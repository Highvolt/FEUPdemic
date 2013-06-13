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
				FillMode=true;
				id_Area=getUnit(getUnit(%pol,0,";"),0,"/");
				id_A=%id;
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
		myScene.add(feupDemic.zones[%i]);
	}
}

function setOpacity(%region,%percentage){
	%v=feupDemic.zones[%region.id];
	%v.setFillColor(setWord(%v.getFillColor, 3, %percentage));

}

function Area::onTouchDown(%this, %touchID, %worldPosition)  
{  
	echo("clicked area with id" SPC %this.id_Area);
	//LogClick.setText("clicked area with id" SPC %this.id_Area);
	LogClick.setText($regions[%this.id_Area].name SPC $regions[%this.id_Area].infected);
}  

