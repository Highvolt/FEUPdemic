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
	%obj.OriginalPos=feupDemic.zones[%region.id].Position;
	%obj.Position=vector2Sub(feupDemic.zones[%region.id].Position,"0 -19");
	echo(feupDemic.zones[%region.id].Position);
	%obj.createPolygonBoxCollisionShape("31", "48");
	
	%obj.OriginalSize="31 48";
	%obj.Size=Vector2Mult( %obj.OriginalSize, mySceneWindow.getCameraWorldScale() );
	%obj.Position=vector2Sub(feupDemic.zones[%region.id].Position,"0" SPC (-getWord(%obj.Size,1))/2);
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
	%timer.startTimer("disapear",5000);
	%obj.timer=%timer;
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
		%obj.Position=vector2Sub(%obj.OriginalPos,"0" SPC (-getWord(%obj.Size,1)/2));
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
			%this.timer.stopTimer();

			return;
		}

	}

} 