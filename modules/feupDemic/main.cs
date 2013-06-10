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
//populateFonts();


createSceneWindow();
createScene();
createSidebar();
mySceneWindow.setScene(myScene);






//Canvas.BackgroundColor = "Black";

}




function feupDemic::destroy( %this )
{
	destroySceneWindow();
}

