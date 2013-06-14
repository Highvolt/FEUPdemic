
//should poll active region for status
function createPieChart(%vals, %radius){
	%len=getWordCount(%vals);
	%ret="";
	//echo(%len);
	%count=0;
	for(%i=0;%i<%len;%i++){
		if(getWord(%vals,%i)<0){
			messageBox("Percentage negative",getWord(%vals,%i));
		}else{
			%count+=getWord(%vals,%i);
		}

	}
	//echo(%count);
	//if(%count==100){
		%count=0;
		%stepVal=360/16;
		%start=0;
		for(%i=0;%i<%len;%i++){
			
			%v=getWord(%vals,%i);
			%a=360.0*(%v/100.0);
			//echo("angle: "@%a);
			%count+=%a;
			%f="";
			%f="0 0";
			for(;%start<=%count;%start+=%stepVal){
				%start1=mDegToRad(%start+90);
				/*if(%f$=""){
				%f=mCos(%start1)*%radius SPC mSin(%start1)*%radius;
				}else{*/
					%f=%f SPC mCos(%start1)*%radius SPC mSin(%start1)*%radius;
				//}
			}
			%start1=mDegToRad(%count+90);
			if(%f$=""){
				%f=mCos(%start1)*%radius SPC mSin(%start1)*%radius;
				}else{
					%f=%f SPC mCos(%start1)*%radius SPC mSin(%start1)*%radius;
				}
			%start=%count;
			//echo("Result position: "@%f);
			if(%ret$=""){
				%ret=%f SPC "0 0";
			}else{
				%ret=%ret@","@%f SPC "0 0";
			}
		}
	//}
	//echo("result "@%ret SPC getUnitCount(%ret,","));
	return %ret;
}


function populatePie(%v){
	echo(%v);
	%pieData=createPieChart(%v,0.5);
if(%pieData!$=""){
	%len=getUnitCount(%pieData,",");
	for(%i=0;%i<%len;%i++){
		//echo(getUnit(%pieData,%i,","));
		%vals=getUnit(%pieData,%i,",");
		%shape=new ShapeVector(){
			//Angle=90;
			Size="1 1";
			CircleRadius=20;
			isCircle=false;
			Position="0 0";
			PolyList=%vals;
			FillMode=true;

		};

		%shape.setPolyCustom(getWordCount(%vals)/2,%vals);
		//echo(getWordCount(%vals)/2);
		//echo(%shape.getPoly());
		//myScene.add(%shape);
		if(%i==0){
			%shape.setFillColor(VectorScale("33 166 206",1/255));
			wellChart.setSceneObject(%shape);
			//wellChart.setCaption("1");
		}else if(%i==1){
			%shape.setFillColor(VectorScale("254 0 0",1/255));
			infectedChart.setSceneObject(%shape);
		}else{
			%shape.setFillColor(VectorScale("24 28 24",1/255));
			deadChart.setSceneObject(%shape);
		}
	}
}
}