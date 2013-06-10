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
//populateFonts();


createSceneWindow();
createScene();
createSidebar();
mySceneWindow.setScene(myScene);

%pieData=createPieChart("30 30 40",100);
if(%pieData!$=""){
	%len=getUnitCount(%pieData,",");
	for(%i=0;%i<%len;%i++){
		//echo(getUnit(%pieData,%i,","));
		%vals=getUnit(%pieData,%i,",");
		%shape=new ShapeVector(){
			//Angle=90;
			
			isCircle=false;
			Position="0 0";
			PolyList=%vals;
		};

		%shape.setPolyCustom(getWordCount(%vals)/2,%vals);
		//echo(getWordCount(%vals)/2);
		//echo(%shape.getPoly());
		myScene.add(%shape);
	}
}
/*%shape=new ShapeVector(){
	Angle=90;
	CircleRadius=100;
	isCircle=true;
	Position="0 0";
};
myScene.add(%shape);*/



//Canvas.BackgroundColor = "Black";

}




function feupDemic::destroy( %this )
{
	destroySceneWindow();
}

