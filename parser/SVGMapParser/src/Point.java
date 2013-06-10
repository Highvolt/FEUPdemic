
public class Point {
	public final double x_;
	public final double y_;
	
	public Point(double x, double y) {
		x_ = x;
		y_ = y;
	}
	
	@Override
	public String toString() {
		return "x: " + x_ + " y: " + y_;
	}
}
