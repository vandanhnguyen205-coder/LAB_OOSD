public class Main {
    public static void main(String[] args) {
        // Tạo đối tượng tam giác
        CDiem p1 = new CDiem(0, 0);
        CDiem p2 = new CDiem(0, 3);
        CDiem p3 = new CDiem(4, 0);
        CTamGiac tg = new CTamGiac(1, p1, p2, p3);
        
        System.out.println("=== TAM GIÁC ===");
        tg.Ve();
        System.out.println("Dien tích: " + tg.DienTich());
        System.out.println("Chu vi: " + tg.ChuVi() + "\n");

        // Tạo đối tượng elip
        CDiem tam = new CDiem(5, 5);
        CEllipse elip = new CEllipse(3, tam, 6, 4);
        
        System.out.println("=== ELIP ===");
        elip.Ve();
        System.out.println("Dien tích: " + elip.DienTich());
        System.out.println("Chu vi: " + elip.ChuVi());
    }
}