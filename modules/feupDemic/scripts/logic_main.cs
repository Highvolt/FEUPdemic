
$disease = create_disease();
$cure = create_cure();
$dna_points = 0;

$REGIONS_SIZE = 4;
$regions[0]=create_region(0, "Um", "hot", "low", "primitive", 500, "1,2,3");
$regions[1]=create_region(1, "Dois","hot", "low", "primitive", 501, "1,2,3");
$regions[2]=create_region(2, "Tres", "hot", "low", "primitive", 502, "1,2,3");
$regions[3]=create_region(3, "Quatro", "hot", "low", "primitive", 503, "1,2,3");

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