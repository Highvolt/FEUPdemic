import java.util.ArrayList;

public class Region {
	private int id_;
	private ArrayList<Polygon> polygons_;
	
	public Region(int id) {
		this(id, new ArrayList<Polygon>());
	}
	
	public Region(int id, ArrayList<Polygon> polygons) {
		id_ = id;
		polygons_ = polygons;
	}
	
	public void addPolygon(Polygon polygon) {
		polygons_.add(polygon);
	}
	
	public int getId() {
		return id_;
	}
	
	@Override
	public String toString() {
		return "id: " + id_ + " polygons: " + polygons_.toString();
	}
	
	public String toScript() {
		StringBuilder script = new StringBuilder("createArea(" + id_ + ", \"");
		
		boolean first = true;
		for (Polygon polygon : polygons_) {
			if (first) {
				first = false;
			} else {
				script.append(",");
			}
			script.append(polygon.toScript());
		}
		
		script.append("\");");
		
		return script.toString();
	}
}
