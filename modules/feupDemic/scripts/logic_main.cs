
$disease = create_disease();
$cure = create_cure();
$dna_points = 0;

$regions[0]=create_region(0, "hot", "low", "primitive", 500, "1,2,3");
$regions[1]=create_region(1, "hot", "low", "primitive", 500, "1,2,3");
$regions[2]=create_region(2, "hot", "low", "primitive", 500, "1,2,3");
$regions[3]=create_region(3, "hot", "low", "primitive", 500, "1,2,3");
//$regions[1]="1";
//$regions[2]="2";
//$regions[3]="3";
//$regions[4]="4";
//$regions[5]="5";
//$regions[6]="6";
//$regions[7]="7";
//$regions[8]="8";
//$regions[9]="9";


function logic_tick(){
	for(%i=0; %i<REGIONS_SIZE; %i++){
		%reg = $regions[%i];
		if(%reg.is_infected()){
			%reg.tick();
			%reg.yellow_prob();
			%reg.propagate();
		}
	}
}