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
		double area = MathHelper.polygonArea(points_);
		double centroid_x = MathHelper.centroidX(points_, area);
		double centroid_y = MathHelper.centroidY(points_, area);
		
		StringBuilder script = new StringBuilder(centroid_x + " " + centroid_y + ";");
		
		boolean first = true;
		for (Point point : points_) {
			if (first) {
				first = false;
			} else {
				script.append(" ");
			}
			script.append(point.x - SVGMapParser.X_OFFSET).append(" ").append((point.y - SVGMapParser.Y_OFFSET) * -1);
		}
		
		return script.toString();
	}
}
