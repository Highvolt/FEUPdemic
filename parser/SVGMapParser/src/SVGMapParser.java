
import org.dom4j.DocumentException;

public class SVGMapParser {
	public static final String INPUT_FILE = "C:\\Users\\Renato\\Dropbox\\Workspace\\DJCO\\FEUPdemic\\assets\\map\\map-picking.svg";
	public static final String OUTPUT_FILE = "";

	public static void main(String[] args) {
		Parser parser = Parser.getInstance();
		
		try {
			parser.parse(INPUT_FILE);
			parser.write(OUTPUT_FILE);
		} catch (DocumentException e) {
			e.printStackTrace();
			return;
		}
		
	}

}