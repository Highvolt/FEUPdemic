function initializeBars(){
	//echo(VectorScale("240 240 240",1/255));
	new ShapeVector(infectivityValue){
				//Angle=90;
				//Size="1 1";
				//CircleRadius=20;
				isCircle=false;
				Position="0 0";
				//PolyList=%polPos;
				FillColor=VectorScale("210 58 164",1/255);
				LineColor="0 0 0 0";
				FillMode=true;
				
	};
	infectivityValue.setPolyCustom(4,"-1 1 1 1 1 -1 -1 -1");
	setInfectivity(0);
	infectivityBar.setSceneObject(infectivityValue);
	new ShapeVector(severityValue){
				//Angle=90;
				//Size="1 1";
				//CircleRadius=20;
				isCircle=false;
				Position="0 0";
				//PolyList=%polPos;
				FillColor=VectorScale("228 247 60",1/255);
				LineColor="0 0 0 0";
				FillMode=true;
				
	};
	severityValue.setPolyCustom(4,"-1 1 1 1 1 -1 -1 -1");
	setSeverity(0);
	severityBar.setSceneObject(severityValue);
	new ShapeVector(lethalityValue){
				//Angle=90;
				//Size="1 1";
				//CircleRadius=20;
				isCircle=false;
				Position="0 0";
				//PolyList=%polPos;
				FillColor=VectorScale("132 70 244",1/255);
				LineColor="0 0 0 0";
				FillMode=true;
				
	};
	lethalityValue.setPolyCustom(4,"-1 1 1 1 1 -1 -1 -1");
	setLethality(0);
	lethalityBar.setSceneObject(lethalityValue);
	new ShapeVector(dnaValue){
				//Angle=90;
				//Size="1 1";
				//CircleRadius=20;
				isCircle=false;
				Position="0 0";
				//PolyList=%polPos;
				FillColor=VectorScale("105 17 37",1/255);
				LineColor="0 0 0 0";
				FillMode=true;
				
	};
	dnaValue.setPolyCustom(4,"-1 1 1 1 1 -1 -1 -1");
	setDna(0);
	dnaBar.setSceneObject(dnaValue);

}

function setInfectivity(%per){
	/*%per=%i*2;//-1;
	%per=%per-1;
	%value=setWord("-1 1 1 1 1 -1 -1 -1",2,%per);
	%value=setWord(%value,4,%per);
	echo("############" TAB %value);
	infectivityValue.setPolyCustom(4,%value);*/
	if(%per>1){
		%per=1;
	}
	infectivityBar.Extent=Vector2Mult(infectivityBar.originalExtent,%per SPC "1");

}

function setSeverity(%per){
	/*%per=%i*2;//-1;
	%per=%per-1;
	%value=setWord("-1 1 1 1 1 -1 -1 -1",2,%per);
	%value=setWord(%value,4,%per);
	severityValue.setPolyCustom(4,%value);*/
	if(%per>1){
		%per=1;
	}
	severityBar.Extent=Vector2Mult(infectivityBar.originalExtent,%per SPC "1");

}

function setLethality(%per){
	/*%per=%i*2;//-1;
	%per=%per-1;
	%value=setWord("-1 1 1 1 1 -1 -1 -1",2,%per);
	%value=setWord(%value,4,%per);
	lethalityValue.setPolyCustom(4,%value);*/
	if(%per>1){
		%per=1;
	}
	lethalityBar.Extent=Vector2Mult(infectivityBar.originalExtent,%per SPC "1");

}
function setDna(%i){
	%per=(%i/100);//*2-1;
	/*%per=%per*2;
	%per=%per-1;
	%value=setWord("-1 1 1 1 1 -1 -1 -1",2,%per);
	%value=setWord(%value,4,%per);
	dnaValue.setPolyCustom(4,%value);*/
	if(%per>1){
		%per=1;
	}
	dnaBar.Extent=Vector2Mult(dnaBar.originalExtent,%per SPC "1");
	dnaVal.setText(%i);

}

