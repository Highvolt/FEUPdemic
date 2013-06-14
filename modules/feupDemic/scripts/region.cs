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
   if(%this.infected>0){
      %cutoff = 0.7;
      %g = gen();
      //echo("g:" SPC %g TAB "pass:" SPC $disease.infection_percentage*%cutoff);
      if(%g < $disease.infection_percentage*%cutoff){
         
         %this.infect(1+mFloor($disease.infection_percentage*%cutoff*%this.population));
      }
      if(gen() < 0.001+$disease.fatality_percentage*%cutoff+$disease.severity_percentage*%cutoff){
         
         %this.kill(1+mFloor($disease.fatality_percentage*%cutoff*%this.population));
      }
      
      if(!$cure.curing){
         if($disease.infection_percentage>0.6 || $disease.severity_percentage+$disease.fatality_percentage>0.25)
            if(gen() < ($disease.infection_percentage+$disease.severity_percentage+$disease.fatality_percentage)*0.1){
               $cure.curing=true;
               %this.deving_cure=true;
            }
      }
      
      if(%his.deving_cure){
         if(gen() < 0.1-($disease.res1*$RES_1_PROB+$disease.res2*$RES_2_PROB+$disease.res3*$RES_3_PROB+$disease.res4*$RES_4_PROB)){
            $cure.progression++;
            setCure($cure.progression); 
         }
      }
   }
}

function region::propagate(%this){
   if(%this.infected>0){
      for(%i = 0; %i < %this.nr_of_neighbours; %i++){
         %reg = $regions[getUnit(%this.neighbours,%i,",")];
         //if(!%reg.is_infected()){
            %reg.red_prob(%this);
         //}
      }
   }
}

function region::yellow_prob(%this){
  
   %g = gen();
   //echo("g:" SPC %g SPC "yellow:" SPC $YELLOW_PROBABILITY SPC %this.has_popup);
	if(%this.infected>0 && %g < $YELLOW_PROBABILITY){
	   if(!%this.has_popup){
		   createPopup(%this,"yellow");
		   %this.has_popup=true;
		   add_dna(1);
      }
	}
}

function region::red_prob(%this, %infecter){
	%p = 0;
	%infected_on_infecter = (%infecter.infected/%infecter.population)*$INFECTED_ON_INFECTER_RATIO;
	%upgrades_percentages = %this.prob_from_infection_upgrades();
	%p+=%infected_on_infecter+%upgrades_percentages;
	%g = gen();
   //echo("gen:" SPC %g SPC"infected_on_infecter:" SPC %infected_on_infecter SPC "upgrades_percentages:" SPC %upgrades_percentages);
	if( %g < %p ){
	   if(!%this.has_popup && !%this.is_infected()){
		   createPopup(%this,"red");
		   %this.has_popup=true;
		   add_dna(1); 
	   }
		%this.infect(1+mFloor(%p*%this.population*0.5));
	}
}

function region::prob_from_infection_upgrades(%this){
	%p = 0;

	switch$ (%this.temperature) 
	{
	   case "COLD":
			%p+= $disease.temp_cold_lv1*$TEMP_COLD_LV1_PROBABILITY+
				 $disease.temp_cold_lv2*$TEMP_COLD_LV2_PROBABILITY+
				 $disease.temp_cold_lv3*$TEMP_COLD_LV3_PROBABILITY+
				 $disease.temp_lv4*$TEMP_LV4_PROBABILITY;
	   case "TEMPERATE":
	   		%p+= $disease.temp_temperate_lv1*$TEMP_TEMPERATE_LV1_PROBABILITY+
				 $disease.temp_temperate_lv2*$TEMP_TEMPERATE_LV2_PROBABILITY+
				 $disease.temp_cold_lv3*$TEMP_COLD_LV3_PROBABILITY+
				 $disease.temp_hot_lv3*$TEMP_HOT_LV3_PROBABILITY+
				 $disease.temp_lv4*$TEMP_LV4_PROBABILITY;
	   case "HOT":
	   		%p+= $disease.temp_hot_lv1*$TEMP_HOT_LV1_PROBABILITY+
				 $disease.temp_hot_lv2*$TEMP_HOT_LV2_PROBABILITY+
				 $disease.temp_hot_lv3*$TEMP_HOT_LV3_PROBABILITY+
				 $disease.temp_lv4*$TEMP_LV4_PROBABILITY;
    }

    switch$ (%this.density) 
	{
	   case "LOW":
			%p+= $disease.dens_low_lv1*$DENS_LOW_LV1_PROBABILITY+
				 $disease.dens_low_lv2*$DENS_LOW_LV2_PROBABILITY+
				 $disease.dens_low_lv3*$DENS_LOW_LV3_PROBABILITY+
				 $disease.dens_lv4*$DENS_LV4_PROBABILITY;
	   case "MEDIUM":
	   		%p+= $disease.dens_medium_lv1*$DENS_MEDIUM_LV1_PROBABILITY+
				 $disease.dens_medium_lv2*$DENS_MEDIUM_LV2_PROBABILITY+
				 $disease.dens_high_lv3*$DENS_HIGH_LV3_PROBABILITY+
				 $disease.dens_low_lv3*$DENS_LOW_LV3_PROBABILITY+
				 $disease.dens_lv4*$DENS_LV4_PROBABILITY;
	   case "HIGH":
	   		%p+= $disease.dens_high_lv1*$DENS_HIGH_LV1_PROBABILITY+
				 $disease.dens_high_lv2*$DENS_HIGH_LV2_PROBABILITY+
				 $disease.dens_high_lv3*$DENS_HIGH_LV3_PROBABILITY+
				 $disease.dens_lv4*$DENS_LV4_PROBABILITY;
    }

    switch$ (%this.tech_level) 
	{
	   case "PRIMITIVE":
			%p+= $disease.tech_primitive_lv1*$TECH_PRIMITIVE_LV1_PROBABILITY+
				 $disease.tech_primitive_lv2*$TECH_PRIMITIVE_LV2_PROBABILITY+
				 $disease.tech_primitive_lv3*$TECH_PRIMITIVE_LV3_PROBABILITY;
	   case "MEDIUM":
	   		%p+= $disease.tech_medium_lv1*$TECH_MEDIUM_LV1_PROBABILITY+
				 $disease.tech_medium_lv2*$TECH_MEDIUM_LV2_PROBABILITY+
				 $disease.tech_primitive_lv3*$TECH_PRIMITIVE_LV3_PROBABILITY+
            $disease.tech_hitech_lv3*$TECH_HITECH_LV3_PROBABILITY;
	   case "HITECH":
	   		%p+= $disease.tech_hitech_lv1*$TECH_HITECH_LV1_PROBABILITY+
				 $disease.tech_hitech_lv2*$TECH_HITECH_LV2_PROBABILITY+
				 $disease.tech_hitech_lv3*$TECH_HITECH_LV3_PROBABILITY;
    }

    %p+= $disease.tech_temp_lv3*$TECH_TEMP_LV3_PROBABILITY+
		 $disease.temp_dens_lv3*$TEMP_DENS_LV3_PROBABILITY+
		 $disease.infection_percentage*0.1;

	return %p;
}

function region::infect(%this, %n){
   %old_infected = %this.infected;
	%this.infected += %n;
	if(%this.infected+%this.death>=%this.population)
	   %this.infected=%this.population-%this.death;
	   else
	   {
	      if(gen() < 0.005)
            add_dna(1+mFloor(0.5*%n));  
	   }
   $disease.infect(%this.infected-%old_infected);
   
	setOpacity(%this,((%this.infected+%this.death)/%this.population));
}

function region::kill(%this, %n){
   if(%this.infected>=%n){
      %this.infected -= %n;
      %this.death += %n;
      $disease.kill(%n);
   } else {
      %this.death += %this.infected;
      $disease.kill(%this.infected);
      %this.infected = 0;
   }
    if(gen() < 0.01)
   add_dna(mFloor(0.5*%n));
}

function region::is_infected(%this){
	return %this.infected+%this.death>0;
}

function region::handlePopUp(%this, %kind){
   switch$ (%kind){
      case "close":
         
      case "red":
         add_dna(3);
      case "yellow": 
         add_dna(1);
   }
   %this.has_popup=false;
}