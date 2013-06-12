
$disease = create_disease();
$cure = create_cure();
$dna_points = 0;


function logic_tick(){
	for(%i=0; %i<REGIONS_SIZE; ++%i){
		%reg = regions[%i];
		if(%reg.is_infected()){
			%reg.tick();
			%reg.yellow_prob();
			%reg.propagate();
		}
	}
}