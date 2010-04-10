
namespace BWAPI {

using System;
using System.Runtime.InteropServices;


class bridgePINVOKEProxy {
	public static bridgePINVOKEDynamic remote;
	
	public static void connectProxy() {
		remote = new bridgePINVOKEDynamic();
	}
}



class bridgePINVOKEDynamic: MarshalByRefObject {

	
public class SWIGPendingExceptionDynamic: MarshalByRefObject {
    public bool Pending {
      get {
        return bridgePINVOKE.SWIGPendingException.Pending;
      } 
    }

    public void Set(Exception e) {
		bridgePINVOKE.SWIGPendingException.Set(e);
	}

    public Exception Retrieve() {
		return bridgePINVOKE.SWIGPendingException.Retrieve();
    }
}

public SWIGPendingExceptionDynamic SWIGPendingException;

public bridgePINVOKEDynamic() {
	SWIGPendingException = new SWIGPendingExceptionDynamic();
}



public void BWAPI_init() {
  bridgePINVOKE.BWAPI_init();
}


public IntPtr new_Race__SWIG_0() {
  return bridgePINVOKE.new_Race__SWIG_0();
}


public IntPtr new_Race__SWIG_1(int jarg1) {
  return bridgePINVOKE.new_Race__SWIG_1(jarg1);
}


public IntPtr new_Race__SWIG_2(HandleRef jarg1) {
  return bridgePINVOKE.new_Race__SWIG_2(jarg1);
}


public IntPtr Race_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Race_opAssign(jarg1, jarg2);
}


public bool Race_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Race_opEquals(jarg1, jarg2);
}


public bool Race_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Race_opNotEquals(jarg1, jarg2);
}


public bool Race_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Race_opLessThan(jarg1, jarg2);
}


public int Race_getID(HandleRef jarg1) {
  return bridgePINVOKE.Race_getID(jarg1);
}


public string Race_getName(HandleRef jarg1) {
  return bridgePINVOKE.Race_getName(jarg1);
}


public IntPtr Race_getWorker(HandleRef jarg1) {
  return bridgePINVOKE.Race_getWorker(jarg1);
}


public IntPtr Race_getCenter(HandleRef jarg1) {
  return bridgePINVOKE.Race_getCenter(jarg1);
}


public IntPtr Race_getRefinery(HandleRef jarg1) {
  return bridgePINVOKE.Race_getRefinery(jarg1);
}


public IntPtr Race_getTransport(HandleRef jarg1) {
  return bridgePINVOKE.Race_getTransport(jarg1);
}


public IntPtr Race_getSupplyProvider(HandleRef jarg1) {
  return bridgePINVOKE.Race_getSupplyProvider(jarg1);
}


public void delete_Race(HandleRef jarg1) {
  bridgePINVOKE.delete_Race(jarg1);
}


public IntPtr getRace(string jarg1) {
  return bridgePINVOKE.getRace(jarg1);
}


public IntPtr allRaces() {
  return bridgePINVOKE.allRaces();
}


public void initRaces() {
  bridgePINVOKE.initRaces();
}


public IntPtr Zerg_get() {
  return bridgePINVOKE.Zerg_get();
}


public IntPtr Terran_get() {
  return bridgePINVOKE.Terran_get();
}


public IntPtr Protoss_get() {
  return bridgePINVOKE.Protoss_get();
}


public IntPtr Random_get() {
  return bridgePINVOKE.Random_get();
}


public IntPtr Other_get() {
  return bridgePINVOKE.Other_get();
}


public IntPtr RaceNone_get() {
  return bridgePINVOKE.RaceNone_get();
}


public IntPtr RaceUnknown_get() {
  return bridgePINVOKE.RaceUnknown_get();
}


public IntPtr new_TechType__SWIG_0() {
  return bridgePINVOKE.new_TechType__SWIG_0();
}


public IntPtr new_TechType__SWIG_1(int jarg1) {
  return bridgePINVOKE.new_TechType__SWIG_1(jarg1);
}


public IntPtr new_TechType__SWIG_2(HandleRef jarg1) {
  return bridgePINVOKE.new_TechType__SWIG_2(jarg1);
}


public IntPtr TechType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TechType_opAssign(jarg1, jarg2);
}


public bool TechType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TechType_opEquals(jarg1, jarg2);
}


public bool TechType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TechType_opNotEquals(jarg1, jarg2);
}


public bool TechType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TechType_opLessThan(jarg1, jarg2);
}


public int TechType_getID(HandleRef jarg1) {
  return bridgePINVOKE.TechType_getID(jarg1);
}


public string TechType_getName(HandleRef jarg1) {
  return bridgePINVOKE.TechType_getName(jarg1);
}


public int TechType_mineralPrice(HandleRef jarg1) {
  return bridgePINVOKE.TechType_mineralPrice(jarg1);
}


public int TechType_gasPrice(HandleRef jarg1) {
  return bridgePINVOKE.TechType_gasPrice(jarg1);
}


public int TechType_energyUsed(HandleRef jarg1) {
  return bridgePINVOKE.TechType_energyUsed(jarg1);
}


public IntPtr TechType_whatResearches(HandleRef jarg1) {
  return bridgePINVOKE.TechType_whatResearches(jarg1);
}


public IntPtr TechType_getWeapon(HandleRef jarg1) {
  return bridgePINVOKE.TechType_getWeapon(jarg1);
}


public IntPtr TechType_whatUses(HandleRef jarg1) {
  return bridgePINVOKE.TechType_whatUses(jarg1);
}


public void delete_TechType(HandleRef jarg1) {
  bridgePINVOKE.delete_TechType(jarg1);
}


public IntPtr getTechType(string jarg1) {
  return bridgePINVOKE.getTechType(jarg1);
}


public IntPtr allTechTypes() {
  return bridgePINVOKE.allTechTypes();
}


public void initTechTypes() {
  bridgePINVOKE.initTechTypes();
}


public IntPtr Stim_Packs_get() {
  return bridgePINVOKE.Stim_Packs_get();
}


public IntPtr TechTypeLockdown_get() {
  return bridgePINVOKE.TechTypeLockdown_get();
}


public IntPtr TechTypeEMP_Shockwave_get() {
  return bridgePINVOKE.TechTypeEMP_Shockwave_get();
}


public IntPtr Spider_Mines_get() {
  return bridgePINVOKE.Spider_Mines_get();
}


public IntPtr Scanner_Sweep_get() {
  return bridgePINVOKE.Scanner_Sweep_get();
}


public IntPtr Tank_Siege_Mode_get() {
  return bridgePINVOKE.Tank_Siege_Mode_get();
}


public IntPtr Defensive_Matrix_get() {
  return bridgePINVOKE.Defensive_Matrix_get();
}


public IntPtr TechTypeIrradiate_get() {
  return bridgePINVOKE.TechTypeIrradiate_get();
}


public IntPtr TechTypeYamato_Gun_get() {
  return bridgePINVOKE.TechTypeYamato_Gun_get();
}


public IntPtr Cloaking_Field_get() {
  return bridgePINVOKE.Cloaking_Field_get();
}


public IntPtr Personnel_Cloaking_get() {
  return bridgePINVOKE.Personnel_Cloaking_get();
}


public IntPtr Burrowing_get() {
  return bridgePINVOKE.Burrowing_get();
}


public IntPtr Infestation_get() {
  return bridgePINVOKE.Infestation_get();
}


public IntPtr TechTypeSpawn_Broodlings_get() {
  return bridgePINVOKE.TechTypeSpawn_Broodlings_get();
}


public IntPtr TechTypeDark_Swarm_get() {
  return bridgePINVOKE.TechTypeDark_Swarm_get();
}


public IntPtr TechTypePlague_get() {
  return bridgePINVOKE.TechTypePlague_get();
}


public IntPtr TechTypeConsume_get() {
  return bridgePINVOKE.TechTypeConsume_get();
}


public IntPtr TechTypeEnsnare_get() {
  return bridgePINVOKE.TechTypeEnsnare_get();
}


public IntPtr TechTypeParasite_get() {
  return bridgePINVOKE.TechTypeParasite_get();
}


public IntPtr TechTypePsionic_Storm_get() {
  return bridgePINVOKE.TechTypePsionic_Storm_get();
}


public IntPtr Hallucination_get() {
  return bridgePINVOKE.Hallucination_get();
}


public IntPtr Recall_get() {
  return bridgePINVOKE.Recall_get();
}


public IntPtr TechTypeStasis_Field_get() {
  return bridgePINVOKE.TechTypeStasis_Field_get();
}


public IntPtr Archon_Warp_get() {
  return bridgePINVOKE.Archon_Warp_get();
}


public IntPtr TechTypeRestoration_get() {
  return bridgePINVOKE.TechTypeRestoration_get();
}


public IntPtr TechTypeDisruption_Web_get() {
  return bridgePINVOKE.TechTypeDisruption_Web_get();
}


public IntPtr TechTypeMind_Control_get() {
  return bridgePINVOKE.TechTypeMind_Control_get();
}


public IntPtr Dark_Archon_Meld_get() {
  return bridgePINVOKE.Dark_Archon_Meld_get();
}


public IntPtr TechTypeFeedback_get() {
  return bridgePINVOKE.TechTypeFeedback_get();
}


public IntPtr TechTypeOptical_Flare_get() {
  return bridgePINVOKE.TechTypeOptical_Flare_get();
}


public IntPtr TechTypeMaelstrom_get() {
  return bridgePINVOKE.TechTypeMaelstrom_get();
}


public IntPtr Lurker_Aspect_get() {
  return bridgePINVOKE.Lurker_Aspect_get();
}


public IntPtr Healing_get() {
  return bridgePINVOKE.Healing_get();
}


public IntPtr TechTypeNone_get() {
  return bridgePINVOKE.TechTypeNone_get();
}


public IntPtr TechTypeUnknown_get() {
  return bridgePINVOKE.TechTypeUnknown_get();
}


public IntPtr TechTypeNuclear_Strike_get() {
  return bridgePINVOKE.TechTypeNuclear_Strike_get();
}


public IntPtr new_UpgradeType__SWIG_0() {
  return bridgePINVOKE.new_UpgradeType__SWIG_0();
}


public IntPtr new_UpgradeType__SWIG_1(int jarg1) {
  return bridgePINVOKE.new_UpgradeType__SWIG_1(jarg1);
}


public IntPtr new_UpgradeType__SWIG_2(HandleRef jarg1) {
  return bridgePINVOKE.new_UpgradeType__SWIG_2(jarg1);
}


public IntPtr UpgradeType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UpgradeType_opAssign(jarg1, jarg2);
}


public bool UpgradeType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UpgradeType_opEquals(jarg1, jarg2);
}


public bool UpgradeType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UpgradeType_opNotEquals(jarg1, jarg2);
}


public bool UpgradeType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UpgradeType_opLessThan(jarg1, jarg2);
}


public int UpgradeType_getID(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeType_getID(jarg1);
}


public string UpgradeType_getName(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeType_getName(jarg1);
}


public IntPtr UpgradeType_getRace(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeType_getRace(jarg1);
}


public int UpgradeType_mineralPriceBase(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeType_mineralPriceBase(jarg1);
}


public int UpgradeType_mineralPriceFactor(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeType_mineralPriceFactor(jarg1);
}


public int UpgradeType_gasPriceBase(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeType_gasPriceBase(jarg1);
}


public int UpgradeType_gasPriceFactor(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeType_gasPriceFactor(jarg1);
}


public int UpgradeType_upgradeTimeBase(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeType_upgradeTimeBase(jarg1);
}


public int UpgradeType_upgradeTimeFactor(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeType_upgradeTimeFactor(jarg1);
}


public int UpgradeType_maxRepeats(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeType_maxRepeats(jarg1);
}


public IntPtr UpgradeType_whatUpgrades(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeType_whatUpgrades(jarg1);
}


public IntPtr UpgradeType_whatUses(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeType_whatUses(jarg1);
}


public void delete_UpgradeType(HandleRef jarg1) {
  bridgePINVOKE.delete_UpgradeType(jarg1);
}


public IntPtr getUpgradeType(string jarg1) {
  return bridgePINVOKE.getUpgradeType(jarg1);
}


public IntPtr allUpgradeTypes() {
  return bridgePINVOKE.allUpgradeTypes();
}


public void initUpgradeTypes() {
  bridgePINVOKE.initUpgradeTypes();
}


public IntPtr Terran_Infantry_Armor_get() {
  return bridgePINVOKE.Terran_Infantry_Armor_get();
}


public IntPtr Terran_Vehicle_Plating_get() {
  return bridgePINVOKE.Terran_Vehicle_Plating_get();
}


public IntPtr Terran_Ship_Plating_get() {
  return bridgePINVOKE.Terran_Ship_Plating_get();
}


public IntPtr Zerg_Carapace_get() {
  return bridgePINVOKE.Zerg_Carapace_get();
}


public IntPtr Zerg_Flyer_Carapace_get() {
  return bridgePINVOKE.Zerg_Flyer_Carapace_get();
}


public IntPtr Protoss_Armor_get() {
  return bridgePINVOKE.Protoss_Armor_get();
}


public IntPtr Protoss_Plating_get() {
  return bridgePINVOKE.Protoss_Plating_get();
}


public IntPtr Terran_Infantry_Weapons_get() {
  return bridgePINVOKE.Terran_Infantry_Weapons_get();
}


public IntPtr Terran_Vehicle_Weapons_get() {
  return bridgePINVOKE.Terran_Vehicle_Weapons_get();
}


public IntPtr Terran_Ship_Weapons_get() {
  return bridgePINVOKE.Terran_Ship_Weapons_get();
}


public IntPtr Zerg_Melee_Attacks_get() {
  return bridgePINVOKE.Zerg_Melee_Attacks_get();
}


public IntPtr Zerg_Missile_Attacks_get() {
  return bridgePINVOKE.Zerg_Missile_Attacks_get();
}


public IntPtr Zerg_Flyer_Attacks_get() {
  return bridgePINVOKE.Zerg_Flyer_Attacks_get();
}


public IntPtr Protoss_Ground_Weapons_get() {
  return bridgePINVOKE.Protoss_Ground_Weapons_get();
}


public IntPtr Protoss_Air_Weapons_get() {
  return bridgePINVOKE.Protoss_Air_Weapons_get();
}


public IntPtr Protoss_Plasma_Shields_get() {
  return bridgePINVOKE.Protoss_Plasma_Shields_get();
}


public IntPtr U_238_Shells_get() {
  return bridgePINVOKE.U_238_Shells_get();
}


public IntPtr Ion_Thrusters_get() {
  return bridgePINVOKE.Ion_Thrusters_get();
}


public IntPtr Titan_Reactor_get() {
  return bridgePINVOKE.Titan_Reactor_get();
}


public IntPtr Ocular_Implants_get() {
  return bridgePINVOKE.Ocular_Implants_get();
}


public IntPtr Moebius_Reactor_get() {
  return bridgePINVOKE.Moebius_Reactor_get();
}


public IntPtr Apollo_Reactor_get() {
  return bridgePINVOKE.Apollo_Reactor_get();
}


public IntPtr Colossus_Reactor_get() {
  return bridgePINVOKE.Colossus_Reactor_get();
}


public IntPtr Ventral_Sacs_get() {
  return bridgePINVOKE.Ventral_Sacs_get();
}


public IntPtr Antennae_get() {
  return bridgePINVOKE.Antennae_get();
}


public IntPtr Pneumatized_Carapace_get() {
  return bridgePINVOKE.Pneumatized_Carapace_get();
}


public IntPtr Metabolic_Boost_get() {
  return bridgePINVOKE.Metabolic_Boost_get();
}


public IntPtr Adrenal_Glands_get() {
  return bridgePINVOKE.Adrenal_Glands_get();
}


public IntPtr Muscular_Augments_get() {
  return bridgePINVOKE.Muscular_Augments_get();
}


public IntPtr Grooved_Spines_get() {
  return bridgePINVOKE.Grooved_Spines_get();
}


public IntPtr Gamete_Meiosis_get() {
  return bridgePINVOKE.Gamete_Meiosis_get();
}


public IntPtr Metasynaptic_Node_get() {
  return bridgePINVOKE.Metasynaptic_Node_get();
}


public IntPtr Singularity_Charge_get() {
  return bridgePINVOKE.Singularity_Charge_get();
}


public IntPtr Leg_Enhancements_get() {
  return bridgePINVOKE.Leg_Enhancements_get();
}


public IntPtr Scarab_Damage_get() {
  return bridgePINVOKE.Scarab_Damage_get();
}


public IntPtr Reaver_Capacity_get() {
  return bridgePINVOKE.Reaver_Capacity_get();
}


public IntPtr Gravitic_Drive_get() {
  return bridgePINVOKE.Gravitic_Drive_get();
}


public IntPtr Sensor_Array_get() {
  return bridgePINVOKE.Sensor_Array_get();
}


public IntPtr Gravitic_Boosters_get() {
  return bridgePINVOKE.Gravitic_Boosters_get();
}


public IntPtr Khaydarin_Amulet_get() {
  return bridgePINVOKE.Khaydarin_Amulet_get();
}


public IntPtr Apial_Sensors_get() {
  return bridgePINVOKE.Apial_Sensors_get();
}


public IntPtr Gravitic_Thrusters_get() {
  return bridgePINVOKE.Gravitic_Thrusters_get();
}


public IntPtr Carrier_Capacity_get() {
  return bridgePINVOKE.Carrier_Capacity_get();
}


public IntPtr Khaydarin_Core_get() {
  return bridgePINVOKE.Khaydarin_Core_get();
}


public IntPtr Argus_Jewel_get() {
  return bridgePINVOKE.Argus_Jewel_get();
}


public IntPtr Argus_Talisman_get() {
  return bridgePINVOKE.Argus_Talisman_get();
}


public IntPtr Caduceus_Reactor_get() {
  return bridgePINVOKE.Caduceus_Reactor_get();
}


public IntPtr Chitinous_Plating_get() {
  return bridgePINVOKE.Chitinous_Plating_get();
}


public IntPtr Anabolic_Synthesis_get() {
  return bridgePINVOKE.Anabolic_Synthesis_get();
}


public IntPtr Charon_Booster_get() {
  return bridgePINVOKE.Charon_Booster_get();
}


public IntPtr UpgradeTypeNone_get() {
  return bridgePINVOKE.UpgradeTypeNone_get();
}


public IntPtr UpgradeTypeUnknown_get() {
  return bridgePINVOKE.UpgradeTypeUnknown_get();
}


public IntPtr new_Position__SWIG_0() {
  return bridgePINVOKE.new_Position__SWIG_0();
}


public IntPtr new_Position__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_Position__SWIG_1(jarg1);
}


public IntPtr new_Position__SWIG_2(int jarg1, int jarg2) {
  return bridgePINVOKE.new_Position__SWIG_2(jarg1, jarg2);
}


public bool Position_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Position_opEquals(jarg1, jarg2);
}


public bool Position_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Position_opNotEquals(jarg1, jarg2);
}


public bool Position_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Position_opLessThan(jarg1, jarg2);
}


public IntPtr Position_opPlus(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Position_opPlus(jarg1, jarg2);
}


public IntPtr Position_opMinus(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Position_opMinus(jarg1, jarg2);
}


public IntPtr Position_opAdd(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Position_opAdd(jarg1, jarg2);
}


public IntPtr Position_opSubtract(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Position_opSubtract(jarg1, jarg2);
}


public double Position_getDistance(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Position_getDistance(jarg1, jarg2);
}


public double Position_getApproxDistance(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Position_getApproxDistance(jarg1, jarg2);
}


public double Position_getLength(HandleRef jarg1) {
  return bridgePINVOKE.Position_getLength(jarg1);
}


public IntPtr Position_x(HandleRef jarg1) {
  return bridgePINVOKE.Position_x(jarg1);
}


public IntPtr Position_y(HandleRef jarg1) {
  return bridgePINVOKE.Position_y(jarg1);
}


public int Position_xConst(HandleRef jarg1) {
  return bridgePINVOKE.Position_xConst(jarg1);
}


public int Position_yConst(HandleRef jarg1) {
  return bridgePINVOKE.Position_yConst(jarg1);
}


public void delete_Position(HandleRef jarg1) {
  bridgePINVOKE.delete_Position(jarg1);
}


public IntPtr PositionInvalid_get() {
  return bridgePINVOKE.PositionInvalid_get();
}


public IntPtr PositionNone_get() {
  return bridgePINVOKE.PositionNone_get();
}


public IntPtr PositionUnknown_get() {
  return bridgePINVOKE.PositionUnknown_get();
}


public IntPtr new_AIModule() {
  return bridgePINVOKE.new_AIModule();
}


public void delete_AIModule(HandleRef jarg1) {
  bridgePINVOKE.delete_AIModule(jarg1);
}


public void AIModule_onStart(HandleRef jarg1) {
  bridgePINVOKE.AIModule_onStart(jarg1);
}


public void AIModule_onEnd(HandleRef jarg1, bool jarg2) {
  bridgePINVOKE.AIModule_onEnd(jarg1, jarg2);
}


public void AIModule_onFrame(HandleRef jarg1) {
  bridgePINVOKE.AIModule_onFrame(jarg1);
}


public bool AIModule_onSendText(HandleRef jarg1, string jarg2) {
  return bridgePINVOKE.AIModule_onSendText(jarg1, jarg2);
}


public void AIModule_onPlayerLeft(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.AIModule_onPlayerLeft(jarg1, jarg2);
}


public void AIModule_onNukeDetect(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.AIModule_onNukeDetect(jarg1, jarg2);
}


public void AIModule_onUnitCreate(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.AIModule_onUnitCreate(jarg1, jarg2);
}


public void AIModule_onUnitDestroy(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.AIModule_onUnitDestroy(jarg1, jarg2);
}


public void AIModule_onUnitMorph(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.AIModule_onUnitMorph(jarg1, jarg2);
}


public void AIModule_onUnitShow(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.AIModule_onUnitShow(jarg1, jarg2);
}


public void AIModule_onUnitHide(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.AIModule_onUnitHide(jarg1, jarg2);
}


public void AIModule_onUnitRenegade(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.AIModule_onUnitRenegade(jarg1, jarg2);
}


public IntPtr new_AttackType__SWIG_0() {
  return bridgePINVOKE.new_AttackType__SWIG_0();
}


public IntPtr new_AttackType__SWIG_1(int jarg1) {
  return bridgePINVOKE.new_AttackType__SWIG_1(jarg1);
}


public IntPtr new_AttackType__SWIG_2(HandleRef jarg1) {
  return bridgePINVOKE.new_AttackType__SWIG_2(jarg1);
}


public IntPtr AttackType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.AttackType_opAssign(jarg1, jarg2);
}


public bool AttackType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.AttackType_opEquals(jarg1, jarg2);
}


public bool AttackType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.AttackType_opNotEquals(jarg1, jarg2);
}


public bool AttackType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.AttackType_opLessThan(jarg1, jarg2);
}


public int AttackType_getID(HandleRef jarg1) {
  return bridgePINVOKE.AttackType_getID(jarg1);
}


public string AttackType_getName(HandleRef jarg1) {
  return bridgePINVOKE.AttackType_getName(jarg1);
}


public void delete_AttackType(HandleRef jarg1) {
  bridgePINVOKE.delete_AttackType(jarg1);
}


public IntPtr getAttackType(string jarg1) {
  return bridgePINVOKE.getAttackType(jarg1);
}


public IntPtr allAttackTypes() {
  return bridgePINVOKE.allAttackTypes();
}


public void initAttackTypes() {
  bridgePINVOKE.initAttackTypes();
}


public IntPtr Melee_get() {
  return bridgePINVOKE.Melee_get();
}


public IntPtr Fusion_Cutter_Hit_get() {
  return bridgePINVOKE.Fusion_Cutter_Hit_get();
}


public IntPtr Gauss_Rifle_Hit_get() {
  return bridgePINVOKE.Gauss_Rifle_Hit_get();
}


public IntPtr C_10_Canister_Rifle_Hit_get() {
  return bridgePINVOKE.C_10_Canister_Rifle_Hit_get();
}


public IntPtr AttackTypeGemeni_Missiles_get() {
  return bridgePINVOKE.AttackTypeGemeni_Missiles_get();
}


public IntPtr AttackTypeFragmentation_Grenade_get() {
  return bridgePINVOKE.AttackTypeFragmentation_Grenade_get();
}


public IntPtr AttackTypeLongbolt_Missile_get() {
  return bridgePINVOKE.AttackTypeLongbolt_Missile_get();
}


public IntPtr ATS_ATA_Laser_Battery_get() {
  return bridgePINVOKE.ATS_ATA_Laser_Battery_get();
}


public IntPtr AttackTypeBurst_Lasers_get() {
  return bridgePINVOKE.AttackTypeBurst_Lasers_get();
}


public IntPtr Arclite_Shock_Cannon_Hit_get() {
  return bridgePINVOKE.Arclite_Shock_Cannon_Hit_get();
}


public IntPtr EMP_Missile_get() {
  return bridgePINVOKE.EMP_Missile_get();
}


public IntPtr Dual_Photon_Blasters_Hit_get() {
  return bridgePINVOKE.Dual_Photon_Blasters_Hit_get();
}


public IntPtr Particle_Beam_Hit_get() {
  return bridgePINVOKE.Particle_Beam_Hit_get();
}


public IntPtr Anti_Matter_Missile_get() {
  return bridgePINVOKE.Anti_Matter_Missile_get();
}


public IntPtr AttackTypePulse_Cannon_get() {
  return bridgePINVOKE.AttackTypePulse_Cannon_get();
}


public IntPtr Psionic_Shockwave_Hit_get() {
  return bridgePINVOKE.Psionic_Shockwave_Hit_get();
}


public IntPtr Psionic_Storm_get() {
  return bridgePINVOKE.Psionic_Storm_get();
}


public IntPtr AttackTypeYamato_Gun_get() {
  return bridgePINVOKE.AttackTypeYamato_Gun_get();
}


public IntPtr AttackTypePhase_Disruptor_get() {
  return bridgePINVOKE.AttackTypePhase_Disruptor_get();
}


public IntPtr STA_STS_Cannon_Overlay_get() {
  return bridgePINVOKE.STA_STS_Cannon_Overlay_get();
}


public IntPtr Sunken_Colony_Tentacle_get() {
  return bridgePINVOKE.Sunken_Colony_Tentacle_get();
}


public IntPtr AttackTypeAcid_Spore_get() {
  return bridgePINVOKE.AttackTypeAcid_Spore_get();
}


public IntPtr AttackTypeGlave_Wurm_get() {
  return bridgePINVOKE.AttackTypeGlave_Wurm_get();
}


public IntPtr AttackTypeSeeker_Spores_get() {
  return bridgePINVOKE.AttackTypeSeeker_Spores_get();
}


public IntPtr Queen_Spell_Carrier_get() {
  return bridgePINVOKE.Queen_Spell_Carrier_get();
}


public IntPtr Plague_Cloud_get() {
  return bridgePINVOKE.Plague_Cloud_get();
}


public IntPtr Consume_get() {
  return bridgePINVOKE.Consume_get();
}


public IntPtr Needle_Spine_Hit_get() {
  return bridgePINVOKE.Needle_Spine_Hit_get();
}


public IntPtr Invisible_get() {
  return bridgePINVOKE.Invisible_get();
}


public IntPtr Optical_Flare_Grenade_get() {
  return bridgePINVOKE.Optical_Flare_Grenade_get();
}


public IntPtr AttackTypeHalo_Rockets_get() {
  return bridgePINVOKE.AttackTypeHalo_Rockets_get();
}


public IntPtr AttackTypeSubterranean_Spines_get() {
  return bridgePINVOKE.AttackTypeSubterranean_Spines_get();
}


public IntPtr Corrosive_Acid_Shot_get() {
  return bridgePINVOKE.Corrosive_Acid_Shot_get();
}


public IntPtr Neutron_Flare_get() {
  return bridgePINVOKE.Neutron_Flare_get();
}


public IntPtr AttackTypeNone_get() {
  return bridgePINVOKE.AttackTypeNone_get();
}


public IntPtr AttackTypeUnknown_get() {
  return bridgePINVOKE.AttackTypeUnknown_get();
}


public IntPtr new_Color__SWIG_0() {
  return bridgePINVOKE.new_Color__SWIG_0();
}


public IntPtr new_Color__SWIG_1(int jarg1) {
  return bridgePINVOKE.new_Color__SWIG_1(jarg1);
}


public IntPtr new_Color__SWIG_2(HandleRef jarg1) {
  return bridgePINVOKE.new_Color__SWIG_2(jarg1);
}


public IntPtr new_Color__SWIG_3(int jarg1, int jarg2, int jarg3) {
  return bridgePINVOKE.new_Color__SWIG_3(jarg1, jarg2, jarg3);
}


public IntPtr Color_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Color_opAssign(jarg1, jarg2);
}


public bool Color_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Color_opEquals(jarg1, jarg2);
}


public bool Color_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Color_opNotEquals(jarg1, jarg2);
}


public bool Color_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Color_opLessThan(jarg1, jarg2);
}


public int Color_getID(HandleRef jarg1) {
  return bridgePINVOKE.Color_getID(jarg1);
}


public int Color_red(HandleRef jarg1) {
  return bridgePINVOKE.Color_red(jarg1);
}


public int Color_green(HandleRef jarg1) {
  return bridgePINVOKE.Color_green(jarg1);
}


public int Color_blue(HandleRef jarg1) {
  return bridgePINVOKE.Color_blue(jarg1);
}


public void delete_Color(HandleRef jarg1) {
  bridgePINVOKE.delete_Color(jarg1);
}


public void initColors() {
  bridgePINVOKE.initColors();
}


public IntPtr Red_get() {
  return bridgePINVOKE.Red_get();
}


public IntPtr Green_get() {
  return bridgePINVOKE.Green_get();
}


public IntPtr Blue_get() {
  return bridgePINVOKE.Blue_get();
}


public IntPtr Yellow_get() {
  return bridgePINVOKE.Yellow_get();
}


public IntPtr Cyan_get() {
  return bridgePINVOKE.Cyan_get();
}


public IntPtr Purple_get() {
  return bridgePINVOKE.Purple_get();
}


public IntPtr Orange_get() {
  return bridgePINVOKE.Orange_get();
}


public IntPtr Black_get() {
  return bridgePINVOKE.Black_get();
}


public IntPtr White_get() {
  return bridgePINVOKE.White_get();
}


public IntPtr Grey_get() {
  return bridgePINVOKE.Grey_get();
}


public int TILE_SIZE_get() {
  return bridgePINVOKE.TILE_SIZE_get();
}


public int PYLON_X_RADIUS_get() {
  return bridgePINVOKE.PYLON_X_RADIUS_get();
}


public int PYLON_Y_RADIUS_get() {
  return bridgePINVOKE.PYLON_Y_RADIUS_get();
}


public IntPtr new_DamageType__SWIG_0() {
  return bridgePINVOKE.new_DamageType__SWIG_0();
}


public IntPtr new_DamageType__SWIG_1(int jarg1) {
  return bridgePINVOKE.new_DamageType__SWIG_1(jarg1);
}


public IntPtr new_DamageType__SWIG_2(HandleRef jarg1) {
  return bridgePINVOKE.new_DamageType__SWIG_2(jarg1);
}


public IntPtr DamageType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.DamageType_opAssign(jarg1, jarg2);
}


public bool DamageType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.DamageType_opEquals(jarg1, jarg2);
}


public bool DamageType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.DamageType_opNotEquals(jarg1, jarg2);
}


public bool DamageType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.DamageType_opLessThan(jarg1, jarg2);
}


public int DamageType_getID(HandleRef jarg1) {
  return bridgePINVOKE.DamageType_getID(jarg1);
}


public string DamageType_getName(HandleRef jarg1) {
  return bridgePINVOKE.DamageType_getName(jarg1);
}


public void delete_DamageType(HandleRef jarg1) {
  bridgePINVOKE.delete_DamageType(jarg1);
}


public IntPtr getDamageType(string jarg1) {
  return bridgePINVOKE.getDamageType(jarg1);
}


public IntPtr allDamageTypes() {
  return bridgePINVOKE.allDamageTypes();
}


public void initDamageTypes() {
  bridgePINVOKE.initDamageTypes();
}


public IntPtr DamageTypeIndependent_get() {
  return bridgePINVOKE.DamageTypeIndependent_get();
}


public IntPtr Explosive_get() {
  return bridgePINVOKE.Explosive_get();
}


public IntPtr Concussive_get() {
  return bridgePINVOKE.Concussive_get();
}


public IntPtr DamageTypeNormal_get() {
  return bridgePINVOKE.DamageTypeNormal_get();
}


public IntPtr Ignore_Armor_get() {
  return bridgePINVOKE.Ignore_Armor_get();
}


public IntPtr DamageTypeNone_get() {
  return bridgePINVOKE.DamageTypeNone_get();
}


public IntPtr DamageTypeUnknown_get() {
  return bridgePINVOKE.DamageTypeUnknown_get();
}


public IntPtr new_Error__SWIG_0() {
  return bridgePINVOKE.new_Error__SWIG_0();
}


public IntPtr new_Error__SWIG_1(int jarg1) {
  return bridgePINVOKE.new_Error__SWIG_1(jarg1);
}


public IntPtr new_Error__SWIG_2(HandleRef jarg1) {
  return bridgePINVOKE.new_Error__SWIG_2(jarg1);
}


public IntPtr Error_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Error_opAssign(jarg1, jarg2);
}


public bool Error_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Error_opEquals(jarg1, jarg2);
}


public bool Error_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Error_opNotEquals(jarg1, jarg2);
}


public bool Error_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Error_opLessThan(jarg1, jarg2);
}


public int Error_getID(HandleRef jarg1) {
  return bridgePINVOKE.Error_getID(jarg1);
}


public string Error_toErrorString(HandleRef jarg1) {
  return bridgePINVOKE.Error_toErrorString(jarg1);
}


public void delete_Error(HandleRef jarg1) {
  bridgePINVOKE.delete_Error(jarg1);
}


public IntPtr getError(string jarg1) {
  return bridgePINVOKE.getError(jarg1);
}


public IntPtr allErrors() {
  return bridgePINVOKE.allErrors();
}


public void initErrors() {
  bridgePINVOKE.initErrors();
}


public IntPtr Unit_Does_Not_Exist_get() {
  return bridgePINVOKE.Unit_Does_Not_Exist_get();
}


public IntPtr Unit_Not_Visible_get() {
  return bridgePINVOKE.Unit_Not_Visible_get();
}


public IntPtr Unit_Not_Owned_get() {
  return bridgePINVOKE.Unit_Not_Owned_get();
}


public IntPtr Unit_Busy_get() {
  return bridgePINVOKE.Unit_Busy_get();
}


public IntPtr Incompatible_UnitType_get() {
  return bridgePINVOKE.Incompatible_UnitType_get();
}


public IntPtr Incompatible_TechType_get() {
  return bridgePINVOKE.Incompatible_TechType_get();
}


public IntPtr Already_Researched_get() {
  return bridgePINVOKE.Already_Researched_get();
}


public IntPtr Fully_Upgraded_get() {
  return bridgePINVOKE.Fully_Upgraded_get();
}


public IntPtr Insufficient_Minerals_get() {
  return bridgePINVOKE.Insufficient_Minerals_get();
}


public IntPtr Insufficient_Gas_get() {
  return bridgePINVOKE.Insufficient_Gas_get();
}


public IntPtr Insufficient_Supply_get() {
  return bridgePINVOKE.Insufficient_Supply_get();
}


public IntPtr Insufficient_Energy_get() {
  return bridgePINVOKE.Insufficient_Energy_get();
}


public IntPtr Insufficient_Tech_get() {
  return bridgePINVOKE.Insufficient_Tech_get();
}


public IntPtr Insufficient_Ammo_get() {
  return bridgePINVOKE.Insufficient_Ammo_get();
}


public IntPtr Insufficient_Space_get() {
  return bridgePINVOKE.Insufficient_Space_get();
}


public IntPtr Unbuildable_Location_get() {
  return bridgePINVOKE.Unbuildable_Location_get();
}


public IntPtr Out_Of_Range_get() {
  return bridgePINVOKE.Out_Of_Range_get();
}


public IntPtr Unable_To_Hit_get() {
  return bridgePINVOKE.Unable_To_Hit_get();
}


public IntPtr Access_Denied_get() {
  return bridgePINVOKE.Access_Denied_get();
}


public IntPtr ErrorNone_get() {
  return bridgePINVOKE.ErrorNone_get();
}


public IntPtr ErrorUnknown_get() {
  return bridgePINVOKE.ErrorUnknown_get();
}


public IntPtr new_ExplosionType__SWIG_0() {
  return bridgePINVOKE.new_ExplosionType__SWIG_0();
}


public IntPtr new_ExplosionType__SWIG_1(int jarg1) {
  return bridgePINVOKE.new_ExplosionType__SWIG_1(jarg1);
}


public IntPtr new_ExplosionType__SWIG_2(HandleRef jarg1) {
  return bridgePINVOKE.new_ExplosionType__SWIG_2(jarg1);
}


public IntPtr ExplosionType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.ExplosionType_opAssign(jarg1, jarg2);
}


public bool ExplosionType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.ExplosionType_opEquals(jarg1, jarg2);
}


public bool ExplosionType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.ExplosionType_opNotEquals(jarg1, jarg2);
}


public bool ExplosionType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.ExplosionType_opLessThan(jarg1, jarg2);
}


public int ExplosionType_getID(HandleRef jarg1) {
  return bridgePINVOKE.ExplosionType_getID(jarg1);
}


public string ExplosionType_getName(HandleRef jarg1) {
  return bridgePINVOKE.ExplosionType_getName(jarg1);
}


public void delete_ExplosionType(HandleRef jarg1) {
  bridgePINVOKE.delete_ExplosionType(jarg1);
}


public IntPtr getExplosionType(string jarg1) {
  return bridgePINVOKE.getExplosionType(jarg1);
}


public IntPtr allExplosionTypes() {
  return bridgePINVOKE.allExplosionTypes();
}


public void initExplosionTypes() {
  bridgePINVOKE.initExplosionTypes();
}


public IntPtr ExplosionTypeNone_get() {
  return bridgePINVOKE.ExplosionTypeNone_get();
}


public IntPtr ExplosionTypeNormal_get() {
  return bridgePINVOKE.ExplosionTypeNormal_get();
}


public IntPtr Radial_Splash_get() {
  return bridgePINVOKE.Radial_Splash_get();
}


public IntPtr Enemy_Splash_get() {
  return bridgePINVOKE.Enemy_Splash_get();
}


public IntPtr ExplosionTypeLockdown_get() {
  return bridgePINVOKE.ExplosionTypeLockdown_get();
}


public IntPtr Nuclear_Missile_get() {
  return bridgePINVOKE.Nuclear_Missile_get();
}


public IntPtr ExplosionTypeParasite_get() {
  return bridgePINVOKE.ExplosionTypeParasite_get();
}


public IntPtr Broodlings_get() {
  return bridgePINVOKE.Broodlings_get();
}


public IntPtr ExplosionTypeEMP_Shockwave_get() {
  return bridgePINVOKE.ExplosionTypeEMP_Shockwave_get();
}


public IntPtr ExplosionTypeIrradiate_get() {
  return bridgePINVOKE.ExplosionTypeIrradiate_get();
}


public IntPtr ExplosionTypeEnsnare_get() {
  return bridgePINVOKE.ExplosionTypeEnsnare_get();
}


public IntPtr ExplosionTypePlague_get() {
  return bridgePINVOKE.ExplosionTypePlague_get();
}


public IntPtr ExplosionTypeStasis_Field_get() {
  return bridgePINVOKE.ExplosionTypeStasis_Field_get();
}


public IntPtr ExplosionTypeDark_Swarm_get() {
  return bridgePINVOKE.ExplosionTypeDark_Swarm_get();
}


public IntPtr ExplosionTypeConsume_get() {
  return bridgePINVOKE.ExplosionTypeConsume_get();
}


public IntPtr ExplosionTypeYamato_Gun_get() {
  return bridgePINVOKE.ExplosionTypeYamato_Gun_get();
}


public IntPtr ExplosionTypeRestoration_get() {
  return bridgePINVOKE.ExplosionTypeRestoration_get();
}


public IntPtr ExplosionTypeDisruption_Web_get() {
  return bridgePINVOKE.ExplosionTypeDisruption_Web_get();
}


public IntPtr ExplosionTypeCorrosive_Acid_get() {
  return bridgePINVOKE.ExplosionTypeCorrosive_Acid_get();
}


public IntPtr ExplosionTypeMind_Control_get() {
  return bridgePINVOKE.ExplosionTypeMind_Control_get();
}


public IntPtr ExplosionTypeFeedback_get() {
  return bridgePINVOKE.ExplosionTypeFeedback_get();
}


public IntPtr ExplosionTypeOptical_Flare_get() {
  return bridgePINVOKE.ExplosionTypeOptical_Flare_get();
}


public IntPtr ExplosionTypeMaelstrom_get() {
  return bridgePINVOKE.ExplosionTypeMaelstrom_get();
}


public IntPtr Air_Splash_get() {
  return bridgePINVOKE.Air_Splash_get();
}


public IntPtr ExplosionTypeUnknown_get() {
  return bridgePINVOKE.ExplosionTypeUnknown_get();
}


public int FLAG_COUNT_get() {
  return bridgePINVOKE.FLAG_COUNT_get();
}


public string Force_getName(HandleRef jarg1) {
  return bridgePINVOKE.Force_getName(jarg1);
}


public IntPtr Force_getPlayers(HandleRef jarg1) {
  return bridgePINVOKE.Force_getPlayers(jarg1);
}


public void delete_Force(HandleRef jarg1) {
  bridgePINVOKE.delete_Force(jarg1);
}


public IntPtr Game_getForces(HandleRef jarg1) {
  return bridgePINVOKE.Game_getForces(jarg1);
}


public IntPtr Game_getPlayers(HandleRef jarg1) {
  return bridgePINVOKE.Game_getPlayers(jarg1);
}


public IntPtr Game_getAllUnits(HandleRef jarg1) {
  return bridgePINVOKE.Game_getAllUnits(jarg1);
}


public IntPtr Game_getMinerals(HandleRef jarg1) {
  return bridgePINVOKE.Game_getMinerals(jarg1);
}


public IntPtr Game_getGeysers(HandleRef jarg1) {
  return bridgePINVOKE.Game_getGeysers(jarg1);
}


public IntPtr Game_getNeutralUnits(HandleRef jarg1) {
  return bridgePINVOKE.Game_getNeutralUnits(jarg1);
}


public IntPtr Game_getStaticMinerals(HandleRef jarg1) {
  return bridgePINVOKE.Game_getStaticMinerals(jarg1);
}


public IntPtr Game_getStaticGeysers(HandleRef jarg1) {
  return bridgePINVOKE.Game_getStaticGeysers(jarg1);
}


public IntPtr Game_getStaticNeutralUnits(HandleRef jarg1) {
  return bridgePINVOKE.Game_getStaticNeutralUnits(jarg1);
}


public int Game_getLatency(HandleRef jarg1) {
  return bridgePINVOKE.Game_getLatency(jarg1);
}


public int Game_getFrameCount(HandleRef jarg1) {
  return bridgePINVOKE.Game_getFrameCount(jarg1);
}


public int Game_getMouseX(HandleRef jarg1) {
  return bridgePINVOKE.Game_getMouseX(jarg1);
}


public int Game_getMouseY(HandleRef jarg1) {
  return bridgePINVOKE.Game_getMouseY(jarg1);
}


public IntPtr Game_getMousePosition(HandleRef jarg1) {
  return bridgePINVOKE.Game_getMousePosition(jarg1);
}


public bool Game_getMouseState__SWIG_0(HandleRef jarg1, int jarg2) {
  return bridgePINVOKE.Game_getMouseState__SWIG_0(jarg1, jarg2);
}


public bool Game_getMouseState__SWIG_1(HandleRef jarg1, int jarg2) {
  return bridgePINVOKE.Game_getMouseState__SWIG_1(jarg1, jarg2);
}


public bool Game_getKeyState__SWIG_0(HandleRef jarg1, int jarg2) {
  return bridgePINVOKE.Game_getKeyState__SWIG_0(jarg1, jarg2);
}


public bool Game_getKeyState__SWIG_1(HandleRef jarg1, int jarg2) {
  return bridgePINVOKE.Game_getKeyState__SWIG_1(jarg1, jarg2);
}


public int Game_getScreenX(HandleRef jarg1) {
  return bridgePINVOKE.Game_getScreenX(jarg1);
}


public int Game_getScreenY(HandleRef jarg1) {
  return bridgePINVOKE.Game_getScreenY(jarg1);
}


public IntPtr Game_getScreenPosition(HandleRef jarg1) {
  return bridgePINVOKE.Game_getScreenPosition(jarg1);
}


public void Game_setScreenPosition__SWIG_0(HandleRef jarg1, int jarg2, int jarg3) {
  bridgePINVOKE.Game_setScreenPosition__SWIG_0(jarg1, jarg2, jarg3);
}


public void Game_setScreenPosition__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.Game_setScreenPosition__SWIG_1(jarg1, jarg2);
}


public void Game_pingMinimap__SWIG_0(HandleRef jarg1, int jarg2, int jarg3) {
  bridgePINVOKE.Game_pingMinimap__SWIG_0(jarg1, jarg2, jarg3);
}


public void Game_pingMinimap__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.Game_pingMinimap__SWIG_1(jarg1, jarg2);
}


public bool Game_isFlagEnabled(HandleRef jarg1, int jarg2) {
  return bridgePINVOKE.Game_isFlagEnabled(jarg1, jarg2);
}


public void Game_enableFlag(HandleRef jarg1, int jarg2) {
  bridgePINVOKE.Game_enableFlag(jarg1, jarg2);
}


public IntPtr Game_unitsOnTile(HandleRef jarg1, int jarg2, int jarg3) {
  return bridgePINVOKE.Game_unitsOnTile(jarg1, jarg2, jarg3);
}


public IntPtr Game_getLastError(HandleRef jarg1) {
  return bridgePINVOKE.Game_getLastError(jarg1);
}


public int Game_mapWidth(HandleRef jarg1) {
  return bridgePINVOKE.Game_mapWidth(jarg1);
}


public int Game_mapHeight(HandleRef jarg1) {
  return bridgePINVOKE.Game_mapHeight(jarg1);
}


public string Game_mapFilename(HandleRef jarg1) {
  return bridgePINVOKE.Game_mapFilename(jarg1);
}


public string Game_mapName(HandleRef jarg1) {
  return bridgePINVOKE.Game_mapName(jarg1);
}


public int Game_getMapHash(HandleRef jarg1) {
  return bridgePINVOKE.Game_getMapHash(jarg1);
}


public int Game_getGroundHeight(HandleRef jarg1, int jarg2, int jarg3) {
  return bridgePINVOKE.Game_getGroundHeight(jarg1, jarg2, jarg3);
}


public bool Game_isWalkable(HandleRef jarg1, int jarg2, int jarg3) {
  return bridgePINVOKE.Game_isWalkable(jarg1, jarg2, jarg3);
}


public bool Game_isBuildable__SWIG_0(HandleRef jarg1, int jarg2, int jarg3) {
  return bridgePINVOKE.Game_isBuildable__SWIG_0(jarg1, jarg2, jarg3);
}


public bool Game_isVisible__SWIG_0(HandleRef jarg1, int jarg2, int jarg3) {
  return bridgePINVOKE.Game_isVisible__SWIG_0(jarg1, jarg2, jarg3);
}


public bool Game_isExplored__SWIG_0(HandleRef jarg1, int jarg2, int jarg3) {
  return bridgePINVOKE.Game_isExplored__SWIG_0(jarg1, jarg2, jarg3);
}


public bool Game_hasCreep__SWIG_0(HandleRef jarg1, int jarg2, int jarg3) {
  return bridgePINVOKE.Game_hasCreep__SWIG_0(jarg1, jarg2, jarg3);
}


public bool Game_hasPower__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5) {
  return bridgePINVOKE.Game_hasPower__SWIG_0(jarg1, jarg2, jarg3, jarg4, jarg5);
}


public bool Game_isBuildable__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Game_isBuildable__SWIG_1(jarg1, jarg2);
}


public bool Game_isVisible__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Game_isVisible__SWIG_1(jarg1, jarg2);
}


public bool Game_isExplored__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Game_isExplored__SWIG_1(jarg1, jarg2);
}


public bool Game_hasCreep__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Game_hasCreep__SWIG_1(jarg1, jarg2);
}


public bool Game_hasPower__SWIG_1(HandleRef jarg1, HandleRef jarg2, int jarg3, int jarg4) {
  return bridgePINVOKE.Game_hasPower__SWIG_1(jarg1, jarg2, jarg3, jarg4);
}


public bool Game_canBuildHere(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4) {
  return bridgePINVOKE.Game_canBuildHere(jarg1, jarg2, jarg3, jarg4);
}


public bool Game_canMake(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3) {
  return bridgePINVOKE.Game_canMake(jarg1, jarg2, jarg3);
}


public bool Game_canResearch(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3) {
  return bridgePINVOKE.Game_canResearch(jarg1, jarg2, jarg3);
}


public bool Game_canUpgrade(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3) {
  return bridgePINVOKE.Game_canUpgrade(jarg1, jarg2, jarg3);
}


public IntPtr Game_getStartLocations(HandleRef jarg1) {
  return bridgePINVOKE.Game_getStartLocations(jarg1);
}


public void Game_printf(HandleRef jarg1, string jarg2) {
  bridgePINVOKE.Game_printf(jarg1, jarg2);
}


public void Game_sendText(HandleRef jarg1, string jarg2) {
  bridgePINVOKE.Game_sendText(jarg1, jarg2);
}


public void Game_changeRace(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.Game_changeRace(jarg1, jarg2);
}


public bool Game_isMultiplayer(HandleRef jarg1) {
  return bridgePINVOKE.Game_isMultiplayer(jarg1);
}


public bool Game_isPaused(HandleRef jarg1) {
  return bridgePINVOKE.Game_isPaused(jarg1);
}


public bool Game_isReplay(HandleRef jarg1) {
  return bridgePINVOKE.Game_isReplay(jarg1);
}


public void Game_startGame(HandleRef jarg1) {
  bridgePINVOKE.Game_startGame(jarg1);
}


public void Game_pauseGame(HandleRef jarg1) {
  bridgePINVOKE.Game_pauseGame(jarg1);
}


public void Game_resumeGame(HandleRef jarg1) {
  bridgePINVOKE.Game_resumeGame(jarg1);
}


public void Game_leaveGame(HandleRef jarg1) {
  bridgePINVOKE.Game_leaveGame(jarg1);
}


public void Game_restartGame(HandleRef jarg1) {
  bridgePINVOKE.Game_restartGame(jarg1);
}


public void Game_setLocalSpeed__SWIG_0(HandleRef jarg1, int jarg2) {
  bridgePINVOKE.Game_setLocalSpeed__SWIG_0(jarg1, jarg2);
}


public void Game_setLocalSpeed__SWIG_1(HandleRef jarg1) {
  bridgePINVOKE.Game_setLocalSpeed__SWIG_1(jarg1);
}


public IntPtr Game_getSelectedUnits(HandleRef jarg1) {
  return bridgePINVOKE.Game_getSelectedUnits(jarg1);
}


public IntPtr Game_self(HandleRef jarg1) {
  return bridgePINVOKE.Game_self(jarg1);
}


public IntPtr Game_enemy(HandleRef jarg1) {
  return bridgePINVOKE.Game_enemy(jarg1);
}


public void Game_drawText(HandleRef jarg1, int jarg2, int jarg3, int jarg4, string jarg5) {
  bridgePINVOKE.Game_drawText(jarg1, jarg2, jarg3, jarg4, jarg5);
}


public void Game_drawTextMap(HandleRef jarg1, int jarg2, int jarg3, string jarg4) {
  bridgePINVOKE.Game_drawTextMap(jarg1, jarg2, jarg3, jarg4);
}


public void Game_drawTextMouse(HandleRef jarg1, int jarg2, int jarg3, string jarg4) {
  bridgePINVOKE.Game_drawTextMouse(jarg1, jarg2, jarg3, jarg4);
}


public void Game_drawTextScreen(HandleRef jarg1, int jarg2, int jarg3, string jarg4) {
  bridgePINVOKE.Game_drawTextScreen(jarg1, jarg2, jarg3, jarg4);
}


public void Game_drawBox__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, HandleRef jarg7, bool jarg8) {
  bridgePINVOKE.Game_drawBox__SWIG_0(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8);
}


public void Game_drawBox__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, HandleRef jarg7) {
  bridgePINVOKE.Game_drawBox__SWIG_1(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7);
}


public void Game_drawBoxMap__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6, bool jarg7) {
  bridgePINVOKE.Game_drawBoxMap__SWIG_0(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7);
}


public void Game_drawBoxMap__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  bridgePINVOKE.Game_drawBoxMap__SWIG_1(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6);
}


public void Game_drawBoxMouse__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6, bool jarg7) {
  bridgePINVOKE.Game_drawBoxMouse__SWIG_0(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7);
}


public void Game_drawBoxMouse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  bridgePINVOKE.Game_drawBoxMouse__SWIG_1(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6);
}


public void Game_drawBoxScreen__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6, bool jarg7) {
  bridgePINVOKE.Game_drawBoxScreen__SWIG_0(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7);
}


public void Game_drawBoxScreen__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  bridgePINVOKE.Game_drawBoxScreen__SWIG_1(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6);
}


public void Game_drawTriangle__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, int jarg8, HandleRef jarg9, bool jarg10) {
  bridgePINVOKE.Game_drawTriangle__SWIG_0(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8, jarg9, jarg10);
}


public void Game_drawTriangle__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, int jarg8, HandleRef jarg9) {
  bridgePINVOKE.Game_drawTriangle__SWIG_1(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8, jarg9);
}


public void Game_drawTriangleMap__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, HandleRef jarg8, bool jarg9) {
  bridgePINVOKE.Game_drawTriangleMap__SWIG_0(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8, jarg9);
}


public void Game_drawTriangleMap__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, HandleRef jarg8) {
  bridgePINVOKE.Game_drawTriangleMap__SWIG_1(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8);
}


public void Game_drawTriangleMouse__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, HandleRef jarg8, bool jarg9) {
  bridgePINVOKE.Game_drawTriangleMouse__SWIG_0(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8, jarg9);
}


public void Game_drawTriangleMouse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, HandleRef jarg8) {
  bridgePINVOKE.Game_drawTriangleMouse__SWIG_1(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8);
}


public void Game_drawTriangleScreen__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, HandleRef jarg8, bool jarg9) {
  bridgePINVOKE.Game_drawTriangleScreen__SWIG_0(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8, jarg9);
}


public void Game_drawTriangleScreen__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, HandleRef jarg8) {
  bridgePINVOKE.Game_drawTriangleScreen__SWIG_1(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8);
}


public void Game_drawCircle__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6, bool jarg7) {
  bridgePINVOKE.Game_drawCircle__SWIG_0(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7);
}


public void Game_drawCircle__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  bridgePINVOKE.Game_drawCircle__SWIG_1(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6);
}


public void Game_drawCircleMap__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, HandleRef jarg5, bool jarg6) {
  bridgePINVOKE.Game_drawCircleMap__SWIG_0(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6);
}


public void Game_drawCircleMap__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, HandleRef jarg5) {
  bridgePINVOKE.Game_drawCircleMap__SWIG_1(jarg1, jarg2, jarg3, jarg4, jarg5);
}


public void Game_drawCircleMouse__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, HandleRef jarg5, bool jarg6) {
  bridgePINVOKE.Game_drawCircleMouse__SWIG_0(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6);
}


public void Game_drawCircleMouse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, HandleRef jarg5) {
  bridgePINVOKE.Game_drawCircleMouse__SWIG_1(jarg1, jarg2, jarg3, jarg4, jarg5);
}


public void Game_drawCircleScreen__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, HandleRef jarg5, bool jarg6) {
  bridgePINVOKE.Game_drawCircleScreen__SWIG_0(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6);
}


public void Game_drawCircleScreen__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, HandleRef jarg5) {
  bridgePINVOKE.Game_drawCircleScreen__SWIG_1(jarg1, jarg2, jarg3, jarg4, jarg5);
}


public void Game_drawEllipse__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, HandleRef jarg7, bool jarg8) {
  bridgePINVOKE.Game_drawEllipse__SWIG_0(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8);
}


public void Game_drawEllipse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, HandleRef jarg7) {
  bridgePINVOKE.Game_drawEllipse__SWIG_1(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7);
}


public void Game_drawEllipseMap__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6, bool jarg7) {
  bridgePINVOKE.Game_drawEllipseMap__SWIG_0(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7);
}


public void Game_drawEllipseMap__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  bridgePINVOKE.Game_drawEllipseMap__SWIG_1(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6);
}


public void Game_drawEllipseMouse__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6, bool jarg7) {
  bridgePINVOKE.Game_drawEllipseMouse__SWIG_0(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7);
}


public void Game_drawEllipseMouse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  bridgePINVOKE.Game_drawEllipseMouse__SWIG_1(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6);
}


public void Game_drawEllipseScreen__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6, bool jarg7) {
  bridgePINVOKE.Game_drawEllipseScreen__SWIG_0(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7);
}


public void Game_drawEllipseScreen__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  bridgePINVOKE.Game_drawEllipseScreen__SWIG_1(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6);
}


public void Game_drawDot(HandleRef jarg1, int jarg2, int jarg3, int jarg4, HandleRef jarg5) {
  bridgePINVOKE.Game_drawDot(jarg1, jarg2, jarg3, jarg4, jarg5);
}


public void Game_drawDotMap(HandleRef jarg1, int jarg2, int jarg3, HandleRef jarg4) {
  bridgePINVOKE.Game_drawDotMap(jarg1, jarg2, jarg3, jarg4);
}


public void Game_drawDotMouse(HandleRef jarg1, int jarg2, int jarg3, HandleRef jarg4) {
  bridgePINVOKE.Game_drawDotMouse(jarg1, jarg2, jarg3, jarg4);
}


public void Game_drawDotScreen(HandleRef jarg1, int jarg2, int jarg3, HandleRef jarg4) {
  bridgePINVOKE.Game_drawDotScreen(jarg1, jarg2, jarg3, jarg4);
}


public void Game_drawLine(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, HandleRef jarg7) {
  bridgePINVOKE.Game_drawLine(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7);
}


public void Game_drawLineMap(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  bridgePINVOKE.Game_drawLineMap(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6);
}


public void Game_drawLineMouse(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  bridgePINVOKE.Game_drawLineMouse(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6);
}


public void Game_drawLineScreen(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  bridgePINVOKE.Game_drawLineScreen(jarg1, jarg2, jarg3, jarg4, jarg5, jarg6);
}


public void delete_Game(HandleRef jarg1) {
  bridgePINVOKE.delete_Game(jarg1);
}


public void Broodwar_set(HandleRef jarg1) {
  bridgePINVOKE.Broodwar_set(jarg1);
}


public IntPtr Broodwar_get() {
  return bridgePINVOKE.Broodwar_get();
}


public IntPtr new_Order__SWIG_0() {
  return bridgePINVOKE.new_Order__SWIG_0();
}


public IntPtr new_Order__SWIG_1(int jarg1) {
  return bridgePINVOKE.new_Order__SWIG_1(jarg1);
}


public IntPtr new_Order__SWIG_2(HandleRef jarg1) {
  return bridgePINVOKE.new_Order__SWIG_2(jarg1);
}


public IntPtr Order_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Order_opAssign(jarg1, jarg2);
}


public bool Order_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Order_opEquals(jarg1, jarg2);
}


public bool Order_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Order_opNotEquals(jarg1, jarg2);
}


public bool Order_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Order_opLessThan(jarg1, jarg2);
}


public int Order_getID(HandleRef jarg1) {
  return bridgePINVOKE.Order_getID(jarg1);
}


public string Order_getName(HandleRef jarg1) {
  return bridgePINVOKE.Order_getName(jarg1);
}


public void delete_Order(HandleRef jarg1) {
  bridgePINVOKE.delete_Order(jarg1);
}


public IntPtr getOrder(string jarg1) {
  return bridgePINVOKE.getOrder(jarg1);
}


public IntPtr allOrders() {
  return bridgePINVOKE.allOrders();
}


public void initOrders() {
  bridgePINVOKE.initOrders();
}


public IntPtr Die_get() {
  return bridgePINVOKE.Die_get();
}


public IntPtr Stop_get() {
  return bridgePINVOKE.Stop_get();
}


public IntPtr Guard_get() {
  return bridgePINVOKE.Guard_get();
}


public IntPtr PlayerGuard_get() {
  return bridgePINVOKE.PlayerGuard_get();
}


public IntPtr TurretGuard_get() {
  return bridgePINVOKE.TurretGuard_get();
}


public IntPtr BunkerGuard_get() {
  return bridgePINVOKE.BunkerGuard_get();
}


public IntPtr Move_get() {
  return bridgePINVOKE.Move_get();
}


public IntPtr ReaverStop_get() {
  return bridgePINVOKE.ReaverStop_get();
}


public IntPtr Attack1_get() {
  return bridgePINVOKE.Attack1_get();
}


public IntPtr Attack2_get() {
  return bridgePINVOKE.Attack2_get();
}


public IntPtr AttackUnit_get() {
  return bridgePINVOKE.AttackUnit_get();
}


public IntPtr AttackFixedRange_get() {
  return bridgePINVOKE.AttackFixedRange_get();
}


public IntPtr AttackTile_get() {
  return bridgePINVOKE.AttackTile_get();
}


public IntPtr Hover_get() {
  return bridgePINVOKE.Hover_get();
}


public IntPtr AttackMove_get() {
  return bridgePINVOKE.AttackMove_get();
}


public IntPtr InfestMine1_get() {
  return bridgePINVOKE.InfestMine1_get();
}


public IntPtr Nothing1_get() {
  return bridgePINVOKE.Nothing1_get();
}


public IntPtr Powerup1_get() {
  return bridgePINVOKE.Powerup1_get();
}


public IntPtr TowerGuard_get() {
  return bridgePINVOKE.TowerGuard_get();
}


public IntPtr TowerAttack_get() {
  return bridgePINVOKE.TowerAttack_get();
}


public IntPtr VultureMine_get() {
  return bridgePINVOKE.VultureMine_get();
}


public IntPtr StayinRange_get() {
  return bridgePINVOKE.StayinRange_get();
}


public IntPtr TurretAttack_get() {
  return bridgePINVOKE.TurretAttack_get();
}


public IntPtr Nothing2_get() {
  return bridgePINVOKE.Nothing2_get();
}


public IntPtr Nothing3_get() {
  return bridgePINVOKE.Nothing3_get();
}


public IntPtr DroneStartBuild_get() {
  return bridgePINVOKE.DroneStartBuild_get();
}


public IntPtr DroneBuild_get() {
  return bridgePINVOKE.DroneBuild_get();
}


public IntPtr InfestMine2_get() {
  return bridgePINVOKE.InfestMine2_get();
}


public IntPtr InfestMine3_get() {
  return bridgePINVOKE.InfestMine3_get();
}


public IntPtr InfestMine4_get() {
  return bridgePINVOKE.InfestMine4_get();
}


public IntPtr BuildTerran_get() {
  return bridgePINVOKE.BuildTerran_get();
}


public IntPtr BuildProtoss1_get() {
  return bridgePINVOKE.BuildProtoss1_get();
}


public IntPtr BuildProtoss2_get() {
  return bridgePINVOKE.BuildProtoss2_get();
}


public IntPtr ConstructingBuilding_get() {
  return bridgePINVOKE.ConstructingBuilding_get();
}


public IntPtr Repair1_get() {
  return bridgePINVOKE.Repair1_get();
}


public IntPtr Repair2_get() {
  return bridgePINVOKE.Repair2_get();
}


public IntPtr PlaceAddon_get() {
  return bridgePINVOKE.PlaceAddon_get();
}


public IntPtr BuildAddon_get() {
  return bridgePINVOKE.BuildAddon_get();
}


public IntPtr Train_get() {
  return bridgePINVOKE.Train_get();
}


public IntPtr RallyPoint1_get() {
  return bridgePINVOKE.RallyPoint1_get();
}


public IntPtr RallyPoint2_get() {
  return bridgePINVOKE.RallyPoint2_get();
}


public IntPtr ZergBirth_get() {
  return bridgePINVOKE.ZergBirth_get();
}


public IntPtr Morph1_get() {
  return bridgePINVOKE.Morph1_get();
}


public IntPtr Morph2_get() {
  return bridgePINVOKE.Morph2_get();
}


public IntPtr BuildSelf1_get() {
  return bridgePINVOKE.BuildSelf1_get();
}


public IntPtr ZergBuildSelf_get() {
  return bridgePINVOKE.ZergBuildSelf_get();
}


public IntPtr Build5_get() {
  return bridgePINVOKE.Build5_get();
}


public IntPtr Enternyduscanal_get() {
  return bridgePINVOKE.Enternyduscanal_get();
}


public IntPtr BuildSelf2_get() {
  return bridgePINVOKE.BuildSelf2_get();
}


public IntPtr Follow_get() {
  return bridgePINVOKE.Follow_get();
}


public IntPtr Carrier_get() {
  return bridgePINVOKE.Carrier_get();
}


public IntPtr CarrierIgnore1_get() {
  return bridgePINVOKE.CarrierIgnore1_get();
}


public IntPtr CarrierStop_get() {
  return bridgePINVOKE.CarrierStop_get();
}


public IntPtr CarrierAttack1_get() {
  return bridgePINVOKE.CarrierAttack1_get();
}


public IntPtr CarrierAttack2_get() {
  return bridgePINVOKE.CarrierAttack2_get();
}


public IntPtr CarrierIgnore2_get() {
  return bridgePINVOKE.CarrierIgnore2_get();
}


public IntPtr CarrierFight_get() {
  return bridgePINVOKE.CarrierFight_get();
}


public IntPtr HoldPosition1_get() {
  return bridgePINVOKE.HoldPosition1_get();
}


public IntPtr Reaver_get() {
  return bridgePINVOKE.Reaver_get();
}


public IntPtr ReaverAttack1_get() {
  return bridgePINVOKE.ReaverAttack1_get();
}


public IntPtr ReaverAttack2_get() {
  return bridgePINVOKE.ReaverAttack2_get();
}


public IntPtr ReaverFight_get() {
  return bridgePINVOKE.ReaverFight_get();
}


public IntPtr ReaverHold_get() {
  return bridgePINVOKE.ReaverHold_get();
}


public IntPtr TrainFighter_get() {
  return bridgePINVOKE.TrainFighter_get();
}


public IntPtr StrafeUnit1_get() {
  return bridgePINVOKE.StrafeUnit1_get();
}


public IntPtr StrafeUnit2_get() {
  return bridgePINVOKE.StrafeUnit2_get();
}


public IntPtr RechargeShields1_get() {
  return bridgePINVOKE.RechargeShields1_get();
}


public IntPtr Rechargeshields2_get() {
  return bridgePINVOKE.Rechargeshields2_get();
}


public IntPtr ShieldBattery_get() {
  return bridgePINVOKE.ShieldBattery_get();
}


public IntPtr Return_get() {
  return bridgePINVOKE.Return_get();
}


public IntPtr DroneLand_get() {
  return bridgePINVOKE.DroneLand_get();
}


public IntPtr BuildingLand_get() {
  return bridgePINVOKE.BuildingLand_get();
}


public IntPtr BuildingLiftoff_get() {
  return bridgePINVOKE.BuildingLiftoff_get();
}


public IntPtr DroneLiftoff_get() {
  return bridgePINVOKE.DroneLiftoff_get();
}


public IntPtr Liftoff_get() {
  return bridgePINVOKE.Liftoff_get();
}


public IntPtr ResearchTech_get() {
  return bridgePINVOKE.ResearchTech_get();
}


public IntPtr Upgrade_get() {
  return bridgePINVOKE.Upgrade_get();
}


public IntPtr Larva_get() {
  return bridgePINVOKE.Larva_get();
}


public IntPtr SpawningLarva_get() {
  return bridgePINVOKE.SpawningLarva_get();
}


public IntPtr Harvest1_get() {
  return bridgePINVOKE.Harvest1_get();
}


public IntPtr Harvest2_get() {
  return bridgePINVOKE.Harvest2_get();
}


public IntPtr MoveToGas_get() {
  return bridgePINVOKE.MoveToGas_get();
}


public IntPtr WaitForGas_get() {
  return bridgePINVOKE.WaitForGas_get();
}


public IntPtr HarvestGas_get() {
  return bridgePINVOKE.HarvestGas_get();
}


public IntPtr ReturnGas_get() {
  return bridgePINVOKE.ReturnGas_get();
}


public IntPtr MoveToMinerals_get() {
  return bridgePINVOKE.MoveToMinerals_get();
}


public IntPtr WaitForMinerals_get() {
  return bridgePINVOKE.WaitForMinerals_get();
}


public IntPtr MiningMinerals_get() {
  return bridgePINVOKE.MiningMinerals_get();
}


public IntPtr Harvest3_get() {
  return bridgePINVOKE.Harvest3_get();
}


public IntPtr Harvest4_get() {
  return bridgePINVOKE.Harvest4_get();
}


public IntPtr ReturnMinerals_get() {
  return bridgePINVOKE.ReturnMinerals_get();
}


public IntPtr Harvest5_get() {
  return bridgePINVOKE.Harvest5_get();
}


public IntPtr EnterTransport_get() {
  return bridgePINVOKE.EnterTransport_get();
}


public IntPtr Pickup1_get() {
  return bridgePINVOKE.Pickup1_get();
}


public IntPtr Pickup2_get() {
  return bridgePINVOKE.Pickup2_get();
}


public IntPtr Pickup3_get() {
  return bridgePINVOKE.Pickup3_get();
}


public IntPtr Pickup4_get() {
  return bridgePINVOKE.Pickup4_get();
}


public IntPtr Powerup2_get() {
  return bridgePINVOKE.Powerup2_get();
}


public IntPtr SiegeMode_get() {
  return bridgePINVOKE.SiegeMode_get();
}


public IntPtr TankMode_get() {
  return bridgePINVOKE.TankMode_get();
}


public IntPtr WatchTarget_get() {
  return bridgePINVOKE.WatchTarget_get();
}


public IntPtr InitCreepGrowth_get() {
  return bridgePINVOKE.InitCreepGrowth_get();
}


public IntPtr SpreadCreep_get() {
  return bridgePINVOKE.SpreadCreep_get();
}


public IntPtr StoppingCreepGrowth_get() {
  return bridgePINVOKE.StoppingCreepGrowth_get();
}


public IntPtr GuardianAspect_get() {
  return bridgePINVOKE.GuardianAspect_get();
}


public IntPtr WarpingArchon_get() {
  return bridgePINVOKE.WarpingArchon_get();
}


public IntPtr CompletingArchonsummon_get() {
  return bridgePINVOKE.CompletingArchonsummon_get();
}


public IntPtr HoldPosition2_get() {
  return bridgePINVOKE.HoldPosition2_get();
}


public IntPtr HoldPosition3_get() {
  return bridgePINVOKE.HoldPosition3_get();
}


public IntPtr Cloak_get() {
  return bridgePINVOKE.Cloak_get();
}


public IntPtr Decloak_get() {
  return bridgePINVOKE.Decloak_get();
}


public IntPtr Unload_get() {
  return bridgePINVOKE.Unload_get();
}


public IntPtr MoveUnload_get() {
  return bridgePINVOKE.MoveUnload_get();
}


public IntPtr FireYamatoGun1_get() {
  return bridgePINVOKE.FireYamatoGun1_get();
}


public IntPtr FireYamatoGun2_get() {
  return bridgePINVOKE.FireYamatoGun2_get();
}


public IntPtr MagnaPulse_get() {
  return bridgePINVOKE.MagnaPulse_get();
}


public IntPtr Burrow_get() {
  return bridgePINVOKE.Burrow_get();
}


public IntPtr Burrowed_get() {
  return bridgePINVOKE.Burrowed_get();
}


public IntPtr Unburrow_get() {
  return bridgePINVOKE.Unburrow_get();
}


public IntPtr DarkSwarm_get() {
  return bridgePINVOKE.DarkSwarm_get();
}


public IntPtr CastParasite_get() {
  return bridgePINVOKE.CastParasite_get();
}


public IntPtr SummonBroodlings_get() {
  return bridgePINVOKE.SummonBroodlings_get();
}


public IntPtr EmpShockwave_get() {
  return bridgePINVOKE.EmpShockwave_get();
}


public IntPtr NukeWait_get() {
  return bridgePINVOKE.NukeWait_get();
}


public IntPtr NukeTrain_get() {
  return bridgePINVOKE.NukeTrain_get();
}


public IntPtr NukeLaunch_get() {
  return bridgePINVOKE.NukeLaunch_get();
}


public IntPtr NukePaint_get() {
  return bridgePINVOKE.NukePaint_get();
}


public IntPtr NukeUnit_get() {
  return bridgePINVOKE.NukeUnit_get();
}


public IntPtr NukeGround_get() {
  return bridgePINVOKE.NukeGround_get();
}


public IntPtr NukeTrack_get() {
  return bridgePINVOKE.NukeTrack_get();
}


public IntPtr InitArbiter_get() {
  return bridgePINVOKE.InitArbiter_get();
}


public IntPtr CloakNearbyUnits_get() {
  return bridgePINVOKE.CloakNearbyUnits_get();
}


public IntPtr PlaceMine_get() {
  return bridgePINVOKE.PlaceMine_get();
}


public IntPtr Rightclickaction_get() {
  return bridgePINVOKE.Rightclickaction_get();
}


public IntPtr SapUnit_get() {
  return bridgePINVOKE.SapUnit_get();
}


public IntPtr SapLocation_get() {
  return bridgePINVOKE.SapLocation_get();
}


public IntPtr HoldPosition4_get() {
  return bridgePINVOKE.HoldPosition4_get();
}


public IntPtr Teleport_get() {
  return bridgePINVOKE.Teleport_get();
}


public IntPtr TeleporttoLocation_get() {
  return bridgePINVOKE.TeleporttoLocation_get();
}


public IntPtr PlaceScanner_get() {
  return bridgePINVOKE.PlaceScanner_get();
}


public IntPtr Scanner_get() {
  return bridgePINVOKE.Scanner_get();
}


public IntPtr DefensiveMatrix_get() {
  return bridgePINVOKE.DefensiveMatrix_get();
}


public IntPtr PsiStorm_get() {
  return bridgePINVOKE.PsiStorm_get();
}


public IntPtr OrderIrradiate_get() {
  return bridgePINVOKE.OrderIrradiate_get();
}


public IntPtr OrderPlague_get() {
  return bridgePINVOKE.OrderPlague_get();
}


public IntPtr OrderConsume_get() {
  return bridgePINVOKE.OrderConsume_get();
}


public IntPtr OrderEnsnare_get() {
  return bridgePINVOKE.OrderEnsnare_get();
}


public IntPtr StasisField_get() {
  return bridgePINVOKE.StasisField_get();
}


public IntPtr Hallucination1_get() {
  return bridgePINVOKE.Hallucination1_get();
}


public IntPtr Hallucination2_get() {
  return bridgePINVOKE.Hallucination2_get();
}


public IntPtr ResetCollision1_get() {
  return bridgePINVOKE.ResetCollision1_get();
}


public IntPtr ResetCollision2_get() {
  return bridgePINVOKE.ResetCollision2_get();
}


public IntPtr Patrol_get() {
  return bridgePINVOKE.Patrol_get();
}


public IntPtr CTFCOPInit_get() {
  return bridgePINVOKE.CTFCOPInit_get();
}


public IntPtr CTFCOP1_get() {
  return bridgePINVOKE.CTFCOP1_get();
}


public IntPtr CTFCOP2_get() {
  return bridgePINVOKE.CTFCOP2_get();
}


public IntPtr ComputerAI_get() {
  return bridgePINVOKE.ComputerAI_get();
}


public IntPtr AtkMoveEP_get() {
  return bridgePINVOKE.AtkMoveEP_get();
}


public IntPtr HarassMove_get() {
  return bridgePINVOKE.HarassMove_get();
}


public IntPtr AIPatrol_get() {
  return bridgePINVOKE.AIPatrol_get();
}


public IntPtr GuardPost_get() {
  return bridgePINVOKE.GuardPost_get();
}


public IntPtr RescuePassive_get() {
  return bridgePINVOKE.RescuePassive_get();
}


public IntPtr OrderNeutral_get() {
  return bridgePINVOKE.OrderNeutral_get();
}


public IntPtr ComputerReturn_get() {
  return bridgePINVOKE.ComputerReturn_get();
}


public IntPtr InitPsiProvider_get() {
  return bridgePINVOKE.InitPsiProvider_get();
}


public IntPtr SelfDestrucing_get() {
  return bridgePINVOKE.SelfDestrucing_get();
}


public IntPtr Critter_get() {
  return bridgePINVOKE.Critter_get();
}


public IntPtr HiddenGun_get() {
  return bridgePINVOKE.HiddenGun_get();
}


public IntPtr OpenDoor_get() {
  return bridgePINVOKE.OpenDoor_get();
}


public IntPtr CloseDoor_get() {
  return bridgePINVOKE.CloseDoor_get();
}


public IntPtr HideTrap_get() {
  return bridgePINVOKE.HideTrap_get();
}


public IntPtr RevealTrap_get() {
  return bridgePINVOKE.RevealTrap_get();
}


public IntPtr Enabledoodad_get() {
  return bridgePINVOKE.Enabledoodad_get();
}


public IntPtr Disabledoodad_get() {
  return bridgePINVOKE.Disabledoodad_get();
}


public IntPtr Warpin_get() {
  return bridgePINVOKE.Warpin_get();
}


public IntPtr Medic_get() {
  return bridgePINVOKE.Medic_get();
}


public IntPtr MedicHeal1_get() {
  return bridgePINVOKE.MedicHeal1_get();
}


public IntPtr HealMove_get() {
  return bridgePINVOKE.HealMove_get();
}


public IntPtr MedicHoldPosition_get() {
  return bridgePINVOKE.MedicHoldPosition_get();
}


public IntPtr MedicHeal2_get() {
  return bridgePINVOKE.MedicHeal2_get();
}


public IntPtr OrderRestoration_get() {
  return bridgePINVOKE.OrderRestoration_get();
}


public IntPtr CastDisruptionWeb_get() {
  return bridgePINVOKE.CastDisruptionWeb_get();
}


public IntPtr CastMindControl_get() {
  return bridgePINVOKE.CastMindControl_get();
}


public IntPtr WarpingDarkArchon_get() {
  return bridgePINVOKE.WarpingDarkArchon_get();
}


public IntPtr CastFeedback_get() {
  return bridgePINVOKE.CastFeedback_get();
}


public IntPtr CastOpticalFlare_get() {
  return bridgePINVOKE.CastOpticalFlare_get();
}


public IntPtr CastMaelstrom_get() {
  return bridgePINVOKE.CastMaelstrom_get();
}


public IntPtr JunkYardDog_get() {
  return bridgePINVOKE.JunkYardDog_get();
}


public IntPtr Fatal_get() {
  return bridgePINVOKE.Fatal_get();
}


public IntPtr OrderNone_get() {
  return bridgePINVOKE.OrderNone_get();
}


public IntPtr OrderUnknown_get() {
  return bridgePINVOKE.OrderUnknown_get();
}


public IntPtr new_PlayerType__SWIG_0() {
  return bridgePINVOKE.new_PlayerType__SWIG_0();
}


public IntPtr new_PlayerType__SWIG_1(int jarg1) {
  return bridgePINVOKE.new_PlayerType__SWIG_1(jarg1);
}


public IntPtr new_PlayerType__SWIG_2(HandleRef jarg1) {
  return bridgePINVOKE.new_PlayerType__SWIG_2(jarg1);
}


public IntPtr PlayerType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.PlayerType_opAssign(jarg1, jarg2);
}


public bool PlayerType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.PlayerType_opEquals(jarg1, jarg2);
}


public bool PlayerType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.PlayerType_opNotEquals(jarg1, jarg2);
}


public bool PlayerType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.PlayerType_opLessThan(jarg1, jarg2);
}


public int PlayerType_getID(HandleRef jarg1) {
  return bridgePINVOKE.PlayerType_getID(jarg1);
}


public string PlayerType_getName(HandleRef jarg1) {
  return bridgePINVOKE.PlayerType_getName(jarg1);
}


public void delete_PlayerType(HandleRef jarg1) {
  bridgePINVOKE.delete_PlayerType(jarg1);
}


public IntPtr getPlayerType(string jarg1) {
  return bridgePINVOKE.getPlayerType(jarg1);
}


public IntPtr allPlayerTypes() {
  return bridgePINVOKE.allPlayerTypes();
}


public void initPlayerTypes() {
  bridgePINVOKE.initPlayerTypes();
}


public IntPtr NotUsed_get() {
  return bridgePINVOKE.NotUsed_get();
}


public IntPtr Computer_get() {
  return bridgePINVOKE.Computer_get();
}


public IntPtr Human_get() {
  return bridgePINVOKE.Human_get();
}


public IntPtr Rescuable_get() {
  return bridgePINVOKE.Rescuable_get();
}


public IntPtr ComputerSlot_get() {
  return bridgePINVOKE.ComputerSlot_get();
}


public IntPtr OpenSlot_get() {
  return bridgePINVOKE.OpenSlot_get();
}


public IntPtr PlayerTypeNeutral_get() {
  return bridgePINVOKE.PlayerTypeNeutral_get();
}


public IntPtr ClosedSlot_get() {
  return bridgePINVOKE.ClosedSlot_get();
}


public IntPtr HumanDefeated_get() {
  return bridgePINVOKE.HumanDefeated_get();
}


public IntPtr ComputerDefeated_get() {
  return bridgePINVOKE.ComputerDefeated_get();
}


public IntPtr PlayerTypeNone_get() {
  return bridgePINVOKE.PlayerTypeNone_get();
}


public IntPtr PlayerTypeUnknown_get() {
  return bridgePINVOKE.PlayerTypeUnknown_get();
}


public int Player_getID(HandleRef jarg1) {
  return bridgePINVOKE.Player_getID(jarg1);
}


public string Player_getName(HandleRef jarg1) {
  return bridgePINVOKE.Player_getName(jarg1);
}


public IntPtr Player_getUnits(HandleRef jarg1) {
  return bridgePINVOKE.Player_getUnits(jarg1);
}


public IntPtr Player_getRace(HandleRef jarg1) {
  return bridgePINVOKE.Player_getRace(jarg1);
}


public IntPtr Player_playerType(HandleRef jarg1) {
  return bridgePINVOKE.Player_playerType(jarg1);
}


public IntPtr Player_getForce(HandleRef jarg1) {
  return bridgePINVOKE.Player_getForce(jarg1);
}


public bool Player_isAlly(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Player_isAlly(jarg1, jarg2);
}


public bool Player_isEnemy(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Player_isEnemy(jarg1, jarg2);
}


public bool Player_isNeutral(HandleRef jarg1) {
  return bridgePINVOKE.Player_isNeutral(jarg1);
}


public IntPtr Player_getStartLocation(HandleRef jarg1) {
  return bridgePINVOKE.Player_getStartLocation(jarg1);
}


public bool Player_isVictorious(HandleRef jarg1) {
  return bridgePINVOKE.Player_isVictorious(jarg1);
}


public bool Player_isDefeated(HandleRef jarg1) {
  return bridgePINVOKE.Player_isDefeated(jarg1);
}


public bool Player_leftGame(HandleRef jarg1) {
  return bridgePINVOKE.Player_leftGame(jarg1);
}


public int Player_minerals(HandleRef jarg1) {
  return bridgePINVOKE.Player_minerals(jarg1);
}


public int Player_gas(HandleRef jarg1) {
  return bridgePINVOKE.Player_gas(jarg1);
}


public int Player_cumulativeMinerals(HandleRef jarg1) {
  return bridgePINVOKE.Player_cumulativeMinerals(jarg1);
}


public int Player_cumulativeGas(HandleRef jarg1) {
  return bridgePINVOKE.Player_cumulativeGas(jarg1);
}


public int Player_supplyTotal__SWIG_0(HandleRef jarg1) {
  return bridgePINVOKE.Player_supplyTotal__SWIG_0(jarg1);
}


public int Player_supplyUsed__SWIG_0(HandleRef jarg1) {
  return bridgePINVOKE.Player_supplyUsed__SWIG_0(jarg1);
}


public int Player_supplyTotal__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Player_supplyTotal__SWIG_1(jarg1, jarg2);
}


public int Player_supplyUsed__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Player_supplyUsed__SWIG_1(jarg1, jarg2);
}


public int Player_allUnitCount(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Player_allUnitCount(jarg1, jarg2);
}


public int Player_completedUnitCount(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Player_completedUnitCount(jarg1, jarg2);
}


public int Player_incompleteUnitCount(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Player_incompleteUnitCount(jarg1, jarg2);
}


public int Player_deadUnitCount(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Player_deadUnitCount(jarg1, jarg2);
}


public int Player_killedUnitCount(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Player_killedUnitCount(jarg1, jarg2);
}


public int Player_getUpgradeLevel(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Player_getUpgradeLevel(jarg1, jarg2);
}


public bool Player_hasResearched(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Player_hasResearched(jarg1, jarg2);
}


public bool Player_isResearching(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Player_isResearching(jarg1, jarg2);
}


public bool Player_isUpgrading(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Player_isUpgrading(jarg1, jarg2);
}


public void delete_Player(HandleRef jarg1) {
  bridgePINVOKE.delete_Player(jarg1);
}


public IntPtr new_TilePosition__SWIG_0() {
  return bridgePINVOKE.new_TilePosition__SWIG_0();
}


public IntPtr new_TilePosition__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_TilePosition__SWIG_1(jarg1);
}


public IntPtr new_TilePosition__SWIG_2(int jarg1, int jarg2) {
  return bridgePINVOKE.new_TilePosition__SWIG_2(jarg1, jarg2);
}


public bool TilePosition_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TilePosition_opEquals(jarg1, jarg2);
}


public bool TilePosition_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TilePosition_opNotEquals(jarg1, jarg2);
}


public bool TilePosition_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TilePosition_opLessThan(jarg1, jarg2);
}


public IntPtr TilePosition_opPlus(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TilePosition_opPlus(jarg1, jarg2);
}


public IntPtr TilePosition_opMinus(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TilePosition_opMinus(jarg1, jarg2);
}


public IntPtr TilePosition_opAdd(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TilePosition_opAdd(jarg1, jarg2);
}


public IntPtr TilePosition_opSubtract(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TilePosition_opSubtract(jarg1, jarg2);
}


public double TilePosition_getDistance(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TilePosition_getDistance(jarg1, jarg2);
}


public double TilePosition_getLength(HandleRef jarg1) {
  return bridgePINVOKE.TilePosition_getLength(jarg1);
}


public bool TilePosition_isValid(HandleRef jarg1) {
  return bridgePINVOKE.TilePosition_isValid(jarg1);
}


public IntPtr TilePosition_x(HandleRef jarg1) {
  return bridgePINVOKE.TilePosition_x(jarg1);
}


public IntPtr TilePosition_y(HandleRef jarg1) {
  return bridgePINVOKE.TilePosition_y(jarg1);
}


public int TilePosition_xConst(HandleRef jarg1) {
  return bridgePINVOKE.TilePosition_xConst(jarg1);
}


public int TilePosition_yConst(HandleRef jarg1) {
  return bridgePINVOKE.TilePosition_yConst(jarg1);
}


public void delete_TilePosition(HandleRef jarg1) {
  bridgePINVOKE.delete_TilePosition(jarg1);
}


public IntPtr TilePositionInvalid_get() {
  return bridgePINVOKE.TilePositionInvalid_get();
}


public IntPtr TilePositionNone_get() {
  return bridgePINVOKE.TilePositionNone_get();
}


public IntPtr TilePositionUnknown_get() {
  return bridgePINVOKE.TilePositionUnknown_get();
}


public int Unit_getID(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getID(jarg1);
}


public IntPtr Unit_getPlayer(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getPlayer(jarg1);
}


public IntPtr Unit_getType(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getType(jarg1);
}


public IntPtr Unit_getInitialType(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getInitialType(jarg1);
}


public int Unit_getHitPoints(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getHitPoints(jarg1);
}


public int Unit_getInitialHitPoints(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getInitialHitPoints(jarg1);
}


public int Unit_getShields(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getShields(jarg1);
}


public int Unit_getEnergy(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getEnergy(jarg1);
}


public int Unit_getResources(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getResources(jarg1);
}


public int Unit_getInitialResources(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getInitialResources(jarg1);
}


public int Unit_getKillCount(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getKillCount(jarg1);
}


public int Unit_getGroundWeaponCooldown(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getGroundWeaponCooldown(jarg1);
}


public int Unit_getAirWeaponCooldown(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getAirWeaponCooldown(jarg1);
}


public int Unit_getSpellCooldown(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getSpellCooldown(jarg1);
}


public int Unit_getDefenseMatrixPoints(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getDefenseMatrixPoints(jarg1);
}


public int Unit_getDefenseMatrixTimer(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getDefenseMatrixTimer(jarg1);
}


public int Unit_getEnsnareTimer(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getEnsnareTimer(jarg1);
}


public int Unit_getIrradiateTimer(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getIrradiateTimer(jarg1);
}


public int Unit_getLockdownTimer(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getLockdownTimer(jarg1);
}


public int Unit_getMaelstromTimer(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getMaelstromTimer(jarg1);
}


public int Unit_getPlagueTimer(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getPlagueTimer(jarg1);
}


public int Unit_getRemoveTimer(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getRemoveTimer(jarg1);
}


public int Unit_getStasisTimer(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getStasisTimer(jarg1);
}


public int Unit_getStimTimer(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getStimTimer(jarg1);
}


public IntPtr Unit_getPosition(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getPosition(jarg1);
}


public IntPtr Unit_getInitialPosition(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getInitialPosition(jarg1);
}


public IntPtr Unit_getTilePosition(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getTilePosition(jarg1);
}


public IntPtr Unit_getInitialTilePosition(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getInitialTilePosition(jarg1);
}


public double Unit_getDistance__SWIG_0(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_getDistance__SWIG_0(jarg1, jarg2);
}


public double Unit_getDistance__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_getDistance__SWIG_1(jarg1, jarg2);
}


public double Unit_getAngle(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getAngle(jarg1);
}


public double Unit_getVelocityX(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getVelocityX(jarg1);
}


public double Unit_getVelocityY(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getVelocityY(jarg1);
}


public IntPtr Unit_getTarget(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getTarget(jarg1);
}


public IntPtr Unit_getTargetPosition(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getTargetPosition(jarg1);
}


public IntPtr Unit_getOrder(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getOrder(jarg1);
}


public IntPtr Unit_getOrderTarget(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getOrderTarget(jarg1);
}


public int Unit_getOrderTimer(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getOrderTimer(jarg1);
}


public IntPtr Unit_getSecondaryOrder(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getSecondaryOrder(jarg1);
}


public IntPtr Unit_getBuildUnit(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getBuildUnit(jarg1);
}


public IntPtr Unit_getBuildType(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getBuildType(jarg1);
}


public int Unit_getRemainingBuildTime(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getRemainingBuildTime(jarg1);
}


public int Unit_getRemainingTrainTime(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getRemainingTrainTime(jarg1);
}


public IntPtr Unit_getChild(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getChild(jarg1);
}


public IntPtr Unit_getTrainingQueue(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getTrainingQueue(jarg1);
}


public IntPtr Unit_getTransport(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getTransport(jarg1);
}


public IntPtr Unit_getLoadedUnits(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getLoadedUnits(jarg1);
}


public int Unit_getInterceptorCount(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getInterceptorCount(jarg1);
}


public int Unit_getScarabCount(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getScarabCount(jarg1);
}


public int Unit_getSpiderMineCount(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getSpiderMineCount(jarg1);
}


public IntPtr Unit_getTech(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getTech(jarg1);
}


public IntPtr Unit_getUpgrade(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getUpgrade(jarg1);
}


public int Unit_getRemainingResearchTime(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getRemainingResearchTime(jarg1);
}


public int Unit_getRemainingUpgradeTime(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getRemainingUpgradeTime(jarg1);
}


public IntPtr Unit_getRallyPosition(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getRallyPosition(jarg1);
}


public IntPtr Unit_getRallyUnit(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getRallyUnit(jarg1);
}


public IntPtr Unit_getAddon(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getAddon(jarg1);
}


public IntPtr Unit_getHatchery(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getHatchery(jarg1);
}


public IntPtr Unit_getLarva(HandleRef jarg1) {
  return bridgePINVOKE.Unit_getLarva(jarg1);
}


public int Unit_getUpgradeLevel(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_getUpgradeLevel(jarg1, jarg2);
}


public bool Unit_exists(HandleRef jarg1) {
  return bridgePINVOKE.Unit_exists(jarg1);
}


public bool Unit_isAccelerating(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isAccelerating(jarg1);
}


public bool Unit_isBeingConstructed(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isBeingConstructed(jarg1);
}


public bool Unit_isBeingHealed(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isBeingHealed(jarg1);
}


public bool Unit_isBlind(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isBlind(jarg1);
}


public bool Unit_isBraking(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isBraking(jarg1);
}


public bool Unit_isBurrowed(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isBurrowed(jarg1);
}


public bool Unit_isCarryingGas(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isCarryingGas(jarg1);
}


public bool Unit_isCarryingMinerals(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isCarryingMinerals(jarg1);
}


public bool Unit_isCloaked(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isCloaked(jarg1);
}


public bool Unit_isCompleted(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isCompleted(jarg1);
}


public bool Unit_isConstructing(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isConstructing(jarg1);
}


public bool Unit_isDefenseMatrixed(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isDefenseMatrixed(jarg1);
}


public bool Unit_isEnsnared(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isEnsnared(jarg1);
}


public bool Unit_isFollowing(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isFollowing(jarg1);
}


public bool Unit_isGatheringGas(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isGatheringGas(jarg1);
}


public bool Unit_isGatheringMinerals(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isGatheringMinerals(jarg1);
}


public bool Unit_isHallucination(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isHallucination(jarg1);
}


public bool Unit_isIdle(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isIdle(jarg1);
}


public bool Unit_isIrradiated(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isIrradiated(jarg1);
}


public bool Unit_isLifted(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isLifted(jarg1);
}


public bool Unit_isLoaded(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isLoaded(jarg1);
}


public bool Unit_isLockedDown(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isLockedDown(jarg1);
}


public bool Unit_isMaelstrommed(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isMaelstrommed(jarg1);
}


public bool Unit_isMorphing(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isMorphing(jarg1);
}


public bool Unit_isMoving(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isMoving(jarg1);
}


public bool Unit_isParasited(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isParasited(jarg1);
}


public bool Unit_isPatrolling(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isPatrolling(jarg1);
}


public bool Unit_isPlagued(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isPlagued(jarg1);
}


public bool Unit_isRepairing(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isRepairing(jarg1);
}


public bool Unit_isResearching(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isResearching(jarg1);
}


public bool Unit_isSelected(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isSelected(jarg1);
}


public bool Unit_isSieged(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isSieged(jarg1);
}


public bool Unit_isStartingAttack(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isStartingAttack(jarg1);
}


public bool Unit_isStasised(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isStasised(jarg1);
}


public bool Unit_isStimmed(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isStimmed(jarg1);
}


public bool Unit_isTraining(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isTraining(jarg1);
}


public bool Unit_isUnderStorm(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isUnderStorm(jarg1);
}


public bool Unit_isUnpowered(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isUnpowered(jarg1);
}


public bool Unit_isUpgrading(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isUpgrading(jarg1);
}


public bool Unit_isVisible(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isVisible(jarg1);
}


public bool Unit_isBeingGathered(HandleRef jarg1) {
  return bridgePINVOKE.Unit_isBeingGathered(jarg1);
}


public bool Unit_attackMove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_attackMove(jarg1, jarg2);
}


public bool Unit_attackUnit(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_attackUnit(jarg1, jarg2);
}


public bool Unit_rightClick__SWIG_0(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_rightClick__SWIG_0(jarg1, jarg2);
}


public bool Unit_rightClick__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_rightClick__SWIG_1(jarg1, jarg2);
}


public bool Unit_train(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_train(jarg1, jarg2);
}


public bool Unit_build(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3) {
  return bridgePINVOKE.Unit_build(jarg1, jarg2, jarg3);
}


public bool Unit_buildAddon(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_buildAddon(jarg1, jarg2);
}


public bool Unit_research(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_research(jarg1, jarg2);
}


public bool Unit_upgrade(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_upgrade(jarg1, jarg2);
}


public bool Unit_stop(HandleRef jarg1) {
  return bridgePINVOKE.Unit_stop(jarg1);
}


public bool Unit_holdPosition(HandleRef jarg1) {
  return bridgePINVOKE.Unit_holdPosition(jarg1);
}


public bool Unit_patrol(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_patrol(jarg1, jarg2);
}


public bool Unit_follow(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_follow(jarg1, jarg2);
}


public bool Unit_setRallyPosition(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_setRallyPosition(jarg1, jarg2);
}


public bool Unit_setRallyUnit(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_setRallyUnit(jarg1, jarg2);
}


public bool Unit_repair(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_repair(jarg1, jarg2);
}


public bool Unit_returnCargo(HandleRef jarg1) {
  return bridgePINVOKE.Unit_returnCargo(jarg1);
}


public bool Unit_morph(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_morph(jarg1, jarg2);
}


public bool Unit_burrow(HandleRef jarg1) {
  return bridgePINVOKE.Unit_burrow(jarg1);
}


public bool Unit_unburrow(HandleRef jarg1) {
  return bridgePINVOKE.Unit_unburrow(jarg1);
}


public bool Unit_siege(HandleRef jarg1) {
  return bridgePINVOKE.Unit_siege(jarg1);
}


public bool Unit_unsiege(HandleRef jarg1) {
  return bridgePINVOKE.Unit_unsiege(jarg1);
}


public bool Unit_cloak(HandleRef jarg1) {
  return bridgePINVOKE.Unit_cloak(jarg1);
}


public bool Unit_decloak(HandleRef jarg1) {
  return bridgePINVOKE.Unit_decloak(jarg1);
}


public bool Unit_lift(HandleRef jarg1) {
  return bridgePINVOKE.Unit_lift(jarg1);
}


public bool Unit_land(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_land(jarg1, jarg2);
}


public bool Unit_load(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_load(jarg1, jarg2);
}


public bool Unit_unload(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_unload(jarg1, jarg2);
}


public bool Unit_unloadAll__SWIG_0(HandleRef jarg1) {
  return bridgePINVOKE.Unit_unloadAll__SWIG_0(jarg1);
}


public bool Unit_unloadAll__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_unloadAll__SWIG_1(jarg1, jarg2);
}


public bool Unit_cancelConstruction(HandleRef jarg1) {
  return bridgePINVOKE.Unit_cancelConstruction(jarg1);
}


public bool Unit_haltConstruction(HandleRef jarg1) {
  return bridgePINVOKE.Unit_haltConstruction(jarg1);
}


public bool Unit_cancelMorph(HandleRef jarg1) {
  return bridgePINVOKE.Unit_cancelMorph(jarg1);
}


public bool Unit_cancelTrain__SWIG_0(HandleRef jarg1) {
  return bridgePINVOKE.Unit_cancelTrain__SWIG_0(jarg1);
}


public bool Unit_cancelTrain__SWIG_1(HandleRef jarg1, int jarg2) {
  return bridgePINVOKE.Unit_cancelTrain__SWIG_1(jarg1, jarg2);
}


public bool Unit_cancelAddon(HandleRef jarg1) {
  return bridgePINVOKE.Unit_cancelAddon(jarg1);
}


public bool Unit_cancelResearch(HandleRef jarg1) {
  return bridgePINVOKE.Unit_cancelResearch(jarg1);
}


public bool Unit_cancelUpgrade(HandleRef jarg1) {
  return bridgePINVOKE.Unit_cancelUpgrade(jarg1);
}


public bool Unit_useTech__SWIG_0(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Unit_useTech__SWIG_0(jarg1, jarg2);
}


public bool Unit_useTech__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3) {
  return bridgePINVOKE.Unit_useTech__SWIG_1(jarg1, jarg2, jarg3);
}


public bool Unit_useTech__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3) {
  return bridgePINVOKE.Unit_useTech__SWIG_2(jarg1, jarg2, jarg3);
}


public void delete_Unit(HandleRef jarg1) {
  bridgePINVOKE.delete_Unit(jarg1);
}


public IntPtr new_UnitSizeType__SWIG_0() {
  return bridgePINVOKE.new_UnitSizeType__SWIG_0();
}


public IntPtr new_UnitSizeType__SWIG_1(int jarg1) {
  return bridgePINVOKE.new_UnitSizeType__SWIG_1(jarg1);
}


public IntPtr new_UnitSizeType__SWIG_2(HandleRef jarg1) {
  return bridgePINVOKE.new_UnitSizeType__SWIG_2(jarg1);
}


public IntPtr UnitSizeType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitSizeType_opAssign(jarg1, jarg2);
}


public bool UnitSizeType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitSizeType_opEquals(jarg1, jarg2);
}


public bool UnitSizeType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitSizeType_opNotEquals(jarg1, jarg2);
}


public bool UnitSizeType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitSizeType_opLessThan(jarg1, jarg2);
}


public int UnitSizeType_getID(HandleRef jarg1) {
  return bridgePINVOKE.UnitSizeType_getID(jarg1);
}


public string UnitSizeType_getName(HandleRef jarg1) {
  return bridgePINVOKE.UnitSizeType_getName(jarg1);
}


public void delete_UnitSizeType(HandleRef jarg1) {
  bridgePINVOKE.delete_UnitSizeType(jarg1);
}


public IntPtr getUnitSizeType(string jarg1) {
  return bridgePINVOKE.getUnitSizeType(jarg1);
}


public IntPtr allUnitSizeTypes() {
  return bridgePINVOKE.allUnitSizeTypes();
}


public void initUnitSizeTypes() {
  bridgePINVOKE.initUnitSizeTypes();
}


public IntPtr UnitSizeTypeIndependent_get() {
  return bridgePINVOKE.UnitSizeTypeIndependent_get();
}


public IntPtr Small_get() {
  return bridgePINVOKE.Small_get();
}


public IntPtr Medium_get() {
  return bridgePINVOKE.Medium_get();
}


public IntPtr Large_get() {
  return bridgePINVOKE.Large_get();
}


public IntPtr UnitSizeTypeNone_get() {
  return bridgePINVOKE.UnitSizeTypeNone_get();
}


public IntPtr UnitSizeTypeUnknown_get() {
  return bridgePINVOKE.UnitSizeTypeUnknown_get();
}


public IntPtr new_UnitType__SWIG_0() {
  return bridgePINVOKE.new_UnitType__SWIG_0();
}


public IntPtr new_UnitType__SWIG_1(int jarg1) {
  return bridgePINVOKE.new_UnitType__SWIG_1(jarg1);
}


public IntPtr new_UnitType__SWIG_2(HandleRef jarg1) {
  return bridgePINVOKE.new_UnitType__SWIG_2(jarg1);
}


public IntPtr UnitType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitType_opAssign(jarg1, jarg2);
}


public bool UnitType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitType_opEquals(jarg1, jarg2);
}


public bool UnitType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitType_opNotEquals(jarg1, jarg2);
}


public bool UnitType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitType_opLessThan(jarg1, jarg2);
}


public int UnitType_getID(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_getID(jarg1);
}


public string UnitType_getName(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_getName(jarg1);
}


public string UnitType_getSubLabel(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_getSubLabel(jarg1);
}


public IntPtr UnitType_getRace(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_getRace(jarg1);
}


public IntPtr UnitType_whatBuilds(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_whatBuilds(jarg1);
}


public IntPtr UnitType_requiredUnits(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_requiredUnits(jarg1);
}


public IntPtr UnitType_requiredTech(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_requiredTech(jarg1);
}


public IntPtr UnitType_abilities(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_abilities(jarg1);
}


public IntPtr UnitType_upgrades(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_upgrades(jarg1);
}


public IntPtr UnitType_armorUpgrade(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_armorUpgrade(jarg1);
}


public int UnitType_maxHitPoints(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_maxHitPoints(jarg1);
}


public int UnitType_maxShields(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_maxShields(jarg1);
}


public int UnitType_maxEnergy(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_maxEnergy(jarg1);
}


public int UnitType_armor(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_armor(jarg1);
}


public int UnitType_mineralPrice(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_mineralPrice(jarg1);
}


public int UnitType_gasPrice(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_gasPrice(jarg1);
}


public int UnitType_buildTime(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_buildTime(jarg1);
}


public int UnitType_supplyRequired(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_supplyRequired(jarg1);
}


public int UnitType_supplyProvided(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_supplyProvided(jarg1);
}


public int UnitType_spaceRequired(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_spaceRequired(jarg1);
}


public int UnitType_spaceProvided(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_spaceProvided(jarg1);
}


public int UnitType_buildScore(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_buildScore(jarg1);
}


public int UnitType_destroyScore(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_destroyScore(jarg1);
}


public IntPtr UnitType_size(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_size(jarg1);
}


public int UnitType_tileWidth(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_tileWidth(jarg1);
}


public int UnitType_tileHeight(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_tileHeight(jarg1);
}


public int UnitType_dimensionLeft(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_dimensionLeft(jarg1);
}


public int UnitType_dimensionUp(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_dimensionUp(jarg1);
}


public int UnitType_dimensionRight(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_dimensionRight(jarg1);
}


public int UnitType_dimensionDown(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_dimensionDown(jarg1);
}


public int UnitType_seekRange(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_seekRange(jarg1);
}


public int UnitType_sightRange(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_sightRange(jarg1);
}


public IntPtr UnitType_groundWeapon(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_groundWeapon(jarg1);
}


public int UnitType_maxGroundHits(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_maxGroundHits(jarg1);
}


public IntPtr UnitType_airWeapon(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_airWeapon(jarg1);
}


public int UnitType_maxAirHits(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_maxAirHits(jarg1);
}


public double UnitType_topSpeed(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_topSpeed(jarg1);
}


public int UnitType_acceleration(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_acceleration(jarg1);
}


public int UnitType_haltDistance(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_haltDistance(jarg1);
}


public int UnitType_turnRadius(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_turnRadius(jarg1);
}


public bool UnitType_canProduce(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_canProduce(jarg1);
}


public bool UnitType_canAttack(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_canAttack(jarg1);
}


public bool UnitType_canMove(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_canMove(jarg1);
}


public bool UnitType_isFlyer(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isFlyer(jarg1);
}


public bool UnitType_regeneratesHP(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_regeneratesHP(jarg1);
}


public bool UnitType_isSpellcaster(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isSpellcaster(jarg1);
}


public bool UnitType_hasPermanentCloak(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_hasPermanentCloak(jarg1);
}


public bool UnitType_isInvincible(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isInvincible(jarg1);
}


public bool UnitType_isOrganic(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isOrganic(jarg1);
}


public bool UnitType_isMechanical(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isMechanical(jarg1);
}


public bool UnitType_isRobotic(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isRobotic(jarg1);
}


public bool UnitType_isDetector(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isDetector(jarg1);
}


public bool UnitType_isResourceContainer(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isResourceContainer(jarg1);
}


public bool UnitType_isResourceDepot(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isResourceDepot(jarg1);
}


public bool UnitType_isRefinery(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isRefinery(jarg1);
}


public bool UnitType_isWorker(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isWorker(jarg1);
}


public bool UnitType_requiresPsi(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_requiresPsi(jarg1);
}


public bool UnitType_requiresCreep(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_requiresCreep(jarg1);
}


public bool UnitType_isTwoUnitsInOneEgg(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isTwoUnitsInOneEgg(jarg1);
}


public bool UnitType_isBurrowable(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isBurrowable(jarg1);
}


public bool UnitType_isCloakable(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isCloakable(jarg1);
}


public bool UnitType_isBuilding(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isBuilding(jarg1);
}


public bool UnitType_isAddon(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isAddon(jarg1);
}


public bool UnitType_isFlyingBuilding(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isFlyingBuilding(jarg1);
}


public bool UnitType_isNeutral(HandleRef jarg1) {
  return bridgePINVOKE.UnitType_isNeutral(jarg1);
}


public void delete_UnitType(HandleRef jarg1) {
  bridgePINVOKE.delete_UnitType(jarg1);
}


public IntPtr getUnitType(string jarg1) {
  return bridgePINVOKE.getUnitType(jarg1);
}


public IntPtr allUnitTypes() {
  return bridgePINVOKE.allUnitTypes();
}


public void initUnitTypes() {
  bridgePINVOKE.initUnitTypes();
}


public IntPtr Terran_Marine_get() {
  return bridgePINVOKE.Terran_Marine_get();
}


public IntPtr Terran_Ghost_get() {
  return bridgePINVOKE.Terran_Ghost_get();
}


public IntPtr Terran_Vulture_get() {
  return bridgePINVOKE.Terran_Vulture_get();
}


public IntPtr Terran_Goliath_get() {
  return bridgePINVOKE.Terran_Goliath_get();
}


public IntPtr Terran_Siege_Tank_Tank_Mode_get() {
  return bridgePINVOKE.Terran_Siege_Tank_Tank_Mode_get();
}


public IntPtr Terran_SCV_get() {
  return bridgePINVOKE.Terran_SCV_get();
}


public IntPtr Terran_Wraith_get() {
  return bridgePINVOKE.Terran_Wraith_get();
}


public IntPtr Terran_Science_Vessel_get() {
  return bridgePINVOKE.Terran_Science_Vessel_get();
}


public IntPtr Terran_Dropship_get() {
  return bridgePINVOKE.Terran_Dropship_get();
}


public IntPtr Terran_Battlecruiser_get() {
  return bridgePINVOKE.Terran_Battlecruiser_get();
}


public IntPtr Terran_Vulture_Spider_Mine_get() {
  return bridgePINVOKE.Terran_Vulture_Spider_Mine_get();
}


public IntPtr Terran_Nuclear_Missile_get() {
  return bridgePINVOKE.Terran_Nuclear_Missile_get();
}


public IntPtr Terran_Siege_Tank_Siege_Mode_get() {
  return bridgePINVOKE.Terran_Siege_Tank_Siege_Mode_get();
}


public IntPtr Terran_Firebat_get() {
  return bridgePINVOKE.Terran_Firebat_get();
}


public IntPtr Spell_Scanner_Sweep_get() {
  return bridgePINVOKE.Spell_Scanner_Sweep_get();
}


public IntPtr Terran_Medic_get() {
  return bridgePINVOKE.Terran_Medic_get();
}


public IntPtr Zerg_Larva_get() {
  return bridgePINVOKE.Zerg_Larva_get();
}


public IntPtr Zerg_Egg_get() {
  return bridgePINVOKE.Zerg_Egg_get();
}


public IntPtr Zerg_Zergling_get() {
  return bridgePINVOKE.Zerg_Zergling_get();
}


public IntPtr Zerg_Hydralisk_get() {
  return bridgePINVOKE.Zerg_Hydralisk_get();
}


public IntPtr Zerg_Ultralisk_get() {
  return bridgePINVOKE.Zerg_Ultralisk_get();
}


public IntPtr Zerg_Broodling_get() {
  return bridgePINVOKE.Zerg_Broodling_get();
}


public IntPtr Zerg_Drone_get() {
  return bridgePINVOKE.Zerg_Drone_get();
}


public IntPtr Zerg_Overlord_get() {
  return bridgePINVOKE.Zerg_Overlord_get();
}


public IntPtr Zerg_Mutalisk_get() {
  return bridgePINVOKE.Zerg_Mutalisk_get();
}


public IntPtr Zerg_Guardian_get() {
  return bridgePINVOKE.Zerg_Guardian_get();
}


public IntPtr Zerg_Queen_get() {
  return bridgePINVOKE.Zerg_Queen_get();
}


public IntPtr Zerg_Defiler_get() {
  return bridgePINVOKE.Zerg_Defiler_get();
}


public IntPtr Zerg_Scourge_get() {
  return bridgePINVOKE.Zerg_Scourge_get();
}


public IntPtr Zerg_Infested_Terran_get() {
  return bridgePINVOKE.Zerg_Infested_Terran_get();
}


public IntPtr Terran_Valkyrie_get() {
  return bridgePINVOKE.Terran_Valkyrie_get();
}


public IntPtr Zerg_Cocoon_get() {
  return bridgePINVOKE.Zerg_Cocoon_get();
}


public IntPtr Protoss_Corsair_get() {
  return bridgePINVOKE.Protoss_Corsair_get();
}


public IntPtr Protoss_Dark_Templar_get() {
  return bridgePINVOKE.Protoss_Dark_Templar_get();
}


public IntPtr Zerg_Devourer_get() {
  return bridgePINVOKE.Zerg_Devourer_get();
}


public IntPtr Protoss_Dark_Archon_get() {
  return bridgePINVOKE.Protoss_Dark_Archon_get();
}


public IntPtr Protoss_Probe_get() {
  return bridgePINVOKE.Protoss_Probe_get();
}


public IntPtr Protoss_Zealot_get() {
  return bridgePINVOKE.Protoss_Zealot_get();
}


public IntPtr Protoss_Dragoon_get() {
  return bridgePINVOKE.Protoss_Dragoon_get();
}


public IntPtr Protoss_High_Templar_get() {
  return bridgePINVOKE.Protoss_High_Templar_get();
}


public IntPtr Protoss_Archon_get() {
  return bridgePINVOKE.Protoss_Archon_get();
}


public IntPtr Protoss_Shuttle_get() {
  return bridgePINVOKE.Protoss_Shuttle_get();
}


public IntPtr Protoss_Scout_get() {
  return bridgePINVOKE.Protoss_Scout_get();
}


public IntPtr Protoss_Arbiter_get() {
  return bridgePINVOKE.Protoss_Arbiter_get();
}


public IntPtr Protoss_Carrier_get() {
  return bridgePINVOKE.Protoss_Carrier_get();
}


public IntPtr Protoss_Interceptor_get() {
  return bridgePINVOKE.Protoss_Interceptor_get();
}


public IntPtr Protoss_Reaver_get() {
  return bridgePINVOKE.Protoss_Reaver_get();
}


public IntPtr Protoss_Observer_get() {
  return bridgePINVOKE.Protoss_Observer_get();
}


public IntPtr Protoss_Scarab_get() {
  return bridgePINVOKE.Protoss_Scarab_get();
}


public IntPtr Critter_Rhynadon_get() {
  return bridgePINVOKE.Critter_Rhynadon_get();
}


public IntPtr Critter_Bengalaas_get() {
  return bridgePINVOKE.Critter_Bengalaas_get();
}


public IntPtr Critter_Scantid_get() {
  return bridgePINVOKE.Critter_Scantid_get();
}


public IntPtr Critter_Kakaru_get() {
  return bridgePINVOKE.Critter_Kakaru_get();
}


public IntPtr Critter_Ragnasaur_get() {
  return bridgePINVOKE.Critter_Ragnasaur_get();
}


public IntPtr Critter_Ursadon_get() {
  return bridgePINVOKE.Critter_Ursadon_get();
}


public IntPtr Zerg_Lurker_Egg_get() {
  return bridgePINVOKE.Zerg_Lurker_Egg_get();
}


public IntPtr Zerg_Lurker_get() {
  return bridgePINVOKE.Zerg_Lurker_get();
}


public IntPtr Spell_Disruption_Web_get() {
  return bridgePINVOKE.Spell_Disruption_Web_get();
}


public IntPtr Terran_Command_Center_get() {
  return bridgePINVOKE.Terran_Command_Center_get();
}


public IntPtr Terran_Comsat_Station_get() {
  return bridgePINVOKE.Terran_Comsat_Station_get();
}


public IntPtr Terran_Nuclear_Silo_get() {
  return bridgePINVOKE.Terran_Nuclear_Silo_get();
}


public IntPtr Terran_Supply_Depot_get() {
  return bridgePINVOKE.Terran_Supply_Depot_get();
}


public IntPtr Terran_Refinery_get() {
  return bridgePINVOKE.Terran_Refinery_get();
}


public IntPtr Terran_Barracks_get() {
  return bridgePINVOKE.Terran_Barracks_get();
}


public IntPtr Terran_Academy_get() {
  return bridgePINVOKE.Terran_Academy_get();
}


public IntPtr Terran_Factory_get() {
  return bridgePINVOKE.Terran_Factory_get();
}


public IntPtr Terran_Starport_get() {
  return bridgePINVOKE.Terran_Starport_get();
}


public IntPtr Terran_Control_Tower_get() {
  return bridgePINVOKE.Terran_Control_Tower_get();
}


public IntPtr Terran_Science_Facility_get() {
  return bridgePINVOKE.Terran_Science_Facility_get();
}


public IntPtr Terran_Covert_Ops_get() {
  return bridgePINVOKE.Terran_Covert_Ops_get();
}


public IntPtr Terran_Physics_Lab_get() {
  return bridgePINVOKE.Terran_Physics_Lab_get();
}


public IntPtr Terran_Machine_Shop_get() {
  return bridgePINVOKE.Terran_Machine_Shop_get();
}


public IntPtr Terran_Engineering_Bay_get() {
  return bridgePINVOKE.Terran_Engineering_Bay_get();
}


public IntPtr Terran_Armory_get() {
  return bridgePINVOKE.Terran_Armory_get();
}


public IntPtr Terran_Missile_Turret_get() {
  return bridgePINVOKE.Terran_Missile_Turret_get();
}


public IntPtr Terran_Bunker_get() {
  return bridgePINVOKE.Terran_Bunker_get();
}


public IntPtr Special_Crashed_Norad_II_get() {
  return bridgePINVOKE.Special_Crashed_Norad_II_get();
}


public IntPtr Special_Ion_Cannon_get() {
  return bridgePINVOKE.Special_Ion_Cannon_get();
}


public IntPtr Zerg_Infested_Command_Center_get() {
  return bridgePINVOKE.Zerg_Infested_Command_Center_get();
}


public IntPtr Zerg_Hatchery_get() {
  return bridgePINVOKE.Zerg_Hatchery_get();
}


public IntPtr Zerg_Lair_get() {
  return bridgePINVOKE.Zerg_Lair_get();
}


public IntPtr Zerg_Hive_get() {
  return bridgePINVOKE.Zerg_Hive_get();
}


public IntPtr Zerg_Nydus_Canal_get() {
  return bridgePINVOKE.Zerg_Nydus_Canal_get();
}


public IntPtr Zerg_Hydralisk_Den_get() {
  return bridgePINVOKE.Zerg_Hydralisk_Den_get();
}


public IntPtr Zerg_Defiler_Mound_get() {
  return bridgePINVOKE.Zerg_Defiler_Mound_get();
}


public IntPtr Zerg_Greater_Spire_get() {
  return bridgePINVOKE.Zerg_Greater_Spire_get();
}


public IntPtr Zerg_Queens_Nest_get() {
  return bridgePINVOKE.Zerg_Queens_Nest_get();
}


public IntPtr Zerg_Evolution_Chamber_get() {
  return bridgePINVOKE.Zerg_Evolution_Chamber_get();
}


public IntPtr Zerg_Ultralisk_Cavern_get() {
  return bridgePINVOKE.Zerg_Ultralisk_Cavern_get();
}


public IntPtr Zerg_Spire_get() {
  return bridgePINVOKE.Zerg_Spire_get();
}


public IntPtr Zerg_Spawning_Pool_get() {
  return bridgePINVOKE.Zerg_Spawning_Pool_get();
}


public IntPtr Zerg_Creep_Colony_get() {
  return bridgePINVOKE.Zerg_Creep_Colony_get();
}


public IntPtr Zerg_Spore_Colony_get() {
  return bridgePINVOKE.Zerg_Spore_Colony_get();
}


public IntPtr Zerg_Sunken_Colony_get() {
  return bridgePINVOKE.Zerg_Sunken_Colony_get();
}


public IntPtr Special_Overmind_With_Shell_get() {
  return bridgePINVOKE.Special_Overmind_With_Shell_get();
}


public IntPtr Special_Overmind_get() {
  return bridgePINVOKE.Special_Overmind_get();
}


public IntPtr Zerg_Extractor_get() {
  return bridgePINVOKE.Zerg_Extractor_get();
}


public IntPtr Special_Mature_Chrysalis_get() {
  return bridgePINVOKE.Special_Mature_Chrysalis_get();
}


public IntPtr Special_Cerebrate_get() {
  return bridgePINVOKE.Special_Cerebrate_get();
}


public IntPtr Special_Cerebrate_Daggoth_get() {
  return bridgePINVOKE.Special_Cerebrate_Daggoth_get();
}


public IntPtr Protoss_Nexus_get() {
  return bridgePINVOKE.Protoss_Nexus_get();
}


public IntPtr Protoss_Robotics_Facility_get() {
  return bridgePINVOKE.Protoss_Robotics_Facility_get();
}


public IntPtr Protoss_Pylon_get() {
  return bridgePINVOKE.Protoss_Pylon_get();
}


public IntPtr Protoss_Assimilator_get() {
  return bridgePINVOKE.Protoss_Assimilator_get();
}


public IntPtr Protoss_Observatory_get() {
  return bridgePINVOKE.Protoss_Observatory_get();
}


public IntPtr Protoss_Gateway_get() {
  return bridgePINVOKE.Protoss_Gateway_get();
}


public IntPtr Protoss_Photon_Cannon_get() {
  return bridgePINVOKE.Protoss_Photon_Cannon_get();
}


public IntPtr Protoss_Citadel_of_Adun_get() {
  return bridgePINVOKE.Protoss_Citadel_of_Adun_get();
}


public IntPtr Protoss_Cybernetics_Core_get() {
  return bridgePINVOKE.Protoss_Cybernetics_Core_get();
}


public IntPtr Protoss_Templar_Archives_get() {
  return bridgePINVOKE.Protoss_Templar_Archives_get();
}


public IntPtr Protoss_Forge_get() {
  return bridgePINVOKE.Protoss_Forge_get();
}


public IntPtr Protoss_Stargate_get() {
  return bridgePINVOKE.Protoss_Stargate_get();
}


public IntPtr Special_Stasis_Cell_Prison_get() {
  return bridgePINVOKE.Special_Stasis_Cell_Prison_get();
}


public IntPtr Protoss_Fleet_Beacon_get() {
  return bridgePINVOKE.Protoss_Fleet_Beacon_get();
}


public IntPtr Protoss_Arbiter_Tribunal_get() {
  return bridgePINVOKE.Protoss_Arbiter_Tribunal_get();
}


public IntPtr Protoss_Robotics_Support_Bay_get() {
  return bridgePINVOKE.Protoss_Robotics_Support_Bay_get();
}


public IntPtr Protoss_Shield_Battery_get() {
  return bridgePINVOKE.Protoss_Shield_Battery_get();
}


public IntPtr Special_Khaydarin_Crystal_Form_get() {
  return bridgePINVOKE.Special_Khaydarin_Crystal_Form_get();
}


public IntPtr Special_Protoss_Temple_get() {
  return bridgePINVOKE.Special_Protoss_Temple_get();
}


public IntPtr Special_XelNaga_Temple_get() {
  return bridgePINVOKE.Special_XelNaga_Temple_get();
}


public IntPtr Resource_Mineral_Field_get() {
  return bridgePINVOKE.Resource_Mineral_Field_get();
}


public IntPtr Resource_Vespene_Geyser_get() {
  return bridgePINVOKE.Resource_Vespene_Geyser_get();
}


public IntPtr Special_Warp_Gate_get() {
  return bridgePINVOKE.Special_Warp_Gate_get();
}


public IntPtr Special_Psi_Disrupter_get() {
  return bridgePINVOKE.Special_Psi_Disrupter_get();
}


public IntPtr Special_Power_Generator_get() {
  return bridgePINVOKE.Special_Power_Generator_get();
}


public IntPtr Special_Overmind_Cocoon_get() {
  return bridgePINVOKE.Special_Overmind_Cocoon_get();
}


public IntPtr Spell_Dark_Swarm_get() {
  return bridgePINVOKE.Spell_Dark_Swarm_get();
}


public IntPtr UnitTypeNone_get() {
  return bridgePINVOKE.UnitTypeNone_get();
}


public IntPtr UnitTypeUnknown_get() {
  return bridgePINVOKE.UnitTypeUnknown_get();
}


public IntPtr new_WeaponType__SWIG_0() {
  return bridgePINVOKE.new_WeaponType__SWIG_0();
}


public IntPtr new_WeaponType__SWIG_1(int jarg1) {
  return bridgePINVOKE.new_WeaponType__SWIG_1(jarg1);
}


public IntPtr new_WeaponType__SWIG_2(HandleRef jarg1) {
  return bridgePINVOKE.new_WeaponType__SWIG_2(jarg1);
}


public IntPtr WeaponType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.WeaponType_opAssign(jarg1, jarg2);
}


public bool WeaponType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.WeaponType_opEquals(jarg1, jarg2);
}


public bool WeaponType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.WeaponType_opNotEquals(jarg1, jarg2);
}


public bool WeaponType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.WeaponType_opLessThan(jarg1, jarg2);
}


public int WeaponType_getID(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_getID(jarg1);
}


public string WeaponType_getName(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_getName(jarg1);
}


public IntPtr WeaponType_getTech(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_getTech(jarg1);
}


public IntPtr WeaponType_whatUses(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_whatUses(jarg1);
}


public int WeaponType_damageAmount(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_damageAmount(jarg1);
}


public int WeaponType_damageBonus(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_damageBonus(jarg1);
}


public int WeaponType_damageCooldown(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_damageCooldown(jarg1);
}


public int WeaponType_damageFactor(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_damageFactor(jarg1);
}


public IntPtr WeaponType_upgradeType(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_upgradeType(jarg1);
}


public IntPtr WeaponType_damageType(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_damageType(jarg1);
}


public IntPtr WeaponType_explosionType(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_explosionType(jarg1);
}


public int WeaponType_minRange(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_minRange(jarg1);
}


public int WeaponType_maxRange(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_maxRange(jarg1);
}


public int WeaponType_innerSplashRadius(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_innerSplashRadius(jarg1);
}


public int WeaponType_medianSplashRadius(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_medianSplashRadius(jarg1);
}


public int WeaponType_outerSplashRadius(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_outerSplashRadius(jarg1);
}


public bool WeaponType_targetsAir(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_targetsAir(jarg1);
}


public bool WeaponType_targetsGround(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_targetsGround(jarg1);
}


public bool WeaponType_targetsMechanical(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_targetsMechanical(jarg1);
}


public bool WeaponType_targetsOrganic(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_targetsOrganic(jarg1);
}


public bool WeaponType_targetsNonBuilding(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_targetsNonBuilding(jarg1);
}


public bool WeaponType_targetsNonRobotic(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_targetsNonRobotic(jarg1);
}


public bool WeaponType_targetsTerrain(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_targetsTerrain(jarg1);
}


public bool WeaponType_targetsOrgOrMech(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_targetsOrgOrMech(jarg1);
}


public bool WeaponType_targetsOwn(HandleRef jarg1) {
  return bridgePINVOKE.WeaponType_targetsOwn(jarg1);
}


public void delete_WeaponType(HandleRef jarg1) {
  bridgePINVOKE.delete_WeaponType(jarg1);
}


public IntPtr getWeaponType(string jarg1) {
  return bridgePINVOKE.getWeaponType(jarg1);
}


public IntPtr allWeaponTypes() {
  return bridgePINVOKE.allWeaponTypes();
}


public IntPtr normalWeaponTypes() {
  return bridgePINVOKE.normalWeaponTypes();
}


public IntPtr specialWeaponTypes() {
  return bridgePINVOKE.specialWeaponTypes();
}


public void initWeaponTypes() {
  bridgePINVOKE.initWeaponTypes();
}


public IntPtr Gauss_Rifle_get() {
  return bridgePINVOKE.Gauss_Rifle_get();
}


public IntPtr C_10_Canister_Rifle_get() {
  return bridgePINVOKE.C_10_Canister_Rifle_get();
}


public IntPtr WeaponTypeFragmentation_Grenade_get() {
  return bridgePINVOKE.WeaponTypeFragmentation_Grenade_get();
}


public IntPtr WeaponTypeSpider_Mines_get() {
  return bridgePINVOKE.WeaponTypeSpider_Mines_get();
}


public IntPtr Twin_Autocannons_get() {
  return bridgePINVOKE.Twin_Autocannons_get();
}


public IntPtr Hellfire_Missile_Pack_get() {
  return bridgePINVOKE.Hellfire_Missile_Pack_get();
}


public IntPtr Arclite_Cannon_get() {
  return bridgePINVOKE.Arclite_Cannon_get();
}


public IntPtr Fusion_Cutter_get() {
  return bridgePINVOKE.Fusion_Cutter_get();
}


public IntPtr WeaponTypeGemini_Missiles_get() {
  return bridgePINVOKE.WeaponTypeGemini_Missiles_get();
}


public IntPtr WeaponTypeBurst_Lasers_get() {
  return bridgePINVOKE.WeaponTypeBurst_Lasers_get();
}


public IntPtr ATS_Laser_Battery_get() {
  return bridgePINVOKE.ATS_Laser_Battery_get();
}


public IntPtr ATA_Laser_Battery_get() {
  return bridgePINVOKE.ATA_Laser_Battery_get();
}


public IntPtr Flame_Thrower_get() {
  return bridgePINVOKE.Flame_Thrower_get();
}


public IntPtr Arclite_Shock_Cannon_get() {
  return bridgePINVOKE.Arclite_Shock_Cannon_get();
}


public IntPtr WeaponTypeLongbolt_Missile_get() {
  return bridgePINVOKE.WeaponTypeLongbolt_Missile_get();
}


public IntPtr Claws_get() {
  return bridgePINVOKE.Claws_get();
}


public IntPtr Needle_Spines_get() {
  return bridgePINVOKE.Needle_Spines_get();
}


public IntPtr Kaiser_Blades_get() {
  return bridgePINVOKE.Kaiser_Blades_get();
}


public IntPtr Toxic_Spores_get() {
  return bridgePINVOKE.Toxic_Spores_get();
}


public IntPtr Spines_get() {
  return bridgePINVOKE.Spines_get();
}


public IntPtr WeaponTypeAcid_Spore_get() {
  return bridgePINVOKE.WeaponTypeAcid_Spore_get();
}


public IntPtr WeaponTypeGlave_Wurm_get() {
  return bridgePINVOKE.WeaponTypeGlave_Wurm_get();
}


public IntPtr WeaponTypeSeeker_Spores_get() {
  return bridgePINVOKE.WeaponTypeSeeker_Spores_get();
}


public IntPtr Subterranean_Tentacle_get() {
  return bridgePINVOKE.Subterranean_Tentacle_get();
}


public IntPtr Suicide_Infested_Terran_get() {
  return bridgePINVOKE.Suicide_Infested_Terran_get();
}


public IntPtr Suicide_Scourge_get() {
  return bridgePINVOKE.Suicide_Scourge_get();
}


public IntPtr Particle_Beam_get() {
  return bridgePINVOKE.Particle_Beam_get();
}


public IntPtr Psi_Blades_get() {
  return bridgePINVOKE.Psi_Blades_get();
}


public IntPtr WeaponTypePhase_Disruptor_get() {
  return bridgePINVOKE.WeaponTypePhase_Disruptor_get();
}


public IntPtr Psionic_Shockwave_get() {
  return bridgePINVOKE.Psionic_Shockwave_get();
}


public IntPtr Dual_Photon_Blasters_get() {
  return bridgePINVOKE.Dual_Photon_Blasters_get();
}


public IntPtr Anti_Matter_Missiles_get() {
  return bridgePINVOKE.Anti_Matter_Missiles_get();
}


public IntPtr Phase_Disruptor_Cannon_get() {
  return bridgePINVOKE.Phase_Disruptor_Cannon_get();
}


public IntPtr WeaponTypePulse_Cannon_get() {
  return bridgePINVOKE.WeaponTypePulse_Cannon_get();
}


public IntPtr STS_Photon_Cannon_get() {
  return bridgePINVOKE.STS_Photon_Cannon_get();
}


public IntPtr STA_Photon_Cannon_get() {
  return bridgePINVOKE.STA_Photon_Cannon_get();
}


public IntPtr Scarab_get() {
  return bridgePINVOKE.Scarab_get();
}


public IntPtr WeaponTypeNeutron_Flare_get() {
  return bridgePINVOKE.WeaponTypeNeutron_Flare_get();
}


public IntPtr WeaponTypeHalo_Rockets_get() {
  return bridgePINVOKE.WeaponTypeHalo_Rockets_get();
}


public IntPtr WeaponTypeCorrosive_Acid_get() {
  return bridgePINVOKE.WeaponTypeCorrosive_Acid_get();
}


public IntPtr WeaponTypeSubterranean_Spines_get() {
  return bridgePINVOKE.WeaponTypeSubterranean_Spines_get();
}


public IntPtr Warp_Blades_get() {
  return bridgePINVOKE.Warp_Blades_get();
}


public IntPtr WeaponTypeYamato_Gun_get() {
  return bridgePINVOKE.WeaponTypeYamato_Gun_get();
}


public IntPtr WeaponTypeNuclear_Strike_get() {
  return bridgePINVOKE.WeaponTypeNuclear_Strike_get();
}


public IntPtr Lockdown_get() {
  return bridgePINVOKE.Lockdown_get();
}


public IntPtr EMP_Shockwave_get() {
  return bridgePINVOKE.EMP_Shockwave_get();
}


public IntPtr WeaponTypeIrradiate_get() {
  return bridgePINVOKE.WeaponTypeIrradiate_get();
}


public IntPtr Parasite_get() {
  return bridgePINVOKE.Parasite_get();
}


public IntPtr Spawn_Broodlings_get() {
  return bridgePINVOKE.Spawn_Broodlings_get();
}


public IntPtr WeaponTypeEnsnare_get() {
  return bridgePINVOKE.WeaponTypeEnsnare_get();
}


public IntPtr Dark_Swarm_get() {
  return bridgePINVOKE.Dark_Swarm_get();
}


public IntPtr WeaponTypePlague_get() {
  return bridgePINVOKE.WeaponTypePlague_get();
}


public IntPtr WeaponTypeConsume_get() {
  return bridgePINVOKE.WeaponTypeConsume_get();
}


public IntPtr Stasis_Field_get() {
  return bridgePINVOKE.Stasis_Field_get();
}


public IntPtr WeaponTypePsionic_Storm_get() {
  return bridgePINVOKE.WeaponTypePsionic_Storm_get();
}


public IntPtr Disruption_Web_get() {
  return bridgePINVOKE.Disruption_Web_get();
}


public IntPtr WeaponTypeRestoration_get() {
  return bridgePINVOKE.WeaponTypeRestoration_get();
}


public IntPtr WeaponTypeMind_Control_get() {
  return bridgePINVOKE.WeaponTypeMind_Control_get();
}


public IntPtr Feedback_get() {
  return bridgePINVOKE.Feedback_get();
}


public IntPtr Optical_Flare_get() {
  return bridgePINVOKE.Optical_Flare_get();
}


public IntPtr Maelstrom_get() {
  return bridgePINVOKE.Maelstrom_get();
}


public IntPtr WeaponTypeNone_get() {
  return bridgePINVOKE.WeaponTypeNone_get();
}


public IntPtr WeaponTypeUnknown_get() {
  return bridgePINVOKE.WeaponTypeUnknown_get();
}


public IntPtr monobridgeutil_getLastUnitParam() {
  return bridgePINVOKE.monobridgeutil_getLastUnitParam();
}


public IntPtr new_monobridgeutil() {
  return bridgePINVOKE.new_monobridgeutil();
}


public void delete_monobridgeutil(HandleRef jarg1) {
  bridgePINVOKE.delete_monobridgeutil(jarg1);
}


public IntPtr new_RectangleArrayDouble__SWIG_0(uint jarg1, uint jarg2, HandleRef jarg3) {
  return bridgePINVOKE.new_RectangleArrayDouble__SWIG_0(jarg1, jarg2, jarg3);
}


public IntPtr new_RectangleArrayDouble__SWIG_1(uint jarg1, uint jarg2) {
  return bridgePINVOKE.new_RectangleArrayDouble__SWIG_1(jarg1, jarg2);
}


public IntPtr new_RectangleArrayDouble__SWIG_2(uint jarg1) {
  return bridgePINVOKE.new_RectangleArrayDouble__SWIG_2(jarg1);
}


public IntPtr new_RectangleArrayDouble__SWIG_3() {
  return bridgePINVOKE.new_RectangleArrayDouble__SWIG_3();
}


public IntPtr new_RectangleArrayDouble__SWIG_4(HandleRef jarg1) {
  return bridgePINVOKE.new_RectangleArrayDouble__SWIG_4(jarg1);
}


public void delete_RectangleArrayDouble(HandleRef jarg1) {
  bridgePINVOKE.delete_RectangleArrayDouble(jarg1);
}


public uint RectangleArrayDouble_getWidth(HandleRef jarg1) {
  return bridgePINVOKE.RectangleArrayDouble_getWidth(jarg1);
}


public uint RectangleArrayDouble_getHeight(HandleRef jarg1) {
  return bridgePINVOKE.RectangleArrayDouble_getHeight(jarg1);
}


public IntPtr RectangleArrayDouble_getItem(HandleRef jarg1, uint jarg2, uint jarg3) {
  return bridgePINVOKE.RectangleArrayDouble_getItem(jarg1, jarg2, jarg3);
}


public void RectangleArrayDouble_setItem(HandleRef jarg1, uint jarg2, uint jarg3, HandleRef jarg4) {
  bridgePINVOKE.RectangleArrayDouble_setItem(jarg1, jarg2, jarg3, jarg4);
}


public void RectangleArrayDouble_resize(HandleRef jarg1, uint jarg2, uint jarg3) {
  bridgePINVOKE.RectangleArrayDouble_resize(jarg1, jarg2, jarg3);
}


public void RectangleArrayDouble_printToFile(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.RectangleArrayDouble_printToFile(jarg1, jarg2);
}


public void RectangleArrayDouble_saveToFile(HandleRef jarg1, string jarg2) {
  bridgePINVOKE.RectangleArrayDouble_saveToFile(jarg1, jarg2);
}


public void RectangleArrayDouble_setTo(HandleRef jarg1, double jarg2) {
  bridgePINVOKE.RectangleArrayDouble_setTo(jarg1, jarg2);
}


public void RectangleArrayDouble_setBorderTo(HandleRef jarg1, double jarg2) {
  bridgePINVOKE.RectangleArrayDouble_setBorderTo(jarg1, jarg2);
}


public void readMap() {
  bridgePINVOKE.readMap();
}


public void analyze() {
  bridgePINVOKE.analyze();
}


public IntPtr getRegions() {
  return bridgePINVOKE.getRegions();
}


public IntPtr getChokepoints() {
  return bridgePINVOKE.getChokepoints();
}


public IntPtr getBaseLocations() {
  return bridgePINVOKE.getBaseLocations();
}


public IntPtr getStartLocations() {
  return bridgePINVOKE.getStartLocations();
}


public IntPtr getUnwalkablePolygons() {
  return bridgePINVOKE.getUnwalkablePolygons();
}


public IntPtr getStartLocation(HandleRef jarg1) {
  return bridgePINVOKE.getStartLocation(jarg1);
}


public IntPtr getRegion__SWIG_0(int jarg1, int jarg2) {
  return bridgePINVOKE.getRegion__SWIG_0(jarg1, jarg2);
}


public IntPtr getRegion__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.getRegion__SWIG_1(jarg1);
}


public IntPtr getNearestChokepoint__SWIG_0(int jarg1, int jarg2) {
  return bridgePINVOKE.getNearestChokepoint__SWIG_0(jarg1, jarg2);
}


public IntPtr getNearestChokepoint__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.getNearestChokepoint__SWIG_1(jarg1);
}


public IntPtr getNearestBaseLocation__SWIG_0(int jarg1, int jarg2) {
  return bridgePINVOKE.getNearestBaseLocation__SWIG_0(jarg1, jarg2);
}


public IntPtr getNearestBaseLocation__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.getNearestBaseLocation__SWIG_1(jarg1);
}


public IntPtr getNearestUnwalkablePolygon__SWIG_0(int jarg1, int jarg2) {
  return bridgePINVOKE.getNearestUnwalkablePolygon__SWIG_0(jarg1, jarg2);
}


public IntPtr getNearestUnwalkablePolygon__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.getNearestUnwalkablePolygon__SWIG_1(jarg1);
}


public IntPtr getNearestUnwalkablePosition(HandleRef jarg1) {
  return bridgePINVOKE.getNearestUnwalkablePosition(jarg1);
}


public bool isConnected__SWIG_0(int jarg1, int jarg2, int jarg3, int jarg4) {
  return bridgePINVOKE.isConnected__SWIG_0(jarg1, jarg2, jarg3, jarg4);
}


public bool isConnected__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.isConnected__SWIG_1(jarg1, jarg2);
}


public double getGroundDistance(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.getGroundDistance(jarg1, jarg2);
}


public IntPtr getNearestTilePosition(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.getNearestTilePosition(jarg1, jarg2);
}


public IntPtr getGroundDistances(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.getGroundDistances(jarg1, jarg2);
}


public void getGroundDistanceMap(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.getGroundDistanceMap(jarg1, jarg2);
}


public IntPtr getShortestPath__SWIG_0(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.getShortestPath__SWIG_0(jarg1, jarg2);
}


public IntPtr getShortestPath__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.getShortestPath__SWIG_1(jarg1, jarg2);
}


public IntPtr BaseLocation_getPosition(HandleRef jarg1) {
  return bridgePINVOKE.BaseLocation_getPosition(jarg1);
}


public IntPtr BaseLocation_getTilePosition(HandleRef jarg1) {
  return bridgePINVOKE.BaseLocation_getTilePosition(jarg1);
}


public IntPtr BaseLocation_getRegion(HandleRef jarg1) {
  return bridgePINVOKE.BaseLocation_getRegion(jarg1);
}


public int BaseLocation_minerals(HandleRef jarg1) {
  return bridgePINVOKE.BaseLocation_minerals(jarg1);
}


public int BaseLocation_gas(HandleRef jarg1) {
  return bridgePINVOKE.BaseLocation_gas(jarg1);
}


public IntPtr BaseLocation_getMinerals(HandleRef jarg1) {
  return bridgePINVOKE.BaseLocation_getMinerals(jarg1);
}


public IntPtr BaseLocation_getStaticMinerals(HandleRef jarg1) {
  return bridgePINVOKE.BaseLocation_getStaticMinerals(jarg1);
}


public IntPtr BaseLocation_getGeysers(HandleRef jarg1) {
  return bridgePINVOKE.BaseLocation_getGeysers(jarg1);
}


public double BaseLocation_getGroundDistance(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.BaseLocation_getGroundDistance(jarg1, jarg2);
}


public double BaseLocation_getAirDistance(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.BaseLocation_getAirDistance(jarg1, jarg2);
}


public bool BaseLocation_isIsland(HandleRef jarg1) {
  return bridgePINVOKE.BaseLocation_isIsland(jarg1);
}


public bool BaseLocation_isMineralOnly(HandleRef jarg1) {
  return bridgePINVOKE.BaseLocation_isMineralOnly(jarg1);
}


public bool BaseLocation_isStartLocation(HandleRef jarg1) {
  return bridgePINVOKE.BaseLocation_isStartLocation(jarg1);
}


public void delete_BaseLocation(HandleRef jarg1) {
  bridgePINVOKE.delete_BaseLocation(jarg1);
}


public IntPtr Chokepoint_getRegions(HandleRef jarg1) {
  return bridgePINVOKE.Chokepoint_getRegions(jarg1);
}


public IntPtr Chokepoint_getSides(HandleRef jarg1) {
  return bridgePINVOKE.Chokepoint_getSides(jarg1);
}


public IntPtr Chokepoint_getCenter(HandleRef jarg1) {
  return bridgePINVOKE.Chokepoint_getCenter(jarg1);
}


public double Chokepoint_getWidth(HandleRef jarg1) {
  return bridgePINVOKE.Chokepoint_getWidth(jarg1);
}


public void delete_Chokepoint(HandleRef jarg1) {
  bridgePINVOKE.delete_Chokepoint(jarg1);
}


public void PositionVector_Clear(HandleRef jarg1) {
  bridgePINVOKE.PositionVector_Clear(jarg1);
}


public void PositionVector_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.PositionVector_Add(jarg1, jarg2);
}


public uint PositionVector_size(HandleRef jarg1) {
  return bridgePINVOKE.PositionVector_size(jarg1);
}


public uint PositionVector_capacity(HandleRef jarg1) {
  return bridgePINVOKE.PositionVector_capacity(jarg1);
}


public void PositionVector_reserve(HandleRef jarg1, uint jarg2) {
  bridgePINVOKE.PositionVector_reserve(jarg1, jarg2);
}


public IntPtr new_PositionVector__SWIG_0() {
  return bridgePINVOKE.new_PositionVector__SWIG_0();
}


public IntPtr new_PositionVector__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_PositionVector__SWIG_1(jarg1);
}


public IntPtr new_PositionVector__SWIG_2(int jarg1) {
  return bridgePINVOKE.new_PositionVector__SWIG_2(jarg1);
}


public IntPtr PositionVector_getitemcopy(HandleRef jarg1, int jarg2) {
  return bridgePINVOKE.PositionVector_getitemcopy(jarg1, jarg2);
}


public IntPtr PositionVector_getitem(HandleRef jarg1, int jarg2) {
  return bridgePINVOKE.PositionVector_getitem(jarg1, jarg2);
}


public void PositionVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3) {
  bridgePINVOKE.PositionVector_setitem(jarg1, jarg2, jarg3);
}


public void PositionVector_AddRange(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.PositionVector_AddRange(jarg1, jarg2);
}


public IntPtr PositionVector_GetRange(HandleRef jarg1, int jarg2, int jarg3) {
  return bridgePINVOKE.PositionVector_GetRange(jarg1, jarg2, jarg3);
}


public void PositionVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3) {
  bridgePINVOKE.PositionVector_Insert(jarg1, jarg2, jarg3);
}


public void PositionVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3) {
  bridgePINVOKE.PositionVector_InsertRange(jarg1, jarg2, jarg3);
}


public void PositionVector_RemoveAt(HandleRef jarg1, int jarg2) {
  bridgePINVOKE.PositionVector_RemoveAt(jarg1, jarg2);
}


public void PositionVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3) {
  bridgePINVOKE.PositionVector_RemoveRange(jarg1, jarg2, jarg3);
}


public IntPtr PositionVector_Repeat(HandleRef jarg1, int jarg2) {
  return bridgePINVOKE.PositionVector_Repeat(jarg1, jarg2);
}


public void PositionVector_Reverse__SWIG_0(HandleRef jarg1) {
  bridgePINVOKE.PositionVector_Reverse__SWIG_0(jarg1);
}


public void PositionVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3) {
  bridgePINVOKE.PositionVector_Reverse__SWIG_1(jarg1, jarg2, jarg3);
}


public void PositionVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3) {
  bridgePINVOKE.PositionVector_SetRange(jarg1, jarg2, jarg3);
}


public void delete_PositionVector(HandleRef jarg1) {
  bridgePINVOKE.delete_PositionVector(jarg1);
}


public IntPtr new_Polygon() {
  return bridgePINVOKE.new_Polygon();
}


public double Polygon_getArea(HandleRef jarg1) {
  return bridgePINVOKE.Polygon_getArea(jarg1);
}


public double Polygon_getPerimeter(HandleRef jarg1) {
  return bridgePINVOKE.Polygon_getPerimeter(jarg1);
}


public IntPtr Polygon_getCenter(HandleRef jarg1) {
  return bridgePINVOKE.Polygon_getCenter(jarg1);
}


public bool Polygon_isInside(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Polygon_isInside(jarg1, jarg2);
}


public IntPtr Polygon_getNearestPoint(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Polygon_getNearestPoint(jarg1, jarg2);
}


public void delete_Polygon(HandleRef jarg1) {
  bridgePINVOKE.delete_Polygon(jarg1);
}


public IntPtr Region_getPolygon(HandleRef jarg1) {
  return bridgePINVOKE.Region_getPolygon(jarg1);
}


public IntPtr Region_getCenter(HandleRef jarg1) {
  return bridgePINVOKE.Region_getCenter(jarg1);
}


public IntPtr Region_getChokepoints(HandleRef jarg1) {
  return bridgePINVOKE.Region_getChokepoints(jarg1);
}


public IntPtr Region_getBaseLocations(HandleRef jarg1) {
  return bridgePINVOKE.Region_getBaseLocations(jarg1);
}


public bool Region_isReachable(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.Region_isReachable(jarg1, jarg2);
}


public IntPtr Region_getReachableRegions(HandleRef jarg1) {
  return bridgePINVOKE.Region_getReachableRegions(jarg1);
}


public void delete_Region(HandleRef jarg1) {
  bridgePINVOKE.delete_Region(jarg1);
}


public IntPtr new_UnitSet__SWIG_0() {
  return bridgePINVOKE.new_UnitSet__SWIG_0();
}


public IntPtr new_UnitSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_UnitSet__SWIG_1(jarg1);
}


public uint UnitSet_size(HandleRef jarg1) {
  return bridgePINVOKE.UnitSet_size(jarg1);
}


public bool UnitSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.UnitSet_empty(jarg1);
}


public void UnitSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.UnitSet_Clear(jarg1);
}


public IntPtr UnitSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitSet_getitem(jarg1, jarg2);
}


public bool UnitSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitSet_ContainsKey(jarg1, jarg2);
}


public void UnitSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.UnitSet_Add(jarg1, jarg2);
}


public bool UnitSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitSet_Remove(jarg1, jarg2);
}


public IntPtr UnitSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.UnitSet_create_iterator_begin(jarg1);
}


public IntPtr UnitSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.UnitSet_get_next_key(jarg1, jarg2);
}


public void delete_UnitSet(HandleRef jarg1) {
  bridgePINVOKE.delete_UnitSet(jarg1);
}


public IntPtr new_AttackTypeSet__SWIG_0() {
  return bridgePINVOKE.new_AttackTypeSet__SWIG_0();
}


public IntPtr new_AttackTypeSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_AttackTypeSet__SWIG_1(jarg1);
}


public uint AttackTypeSet_size(HandleRef jarg1) {
  return bridgePINVOKE.AttackTypeSet_size(jarg1);
}


public bool AttackTypeSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.AttackTypeSet_empty(jarg1);
}


public void AttackTypeSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.AttackTypeSet_Clear(jarg1);
}


public IntPtr AttackTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.AttackTypeSet_getitem(jarg1, jarg2);
}


public bool AttackTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.AttackTypeSet_ContainsKey(jarg1, jarg2);
}


public void AttackTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.AttackTypeSet_Add(jarg1, jarg2);
}


public bool AttackTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.AttackTypeSet_Remove(jarg1, jarg2);
}


public IntPtr AttackTypeSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.AttackTypeSet_create_iterator_begin(jarg1);
}


public IntPtr AttackTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.AttackTypeSet_get_next_key(jarg1, jarg2);
}


public void delete_AttackTypeSet(HandleRef jarg1) {
  bridgePINVOKE.delete_AttackTypeSet(jarg1);
}


public IntPtr new_DamageTypeSet__SWIG_0() {
  return bridgePINVOKE.new_DamageTypeSet__SWIG_0();
}


public IntPtr new_DamageTypeSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_DamageTypeSet__SWIG_1(jarg1);
}


public uint DamageTypeSet_size(HandleRef jarg1) {
  return bridgePINVOKE.DamageTypeSet_size(jarg1);
}


public bool DamageTypeSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.DamageTypeSet_empty(jarg1);
}


public void DamageTypeSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.DamageTypeSet_Clear(jarg1);
}


public IntPtr DamageTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.DamageTypeSet_getitem(jarg1, jarg2);
}


public bool DamageTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.DamageTypeSet_ContainsKey(jarg1, jarg2);
}


public void DamageTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.DamageTypeSet_Add(jarg1, jarg2);
}


public bool DamageTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.DamageTypeSet_Remove(jarg1, jarg2);
}


public IntPtr DamageTypeSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.DamageTypeSet_create_iterator_begin(jarg1);
}


public IntPtr DamageTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.DamageTypeSet_get_next_key(jarg1, jarg2);
}


public void delete_DamageTypeSet(HandleRef jarg1) {
  bridgePINVOKE.delete_DamageTypeSet(jarg1);
}


public IntPtr new_ErrorSet__SWIG_0() {
  return bridgePINVOKE.new_ErrorSet__SWIG_0();
}


public IntPtr new_ErrorSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_ErrorSet__SWIG_1(jarg1);
}


public uint ErrorSet_size(HandleRef jarg1) {
  return bridgePINVOKE.ErrorSet_size(jarg1);
}


public bool ErrorSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.ErrorSet_empty(jarg1);
}


public void ErrorSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.ErrorSet_Clear(jarg1);
}


public IntPtr ErrorSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.ErrorSet_getitem(jarg1, jarg2);
}


public bool ErrorSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.ErrorSet_ContainsKey(jarg1, jarg2);
}


public void ErrorSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.ErrorSet_Add(jarg1, jarg2);
}


public bool ErrorSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.ErrorSet_Remove(jarg1, jarg2);
}


public IntPtr ErrorSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.ErrorSet_create_iterator_begin(jarg1);
}


public IntPtr ErrorSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.ErrorSet_get_next_key(jarg1, jarg2);
}


public void delete_ErrorSet(HandleRef jarg1) {
  bridgePINVOKE.delete_ErrorSet(jarg1);
}


public IntPtr new_ExplosionTypeSet__SWIG_0() {
  return bridgePINVOKE.new_ExplosionTypeSet__SWIG_0();
}


public IntPtr new_ExplosionTypeSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_ExplosionTypeSet__SWIG_1(jarg1);
}


public uint ExplosionTypeSet_size(HandleRef jarg1) {
  return bridgePINVOKE.ExplosionTypeSet_size(jarg1);
}


public bool ExplosionTypeSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.ExplosionTypeSet_empty(jarg1);
}


public void ExplosionTypeSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.ExplosionTypeSet_Clear(jarg1);
}


public IntPtr ExplosionTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.ExplosionTypeSet_getitem(jarg1, jarg2);
}


public bool ExplosionTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.ExplosionTypeSet_ContainsKey(jarg1, jarg2);
}


public void ExplosionTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.ExplosionTypeSet_Add(jarg1, jarg2);
}


public bool ExplosionTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.ExplosionTypeSet_Remove(jarg1, jarg2);
}


public IntPtr ExplosionTypeSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.ExplosionTypeSet_create_iterator_begin(jarg1);
}


public IntPtr ExplosionTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.ExplosionTypeSet_get_next_key(jarg1, jarg2);
}


public void delete_ExplosionTypeSet(HandleRef jarg1) {
  bridgePINVOKE.delete_ExplosionTypeSet(jarg1);
}


public IntPtr new_ForcePtrSet__SWIG_0() {
  return bridgePINVOKE.new_ForcePtrSet__SWIG_0();
}


public IntPtr new_ForcePtrSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_ForcePtrSet__SWIG_1(jarg1);
}


public uint ForcePtrSet_size(HandleRef jarg1) {
  return bridgePINVOKE.ForcePtrSet_size(jarg1);
}


public bool ForcePtrSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.ForcePtrSet_empty(jarg1);
}


public void ForcePtrSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.ForcePtrSet_Clear(jarg1);
}


public IntPtr ForcePtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.ForcePtrSet_getitem(jarg1, jarg2);
}


public bool ForcePtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.ForcePtrSet_ContainsKey(jarg1, jarg2);
}


public void ForcePtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.ForcePtrSet_Add(jarg1, jarg2);
}


public bool ForcePtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.ForcePtrSet_Remove(jarg1, jarg2);
}


public IntPtr ForcePtrSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.ForcePtrSet_create_iterator_begin(jarg1);
}


public IntPtr ForcePtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.ForcePtrSet_get_next_key(jarg1, jarg2);
}


public void delete_ForcePtrSet(HandleRef jarg1) {
  bridgePINVOKE.delete_ForcePtrSet(jarg1);
}


public IntPtr new_OrderSet__SWIG_0() {
  return bridgePINVOKE.new_OrderSet__SWIG_0();
}


public IntPtr new_OrderSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_OrderSet__SWIG_1(jarg1);
}


public uint OrderSet_size(HandleRef jarg1) {
  return bridgePINVOKE.OrderSet_size(jarg1);
}


public bool OrderSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.OrderSet_empty(jarg1);
}


public void OrderSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.OrderSet_Clear(jarg1);
}


public IntPtr OrderSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.OrderSet_getitem(jarg1, jarg2);
}


public bool OrderSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.OrderSet_ContainsKey(jarg1, jarg2);
}


public void OrderSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.OrderSet_Add(jarg1, jarg2);
}


public bool OrderSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.OrderSet_Remove(jarg1, jarg2);
}


public IntPtr OrderSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.OrderSet_create_iterator_begin(jarg1);
}


public IntPtr OrderSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.OrderSet_get_next_key(jarg1, jarg2);
}


public void delete_OrderSet(HandleRef jarg1) {
  bridgePINVOKE.delete_OrderSet(jarg1);
}


public IntPtr new_PlayerPtrSet__SWIG_0() {
  return bridgePINVOKE.new_PlayerPtrSet__SWIG_0();
}


public IntPtr new_PlayerPtrSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_PlayerPtrSet__SWIG_1(jarg1);
}


public uint PlayerPtrSet_size(HandleRef jarg1) {
  return bridgePINVOKE.PlayerPtrSet_size(jarg1);
}


public bool PlayerPtrSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.PlayerPtrSet_empty(jarg1);
}


public void PlayerPtrSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.PlayerPtrSet_Clear(jarg1);
}


public IntPtr PlayerPtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.PlayerPtrSet_getitem(jarg1, jarg2);
}


public bool PlayerPtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.PlayerPtrSet_ContainsKey(jarg1, jarg2);
}


public void PlayerPtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.PlayerPtrSet_Add(jarg1, jarg2);
}


public bool PlayerPtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.PlayerPtrSet_Remove(jarg1, jarg2);
}


public IntPtr PlayerPtrSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.PlayerPtrSet_create_iterator_begin(jarg1);
}


public IntPtr PlayerPtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.PlayerPtrSet_get_next_key(jarg1, jarg2);
}


public void delete_PlayerPtrSet(HandleRef jarg1) {
  bridgePINVOKE.delete_PlayerPtrSet(jarg1);
}


public IntPtr new_PlayerTypeSet__SWIG_0() {
  return bridgePINVOKE.new_PlayerTypeSet__SWIG_0();
}


public IntPtr new_PlayerTypeSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_PlayerTypeSet__SWIG_1(jarg1);
}


public uint PlayerTypeSet_size(HandleRef jarg1) {
  return bridgePINVOKE.PlayerTypeSet_size(jarg1);
}


public bool PlayerTypeSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.PlayerTypeSet_empty(jarg1);
}


public void PlayerTypeSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.PlayerTypeSet_Clear(jarg1);
}


public IntPtr PlayerTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.PlayerTypeSet_getitem(jarg1, jarg2);
}


public bool PlayerTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.PlayerTypeSet_ContainsKey(jarg1, jarg2);
}


public void PlayerTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.PlayerTypeSet_Add(jarg1, jarg2);
}


public bool PlayerTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.PlayerTypeSet_Remove(jarg1, jarg2);
}


public IntPtr PlayerTypeSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.PlayerTypeSet_create_iterator_begin(jarg1);
}


public IntPtr PlayerTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.PlayerTypeSet_get_next_key(jarg1, jarg2);
}


public void delete_PlayerTypeSet(HandleRef jarg1) {
  bridgePINVOKE.delete_PlayerTypeSet(jarg1);
}


public IntPtr new_RaceSet__SWIG_0() {
  return bridgePINVOKE.new_RaceSet__SWIG_0();
}


public IntPtr new_RaceSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_RaceSet__SWIG_1(jarg1);
}


public uint RaceSet_size(HandleRef jarg1) {
  return bridgePINVOKE.RaceSet_size(jarg1);
}


public bool RaceSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.RaceSet_empty(jarg1);
}


public void RaceSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.RaceSet_Clear(jarg1);
}


public IntPtr RaceSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.RaceSet_getitem(jarg1, jarg2);
}


public bool RaceSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.RaceSet_ContainsKey(jarg1, jarg2);
}


public void RaceSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.RaceSet_Add(jarg1, jarg2);
}


public bool RaceSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.RaceSet_Remove(jarg1, jarg2);
}


public IntPtr RaceSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.RaceSet_create_iterator_begin(jarg1);
}


public IntPtr RaceSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.RaceSet_get_next_key(jarg1, jarg2);
}


public void delete_RaceSet(HandleRef jarg1) {
  bridgePINVOKE.delete_RaceSet(jarg1);
}


public IntPtr new_TechTypePtrSet__SWIG_0() {
  return bridgePINVOKE.new_TechTypePtrSet__SWIG_0();
}


public IntPtr new_TechTypePtrSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_TechTypePtrSet__SWIG_1(jarg1);
}


public uint TechTypePtrSet_size(HandleRef jarg1) {
  return bridgePINVOKE.TechTypePtrSet_size(jarg1);
}


public bool TechTypePtrSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.TechTypePtrSet_empty(jarg1);
}


public void TechTypePtrSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.TechTypePtrSet_Clear(jarg1);
}


public IntPtr TechTypePtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TechTypePtrSet_getitem(jarg1, jarg2);
}


public bool TechTypePtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TechTypePtrSet_ContainsKey(jarg1, jarg2);
}


public void TechTypePtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.TechTypePtrSet_Add(jarg1, jarg2);
}


public bool TechTypePtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TechTypePtrSet_Remove(jarg1, jarg2);
}


public IntPtr TechTypePtrSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.TechTypePtrSet_create_iterator_begin(jarg1);
}


public IntPtr TechTypePtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.TechTypePtrSet_get_next_key(jarg1, jarg2);
}


public void delete_TechTypePtrSet(HandleRef jarg1) {
  bridgePINVOKE.delete_TechTypePtrSet(jarg1);
}


public IntPtr new_TechTypeSet__SWIG_0() {
  return bridgePINVOKE.new_TechTypeSet__SWIG_0();
}


public IntPtr new_TechTypeSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_TechTypeSet__SWIG_1(jarg1);
}


public uint TechTypeSet_size(HandleRef jarg1) {
  return bridgePINVOKE.TechTypeSet_size(jarg1);
}


public bool TechTypeSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.TechTypeSet_empty(jarg1);
}


public void TechTypeSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.TechTypeSet_Clear(jarg1);
}


public IntPtr TechTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TechTypeSet_getitem(jarg1, jarg2);
}


public bool TechTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TechTypeSet_ContainsKey(jarg1, jarg2);
}


public void TechTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.TechTypeSet_Add(jarg1, jarg2);
}


public bool TechTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TechTypeSet_Remove(jarg1, jarg2);
}


public IntPtr TechTypeSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.TechTypeSet_create_iterator_begin(jarg1);
}


public IntPtr TechTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.TechTypeSet_get_next_key(jarg1, jarg2);
}


public void delete_TechTypeSet(HandleRef jarg1) {
  bridgePINVOKE.delete_TechTypeSet(jarg1);
}


public IntPtr new_UnitSizeTypeSet__SWIG_0() {
  return bridgePINVOKE.new_UnitSizeTypeSet__SWIG_0();
}


public IntPtr new_UnitSizeTypeSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_UnitSizeTypeSet__SWIG_1(jarg1);
}


public uint UnitSizeTypeSet_size(HandleRef jarg1) {
  return bridgePINVOKE.UnitSizeTypeSet_size(jarg1);
}


public bool UnitSizeTypeSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.UnitSizeTypeSet_empty(jarg1);
}


public void UnitSizeTypeSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.UnitSizeTypeSet_Clear(jarg1);
}


public IntPtr UnitSizeTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitSizeTypeSet_getitem(jarg1, jarg2);
}


public bool UnitSizeTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitSizeTypeSet_ContainsKey(jarg1, jarg2);
}


public void UnitSizeTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.UnitSizeTypeSet_Add(jarg1, jarg2);
}


public bool UnitSizeTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitSizeTypeSet_Remove(jarg1, jarg2);
}


public IntPtr UnitSizeTypeSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.UnitSizeTypeSet_create_iterator_begin(jarg1);
}


public IntPtr UnitSizeTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.UnitSizeTypeSet_get_next_key(jarg1, jarg2);
}


public void delete_UnitSizeTypeSet(HandleRef jarg1) {
  bridgePINVOKE.delete_UnitSizeTypeSet(jarg1);
}


public IntPtr new_UnitTypePtrSet__SWIG_0() {
  return bridgePINVOKE.new_UnitTypePtrSet__SWIG_0();
}


public IntPtr new_UnitTypePtrSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_UnitTypePtrSet__SWIG_1(jarg1);
}


public uint UnitTypePtrSet_size(HandleRef jarg1) {
  return bridgePINVOKE.UnitTypePtrSet_size(jarg1);
}


public bool UnitTypePtrSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.UnitTypePtrSet_empty(jarg1);
}


public void UnitTypePtrSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.UnitTypePtrSet_Clear(jarg1);
}


public IntPtr UnitTypePtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitTypePtrSet_getitem(jarg1, jarg2);
}


public bool UnitTypePtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitTypePtrSet_ContainsKey(jarg1, jarg2);
}


public void UnitTypePtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.UnitTypePtrSet_Add(jarg1, jarg2);
}


public bool UnitTypePtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitTypePtrSet_Remove(jarg1, jarg2);
}


public IntPtr UnitTypePtrSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.UnitTypePtrSet_create_iterator_begin(jarg1);
}


public IntPtr UnitTypePtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.UnitTypePtrSet_get_next_key(jarg1, jarg2);
}


public void delete_UnitTypePtrSet(HandleRef jarg1) {
  bridgePINVOKE.delete_UnitTypePtrSet(jarg1);
}


public IntPtr new_UnitTypeSet__SWIG_0() {
  return bridgePINVOKE.new_UnitTypeSet__SWIG_0();
}


public IntPtr new_UnitTypeSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_UnitTypeSet__SWIG_1(jarg1);
}


public uint UnitTypeSet_size(HandleRef jarg1) {
  return bridgePINVOKE.UnitTypeSet_size(jarg1);
}


public bool UnitTypeSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.UnitTypeSet_empty(jarg1);
}


public void UnitTypeSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.UnitTypeSet_Clear(jarg1);
}


public IntPtr UnitTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitTypeSet_getitem(jarg1, jarg2);
}


public bool UnitTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitTypeSet_ContainsKey(jarg1, jarg2);
}


public void UnitTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.UnitTypeSet_Add(jarg1, jarg2);
}


public bool UnitTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitTypeSet_Remove(jarg1, jarg2);
}


public IntPtr UnitTypeSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.UnitTypeSet_create_iterator_begin(jarg1);
}


public IntPtr UnitTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.UnitTypeSet_get_next_key(jarg1, jarg2);
}


public void delete_UnitTypeSet(HandleRef jarg1) {
  bridgePINVOKE.delete_UnitTypeSet(jarg1);
}


public IntPtr new_UpgradeTypePtrSet__SWIG_0() {
  return bridgePINVOKE.new_UpgradeTypePtrSet__SWIG_0();
}


public IntPtr new_UpgradeTypePtrSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_UpgradeTypePtrSet__SWIG_1(jarg1);
}


public uint UpgradeTypePtrSet_size(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeTypePtrSet_size(jarg1);
}


public bool UpgradeTypePtrSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeTypePtrSet_empty(jarg1);
}


public void UpgradeTypePtrSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.UpgradeTypePtrSet_Clear(jarg1);
}


public IntPtr UpgradeTypePtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UpgradeTypePtrSet_getitem(jarg1, jarg2);
}


public bool UpgradeTypePtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UpgradeTypePtrSet_ContainsKey(jarg1, jarg2);
}


public void UpgradeTypePtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.UpgradeTypePtrSet_Add(jarg1, jarg2);
}


public bool UpgradeTypePtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UpgradeTypePtrSet_Remove(jarg1, jarg2);
}


public IntPtr UpgradeTypePtrSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeTypePtrSet_create_iterator_begin(jarg1);
}


public IntPtr UpgradeTypePtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.UpgradeTypePtrSet_get_next_key(jarg1, jarg2);
}


public void delete_UpgradeTypePtrSet(HandleRef jarg1) {
  bridgePINVOKE.delete_UpgradeTypePtrSet(jarg1);
}


public IntPtr new_UpgradeTypeSet__SWIG_0() {
  return bridgePINVOKE.new_UpgradeTypeSet__SWIG_0();
}


public IntPtr new_UpgradeTypeSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_UpgradeTypeSet__SWIG_1(jarg1);
}


public uint UpgradeTypeSet_size(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeTypeSet_size(jarg1);
}


public bool UpgradeTypeSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeTypeSet_empty(jarg1);
}


public void UpgradeTypeSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.UpgradeTypeSet_Clear(jarg1);
}


public IntPtr UpgradeTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UpgradeTypeSet_getitem(jarg1, jarg2);
}


public bool UpgradeTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UpgradeTypeSet_ContainsKey(jarg1, jarg2);
}


public void UpgradeTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.UpgradeTypeSet_Add(jarg1, jarg2);
}


public bool UpgradeTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UpgradeTypeSet_Remove(jarg1, jarg2);
}


public IntPtr UpgradeTypeSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.UpgradeTypeSet_create_iterator_begin(jarg1);
}


public IntPtr UpgradeTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.UpgradeTypeSet_get_next_key(jarg1, jarg2);
}


public void delete_UpgradeTypeSet(HandleRef jarg1) {
  bridgePINVOKE.delete_UpgradeTypeSet(jarg1);
}


public IntPtr new_WeaponTypeSet__SWIG_0() {
  return bridgePINVOKE.new_WeaponTypeSet__SWIG_0();
}


public IntPtr new_WeaponTypeSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_WeaponTypeSet__SWIG_1(jarg1);
}


public uint WeaponTypeSet_size(HandleRef jarg1) {
  return bridgePINVOKE.WeaponTypeSet_size(jarg1);
}


public bool WeaponTypeSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.WeaponTypeSet_empty(jarg1);
}


public void WeaponTypeSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.WeaponTypeSet_Clear(jarg1);
}


public IntPtr WeaponTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.WeaponTypeSet_getitem(jarg1, jarg2);
}


public bool WeaponTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.WeaponTypeSet_ContainsKey(jarg1, jarg2);
}


public void WeaponTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.WeaponTypeSet_Add(jarg1, jarg2);
}


public bool WeaponTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.WeaponTypeSet_Remove(jarg1, jarg2);
}


public IntPtr WeaponTypeSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.WeaponTypeSet_create_iterator_begin(jarg1);
}


public IntPtr WeaponTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.WeaponTypeSet_get_next_key(jarg1, jarg2);
}


public void delete_WeaponTypeSet(HandleRef jarg1) {
  bridgePINVOKE.delete_WeaponTypeSet(jarg1);
}


public IntPtr new_PositionPair__SWIG_0() {
  return bridgePINVOKE.new_PositionPair__SWIG_0();
}


public IntPtr new_PositionPair__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.new_PositionPair__SWIG_1(jarg1, jarg2);
}


public IntPtr new_PositionPair__SWIG_2(HandleRef jarg1) {
  return bridgePINVOKE.new_PositionPair__SWIG_2(jarg1);
}


public void PositionPair_first_set(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.PositionPair_first_set(jarg1, jarg2);
}


public IntPtr PositionPair_first_get(HandleRef jarg1) {
  return bridgePINVOKE.PositionPair_first_get(jarg1);
}


public void PositionPair_second_set(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.PositionPair_second_set(jarg1, jarg2);
}


public IntPtr PositionPair_second_get(HandleRef jarg1) {
  return bridgePINVOKE.PositionPair_second_get(jarg1);
}


public void delete_PositionPair(HandleRef jarg1) {
  bridgePINVOKE.delete_PositionPair(jarg1);
}


public IntPtr new_UnitTypePtrIntPair__SWIG_0() {
  return bridgePINVOKE.new_UnitTypePtrIntPair__SWIG_0();
}


public IntPtr new_UnitTypePtrIntPair__SWIG_1(HandleRef jarg1, int jarg2) {
  return bridgePINVOKE.new_UnitTypePtrIntPair__SWIG_1(jarg1, jarg2);
}


public IntPtr new_UnitTypePtrIntPair__SWIG_2(HandleRef jarg1) {
  return bridgePINVOKE.new_UnitTypePtrIntPair__SWIG_2(jarg1);
}


public void UnitTypePtrIntPair_first_set(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.UnitTypePtrIntPair_first_set(jarg1, jarg2);
}


public IntPtr UnitTypePtrIntPair_first_get(HandleRef jarg1) {
  return bridgePINVOKE.UnitTypePtrIntPair_first_get(jarg1);
}


public void UnitTypePtrIntPair_second_set(HandleRef jarg1, int jarg2) {
  bridgePINVOKE.UnitTypePtrIntPair_second_set(jarg1, jarg2);
}


public int UnitTypePtrIntPair_second_get(HandleRef jarg1) {
  return bridgePINVOKE.UnitTypePtrIntPair_second_get(jarg1);
}


public void delete_UnitTypePtrIntPair(HandleRef jarg1) {
  bridgePINVOKE.delete_UnitTypePtrIntPair(jarg1);
}


public IntPtr new_TilePositionSet__SWIG_0() {
  return bridgePINVOKE.new_TilePositionSet__SWIG_0();
}


public IntPtr new_TilePositionSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_TilePositionSet__SWIG_1(jarg1);
}


public uint TilePositionSet_size(HandleRef jarg1) {
  return bridgePINVOKE.TilePositionSet_size(jarg1);
}


public bool TilePositionSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.TilePositionSet_empty(jarg1);
}


public void TilePositionSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.TilePositionSet_Clear(jarg1);
}


public IntPtr TilePositionSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TilePositionSet_getitem(jarg1, jarg2);
}


public bool TilePositionSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TilePositionSet_ContainsKey(jarg1, jarg2);
}


public void TilePositionSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.TilePositionSet_Add(jarg1, jarg2);
}


public bool TilePositionSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TilePositionSet_Remove(jarg1, jarg2);
}


public IntPtr TilePositionSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.TilePositionSet_create_iterator_begin(jarg1);
}


public IntPtr TilePositionSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.TilePositionSet_get_next_key(jarg1, jarg2);
}


public void delete_TilePositionSet(HandleRef jarg1) {
  bridgePINVOKE.delete_TilePositionSet(jarg1);
}


public IntPtr new_TilePositionDoubleMap__SWIG_0() {
  return bridgePINVOKE.new_TilePositionDoubleMap__SWIG_0();
}


public IntPtr new_TilePositionDoubleMap__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_TilePositionDoubleMap__SWIG_1(jarg1);
}


public uint TilePositionDoubleMap_size(HandleRef jarg1) {
  return bridgePINVOKE.TilePositionDoubleMap_size(jarg1);
}


public bool TilePositionDoubleMap_empty(HandleRef jarg1) {
  return bridgePINVOKE.TilePositionDoubleMap_empty(jarg1);
}


public void TilePositionDoubleMap_Clear(HandleRef jarg1) {
  bridgePINVOKE.TilePositionDoubleMap_Clear(jarg1);
}


public double TilePositionDoubleMap_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TilePositionDoubleMap_getitem(jarg1, jarg2);
}


public void TilePositionDoubleMap_setitem(HandleRef jarg1, HandleRef jarg2, double jarg3) {
  bridgePINVOKE.TilePositionDoubleMap_setitem(jarg1, jarg2, jarg3);
}


public bool TilePositionDoubleMap_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TilePositionDoubleMap_ContainsKey(jarg1, jarg2);
}


public void TilePositionDoubleMap_Add(HandleRef jarg1, HandleRef jarg2, double jarg3) {
  bridgePINVOKE.TilePositionDoubleMap_Add(jarg1, jarg2, jarg3);
}


public bool TilePositionDoubleMap_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.TilePositionDoubleMap_Remove(jarg1, jarg2);
}


public IntPtr TilePositionDoubleMap_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.TilePositionDoubleMap_create_iterator_begin(jarg1);
}


public IntPtr TilePositionDoubleMap_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.TilePositionDoubleMap_get_next_key(jarg1, jarg2);
}


public void delete_TilePositionDoubleMap(HandleRef jarg1) {
  bridgePINVOKE.delete_TilePositionDoubleMap(jarg1);
}


public IntPtr new_TilePositionDoublePair__SWIG_0() {
  return bridgePINVOKE.new_TilePositionDoublePair__SWIG_0();
}


public IntPtr new_TilePositionDoublePair__SWIG_1(HandleRef jarg1, double jarg2) {
  return bridgePINVOKE.new_TilePositionDoublePair__SWIG_1(jarg1, jarg2);
}


public IntPtr new_TilePositionDoublePair__SWIG_2(HandleRef jarg1) {
  return bridgePINVOKE.new_TilePositionDoublePair__SWIG_2(jarg1);
}


public void TilePositionDoublePair_first_set(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.TilePositionDoublePair_first_set(jarg1, jarg2);
}


public IntPtr TilePositionDoublePair_first_get(HandleRef jarg1) {
  return bridgePINVOKE.TilePositionDoublePair_first_get(jarg1);
}


public void TilePositionDoublePair_second_set(HandleRef jarg1, double jarg2) {
  bridgePINVOKE.TilePositionDoublePair_second_set(jarg1, jarg2);
}


public double TilePositionDoublePair_second_get(HandleRef jarg1) {
  return bridgePINVOKE.TilePositionDoublePair_second_get(jarg1);
}


public void delete_TilePositionDoublePair(HandleRef jarg1) {
  bridgePINVOKE.delete_TilePositionDoublePair(jarg1);
}


public void TilePositionVector_Clear(HandleRef jarg1) {
  bridgePINVOKE.TilePositionVector_Clear(jarg1);
}


public void TilePositionVector_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.TilePositionVector_Add(jarg1, jarg2);
}


public uint TilePositionVector_size(HandleRef jarg1) {
  return bridgePINVOKE.TilePositionVector_size(jarg1);
}


public uint TilePositionVector_capacity(HandleRef jarg1) {
  return bridgePINVOKE.TilePositionVector_capacity(jarg1);
}


public void TilePositionVector_reserve(HandleRef jarg1, uint jarg2) {
  bridgePINVOKE.TilePositionVector_reserve(jarg1, jarg2);
}


public IntPtr new_TilePositionVector__SWIG_0() {
  return bridgePINVOKE.new_TilePositionVector__SWIG_0();
}


public IntPtr new_TilePositionVector__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_TilePositionVector__SWIG_1(jarg1);
}


public IntPtr new_TilePositionVector__SWIG_2(int jarg1) {
  return bridgePINVOKE.new_TilePositionVector__SWIG_2(jarg1);
}


public IntPtr TilePositionVector_getitemcopy(HandleRef jarg1, int jarg2) {
  return bridgePINVOKE.TilePositionVector_getitemcopy(jarg1, jarg2);
}


public IntPtr TilePositionVector_getitem(HandleRef jarg1, int jarg2) {
  return bridgePINVOKE.TilePositionVector_getitem(jarg1, jarg2);
}


public void TilePositionVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3) {
  bridgePINVOKE.TilePositionVector_setitem(jarg1, jarg2, jarg3);
}


public void TilePositionVector_AddRange(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.TilePositionVector_AddRange(jarg1, jarg2);
}


public IntPtr TilePositionVector_GetRange(HandleRef jarg1, int jarg2, int jarg3) {
  return bridgePINVOKE.TilePositionVector_GetRange(jarg1, jarg2, jarg3);
}


public void TilePositionVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3) {
  bridgePINVOKE.TilePositionVector_Insert(jarg1, jarg2, jarg3);
}


public void TilePositionVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3) {
  bridgePINVOKE.TilePositionVector_InsertRange(jarg1, jarg2, jarg3);
}


public void TilePositionVector_RemoveAt(HandleRef jarg1, int jarg2) {
  bridgePINVOKE.TilePositionVector_RemoveAt(jarg1, jarg2);
}


public void TilePositionVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3) {
  bridgePINVOKE.TilePositionVector_RemoveRange(jarg1, jarg2, jarg3);
}


public IntPtr TilePositionVector_Repeat(HandleRef jarg1, int jarg2) {
  return bridgePINVOKE.TilePositionVector_Repeat(jarg1, jarg2);
}


public void TilePositionVector_Reverse__SWIG_0(HandleRef jarg1) {
  bridgePINVOKE.TilePositionVector_Reverse__SWIG_0(jarg1);
}


public void TilePositionVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3) {
  bridgePINVOKE.TilePositionVector_Reverse__SWIG_1(jarg1, jarg2, jarg3);
}


public void TilePositionVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3) {
  bridgePINVOKE.TilePositionVector_SetRange(jarg1, jarg2, jarg3);
}


public void delete_TilePositionVector(HandleRef jarg1) {
  bridgePINVOKE.delete_TilePositionVector(jarg1);
}


public IntPtr new_UnitTypePtrIntMap__SWIG_0() {
  return bridgePINVOKE.new_UnitTypePtrIntMap__SWIG_0();
}


public IntPtr new_UnitTypePtrIntMap__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_UnitTypePtrIntMap__SWIG_1(jarg1);
}


public uint UnitTypePtrIntMap_size(HandleRef jarg1) {
  return bridgePINVOKE.UnitTypePtrIntMap_size(jarg1);
}


public bool UnitTypePtrIntMap_empty(HandleRef jarg1) {
  return bridgePINVOKE.UnitTypePtrIntMap_empty(jarg1);
}


public void UnitTypePtrIntMap_Clear(HandleRef jarg1) {
  bridgePINVOKE.UnitTypePtrIntMap_Clear(jarg1);
}


public int UnitTypePtrIntMap_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitTypePtrIntMap_getitem(jarg1, jarg2);
}


public void UnitTypePtrIntMap_setitem(HandleRef jarg1, HandleRef jarg2, int jarg3) {
  bridgePINVOKE.UnitTypePtrIntMap_setitem(jarg1, jarg2, jarg3);
}


public bool UnitTypePtrIntMap_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitTypePtrIntMap_ContainsKey(jarg1, jarg2);
}


public void UnitTypePtrIntMap_Add(HandleRef jarg1, HandleRef jarg2, int jarg3) {
  bridgePINVOKE.UnitTypePtrIntMap_Add(jarg1, jarg2, jarg3);
}


public bool UnitTypePtrIntMap_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitTypePtrIntMap_Remove(jarg1, jarg2);
}


public IntPtr UnitTypePtrIntMap_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.UnitTypePtrIntMap_create_iterator_begin(jarg1);
}


public IntPtr UnitTypePtrIntMap_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.UnitTypePtrIntMap_get_next_key(jarg1, jarg2);
}


public void delete_UnitTypePtrIntMap(HandleRef jarg1) {
  bridgePINVOKE.delete_UnitTypePtrIntMap(jarg1);
}


public void UnitPtrList_Clear(HandleRef jarg1) {
  bridgePINVOKE.UnitPtrList_Clear(jarg1);
}


public void UnitPtrList_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.UnitPtrList_Add(jarg1, jarg2);
}


public uint UnitPtrList_size(HandleRef jarg1) {
  return bridgePINVOKE.UnitPtrList_size(jarg1);
}


public IntPtr new_UnitPtrList__SWIG_0() {
  return bridgePINVOKE.new_UnitPtrList__SWIG_0();
}


public IntPtr new_UnitPtrList__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_UnitPtrList__SWIG_1(jarg1);
}


public IntPtr UnitPtrList_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.UnitPtrList_create_iterator_begin(jarg1);
}


public IntPtr UnitPtrList_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.UnitPtrList_get_next_key(jarg1, jarg2);
}


public bool UnitPtrList_Contains(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitPtrList_Contains(jarg1, jarg2);
}


public bool UnitPtrList_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.UnitPtrList_Remove(jarg1, jarg2);
}


public void delete_UnitPtrList(HandleRef jarg1) {
  bridgePINVOKE.delete_UnitPtrList(jarg1);
}


public void UnitTypeList_Clear(HandleRef jarg1) {
  bridgePINVOKE.UnitTypeList_Clear(jarg1);
}


public void UnitTypeList_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.UnitTypeList_Add(jarg1, jarg2);
}


public uint UnitTypeList_size(HandleRef jarg1) {
  return bridgePINVOKE.UnitTypeList_size(jarg1);
}


public IntPtr new_UnitTypeList__SWIG_0() {
  return bridgePINVOKE.new_UnitTypeList__SWIG_0();
}


public IntPtr new_UnitTypeList__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_UnitTypeList__SWIG_1(jarg1);
}


public IntPtr UnitTypeList_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.UnitTypeList_create_iterator_begin(jarg1);
}


public IntPtr UnitTypeList_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.UnitTypeList_get_next_key(jarg1, jarg2);
}


public void delete_UnitTypeList(HandleRef jarg1) {
  bridgePINVOKE.delete_UnitTypeList(jarg1);
}


public IntPtr new_RegionPtrRegionPtrPair__SWIG_0() {
  return bridgePINVOKE.new_RegionPtrRegionPtrPair__SWIG_0();
}


public IntPtr new_RegionPtrRegionPtrPair__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.new_RegionPtrRegionPtrPair__SWIG_1(jarg1, jarg2);
}


public IntPtr new_RegionPtrRegionPtrPair__SWIG_2(HandleRef jarg1) {
  return bridgePINVOKE.new_RegionPtrRegionPtrPair__SWIG_2(jarg1);
}


public void RegionPtrRegionPtrPair_first_set(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.RegionPtrRegionPtrPair_first_set(jarg1, jarg2);
}


public IntPtr RegionPtrRegionPtrPair_first_get(HandleRef jarg1) {
  return bridgePINVOKE.RegionPtrRegionPtrPair_first_get(jarg1);
}


public void RegionPtrRegionPtrPair_second_set(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.RegionPtrRegionPtrPair_second_set(jarg1, jarg2);
}


public IntPtr RegionPtrRegionPtrPair_second_get(HandleRef jarg1) {
  return bridgePINVOKE.RegionPtrRegionPtrPair_second_get(jarg1);
}


public void delete_RegionPtrRegionPtrPair(HandleRef jarg1) {
  bridgePINVOKE.delete_RegionPtrRegionPtrPair(jarg1);
}


public IntPtr new_BaseLocationPtrSet__SWIG_0() {
  return bridgePINVOKE.new_BaseLocationPtrSet__SWIG_0();
}


public IntPtr new_BaseLocationPtrSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_BaseLocationPtrSet__SWIG_1(jarg1);
}


public uint BaseLocationPtrSet_size(HandleRef jarg1) {
  return bridgePINVOKE.BaseLocationPtrSet_size(jarg1);
}


public bool BaseLocationPtrSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.BaseLocationPtrSet_empty(jarg1);
}


public void BaseLocationPtrSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.BaseLocationPtrSet_Clear(jarg1);
}


public IntPtr BaseLocationPtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.BaseLocationPtrSet_getitem(jarg1, jarg2);
}


public bool BaseLocationPtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.BaseLocationPtrSet_ContainsKey(jarg1, jarg2);
}


public void BaseLocationPtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.BaseLocationPtrSet_Add(jarg1, jarg2);
}


public bool BaseLocationPtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.BaseLocationPtrSet_Remove(jarg1, jarg2);
}


public IntPtr BaseLocationPtrSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.BaseLocationPtrSet_create_iterator_begin(jarg1);
}


public IntPtr BaseLocationPtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.BaseLocationPtrSet_get_next_key(jarg1, jarg2);
}


public void delete_BaseLocationPtrSet(HandleRef jarg1) {
  bridgePINVOKE.delete_BaseLocationPtrSet(jarg1);
}


public IntPtr new_ChokepointPtrSet__SWIG_0() {
  return bridgePINVOKE.new_ChokepointPtrSet__SWIG_0();
}


public IntPtr new_ChokepointPtrSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_ChokepointPtrSet__SWIG_1(jarg1);
}


public uint ChokepointPtrSet_size(HandleRef jarg1) {
  return bridgePINVOKE.ChokepointPtrSet_size(jarg1);
}


public bool ChokepointPtrSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.ChokepointPtrSet_empty(jarg1);
}


public void ChokepointPtrSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.ChokepointPtrSet_Clear(jarg1);
}


public IntPtr ChokepointPtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.ChokepointPtrSet_getitem(jarg1, jarg2);
}


public bool ChokepointPtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.ChokepointPtrSet_ContainsKey(jarg1, jarg2);
}


public void ChokepointPtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.ChokepointPtrSet_Add(jarg1, jarg2);
}


public bool ChokepointPtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.ChokepointPtrSet_Remove(jarg1, jarg2);
}


public IntPtr ChokepointPtrSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.ChokepointPtrSet_create_iterator_begin(jarg1);
}


public IntPtr ChokepointPtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.ChokepointPtrSet_get_next_key(jarg1, jarg2);
}


public void delete_ChokepointPtrSet(HandleRef jarg1) {
  bridgePINVOKE.delete_ChokepointPtrSet(jarg1);
}


public IntPtr new_PolygonPtrSet__SWIG_0() {
  return bridgePINVOKE.new_PolygonPtrSet__SWIG_0();
}


public IntPtr new_PolygonPtrSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_PolygonPtrSet__SWIG_1(jarg1);
}


public uint PolygonPtrSet_size(HandleRef jarg1) {
  return bridgePINVOKE.PolygonPtrSet_size(jarg1);
}


public bool PolygonPtrSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.PolygonPtrSet_empty(jarg1);
}


public void PolygonPtrSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.PolygonPtrSet_Clear(jarg1);
}


public IntPtr PolygonPtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.PolygonPtrSet_getitem(jarg1, jarg2);
}


public bool PolygonPtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.PolygonPtrSet_ContainsKey(jarg1, jarg2);
}


public void PolygonPtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.PolygonPtrSet_Add(jarg1, jarg2);
}


public bool PolygonPtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.PolygonPtrSet_Remove(jarg1, jarg2);
}


public IntPtr PolygonPtrSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.PolygonPtrSet_create_iterator_begin(jarg1);
}


public IntPtr PolygonPtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.PolygonPtrSet_get_next_key(jarg1, jarg2);
}


public void delete_PolygonPtrSet(HandleRef jarg1) {
  bridgePINVOKE.delete_PolygonPtrSet(jarg1);
}


public IntPtr new_RegionPtrSet__SWIG_0() {
  return bridgePINVOKE.new_RegionPtrSet__SWIG_0();
}


public IntPtr new_RegionPtrSet__SWIG_1(HandleRef jarg1) {
  return bridgePINVOKE.new_RegionPtrSet__SWIG_1(jarg1);
}


public uint RegionPtrSet_size(HandleRef jarg1) {
  return bridgePINVOKE.RegionPtrSet_size(jarg1);
}


public bool RegionPtrSet_empty(HandleRef jarg1) {
  return bridgePINVOKE.RegionPtrSet_empty(jarg1);
}


public void RegionPtrSet_Clear(HandleRef jarg1) {
  bridgePINVOKE.RegionPtrSet_Clear(jarg1);
}


public IntPtr RegionPtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.RegionPtrSet_getitem(jarg1, jarg2);
}


public bool RegionPtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.RegionPtrSet_ContainsKey(jarg1, jarg2);
}


public void RegionPtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  bridgePINVOKE.RegionPtrSet_Add(jarg1, jarg2);
}


public bool RegionPtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return bridgePINVOKE.RegionPtrSet_Remove(jarg1, jarg2);
}


public IntPtr RegionPtrSet_create_iterator_begin(HandleRef jarg1) {
  return bridgePINVOKE.RegionPtrSet_create_iterator_begin(jarg1);
}


public IntPtr RegionPtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return bridgePINVOKE.RegionPtrSet_get_next_key(jarg1, jarg2);
}


public void delete_RegionPtrSet(HandleRef jarg1) {
  bridgePINVOKE.delete_RegionPtrSet(jarg1);
}


public IntPtr PolygonUpcast(IntPtr objectRef) {
  return bridgePINVOKE.PolygonUpcast(objectRef);
}

}
}