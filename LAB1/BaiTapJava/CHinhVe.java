public abstract class CHinhVe {
    protected int MaloaiHinhVe;
    public CHinhVe () {}
    public CHinhVe (int maLoaiHinhVe){
        this.MaloaiHinhVe = maLoaiHinhVe;
    }
    public abstract float DienTich();
    public abstract float ChuVi();
    public abstract void Ve();

    public int getMaLoaiHinhVe (){
        return MaloaiHinhVe;
    }
    public void setMaLoaiHinhVe(int MaLoaiHinhVe){
        MaLoaiHinhVe = MaLoaiHinhVe;
    }
   
}