
$disease = create_disease();
$cure = create_cure();
$dna_points = 0;

$REGIONS_SIZE = 56;
$regions[0]=create_region(0, "Auditório", "hot", "high", "hitech", 193, "1,3");
$regions[1]=create_region(1, "Administração","temperate", "medium", "medium", 193, "2,0,3");
$regions[2]=create_region(2, "Secretaria", "temperate", "medium", "medium", 193, "4,5,1");
$regions[3]=create_region(3, "Bar de minas", "temperate", "high", "primitive", 193, "0,1,15");
$regions[4]=create_region(4, "Tesouraria", "temperate", "low", "primitive", 193, "2,5");
$regions[5]=create_region(5, "B - Bloco VII", "temperate", "medium", "primitive", 193, "4,6");
$regions[6]=create_region(6, "B - Bloco VI", "temperate", "medium", "primitive", 193, "5,7,16");
$regions[7]=create_region(7, "B - Bloco V", "temperate", "medium", "primitive", 193, "6,8,17,16");
$regions[8]=create_region(8, "B - Bloco IV", "temperate", "medium", "primitive", 193, "19,7,12,9,10,11,13");
$regions[9]=create_region(9, "B001", "hot", "high", "medium", 193, "18,19,12,10,11,13");
$regions[10]=create_region(10, "B002", "hot", "high", "medium", 193, "9,12,11,25,18,13");
$regions[11]=create_region(11, "B003", "hot", "high", "medium", 193, "10,9,12,25,14,13");
$regions[12]=create_region(12, "B - Bloco II", "temperate", "medium", "hitech", 193, "9,10,11,14,8,13");
$regions[13]=create_region(13, "B - Bloco III", "temperate", "medium", "primitive", 193, "9,10,11,12,8");
$regions[14]=create_region(14, "B - Bloco I", "temperate", "medium", "hitech", 193, "12,49,51");
$regions[15]=create_region(15, "E - Quimica I", "hot", "low", "primitive", 503, "3,1,16");
$regions[16]=create_region(16, "E - Quimica II", "hot", "low", "primitive", 503, "15,17,6");
$regions[17]=create_region(17, "F - Minas e Metalurgia I", "hot", "low", "primitive", 503, "48,46,47,16,19,7");
$regions[18]=create_region(18, "G - Civil II", "temperate", "high", "primitive", 503, "19,20,21,25,9,10");
$regions[19]=create_region(19, "G - Civil I", "temperate", "high", "primitive", 503, "17,20,21,18,9");
$regions[20]=create_region(20, "G - Civil III", "temperate", "high", "primitive", 503, "19,18,21");
$regions[21]=create_region(21, "G - Civil IV", "temperate", "high", "primitive", 503, "43,20,25");
$regions[22]=create_region(22, "Ponte G-H", "cold", "low", "primitive", 503, "43,21");
$regions[23]=create_region(23, "J - Electrotecnia Norte II", "hot", "high", "hitech", 503, "24,41,32");
$regions[24]=create_region(24, "J - Electrotecnia Norte I", "hot", "high", "hitech", 503, "25,41,23,44,31");
$regions[25]=create_region(25, "I - Electrotecnia I", "hot", "high", "hitech", 503, "24,21,27,26,18");
$regions[26]=create_region(26, "I - Electrotecnia II", "hot", "high", "hitech", 503, "25,27,29,28");
$regions[27]=create_region(27, "I - Electrotecnia III", "hot", "high", "hitech", 503, "26,29,24,31,30");
$regions[28]=create_region(28, "D - CICA", "hot", "medium", "hitech", 193, "14,26,29,49");
$regions[29]=create_region(29, "L - Mecânica I", "hot", "high", "medium", 503, "26,27,30,28");
$regions[30]=create_region(30, "L - Mecânica II", "hot", "high", "medium", 503, "27,29,31");
$regions[31]=create_region(31, "M - Mecânica Norte I", "hot", "high", "medium", 503, "24,30,32");
$regions[32]=create_region(32, "M - Mecânica Norte II", "hot", "high", "medium", 503, "31,33,23");
$regions[33]=create_region(33, "M - Mecânica Norte III", "hot", "high", "medium", 503, "32,34");
$regions[34]=create_region(34, "M - Mecânica Norte IV", "hot", "high", "medium", 503, "33,38");
$regions[35]=create_region(35, "T - IDMEC I", "cold", "low", "medium", 503, "37,36,38");
$regions[36]=create_region(36, "T - IDMEC II", "cold", "low", "medium", 503, "35,38");
$regions[37]=create_region(37, "U - INEGI II", "temperate", "medium", "hitech", 503, "38,35,40");
$regions[38]=create_region(38, "U - INEGI I", "temperate", "medium", "hitech", 503, "39,37,35,36");
$regions[39]=create_region(39, "S - INESC I", "temperate", "medium", "hitech", 503, "40,38,45");
$regions[40]=create_region(40, "S - INESC II", "temperate", "medium", "hitech", 503, "39,37");
$regions[41]=create_region(41, "K - Pavilhão FCNAUP", "cold", "low", "primitive", 503, "45,44,24,23");
$regions[42]=create_region(42, "H - Civil Norte II", "temperate", "high", "primitive", 503, "43,45");
$regions[43]=create_region(43, "H - Civil Norte I", "temperate", "high", "primitive", 503, "42,45,44,21");
$regions[44]=create_region(44, "H - Civil Norte III", "temperate", "high", "primitive", 503, "43,45,24,41");
$regions[45]=create_region(45, "H - Civil Norte IV", "temperate", "high", "primitive", 503, "42,43,44,41");
$regions[46]=create_region(46, "G - Central de Gases", "cold", "low", "primitive", 503, "17,47,48");
$regions[47]=create_region(47, "R - Laboratório de Ambiente", "cold", "low", "primitive", 503, "43,48,46");
$regions[48]=create_region(48, "F - Minas e Metalurgia II", "hot", "low", "primitive", 503, "46,47,42,17");
$regions[49]=create_region(49, "C - Biblioteca I", "hot", "high", "primitive", 503, "14,28,50");
$regions[50]=create_region(50, "C - Biblioteca II", "hot", "high", "primitive", 503, "49");
$regions[51]=create_region(51, "P - Cantina I", "hot", "high", "primitive", 503, "14,52,55");
$regions[52]=create_region(52, "P - Cantina II", "hot", "high", "primitive", 503, "51,55,53");
$regions[53]=create_region(53, "P - Cantina III", "hot", "high", "primitive", 503, "52,51,55");
$regions[54]=create_region(54, "AEFEUP I", "cold", "high", "medium", 503, "56,55");
$regions[55]=create_region(55, "AEFEUP II", "hot", "high", "medium", 503, "56,51,52,53,54");
$regions[56]=create_region(56, "AEFEUP III", "medium", "high", "medium", 503, "55,54");

$regions[0].infect(2);

function logic_timer::logic_tick(){
  
	for(%i=0; %i<=$REGIONS_SIZE; %i++){
		%reg = $regions[%i];
		if(%reg.is_infected()){
			%reg.tick();
			%reg.yellow_prob();
			%reg.propagate();
		}
	}
}


new SimObject(logic_timer);
logic_timer.startTimer(logic_tick, 500);