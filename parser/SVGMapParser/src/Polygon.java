import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.Locale;


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
		DecimalFormat df = new DecimalFormat("#");

		double area = MathHelper.polygonArea(points_);
		double centroid_x = MathHelper.centroidX(points_, area) - SVGMapParser.X_OFFSET;
		double centroid_y = (MathHelper.centroidY(points_, area) - SVGMapParser.Y_OFFSET) * -1;
		
		StringBuilder script = new StringBuilder(df.format(centroid_x / 10) + " " + df.format(centroid_y / 10) + ";");
		
		boolean first = true;
		for (Point point : points_) {
			if (first) {
				first = false;
			} else {
				script.append(" ");
			}
			
			script.append(df.format(point.x - SVGMapParser.X_OFFSET)).append(" ").append(df.format((point.y - SVGMapParser.Y_OFFSET) * -1));
		}
		
		return script.toString();
	}
}
