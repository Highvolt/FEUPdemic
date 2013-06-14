function create_disease(){
	%this=new ScriptObject(){ class="disease"; };

	%this.infection_percentage=0.1;
	%this.severity_percentage=0;
	%this.fatality_percentage=0;
	
	%this.world_total=$FEUP_POPULATION;
	%this.world_uninfected=%this.world_total;
	%this.world_infected=0;
	%this.world_death=0;

	//infections
	%this.TL1=0;
	%this.TL2=0;
	%this.TM1=0;
	%this.TM2=0;
	%this.TH1=0;
	%this.TH2=0;
	%this.TL3=0;
	%this.TH3=0;
	%this.TempL1=0;
	%this.TempL2=0;
	%this.TempM1=0;
	%this.TempM2=0;
	%this.TempH1=0;
	%this.TempH2=0;
	%this.TempL3=0;
	%this.TempH3=0;
	%this.Temp4=0;
	%this.PL1=0;
	%this.PL2=0;
	%this.PM1=0;
	%this.PM2=0;
	%this.PH1=0;
	%this.PH2=0;
	%this.PL3=0;
	%this.PH3=0;
	%this.P4=0;

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

   //resistances
   %this.res1=0;
   %this.res2=0;
   %this.res3=0;
   %this.res4=0;

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
