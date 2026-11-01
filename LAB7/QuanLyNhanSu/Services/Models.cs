namespace QuanLyNhanSu.Services {
    public class KetQuaXuLy {
        public bool ThanhCong { get; private set; }
        public string ThongBao { get; private set; }
        public static KetQuaXuLy Ok(string s) { return new KetQuaXuLy { ThanhCong=true, ThongBao=s }; }
        public static KetQuaXuLy Fail(string s) { return new KetQuaXuLy { ThanhCong=false, ThongBao=s }; }
    }
    public static class QuyDinh {
        public const decimal GioChuanMoiNgay=8m, HeSoPhuTroi=1.5m;
        public const string ThuViec="Thử việc", ChinhThuc="Chính thức", NghiViec="Nghỉ việc";
        public const string DaiHan="DAIHAN", NganHan="NGANHAN", CaNhan="CANHAN", TapThe="TAPTHE";
    }
}