function create_disease(){
	%this=new ScriptObject(){ class="disease" };

	%this.infection_percentage=0;
	%this.severity_percentage=0;
	%this.fatality_percentage=0;

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

	return %this;
}