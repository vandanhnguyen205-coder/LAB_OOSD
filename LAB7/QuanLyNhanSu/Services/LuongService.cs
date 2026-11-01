using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class LuongService
    {
        public DataTable LayBangLuong(int thang, int nam)
        {
            string sql = @"SELECT bl.*, nv.HoTen 
                           FROM BangLuong bl
                           JOIN NhanVien nv ON bl.MaNV = nv.MaNV
                           WHERE bl.Thang = @Thang AND bl.Nam = @Nam";
            return Db.Query(sql, new SqlParameter("@Thang", thang), new SqlParameter("@Nam", nam));
        }

        public bool TinhVaLuuLuong(int thang, int nam)
        {
            // 1. Lay danh sach cham cong thang
            string sqlCC = "SELECT * FROM BangChamCong WHERE Thang=@Thang AND Nam=@Nam";
            var dtCC = Db.Query(sqlCC, new SqlParameter("@Thang", thang), new SqlParameter("@Nam", nam));
            if (dtCC.Rows.Count == 0) return false;

            using (var cn = Db.OpenConnection())
            using (var tran = cn.BeginTransaction())
            {
                try
                {
                    // Xoa bang luong cu neu co
                    string sqlDel = "DELETE FROM BangLuong WHERE Thang=@Thang AND Nam=@Nam";
                    using (var cmdDel = new SqlCommand(sqlDel, cn, tran))
                    {
                        cmdDel.Parameters.AddWithValue("@Thang", thang);
                        cmdDel.Parameters.AddWithValue("@Nam", nam);
                        cmdDel.ExecuteNonQuery();
                    }

                    foreach (DataRow row in dtCC.Rows)
                    {
                        string maNV = row["MaNV"].ToString();
                        int ngayCongChuan = Convert.ToInt32(row["NgayCongChuan"]);
                        double soNgayCong = Convert.ToDouble(row["SoNgayCong"]);

                        // Lương & phụ cấp từ QĐ Lương mới nhất
                        decimal luongCB = 5000000; // default
                        decimal phuCap = 0;
                        string sqlQDL = "SELECT TOP 1 LuongCoBan, (PhuCapLuong + PhuCapDocHai) AS PhuCap FROM QuyetDinhLuong WHERE MaNV=@Ma ORDER BY NgayHieuLuc DESC";
                        using (var cmdQDL = new SqlCommand(sqlQDL, cn, tran))
                        {
                            cmdQDL.Parameters.AddWithValue("@Ma", maNV);
                            using (var dr = cmdQDL.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    luongCB = Convert.ToDecimal(dr["LuongCoBan"]);
                                    phuCap = Convert.ToDecimal(dr["PhuCap"]);
                                }
                            }
                        }

                        // Lương ngày công
                        decimal luongNgayCong = (luongCB + phuCap) * (decimal)(soNgayCong / (ngayCongChuan > 0 ? ngayCongChuan : 26));

                        // Phụ trội (Hệ số 1.5)
                        decimal tienPhuTroi = 0;
                        string sqlPT = @"SELECT ISNULL(SUM(pt.SoGio), 0) 
                                         FROM ChiTietPhuTroi ct
                                         JOIN PhieuPhuTroi pt ON ct.SoPhieu = pt.SoPhieu
                                         WHERE ct.MaNV = @Ma AND MONTH(pt.NgayPhuTroi) = @Thang AND YEAR(pt.NgayPhuTroi) = @Nam";
                        using (var cmdPT = new SqlCommand(sqlPT, cn, tran))
                        {
                            cmdPT.Parameters.AddWithValue("@Ma", maNV);
                            cmdPT.Parameters.AddWithValue("@Thang", thang);
                            cmdPT.Parameters.AddWithValue("@Nam", nam);
                            double gioPT = Convert.ToDouble(cmdPT.ExecuteScalar() ?? 0);
                            decimal luongGio = luongCB / (26 * 8); // QD01: 8h/ngay
                            tienPhuTroi = (decimal)(gioPT * 1.5) * luongGio;
                        }

                        // Trách trừ Bảo hiểm (BHXH 8%, BHYT 1.5% đối với HĐ Dài hạn)
                        decimal khoảnTrừBH = 0;
                        string sqlBH = @"SELECT ISNULL(SUM(TyLeBHXH + TyLeBHYT), 0) 
                                         FROM HoSoBaoHiem bh
                                         JOIN HopDong hd ON bh.MaNV = hd.MaNV
                                         WHERE bh.MaNV=@Ma AND hd.LoaiHD=N'Dài hạn'";
                        using (var cmdBH = new SqlCommand(sqlBH, cn, tran))
                        {
                            cmdBH.Parameters.AddWithValue("@Ma", maNV);
                            double tyLe = Convert.ToDouble(cmdBH.ExecuteScalar() ?? 0);
                            khoảnTrừBH = luongCB * (decimal)tyLe;
                        }

                        // Khen thưởng
                        decimal thuong = 0;
                        string sqlKT = "SELECT ISNULL(SUM(SoTien), 0) FROM QuyetDinhKhenThuong WHERE MaNV=@Ma AND MONTH(NgayQD)=@Thang AND YEAR(NgayQD)=@Nam";
                        using (var cmdKT = new SqlCommand(sqlKT, cn, tran))
                        {
                            cmdKT.Parameters.AddWithValue("@Ma", maNV);
                            cmdKT.Parameters.AddWithValue("@Thang", thang);
                            cmdKT.Parameters.AddWithValue("@Nam", nam);
                            thuong = Convert.ToDecimal(cmdKT.ExecuteScalar() ?? 0);
                        }

                        // Phạt
                        decimal phat = 0;
                        string sqlKL = "SELECT ISNULL(SUM(SoTienPhat), 0) FROM QuyetDinhKyLuat WHERE MaNV=@Ma AND MONTH(NgayQD)=@Thang AND YEAR(NgayQD)=@Nam";
                        using (var cmdKL = new SqlCommand(sqlKL, cn, tran))
                        {
                            cmdKL.Parameters.AddWithValue("@Ma", maNV);
                            cmdKL.Parameters.AddWithValue("@Thang", thang);
                            cmdKL.Parameters.AddWithValue("@Nam", nam);
                            phat = Convert.ToDecimal(cmdKL.ExecuteScalar() ?? 0);
                        }

                        // Thực lĩnh
                        decimal thucLinh = luongNgayCong + tienPhuTroi + thuong - khoảnTrừBH - phat;

                        // Insert BangLuong
                        string sqlIns = @"INSERT INTO BangLuong VALUES(@Ma, @Thang, @Nam, @LCB, @PC, @LNC, @TPT, @Thuong, @BH, @Phat, @TL)";
                        using (var cmdIns = new SqlCommand(sqlIns, cn, tran))
                        {
                            cmdIns.Parameters.AddWithValue("@Ma", maNV);
                            cmdIns.Parameters.AddWithValue("@Thang", thang);
                            cmdIns.Parameters.AddWithValue("@Nam", nam);
                            cmdIns.Parameters.AddWithValue("@LCB", luongCB);
                            cmdIns.Parameters.AddWithValue("@PC", phuCap);
                            cmdIns.Parameters.AddWithValue("@LNC", luongNgayCong);
                            cmdIns.Parameters.AddWithValue("@TPT", tienPhuTroi);
                            cmdIns.Parameters.AddWithValue("@Thuong", thuong);
                            cmdIns.Parameters.AddWithValue("@BH", khoảnTrừBH);
                            cmdIns.Parameters.AddWithValue("@Phat", phat);
                            cmdIns.Parameters.AddWithValue("@TL", thucLinh);
                            cmdIns.ExecuteNonQuery();
                        }
                    }

                    tran.Commit();
                    return true;
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }
    }
}
