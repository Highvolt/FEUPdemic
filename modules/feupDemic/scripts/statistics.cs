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
	dnaBar.setSceneObject(dnaValue);

}