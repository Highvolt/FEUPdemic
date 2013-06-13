function create_disease(){
	%this=new ScriptObject(){ class="disease"; };

	%this.infection_percentage=0.2;
	%this.severity_percentage=0.2;
	%this.fatality_percentage=0.2;
	
	%this.world_total=10833;
	%this.world_uninfected=10833;
	%this.world_infected=0;
	%this.world_death=0;

	//infections
	%this.tech_primitive_lv1=0;
	%this.tech_primitive_lv2=0;
	%this.tech_medium_lv1=0;
	%this.tech_medium_lv2=0;
	%this.tech_hitech_lv1=0;
	%this.tech_hitech_lv2=0;

	%this.tech_temp_lv3=0;

	%this.temp_cold_lv1=0;
	%this.temp_cold_lv2=0;
	%this.temp_temperate_lv1=0;
	%this.temp_temperate_lv2=0;
	%this.temp_hot_lv1=0;
	%this.temp_hot_lv2=0;

	%this.temp_dens_lv3=0;

	%this.dens_low_lv1=0;
	%this.dens_low_lv2=0;
	%this.dens_medium_lv1=0;
	%this.dens_medium_lv2=0;
	%this.dens_high_lv1=0;
	%this.dens_high_lv2=0;

	//disease
	%this.dis1=0;
	%this.dis2=0;
	%this.dis3=0;
	%this.dis4=0;
	%this.dis5=0;
	%this.dis6=0;
	%this.dis7=0;
	%this.dis8=0;
	%this.dis9=0;
	%this.dis10=0;
	%this.dis11=0;
	%this.dis12=0;
	%this.dis13=0;
	%this.dis14=0;
	%this.dis15=0;
	%this.dis16=0;
	%this.dis17=0;
	%this.dis18=0;
	%this.dis19=0;
	%this.dis20=0;
	%this.dis21=0;
	%this.dis22=0;
	%this.dis23=0;
	%this.dis24=0;
	%this.dis25=0;
	%this.dis26=0;
	%this.dis27=0;
	%this.dis28=0;
	%this.dis29=0;
	%this.dis30=0;
	%this.dis31=0;
	%this.dis32=0;
	%this.dis33=0;
	%this.dis34=0;
	%this.dis35=0;
	%this.dis36=0;
	%this.dis37=0;

	return %this;
}

function disease::infect(%this, %n){
   %this.world_uninfected-=%n;
   %this.world_infected+=%n;
}

function disease::kill(%this, %n){
   %this.world_infected-=%n;
   %this.world_death+=%n;
}

function disease::updateMenu(%this){
	//echo("########################" TAB %this.infection_percentage);
	setInfectivity(%this.infection_percentage);
	setSeverity(%this.severity_percentage);
	setLethality(%this.fatality_percentage);
}
