    public class CEllipse extends CHinhVe {
        protected CDiem PDiemTam;  // Tâm elip
        protected float PA;        // Bán trục lớn
        protected float PB;        // Bán trục nhỏ

        public CEllipse() {
            super();
            this.PDiemTam = new CDiem();
            this.PA = 0;
            this.PB = 0;
        }

        public CEllipse(int maLoai, CDiem tam, float a, float b) {
            super(maLoai);
            this.PDiemTam = tam;
            this.PA = a;
            this.PB = b;
        }

        // Diện tích elip = π * a * b
        @Override
        public float DienTich() {
            return (float) (Math.PI * PA * PB);
        }

        // Chu vi (công thức gần đúng Ramanujan)
        @Override
        public float ChuVi() {
            return (float) (Math.PI * (3 * (PA + PB) - Math.sqrt((3 * PA + PB) * (PA + 3 * PB))));
        }

        @Override
        public void Ve() {
            System.out.println("Đang ve hinh ELIP:");
            System.out.println("Tâm: (" + PDiemTam.getX() + "," + PDiemTam.getY() + ")");
            System.out.println("Bán trục A = " + PA + ", Bán trục B = " + PB);
        }

        // Getter & Setter
        public CDiem getPDiemTam() { return PDiemTam; }
        public void setPDiemTam(CDiem pDiemTam) { PDiemTam = pDiemTam; }
        public float getPA() { return PA; }
        public void setPA(float PA) { this.PA = PA; }
        public float getPB() { return PB; }
        public void setPB(float PB) { this.PB = PB; }
    }