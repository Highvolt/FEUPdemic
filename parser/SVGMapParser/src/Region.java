import java.util.ArrayList;

public class Region {
	private String id_;
	private ArrayList<Polygon> polygons_;
	
	public Region(String id) {
		this(id, new ArrayList<Polygon>());
	}
	
	public Region(String id, ArrayList<Polygon> polygons) {
		id_ = id;
		polygons_ = polygons;
	}
	
	public void addPolygon(Polygon polygon) {
		polygons_.add(polygon);
	}
	
	public String getId() {
		return id_;
	}
	
	@Override
	public String toString() {
		return "id: " + id_ + " polygons: " + polygons_.toString();
	}
	
	public String toScript() {
		String script = "createArea(\"" + id_ + "\", ";
		
		for (Polygon polygon : polygons_) {
			script += polygon.toScript();
		}
		
		script += ");";
		return script;
	}
}
