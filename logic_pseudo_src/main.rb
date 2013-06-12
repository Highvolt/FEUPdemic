regions: region[]
cure: cure
disease: disease
dna_points: 0

def tick:
	map.regions.each do |region|
	if region.is_infected?
		region.tick
		region.yellow_prob
		region.propagate		
	end
	if cure.curing?
		cure.tick
	else
		cure.awareness_prob	
	end	
end
