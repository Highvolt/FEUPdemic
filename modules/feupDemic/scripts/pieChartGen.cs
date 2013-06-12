

function createPieChart(%vals, %radius){
	%len=getWordCount(%vals);
	%ret="";
	//echo(%len);
	%count=0;
	for(%i=0;%i<%len;%i++){
		%count+=getWord(%vals,%i);

	}
	//echo(%count);
	if(%count==100){
		%count=0;
		%stepVal=360/16;
		%start=0;
		for(%i=0;%i<%len;%i++){
			
			%v=getWord(%vals,%i);
			%a=360.0*(%v/100.0);
			//echo("angle: "@%a);
			%count+=%a;
			%f="";

			for(;%start<=%count;%start+=%stepVal){
				%start1=mDegToRad(%start);
				if(%f$=""){
				%f=mCos(%start1)*%radius SPC mSin(%start1)*%radius;
				}else{
					%f=%f SPC mCos(%start1)*%radius SPC mSin(%start1)*%radius;
				}
			}
			%start1=mDegToRad(%count);
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
	}
	//echo("result "@%ret SPC getUnitCount(%ret,","));
	return %ret;
}