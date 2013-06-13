//createArea(id, "x y;px1 py1 pxn pyn,X y;px1 py1 pxn pyn")
function createArea(%id,%data){
	%polsLen=getUnitCount(%data,",");
	for(%i=0;%i<%polsLen;%i++){
		%pol=getUnit(%data,%i,",");
		if(getUnitCount(%pol,";")==2){
			%pos=getUnit(getUnit(%pol,0,";"),1,"/");
			%polPos=getUnit(%pol,1,";");
			%shape=new ShapeVector(){
				//Angle=90;
				//Size="1 1";
				//CircleRadius=20;
				isCircle=false;
				Position=%pos;
				PolyList=%polPos;
				FillColor="1 0 0 0";
				LineColor="0 0 0 0";
				FillMode=true;
				id_Area=getUnit(getUnit(%pol,0,";"),0,"/");
				id_A=%id;
				SceneGroup=1;
				SceneLayer=2;
				class="Area";
			};
			%shape.setUseInputEvents(true);
			%shape.setPolyCustom(getWordCount(%polPos)/2,%polPos);
			//echo("Vals:"@%polPos);
			%shape.createPolygonCollisionShape(%polPos);
			feupDemic.zones[%shape.id_Area]=%shape;
			feupDemic.zonesCount++;
		}
	}
}

function drawAreas(){
	for(%i=0;%i<feupDemic.zonesCount;%i++){
		echo("zone" SPC feupDemic.zones[%i]);
		myScene.add(feupDemic.zones[%i]);
	}
}

function setOpacity(%region,%percentage){
	%v=feupDemic.zones[%region.id];
	%v.setFillColor(setWord(%v.getFillColor(), 3, %percentage));

}


function graphTimer::updateGraph(%this){
	%pop=%this.selected.population;
	%inf=%this.selected.infected;
	%death=%this.selected.death;
	%healty=%pop-%inf;
	%healty-=%death;
	%inf=%inf/%pop;
	%inf=%inf*100;
	%death=%death/%pop;
	%death=%death*100;
	%h=%healty;
	%healty=%healty/%pop;
	%healty=%healty*100;
	populatePie(%healty SPC %inf SPC %death);
	//LogClick.setText("id:" SPC %this.selected.id SPC "inf:" SPC $disease.world_infected SPC "dea:" SPC $disease.world_death);
	wellText.setText(%h);
	infectedText.setText(%this.selected.infected);
	deathText.setText(%this.selected.death);
}

function Area::onTouchDown(%this, %touchID, %worldPosition)  
{  
	

	echo("clicked area with id" SPC %this.id_Area);
	%pop=$regions[%this.id_Area].population;
	%inf=$regions[%this.id_Area].infected;
	%death=$regions[%this.id_Area].death;
	//LogClick.setText("id:" SPC %this.id_Area SPC "inf:" SPC %inf SPC "dea:" SPC %death);
	%healty=%pop-%inf;
	%healty-=%death;
	%inf=%inf/%pop;
	%inf=%inf*100;
	%death=%death/%pop;
	%death=%death*100;
	%h=%healty;
	%healty=%healty/%pop;
	%healty=%healty*100;
	populatePie(%healty SPC %inf SPC %death);
	wellText.setText(%h);
	infectedText.setText($regions[%this.id_Area].infected);
	deathText.setText($regions[%this.id_Area].death);
	//$selected=
	if ( isObject($timerGraph) ){
		$timerGraph.stopTimer();
		$timerGraph.delete();
	}
	$timerGraph=new SimObject(){
		class="graphTimer";
		selected=$regions[%this.id_Area];
	};
	$timerGraph.startTimer(updateGraph,500);
	LogClick.setText($regions[%this.id_Area].name SPC $regions[%this.id_Area].infected);
	ZoneName.setText($regions[%this.id_Area].name);
}  


