
import java.io.IOException;

import org.dom4j.DocumentException;

public class SVGMapParser {
	public static final String INPUT_FILE = "C:\\Users\\Renato\\Dropbox\\Workspace\\DJCO\\FEUPdemic\\assets\\map\\map-picking.svg";
	public static final String OUTPUT_FILE = "C:\\Users\\Renato\\Dropbox\\Workspace\\DJCO\\FEUPdemic\\modules\\feupDemic\\scripts\\level.cs";
	
	public static final int MAP_WIDTH = 667;
	public static final int MAP_HEIGHT = 640;
	public static final double X_OFFSET = MAP_WIDTH / 2.0;
	public static final double Y_OFFSET = MAP_HEIGHT / 2.0;

	public static void main(String[] args) {
		Parser parser = Parser.getInstance();
		
		try {
			parser.parse(INPUT_FILE);
			parser.write(OUTPUT_FILE);
		} catch (DocumentException e) {
			e.printStackTrace();
			return;
		} catch (IOException e) {
			e.printStackTrace();
		}
		
	}

}
