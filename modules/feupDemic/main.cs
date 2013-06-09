//walls collision group = 1

function populateFonts()
{      
      %font = "Minecraftia";      
      %sizes = "18 24 32 36";      
      for (%i = 0; %i < getWordCount(%sizes); %i++)            
            populateFontCacheRange(%font, getWord(%sizes, %i), 32, 126);      
      writeFontCache();
}


function feupDemic::create( %this )
{
	
	
exec("./scripts/scenewindow.cs");
exec("./scripts/scene.cs");
exec("./gui/guiProfiles.cs");
//populateFonts();
createSceneWindow();
createScene();

Canvas.BackgroundColor = "Black";

}




function feupDemic::destroy( %this )
{
	destroySceneWindow();
}

