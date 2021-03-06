
$disease = create_disease();
$cure = create_cure();
$dna_points = 0;
$logic_tick=false;

$REGIONS_SIZE = 57;
$regions[0]=create_region(0, "Auditorio", "HOT", "HIGH", "HITECH", 193, "1,3");
$regions[1]=create_region(1, "Administracao","TEMPERATE", "MEDIUM", "MEDIUM", 190, "2,0,3");
$regions[2]=create_region(2, "Secretaria", "TEMPERATE", "MEDIUM", "MEDIUM", 100, "4,5,1");
$regions[3]=create_region(3, "Bar de minas", "TEMPERATE", "HIGH", "PRIMITIVE", 190, "0,1,15");
$regions[4]=create_region(4, "Tesouraria", "TEMPERATE", "LOW", "PRIMITIVE", 190, "2,5");
$regions[5]=create_region(5, "B - Bloco VII", "TEMPERATE", "MEDIUM", "PRIMITIVE", 190, "4,6");
$regions[6]=create_region(6, "B - Bloco VI", "TEMPERATE", "MEDIUM", "PRIMITIVE", 190, "5,7,16");
$regions[7]=create_region(7, "B - Bloco V", "TEMPERATE", "MEDIUM", "PRIMITIVE", 190, "6,8,17,16");
$regions[8]=create_region(8, "B - Bloco IV", "TEMPERATE", "MEDIUM", "PRIMITIVE", 190, "19,7,12,9,10,11,13");
$regions[9]=create_region(9, "B001", "HOT", "HIGH", "MEDIUM", 170, "18,19,12,10,11,13");
$regions[10]=create_region(10, "B002", "HOT", "HIGH", "MEDIUM", 190, "9,12,11,25,18,13");
$regions[11]=create_region(11, "B003", "HOT", "HIGH", "MEDIUM", 190, "10,9,12,25,14,13");
$regions[12]=create_region(12, "B - Bloco II", "TEMPERATE", "MEDIUM", "HITECH", 194, "9,10,11,14,8,13");
$regions[13]=create_region(13, "B - Bloco III", "TEMPERATE", "MEDIUM", "PRIMITIVE", 191, "9,10,11,12,8");
$regions[14]=create_region(14, "B - Bloco I", "TEMPERATE", "MEDIUM", "HITECH", 190, "12,49,51");
$regions[15]=create_region(15, "E - Quimica I", "HOT", "LOW", "PRIMITIVE", 190, "3,1,16");
$regions[16]=create_region(16, "E - Quimica II", "HOT", "LOW", "PRIMITIVE", 190, "15,17,6");
$regions[17]=create_region(17, "F - Minas e Metalurgia I", "HOT", "LOW", "PRIMITIVE", 190, "48,46,47,16,19,7");
$regions[18]=create_region(18, "G - Civil II", "TEMPERATE", "HIGH", "PRIMITIVE", 200, "19,20,21,25,9,10");
$regions[19]=create_region(19, "G - Civil I", "TEMPERATE", "HIGH", "PRIMITIVE", 190, "17,20,21,18,9");
$regions[20]=create_region(20, "G - Civil III", "TEMPERATE", "HIGH", "PRIMITIVE", 190, "19,18,21");
$regions[21]=create_region(21, "G - Civil IV", "TEMPERATE", "HIGH", "PRIMITIVE", 190, "43,20,25,22");
$regions[22]=create_region(22, "Ponte G-H", "COLD", "LOW", "PRIMITIVE", 195, "43,21");
$regions[23]=create_region(23, "J - Electrotecnia Norte II", "HOT", "HIGH", "HITECH",190, "24,41,32");
$regions[24]=create_region(24, "J - Electrotecnia Norte I", "HOT", "HIGH", "HITECH", 190, "25,41,23,44,31");
$regions[25]=create_region(25, "I - Electrotecnia I", "HOT", "HIGH", "HITECH", 193, "24,21,27,26,18");
$regions[26]=create_region(26, "I - Electrotecnia II", "HOT", "HIGH", "HITECH", 190, "25,27,29,28");
$regions[27]=create_region(27, "I - Electrotecnia III", "HOT", "HIGH", "HITECH", 190, "26,29,24,31,30");
$regions[28]=create_region(28, "D - CICA", "HOT", "MEDIUM", "HITECH", 197, "14,26,29,49");
$regions[29]=create_region(29, "L - Mecanica I", "HOT", "HIGH", "MEDIUM", 190, "26,27,30,28");
$regions[30]=create_region(30, "L - Mecanica II", "HOT", "HIGH", "MEDIUM", 190, "27,29,31");
$regions[31]=create_region(31, "M - Mecanica Norte I", "HOT", "HIGH", "MEDIUM", 190, "24,30,32");
$regions[32]=create_region(32, "M - Mecanica Norte II", "HOT", "HIGH", "MEDIUM", 190, "31,33,23");
$regions[33]=create_region(33, "M - Mecanica Norte III", "HOT", "HIGH", "MEDIUM", 190, "32,34");
$regions[34]=create_region(34, "M - Mecanica Norte IV", "HOT", "HIGH", "MEDIUM", 190, "33,38");
$regions[35]=create_region(35, "T - IDMEC I", "COLD", "LOW", "MEDIUM", 190, "37,36,38");
$regions[36]=create_region(36, "T - IDMEC II", "COLD", "LOW", "MEDIUM", 190, "35,38");
$regions[37]=create_region(37, "U - INEGI II", "TEMPERATE", "MEDIUM", "HITECH", 192, "38,35,40");
$regions[38]=create_region(38, "U - INEGI I", "TEMPERATE", "MEDIUM", "HITECH", 190, "39,37,35,36");
$regions[39]=create_region(39, "S - INESC I", "TEMPERATE", "MEDIUM", "HITECH", 193, "40,38,45");
$regions[40]=create_region(40, "S - INESC II", "TEMPERATE", "MEDIUM", "HITECH", 192, "39,37");
$regions[41]=create_region(41, "K - Pavilhao FCNAUP", "COLD", "LOW", "PRIMITIVE", 190, "45,44,24,23");
$regions[42]=create_region(42, "H - Civil Norte II", "TEMPERATE", "HIGH", "PRIMITIVE", 190, "43,45,22");
$regions[43]=create_region(43, "H - Civil Norte I", "TEMPERATE", "HIGH", "PRIMITIVE", 210, "42,45,44,21");
$regions[44]=create_region(44, "H - Civil Norte III", "TEMPERATE", "HIGH", "PRIMITIVE", 190, "43,45,24,41");
$regions[45]=create_region(45, "H - Civil Norte IV", "TEMPERATE", "HIGH", "PRIMITIVE", 190, "42,43,44,41");
$regions[46]=create_region(46, "G - Central de Gases", "COLD", "LOW", "PRIMITIVE", 190, "17,47,48");
$regions[47]=create_region(47, "R - Laboratorio de Ambiente", "COLD", "LOW", "PRIMITIVE", 200, "43,48,46");
$regions[48]=create_region(48, "F - Minas e Metalurgia II", "HOT", "LOW", "PRIMITIVE", 190, "46,47,42,17");
$regions[49]=create_region(49, "C - Biblioteca I", "HOT", "HIGH", "PRIMITIVE", 190, "14,28,50");
$regions[50]=create_region(50, "C - Biblioteca II", "HOT", "HIGH", "PRIMITIVE", 190, "49");
$regions[51]=create_region(51, "P - Cantina I", "HOT", "HIGH", "PRIMITIVE", 196, "14,52,55");
$regions[52]=create_region(52, "P - Cantina II", "HOT", "HIGH", "PRIMITIVE", 190, "51,55,53");
$regions[53]=create_region(53, "P - Cantina III", "HOT", "HIGH", "PRIMITIVE", 220, "52,51,55");
$regions[54]=create_region(54, "AEFEUP I", "COLD", "HIGH", "MEDIUM", 192, "56,55");
$regions[55]=create_region(55, "AEFEUP II", "HOT", "HIGH", "MEDIUM", 194, "56,51,52,53,54");
$regions[56]=create_region(56, "AEFEUP III", "MEDIUM", "HIGH", "MEDIUM", 191, "55,54");

//$regions[14].infect(2);

function add_dna(%n){
  $dna_points+=%n;
  setDna($dna_points); 
}

function has_dna(%n){
   return $dna_points>=%n;  
}

function remove_dna(%n){
   if(has_dna(%n)){
      $dna_points-=%n;
      setDna($dna_points);   
   }
      
}

function logic_timer::logic_tick(){
  if(!$logic_tick) {
     $logic_tick=true;
     if(!$menu_open){
        %active=false;
         for(%i=0; %i<$REGIONS_SIZE; %i++){
            %reg = $regions[%i];
            if(%reg.infected>0)
               %active=true;
            if(%reg.is_infected()){
               %reg.tick();
               %reg.yelLOW_prob();
               %reg.propagate();
            }
         }
         
         if($disease.world_death==$disease.world_total){
            echo("you win");
            messageBox("WIN","WIN!!!!!");
            logic_timer.stopTimer();
            quit(); 

         } else if(!%active){
            echo("you lose");
            messageBox("Lose","Game Over!!!!!");
            logic_timer.stopTimer();
            quit(); 
         } else if($cure.progression==100){
            echo("cure developed");
            messageBox("Lose","Cure fully developed! Game Over!!!!!");
            logic_timer.stopTimer();
            quit(); 
         }
         
     }
     $logic_tick=false;
   }
}


