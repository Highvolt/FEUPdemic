$YELLOW_PROBABILITY = 0.0059;
$INFECTED_ON_INFECTER_RATIO=0.001;
$FEUP_POPULATION = 10833;

//INFECTIONS
//probabilities
$TECH_PRIMITIVE_LV1_PROBABILITY=0.01;
$TECH_PRIMITIVE_LV2_PROBABILITY=0.01;
$TECH_MEDIUM_LV1_PROBABILITY=0.01;
$TECH_MEDIUM_LV2_PROBABILITY=0.01;
$TECH_HITECH_LV1_PROBABILITY=0.01;
$TECH_HITECH_LV2_PROBABILITY=0.01;

$TECH_PRIMITIVE_LV3_PROBABILITY=0.01;
$TECH_HITECH_LV3_PROBABILITY=0.01;

$TEMP_COLD_LV1_PROBABILITY=0.01;
$TEMP_COLD_LV2_PROBABILITY=0.01;
$TEMP_TEMPERATE_LV1_PROBABILITY=0.01;
$TEMP_TEMPERATE_LV2_PROBABILITY=0.01;
$TEMP_HOT_LV1_PROBABILITY=0.01;
$TEMP_HOT_LV2_PROBABILITY=0.01;

$TEMP_COLD_LV3_PROBABILITY=0.01;
$TEMP_HOT_LV3_PROBABILITY=0.01;

$TEMP_LV4_PROBABILITY=0.01;

$DENS_LOW_LV1_PROBABILITY=0.01;
$DENS_LOW_LV2_PROBABILITY=0.01;
$DENS_MEDIUM_LV1_PROBABILITY=0.01;
$DENS_MEDIUM_LV2_PROBABILITY=0.01;
$DENS_HIGH_LV1_PROBABILITY=0.01;
$DENS_HIGH_LV2_PROBABILITY=0.01;

$DENS_LOW_LV3_PROBABILITY=0.01;
$DENS_HIGH_LV3_PROBABILITY=0.01;

$DENS_LV4_PROBABILITY=0.01;

//costs
//costs = cost*(//already_upgraded)*COST_SCALING
$COST_SCALING=0.3;

$TL1_COST=1;
$TL2_COST=2;
$TM1_COST=1;
$TM2_COST=2;
$TH1_COST=1;
$TH2_COST=2;
$TL3_COST=3;
$TH3_COST=3;
$TempL1_COST=1;
$TempL2_COST=2;
$TempM1_COST=1;
$TempM2_COST=2;
$TempH1_COST=1;
$TempH2_COST=2;
$TempL3_COST=3;
$TempH3_COST=3;
$Temp4_COST=4;
$PL1_COST=1;
$PL2_COST=2;
$PM1_COST=1;
$PM2_COST=2;
$PH1_COST=1;
$PH2_COST=2;
$PL3_COST=3;
$PH3_COST=3;
$P4_COST=4;

//percentages
//to be added to disease.infection_percentage on upgrade
$TL1_INFECT=0.01;
$TL2_INFECT=0.01;
$TM1_INFECT=0.01;
$TM2_INFECT=0.01;
$TH1_INFECT=0.01;
$TH2_INFECT=0.01;
$TL3_INFECT=0.01;
$TH3_INFECT=0.01;
$TempL1_INFECT=0.01;
$TempL2_INFECT=0.01;
$TempM1_INFECT=0.01;
$TempM2_INFECT=0.01;
$TempH1_INFECT=0.01;
$TempH2_INFECT=0.01;
$TempL3_INFECT=0.01;
$TempH3_INFECT=0.01;
$Temp4_INFECT=0.01;
$PL1_INFECT=0.01;
$PL2_INFECT=0.01;
$PM1_INFECT=0.01;
$PM2_INFECT=0.01;
$PH1_INFECT=0.01;
$PH2_INFECT=0.01;
$PL3_INFECT=0.01;
$PH3_INFECT=0.01;
$P4_INFECT=0.01;
 //has to be lower -- 0.01

$TL1_NAME="Infect primitive tech I";
$TL2_NAME="Infect primitive tech II";
$TM1_NAME="Infect medium tech I";
$TM2_NAME="Infect medium tech II";
$TH1_NAME="Infect hitech tech I";
$TH2_NAME="Infect hitech tech II";
$TL3_NAME="Infect primitive tech III";
$TH3_NAME="Infect hitech tech III";
$TempL1_NAME="Infect cold temperatures I";
$TempL2_NAME="Infect cold temperatures II";
$TempM1_NAME="Infect temperate temperatures I";
$TempM2_NAME="Infect temperate temperatures II";
$TempH1_NAME="Infect hot temperatures I";
$TempH2_NAME="Infect hot temperatures II";
$TempL3_NAME="Infect cold temperatures III";
$TempH3_NAME="Infect hot temperatures III";
$Temp4_NAME="Infect temperatures IV";
$PL1_NAME="Infect low densities I";
$PL2_NAME="Infect low densities II";
$PM1_NAME="Infect medium densities I";
$PM2_NAME="Infect medium densities II";
$PH1_NAME="Infect high densities I";
$PH2_NAME="Infect high densities I";
$PL3_NAME="Infect low densities III";
$PH3_NAME="Infect high densities III";
$P4_NAME="Infect densities IV";
//enum temperature = {cold, temperate, hot}
//enum density = {low, medium, high}
//enum technologic_level = { primitive, medium ,hitech}

//symptoms
$DIS_1_COST=1;
$DIS_1_INFECT=0.01;
$DIS_1_LETHAL=0.01;
$DIS_1_SEVERITY=0.01;
$DIS_1_NAME="Nausea";
$DIS_1_DESC="Irritated stomach lining leads to discomfort. Slight chance of infection when kissing.";

$DIS_6_COST=1;
$DIS_6_INFECT=0.01;
$DIS_6_LETHAL=0.01;
$DIS_6_SEVERITY=0.01;
$DIS_6_NAME="Coughing";
$DIS_6_DESC="Chance of infection by spreading pathogen into surroundings, especially in high density, urban areas.";

$DIS_18_COST=1;
$DIS_18_INFECT=0.01;
$DIS_18_LETHAL=0.01;
$DIS_18_SEVERITY=0.01;
$DIS_18_NAME="Rash";
$DIS_18_DESC="The skin becomes blistered and painful, slightly increasing infectivity.";

$DIS_12_COST=1;
$DIS_12_INFECT=0.01;
$DIS_12_LETHAL=0.01;
$DIS_12_SEVERITY=0.01;
$DIS_12_NAME="Insomnia";
$DIS_12_DESC="Inability to sleep makes people irritable and less productive.";

$DIS_25_COST=1;
$DIS_25_INFECT=0.01;
$DIS_25_LETHAL=0.01;
$DIS_25_SEVERITY=0.01;
$DIS_25_NAME="Cysts";
$DIS_25_DESC="Painful lumps containing pockets of the pathogen. Slight chance of bursting which can spread disease.";

$DIS_20_COST=1;
$DIS_20_INFECT=0.01;
$DIS_20_LETHAL=0.01;
$DIS_20_SEVERITY=0.01;
$DIS_20_NAME="Anaemia";
$DIS_20_DESC="Decrease in red blood cells or haemoglobin in the blood can lead to hypoxia.";

$DIS_2_COST=2;
$DIS_2_INFECT=0.01;
$DIS_2_LETHAL=0.01;
$DIS_2_SEVERITY=0.01;
$DIS_2_NAME="Vomiting";
$DIS_2_DESC="The expulsion of infected material through projectile vomiting increases the risk of infection.";

$DIS_7_COST=2;
$DIS_7_INFECT=0.01;
$DIS_7_LETHAL=0.01;
$DIS_7_SEVERITY=0.01;
$DIS_7_NAME="Pneumonia";
$DIS_7_DESC="Serious fluid build and discharge from the lungs. People in cold climates especially vulnerable.";

$DIS_9_COST=2;
$DIS_9_INFECT=0.01;
$DIS_9_LETHAL=0.01;
$DIS_9_SEVERITY=0.01;
$DIS_9_NAME="Sneezing";
$DIS_9_DESC="Fluid discharge through sneezing increases infection rates.";

$DIS_19_COST=2;
$DIS_19_INFECT=0.01;
$DIS_19_LETHAL=0.01;
$DIS_19_SEVERITY=0.01;
$DIS_19_NAME="Sweating";
$DIS_19_DESC="The loss of fluid through sweating also increases infection rates due to poor hygiene. More dangerous in cold countries.";

$DIS_13_COST=2;
$DIS_13_INFECT=0.01;
$DIS_13_LETHAL=0.01;
$DIS_13_SEVERITY=0.01;
$DIS_13_NAME="Paranoia";
$DIS_13_DESC="Irrational delusions and mental symptoms. Victims distrust of others makes them unlikely to seek treatment or cooperate with others.";

$DIS_26_COST=2;
$DIS_26_INFECT=0.01;
$DIS_26_LETHAL=0.01;
$DIS_26_SEVERITY=0.01;
$DIS_26_NAME="Hyper Sensitivity";
$DIS_26_DESC="Increase likelihood of allergic reactions which can distract the immune system. Rich region particularly vulnerable.";

$DIS_31_COST=2;
$DIS_31_INFECT=0.01;
$DIS_31_LETHAL=0.01;
$DIS_31_SEVERITY=0.01;
$DIS_31_NAME="Abscesses";
$DIS_31_DESC="Pockets of infected flesh are painful and acts as breeding grounds for the pathogen, increasing infection rates when burst.";

$DIS_23_COST=2;
$DIS_23_INFECT=0.01;
$DIS_23_LETHAL=0.01;
$DIS_23_SEVERITY=0.01;
$DIS_23_NAME="Haemophilia";
$DIS_23_DESC="Reduced blood clotting prevents wounds healing. Pathogen able to spread through infected blood.";

$DIS_5_COST=3;
$DIS_5_INFECT=0.01;
$DIS_5_LETHAL=0.01;
$DIS_5_SEVERITY=0.01;
$DIS_5_NAME="Pulmunary Oedema";
$DIS_5_DESC="Potentially fatal heart abnormality causes breakdown of respiratory system, releasing pathogen into the air.";

$DIS_10_COST=3;
$DIS_10_INFECT=0.01;
$DIS_10_LETHAL=0.01;
$DIS_10_SEVERITY=0.01;
$DIS_10_NAME="Fever";
$DIS_10_DESC="Increase in temperature, contagiousness and severe dehydration, which can be fatal.";

$DIS_15_COST=3;
$DIS_15_INFECT=0.01;
$DIS_15_LETHAL=0.01;
$DIS_15_SEVERITY=0.01;
$DIS_15_NAME="Inflammation";
$DIS_15_DESC="Inflammation obstructs bodily processes. Swelling can obstruct breathing and be fatal.";

$DIS_27_COST=3;
$DIS_27_INFECT=0.01;
$DIS_27_LETHAL=0.01;
$DIS_27_SEVERITY=0.01;
$DIS_27_NAME="Tumours";
$DIS_27_DESC="Pathogen disrupts cell growth pathways, causing uncontrolled, eventually fatal tumour growth.";

$DIS_3_COST=4;
$DIS_3_INFECT=0.01;
$DIS_3_LETHAL=0.01;
$DIS_3_SEVERITY=0.01;
$DIS_3_NAME="Diarrhoea";
$DIS_3_DESC="Pathogen active in digestive tract, causing infection through faeces and potentially lethal dehydration. Poor countries very vulnerable.";

$DIS_8_COST=4;
$DIS_8_INFECT=0.01;
$DIS_8_LETHAL=0.01;
$DIS_8_SEVERITY=0.01;
$DIS_8_NAME="Pulmonary Fibrosis";
$DIS_8_DESC="Scarring of lungs causes shortness of breath and extreme coughing. Can be fatal when combined with intense exercise.";

$DIS_29_COST=4;
$DIS_29_INFECT=0.01;
$DIS_29_LETHAL=0.01;
$DIS_29_SEVERITY=0.01;
$DIS_29_NAME="Immune Suppression";
$DIS_29_DESC="Pathogens attach to lymphocytes, suppressing immune system and allowing significantly greater freedom of mutation. Can be lethal.";

$DIS_28_COST=4;
$DIS_28_INFECT=0.01;
$DIS_28_LETHAL=0.01;
$DIS_28_SEVERITY=0.01;
$DIS_28_NAME="Skin Lesions";
$DIS_28_DESC="Breakdown in the epidermis causes large open wounds which significantly increase infectivity";

$DIS_14_COST=4;
$DIS_14_INFECT=0.01;
$DIS_14_LETHAL=0.01;
$DIS_14_SEVERITY=0.01;
$DIS_14_NAME="Seizures";
$DIS_14_DESC="Random blackouts and fits reduces the patient's ability to function independently. Can be fatal.";

$DIS_16_COST=4;
$DIS_16_INFECT=0.01;
$DIS_16_LETHAL=0.01;
$DIS_16_SEVERITY=0.01;
$DIS_16_NAME="Paralysis";
$DIS_16_DESC="Pathogen destroys motor neurons to cause paralysis. Significantly harder to cure and can be fatal.";

$DIS_32_COST=4;
$DIS_32_INFECT=0.01;
$DIS_32_LETHAL=0.01;
$DIS_32_SEVERITY=0.01;
$DIS_32_NAME="Systemic Infection";
$DIS_32_DESC="Pathogen affects multiple organs and tissue types, causing body-wide infections that spread fast and can be fatal.";

$DIS_24_COST=4;
$DIS_24_INFECT=0.01;
$DIS_24_LETHAL=0.01;
$DIS_24_SEVERITY=0.01;
$DIS_24_NAME="Internal Haemorrhaging";
$DIS_24_DESC="Flesh eating pathogen breaks down arterial membranes causing rapid internal bleeding and death.";

$DIS_4_COST=5;
$DIS_4_INFECT=0.01;
$DIS_4_LETHAL=0.01;
$DIS_4_SEVERITY=0.01;
$DIS_4_NAME="Dysentry";
$DIS_4_DESC="A complete breakdown in the digestive system causes infected sewage, dehydration, starvation and death.";

$DIS_30_COST=5;
$DIS_30_INFECT=0.01;
$DIS_30_LETHAL=0.01;
$DIS_30_SEVERITY=0.01;
$DIS_30_NAME="Total Organ Failure";
$DIS_30_DESC="Catastrophic cell death of multiple tissue types causes body-wide organ failure ad rapid death.";

$DIS_22_COST=5;
$DIS_22_INFECT=0.01;
$DIS_22_LETHAL=0.01;
$DIS_22_SEVERITY=0.01;
$DIS_22_NAME="Necrosis";
$DIS_22_DESC="Large swathes of infected tissue lose blood supply and become fatal sources of gangrene. Decomposed bodies remain a vector of transmission.";

$DIS_17_COST=5;
$DIS_17_INFECT=0.01;
$DIS_17_LETHAL=0.01;
$DIS_17_SEVERITY=0.01;
$DIS_17_NAME="Insanity";
$DIS_17_DESC="Neuropathic action of the pathogen in the frontal cortex causes severe emotional and behavioral abnormalities. Significantly harder to cure.";

$DIS_11_COST=5;
$DIS_11_INFECT=0.01;
$DIS_11_LETHAL=0.01;
$DIS_11_SEVERITY=0.01;
$DIS_11_NAME="Coma";
$DIS_11_DESC="Neuropathic effects in the brain stem causes loss of consciousness and sometimes death. Significantly harder to cure.";

$DIS_21_COST=5;
$DIS_21_INFECT=0.01;
$DIS_21_LETHAL=0.01;
$DIS_21_SEVERITY=0.01;
$DIS_21_NAME="Hemorrhagic Shock";
$DIS_21_DESC="Failure of the heart to pump effectively causes oxygen deprivation, loss of consciousness and death.";

$R1_PROB=0.01;
$R1_NAME="Drug resistance I";
$R1_DESC="Improves the disease resistance to the cure";

$R2_PROB=0.01;
$R2_NAME="Drug resistance II";
$R2_DESC="Improves the disease resistance to the cure";

$R3_PROB=0.01;
$R3_NAME="Drug resistance III";
$R3_DESC="Improves the disease resistance to the cure";

$R4_PROB=0.01;
$R4_NAME="Drug resistance IV";
$R4_DESC="Improves the disease resistance to the cure";



//Symptoms CONN

$DIS_1_CONN="2 3";
$DIS_2_CONN="3 5";
$DIS_3_CONN="5 4";
$DIS_4_CONN="17";
$DIS_5_CONN="7 8";
$DIS_6_CONN="7 9";
$DIS_7_CONN="8 5";
$DIS_8_CONN="11";
$DIS_9_CONN="29 10";
$DIS_10_CONN="29 28";
$DIS_11_CONN="30";
$DIS_12_CONN="13";
$DIS_13_CONN="14 15";
$DIS_14_CONN="17 15";
$DIS_15_CONN="14 16";
$DIS_16_CONN="11";
$DIS_18_CONN="19";
$DIS_19_CONN="10 28";
$DIS_20_CONN="23";
$DIS_21_CONN="22";
$DIS_22_CONN="21";
$DIS_23_CONN="24 21";
$DIS_24_CONN="27";
$DIS_25_CONN="26 31";
$DIS_26_CONN="16";
$DIS_27_CONN="24";
$DIS_28_CONN="22 29";
$DIS_29_CONN="30 28";
$DIS_31_CONN="27";


function gen(){
	return getRandomF(0,1);
}


