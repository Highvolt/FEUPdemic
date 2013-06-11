//walls collision group = 1

function populateFonts()
{      
      %font = "Minecraftia";      
      %sizes = "12 18 24 32 36 64";      
      for (%i = 0; %i < getWordCount(%sizes); %i++)            
            populateFontCacheRange(%font, getWord(%sizes, %i), 32, 126);      
      writeFontCache();
}


function feupDemic::create( %this )
{
	
	
exec("./scripts/scenewindow.cs");
exec("./scripts/scene.cs");
exec("./gui/guiProfiles.cs");
//myScene.setDebugOn("fps collision");
exec(".scripts/menu.cs");
exec(".scripts/pieChartGen.cs");
exec(".scripts/area.cs");
//populateFonts();
feupDemic.zonesCount=0;
createSceneWindow();
createScene();
createSidebar();
mySceneWindow.setScene(myScene);
createArea(2, "0 0;10 10 -10 10 -10 -10 10 -10,100 100;10 10 -10 10 -10 -10 10 -10");

drawAreas();

populatePie();
/*%shape=new ShapeVector(){
	Angle=90;
	CircleRadius=100;
	isCircle=true;
	Position="0 0";
};
myScene.add(%shape);*/



//Canvas.BackgroundColor = "Black";

}


function populatePie(){
	%pieData=createPieChart("50 25 25",0.5);
if(%pieData!$=""){
	%len=getUnitCount(%pieData,",");
	for(%i=0;%i<%len;%i++){
		//echo(getUnit(%pieData,%i,","));
		%vals=getUnit(%pieData,%i,",");
		%shape=new ShapeVector(){
			//Angle=90;
			Size="1 1";
			CircleRadius=20;
			isCircle=false;
			Position="0 0";
			PolyList=%vals;
			FillMode=true;
		};

		%shape.setPolyCustom(getWordCount(%vals)/2,%vals);
		//echo(getWordCount(%vals)/2);
		//echo(%shape.getPoly());
		//myScene.add(%shape);
		if(%i==0){
			%shape.setFillColor("0.0 0.0 1.0");
			wellChart.setSceneObject(%shape);
			//wellChart.setCaption("1");
		}else if(%i==1){
			%shape.setFillColor("1.0 0.0 0.0");
			infectedChart.setSceneObject(%shape);
		}else{
			%shape.setFillColor("0.0 0.0 0.0");
			deadChart.setSceneObject(%shape);
		}
	}
}
}

function feupDemic::destroy( %this )
{
	destroySceneWindow();
}



