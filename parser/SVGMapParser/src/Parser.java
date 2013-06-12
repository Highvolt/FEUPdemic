import java.io.File;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

import org.dom4j.Document;
import org.dom4j.DocumentException;
import org.dom4j.DocumentHelper;
import org.dom4j.Node;
import org.dom4j.XPath;
import org.dom4j.io.SAXReader;


public class Parser {
	private static Parser parser_ = new Parser();
	
	private Document document_;
	private ArrayList<Region> regions_;
	
	public static Parser getInstance() {
		return parser_;
	}
	
	public void parse(String path) throws DocumentException {
		File xml = new File(path);
		SAXReader reader = new SAXReader();
		document_ = reader.read(xml);
		
		regions_ = importRegions();
	}
	
	public void write(String path) {
		if (regions_ == null) {
			throw new NullPointerException();
		}
		
		for (Region region : regions_) {
			System.out.println(region.toScript());
		}
	}
	
	private ArrayList<Region> importRegions() throws DocumentException {
		ArrayList<Region> regions = new ArrayList<Region>();
		
		Map<String, String> namespace_uris = new HashMap<String, String>();
		namespace_uris.put("svg", "http://www.w3.org/2000/svg");
		XPath groups = DocumentHelper.createXPath("//svg:g");
		groups.setNamespaceURIs(namespace_uris);
		
		XPath shapes = DocumentHelper.createXPath("svg:polygon | svg:rect");
		shapes.setNamespaceURIs(namespace_uris);
		
		List<Node> region_nodes = groups.selectNodes(document_);
		
		Iterator<Node> iterator = region_nodes.iterator();

		String id;
		while (iterator.hasNext()) {
			Node group = iterator.next();
			id = group.valueOf("@id");
			
			Region region = new Region(Integer.parseInt(id.substring(1)));
			
			List<Node> shapes_nodes = shapes.selectNodes(group);
			Iterator<Node> shapes_iterator = shapes_nodes.iterator();
			while (shapes_iterator.hasNext()) {
				Node shape = shapes_iterator.next();
				String node_name = shape.getName();
				ArrayList<Point> points = new ArrayList<Point>();
				if ("polygon".equals(node_name)) {
					String[] points_array = shape.valueOf("@points").split("(\\s*,\\s*)|\\s+");
					
					for (int i = 0; i < points_array.length; i = i + 2) {
						points.add(new Point(Double.valueOf(points_array[i]),
								Double.valueOf(points_array[i + 1])));
					}
				} else if ("rect".equals(node_name)) {
					double x = Double.valueOf(shape.valueOf("@x"));
					double y = Double.valueOf(shape.valueOf("@y"));
					double width = Double.valueOf(shape.valueOf("@width"));
					double height = Double.valueOf(shape.valueOf("@height"));
					
					points.add(new Point(x, y));
					points.add(new Point(x + width, y));
					points.add(new Point(x + width, y + height));
					points.add(new Point(x, y + height));
				} else {
					throw new DocumentException();
				}
				
				Polygon polygon = new Polygon(points);
				region.addPolygon(polygon);
			}
			regions.add(region);
		}
				
		return regions;
	}
}
