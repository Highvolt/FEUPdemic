function createSidebar() {
		$bar = new GuiBackgroundCtrl(sidebar) {
		   canSaveDynamicFields = "0";
		   Profile = "GuiMenuProfile";   
		   HorizSizing = "right";
		   VertSizing = "bottom";
		   position = "0 0";
		   Extent = "0 0";
		   MinExtent = "0 0";
		   canSave = "1";
		   Visible = "1";

		   hovertime = "1000";
		   isContainer=true;

		   new GuiControl(wrapper){
			   canSaveDynamicFields = "0";
			   Profile = "GuiDefaultProfile";   
			   HorizSizing = "right";
			   VertSizing = "bottom";
			   position = "-1000 0";
			   Extent = "2000 640";
			   MinExtent = "0 0";
			   canSave = "1";
			   Visible = "1";

			   hovertime = "1000";
			   isContainer=true;

			   new SceneWindow(mySceneWindow){
					Profile = GuiDefaultProfile;
					position = "1333 0";
					Extent = "667 640";
			   };


				new GuiControl(menu) {
				   canSaveDynamicFields = "0";
				   Profile = "GuiMenuProfile";   
				   HorizSizing = "right";
				   VertSizing = "bottom";
				   position = "1000 0";
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
						Extent = "333 50";
						canSave = "1";
						Visible = "1";
						hovertime = "1000";
						text="Bloco B";
					};

					 new GuiSceneObjectCtrl(wellChart) {
					   canSaveDynamicFields = "0";
					   Profile = "GuiDefaultProfile";   
					   HorizSizing = "right";
					   VertSizing = "bottom";
					   position = "91 50";
					   Extent = "150 150";
					   MinExtent = "2 70";
					   canSave = "1";
					   Visible = "1";
					   hovertime = "1000";
					};

					new GuiSceneObjectCtrl(infectedChart) {
					   canSaveDynamicFields = "0";
					   Profile = "GuiMenuProfile";   
					   HorizSizing = "right";
					   VertSizing = "bottom";
					   position = "91 50";
					   Extent = "150 150";
					   MinExtent = "2 70";
					   canSave = "1";
					   Visible = "1";
					   hovertime = "1000";
					};

					new GuiSceneObjectCtrl(deadChart) {
					   canSaveDynamicFields = "0";
					   Profile = "GuiDefaultProfile";   
					   HorizSizing = "right";
					   VertSizing = "bottom";
					   position = "91 50";
					   Extent = "150 150";
					   MinExtent = "2 70";
					   canSave = "1";
					   Visible = "1";
					   hovertime = "1000";
					};

					 new GuiControl() {
					   canSaveDynamicFields = "0";
					   Profile = "GuiLogProfile";   
					   HorizSizing = "right";
					   VertSizing = "bottom";
					   position = "2 250";
					   Extent = "329 50";
					   MinExtent = "2 50";
					   canSave = "1";
					   Visible = "1";
					   hovertime = "1000";
					   isContainer=true;
					
						new GuiTextCtrl() {
						   canSaveDynamicFields = "0";
						   Profile = "GuiLogProfile";   
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "0 0";
						   Extent = "320 50";
						   MinExtent = "2 4";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						   text="Log";
						};
						
					};

					new GuiTextCtrl(LogClick) {   ////TODO REMOVE
						   canSaveDynamicFields = "0";
						   Profile = "GuiLogProfile";   
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "0 310";
						   Extent = "323 50";
						   MinExtent = "2 4";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						   text="";	
					};

					/*
					 * Infectivity
					 */
					new GuiTextCtrl() {
						   canSaveDynamicFields = "0";
						   Profile = "GuiBarLabelProfile";   
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "45 365";
						   Extent = "320 50";
						   MinExtent = "2 4";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						   text="Infectivity";
					};

					new GuiSpriteCtrl(infectivity_bar) {
						canSaveDynamicFields = "0";
						Profile = "GuiBarProfile";
						HorizSizing = "right";
						VertSizing = "bottom";
						position = "45 400";
						Extent = "243 22";
						MinExtent = "0 0";
						canSave = "1";
						Visible = "1";
						Image="feupDemic:bar";
					};

					/*
					 * Severity
					 */
					new GuiTextCtrl() {
						   canSaveDynamicFields = "0";
						   Profile = "GuiBarLabelProfile";   
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "45 415";
						   Extent = "320 50";
						   MinExtent = "2 4";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						   text="Severity";
					};

					new GuiSpriteCtrl(severity_bar) {
						canSaveDynamicFields = "0";
						Profile = "GuiBarProfile";
						HorizSizing = "right";
						VertSizing = "bottom";
						position = "45 450";
						Extent = "243 22";
						MinExtent = "0 0";
						canSave = "1";
						Visible = "1";
						Image="feupDemic:bar";
					};

					/*
					 * Lethality
					 */
					new GuiTextCtrl() {
						   canSaveDynamicFields = "0";
						   Profile = "GuiBarLabelProfile";   
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "45 465";
						   Extent = "320 50";
						   MinExtent = "2 4";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						   text="Lethality";
					};

					new GuiSpriteCtrl(lethality_bar) {
						canSaveDynamicFields = "0";
						Profile = "GuiBarProfile";
						HorizSizing = "right";
						VertSizing = "bottom";
						position = "45 500";
						Extent = "243 22";
						MinExtent = "0 0";
						canSave = "1";
						Visible = "1";
						Image="feupDemic:bar";
					};

					/*
					 * DNA
					 */
					new GuiTextCtrl() {
						   canSaveDynamicFields = "0";
						   Profile = "GuiDnaBarLabelProfile";
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "80 528";
						   Extent = "100 50";
						   MinExtent = "2 4";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						   text="DNA";
					};

					new GuiSpriteCtrl(dna_bar) {
						canSaveDynamicFields = "0";
						Profile = "GuiBarProfile";
						HorizSizing = "right";
						VertSizing = "bottom";
						position = "45 535";
						Extent = "243 38";
						MinExtent = "0 0";
						canSave = "1";
						Visible = "1";
						Image="feupDemic:dna_bar";
					};

					new GuiButtonCtrl(){
						 canSaveDynamicFields = "0";
					   Profile = "GuiButtonProfile";   
					   HorizSizing = "right";
					   VertSizing = "bottom";
					   position = "115 600";
					   Extent = "100 50";
					   MinExtent = "2 2";
					   canSave = "1";
					   Visible = "1";
					   hovertime = "1000";
					  // isContainer=true;
					   text="MENU";
					   Command="menuVisible(1);";
					};
					
				};

				new GuiControl(menuOverlay) {
				   canSaveDynamicFields = "0";
				   Profile = "GuiMenuProfile";   
				   HorizSizing = "right";
				   VertSizing = "bottom";
				   position = "0 0";
				   Extent = "1000 640";
				   MinExtent = "333 640";
				   canSave = "1";
				   Visible = "1";
				   hovertime = "1000";
				   isContainer=true;
				   new GuiButtonCtrl(){
						 canSaveDynamicFields = "0";
					   Profile = "GuiLeftButtonProfile";   
					   HorizSizing = "right";
					   VertSizing = "bottom";
					   position = "230 100";
					   Extent = "180 40";
					   MinExtent = "2 2";
					   canSave = "1";
					   Visible = "1";
					   hovertime = "1000";
					   text="TRANSMISSION";
					   Command="changeToTab(1);";
					};
					new GuiButtonCtrl(){
						 canSaveDynamicFields = "0";
					   Profile = "GuiMiddleButtonProfile";   
					   HorizSizing = "right";
					   VertSizing = "bottom";
					   position = "410 100";
					   Extent = "180 40";
					   MinExtent = "2 2";
					   canSave = "1";
					   Visible = "1";
					   hovertime = "1000";
					  // isContainer=true;
					   text="SYMPTOMS";
						Command="changeToTab(2);";
					};
					new GuiButtonCtrl(){
						 canSaveDynamicFields = "0";
					   Profile = "GuiRightButtonProfile";   
					   HorizSizing = "right";
					   VertSizing = "bottom";
					   position = "590 100";
					   Extent = "180 40";
					   MinExtent = "2 2";
					   canSave = "1";
					   Visible = "1";
					   hovertime = "1000";
					  // isContainer=true;
					   text="RESISTANCE";
						Command="changeToTab(3);";
					};

					new GuiControl() {
					   canSaveDynamicFields = "0";
					   Profile = "GuiDefaultProfile";   
					   HorizSizing = "right";
					   VertSizing = "bottom";
					   position = "200 150";
					   Extent = "600 400";
					   MinExtent = "2 2";
					   canSave = "1";
					   Visible = "1";
					   hovertime = "1000";
					   isContainer=true;
						   new GuiControl(transmissionTab) {
							   canSaveDynamicFields = "0";
							   Profile = "GuiDefaultProfile";   
							   HorizSizing = "right";
							   VertSizing = "bottom";
							   position = "0 0";
							   Extent = "600 400";
							   MinExtent = "2 2";
							   canSave = "1";
							   Visible = "1";
							   hovertime = "1000";
							   isContainer = true;

							  new GuiTextCtrl() {  
								  canSaveDynamicFields = "0";
								  Profile = "GuiLogProfile";   
								  HorizSizing = "right";
								  VertSizing = "bottom";
								  position = "0 0";
								  Extent = "323 50";
								  MinExtent = "2 4";
								  canSave = "1";
								  Visible = "1";
								  hovertime = "1000";
								  text="1";
								};
						   
							};
							 new GuiControl(symptomsTab) {
							   canSaveDynamicFields = "0";
							   Profile = "GuiDefaultProfile";   
							   HorizSizing = "right";
							   VertSizing = "bottom";
							   position = "0 0";
							   Extent = "600 400";
							   MinExtent = "2 2";
							   canSave = "1";
							   Visible = "0";
							   hovertime = "1000";
							   isContainer=true;
							   new GuiTextCtrl() {  
								   canSaveDynamicFields = "0";
								   Profile = "GuiLogProfile";   
								   HorizSizing = "right";
								   VertSizing = "bottom";
								   position = "0 0";
								   Extent = "323 50";
								   MinExtent = "2 4";
								   canSave = "1";
								   Visible = "1";
								   hovertime = "1000";
								  // isContainer=true;
								   text="2";
								
									 
									
								};
						   
							};
							new GuiControl(resistenceTab) {
							   canSaveDynamicFields = "0";
							   Profile = "GuiDefaultProfile";   
							   HorizSizing = "right";
							   VertSizing = "bottom";
							   position = "0 0";
							   Extent = "600 400";
							   MinExtent = "2 2";
							   canSave = "1";
							   Visible = "0";
							   hovertime = "1000";
							   isContainer=true;
							   new GuiTextCtrl() {  
								   canSaveDynamicFields = "0";
								   Profile = "GuiLogProfile";   
								   HorizSizing = "right";
								   VertSizing = "bottom";
								   position = "0 0";
								   Extent = "323 50";
								   MinExtent = "2 4";
								   canSave = "1";
								   Visible = "1";
								   hovertime = "1000";
								  // isContainer=true;
								   text="3";
								
									 
									
								};
						   
							};
					};

					new GuiButtonCtrl(){
						 canSaveDynamicFields = "0";
					   Profile = "GuiButtonProfile";   
					   HorizSizing = "right";
					   VertSizing = "bottom";
					   position = "740 600";
					   Extent = "150 50";
					   MinExtent = "2 2";
					   canSave = "1";
					   Visible = "1";
					   hovertime = "1000";
					  // isContainer=true;
					   text="BACK";
					   Command="menuVisible(0);";
					};
				};
			};	 
			
		};
	
	Canvas.pushDialog(sidebar);

	new SimObject(timerXPTO);


}


function menuVisible(%state){
	if(menuOverlay.Visible$="1" && %state==0){
		timerXPTO.startTimer(hideOverlay, 2.5);
	}else{
		timerXPTO.startTimer(showOverlay, 2.5);
	}
}

function timerXPTO::hideOverlay(){
	%dir=-1;
	if(%dir<0){
		//echo(getWord(menuOverlay.Position,0));
		if(getWord(wrapper.Position,0)<=-1000){

			timerXPTO.it=0;
			timerXPTO.stopTimer();
			wrapper.Position="-1000 0";
		}else{
			%v=-10*mSin(timerXPTO.it/250 * (3.1415/2));
			wrapper.Position=Vector2Add(wrapper.Position,%v SPC "0");
			/*menuOverlay.Position=Vector2Add(menuOverlay.Position,%v SPC "0");
			menu.Position=Vector2Add(menu.Position,%v SPC "0");
			mySceneWindow.Position=Vector2Add(mySceneWindow.Position,%v SPC "0");*/
			timerXPTO.it++;
			//timerXPTO.startTimer(moveOverlay(-1), 100,true);
			//return moveOverlay(-1);
			//return moveOverlay(-1);
		}
	}
}

timerXPTO.it=0;

function timerXPTO::showOverlay(){
	%dir=1;
	if(%dir>0){

		//echo(getWord(menuOverlay.Position,0));
		if(getWord(wrapper.Position,0)>=0){
			timerXPTO.it=0;
			timerXPTO.stopTimer();
			wrapper.Position="0 0";
		}else{
			%v=	10*mSin(timerXPTO.it/250 * (3.1415/2));
			wrapper.Position=Vector2Add(wrapper.Position,%v SPC "0");/*
			%before=menuOverlay.Position;
			menuOverlay.Position=Vector2Add(menuOverlay.Position,%v SPC "0");
			echo(Vector2Sub(menuOverlay.Position,%before));
			%before=menu.Position;
			menu.Position=Vector2Add(menu.Position,%v SPC "0");
			echo(Vector2Sub(menu.Position,%before));
			%before=mySceneWindow.Position;
			mySceneWindow.Position=Vector2Add(mySceneWindow.Position,%v SPC "0");
			echo(Vector2Sub(mySceneWindow.Position,%before));*/
			timerXPTO.it++;

		}
	}
}


function changeToTab(%page){
	switch(%page){
		case 1:
			transmissionTab.Visible="1";
			symptomsTab.Visible="0";
			resistenceTab.Visible="0";
		case 2:
			transmissionTab.Visible="0";
			symptomsTab.Visible="1";
			resistenceTab.Visible="0";
		case 3:
			transmissionTab.Visible="0";
			symptomsTab.Visible="0";
			resistenceTab.Visible="1";

	}
}