function createPopup(%region,%kind){
	%obj=new Sprite(){
		class="popUP";
	};
	%obj.setBodyType( static );
	%v=getWord(feupDemic.zones,%region.id);
	%obj.id_A=%region.id;
	%obj.kind=%kind;
	//echo(%v.id_Area);
	%obj.setUseInputEvents(true);
	%obj.OriginalPos=%v.Position;
	//%obj.Position=vector2Sub(feupDemic.zones[%region.id].Position,"0 -19");
	echo(%v.Position);
	%obj.createPolygonBoxCollisionShape("31", "48");
	
	%obj.OriginalSize="31 48";
	%obj.Size=Vector2Mult( %obj.OriginalSize, mySceneWindow.getCameraWorldScale() );
	%obj.Position=vector2Sub(%v.Position,"0" SPC (-getWord(%obj.Size,1))/2);
	%obj.Animation="feupDemic:yellowAnim";
	if(%kind$="red"){
		%obj.Animation="feupDemic:redAnim";
	}else if(%kind$="blue"){
		%obj.Animation="feupDemic:blueAnim";
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

function popUpTimer::remove2(%this){
	myScene.remove(%this.obj);
	for(%i=0;%i<%len;%i++){
		%obj=getWord(feupDemic.pops,%i);
		if(%obj$=%this.obj){
			feupDemic.pops=removeWord(feupDemic.pops,%i);
			
			return;
		}

	}
	%this.stopTimer();
}

function popUpTimer::disapear(%this){
	$regions[%this.obj.id_A].handlePopUp("close");
	%len=getWordCount(feupDemic.pops);
	//echo(%len);
	myScene.remove(%this.obj);
	for(%i=0;%i<%len;%i++){
		%obj=getWord(feupDemic.pops,%i);
		if(%obj$=%this.obj){
			feupDemic.pops=removeWord(feupDemic.pops,%i);
			
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
	if(%this.a==1){
		return;
	}
	%this.a=1;
	%obj=%this;
	%this.clearCollisionShapes();
	%obj.OriginalSize="45 71";
	%obj.Size=Vector2Mult( %obj.OriginalSize, mySceneWindow.getCameraWorldScale() );
	%obj.Position=vector2Sub(%obj.OriginalPos,"0" SPC (-getWord(%obj.Size,1)/2));
	%obj.Animation="feupDemic:yellowClickAnim";
	if(%this.kind$="red"){
		%obj.Animation="feupDemic:redClickAnim";
	}else if(%this.kind$="blue"){
		%obj.Animation="feupDemic:blueClickAnim";
	}
	//echo("down");
	echo("popup Click");
	$regions[%this.id_A].handlePopUp(%this.kind);
	%this.timer.stopTimer();
	%this.timer.startTimer("remove2",200);
	/*%len=getWordCount(feupDemic.pops);
	//echo(%len);
	for(%i=0;%i<%len;%i++){
		%obj=getWord(feupDemic.pops,%i);
		if(%obj==%this){
			feupDemic.pops=removeWord(feupDemic.pops,%i);
			//myScene.remove(%this);
			
			return;
		}

	}*/

} 