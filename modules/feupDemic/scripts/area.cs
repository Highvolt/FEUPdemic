//createArea(id, "x y;px1 py1 pxn pyn,X y;px1 py1 pxn pyn")
function createArea(%id,%data){
	%polsLen=getUnitCount(%data,",");
	for(%i=0;%i<%polsLen;%i++){
		%pol=getUnit(%data,%i,",");
		if(getUnitCount(%pol,";")==2){
			%pos=getUnit(%pol,0,";");
			%polPos=getUnit(%pol,1,";");
			%shape=new ShapeVector(){
				//Angle=90;
				//Size="1 1";
				//CircleRadius=20;
				isCircle=false;
				Position=%pos;
				PolyList=%polPos;
				FillMode=true;
			};

			%shape.setPolyCustom(getWordCount(%polPos)/2,%polPos);
			feupDemic.zones[feupDemic.zonesCount]=%shape;
			feupDemic.zonesCount++;
		}
	}
}

function drawAreas(){
	for(%i=0;%i<feupDemic.zonesCount;%i++){
		myScene.add(feupDemic.zones[%i]);
	}
}

