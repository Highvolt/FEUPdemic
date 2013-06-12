import java.util.ArrayList;


public class MathHelper {
	public static double polygonArea(ArrayList<Point> points) {
		double area, sum = 0.0;
		
		int i;
		for (i = 0; i < points.size() - 1; ++i) {
			sum += (points.get(i).x * points.get(i + 1).y - points.get(i + 1).x * points.get(i).y);
		}
		
		sum += (points.get(i).x * points.get(0).y - points.get(0).x * points.get(i).y);
		
		area = sum / 2.0;
		
		return area;
	}
	
	public static double centroidX(ArrayList<Point> points, double area) {
		double centroid, sum = 0.0;
		
		int i;
		for (i = 0; i < points.size() - 1; ++i) {
			sum += ((points.get(i).x + points.get(i + 1).x) * (points.get(i).x * points.get(i + 1).y - points.get(i + 1).x * points.get(i).y));
		}
		
		sum += ((points.get(i).x + points.get(0).x) * (points.get(i).x * points.get(0).y - points.get(0).x * points.get(i).y));
		
		centroid = (1.0 / (6.0 * area)) * sum;
		
		return centroid;
	}
	
	public static double centroidY(ArrayList<Point> points, double area) {
		double centroid, sum = 0.0;
		
		int i;
		for (i = 0; i < points.size() - 1; ++i) {
			sum += ((points.get(i).y + points.get(i + 1).y) * (points.get(i).x * points.get(i + 1).y - points.get(i + 1).x * points.get(i).y));
		}
		
		sum += ((points.get(i).y + points.get(0).y) * (points.get(i).x * points.get(0).y - points.get(0).x * points.get(i).y));
		
		centroid = (1.0 / (6.0 * area)) * sum;
		
		return centroid;
	}
}
