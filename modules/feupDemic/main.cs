//walls collision group = 1

function populateFonts()
{      
      %font = "Minecraftia";      
      %sizes = "12 16 18 24 32 36 64";      
      for (%i = 0; %i < getWordCount(%sizes); %i++)            
            populateFontCacheRange(%font, getWord(%sizes, %i), 32, 126);      
      writeFontCache();
}


function feupDemic::create( %this )
{
	//activateDirectInput();
	enableWinConsole(false);
	exec("./scripts/scenewindow.cs");
	exec("./scripts/scene.cs");
	exec("./gui/guiProfiles.cs");
	
	exec(".scripts/menu.cs");
	exec(".scripts/pieChartGen.cs");
	exec(".scripts/area.cs");
  exec(".scripts/level.cs");
  exec(".scripts/global.cs");
  exec(".scripts/disease.cs");
  exec(".scripts/cure.cs");
  exec(".scripts/region.cs");
  exec(".scripts/logic_main.cs");
  exec(".scripts/popUP.cs");
  exec(".scripts/statistics.cs");

	//populateFonts();
	feupDemic.pops="";
	feupDemic.zonesCount=0;

	%obj = new ScriptObject(Listener)  
	{  
	   //class="Listener";  
	};  
	createSidebar();
	configureSceneWindow();
	createScene();
	
	//myScene.setDebugOn("collision");
	
	mySceneWindow.setScene(myScene);
	mySceneWindow.setUseObjectInputEvents(true);
	createGrass();
	initializeBars();
	SceneWindow.UseObjectInputEvents = true;  
	//mySceneWindow.setUseInputEvents();
	mySceneWindow.addInputListener(%obj);

	createAreas();
  drawAreas();

	populatePie("45 30 25");
	//echoInputState();
	//%region =new ScriptObject(){ class="region"; };
	//%region.id=0;
	//createPopup(%region,0);
	/*%shape=new ShapeVector(){
		Angle=90;
		CircleRadius=100;
		isCircle=true;
		Position="0 0";
	};
	myScene.add(%shape);*/



	//Canvas.BackgroundColor = "Black";
	//echo(Canvas.getMouseControl());
	//mySceneWindow.setLockMouse(true);	
	
	echo(mySceneWindow.getLockMouse());

}






function feupDemic::destroy( %this )
{
	destroySceneWindow();
}


function createGrass(){

   $grass=new Sprite(grass);
 	 grass.setBodyType( static );
    grass.Size = "667" SPC "640";
    
    // Set the position.
    grass.setPosition("0 0");
	grass.SceneLayer = "31";
   
    grass.Image = "feupDemic:map";
            
    echo($grass);
    myScene.add( $grass );   
}

function Sprite::onTouchDown(%this, %touchid, %worldposition)  
{  
	echo("click Sprite");
	 
	//mySceneWindow.setCameraPosition(-getWord(%worldposition,0),-getWord(%worldposition,1));
}

/*function mySceneWindow::onTouchDown(%this, %touchID, %worldPosition)  
{  
	//echo("click");
	//mySceneWindow.setCameraPosition(-getWord(%worldposition,0),-getWord(%worldposition,1));
	
}  
*/


function SceneWindow::onMouseWheelUp(%this, %modifier, %mousePoint, %mouseClickCount)
{  
	echo(%this.getMousePosition());
	mySceneWindow.setCameraZoom(mySceneWindow.getCameraZoom()+0.1);
	//mySceneWindow.setCameraPosition(%mousePoint);
	updatePops();
} 


function SceneWindow::onMouseWheelDown(%this, %modifier, %mousePoint, %mouseClickCount)
{  
	//echo("down");
	if(mySceneWindow.getCameraZoom()-0.1<=0){
		mySceneWindow.setCameraZoom(0.1);
		mySceneWindow.setCameraPosition(0,0);
	}else{
		mySceneWindow.setCameraZoom(mySceneWindow.getCameraZoom()-0.1);
		//mySceneWindow.setCameraPosition(%mousePoint);
	}
	updatePops();

} 



function SceneWindow::onTouchDown(%this, %touchid, %worldposition)  
{  

	%ret=myScene.pickPoint(%worldPosition);
	 echo(%worldPosition SPC "window:" SPC %ret);
	 if(getWordCount(%ret)<=1){
	 	LogClick.setText("clicked world");
	 }

	//echo("click");
	 %this.OldTouchPosition = %worldposition;
	 %this.OldCameraPosition= mySceneWindow.getCameraPosition();
	/* %ret=myScene.pickPoint(%worldposition,"","","any");
	 echo(%ret);
	 if(%ret!$=""){
	 	%len=getWordCount(%ret);
	 	for(%i=0;%i<%len;%i++){
	 		%obj=getWord(%ret,%i);
	 		if(%obj.id_Area){
	 			echo(%obj.id_Area);
	 		}
	 	}
	 }*/
	//mySceneWindow.setCameraPosition(-getWord(%worldposition,0),-getWord(%worldposition,1));
}  


function SceneWindow::onTouchDragged(%this, %touchid, %worldposition)  
{  
	//echo("drag" SPC %worldposition SPC "#" SPC %touchid SPC getRealTime());
	//mySceneWindow.setCameraPosition(-getWord(%worldposition,0),-getWord(%worldposition,1));

	%panOffset = Vector2Sub( %worldposition, %this.OldTouchPosition);

    %camOffset= Vector2Sub( mySceneWindow.getCameraPosition(), %this.OldCameraPosition);
    //%panOffset = Vector2Inverse( %panOffset );

    
    //%panOffset = Vector2Mult( %panOffset, mySceneWindow.getCameraWorldScale() );
    
    //echo(%panOffset);
    %this.OldCameraPosition= mySceneWindow.getCameraPosition();
    mySceneWindow.setCameraPosition( Vector2Add(Vector2Sub( mySceneWindow.getCameraPosition(), %panOffset ),%camOffset));
     %this.OldTouchPosition = %worldposition;

}  


