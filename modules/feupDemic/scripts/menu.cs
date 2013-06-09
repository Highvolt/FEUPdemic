function createSidebar(){
	if(!sidebar){
		new GuiControl(sidebar) {
		   canSaveDynamicFields = "0";
		   Profile = "GuiDefaultProfile";   
		   HorizSizing = "right";
		   VertSizing = "bottom";
		   position = "0 1000";
		   Extent = "1024 768";
		   MinExtent = "8 2";
		   canSave = "1";
		   Visible = "1";
		   hovertime = "1000";
		};
	}

}