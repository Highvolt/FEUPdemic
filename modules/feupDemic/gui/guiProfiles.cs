$platformFontType = ($platform $= "windows") ? "Minecraftia" : "Minecraftia";
$platformFontSize = ($platform $= "ios") ? 18 : 12;

if(!isObject(GuiDefaultProfile)) new GuiControlProfile (GuiDefaultProfile) {
	 // font
    tab = false;
    canKeyFocus = false;
    hasBitmapArray = false;
    mouseOverSelected = false;

    // fill color
    opaque = false;
    fillColor = "211 211 211";
    fillColorHL = "244 244 244";
    fillColorNA = "244 244 244";

    // border color
    border = 0;
    borderColor   = "100 100 100 255";
    borderColorHL = "128 128 128";
    borderColorNA = "64 64 64";

    // font
    fontType = $platformFontType;
    fontSize = $platformFontSize;

    fontColor = "0 0 0";
    fontColorHL = "32 100 100";
    fontColorNA = "0 0 0";
    fontColorSEL= "10 10 10";

    // bitmap information
    //bitmap = "^Sandbox/gui/images/window.png";
    //bitmapBase = "";
    //textOffset = "0 0";

    // used by guiTextControl
    modal = true;
    justify = "left";
    autoSizeWidth = false;
    autoSizeHeight = false;
    returnTab = false;
    numbersOnly = false;
    cursorColor = "0 0 0 255";
    
    
};  

new GuiControlProfile (GuiMenuProfile) {
     // font
    fontType = $platformFontType;
    fontSize =24;
    
    /*fillColor="64 64 64";
    fillColorHL="0 0 0";
    fillColorNA="0 0 0";*/

    opaque = false;
     
    border = -2;

     bitmap = "^feupDemic/gui/images/gray_frame.png";
    // hasBitmapArray = true;
    fontColor = "255 255 255";
    fontColorHL = "32 100 100";
    fontColorNA = "0 0 0";
    fontColorSEL= "10 10 10";
    //opaque=1;
     // used by guiTextControl
    modal = true;
    justify = "center";
    autoSizeWidth = false;
    autoSizeHeight = false;
    returnTab = false;
    numbersOnly = false;
    cursorColor = "0 0 0 255";
    
    
};  

new GuiControlProfile (GuiHexProfile) {
     // font
    fontType = $platformFontType;
    fontSize =24;
    
    /*fillColor="64 64 64";
    fillColorHL="0 0 0";
    fillColorNA="0 0 0";*/

    opaque = false;
     
    border = -2;

     bitmap = "^feupDemic/gui/images/hexagonal_grid.png";
    // hasBitmapArray = true;
    fontColor = "255 255 255";
    fontColorHL = "32 100 100";
    fontColorNA = "0 0 0";
    fontColorSEL= "10 10 10";
    //opaque=1;
     // used by guiTextControl
    modal = true;
    justify = "center";
    autoSizeWidth = false;
    autoSizeHeight = false;
    returnTab = false;
    numbersOnly = false;
    cursorColor = "0 0 0 255";
    
    
};  

new GuiControlProfile(GuiBarProfile) {  
    opaque = 1;
     border=0;

     //bitmap = "^feupDemic/gui/images/bar.png";
     

    modal = true;
    autoSizeWidth = false;
    autoSizeHeight = false;
    returnTab = false;
    numbersOnly = false;
    cursorColor = "0 0 0 255";
};

new GuiControlProfile (GuiButtonProfile){
    fontType = $platformFontType;
    fontSize = 16;

    bitmap = "^feupDemic/gui/images/redButton.png";

    fontColor = "255 255 255";
    fontColorHL = "255 255 255";
    fontColorNA = "0 0 0";
    fontColorSEL= "10 10 10";
    opaque = 1;
     
    modal = true;
    justify = "center";
    autoSizeWidth = false;
    autoSizeHeight = false;
    returnTab = false;
    numbersOnly = false;
    cursorColor = "0 0 0 255";
};  

new GuiControlProfile (GuiLeftButtonProfile){
    fontType = $platformFontType;
    fontSize = 16;

    bitmap = "^feupDemic/gui/images/red_button_left.png";

    fontColor = "255 255 255";
    fontColorHL = "255 255 255";
    fontColorNA = "0 0 0";
    fontColorSEL= "10 10 10";
    opaque = 1;
     
    modal = true;
    justify = "center";
    autoSizeWidth = false;
    autoSizeHeight = false;
    returnTab = false;
    numbersOnly = false;
    cursorColor = "0 0 0 255";
};  

new GuiControlProfile (GuiRightButtonProfile){
    fontType = $platformFontType;
    fontSize = 16;

    bitmap = "^feupDemic/gui/images/red_button_right.png";

    fontColor = "255 255 255";
    fontColorHL = "255 255 255";
    fontColorNA = "0 0 0";
    fontColorSEL= "10 10 10";
    opaque = 1;
     
    modal = true;
    justify = "center";
    autoSizeWidth = false;
    autoSizeHeight = false;
    returnTab = false;
    numbersOnly = false;
    cursorColor = "0 0 0 255";
};

new GuiControlProfile (GuiMiddleButtonProfile){
    fontType = $platformFontType;
    fontSize = 16;

    bitmap = "^feupDemic/gui/images/red_button_middle.png";

    fontColor = "255 255 255";
    fontColorHL = "255 255 255";
    fontColorNA = "0 0 0";
    fontColorSEL= "10 10 10";
    opaque = 1;
     
    modal = true;
    justify = "center";
    autoSizeWidth = false;
    autoSizeHeight = false;
    returnTab = false;
    numbersOnly = false;
    cursorColor = "0 0 0 255";
};  

new GuiControlProfile (GuiLogProfile){
     // font
    fontType = $platformFontType;
    fontSize =16;
    
    /*fillColor="27 33 27";
    fillColorHL="0 0 0";
    fillColorNA="0 0 0";*/

    opaque = false;
     
    border = 0;

     //bitmap = "^feupDemic/gui/images/gray_button.png";
    // hasBitmapArray = true;
    fontColor = "255 255 255";
    fontColorHL = "32 100 100";
    fontColorNA = "0 0 0";
    fontColorSEL= "10 10 10";
    //opaque=1;
     // used by guiTextControl
    modal = true;
    justify = "left";
    autoSizeWidth = false;
    autoSizeHeight = false;
    returnTab = false;
    numbersOnly = false;
    cursorColor = "0 0 0 255";
    
    
}; 


new GuiControlProfile (Gui18Profile){
     // font
    fontType = $platformFontType;
    fontSize =18;
    
    /*fillColor="27 33 27";
    fillColorHL="0 0 0";
    fillColorNA="0 0 0";*/

    opaque = false;
     
    border = 0;

     //bitmap = "^feupDemic/gui/images/gray_button.png";
    // hasBitmapArray = true;
    fontColor = "255 255 255";
    fontColorHL = "32 100 100";
    fontColorNA = "0 0 0";
    fontColorSEL= "10 10 10";
    //opaque=1;
     // used by guiTextControl
    modal = true;
    justify = "left";
    autoSizeWidth = false;
    autoSizeHeight = false;
    returnTab = false;
    numbersOnly = false;
    cursorColor = "0 0 0 255";
    
    
};  

new GuiControlProfile (GuiTitleProfile){
     // font
    fontType = $platformFontType;
    fontSize =14;
    
    /*fillColor="27 33 27";
    fillColorHL="0 0 0";
    fillColorNA="0 0 0";*/

    opaque = false;
     
    border = 0;

     //bitmap = "^feupDemic/gui/images/gray_button.png";
    // hasBitmapArray = true;
    fontColor = "0 0 0";
    fontColorHL = "32 100 100";
    fontColorNA = "0 0 0";
    fontColorSEL= "10 10 10";
    //opaque=1;
     // used by guiTextControl
    modal = true;
    justify = "left";
    autoSizeWidth = false;
    autoSizeHeight = false;
    returnTab = false;
    numbersOnly = false;
    cursorColor = "0 0 0 255";
    
    
};  

new GuiControlProfile (GuiBarLabelProfile) {
    fontType = $platformFontType;
    fontSize = 16;
    
    fillColor="27 33 27";
    fillColorHL="0 0 0";
    fillColorNA="0 0 0";

    opaque = 1;
 
    border = 0;

    fontColor = "27 33 27";
    modal = true;
    justify = "left";
    autoSizeWidth = false;
    autoSizeHeight = false;
    returnTab = false;
    numbersOnly = false;
    cursorColor = "0 0 0 255";
    
    
};  

new GuiControlProfile (GuiDnaBarLabelProfile) {
    fontType = $platformFontType;
    fontSize = 24;
    
    fillColor="255 255 255";
    fillColorHL="0 0 0";
    fillColorNA="0 0 0";

    opaque = 1;
 
    border = 0;

    fontColor = "255 255 255";
    modal = true;
    justify = "left";
    autoSizeWidth = false;
    autoSizeHeight = false;
    returnTab = false;
    numbersOnly = false;
    cursorColor = "0 0 0 255";
    
    
};  

