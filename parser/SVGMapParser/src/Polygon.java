import java.util.ArrayList;


public class Polygon {
	private ArrayList<Point> points_;
	
	public Polygon() {
		points_ = new ArrayList<>();
	}
	
	public Polygon(ArrayList<Point> points) {
		points_ = points;
	}
	
	public void addPoint(Point point) {
		points_.add(point);
	}
	
	public void addPoint(double x, double y) {
		points_.add(new Point(x, y));
	}
	
	@Override
	public String toString() {
		return points_.toString();
	}

	public String toScript() {
//		StringBuilder xx_coordinates = new StringBuilder("[");
//		StringBuilder yy_coordinates = new StringBuilder("[");
		
		double area = MathHelper.polygonArea(points_);
		double centroid_x = MathHelper.centroidX(points_, area);
		double centroid_y = MathHelper.centroidY(points_, area);
		
//		for (Point point : points_) {
//			xx_coordinates.append(point.x_).append(", ");
//			yy_coordinates.append(point.y_).append(", ");
//		}
//
//		xx_coordinates.deleteCharAt(xx_coordinates.length() - 1);
//		xx_coordinates.setCharAt(xx_coordinates.length() - 1, ']');
//		yy_coordinates.deleteCharAt(yy_coordinates.length() - 1);
//		yy_coordinates.setCharAt(yy_coordinates.length() - 1, ']');
//		
//		return "[" + xx_coordinates.toString() + ", " + yy_coordinates.toString() + "]";
		
		return "\n[ centroid x: " + centroid_x + " centroid y: " + centroid_y + " area: " + area + "]\n";
	}
}
