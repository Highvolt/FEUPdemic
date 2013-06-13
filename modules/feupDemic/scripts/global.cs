$YELLOW_PROBABILITY = 0.0001;

//INFECTIONS
//probabilities
$TECH_PRIMITIVE_LV1_PROBABILITY=0.01;
$TECH_PRIMITIVE_LV2_PROBABILITY=0.01;
$TECH_MEDIUM_LV1_PROBABILITY=0.01;
$TECH_MEDIUM_LV2_PROBABILITY=0.01;
$TECH_HITECH_LV1_PROBABILITY=0.01;
$TECH_HITECH_LV2_PROBABILITY=0.01;

$TECH_TEMP_LV3_PROBABILITY=0.01;

$TEMP_COLD_LV1_PROBABILITY=0.01;
$TEMP_COLD_LV2_PROBABILITY=0.01;
$TEMP_TEMPERATE_LV1_PROBABILITY=0.01;
$TEMP_TEMPERATE_LV2_PROBABILITY=0.01;
$TEMP_HOT_LV1_PROBABILITY=0.01;
$TEMP_HOT_LV2_PROBABILITY=0.01;

$TEMP_DENS_LV3_PROBABILITY=0.01;

$DENS_LOW_LV1_PROBABILITY=0.01;
$DENS_LOW_LV2_PROBABILITY=0.01;
$DENS_MEDIUM_LV1_PROBABILITY=0.01;
$DENS_MEDIUM_LV2_PROBABILITY=0.01;
$DENS_HIGH_LV1_PROBABILITY=0.01;
$DENS_HIGH_LV2_PROBABILITY=0.01;

//costs
//costs = cost*(//already_upgraded)*COST_SCALING
$COST_SCALING=0.3;

$TECH_PRIMITIVE_LV1_COST=1;
$TECH_PRIMITIVE_LV2_COST=2;
$TECH_MEDIUM_LV1_COST=1;
$TECH_MEDIUM_LV2_COST=2;
$TECH_HITECH_LV1_COST=1;
$TECH_HITECH_LV2_COST=2;

$TECH_TEMP_LV3_COST=3;

$TEMP_COLD_LV1_COST=1;
$TEMP_COLD_LV2_COST=2;
$TEMP_TEMPERATE_LV1_COST=1;
$TEMP_TEMPERATE_LV2_COST=2;
$TEMP_HOT_LV1_COST=1;
$TEMP_HOT_LV2_COST=2;

$TEMP_DENS_LV3_COST=3;

$DENS_LOW_LV1_COST=1;
$DENS_LOW_LV2_COST=2;
$DENS_MEDIUM_LV1_COST=1;
$DENS_MEDIUM_LV2_COST=2;
$DENS_HIGH_LV1_COST=1;
$DENS_HIGH_LV2_COST=2;

//percentages
//to be added to disease.infection_percentage on upgrade
$TECH_PRIMITIVE_LV1_INFECTION_P=0.01;
$TECH_PRIMITIVE_LV2_INFECTION_P=0.01;
$TECH_MEDIUM_LV1_INFECTION_P=0.01;
$TECH_MEDIUM_LV2_INFECTION_P=0.01;
$TECH_HITECH_LV1_INFECTION_P=0.01;
$TECH_HITECH_LV2_INFECTION_P=0.01;

$TECH_TEMP_LV3_INFECTION_P=0.01;

$TEMP_COLD_LV1_INFECTION_P=0.01;
$TEMP_COLD_LV2_INFECTION_P=0.01;
$TEMP_TEMPERATE_LV1_INFECTION_P=0.01;
$TEMP_TEMPERATE_LV2_INFECTION_P=0.01;
$TEMP_HOT_LV1_INFECTION_P=0.01;
$TEMP_HOT_LV2_INFECTION_P=0.01;

$TEMP_DENS_LV3_INFECTION_P=0.01;

$DENS_LOW_LV1_INFECTION_P=0.01;
$DENS_LOW_LV2_INFECTION_P=0.01;
$DENS_MEDIUM_LV1_INFECTION_P=0.01;
$DENS_MEDIUM_LV2_INFECTION_P=0.01;
$DENS_HIGH_LV1_INFECTION_P=0.01;
$DENS_HIGH_LV2_INFECTION_P=0.01;

$INFECTED_ON_INFECTER_RATIO=0.01; //has to be lower -- 0.01

//enum temperature = {cold, temperate, hot}
//enum density = {low, medium, high}
//enum technologic_level = { primitive, medium ,hitech}

//symptoms
$DIS_1_COST=1;
$DIS_1_INFECT=0.1;
$DIS_1_LETHAL=0.1;
$DIS_1_SEVERITY=0.1;
$DIS_1_NAME="Nausea";
$DIS_1_DESC="Irritated stomach lining leads to discomfort. Slight chance of infection when kissing.";

$DIS_2_COST=1;
$DIS_2_INFECT=0.1;
$DIS_2_LETHAL=0.1;
$DIS_2_SEVERITY=0.1;
$DIS_2_NAME="Coughing";
$DIS_2_DESC="Chance of infection by spreading pathogen into surroundings, especially in high density, urban areas.";

$DIS_3_COST=1;
$DIS_3_INFECT=0.1;
$DIS_3_LETHAL=0.1;
$DIS_3_SEVERITY=0.1;
$DIS_3_NAME="Rash";
$DIS_3_DESC="The skin becomes blistered and painful, slightly increasing infectivity.";

$DIS_4_COST=1;
$DIS_4_INFECT=0.1;
$DIS_4_LETHAL=0.1;
$DIS_4_SEVERITY=0.1;
$DIS_4_NAME="Insomnia";
$DIS_4_DESC="Inability to sleep makes people irritable and less productive.";

$DIS_5_COST=1;
$DIS_5_INFECT=0.1;
$DIS_5_LETHAL=0.1;
$DIS_5_SEVERITY=0.1;
$DIS_5_NAME="Cysts";
$DIS_5_DESC="Painful lumps containing pockets of the pathogen. Slight chance of bursting which can spread disease.";

$DIS_6_COST=1;
$DIS_6_INFECT=0.1;
$DIS_6_LETHAL=0.1;
$DIS_6_SEVERITY=0.1;
$DIS_6_NAME="Anaemia";
$DIS_6_DESC="Decrease in red blood cells or haemoglobin in the blood can lead to hypoxia.";

$DIS_7_COST=2;
$DIS_7_INFECT=0.1;
$DIS_7_LETHAL=0.1;
$DIS_7_SEVERITY=0.1;
$DIS_7_NAME="Vomiting";
$DIS_7_DESC="The expulsion of infected material through projectile vomiting increases the risk of infection.";

$DIS_8_COST=2;
$DIS_8_INFECT=0.1;
$DIS_8_LETHAL=0.1;
$DIS_8_SEVERITY=0.1;
$DIS_8_NAME="Pneumonia";
$DIS_8_DESC="Serious fluid build and discharge from the lungs. People in cold climates especially vulnerable.";

$DIS_9_COST=2;
$DIS_9_INFECT=0.1;
$DIS_9_LETHAL=0.1;
$DIS_9_SEVERITY=0.1;
$DIS_9_NAME="Sneezing";
$DIS_9_DESC="Fluid discharge through sneezing increases infection rates.";

$DIS_10_COST=2;
$DIS_10_INFECT=0.1;
$DIS_10_LETHAL=0.1;
$DIS_10_SEVERITY=0.1;
$DIS_10_NAME="Sweating";
$DIS_10_DESC="The loss of fluid through sweating also increases infection rates due to poor hygiene. More dangerous in cold countries.";

$DIS_11_COST=2;
$DIS_11_INFECT=0.1;
$DIS_11_LETHAL=0.1;
$DIS_11_SEVERITY=0.1;
$DIS_11_NAME="Paranoia";
$DIS_11_DESC="Irrational delusions and mental symptoms. Victims distrust of others makes them unlikely to seek treatment or cooperate with others.";

$DIS_12_COST=2;
$DIS_12_INFECT=0.1;
$DIS_12_LETHAL=0.1;
$DIS_12_SEVERITY=0.1;
$DIS_12_NAME="Hyper Sensitivity";
$DIS_12_DESC="Increase likelihood of allergic reactions which can distract the immune system. Rich region particularly vulnerable.";

$DIS_13_COST=2;
$DIS_13_INFECT=0.1;
$DIS_13_LETHAL=0.1;
$DIS_13_SEVERITY=0.1;
$DIS_13_NAME="Abscesses";
$DIS_13_DESC="Pockets of infected flesh are painful and acts as breeding grounds for the pathogen, increasing infection rates when burst.";

$DIS_14_COST=2;
$DIS_14_INFECT=0.1;
$DIS_14_LETHAL=0.1;
$DIS_14_SEVERITY=0.1;
$DIS_14_NAME="Haemophilia";
$DIS_14_DESC="Reduced blood clotting prevents wounds healing. Pathogen able to spread through infected blood.";

$DIS_15_COST=3;
$DIS_15_INFECT=0.1;
$DIS_15_LETHAL=0.1;
$DIS_15_SEVERITY=0.1;
$DIS_15_NAME="Pulmunary Oedema";
$DIS_15_DESC="Potentially fatal heart abnormality causes breakdown of respiratory system, releasing pathogen into the air.";

$DIS_16_COST=3;
$DIS_16_INFECT=0.1;
$DIS_16_LETHAL=0.1;
$DIS_16_SEVERITY=0.1;
$DIS_16_NAME="Fever";
$DIS_16_DESC="Increase in temperature, contagiousness and severe dehydration, which can be fatal.";

$DIS_17_COST=3;
$DIS_17_INFECT=0.1;
$DIS_17_LETHAL=0.1;
$DIS_17_SEVERITY=0.1;
$DIS_17_NAME="Inflammation";
$DIS_17_DESC="Inflammation obstructs bodily processes. Swelling can obstruct breathing and be fatal.";

$DIS_18_COST=3;
$DIS_18_INFECT=0.1;
$DIS_18_LETHAL=0.1;
$DIS_18_SEVERITY=0.1;
$DIS_18_NAME="Tumours";
$DIS_18_DESC="Pathogen disrupts cell growth pathways, causing uncontrolled, eventually fatal tumour growth.";

$DIS_19_COST=4;
$DIS_19_INFECT=0.1;
$DIS_19_LETHAL=0.1;
$DIS_19_SEVERITY=0.1;
$DIS_19_NAME="Diarrhoea";
$DIS_19_DESC="Pathogen active in digestive tract, causing infection through faeces and potentially lethal dehydration. Poor countries very vulnerable.";

$DIS_20_COST=4;
$DIS_20_INFECT=0.1;
$DIS_20_LETHAL=0.1;
$DIS_20_SEVERITY=0.1;
$DIS_20_NAME="Pulmonary Fibrosis";
$DIS_20_DESC="Scarring of lungs causes shortness of breath and extreme coughing. Can be fatal when combined with intense exercise.";

$DIS_21_COST=4;
$DIS_21_INFECT=0.1;
$DIS_21_LETHAL=0.1;
$DIS_21_SEVERITY=0.1;
$DIS_21_NAME="Immune Suppression";
$DIS_21_DESC="Pathogens attach to lymphocytes, suppressing immune system and allowing significantly greater freedom of mutation. Can be lethal.";

$DIS_22_COST=4;
$DIS_22_INFECT=0.1;
$DIS_22_LETHAL=0.1;
$DIS_22_SEVERITY=0.1;
$DIS_22_NAME="Skin Lesions";
$DIS_22_DESC="Breakdown in the epidermis causes large open wounds which significantly increase infectivity";

$DIS_23_COST=4;
$DIS_23_INFECT=0.1;
$DIS_23_LETHAL=0.1;
$DIS_23_SEVERITY=0.1;
$DIS_23_NAME="Seizures";
$DIS_23_DESC="Random blackouts and fits reduces the patient's ability to function independently. Can be fatal.";

$DIS_24_COST=4;
$DIS_24_INFECT=0.1;
$DIS_24_LETHAL=0.1;
$DIS_24_SEVERITY=0.1;
$DIS_24_NAME="Paralysis";
$DIS_24_DESC="Pathogen destroys motor neurons to cause paralysis. Significantly harder to cure and can be fatal.";

$DIS_25_COST=4;
$DIS_25_INFECT=0.1;
$DIS_25_LETHAL=0.1;
$DIS_25_SEVERITY=0.1;
$DIS_25_NAME="Systemic Infection";
$DIS_25_DESC="Pathogen affects multiple organs and tissue types, causing body-wide infections that spread fast and can be fatal.";

$DIS_26_COST=4;
$DIS_26_INFECT=0.1;
$DIS_26_LETHAL=0.1;
$DIS_26_SEVERITY=0.1;
$DIS_26_NAME="Internal Haemorrhaging";
$DIS_26_DESC="Flesh eating pathogen breaks down arterial membranes causing rapid internal bleeding and death.";

$DIS_27_COST=5;
$DIS_27_INFECT=0.1;
$DIS_27_LETHAL=0.1;
$DIS_27_SEVERITY=0.1;
$DIS_27_NAME="Dysentry";
$DIS_27_DESC="A complete breakdown in the digestive system causes infected sewage, dehydration, starvation and death.";

$DIS_28_COST=5;
$DIS_28_INFECT=0.1;
$DIS_28_LETHAL=0.1;
$DIS_28_SEVERITY=0.1;
$DIS_28_NAME="Total Organ Failure";
$DIS_28_DESC="Catastrophic cell death of multiple tissue types causes body-wide organ failure ad rapid death.";

$DIS_29_COST=5;
$DIS_29_INFECT=0.1;
$DIS_29_LETHAL=0.1;
$DIS_29_SEVERITY=0.1;
$DIS_29_NAME="Necrosis";
$DIS_29_DESC="Large swathes of infected tissue lose blood supply and become fatal sources of gangrene. Decomposed bodies remain a vector of transmission.";

$DIS_30_COST=5;
$DIS_30_INFECT=0.1;
$DIS_30_LETHAL=0.1;
$DIS_30_SEVERITY=0.1;
$DIS_30_NAME="Insanity";
$DIS_30_DESC="Neuropathic action of the pathogen in the frontal cortex causes severe emotional and behavioral abnormalities. Significantly harder to cure.";

$DIS_31_COST=5;
$DIS_32_INFECT=0.1;
$DIS_33_LETHAL=0.1;
$DIS_34_SEVERITY=0.1;
$DIS_35_NAME="Coma";
$DIS_36_DESC="Neuropathic effects in the brain stem causes loss of consciousness and sometimes death. Significantly harder to cure.";

$DIS_37_COST=5;
$DIS_37_INFECT=0.1;
$DIS_37_LETHAL=0.1;
$DIS_37_SEVERITY=0.1;
$DIS_37_NAME="Hemorrhagic Shock";
$DIS_37_DESC="Failure of the heart to pump effectively causes oxygen deprivation, loss of consciousness and death.";

function gen(){
	return getRandomF(0,1);
}


