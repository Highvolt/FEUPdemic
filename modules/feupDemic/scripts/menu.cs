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

					new GuiTextCtrl(ZoneName) {
						canSaveDynamicFields = "0";
						Profile = "GuiMenuProfile";
						HorizSizing = "right";
						VertSizing = "bottom";
						position = "0 0";
						Extent = "333 50";
						canSave = "1";
						Visible = "1";
						hovertime = "1000";
						text="FEUP";
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
					   Profile = "GuiDefaultProfile";   
					   HorizSizing = "right";
					   VertSizing = "bottom";
					   position = "2 210";
					   Extent = "329 200";
					   MinExtent = "2 50";
					   canSave = "1";
					   Visible = "1";
					   hovertime = "1000";
					   isContainer=true;
							new GuiControl() {
							   canSaveDynamicFields = "0";
							   Profile = "GuiDefaultProfile";   
							   HorizSizing = "right";
							   VertSizing = "bottom";
							   position = "60 0";
							   Extent = "250 30";
							   MinExtent = "2 2";
							   canSave = "1";
							   Visible = "1";
							   hovertime = "1000";
							   isContainer=true;

							   new GuiBitmapCtrl() {
								   canSaveDynamicFields = "0";
								   Profile = "GuiDefaultProfile";   
								   HorizSizing = "right";
								   VertSizing = "bottom";
								   position = "25 5";
								   Extent = "20 20";
								   MinExtent = "0 0";
								   canSave = "1";
								   Visible = "1";
								   hovertime = "1000";
								   bitmap = "^feupDemic/gui/images/heart.png";
								   //isContainer=true;
							};

							   new GuiTextCtrl(wellText) {
								   canSaveDynamicFields = "0";
								   Profile = "GuiLogProfile";   
								   HorizSizing = "right";
								   VertSizing = "bottom";
								   position = "50 0";
								   Extent = "250 30";
								   MinExtent = "2 4";
								   canSave = "1";
								   Visible = "1";
								   hovertime = "1000";
								   text="0";
								};

							};
							new GuiControl() {
							   canSaveDynamicFields = "0";
							   Profile = "GuiDefaultProfile";   
							   HorizSizing = "right";
							   VertSizing = "bottom";
							   position = "60 23";
							   Extent = "250 30";
							   MinExtent = "2 2";
							   canSave = "1";
							   Visible = "1";
							   hovertime = "1000";
							   isContainer=true;

							   new GuiBitmapCtrl() {
								   canSaveDynamicFields = "0";
								   Profile = "GuiDefaultProfile";   
								   HorizSizing = "right";
								   VertSizing = "bottom";
								   position = "25 5";
								   Extent = "20 20";
								   MinExtent = "0 0";
								   canSave = "1";
								   Visible = "1";
								   hovertime = "1000";
								   bitmap = "^feupDemic/gui/images/biohazard.png";
								   //isContainer=true;
							};

							   new GuiTextCtrl(infectedText) {
								   canSaveDynamicFields = "0";
								   Profile = "GuiLogProfile";   
								   HorizSizing = "right";
								   VertSizing = "bottom";
								   position = "50 0";
								   Extent = "250 30";
								   MinExtent = "2 4";
								   canSave = "1";
								   Visible = "1";
								   hovertime = "1000";
								   text="0";
								};

							};
							new GuiControl() {
							   canSaveDynamicFields = "0";
							   Profile = "GuiDefaultProfile";   
							   HorizSizing = "right";
							   VertSizing = "bottom";
							   position = "60 47";
							   Extent = "250 30";
							   MinExtent = "2 2";
							   canSave = "1";
							   Visible = "1";
							   hovertime = "1000";
							   isContainer=true;

							   new GuiBitmapCtrl() {
									   canSaveDynamicFields = "0";
									   Profile = "GuiDefaultProfile";   
									   HorizSizing = "right";
									   VertSizing = "bottom";
									   position = "25 5";
									   Extent = "20 20";
									   MinExtent = "0 0";
									   canSave = "1";
									   Visible = "1";
									   hovertime = "1000";
									   bitmap = "^feupDemic/gui/images/skull.png";
									   //isContainer=true;
								};
							   new GuiTextCtrl(deathText) {
								   canSaveDynamicFields = "0";
								   Profile = "GuiLogProfile";   
								   HorizSizing = "right";
								   VertSizing = "bottom";
								   position = "50 0";
								   Extent = "250 30";
								   MinExtent = "2 4";
								   canSave = "1";
								   Visible = "1";
								   hovertime = "1000";
								   text="0";
								};

							};

						/*new GuiTextCtrl() {
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
						};*/
						
					};
					new GuiControl(statsReg) {
					   canSaveDynamicFields = "0";
					   Profile = "GuiDefaultProfile";   
					   HorizSizing = "right";
					   VertSizing = "bottom";
					   position = "85 315";
					   Extent = "250 160";
					   MinExtent = "2 2";
					   canSave = "1";
					   Visible = "1";
					   hovertime = "1000";
					   isContainer=true;

					   new GuiTextCtrl() {
						   canSaveDynamicFields = "0";
						   Profile = "GuiTitleProfile";   
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "0 0";
						   Extent = "200 12";
						   MinExtent = "2 4";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						   text="POPULATIONAL DENSITY";
						};
						new GuiTextCtrl(populationalText) {
							canSaveDynamicFields = "0";
							Profile = "Gui18Profile";   
							HorizSizing = "right";
							VertSizing = "bottom";
							position = "0 12";
							Extent = "200 15";
							MinExtent = "2 4";
							canSave = "1";
							Visible = "1";
							hovertime = "1000";
							text="PLACE HOLDER";
						};
						 new GuiTextCtrl() {
						   canSaveDynamicFields = "0";
						   Profile = "GuiTitleProfile";   
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "0 32";
						   Extent = "200 12";
						   MinExtent = "2 4";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						   text="TEMPERATURE";
						};
						new GuiTextCtrl(temperatureText) {
							canSaveDynamicFields = "0";
							Profile = "Gui18Profile";   
							HorizSizing = "right";
							VertSizing = "bottom";
							position = "0 45";
							Extent = "200 15";
							MinExtent = "2 4";
							canSave = "1";
							Visible = "1";
							hovertime = "1000";
							text="PLACE HOLDER";
						};
						 new GuiTextCtrl() {
						   canSaveDynamicFields = "0";
						   Profile = "GuiTitleProfile";   
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "0 64";
						   Extent = "200 12";
						   MinExtent = "2 4";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						   text="TECH LEVEL";
						};
						new GuiTextCtrl(techText) {
							canSaveDynamicFields = "0";
							Profile = "Gui18Profile";   
							HorizSizing = "right";
							VertSizing = "bottom";
							position = "0 76";
							Extent = "200 15";
							MinExtent = "2 4";
							canSave = "1";
							Visible = "1";
							hovertime = "1000";
							text="PLACE HOLDER";
						};

					};
					/*new GuiTextCtrl(LogClick) {   ////TODO REMOVE
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
					};*/



					/*
					 * Infectivity
					 */
					new GuiTextCtrl() {
						   canSaveDynamicFields = "0";
						   Profile = "GuiBarLabelProfile";   
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "45 413";
						   Extent = "320 50";
						   MinExtent = "2 4";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						   text="INFECTIVITY";
					};

					new GuiSpriteCtrl(infectivity_bar) {
						canSaveDynamicFields = "0";
						Profile = "GuiBarProfile";
						HorizSizing = "right";
						VertSizing = "bottom";
						position = "45 445";
						Extent = "243 22";
						MinExtent = "0 0";
						canSave = "1";
						Visible = "1";
						Image="feupDemic:bar";
						isContainer=true;
						new GuiSceneObjectCtrl(infectivityBar) {
						   canSaveDynamicFields = "0";
						   Profile = "GuiMenuProfile";   
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "5 5";
						   Extent = "234 12";
						   originalExtent= "234 12";
						   MinExtent = "2 2";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						};

					};

					/*
					 * Severity
					 */
					new GuiTextCtrl() {
						   canSaveDynamicFields = "0";
						   Profile = "GuiBarLabelProfile";   
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "45 449";
						   Extent = "320 50";
						   MinExtent = "2 4";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						   text="SEVERITY";
					};

					new GuiSpriteCtrl(severity_bar) {
						canSaveDynamicFields = "0";
						Profile = "GuiBarProfile";
						HorizSizing = "right";
						VertSizing = "bottom";
						position = "45 481";
						Extent = "243 22";
						MinExtent = "0 0";
						canSave = "1";
						Visible = "1";
						Image="feupDemic:bar";
						isContainer=true;
						new GuiSceneObjectCtrl(severityBar) {
						   canSaveDynamicFields = "0";
						   Profile = "GuiMenuProfile";   
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "5 5";
						   Extent = "234 12";
						   originalExtent= "234 12";
						   MinExtent = "2 2";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						};
					};

					/*
					 * Lethality
					 */
					new GuiTextCtrl() {
						   canSaveDynamicFields = "0";
						   Profile = "GuiBarLabelProfile";   
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "45 485";
						   Extent = "320 50";
						   MinExtent = "2 4";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						   text="LETHALITY";
					};

					new GuiSpriteCtrl(lethality_bar) {
						canSaveDynamicFields = "0";
						Profile = "GuiBarProfile";
						HorizSizing = "right";
						VertSizing = "bottom";
						position = "45 518";
						Extent = "243 22";
						MinExtent = "0 0";
						canSave = "1";
						Visible = "1";
						Image="feupDemic:bar";
						isContainer=true;
						new GuiSceneObjectCtrl(lethalityBar) {
						   canSaveDynamicFields = "0";
						   Profile = "GuiMenuProfile";   
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "5 5";
						   Extent = "234 12";
						   originalExtent= "234 12";
						   MinExtent = "2 2";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						};
					};

					/*
					 * DNA
					 */
					

					new GuiSpriteCtrl(dna_bar) {
						canSaveDynamicFields = "0";
						Profile = "GuiBarProfile";
						HorizSizing = "right";
						VertSizing = "bottom";
						position = "45 545";
						Extent = "243 38";
						MinExtent = "0 0";
						canSave = "1";
						Visible = "1";
						Image="feupDemic:dna_bar";
						isContainer=true;
						new GuiSceneObjectCtrl(dnaBar) {
						   canSaveDynamicFields = "0";
						   Profile = "GuiMenuProfile";   
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "5 5";
						   Extent = "234 28";
						   originalExtent= "234 28";
						   MinExtent = "2 2";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						};
						new GuiTextCtrl() {
						   canSaveDynamicFields = "0";
						   Profile = "GuiDnaBarLabelProfile";
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "32 0";
						   Extent = "100 38";
						   MinExtent = "2 4";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						   text="DNA";
						};
						new GuiTextCtrl(dnaVal) {
						   canSaveDynamicFields = "0";
						   Profile = "GuiDnaBarLabelProfile";
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "200 0";
						   Extent = "100 38";
						   MinExtent = "2 4";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						   text="0";
						};
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



					 new GuiBitmapCtrl() {
						   canSaveDynamicFields = "0";
						   Profile = "GuiDefaultProfile";   
						   HorizSizing = "right";
						   VertSizing = "bottom";
						   position = "4 4";
						   Extent = "992 632";
						   MinExtent = "333 640";
						   canSave = "1";
						   Visible = "1";
						   hovertime = "1000";
						   bitmap = "^feupDemic/gui/images/hexagonal_grid.png";
						   //isContainer=true;
					};

					new GuiMLTextCtrl(detailTitle) {  
					  canSaveDynamicFields = "0";
					  Profile = "GuiLogProfile";   
					  HorizSizing = "right";
					  VertSizing = "bottom";
					  position = "725 190";
					  Extent = "225 50";
					  MinExtent = "2 4";
					  canSave = "1";
					  Visible = "1";
					  hovertime = "1000";
					  truncate=true;
					  text="Title";
					};


					new GuiMLTextCtrl(detailText) {  
					  canSaveDynamicFields = "0";
					  Profile = "GuiLogProfile";   
					  HorizSizing = "right";
					  VertSizing = "bottom";
					  position = "725 220";
					  Extent = "225 120";
					  MinExtent = "2 4";
					  canSave = "1";
					  Visible = "1";
					  hovertime = "1000";
					  truncate=true;
					  text="ajsdnajsdjfnasdjkfnakjsdnfjksdanfjkask vjasdnv jasd vjksafnjnsajkdvnaskjfv sajvnsajfnvjksnfjvnsdjnvjksdv sdvjnskdvsdkvnksadnvksadnvksdnvskd ksd vksd vksdmkvn";
					};
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
					   position = "50 185";
					   Extent = "642 383";
					   MinExtent = "2 2";
					   canSave = "1";
					   Visible = "1";
					   hovertime = "1000";
					   isContainer=true;
						   new SceneWindow(transmissionTab) {
							   canSaveDynamicFields = "0";
							   Profile = "GuiDefaultProfile";   
							   HorizSizing = "right";
							   VertSizing = "bottom";
							   position = "0 0";
							   Extent = "642 383";
							   MinExtent = "2 2";
							   canSave = "1";
							   Visible = "1";
							   hovertime = "1000";
							   isContainer = true;

							 /* new GuiTextCtrl() {  
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
								};*/
						   
							};
							 new SceneWindow(symptomsTab) {
							   canSaveDynamicFields = "0";
							   Profile = "GuiDefaultProfile";   
							   HorizSizing = "right";
							   VertSizing = "bottom";
							   position = "0 0";
							   Extent = "642 383";
							   MinExtent = "2 2";
							   canSave = "1";
							   Visible = "0";
							   hovertime = "1000";
							   isContainer=true;
							  /* new GuiTextCtrl() {  
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
								
									 
									
								};*/
						   
							};
							new SceneWindow(resistenceTab) {
							   canSaveDynamicFields = "0";
							   Profile = "GuiDefaultProfile";   
							   HorizSizing = "right";
							   VertSizing = "bottom";
							   position = "0 0";
							   Extent = "642 383";
							   MinExtent = "2 2";
							   canSave = "1";
							   Visible = "0";
							   hovertime = "1000";
							   isContainer=true;
							  /* new GuiTextCtrl() {  
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
								
									 
									
								};*/
						   
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
	
	transmissionTab.setCameraPosition( 0, 0 );
    transmissionTab.setCameraSize( 642, 383 );
    transmissionTab.setCameraZoom( 1 );
    transmissionTab.setCameraAngle( 0 );
    transmissionTab.Pos=0;
    transmissionTabInit();

   	symptomsTab.setCameraPosition( 0, 0 );
    symptomsTab.setCameraSize( 642, 383 );
    symptomsTab.setCameraZoom( 1 );
    symptomsTab.setCameraAngle( 0 );
    symptomsTab.Pos=0;
    symptomsTabInit();

    resistenceTab.setCameraPosition( 0, 0 );
    resistenceTab.setCameraSize( 642, 383 );
    resistenceTab.setCameraZoom( 1 );
    resistenceTab.setCameraAngle( 0 );
    resistenceTab.Pos=0;
    resistenceTabInit();

	Canvas.pushDialog(sidebar);

	new SimObject(timerXPTO);


}



function transmissionTabInit(){
	$transmissionScene=new Scene();
   
	transmissionTab.setScene($transmissionScene);
}


function item::onTouchDown(%this, %touchid, %worldposition){
	echo("item" SPC %this.id);
	if(%this.kind$="s"){
		detailText.setText(getVariable("$DIS_"@%this.id@"_DESC"));
		detailTitle.setText(getVariable("$DIS_"@%this.id@"_NAME"));
	}
}

function symptomsTabInit(){
	$symptomsScene=new Scene();
	symptomsTab.setScene($symptomsScene);
	symptomsTab.setUseObjectInputEvents(true);
	$symptomsIcons="";
	$symptomsScene.setDebugOn("collision");
	%s=new Sprite(){
   			class="item";
   			id=1;
   			kind="s";
   	};
	%s.Size="62 66";
   	%s.Image="feupDemic:s1";
   	$s.Position="0 0";
   	%s.createPolygonCollisionShape("0 -33 31 -16 31 16 0 33 -31 16 -31 -16");	
   	%s.setUseInputEvents(true);
   	%s.setImageFrame(1);
   	$symptomsScene.add(%s);
   	$symptomsIcons=%s;

   	for(%i=2;%i<=31;%i++){
   		%s=new Sprite(){
   			class="item";
   			id=%i;
   			kind="s";
   		};
   		%s.setUseInputEvents(true);
		%s.Size="62 66";
	   	%s.Image="feupDemic:s"@%i;
	   	$s.Position="0 0";
	   	%s.setImageFrame(1);
	   	%s.createPolygonCollisionShape("0 -33 31 -16 31 16 0 33 -31 16 -31 -16");
	   	$symptomsScene.add(%s);
	   	$symptomsIcons=$symptomsIcons SPC %s;
   	}
   	/*%len=getWordCount($symptomsIcons);
   	%h=0;
   	%v=0;
   	for(%i=0;%i<%len;%i++){
   		%s=getWord($symptomsIcons,%i);

   		//%s.Position=((%i%10)*62-280) SPC (-(mCeil(%i/10)+1)*66+191);
   		%s.Position=Vector2Hex(%h,%v);
   		if(%v%2==0){
   			if(%h>7){
   				%v++;
   				%h=0;
   			}else{
   				%h++;
   			}
   		}else{
   			if(%h>8){
   				%v++;
   				%h=0;
   			}else{
   				%h++;
   			}
   		}

   	}*/
   	//getWord($symptomsIcons,0).Position="-289 158";
   	getWord($symptomsIcons,0).Position=Vector2Hex(0,0);	
   	getWord($symptomsIcons,1).Position=Vector2Hex(1,0);
   	getWord($symptomsIcons,2).Position=Vector2Hex(1,1);
   	getWord($symptomsIcons,3).Position=Vector2Hex(0,2);
   	getWord($symptomsIcons,4).Position=Vector2Hex(2,1);
   	getWord($symptomsIcons,5).Position=Vector2Hex(3,0);
   	getWord($symptomsIcons,6).Position=Vector2Hex(3,1);
   	getWord($symptomsIcons,7).Position=Vector2Hex(2,2);
   	getWord($symptomsIcons,8).Position=Vector2Hex(4,1);
   	getWord($symptomsIcons,9).Position=Vector2Hex(5,1);
	getWord($symptomsIcons,10).Position=Vector2Hex(3,3);
	getWord($symptomsIcons,11).Position=Vector2Hex(0,6);
	getWord($symptomsIcons,12).Position=Vector2Hex(1,5);
	getWord($symptomsIcons,13).Position=Vector2Hex(0,4);
	getWord($symptomsIcons,14).Position=Vector2Hex(1,4);
	getWord($symptomsIcons,15).Position=Vector2Hex(2,4);
   	getWord($symptomsIcons,16).Position=Vector2Hex(0,3);
   	getWord($symptomsIcons,17).Position=Vector2Hex(6,0);
   	getWord($symptomsIcons,18).Position=Vector2Hex(6,1);
   	getWord($symptomsIcons,19).Position=Vector2Hex(7,6);
   	getWord($symptomsIcons,20).Position=Vector2Hex(6,4);
	getWord($symptomsIcons,21).Position=Vector2Hex(6,3);
	getWord($symptomsIcons,22).Position=Vector2Hex(6,6);
	getWord($symptomsIcons,23).Position=Vector2Hex(6,5);
   	getWord($symptomsIcons,24).Position=Vector2Hex(3,6);
   	getWord($symptomsIcons,25).Position=Vector2Hex(3,5);
   	getWord($symptomsIcons,26).Position=Vector2Hex(5,5);
   	getWord($symptomsIcons,27).Position=Vector2Hex(5,2);
	getWord($symptomsIcons,28).Position=Vector2Hex(4,2);
   	getWord($symptomsIcons,29).Position=Vector2Hex(4,3);
   	getWord($symptomsIcons,30).Position=Vector2Hex(4,6);
}

function Vector2Hex(%x,%y){
	if(%y%2==0){
		return -289+%x*64+62/2+2 SPC 191-%y*53-33;
	}else{
		return -289+%x*64+1 SPC 191-%y*53-33;
	}
}

function resistenceTabInit(){
	$resistenceScene=new Scene();
   
	resistenceTab.setScene($resistenceScene);
}

function menuVisible(%state){
	if(menuOverlay.Visible$="1" && %state==0){
		timerXPTO.startTimer(hideOverlay, 2.5);
	}else{
		timerXPTO.startTimer(showOverlay, 2.5);
		$menu_open=true;
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
			$menu_open=false;
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