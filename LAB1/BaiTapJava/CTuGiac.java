public class CTuGiac extends CHinhVe {
    // 4 đỉnh tứ giác
    protected CDiem PDiemP1;
    protected CDiem PDiemP2;
    protected CDiem PDiemP3;
    protected CDiem PDiemP4;

    public CTuGiac() {
        super();
        this.PDiemP1 = new CDiem();
        this.PDiemP2 = new CDiem();
        this.PDiemP3 = new CDiem();
        this.PDiemP4 = new CDiem();
    }

    public CTuGiac(int maLoai, CDiem p1, CDiem p2, CDiem p3, CDiem p4) {
        super(maLoai);
        this.PDiemP1 = p1;
        this.PDiemP2 = p2;
        this.PDiemP3 = p3;
        this.PDiemP4 = p4;
    }

    // Diện tích (tạm chia thành 2 tam giác)
    @Override
    public float DienTich() {
        CTamGiac tg1 = new CTamGiac(1, PDiemP1, PDiemP2, PDiemP3);
        CTamGiac tg2 = new CTamGiac(1, PDiemP1, PDiemP3, PDiemP4);
        return tg1.DienTich() + tg2.DienTich();
    }

    // Chu vi = tổng độ dài 4 cạnh
    @Override
    public float ChuVi() {
        float c1 = PDiemP1.KhoangCach(PDiemP2);
        float c2 = PDiemP2.KhoangCach(PDiemP3);
        float c3 = PDiemP3.KhoangCach(PDiemP4);
        float c4 = PDiemP4.KhoangCach(PDiemP1);
        return c1 + c2 + c3 + c4;
    }

    @Override
    public void Ve() {
        System.out.println("Đang ve hinh tu giac:");
        System.out.println("P1(" + PDiemP1.getX() + "," + PDiemP1.getY() + ")");
        System.out.println("P2(" + PDiemP2.getX() + "," + PDiemP2.getY() + ")");
        System.out.println("P3(" + PDiemP3.getX() + "," + PDiemP3.getY() + ")");
        System.out.println("P4(" + PDiemP4.getX() + "," + PDiemP4.getY() + ")");
    }

    // Getter & Setter
    public CDiem getPDiemP1() { return PDiemP1; }
    public void setPDiemP1(CDiem pDiemP1) { PDiemP1 = pDiemP1; }
    public CDiem getPDiemP2() { return PDiemP2; }
    public void setPDiemP2(CDiem pDiemP2) { PDiemP2 = pDiemP2; }
    public CDiem getPDiemP3() { return PDiemP3; }
    public void setPDiemP3(CDiem pDiemP3) { PDiemP3 = pDiemP3; }
    public CDiem getPDiemP4() { return PDiemP4; }
    public void setPDiemP4(CDiem pDiemP4) { PDiemP4 = pDiemP4; }
}