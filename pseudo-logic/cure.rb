curing:bool = false
regions: region[]
progression= 0 

def tick
	percentage = #check disease characteristics and resistances 
	progression++ if gen < percentage
end

def awareness_prob
	percentage = #check disease spread in regions
	if gen < percentage
		start_cure
	end
end

def start_cure
	region = #pick region for cure development
	region.deving_cure=true
	curing = true
end
