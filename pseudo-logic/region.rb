population: int #total population
infected: int #number of people infected
density: density
temperature: temperature
technologic_level: technologic_level
deving_cure:0
id

def tick
	#check region types and disease strength
end

def propagate
	self.neighbours.each do |neighbour|
		neighbours.red_prob(self)
	end
end

def yellow_prob
	yellow_popup if gen < YELLOW_PROBABILITY 	
end


def red_prob(infecter)
	percentage = 0
	#check infecter, self and (global)disease properties and create a percentage
	#+META
	#number of infected people (infected/population)
	#temp, tech and density disease upgrades get bonus if country matches any
	infected_on_infecter = infecter.infected/infecter.population*0.1
	upgrades_percegage = prob_from_disease_infection_upgrades
	
	percentage+=infected_on_infecter+upgrades_percegage

	if gen < percentage	
		red_popup(self)
		infect(1)
	end
end

def prob_from_disease_infection_upgrades
	p=0

	switch(temperature)
		case cold:
			p+= temp_cold_lv1*TEMP_COLD_LV1_PROBABILITY+
				temp_cold_lv2*TEMP_COLD_LV2_PROBABILITY
		end
		case temperate:
			p+= temp_temperate_lv1*TEMP_TEMPERATE_LV1_PROBABILITY+
				temp_temperate_lv2*TEMP_TEMPERATE_LV2_PROBABILITY
		end
		case hot:
			p+= temp_hot_lv1*TEMP_HOT_LV1_PROBABILITY+
				temp_hot_lv2*TEMP_HOT_LV2_PROBABILITY
		end
	end

	switch(density)
		case low:
			p+= dens_low_lv1*DENS_LOW_LV1_PROBABILITY+
				dens_low_lv2*DENS_LOW_LV2_PROBABILITY
		end
		case medium:
			p+= dens_medium_lv1*DENS_MEDIUM_LV1_PROBABILITY+
				dens_medium_lv2*DENS_MEDIUM_LV2_PROBABILITY
		end
		case high:
			p+= dens_high_lv1*DENS_HIGH_LV1_PROBABILITY+
				dens_high_lv2*DENS_HIGH_LV2_PROBABILITY
		end
	end

	switch(technologic_level)
		case primitive:
			p+= tech_primitive_lv1*TECH_PRIMITIVE_LV1_PROBABILITY+
				tech_primitive_lv2*TECH_PRIMITIVE_LV2_PROBABILITY
		end
		case medium:
			p+= tech_medium_lv1*TECH_MEDIUM_LV1_PROBABILITY+
				tech_medium_lv2*TECH_MEDIUM_LV2_PROBABILITY
		end
		case hitech:
			p+= tech_hitech_lv1*TECH_HITECH_LV1_PROBABILITY+
				tech_hitech_lv2*TECH_HITECH_LV2_PROBABILITY
		end
	end

	p+= tech_temp_lv3*TECH_TEMP_LV3_PROBABILITY+
		temp_dens_lv3*TEMP_DENS_LV3_PROBABILITY+
		disease.infection_percentage*0.1


	return p
end

def infect n
	infected += n
end

def kill n
	infected -= n
	death += n
end