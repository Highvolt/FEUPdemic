function configureSceneWindow()
{   
    

    mySceneWindow.setCameraPosition( 0, 0 );
    mySceneWindow.setCameraSize( 667, 640 );
    mySceneWindow.setCameraZoom( 1 );
    mySceneWindow.setCameraAngle( 0 );
    mySceneWindow.Pos=0;

    
    
}


function destroySceneWindow()
{
    // Finish if no window available.
    if ( !isObject(mySceneWindow) )
        return;
    
    // Delete the window.
    mySceneWindow.delete();
}