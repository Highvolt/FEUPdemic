function createPopup(%region,%kind){
	%obj=new Sprite(){
		class="popUP";
	};
	%obj.setBodyType( static );
	%v=feupDemic.zones[%region.id];
	%obj.id_A=%region.id;
	%obj.kind=%kind;
	//echo(%v.id_Area);
	%obj.setUseInputEvents(true);
	%obj.Position=feupDemic.zones[%region.id].Position;
	echo(feupDemic.zones[%region.id].Position);
	%obj.createPolygonBoxCollisionShape("20", "20");
	
	%obj.OriginalSize="20 20";
	%obj.Size=Vector2Mult( %obj.OriginalSize, mySceneWindow.getCameraWorldScale() );
	%obj.Image="feupDemic:yellow";
	if(%kind$="red"){
		%obj.Image="feupDemic:red";
	}
	if(feupDemic.pops$=""){
		feupDemic.pops=%obj;
	}else{
		feupDemic.pops=feupDemic.pops SPC %obj;
	}
	myScene.add(%obj);
	%timer=new SimObject(){
		class="popUpTimer";
		obj=%obj;
	};
	%timer.startTimer(disapear,5000);
}


function popUpTimer::disapear(%this){
	$regions[%this.obj.id_A].handlePopUp("close");
	%len=getWordCount(feupDemic.pops);
	//echo(%len);
	for(%i=0;%i<%len;%i++){
		%obj=getWord(feupDemic.pops,%i);
		if(%obj==%this.obj){
			feupDemic.pops=removeWord(feupDemic.pops,%i);
			myScene.remove(%this.obj);
			return;
		}

	}
	%this.stopTimer();

}

function updatePops(){
	if(getWord(mySceneWindow.getCameraWorldScale(),0)>1){
		return;
	}
	%len=getWordCount(feupDemic.pops);
	//echo(%len);
	for(%i=0;%i<%len;%i++){
		%obj=getWord(feupDemic.pops,%i);
		%obj.clearCollisionShapes();
		%obj.Size=Vector2Mult( %obj.OriginalSize, mySceneWindow.getCameraWorldScale() );
		echo(%obj SPC %obj.Size);
		%obj.createPolygonBoxCollisionShape(%obj.Size);

	}
}

function popUP::onTouchDown(%this, %touchid, %worldposition)
{  
	//echo("down");
	echo("popup Click");
	$regions[%this.id_A].handlePopUp(%this.kind);
	%len=getWordCount(feupDemic.pops);
	//echo(%len);
	for(%i=0;%i<%len;%i++){
		%obj=getWord(feupDemic.pops,%i);
		if(%obj==%this){
			feupDemic.pops=removeWord(feupDemic.pops,%i);
			myScene.remove(%this);
			return;
		}

	}

} 