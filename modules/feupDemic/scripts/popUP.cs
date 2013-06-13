function createPopup(%region,%kind){
	%obj=new Sprite(){
		class="popUP";
	};
	%obj.setBodyType( static );
	%v=feupDemic.zones[%region.id];
	echo(%v.id_Area);
	%obj.Position=feupDemic.zones[%region.id].Position;
	echo(feupDemic.zones[%region.id].Position);
	%obj.createPolygonBoxCollisionShape("20", "20");
	%obj.Size="20 20";
	%obj.OriginalSize=%obj.Size;
	if(feupDemic.pops$=""){
		feupDemic.pops=%obj;
	}else{
		feupDemic.pops=feupDemic.pops SPC %obj;
	}
	myScene.add(%obj);
}

function updatePops(){
	if(getWord(mySceneWindow.getCameraWorldScale(),0)>1){
		return;
	}
	%len=getWordCount(feupDemic.pops);
	echo(%len);
	for(%i=0;%i<%len;%i++){
		%obj=getWord(feupDemic.pops,%i);
		%obj.clearCollisionShapes();
		%obj.Size=Vector2Mult( %obj.OriginalSize, mySceneWindow.getCameraWorldScale() );
		echo(%obj SPC %obj.Size);
		%obj.createPolygonBoxCollisionShape(%obj.Size);

	}
}