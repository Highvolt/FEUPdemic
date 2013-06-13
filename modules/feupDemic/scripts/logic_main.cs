
$disease = create_disease();
$cure = create_cure();
$dna_points = 0;

$REGIONS_SIZE = 56;
$regions[0]=create_region(0, "Zero", "hot", "low", "primitive", 500, "1,3");
$regions[1]=create_region(1, "Um","hot", "low", "primitive", 501, "2,0,3");
$regions[2]=create_region(2, "Dois", "hot", "low", "primitive", 502, "4,5,1");
$regions[3]=create_region(3, "Tres", "hot", "low", "primitive", 503, "0,1,15");
$regions[4]=create_region(4, "4", "hot", "low", "primitive", 503, "2,5");
$regions[5]=create_region(5, "5", "hot", "low", "primitive", 503, "4,6");
$regions[6]=create_region(6, "5", "hot", "low", "primitive", 503, "5,7,16");
$regions[7]=create_region(7, "7", "hot", "low", "primitive", 503, "6,8,17,16");
$regions[8]=create_region(8, "8", "hot", "low", "primitive", 503, "19,7,12,9,10,11,13");
$regions[9]=create_region(9, "9", "hot", "low", "primitive", 503, "18,19,12,10,11,13");
$regions[10]=create_region(10, "10", "hot", "low", "primitive", 503, "9,12,11,25,18,13");
$regions[11]=create_region(11, "11", "hot", "low", "primitive", 503, "10,9,12,25,14,13");
$regions[12]=create_region(12, "12", "hot", "low", "primitive", 503, "9,10,11,14,8,13");
$regions[13]=create_region(13, "13", "hot", "low", "primitive", 503, "9,10,11,12,8");
$regions[14]=create_region(14, "14", "hot", "low", "primitive", 503, "12,49,51");
$regions[15]=create_region(15, "15", "hot", "low", "primitive", 503, "3,1,16");
$regions[16]=create_region(16, "16", "hot", "low", "primitive", 503, "15,17,6");
$regions[17]=create_region(17, "17", "hot", "low", "primitive", 503, "48,46,47,16,19,7");
$regions[18]=create_region(18, "18", "hot", "low", "primitive", 503, "19,20,21,25,9,10");
$regions[19]=create_region(19, "19", "hot", "low", "primitive", 503, "17,20,21,18,9");
$regions[20]=create_region(20, "20", "hot", "low", "primitive", 503, "19,18,21");
$regions[21]=create_region(21, "21", "hot", "low", "primitive", 503, "43,20,25");
$regions[22]=create_region(22, "5", "hot", "low", "primitive", 503, "1");//cant find it
$regions[23]=create_region(23, "5", "hot", "low", "primitive", 503, "24,41,32");
$regions[24]=create_region(24, "5", "hot", "low", "primitive", 503, "25,41,23,44,31");
$regions[25]=create_region(25, "5", "hot", "low", "primitive", 503, "24,21,27,26,18");
$regions[26]=create_region(26, "5", "hot", "low", "primitive", 503, "25,27,29,28");
$regions[27]=create_region(27, "5", "hot", "low", "primitive", 503, "26,29,24,31,30");
$regions[28]=create_region(28, "5", "hot", "low", "primitive", 503, "14,26,29,49");
$regions[29]=create_region(29, "5", "hot", "low", "primitive", 503, "26,27,30,28");
$regions[30]=create_region(30, "5", "hot", "low", "primitive", 503, "27,29,31");
$regions[31]=create_region(31, "5", "hot", "low", "primitive", 503, "24,30,32");
$regions[32]=create_region(32, "5", "hot", "low", "primitive", 503, "31,33,23");
$regions[33]=create_region(33, "5", "hot", "low", "primitive", 503, "32,34");
$regions[34]=create_region(34, "5", "hot", "low", "primitive", 503, "33,38");
$regions[35]=create_region(35, "5", "hot", "low", "primitive", 503, "37,36,38");
$regions[36]=create_region(36, "5", "hot", "low", "primitive", 503, "35,38");
$regions[37]=create_region(37, "5", "hot", "low", "primitive", 503, "38,35,40");
$regions[38]=create_region(38, "5", "hot", "low", "primitive", 503, "39,37,35,36");
$regions[39]=create_region(39, "5", "hot", "low", "primitive", 503, "40,38,45");
$regions[40]=create_region(40, "5", "hot", "low", "primitive", 503, "39,37");
$regions[41]=create_region(41, "5", "hot", "low", "primitive", 503, "45,44,24,23");
$regions[42]=create_region(42, "5", "hot", "low", "primitive", 503, "43,45");
$regions[43]=create_region(43, "5", "hot", "low", "primitive", 503, "42,45,44,21");
$regions[44]=create_region(44, "5", "hot", "low", "primitive", 503, "43,45,24,41");
$regions[45]=create_region(45, "5", "hot", "low", "primitive", 503, "42,43,44,41");
$regions[46]=create_region(46, "5", "hot", "low", "primitive", 503, "17,47,48");
$regions[47]=create_region(47, "5", "hot", "low", "primitive", 503, "43,48,46");
$regions[48]=create_region(48, "5", "hot", "low", "primitive", 503, "46,47,42,17");
$regions[49]=create_region(49, "5", "hot", "low", "primitive", 503, "14,28,50");
$regions[50]=create_region(50, "5", "hot", "low", "primitive", 503, "49");
$regions[51]=create_region(51, "5", "hot", "low", "primitive", 503, "14,52,55");
$regions[52]=create_region(52, "5", "hot", "low", "primitive", 503, "51,55");
$regions[53]=create_region(53, "5", "hot", "low", "primitive", 503, "1");//cant find it
$regions[54]=create_region(54, "5", "hot", "low", "primitive", 503, "56");
$regions[55]=create_region(55, "5", "hot", "low", "primitive", 503, "56,51,52");
$regions[56]=create_region(56, "5", "hot", "low", "primitive", 503, "55,54");

$regions[0].infect(2);

function logic_timer::logic_tick(){
  
	for(%i=0; %i<$REGIONS_SIZE; %i++){
		%reg = $regions[%i];
		if(%reg.is_infected()){
			%reg.tick();
			%reg.yellow_prob();
			%reg.propagate();
		}
	}
}


new SimObject(logic_timer);
logic_timer.startTimer(logic_tick, 5);