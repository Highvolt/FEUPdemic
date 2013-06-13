function create_region(%id, %name, %temperature, %density, %tech_level, %population, %neighbours){
	%this=new ScriptObject(){ class="region"; };
	%this.name = %name;
	%this.id = %id;
	%this.temperature = %temperature;
	%this.density = %density;
	%this.tech_level = %tech_level;
	%this.population = %population;
	%this.infected = 0;
	%this.death = 0;
	%this.deving_cure = false;
	%this.neighbours = %neighbours;
	%this.nr_of_neighbours = getUnitCount(%neighbours,",");
	%this.has_popup = false;
	return %this;
}

function region::tick(%this){
   if(gen() < 0.1)
	   %this.infect(1);
   if(gen() < 0.01)
      %this.kill(1);
}

function region::propagate(%this){
   if(%this.is_infected()){
      for(%i = 0; %i < %this.nr_of_neighbours; %i++){
         %reg = $regions[getUnit(%this.neighbours,%i,",")];
         if(!%reg.is_infected()){
            %reg.red_prob(%this);
         }
      }
   }
}

function region::yellow_prob(%this){
  
   %g = gen();
   //echo("g:" SPC %g SPC "yellow:" SPC $YELLOW_PROBABILITY SPC %this.has_popup);
	if(%g < $YELLOW_PROBABILITY){
	   if(!%this.has_popup){
		   createPopup(%this,"yellow");
		   %this.has_popup=true;
      }
	}
}

function region::red_prob(%this, %infecter){
	%p = 0;
	%infected_on_infecter = %infecter.infected/%infecter.population*$INFECTED_ON_INFECTER_RATIO;
	%upgrades_percentages = %this.prob_from_infection_upgrades();
	%p+=%infected_on_infecter+%upgrades_percentages;
	%g = gen();
   //echo("gen:" SPC %g SPC"infected_on_infecter:" SPC %infected_on_infecter SPC "upgrades_percentages:" SPC %upgrades_percentages);
	if( %g < %p ){
	   if(!%this.has_popup){
		   createPopup(%this,"red");
		   %this.has_popup=true;
	   }
		%this.infect(1);
	}
}

function region::prob_from_infection_upgrades(%this){
	%p = 0;

	switch$ (temperature) 
	{
	   case "cold":
			%p+= $disease.temp_cold_lv1*$TEMP_COLD_LV1_PROBABILITY+
				 $disease.temp_cold_lv2*$TEMP_COLD_LV2_PROBABILITY;
	   case "temperate":
	   		%p+= $disease.temp_temperate_lv1*$TEMP_TEMPERATE_LV1_PROBABILITY+
				 $disease.temp_temperate_lv2*$TEMP_TEMPERATE_LV2_PROBABILITY;
	   case "hot":
	   		%p+= $disease.temp_hot_lv1*$TEMP_HOT_LV1_PROBABILITY+
				 $disease.temp_hot_lv2*$TEMP_HOT_LV2_PROBABILITY;
    }

    switch$ (density) 
	{
	   case "low":
			%p+= $disease.dens_low_lv1*$DENS_LOW_LV1_PROBABILITY+
				 $disease.dens_low_lv2*$DENS_LOW_LV2_PROBABILITY;
	   case "medium":
	   		%p+= $disease.dens_medium_lv1*$DENS_MEDIUM_LV1_PROBABILITY+
				 $disease.dens_medium_lv2*$DENS_MEDIUM_LV2_PROBABILITY;
	   case "high":
	   		%p+= $disease.dens_high_lv1*$DENS_HIGH_LV1_PROBABILITY+
				 $disease.dens_high_lv2*$DENS_HIGH_LV2_PROBABILITY;
    }

    switch$ (tech_level) 
	{
	   case "primitive":
			%p+= $disease.tech_primitive_lv1*$TECH_PRIMITIVE_LV1_PROBABILITY+
				 $disease.tech_primitive_lv2*$TECH_PRIMITIVE_LV2_PROBABILITY;
	   case "medium":
	   		%p+= $disease.tech_medium_lv1*$TECH_MEDIUM_LV1_PROBABILITY+
				 $disease.tech_medium_lv2*$TECH_MEDIUM_LV2_PROBABILITY;
	   case "hitech":
	   		%p+= $disease.tech_hitech_lv1*$TECH_HITECH_LV1_PROBABILITY+
				 $disease.tech_hitech_lv2*$TECH_HITECH_LV2_PROBABILITY;
    }

    %p+= $disease.tech_temp_lv3*$TECH_TEMP_LV3_PROBABILITY+
		 $disease.temp_dens_lv3*$TEMP_DENS_LV3_PROBABILITY+
		 $disease.infection_percentage*0.1;

	return %p;
}

function region::infect(%this, %n){
	%this.infected += %n;
	setOpacity(%this,((%this.infected+%this.death)/%this.population));
}

function region::kill(%this, %n){
	%this.infected -= %n;
	%this.death += %n;
}

function region::is_infected(%this){
	return %this.infected>0;
}

function region::handlePopUp(%this, %kind){
   switch$ (%kind){
      case "close":
         
      case "red":
         %this.infect(60);
      case "yellow": 
         %this.infect(80); 
   }
   %this.has_popup=false;
}