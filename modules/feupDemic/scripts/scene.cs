function createScene()
{
    // Destroy the scene if it already exists.
    if ( isObject(myScene) )
        destroyScene();
    
    // Create the scene.
    new Scene(myScene);
   
  // $superScene=myScene;
    //myScene.Gravity="0, -9.8";
echo(myScene.getGravity());
//myScene.setDebugOn("collision");

  //  myScene.setDefaultFriction("0.0");
   
    
}

//-----------------------------------------------------------------------------

function destroyScene()
{
    // Finish if no scene available.
    if ( !isObject(myScene) )
        return;

    // Delete the scene.
    myScene.delete();
}