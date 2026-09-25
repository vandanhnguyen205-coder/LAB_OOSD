public class CDiem {
    private float x;
    private float y;

    public CDiem (){this(0,0); }
    public CDiem (float x, float y) {
        this.x = x;
        this.y = y;
    } 
    public float KhoangCach (CDiem d){
        return (float) Math.sqrt(Math.pow(this.x - d.x, 2) + Math.pow(this.y-d.y, 2));
    }
    public float getX(){
        return x;
    }
    public float getY(){
        return y;
    }
    public void setX(float x){
        this.x = x;
    }
    public void setY(float y){
        this.y = y;
    }
}
