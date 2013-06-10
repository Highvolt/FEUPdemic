function createSidebar(){


	

		new GuiControl(sidebar) {
		   canSaveDynamicFields = "0";
		   Profile = "GuiDefaultProfile";   
		   HorizSizing = "right";
		   VertSizing = "bottom";
		   position = "300 0";
		   Extent = "333 640";
		   MinExtent = "333 640";
		   canSave = "1";
		   Visible = "1";
		   hovertime = "1000";
		   isContainer=true;
			new GuiControl() {
			   canSaveDynamicFields = "0";
			   Profile = "GuiMenuProfile";   
			   HorizSizing = "right";
			   VertSizing = "bottom";
			   position = "0 0";
			   Extent = "333 640";
			   MinExtent = "333 640";
			   canSave = "1";
			   Visible = "1";
			   hovertime = "1000";
			   isContainer=true;
			
				 new GuiTextCtrl() {
				   canSaveDynamicFields = "0";
				   Profile = "GuiMenuProfile";   
				   HorizSizing = "right";
				   VertSizing = "bottom";
				   position = "0 0";
				   Extent = "333 70";
				   MinExtent = "2 70";
				   canSave = "1";
				   Visible = "1";
				   hovertime = "1000";
				  // isContainer=true;
				   text="FEUPDEMIC";
				
					 
					
				};

				 new GuiSceneObjectCtrl(wellChart) {
				   canSaveDynamicFields = "0";
				   Profile = "GuiDefaultProfile";   
				   HorizSizing = "right";
				   VertSizing = "bottom";
				   position = "91 75";
				   Extent = "150 150";
				   MinExtent = "2 70";
				   canSave = "1";
				   Visible = "1";
				   hovertime = "1000";
				  // isContainer=true;
				   //text="FEUPDEMIC";
				
					 
					
				};

				new GuiSceneObjectCtrl(infectedChart) {
				   canSaveDynamicFields = "0";
				   Profile = "GuiMenuProfile";   
				   HorizSizing = "right";
				   VertSizing = "bottom";
				   position = "91 75";
				   Extent = "150 150";
				   MinExtent = "2 70";
				   canSave = "1";
				   Visible = "1";
				   hovertime = "1000";
				   //renderMargin=30;
				  // isContainer=true;
				   //text="FEUPDEMIC";
				
					 
					
				};

				new GuiSceneObjectCtrl(deadChart) {
				   canSaveDynamicFields = "0";
				   Profile = "GuiDefaultProfile";   
				   HorizSizing = "right";
				   VertSizing = "bottom";
				   position = "91 75";
				   Extent = "150 150";
				   MinExtent = "2 70";
				   canSave = "1";
				   Visible = "1";
				   hovertime = "1000";
				  // isContainer=true;
				   //text="FEUPDEMIC";
				
					 
					
				};



				new GuiButtonCtrl(){
					 canSaveDynamicFields = "0";
				   Profile = "GuiButtonProfile";   
				   HorizSizing = "right";
				   VertSizing = "bottom";
				   position = "115 580";
				   Extent = "100 40";
				   MinExtent = "2 2";
				   canSave = "1";
				   Visible = "1";
				   hovertime = "1000";
				  // isContainer=true;
				   text="DISEASE";
				};
				
			};
				 
			
		};
	
	Canvas.pushDialog(sidebar);
   

}