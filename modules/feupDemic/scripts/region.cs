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
         
         %this.infect(1/*+mFloor($disease.infection_percentage*0.1*%this.population)*/);
      }
      if(gen() < 0.001+$disease.fatality_percentage*%cutoff*0.08+$disease.severity_percentage*%cutoff*0.05){
         
         %this.kill(1/*+mFloor($disease.fatality_percentage*%cutoff*%this.population*0.09)*/);
      }
      
      if(!$cure.curing){
         if($disease.infection_percentage>0.6 || $disease.severity_percentage+$disease.fatality_percentage>0.25)
            if(gen() < ($disease.infection_percentage+$disease.severity_percentage+$disease.fatality_percentage)*0.1){
               $cure.curing=true;
               %this.deving_cure=true;
            }
      }
      
      if(%this.deving_cure){
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
	//%infected_on_infecter = (%infecter.infected/%infecter.population)*$INFECTED_ON_INFECTER_RATIO;
	%upgrades_percentages = %this.prob_from_infection_upgrades();
	%p+=%infected_on_infecter+%upgrades_percentages;
	%g = gen();
   //echo("gen:" SPC %g SPC"infected_on_infecter:" SPC %infected_on_infecter SPC "upgrades_percentages:" SPC %upgrades_percentages);
	if( %g < %p*0.2 ){
	   if(!%this.has_popup && !%this.is_infected()){
		   createPopup(%this,"red");
		   %this.has_popup=true;
		   add_dna(1); 
	   }
		%this.infect(1/*+mFloor(%p*%this.population*0.5)*/);
	}
}

function region::prob_from_infection_upgrades(%this){
	%p = 0;

	switch$ (%this.temperature) 
	{
	   case "COLD":
			%p+= $disease.templ1*$TEMP_COLD_LV1_PROBABILITY+
				 $disease.templ2*$TEMP_COLD_LV2_PROBABILITY+
				 $disease.templ3*$TEMP_COLD_LV3_PROBABILITY+
				 $disease.temp4*$TEMP_LV4_PROBABILITY;
	   case "TEMPERATE":
	   		%p+= $disease.tempm1*$TEMP_TEMPERATE_LV1_PROBABILITY+
				 $disease.tempm2*$TEMP_TEMPERATE_LV2_PROBABILITY+
				 $disease.templ3*$TEMP_COLD_LV3_PROBABILITY+
				 $disease.temph3*$TEMP_HOT_LV3_PROBABILITY+
				 $disease.temp4*$TEMP_LV4_PROBABILITY;
	   case "HOT":
	   		%p+= $disease.temph1*$TEMP_HOT_LV1_PROBABILITY+
				 $disease.temph2*$TEMP_HOT_LV2_PROBABILITY+
				 $disease.temph3*$TEMP_HOT_LV3_PROBABILITY+
				 $disease.temp4*$TEMP_LV4_PROBABILITY;
    }

    switch$ (%this.density) 
	{
	   case "LOW":
			%p+= $disease.pl1*$DENS_LOW_LV1_PROBABILITY+
				 $disease.pl2*$DENS_LOW_LV2_PROBABILITY+
				 $disease.pl3*$DENS_LOW_LV3_PROBABILITY+
				 $disease.p4*$DENS_LV4_PROBABILITY;
	   case "MEDIUM":
	   		%p+= $disease.pm1*$DENS_MEDIUM_LV1_PROBABILITY+
				 $disease.pm2*$DENS_MEDIUM_LV2_PROBABILITY+
				 $disease.ph3*$DENS_HIGH_LV3_PROBABILITY+
				 $disease.pl3*$DENS_LOW_LV3_PROBABILITY+
				 $disease.p4*$DENS_LV4_PROBABILITY;
	   case "HIGH":
	   		%p+= $disease.ph1*$DENS_HIGH_LV1_PROBABILITY+
				 $disease.ph*$DENS_HIGH_LV2_PROBABILITY+
				 $disease.ph3*$DENS_HIGH_LV3_PROBABILITY+
				 $disease.p4*$DENS_LV4_PROBABILITY;
    }

    switch$ (%this.tech_level) 
	{
	   case "PRIMITIVE":
			%p+= $disease.tl1*$TECH_PRIMITIVE_LV1_PROBABILITY+
				 $disease.l2*$TECH_PRIMITIVE_LV2_PROBABILITY+
				 $disease.tl*$TECH_PRIMITIVE_LV3_PROBABILITY;
	   case "MEDIUM":
	   		%p+= $disease.tm1*$TECH_MEDIUM_LV1_PROBABILITY+
				 $disease.tm2*$TECH_MEDIUM_LV2_PROBABILITY+
				 $disease.tl3*$TECH_PRIMITIVE_LV3_PROBABILITY+
            	 $disease.th3*$TECH_HITECH_LV3_PROBABILITY;
	   case "HITECH":
	   		%p+= $disease.th1*$TECH_HITECH_LV1_PROBABILITY+
				 $disease.th2*$TECH_HITECH_LV2_PROBABILITY+
				 $disease.th3*$TECH_HITECH_LV3_PROBABILITY;
    }

    %p+= $disease.infection_percentage*0.1;

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