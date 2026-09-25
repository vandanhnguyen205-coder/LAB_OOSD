public class CTamGiac extends CHinhVe {
    // 3 đỉnh tam giác
    protected CDiem PDiemP1;
    protected CDiem PDiemP2;
    protected CDiem PDiemP3;

    // Constructor
    public CTamGiac() {
        super();
        this.PDiemP1 = new CDiem();
        this.PDiemP2 = new CDiem();
        this.PDiemP3 = new CDiem();
    }

    public CTamGiac(int maLoai, CDiem p1, CDiem p2, CDiem p3) {
        super(maLoai);
        this.PDiemP1 = p1;
        this.PDiemP2 = p2;
        this.PDiemP3 = p3;
    }

    // Tính diện tích theo công thức Heron
    @Override
    public float DienTich() {
        float a = PDiemP1.KhoangCach(PDiemP2);
        float b = PDiemP2.KhoangCach(PDiemP3);
        float c = PDiemP3.KhoangCach(PDiemP1);
        float p = (a + b + c) / 2;
        return (float) Math.sqrt(p * (p - a) * (p - b) * (p - c));
    }

    // Tính chu vi
    @Override
    public float ChuVi() {
        float a = PDiemP1.KhoangCach(PDiemP2);
        float b = PDiemP2.KhoangCach(PDiemP3);
        float c = PDiemP3.KhoangCach(PDiemP1);
        return a + b + c;
    }

    // Phương thức vẽ (chỉ in ra màn hình)
    @Override
    public void Ve() {
        System.out.println("Đang ve hinh tam giac ba dinh:");
        System.out.println("P1(" + PDiemP1.getX() + "," + PDiemP1.getY() + ")");
        System.out.println("P2(" + PDiemP2.getX() + "," + PDiemP2.getY() + ")");
        System.out.println("P3(" + PDiemP3.getX() + "," + PDiemP3.getY() + ")");
    }

    // Getter & Setter
    public CDiem getPDiemP1() { return PDiemP1; }
    public void setPDiemP1(CDiem pDiemP1) { PDiemP1 = pDiemP1; }
    public CDiem getPDiemP2() { return PDiemP2; }
    public void setPDiemP2(CDiem pDiemP2) { PDiemP2 = pDiemP2; }
    public CDiem getPDiemP3() { return PDiemP3; }
    public void setPDiemP3(CDiem pDiemP3) { PDiemP3 = pDiemP3; }
}