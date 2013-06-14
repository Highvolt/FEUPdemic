function create_cure(){
	%this=new ScriptObject(){ class="cure"; };
	%this.progression=0;
	%this.curing=false;
}

function cure::awareness_prob(){
	%p = 0;
	if( gen() < %p ){
		%this.start_cure();
	}
}

function cure::start_cure(){
	//
}