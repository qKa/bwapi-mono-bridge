
	 using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace BWAPI {

   public class bridgePINVOKEProxy {
	public static bridgePINVOKEDynamic remote;
	
	public static void connectProxy() {
		remote = new bridgePINVOKEDynamic();
	}
	
	public static bridgePINVOKEDynamic.SWIGPendingExceptionDynamic SWIGPendingException
    {
        get
        {
            return remote.SWIGPendingException;
        }
    }



public static void BWAPI_init() {
  remote.BWAPI_init();
}


public static IntPtr new_Race__SWIG_0() {
  return remote.new_Race__SWIG_0();
}


public static IntPtr new_Race__SWIG_1(int jarg1) {
  return remote.new_Race__SWIG_1(jarg1);
}


public static IntPtr new_Race__SWIG_2(HandleRef jarg1) {
  return remote.new_Race__SWIG_2(jarg1.Handle);
}


public static IntPtr Race_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return remote.Race_opAssign(jarg1.Handle, jarg2.Handle);
}


public static bool Race_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.Race_opEquals(jarg1.Handle, jarg2.Handle);
}


public static bool Race_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.Race_opNotEquals(jarg1.Handle, jarg2.Handle);
}


public static bool Race_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return remote.Race_opLessThan(jarg1.Handle, jarg2.Handle);
}


public static int Race_getID(HandleRef jarg1) {
  return remote.Race_getID(jarg1.Handle);
}


public static string Race_getName(HandleRef jarg1) {
  return remote.Race_getName(jarg1.Handle);
}


public static IntPtr Race_getWorker(HandleRef jarg1) {
  return remote.Race_getWorker(jarg1.Handle);
}


public static IntPtr Race_getCenter(HandleRef jarg1) {
  return remote.Race_getCenter(jarg1.Handle);
}


public static IntPtr Race_getRefinery(HandleRef jarg1) {
  return remote.Race_getRefinery(jarg1.Handle);
}


public static IntPtr Race_getTransport(HandleRef jarg1) {
  return remote.Race_getTransport(jarg1.Handle);
}


public static IntPtr Race_getSupplyProvider(HandleRef jarg1) {
  return remote.Race_getSupplyProvider(jarg1.Handle);
}


public static void delete_Race(HandleRef jarg1) {
  remote.delete_Race(jarg1.Handle);
}


public static IntPtr getRace(string jarg1) {
  return remote.getRace(jarg1);
}


public static IntPtr allRaces() {
  return remote.allRaces();
}


public static void initRaces() {
  remote.initRaces();
}


public static IntPtr Zerg_get() {
  return remote.Zerg_get();
}


public static IntPtr Terran_get() {
  return remote.Terran_get();
}


public static IntPtr Protoss_get() {
  return remote.Protoss_get();
}


public static IntPtr Random_get() {
  return remote.Random_get();
}


public static IntPtr Other_get() {
  return remote.Other_get();
}


public static IntPtr RaceNone_get() {
  return remote.RaceNone_get();
}


public static IntPtr RaceUnknown_get() {
  return remote.RaceUnknown_get();
}


public static IntPtr new_TechType__SWIG_0() {
  return remote.new_TechType__SWIG_0();
}


public static IntPtr new_TechType__SWIG_1(int jarg1) {
  return remote.new_TechType__SWIG_1(jarg1);
}


public static IntPtr new_TechType__SWIG_2(HandleRef jarg1) {
  return remote.new_TechType__SWIG_2(jarg1.Handle);
}


public static IntPtr TechType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return remote.TechType_opAssign(jarg1.Handle, jarg2.Handle);
}


public static bool TechType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.TechType_opEquals(jarg1.Handle, jarg2.Handle);
}


public static bool TechType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.TechType_opNotEquals(jarg1.Handle, jarg2.Handle);
}


public static bool TechType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return remote.TechType_opLessThan(jarg1.Handle, jarg2.Handle);
}


public static int TechType_getID(HandleRef jarg1) {
  return remote.TechType_getID(jarg1.Handle);
}


public static string TechType_getName(HandleRef jarg1) {
  return remote.TechType_getName(jarg1.Handle);
}


public static int TechType_mineralPrice(HandleRef jarg1) {
  return remote.TechType_mineralPrice(jarg1.Handle);
}


public static int TechType_gasPrice(HandleRef jarg1) {
  return remote.TechType_gasPrice(jarg1.Handle);
}


public static int TechType_energyUsed(HandleRef jarg1) {
  return remote.TechType_energyUsed(jarg1.Handle);
}


public static IntPtr TechType_whatResearches(HandleRef jarg1) {
  return remote.TechType_whatResearches(jarg1.Handle);
}


public static IntPtr TechType_getWeapon(HandleRef jarg1) {
  return remote.TechType_getWeapon(jarg1.Handle);
}


public static IntPtr TechType_whatUses(HandleRef jarg1) {
  return remote.TechType_whatUses(jarg1.Handle);
}


public static void delete_TechType(HandleRef jarg1) {
  remote.delete_TechType(jarg1.Handle);
}


public static IntPtr getTechType(string jarg1) {
  return remote.getTechType(jarg1);
}


public static IntPtr allTechTypes() {
  return remote.allTechTypes();
}


public static void initTechTypes() {
  remote.initTechTypes();
}


public static IntPtr Stim_Packs_get() {
  return remote.Stim_Packs_get();
}


public static IntPtr TechTypeLockdown_get() {
  return remote.TechTypeLockdown_get();
}


public static IntPtr TechTypeEMP_Shockwave_get() {
  return remote.TechTypeEMP_Shockwave_get();
}


public static IntPtr Spider_Mines_get() {
  return remote.Spider_Mines_get();
}


public static IntPtr Scanner_Sweep_get() {
  return remote.Scanner_Sweep_get();
}


public static IntPtr Tank_Siege_Mode_get() {
  return remote.Tank_Siege_Mode_get();
}


public static IntPtr Defensive_Matrix_get() {
  return remote.Defensive_Matrix_get();
}


public static IntPtr TechTypeIrradiate_get() {
  return remote.TechTypeIrradiate_get();
}


public static IntPtr TechTypeYamato_Gun_get() {
  return remote.TechTypeYamato_Gun_get();
}


public static IntPtr Cloaking_Field_get() {
  return remote.Cloaking_Field_get();
}


public static IntPtr Personnel_Cloaking_get() {
  return remote.Personnel_Cloaking_get();
}


public static IntPtr Burrowing_get() {
  return remote.Burrowing_get();
}


public static IntPtr Infestation_get() {
  return remote.Infestation_get();
}


public static IntPtr TechTypeSpawn_Broodlings_get() {
  return remote.TechTypeSpawn_Broodlings_get();
}


public static IntPtr TechTypeDark_Swarm_get() {
  return remote.TechTypeDark_Swarm_get();
}


public static IntPtr TechTypePlague_get() {
  return remote.TechTypePlague_get();
}


public static IntPtr TechTypeConsume_get() {
  return remote.TechTypeConsume_get();
}


public static IntPtr TechTypeEnsnare_get() {
  return remote.TechTypeEnsnare_get();
}


public static IntPtr TechTypeParasite_get() {
  return remote.TechTypeParasite_get();
}


public static IntPtr TechTypePsionic_Storm_get() {
  return remote.TechTypePsionic_Storm_get();
}


public static IntPtr Hallucination_get() {
  return remote.Hallucination_get();
}


public static IntPtr Recall_get() {
  return remote.Recall_get();
}


public static IntPtr TechTypeStasis_Field_get() {
  return remote.TechTypeStasis_Field_get();
}


public static IntPtr Archon_Warp_get() {
  return remote.Archon_Warp_get();
}


public static IntPtr TechTypeRestoration_get() {
  return remote.TechTypeRestoration_get();
}


public static IntPtr TechTypeDisruption_Web_get() {
  return remote.TechTypeDisruption_Web_get();
}


public static IntPtr TechTypeMind_Control_get() {
  return remote.TechTypeMind_Control_get();
}


public static IntPtr Dark_Archon_Meld_get() {
  return remote.Dark_Archon_Meld_get();
}


public static IntPtr TechTypeFeedback_get() {
  return remote.TechTypeFeedback_get();
}


public static IntPtr TechTypeOptical_Flare_get() {
  return remote.TechTypeOptical_Flare_get();
}


public static IntPtr TechTypeMaelstrom_get() {
  return remote.TechTypeMaelstrom_get();
}


public static IntPtr Lurker_Aspect_get() {
  return remote.Lurker_Aspect_get();
}


public static IntPtr Healing_get() {
  return remote.Healing_get();
}


public static IntPtr TechTypeNone_get() {
  return remote.TechTypeNone_get();
}


public static IntPtr TechTypeUnknown_get() {
  return remote.TechTypeUnknown_get();
}


public static IntPtr TechTypeNuclear_Strike_get() {
  return remote.TechTypeNuclear_Strike_get();
}


public static IntPtr new_UpgradeType__SWIG_0() {
  return remote.new_UpgradeType__SWIG_0();
}


public static IntPtr new_UpgradeType__SWIG_1(int jarg1) {
  return remote.new_UpgradeType__SWIG_1(jarg1);
}


public static IntPtr new_UpgradeType__SWIG_2(HandleRef jarg1) {
  return remote.new_UpgradeType__SWIG_2(jarg1.Handle);
}


public static IntPtr UpgradeType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return remote.UpgradeType_opAssign(jarg1.Handle, jarg2.Handle);
}


public static bool UpgradeType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.UpgradeType_opEquals(jarg1.Handle, jarg2.Handle);
}


public static bool UpgradeType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.UpgradeType_opNotEquals(jarg1.Handle, jarg2.Handle);
}


public static bool UpgradeType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return remote.UpgradeType_opLessThan(jarg1.Handle, jarg2.Handle);
}


public static int UpgradeType_getID(HandleRef jarg1) {
  return remote.UpgradeType_getID(jarg1.Handle);
}


public static string UpgradeType_getName(HandleRef jarg1) {
  return remote.UpgradeType_getName(jarg1.Handle);
}


public static IntPtr UpgradeType_getRace(HandleRef jarg1) {
  return remote.UpgradeType_getRace(jarg1.Handle);
}


public static int UpgradeType_mineralPriceBase(HandleRef jarg1) {
  return remote.UpgradeType_mineralPriceBase(jarg1.Handle);
}


public static int UpgradeType_mineralPriceFactor(HandleRef jarg1) {
  return remote.UpgradeType_mineralPriceFactor(jarg1.Handle);
}


public static int UpgradeType_gasPriceBase(HandleRef jarg1) {
  return remote.UpgradeType_gasPriceBase(jarg1.Handle);
}


public static int UpgradeType_gasPriceFactor(HandleRef jarg1) {
  return remote.UpgradeType_gasPriceFactor(jarg1.Handle);
}


public static int UpgradeType_upgradeTimeBase(HandleRef jarg1) {
  return remote.UpgradeType_upgradeTimeBase(jarg1.Handle);
}


public static int UpgradeType_upgradeTimeFactor(HandleRef jarg1) {
  return remote.UpgradeType_upgradeTimeFactor(jarg1.Handle);
}


public static int UpgradeType_maxRepeats(HandleRef jarg1) {
  return remote.UpgradeType_maxRepeats(jarg1.Handle);
}


public static IntPtr UpgradeType_whatUpgrades(HandleRef jarg1) {
  return remote.UpgradeType_whatUpgrades(jarg1.Handle);
}


public static IntPtr UpgradeType_whatUses(HandleRef jarg1) {
  return remote.UpgradeType_whatUses(jarg1.Handle);
}


public static void delete_UpgradeType(HandleRef jarg1) {
  remote.delete_UpgradeType(jarg1.Handle);
}


public static IntPtr getUpgradeType(string jarg1) {
  return remote.getUpgradeType(jarg1);
}


public static IntPtr allUpgradeTypes() {
  return remote.allUpgradeTypes();
}


public static void initUpgradeTypes() {
  remote.initUpgradeTypes();
}


public static IntPtr Terran_Infantry_Armor_get() {
  return remote.Terran_Infantry_Armor_get();
}


public static IntPtr Terran_Vehicle_Plating_get() {
  return remote.Terran_Vehicle_Plating_get();
}


public static IntPtr Terran_Ship_Plating_get() {
  return remote.Terran_Ship_Plating_get();
}


public static IntPtr Zerg_Carapace_get() {
  return remote.Zerg_Carapace_get();
}


public static IntPtr Zerg_Flyer_Carapace_get() {
  return remote.Zerg_Flyer_Carapace_get();
}


public static IntPtr Protoss_Armor_get() {
  return remote.Protoss_Armor_get();
}


public static IntPtr Protoss_Plating_get() {
  return remote.Protoss_Plating_get();
}


public static IntPtr Terran_Infantry_Weapons_get() {
  return remote.Terran_Infantry_Weapons_get();
}


public static IntPtr Terran_Vehicle_Weapons_get() {
  return remote.Terran_Vehicle_Weapons_get();
}


public static IntPtr Terran_Ship_Weapons_get() {
  return remote.Terran_Ship_Weapons_get();
}


public static IntPtr Zerg_Melee_Attacks_get() {
  return remote.Zerg_Melee_Attacks_get();
}


public static IntPtr Zerg_Missile_Attacks_get() {
  return remote.Zerg_Missile_Attacks_get();
}


public static IntPtr Zerg_Flyer_Attacks_get() {
  return remote.Zerg_Flyer_Attacks_get();
}


public static IntPtr Protoss_Ground_Weapons_get() {
  return remote.Protoss_Ground_Weapons_get();
}


public static IntPtr Protoss_Air_Weapons_get() {
  return remote.Protoss_Air_Weapons_get();
}


public static IntPtr Protoss_Plasma_Shields_get() {
  return remote.Protoss_Plasma_Shields_get();
}


public static IntPtr U_238_Shells_get() {
  return remote.U_238_Shells_get();
}


public static IntPtr Ion_Thrusters_get() {
  return remote.Ion_Thrusters_get();
}


public static IntPtr Titan_Reactor_get() {
  return remote.Titan_Reactor_get();
}


public static IntPtr Ocular_Implants_get() {
  return remote.Ocular_Implants_get();
}


public static IntPtr Moebius_Reactor_get() {
  return remote.Moebius_Reactor_get();
}


public static IntPtr Apollo_Reactor_get() {
  return remote.Apollo_Reactor_get();
}


public static IntPtr Colossus_Reactor_get() {
  return remote.Colossus_Reactor_get();
}


public static IntPtr Ventral_Sacs_get() {
  return remote.Ventral_Sacs_get();
}


public static IntPtr Antennae_get() {
  return remote.Antennae_get();
}


public static IntPtr Pneumatized_Carapace_get() {
  return remote.Pneumatized_Carapace_get();
}


public static IntPtr Metabolic_Boost_get() {
  return remote.Metabolic_Boost_get();
}


public static IntPtr Adrenal_Glands_get() {
  return remote.Adrenal_Glands_get();
}


public static IntPtr Muscular_Augments_get() {
  return remote.Muscular_Augments_get();
}


public static IntPtr Grooved_Spines_get() {
  return remote.Grooved_Spines_get();
}


public static IntPtr Gamete_Meiosis_get() {
  return remote.Gamete_Meiosis_get();
}


public static IntPtr Metasynaptic_Node_get() {
  return remote.Metasynaptic_Node_get();
}


public static IntPtr Singularity_Charge_get() {
  return remote.Singularity_Charge_get();
}


public static IntPtr Leg_Enhancements_get() {
  return remote.Leg_Enhancements_get();
}


public static IntPtr Scarab_Damage_get() {
  return remote.Scarab_Damage_get();
}


public static IntPtr Reaver_Capacity_get() {
  return remote.Reaver_Capacity_get();
}


public static IntPtr Gravitic_Drive_get() {
  return remote.Gravitic_Drive_get();
}


public static IntPtr Sensor_Array_get() {
  return remote.Sensor_Array_get();
}


public static IntPtr Gravitic_Boosters_get() {
  return remote.Gravitic_Boosters_get();
}


public static IntPtr Khaydarin_Amulet_get() {
  return remote.Khaydarin_Amulet_get();
}


public static IntPtr Apial_Sensors_get() {
  return remote.Apial_Sensors_get();
}


public static IntPtr Gravitic_Thrusters_get() {
  return remote.Gravitic_Thrusters_get();
}


public static IntPtr Carrier_Capacity_get() {
  return remote.Carrier_Capacity_get();
}


public static IntPtr Khaydarin_Core_get() {
  return remote.Khaydarin_Core_get();
}


public static IntPtr Argus_Jewel_get() {
  return remote.Argus_Jewel_get();
}


public static IntPtr Argus_Talisman_get() {
  return remote.Argus_Talisman_get();
}


public static IntPtr Caduceus_Reactor_get() {
  return remote.Caduceus_Reactor_get();
}


public static IntPtr Chitinous_Plating_get() {
  return remote.Chitinous_Plating_get();
}


public static IntPtr Anabolic_Synthesis_get() {
  return remote.Anabolic_Synthesis_get();
}


public static IntPtr Charon_Booster_get() {
  return remote.Charon_Booster_get();
}


public static IntPtr UpgradeTypeNone_get() {
  return remote.UpgradeTypeNone_get();
}


public static IntPtr UpgradeTypeUnknown_get() {
  return remote.UpgradeTypeUnknown_get();
}


public static IntPtr new_Position__SWIG_0() {
  return remote.new_Position__SWIG_0();
}


public static IntPtr new_Position__SWIG_1(HandleRef jarg1) {
  return remote.new_Position__SWIG_1(jarg1.Handle);
}


public static IntPtr new_Position__SWIG_2(int jarg1, int jarg2) {
  return remote.new_Position__SWIG_2(jarg1, jarg2);
}


public static bool Position_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.Position_opEquals(jarg1.Handle, jarg2.Handle);
}


public static bool Position_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.Position_opNotEquals(jarg1.Handle, jarg2.Handle);
}


public static bool Position_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return remote.Position_opLessThan(jarg1.Handle, jarg2.Handle);
}


public static IntPtr Position_opPlus(HandleRef jarg1, HandleRef jarg2) {
  return remote.Position_opPlus(jarg1.Handle, jarg2.Handle);
}


public static IntPtr Position_opMinus(HandleRef jarg1, HandleRef jarg2) {
  return remote.Position_opMinus(jarg1.Handle, jarg2.Handle);
}


public static IntPtr Position_opAdd(HandleRef jarg1, HandleRef jarg2) {
  return remote.Position_opAdd(jarg1.Handle, jarg2.Handle);
}


public static IntPtr Position_opSubtract(HandleRef jarg1, HandleRef jarg2) {
  return remote.Position_opSubtract(jarg1.Handle, jarg2.Handle);
}


public static double Position_getDistance(HandleRef jarg1, HandleRef jarg2) {
  return remote.Position_getDistance(jarg1.Handle, jarg2.Handle);
}


public static double Position_getApproxDistance(HandleRef jarg1, HandleRef jarg2) {
  return remote.Position_getApproxDistance(jarg1.Handle, jarg2.Handle);
}


public static double Position_getLength(HandleRef jarg1) {
  return remote.Position_getLength(jarg1.Handle);
}


public static IntPtr Position_x(HandleRef jarg1) {
  return remote.Position_x(jarg1.Handle);
}


public static IntPtr Position_y(HandleRef jarg1) {
  return remote.Position_y(jarg1.Handle);
}


public static int Position_xConst(HandleRef jarg1) {
  return remote.Position_xConst(jarg1.Handle);
}


public static int Position_yConst(HandleRef jarg1) {
  return remote.Position_yConst(jarg1.Handle);
}


public static void delete_Position(HandleRef jarg1) {
  remote.delete_Position(jarg1.Handle);
}


public static IntPtr PositionInvalid_get() {
  return remote.PositionInvalid_get();
}


public static IntPtr PositionNone_get() {
  return remote.PositionNone_get();
}


public static IntPtr PositionUnknown_get() {
  return remote.PositionUnknown_get();
}


public static IntPtr new_AIModule() {
  return remote.new_AIModule();
}


public static void delete_AIModule(HandleRef jarg1) {
  remote.delete_AIModule(jarg1.Handle);
}


public static void AIModule_onStart(HandleRef jarg1) {
  remote.AIModule_onStart(jarg1.Handle);
}


public static void AIModule_onEnd(HandleRef jarg1, bool jarg2) {
  remote.AIModule_onEnd(jarg1.Handle, jarg2);
}


public static void AIModule_onFrame(HandleRef jarg1) {
  remote.AIModule_onFrame(jarg1.Handle);
}


public static bool AIModule_onSendText(HandleRef jarg1, string jarg2) {
  return remote.AIModule_onSendText(jarg1.Handle, jarg2);
}


public static void AIModule_onPlayerLeft(HandleRef jarg1, HandleRef jarg2) {
  remote.AIModule_onPlayerLeft(jarg1.Handle, jarg2.Handle);
}


public static void AIModule_onNukeDetect(HandleRef jarg1, HandleRef jarg2) {
  remote.AIModule_onNukeDetect(jarg1.Handle, jarg2.Handle);
}


public static void AIModule_onUnitCreate(HandleRef jarg1, HandleRef jarg2) {
  remote.AIModule_onUnitCreate(jarg1.Handle, jarg2.Handle);
}


public static void AIModule_onUnitDestroy(HandleRef jarg1, HandleRef jarg2) {
  remote.AIModule_onUnitDestroy(jarg1.Handle, jarg2.Handle);
}


public static void AIModule_onUnitMorph(HandleRef jarg1, HandleRef jarg2) {
  remote.AIModule_onUnitMorph(jarg1.Handle, jarg2.Handle);
}


public static void AIModule_onUnitShow(HandleRef jarg1, HandleRef jarg2) {
  remote.AIModule_onUnitShow(jarg1.Handle, jarg2.Handle);
}


public static void AIModule_onUnitHide(HandleRef jarg1, HandleRef jarg2) {
  remote.AIModule_onUnitHide(jarg1.Handle, jarg2.Handle);
}


public static void AIModule_onUnitRenegade(HandleRef jarg1, HandleRef jarg2) {
  remote.AIModule_onUnitRenegade(jarg1.Handle, jarg2.Handle);
}


public static IntPtr new_AttackType__SWIG_0() {
  return remote.new_AttackType__SWIG_0();
}


public static IntPtr new_AttackType__SWIG_1(int jarg1) {
  return remote.new_AttackType__SWIG_1(jarg1);
}


public static IntPtr new_AttackType__SWIG_2(HandleRef jarg1) {
  return remote.new_AttackType__SWIG_2(jarg1.Handle);
}


public static IntPtr AttackType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return remote.AttackType_opAssign(jarg1.Handle, jarg2.Handle);
}


public static bool AttackType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.AttackType_opEquals(jarg1.Handle, jarg2.Handle);
}


public static bool AttackType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.AttackType_opNotEquals(jarg1.Handle, jarg2.Handle);
}


public static bool AttackType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return remote.AttackType_opLessThan(jarg1.Handle, jarg2.Handle);
}


public static int AttackType_getID(HandleRef jarg1) {
  return remote.AttackType_getID(jarg1.Handle);
}


public static string AttackType_getName(HandleRef jarg1) {
  return remote.AttackType_getName(jarg1.Handle);
}


public static void delete_AttackType(HandleRef jarg1) {
  remote.delete_AttackType(jarg1.Handle);
}


public static IntPtr getAttackType(string jarg1) {
  return remote.getAttackType(jarg1);
}


public static IntPtr allAttackTypes() {
  return remote.allAttackTypes();
}


public static void initAttackTypes() {
  remote.initAttackTypes();
}


public static IntPtr Melee_get() {
  return remote.Melee_get();
}


public static IntPtr Fusion_Cutter_Hit_get() {
  return remote.Fusion_Cutter_Hit_get();
}


public static IntPtr Gauss_Rifle_Hit_get() {
  return remote.Gauss_Rifle_Hit_get();
}


public static IntPtr C_10_Canister_Rifle_Hit_get() {
  return remote.C_10_Canister_Rifle_Hit_get();
}


public static IntPtr AttackTypeGemeni_Missiles_get() {
  return remote.AttackTypeGemeni_Missiles_get();
}


public static IntPtr AttackTypeFragmentation_Grenade_get() {
  return remote.AttackTypeFragmentation_Grenade_get();
}


public static IntPtr AttackTypeLongbolt_Missile_get() {
  return remote.AttackTypeLongbolt_Missile_get();
}


public static IntPtr ATS_ATA_Laser_Battery_get() {
  return remote.ATS_ATA_Laser_Battery_get();
}


public static IntPtr AttackTypeBurst_Lasers_get() {
  return remote.AttackTypeBurst_Lasers_get();
}


public static IntPtr Arclite_Shock_Cannon_Hit_get() {
  return remote.Arclite_Shock_Cannon_Hit_get();
}


public static IntPtr EMP_Missile_get() {
  return remote.EMP_Missile_get();
}


public static IntPtr Dual_Photon_Blasters_Hit_get() {
  return remote.Dual_Photon_Blasters_Hit_get();
}


public static IntPtr Particle_Beam_Hit_get() {
  return remote.Particle_Beam_Hit_get();
}


public static IntPtr Anti_Matter_Missile_get() {
  return remote.Anti_Matter_Missile_get();
}


public static IntPtr AttackTypePulse_Cannon_get() {
  return remote.AttackTypePulse_Cannon_get();
}


public static IntPtr Psionic_Shockwave_Hit_get() {
  return remote.Psionic_Shockwave_Hit_get();
}


public static IntPtr Psionic_Storm_get() {
  return remote.Psionic_Storm_get();
}


public static IntPtr AttackTypeYamato_Gun_get() {
  return remote.AttackTypeYamato_Gun_get();
}


public static IntPtr AttackTypePhase_Disruptor_get() {
  return remote.AttackTypePhase_Disruptor_get();
}


public static IntPtr STA_STS_Cannon_Overlay_get() {
  return remote.STA_STS_Cannon_Overlay_get();
}


public static IntPtr Sunken_Colony_Tentacle_get() {
  return remote.Sunken_Colony_Tentacle_get();
}


public static IntPtr AttackTypeAcid_Spore_get() {
  return remote.AttackTypeAcid_Spore_get();
}


public static IntPtr AttackTypeGlave_Wurm_get() {
  return remote.AttackTypeGlave_Wurm_get();
}


public static IntPtr AttackTypeSeeker_Spores_get() {
  return remote.AttackTypeSeeker_Spores_get();
}


public static IntPtr Queen_Spell_Carrier_get() {
  return remote.Queen_Spell_Carrier_get();
}


public static IntPtr Plague_Cloud_get() {
  return remote.Plague_Cloud_get();
}


public static IntPtr Consume_get() {
  return remote.Consume_get();
}


public static IntPtr Needle_Spine_Hit_get() {
  return remote.Needle_Spine_Hit_get();
}


public static IntPtr Invisible_get() {
  return remote.Invisible_get();
}


public static IntPtr Optical_Flare_Grenade_get() {
  return remote.Optical_Flare_Grenade_get();
}


public static IntPtr AttackTypeHalo_Rockets_get() {
  return remote.AttackTypeHalo_Rockets_get();
}


public static IntPtr AttackTypeSubterranean_Spines_get() {
  return remote.AttackTypeSubterranean_Spines_get();
}


public static IntPtr Corrosive_Acid_Shot_get() {
  return remote.Corrosive_Acid_Shot_get();
}


public static IntPtr Neutron_Flare_get() {
  return remote.Neutron_Flare_get();
}


public static IntPtr AttackTypeNone_get() {
  return remote.AttackTypeNone_get();
}


public static IntPtr AttackTypeUnknown_get() {
  return remote.AttackTypeUnknown_get();
}


public static IntPtr new_Color__SWIG_0() {
  return remote.new_Color__SWIG_0();
}


public static IntPtr new_Color__SWIG_1(int jarg1) {
  return remote.new_Color__SWIG_1(jarg1);
}


public static IntPtr new_Color__SWIG_2(HandleRef jarg1) {
  return remote.new_Color__SWIG_2(jarg1.Handle);
}


public static IntPtr new_Color__SWIG_3(int jarg1, int jarg2, int jarg3) {
  return remote.new_Color__SWIG_3(jarg1, jarg2, jarg3);
}


public static IntPtr Color_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return remote.Color_opAssign(jarg1.Handle, jarg2.Handle);
}


public static bool Color_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.Color_opEquals(jarg1.Handle, jarg2.Handle);
}


public static bool Color_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.Color_opNotEquals(jarg1.Handle, jarg2.Handle);
}


public static bool Color_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return remote.Color_opLessThan(jarg1.Handle, jarg2.Handle);
}


public static int Color_getID(HandleRef jarg1) {
  return remote.Color_getID(jarg1.Handle);
}


public static int Color_red(HandleRef jarg1) {
  return remote.Color_red(jarg1.Handle);
}


public static int Color_green(HandleRef jarg1) {
  return remote.Color_green(jarg1.Handle);
}


public static int Color_blue(HandleRef jarg1) {
  return remote.Color_blue(jarg1.Handle);
}


public static void delete_Color(HandleRef jarg1) {
  remote.delete_Color(jarg1.Handle);
}


public static void initColors() {
  remote.initColors();
}


public static IntPtr Red_get() {
  return remote.Red_get();
}


public static IntPtr Green_get() {
  return remote.Green_get();
}


public static IntPtr Blue_get() {
  return remote.Blue_get();
}


public static IntPtr Yellow_get() {
  return remote.Yellow_get();
}


public static IntPtr Cyan_get() {
  return remote.Cyan_get();
}


public static IntPtr Purple_get() {
  return remote.Purple_get();
}


public static IntPtr Orange_get() {
  return remote.Orange_get();
}


public static IntPtr Black_get() {
  return remote.Black_get();
}


public static IntPtr White_get() {
  return remote.White_get();
}


public static IntPtr Grey_get() {
  return remote.Grey_get();
}


public static int TILE_SIZE_get() {
  return remote.TILE_SIZE_get();
}


public static int PYLON_X_RADIUS_get() {
  return remote.PYLON_X_RADIUS_get();
}


public static int PYLON_Y_RADIUS_get() {
  return remote.PYLON_Y_RADIUS_get();
}


public static IntPtr new_DamageType__SWIG_0() {
  return remote.new_DamageType__SWIG_0();
}


public static IntPtr new_DamageType__SWIG_1(int jarg1) {
  return remote.new_DamageType__SWIG_1(jarg1);
}


public static IntPtr new_DamageType__SWIG_2(HandleRef jarg1) {
  return remote.new_DamageType__SWIG_2(jarg1.Handle);
}


public static IntPtr DamageType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return remote.DamageType_opAssign(jarg1.Handle, jarg2.Handle);
}


public static bool DamageType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.DamageType_opEquals(jarg1.Handle, jarg2.Handle);
}


public static bool DamageType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.DamageType_opNotEquals(jarg1.Handle, jarg2.Handle);
}


public static bool DamageType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return remote.DamageType_opLessThan(jarg1.Handle, jarg2.Handle);
}


public static int DamageType_getID(HandleRef jarg1) {
  return remote.DamageType_getID(jarg1.Handle);
}


public static string DamageType_getName(HandleRef jarg1) {
  return remote.DamageType_getName(jarg1.Handle);
}


public static void delete_DamageType(HandleRef jarg1) {
  remote.delete_DamageType(jarg1.Handle);
}


public static IntPtr getDamageType(string jarg1) {
  return remote.getDamageType(jarg1);
}


public static IntPtr allDamageTypes() {
  return remote.allDamageTypes();
}


public static void initDamageTypes() {
  remote.initDamageTypes();
}


public static IntPtr DamageTypeIndependent_get() {
  return remote.DamageTypeIndependent_get();
}


public static IntPtr Explosive_get() {
  return remote.Explosive_get();
}


public static IntPtr Concussive_get() {
  return remote.Concussive_get();
}


public static IntPtr DamageTypeNormal_get() {
  return remote.DamageTypeNormal_get();
}


public static IntPtr Ignore_Armor_get() {
  return remote.Ignore_Armor_get();
}


public static IntPtr DamageTypeNone_get() {
  return remote.DamageTypeNone_get();
}


public static IntPtr DamageTypeUnknown_get() {
  return remote.DamageTypeUnknown_get();
}


public static IntPtr new_Error__SWIG_0() {
  return remote.new_Error__SWIG_0();
}


public static IntPtr new_Error__SWIG_1(int jarg1) {
  return remote.new_Error__SWIG_1(jarg1);
}


public static IntPtr new_Error__SWIG_2(HandleRef jarg1) {
  return remote.new_Error__SWIG_2(jarg1.Handle);
}


public static IntPtr Error_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return remote.Error_opAssign(jarg1.Handle, jarg2.Handle);
}


public static bool Error_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.Error_opEquals(jarg1.Handle, jarg2.Handle);
}


public static bool Error_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.Error_opNotEquals(jarg1.Handle, jarg2.Handle);
}


public static bool Error_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return remote.Error_opLessThan(jarg1.Handle, jarg2.Handle);
}


public static int Error_getID(HandleRef jarg1) {
  return remote.Error_getID(jarg1.Handle);
}


public static string Error_toErrorString(HandleRef jarg1) {
  return remote.Error_toErrorString(jarg1.Handle);
}


public static void delete_Error(HandleRef jarg1) {
  remote.delete_Error(jarg1.Handle);
}


public static IntPtr getError(string jarg1) {
  return remote.getError(jarg1);
}


public static IntPtr allErrors() {
  return remote.allErrors();
}


public static void initErrors() {
  remote.initErrors();
}


public static IntPtr Unit_Does_Not_Exist_get() {
  return remote.Unit_Does_Not_Exist_get();
}


public static IntPtr Unit_Not_Visible_get() {
  return remote.Unit_Not_Visible_get();
}


public static IntPtr Unit_Not_Owned_get() {
  return remote.Unit_Not_Owned_get();
}


public static IntPtr Unit_Busy_get() {
  return remote.Unit_Busy_get();
}


public static IntPtr Incompatible_UnitType_get() {
  return remote.Incompatible_UnitType_get();
}


public static IntPtr Incompatible_TechType_get() {
  return remote.Incompatible_TechType_get();
}


public static IntPtr Already_Researched_get() {
  return remote.Already_Researched_get();
}


public static IntPtr Fully_Upgraded_get() {
  return remote.Fully_Upgraded_get();
}


public static IntPtr Insufficient_Minerals_get() {
  return remote.Insufficient_Minerals_get();
}


public static IntPtr Insufficient_Gas_get() {
  return remote.Insufficient_Gas_get();
}


public static IntPtr Insufficient_Supply_get() {
  return remote.Insufficient_Supply_get();
}


public static IntPtr Insufficient_Energy_get() {
  return remote.Insufficient_Energy_get();
}


public static IntPtr Insufficient_Tech_get() {
  return remote.Insufficient_Tech_get();
}


public static IntPtr Insufficient_Ammo_get() {
  return remote.Insufficient_Ammo_get();
}


public static IntPtr Insufficient_Space_get() {
  return remote.Insufficient_Space_get();
}


public static IntPtr Unbuildable_Location_get() {
  return remote.Unbuildable_Location_get();
}


public static IntPtr Out_Of_Range_get() {
  return remote.Out_Of_Range_get();
}


public static IntPtr Unable_To_Hit_get() {
  return remote.Unable_To_Hit_get();
}


public static IntPtr Access_Denied_get() {
  return remote.Access_Denied_get();
}


public static IntPtr ErrorNone_get() {
  return remote.ErrorNone_get();
}


public static IntPtr ErrorUnknown_get() {
  return remote.ErrorUnknown_get();
}


public static IntPtr new_ExplosionType__SWIG_0() {
  return remote.new_ExplosionType__SWIG_0();
}


public static IntPtr new_ExplosionType__SWIG_1(int jarg1) {
  return remote.new_ExplosionType__SWIG_1(jarg1);
}


public static IntPtr new_ExplosionType__SWIG_2(HandleRef jarg1) {
  return remote.new_ExplosionType__SWIG_2(jarg1.Handle);
}


public static IntPtr ExplosionType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return remote.ExplosionType_opAssign(jarg1.Handle, jarg2.Handle);
}


public static bool ExplosionType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.ExplosionType_opEquals(jarg1.Handle, jarg2.Handle);
}


public static bool ExplosionType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.ExplosionType_opNotEquals(jarg1.Handle, jarg2.Handle);
}


public static bool ExplosionType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return remote.ExplosionType_opLessThan(jarg1.Handle, jarg2.Handle);
}


public static int ExplosionType_getID(HandleRef jarg1) {
  return remote.ExplosionType_getID(jarg1.Handle);
}


public static string ExplosionType_getName(HandleRef jarg1) {
  return remote.ExplosionType_getName(jarg1.Handle);
}


public static void delete_ExplosionType(HandleRef jarg1) {
  remote.delete_ExplosionType(jarg1.Handle);
}


public static IntPtr getExplosionType(string jarg1) {
  return remote.getExplosionType(jarg1);
}


public static IntPtr allExplosionTypes() {
  return remote.allExplosionTypes();
}


public static void initExplosionTypes() {
  remote.initExplosionTypes();
}


public static IntPtr ExplosionTypeNone_get() {
  return remote.ExplosionTypeNone_get();
}


public static IntPtr ExplosionTypeNormal_get() {
  return remote.ExplosionTypeNormal_get();
}


public static IntPtr Radial_Splash_get() {
  return remote.Radial_Splash_get();
}


public static IntPtr Enemy_Splash_get() {
  return remote.Enemy_Splash_get();
}


public static IntPtr ExplosionTypeLockdown_get() {
  return remote.ExplosionTypeLockdown_get();
}


public static IntPtr Nuclear_Missile_get() {
  return remote.Nuclear_Missile_get();
}


public static IntPtr ExplosionTypeParasite_get() {
  return remote.ExplosionTypeParasite_get();
}


public static IntPtr Broodlings_get() {
  return remote.Broodlings_get();
}


public static IntPtr ExplosionTypeEMP_Shockwave_get() {
  return remote.ExplosionTypeEMP_Shockwave_get();
}


public static IntPtr ExplosionTypeIrradiate_get() {
  return remote.ExplosionTypeIrradiate_get();
}


public static IntPtr ExplosionTypeEnsnare_get() {
  return remote.ExplosionTypeEnsnare_get();
}


public static IntPtr ExplosionTypePlague_get() {
  return remote.ExplosionTypePlague_get();
}


public static IntPtr ExplosionTypeStasis_Field_get() {
  return remote.ExplosionTypeStasis_Field_get();
}


public static IntPtr ExplosionTypeDark_Swarm_get() {
  return remote.ExplosionTypeDark_Swarm_get();
}


public static IntPtr ExplosionTypeConsume_get() {
  return remote.ExplosionTypeConsume_get();
}


public static IntPtr ExplosionTypeYamato_Gun_get() {
  return remote.ExplosionTypeYamato_Gun_get();
}


public static IntPtr ExplosionTypeRestoration_get() {
  return remote.ExplosionTypeRestoration_get();
}


public static IntPtr ExplosionTypeDisruption_Web_get() {
  return remote.ExplosionTypeDisruption_Web_get();
}


public static IntPtr ExplosionTypeCorrosive_Acid_get() {
  return remote.ExplosionTypeCorrosive_Acid_get();
}


public static IntPtr ExplosionTypeMind_Control_get() {
  return remote.ExplosionTypeMind_Control_get();
}


public static IntPtr ExplosionTypeFeedback_get() {
  return remote.ExplosionTypeFeedback_get();
}


public static IntPtr ExplosionTypeOptical_Flare_get() {
  return remote.ExplosionTypeOptical_Flare_get();
}


public static IntPtr ExplosionTypeMaelstrom_get() {
  return remote.ExplosionTypeMaelstrom_get();
}


public static IntPtr Air_Splash_get() {
  return remote.Air_Splash_get();
}


public static IntPtr ExplosionTypeUnknown_get() {
  return remote.ExplosionTypeUnknown_get();
}


public static int FLAG_COUNT_get() {
  return remote.FLAG_COUNT_get();
}


public static string Force_getName(HandleRef jarg1) {
  return remote.Force_getName(jarg1.Handle);
}


public static IntPtr Force_getPlayers(HandleRef jarg1) {
  return remote.Force_getPlayers(jarg1.Handle);
}


public static void delete_Force(HandleRef jarg1) {
  remote.delete_Force(jarg1.Handle);
}


public static IntPtr Game_getForces(HandleRef jarg1) {
  return remote.Game_getForces(jarg1.Handle);
}


public static IntPtr Game_getPlayers(HandleRef jarg1) {
  return remote.Game_getPlayers(jarg1.Handle);
}


public static IntPtr Game_getAllUnits(HandleRef jarg1) {
  return remote.Game_getAllUnits(jarg1.Handle);
}


public static IntPtr Game_getMinerals(HandleRef jarg1) {
  return remote.Game_getMinerals(jarg1.Handle);
}


public static IntPtr Game_getGeysers(HandleRef jarg1) {
  return remote.Game_getGeysers(jarg1.Handle);
}


public static IntPtr Game_getNeutralUnits(HandleRef jarg1) {
  return remote.Game_getNeutralUnits(jarg1.Handle);
}


public static IntPtr Game_getStaticMinerals(HandleRef jarg1) {
  return remote.Game_getStaticMinerals(jarg1.Handle);
}


public static IntPtr Game_getStaticGeysers(HandleRef jarg1) {
  return remote.Game_getStaticGeysers(jarg1.Handle);
}


public static IntPtr Game_getStaticNeutralUnits(HandleRef jarg1) {
  return remote.Game_getStaticNeutralUnits(jarg1.Handle);
}


public static int Game_getLatency(HandleRef jarg1) {
  return remote.Game_getLatency(jarg1.Handle);
}


public static int Game_getFrameCount(HandleRef jarg1) {
  return remote.Game_getFrameCount(jarg1.Handle);
}


public static int Game_getMouseX(HandleRef jarg1) {
  return remote.Game_getMouseX(jarg1.Handle);
}


public static int Game_getMouseY(HandleRef jarg1) {
  return remote.Game_getMouseY(jarg1.Handle);
}


public static IntPtr Game_getMousePosition(HandleRef jarg1) {
  return remote.Game_getMousePosition(jarg1.Handle);
}


public static bool Game_getMouseState__SWIG_0(HandleRef jarg1, int jarg2) {
  return remote.Game_getMouseState__SWIG_0(jarg1.Handle, jarg2);
}


public static bool Game_getMouseState__SWIG_1(HandleRef jarg1, int jarg2) {
  return remote.Game_getMouseState__SWIG_1(jarg1.Handle, jarg2);
}


public static bool Game_getKeyState__SWIG_0(HandleRef jarg1, int jarg2) {
  return remote.Game_getKeyState__SWIG_0(jarg1.Handle, jarg2);
}


public static bool Game_getKeyState__SWIG_1(HandleRef jarg1, int jarg2) {
  return remote.Game_getKeyState__SWIG_1(jarg1.Handle, jarg2);
}


public static int Game_getScreenX(HandleRef jarg1) {
  return remote.Game_getScreenX(jarg1.Handle);
}


public static int Game_getScreenY(HandleRef jarg1) {
  return remote.Game_getScreenY(jarg1.Handle);
}


public static IntPtr Game_getScreenPosition(HandleRef jarg1) {
  return remote.Game_getScreenPosition(jarg1.Handle);
}


public static void Game_setScreenPosition__SWIG_0(HandleRef jarg1, int jarg2, int jarg3) {
  remote.Game_setScreenPosition__SWIG_0(jarg1.Handle, jarg2, jarg3);
}


public static void Game_setScreenPosition__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  remote.Game_setScreenPosition__SWIG_1(jarg1.Handle, jarg2.Handle);
}


public static void Game_pingMinimap__SWIG_0(HandleRef jarg1, int jarg2, int jarg3) {
  remote.Game_pingMinimap__SWIG_0(jarg1.Handle, jarg2, jarg3);
}


public static void Game_pingMinimap__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  remote.Game_pingMinimap__SWIG_1(jarg1.Handle, jarg2.Handle);
}


public static bool Game_isFlagEnabled(HandleRef jarg1, int jarg2) {
  return remote.Game_isFlagEnabled(jarg1.Handle, jarg2);
}


public static void Game_enableFlag(HandleRef jarg1, int jarg2) {
  remote.Game_enableFlag(jarg1.Handle, jarg2);
}


public static IntPtr Game_unitsOnTile(HandleRef jarg1, int jarg2, int jarg3) {
  return remote.Game_unitsOnTile(jarg1.Handle, jarg2, jarg3);
}


public static IntPtr Game_getLastError(HandleRef jarg1) {
  return remote.Game_getLastError(jarg1.Handle);
}


public static int Game_mapWidth(HandleRef jarg1) {
  return remote.Game_mapWidth(jarg1.Handle);
}


public static int Game_mapHeight(HandleRef jarg1) {
  return remote.Game_mapHeight(jarg1.Handle);
}


public static string Game_mapFilename(HandleRef jarg1) {
  return remote.Game_mapFilename(jarg1.Handle);
}


public static string Game_mapName(HandleRef jarg1) {
  return remote.Game_mapName(jarg1.Handle);
}


public static int Game_getMapHash(HandleRef jarg1) {
  return remote.Game_getMapHash(jarg1.Handle);
}


public static int Game_getGroundHeight(HandleRef jarg1, int jarg2, int jarg3) {
  return remote.Game_getGroundHeight(jarg1.Handle, jarg2, jarg3);
}


public static bool Game_isWalkable(HandleRef jarg1, int jarg2, int jarg3) {
  return remote.Game_isWalkable(jarg1.Handle, jarg2, jarg3);
}


public static bool Game_isBuildable__SWIG_0(HandleRef jarg1, int jarg2, int jarg3) {
  return remote.Game_isBuildable__SWIG_0(jarg1.Handle, jarg2, jarg3);
}


public static bool Game_isVisible__SWIG_0(HandleRef jarg1, int jarg2, int jarg3) {
  return remote.Game_isVisible__SWIG_0(jarg1.Handle, jarg2, jarg3);
}


public static bool Game_isExplored__SWIG_0(HandleRef jarg1, int jarg2, int jarg3) {
  return remote.Game_isExplored__SWIG_0(jarg1.Handle, jarg2, jarg3);
}


public static bool Game_hasCreep__SWIG_0(HandleRef jarg1, int jarg2, int jarg3) {
  return remote.Game_hasCreep__SWIG_0(jarg1.Handle, jarg2, jarg3);
}


public static bool Game_hasPower__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5) {
  return remote.Game_hasPower__SWIG_0(jarg1.Handle, jarg2, jarg3, jarg4, jarg5);
}


public static bool Game_isBuildable__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return remote.Game_isBuildable__SWIG_1(jarg1.Handle, jarg2.Handle);
}


public static bool Game_isVisible__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return remote.Game_isVisible__SWIG_1(jarg1.Handle, jarg2.Handle);
}


public static bool Game_isExplored__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return remote.Game_isExplored__SWIG_1(jarg1.Handle, jarg2.Handle);
}


public static bool Game_hasCreep__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return remote.Game_hasCreep__SWIG_1(jarg1.Handle, jarg2.Handle);
}


public static bool Game_hasPower__SWIG_1(HandleRef jarg1, HandleRef jarg2, int jarg3, int jarg4) {
  return remote.Game_hasPower__SWIG_1(jarg1.Handle, jarg2.Handle, jarg3, jarg4);
}


public static bool Game_canBuildHere(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4) {
  return remote.Game_canBuildHere(jarg1.Handle, jarg2.Handle, jarg3.Handle, jarg4.Handle);
}


public static bool Game_canMake(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3) {
  return remote.Game_canMake(jarg1.Handle, jarg2.Handle, jarg3.Handle);
}


public static bool Game_canResearch(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3) {
  return remote.Game_canResearch(jarg1.Handle, jarg2.Handle, jarg3.Handle);
}


public static bool Game_canUpgrade(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3) {
  return remote.Game_canUpgrade(jarg1.Handle, jarg2.Handle, jarg3.Handle);
}


public static IntPtr Game_getStartLocations(HandleRef jarg1) {
  return remote.Game_getStartLocations(jarg1.Handle);
}


public static void Game_printf(HandleRef jarg1, string jarg2) {
  remote.Game_printf(jarg1.Handle, jarg2);
}


public static void Game_sendText(HandleRef jarg1, string jarg2) {
  remote.Game_sendText(jarg1.Handle, jarg2);
}


public static void Game_changeRace(HandleRef jarg1, HandleRef jarg2) {
  remote.Game_changeRace(jarg1.Handle, jarg2.Handle);
}


public static bool Game_isMultiplayer(HandleRef jarg1) {
  return remote.Game_isMultiplayer(jarg1.Handle);
}


public static bool Game_isPaused(HandleRef jarg1) {
  return remote.Game_isPaused(jarg1.Handle);
}


public static bool Game_isReplay(HandleRef jarg1) {
  return remote.Game_isReplay(jarg1.Handle);
}


public static void Game_startGame(HandleRef jarg1) {
  remote.Game_startGame(jarg1.Handle);
}


public static void Game_pauseGame(HandleRef jarg1) {
  remote.Game_pauseGame(jarg1.Handle);
}


public static void Game_resumeGame(HandleRef jarg1) {
  remote.Game_resumeGame(jarg1.Handle);
}


public static void Game_leaveGame(HandleRef jarg1) {
  remote.Game_leaveGame(jarg1.Handle);
}


public static void Game_restartGame(HandleRef jarg1) {
  remote.Game_restartGame(jarg1.Handle);
}


public static void Game_setLocalSpeed__SWIG_0(HandleRef jarg1, int jarg2) {
  remote.Game_setLocalSpeed__SWIG_0(jarg1.Handle, jarg2);
}


public static void Game_setLocalSpeed__SWIG_1(HandleRef jarg1) {
  remote.Game_setLocalSpeed__SWIG_1(jarg1.Handle);
}


public static IntPtr Game_getSelectedUnits(HandleRef jarg1) {
  return remote.Game_getSelectedUnits(jarg1.Handle);
}


public static IntPtr Game_self(HandleRef jarg1) {
  return remote.Game_self(jarg1.Handle);
}


public static IntPtr Game_enemy(HandleRef jarg1) {
  return remote.Game_enemy(jarg1.Handle);
}


public static void Game_drawText(HandleRef jarg1, int jarg2, int jarg3, int jarg4, string jarg5) {
  remote.Game_drawText(jarg1.Handle, jarg2, jarg3, jarg4, jarg5);
}


public static void Game_drawTextMap(HandleRef jarg1, int jarg2, int jarg3, string jarg4) {
  remote.Game_drawTextMap(jarg1.Handle, jarg2, jarg3, jarg4);
}


public static void Game_drawTextMouse(HandleRef jarg1, int jarg2, int jarg3, string jarg4) {
  remote.Game_drawTextMouse(jarg1.Handle, jarg2, jarg3, jarg4);
}


public static void Game_drawTextScreen(HandleRef jarg1, int jarg2, int jarg3, string jarg4) {
  remote.Game_drawTextScreen(jarg1.Handle, jarg2, jarg3, jarg4);
}


public static void Game_drawBox__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, HandleRef jarg7, bool jarg8) {
  remote.Game_drawBox__SWIG_0(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7.Handle, jarg8);
}


public static void Game_drawBox__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, HandleRef jarg7) {
  remote.Game_drawBox__SWIG_1(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7.Handle);
}


public static void Game_drawBoxMap__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6, bool jarg7) {
  remote.Game_drawBoxMap__SWIG_0(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6.Handle, jarg7);
}


public static void Game_drawBoxMap__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  remote.Game_drawBoxMap__SWIG_1(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6.Handle);
}


public static void Game_drawBoxMouse__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6, bool jarg7) {
  remote.Game_drawBoxMouse__SWIG_0(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6.Handle, jarg7);
}


public static void Game_drawBoxMouse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  remote.Game_drawBoxMouse__SWIG_1(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6.Handle);
}


public static void Game_drawBoxScreen__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6, bool jarg7) {
  remote.Game_drawBoxScreen__SWIG_0(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6.Handle, jarg7);
}


public static void Game_drawBoxScreen__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  remote.Game_drawBoxScreen__SWIG_1(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6.Handle);
}


public static void Game_drawTriangle__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, int jarg8, HandleRef jarg9, bool jarg10) {
  remote.Game_drawTriangle__SWIG_0(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8, jarg9.Handle, jarg10);
}


public static void Game_drawTriangle__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, int jarg8, HandleRef jarg9) {
  remote.Game_drawTriangle__SWIG_1(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8, jarg9.Handle);
}


public static void Game_drawTriangleMap__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, HandleRef jarg8, bool jarg9) {
  remote.Game_drawTriangleMap__SWIG_0(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8.Handle, jarg9);
}


public static void Game_drawTriangleMap__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, HandleRef jarg8) {
  remote.Game_drawTriangleMap__SWIG_1(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8.Handle);
}


public static void Game_drawTriangleMouse__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, HandleRef jarg8, bool jarg9) {
  remote.Game_drawTriangleMouse__SWIG_0(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8.Handle, jarg9);
}


public static void Game_drawTriangleMouse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, HandleRef jarg8) {
  remote.Game_drawTriangleMouse__SWIG_1(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8.Handle);
}


public static void Game_drawTriangleScreen__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, HandleRef jarg8, bool jarg9) {
  remote.Game_drawTriangleScreen__SWIG_0(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8.Handle, jarg9);
}


public static void Game_drawTriangleScreen__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, HandleRef jarg8) {
  remote.Game_drawTriangleScreen__SWIG_1(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8.Handle);
}


public static void Game_drawCircle__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6, bool jarg7) {
  remote.Game_drawCircle__SWIG_0(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6.Handle, jarg7);
}


public static void Game_drawCircle__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  remote.Game_drawCircle__SWIG_1(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6.Handle);
}


public static void Game_drawCircleMap__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, HandleRef jarg5, bool jarg6) {
  remote.Game_drawCircleMap__SWIG_0(jarg1.Handle, jarg2, jarg3, jarg4, jarg5.Handle, jarg6);
}


public static void Game_drawCircleMap__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, HandleRef jarg5) {
  remote.Game_drawCircleMap__SWIG_1(jarg1.Handle, jarg2, jarg3, jarg4, jarg5.Handle);
}


public static void Game_drawCircleMouse__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, HandleRef jarg5, bool jarg6) {
  remote.Game_drawCircleMouse__SWIG_0(jarg1.Handle, jarg2, jarg3, jarg4, jarg5.Handle, jarg6);
}


public static void Game_drawCircleMouse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, HandleRef jarg5) {
  remote.Game_drawCircleMouse__SWIG_1(jarg1.Handle, jarg2, jarg3, jarg4, jarg5.Handle);
}


public static void Game_drawCircleScreen__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, HandleRef jarg5, bool jarg6) {
  remote.Game_drawCircleScreen__SWIG_0(jarg1.Handle, jarg2, jarg3, jarg4, jarg5.Handle, jarg6);
}


public static void Game_drawCircleScreen__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, HandleRef jarg5) {
  remote.Game_drawCircleScreen__SWIG_1(jarg1.Handle, jarg2, jarg3, jarg4, jarg5.Handle);
}


public static void Game_drawEllipse__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, HandleRef jarg7, bool jarg8) {
  remote.Game_drawEllipse__SWIG_0(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7.Handle, jarg8);
}


public static void Game_drawEllipse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, HandleRef jarg7) {
  remote.Game_drawEllipse__SWIG_1(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7.Handle);
}


public static void Game_drawEllipseMap__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6, bool jarg7) {
  remote.Game_drawEllipseMap__SWIG_0(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6.Handle, jarg7);
}


public static void Game_drawEllipseMap__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  remote.Game_drawEllipseMap__SWIG_1(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6.Handle);
}


public static void Game_drawEllipseMouse__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6, bool jarg7) {
  remote.Game_drawEllipseMouse__SWIG_0(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6.Handle, jarg7);
}


public static void Game_drawEllipseMouse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  remote.Game_drawEllipseMouse__SWIG_1(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6.Handle);
}


public static void Game_drawEllipseScreen__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6, bool jarg7) {
  remote.Game_drawEllipseScreen__SWIG_0(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6.Handle, jarg7);
}


public static void Game_drawEllipseScreen__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  remote.Game_drawEllipseScreen__SWIG_1(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6.Handle);
}


public static void Game_drawDot(HandleRef jarg1, int jarg2, int jarg3, int jarg4, HandleRef jarg5) {
  remote.Game_drawDot(jarg1.Handle, jarg2, jarg3, jarg4, jarg5.Handle);
}


public static void Game_drawDotMap(HandleRef jarg1, int jarg2, int jarg3, HandleRef jarg4) {
  remote.Game_drawDotMap(jarg1.Handle, jarg2, jarg3, jarg4.Handle);
}


public static void Game_drawDotMouse(HandleRef jarg1, int jarg2, int jarg3, HandleRef jarg4) {
  remote.Game_drawDotMouse(jarg1.Handle, jarg2, jarg3, jarg4.Handle);
}


public static void Game_drawDotScreen(HandleRef jarg1, int jarg2, int jarg3, HandleRef jarg4) {
  remote.Game_drawDotScreen(jarg1.Handle, jarg2, jarg3, jarg4.Handle);
}


public static void Game_drawLine(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, HandleRef jarg7) {
  remote.Game_drawLine(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6, jarg7.Handle);
}


public static void Game_drawLineMap(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  remote.Game_drawLineMap(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6.Handle);
}


public static void Game_drawLineMouse(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  remote.Game_drawLineMouse(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6.Handle);
}


public static void Game_drawLineScreen(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, HandleRef jarg6) {
  remote.Game_drawLineScreen(jarg1.Handle, jarg2, jarg3, jarg4, jarg5, jarg6.Handle);
}


public static void delete_Game(HandleRef jarg1) {
  remote.delete_Game(jarg1.Handle);
}


public static void Broodwar_set(HandleRef jarg1) {
  remote.Broodwar_set(jarg1.Handle);
}


public static IntPtr Broodwar_get() {
  return remote.Broodwar_get();
}


public static IntPtr new_Order__SWIG_0() {
  return remote.new_Order__SWIG_0();
}


public static IntPtr new_Order__SWIG_1(int jarg1) {
  return remote.new_Order__SWIG_1(jarg1);
}


public static IntPtr new_Order__SWIG_2(HandleRef jarg1) {
  return remote.new_Order__SWIG_2(jarg1.Handle);
}


public static IntPtr Order_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return remote.Order_opAssign(jarg1.Handle, jarg2.Handle);
}


public static bool Order_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.Order_opEquals(jarg1.Handle, jarg2.Handle);
}


public static bool Order_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.Order_opNotEquals(jarg1.Handle, jarg2.Handle);
}


public static bool Order_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return remote.Order_opLessThan(jarg1.Handle, jarg2.Handle);
}


public static int Order_getID(HandleRef jarg1) {
  return remote.Order_getID(jarg1.Handle);
}


public static string Order_getName(HandleRef jarg1) {
  return remote.Order_getName(jarg1.Handle);
}


public static void delete_Order(HandleRef jarg1) {
  remote.delete_Order(jarg1.Handle);
}


public static IntPtr getOrder(string jarg1) {
  return remote.getOrder(jarg1);
}


public static IntPtr allOrders() {
  return remote.allOrders();
}


public static void initOrders() {
  remote.initOrders();
}


public static IntPtr Die_get() {
  return remote.Die_get();
}


public static IntPtr Stop_get() {
  return remote.Stop_get();
}


public static IntPtr Guard_get() {
  return remote.Guard_get();
}


public static IntPtr PlayerGuard_get() {
  return remote.PlayerGuard_get();
}


public static IntPtr TurretGuard_get() {
  return remote.TurretGuard_get();
}


public static IntPtr BunkerGuard_get() {
  return remote.BunkerGuard_get();
}


public static IntPtr Move_get() {
  return remote.Move_get();
}


public static IntPtr ReaverStop_get() {
  return remote.ReaverStop_get();
}


public static IntPtr Attack1_get() {
  return remote.Attack1_get();
}


public static IntPtr Attack2_get() {
  return remote.Attack2_get();
}


public static IntPtr AttackUnit_get() {
  return remote.AttackUnit_get();
}


public static IntPtr AttackFixedRange_get() {
  return remote.AttackFixedRange_get();
}


public static IntPtr AttackTile_get() {
  return remote.AttackTile_get();
}


public static IntPtr Hover_get() {
  return remote.Hover_get();
}


public static IntPtr AttackMove_get() {
  return remote.AttackMove_get();
}


public static IntPtr InfestMine1_get() {
  return remote.InfestMine1_get();
}


public static IntPtr Nothing1_get() {
  return remote.Nothing1_get();
}


public static IntPtr Powerup1_get() {
  return remote.Powerup1_get();
}


public static IntPtr TowerGuard_get() {
  return remote.TowerGuard_get();
}


public static IntPtr TowerAttack_get() {
  return remote.TowerAttack_get();
}


public static IntPtr VultureMine_get() {
  return remote.VultureMine_get();
}


public static IntPtr StayinRange_get() {
  return remote.StayinRange_get();
}


public static IntPtr TurretAttack_get() {
  return remote.TurretAttack_get();
}


public static IntPtr Nothing2_get() {
  return remote.Nothing2_get();
}


public static IntPtr Nothing3_get() {
  return remote.Nothing3_get();
}


public static IntPtr DroneStartBuild_get() {
  return remote.DroneStartBuild_get();
}


public static IntPtr DroneBuild_get() {
  return remote.DroneBuild_get();
}


public static IntPtr InfestMine2_get() {
  return remote.InfestMine2_get();
}


public static IntPtr InfestMine3_get() {
  return remote.InfestMine3_get();
}


public static IntPtr InfestMine4_get() {
  return remote.InfestMine4_get();
}


public static IntPtr BuildTerran_get() {
  return remote.BuildTerran_get();
}


public static IntPtr BuildProtoss1_get() {
  return remote.BuildProtoss1_get();
}


public static IntPtr BuildProtoss2_get() {
  return remote.BuildProtoss2_get();
}


public static IntPtr ConstructingBuilding_get() {
  return remote.ConstructingBuilding_get();
}


public static IntPtr Repair1_get() {
  return remote.Repair1_get();
}


public static IntPtr Repair2_get() {
  return remote.Repair2_get();
}


public static IntPtr PlaceAddon_get() {
  return remote.PlaceAddon_get();
}


public static IntPtr BuildAddon_get() {
  return remote.BuildAddon_get();
}


public static IntPtr Train_get() {
  return remote.Train_get();
}


public static IntPtr RallyPoint1_get() {
  return remote.RallyPoint1_get();
}


public static IntPtr RallyPoint2_get() {
  return remote.RallyPoint2_get();
}


public static IntPtr ZergBirth_get() {
  return remote.ZergBirth_get();
}


public static IntPtr Morph1_get() {
  return remote.Morph1_get();
}


public static IntPtr Morph2_get() {
  return remote.Morph2_get();
}


public static IntPtr BuildSelf1_get() {
  return remote.BuildSelf1_get();
}


public static IntPtr ZergBuildSelf_get() {
  return remote.ZergBuildSelf_get();
}


public static IntPtr Build5_get() {
  return remote.Build5_get();
}


public static IntPtr Enternyduscanal_get() {
  return remote.Enternyduscanal_get();
}


public static IntPtr BuildSelf2_get() {
  return remote.BuildSelf2_get();
}


public static IntPtr Follow_get() {
  return remote.Follow_get();
}


public static IntPtr Carrier_get() {
  return remote.Carrier_get();
}


public static IntPtr CarrierIgnore1_get() {
  return remote.CarrierIgnore1_get();
}


public static IntPtr CarrierStop_get() {
  return remote.CarrierStop_get();
}


public static IntPtr CarrierAttack1_get() {
  return remote.CarrierAttack1_get();
}


public static IntPtr CarrierAttack2_get() {
  return remote.CarrierAttack2_get();
}


public static IntPtr CarrierIgnore2_get() {
  return remote.CarrierIgnore2_get();
}


public static IntPtr CarrierFight_get() {
  return remote.CarrierFight_get();
}


public static IntPtr HoldPosition1_get() {
  return remote.HoldPosition1_get();
}


public static IntPtr Reaver_get() {
  return remote.Reaver_get();
}


public static IntPtr ReaverAttack1_get() {
  return remote.ReaverAttack1_get();
}


public static IntPtr ReaverAttack2_get() {
  return remote.ReaverAttack2_get();
}


public static IntPtr ReaverFight_get() {
  return remote.ReaverFight_get();
}


public static IntPtr ReaverHold_get() {
  return remote.ReaverHold_get();
}


public static IntPtr TrainFighter_get() {
  return remote.TrainFighter_get();
}


public static IntPtr StrafeUnit1_get() {
  return remote.StrafeUnit1_get();
}


public static IntPtr StrafeUnit2_get() {
  return remote.StrafeUnit2_get();
}


public static IntPtr RechargeShields1_get() {
  return remote.RechargeShields1_get();
}


public static IntPtr Rechargeshields2_get() {
  return remote.Rechargeshields2_get();
}


public static IntPtr ShieldBattery_get() {
  return remote.ShieldBattery_get();
}


public static IntPtr Return_get() {
  return remote.Return_get();
}


public static IntPtr DroneLand_get() {
  return remote.DroneLand_get();
}


public static IntPtr BuildingLand_get() {
  return remote.BuildingLand_get();
}


public static IntPtr BuildingLiftoff_get() {
  return remote.BuildingLiftoff_get();
}


public static IntPtr DroneLiftoff_get() {
  return remote.DroneLiftoff_get();
}


public static IntPtr Liftoff_get() {
  return remote.Liftoff_get();
}


public static IntPtr ResearchTech_get() {
  return remote.ResearchTech_get();
}


public static IntPtr Upgrade_get() {
  return remote.Upgrade_get();
}


public static IntPtr Larva_get() {
  return remote.Larva_get();
}


public static IntPtr SpawningLarva_get() {
  return remote.SpawningLarva_get();
}


public static IntPtr Harvest1_get() {
  return remote.Harvest1_get();
}


public static IntPtr Harvest2_get() {
  return remote.Harvest2_get();
}


public static IntPtr MoveToGas_get() {
  return remote.MoveToGas_get();
}


public static IntPtr WaitForGas_get() {
  return remote.WaitForGas_get();
}


public static IntPtr HarvestGas_get() {
  return remote.HarvestGas_get();
}


public static IntPtr ReturnGas_get() {
  return remote.ReturnGas_get();
}


public static IntPtr MoveToMinerals_get() {
  return remote.MoveToMinerals_get();
}


public static IntPtr WaitForMinerals_get() {
  return remote.WaitForMinerals_get();
}


public static IntPtr MiningMinerals_get() {
  return remote.MiningMinerals_get();
}


public static IntPtr Harvest3_get() {
  return remote.Harvest3_get();
}


public static IntPtr Harvest4_get() {
  return remote.Harvest4_get();
}


public static IntPtr ReturnMinerals_get() {
  return remote.ReturnMinerals_get();
}


public static IntPtr Harvest5_get() {
  return remote.Harvest5_get();
}


public static IntPtr EnterTransport_get() {
  return remote.EnterTransport_get();
}


public static IntPtr Pickup1_get() {
  return remote.Pickup1_get();
}


public static IntPtr Pickup2_get() {
  return remote.Pickup2_get();
}


public static IntPtr Pickup3_get() {
  return remote.Pickup3_get();
}


public static IntPtr Pickup4_get() {
  return remote.Pickup4_get();
}


public static IntPtr Powerup2_get() {
  return remote.Powerup2_get();
}


public static IntPtr SiegeMode_get() {
  return remote.SiegeMode_get();
}


public static IntPtr TankMode_get() {
  return remote.TankMode_get();
}


public static IntPtr WatchTarget_get() {
  return remote.WatchTarget_get();
}


public static IntPtr InitCreepGrowth_get() {
  return remote.InitCreepGrowth_get();
}


public static IntPtr SpreadCreep_get() {
  return remote.SpreadCreep_get();
}


public static IntPtr StoppingCreepGrowth_get() {
  return remote.StoppingCreepGrowth_get();
}


public static IntPtr GuardianAspect_get() {
  return remote.GuardianAspect_get();
}


public static IntPtr WarpingArchon_get() {
  return remote.WarpingArchon_get();
}


public static IntPtr CompletingArchonsummon_get() {
  return remote.CompletingArchonsummon_get();
}


public static IntPtr HoldPosition2_get() {
  return remote.HoldPosition2_get();
}


public static IntPtr HoldPosition3_get() {
  return remote.HoldPosition3_get();
}


public static IntPtr Cloak_get() {
  return remote.Cloak_get();
}


public static IntPtr Decloak_get() {
  return remote.Decloak_get();
}


public static IntPtr Unload_get() {
  return remote.Unload_get();
}


public static IntPtr MoveUnload_get() {
  return remote.MoveUnload_get();
}


public static IntPtr FireYamatoGun1_get() {
  return remote.FireYamatoGun1_get();
}


public static IntPtr FireYamatoGun2_get() {
  return remote.FireYamatoGun2_get();
}


public static IntPtr MagnaPulse_get() {
  return remote.MagnaPulse_get();
}


public static IntPtr Burrow_get() {
  return remote.Burrow_get();
}


public static IntPtr Burrowed_get() {
  return remote.Burrowed_get();
}


public static IntPtr Unburrow_get() {
  return remote.Unburrow_get();
}


public static IntPtr DarkSwarm_get() {
  return remote.DarkSwarm_get();
}


public static IntPtr CastParasite_get() {
  return remote.CastParasite_get();
}


public static IntPtr SummonBroodlings_get() {
  return remote.SummonBroodlings_get();
}


public static IntPtr EmpShockwave_get() {
  return remote.EmpShockwave_get();
}


public static IntPtr NukeWait_get() {
  return remote.NukeWait_get();
}


public static IntPtr NukeTrain_get() {
  return remote.NukeTrain_get();
}


public static IntPtr NukeLaunch_get() {
  return remote.NukeLaunch_get();
}


public static IntPtr NukePaint_get() {
  return remote.NukePaint_get();
}


public static IntPtr NukeUnit_get() {
  return remote.NukeUnit_get();
}


public static IntPtr NukeGround_get() {
  return remote.NukeGround_get();
}


public static IntPtr NukeTrack_get() {
  return remote.NukeTrack_get();
}


public static IntPtr InitArbiter_get() {
  return remote.InitArbiter_get();
}


public static IntPtr CloakNearbyUnits_get() {
  return remote.CloakNearbyUnits_get();
}


public static IntPtr PlaceMine_get() {
  return remote.PlaceMine_get();
}


public static IntPtr Rightclickaction_get() {
  return remote.Rightclickaction_get();
}


public static IntPtr SapUnit_get() {
  return remote.SapUnit_get();
}


public static IntPtr SapLocation_get() {
  return remote.SapLocation_get();
}


public static IntPtr HoldPosition4_get() {
  return remote.HoldPosition4_get();
}


public static IntPtr Teleport_get() {
  return remote.Teleport_get();
}


public static IntPtr TeleporttoLocation_get() {
  return remote.TeleporttoLocation_get();
}


public static IntPtr PlaceScanner_get() {
  return remote.PlaceScanner_get();
}


public static IntPtr Scanner_get() {
  return remote.Scanner_get();
}


public static IntPtr DefensiveMatrix_get() {
  return remote.DefensiveMatrix_get();
}


public static IntPtr PsiStorm_get() {
  return remote.PsiStorm_get();
}


public static IntPtr OrderIrradiate_get() {
  return remote.OrderIrradiate_get();
}


public static IntPtr OrderPlague_get() {
  return remote.OrderPlague_get();
}


public static IntPtr OrderConsume_get() {
  return remote.OrderConsume_get();
}


public static IntPtr OrderEnsnare_get() {
  return remote.OrderEnsnare_get();
}


public static IntPtr StasisField_get() {
  return remote.StasisField_get();
}


public static IntPtr Hallucination1_get() {
  return remote.Hallucination1_get();
}


public static IntPtr Hallucination2_get() {
  return remote.Hallucination2_get();
}


public static IntPtr ResetCollision1_get() {
  return remote.ResetCollision1_get();
}


public static IntPtr ResetCollision2_get() {
  return remote.ResetCollision2_get();
}


public static IntPtr Patrol_get() {
  return remote.Patrol_get();
}


public static IntPtr CTFCOPInit_get() {
  return remote.CTFCOPInit_get();
}


public static IntPtr CTFCOP1_get() {
  return remote.CTFCOP1_get();
}


public static IntPtr CTFCOP2_get() {
  return remote.CTFCOP2_get();
}


public static IntPtr ComputerAI_get() {
  return remote.ComputerAI_get();
}


public static IntPtr AtkMoveEP_get() {
  return remote.AtkMoveEP_get();
}


public static IntPtr HarassMove_get() {
  return remote.HarassMove_get();
}


public static IntPtr AIPatrol_get() {
  return remote.AIPatrol_get();
}


public static IntPtr GuardPost_get() {
  return remote.GuardPost_get();
}


public static IntPtr RescuePassive_get() {
  return remote.RescuePassive_get();
}


public static IntPtr OrderNeutral_get() {
  return remote.OrderNeutral_get();
}


public static IntPtr ComputerReturn_get() {
  return remote.ComputerReturn_get();
}


public static IntPtr InitPsiProvider_get() {
  return remote.InitPsiProvider_get();
}


public static IntPtr SelfDestrucing_get() {
  return remote.SelfDestrucing_get();
}


public static IntPtr Critter_get() {
  return remote.Critter_get();
}


public static IntPtr HiddenGun_get() {
  return remote.HiddenGun_get();
}


public static IntPtr OpenDoor_get() {
  return remote.OpenDoor_get();
}


public static IntPtr CloseDoor_get() {
  return remote.CloseDoor_get();
}


public static IntPtr HideTrap_get() {
  return remote.HideTrap_get();
}


public static IntPtr RevealTrap_get() {
  return remote.RevealTrap_get();
}


public static IntPtr Enabledoodad_get() {
  return remote.Enabledoodad_get();
}


public static IntPtr Disabledoodad_get() {
  return remote.Disabledoodad_get();
}


public static IntPtr Warpin_get() {
  return remote.Warpin_get();
}


public static IntPtr Medic_get() {
  return remote.Medic_get();
}


public static IntPtr MedicHeal1_get() {
  return remote.MedicHeal1_get();
}


public static IntPtr HealMove_get() {
  return remote.HealMove_get();
}


public static IntPtr MedicHoldPosition_get() {
  return remote.MedicHoldPosition_get();
}


public static IntPtr MedicHeal2_get() {
  return remote.MedicHeal2_get();
}


public static IntPtr OrderRestoration_get() {
  return remote.OrderRestoration_get();
}


public static IntPtr CastDisruptionWeb_get() {
  return remote.CastDisruptionWeb_get();
}


public static IntPtr CastMindControl_get() {
  return remote.CastMindControl_get();
}


public static IntPtr WarpingDarkArchon_get() {
  return remote.WarpingDarkArchon_get();
}


public static IntPtr CastFeedback_get() {
  return remote.CastFeedback_get();
}


public static IntPtr CastOpticalFlare_get() {
  return remote.CastOpticalFlare_get();
}


public static IntPtr CastMaelstrom_get() {
  return remote.CastMaelstrom_get();
}


public static IntPtr JunkYardDog_get() {
  return remote.JunkYardDog_get();
}


public static IntPtr Fatal_get() {
  return remote.Fatal_get();
}


public static IntPtr OrderNone_get() {
  return remote.OrderNone_get();
}


public static IntPtr OrderUnknown_get() {
  return remote.OrderUnknown_get();
}


public static IntPtr new_PlayerType__SWIG_0() {
  return remote.new_PlayerType__SWIG_0();
}


public static IntPtr new_PlayerType__SWIG_1(int jarg1) {
  return remote.new_PlayerType__SWIG_1(jarg1);
}


public static IntPtr new_PlayerType__SWIG_2(HandleRef jarg1) {
  return remote.new_PlayerType__SWIG_2(jarg1.Handle);
}


public static IntPtr PlayerType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return remote.PlayerType_opAssign(jarg1.Handle, jarg2.Handle);
}


public static bool PlayerType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.PlayerType_opEquals(jarg1.Handle, jarg2.Handle);
}


public static bool PlayerType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.PlayerType_opNotEquals(jarg1.Handle, jarg2.Handle);
}


public static bool PlayerType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return remote.PlayerType_opLessThan(jarg1.Handle, jarg2.Handle);
}


public static int PlayerType_getID(HandleRef jarg1) {
  return remote.PlayerType_getID(jarg1.Handle);
}


public static string PlayerType_getName(HandleRef jarg1) {
  return remote.PlayerType_getName(jarg1.Handle);
}


public static void delete_PlayerType(HandleRef jarg1) {
  remote.delete_PlayerType(jarg1.Handle);
}


public static IntPtr getPlayerType(string jarg1) {
  return remote.getPlayerType(jarg1);
}


public static IntPtr allPlayerTypes() {
  return remote.allPlayerTypes();
}


public static void initPlayerTypes() {
  remote.initPlayerTypes();
}


public static IntPtr NotUsed_get() {
  return remote.NotUsed_get();
}


public static IntPtr Computer_get() {
  return remote.Computer_get();
}


public static IntPtr Human_get() {
  return remote.Human_get();
}


public static IntPtr Rescuable_get() {
  return remote.Rescuable_get();
}


public static IntPtr ComputerSlot_get() {
  return remote.ComputerSlot_get();
}


public static IntPtr OpenSlot_get() {
  return remote.OpenSlot_get();
}


public static IntPtr PlayerTypeNeutral_get() {
  return remote.PlayerTypeNeutral_get();
}


public static IntPtr ClosedSlot_get() {
  return remote.ClosedSlot_get();
}


public static IntPtr HumanDefeated_get() {
  return remote.HumanDefeated_get();
}


public static IntPtr ComputerDefeated_get() {
  return remote.ComputerDefeated_get();
}


public static IntPtr PlayerTypeNone_get() {
  return remote.PlayerTypeNone_get();
}


public static IntPtr PlayerTypeUnknown_get() {
  return remote.PlayerTypeUnknown_get();
}


public static int Player_getID(HandleRef jarg1) {
  return remote.Player_getID(jarg1.Handle);
}


public static string Player_getName(HandleRef jarg1) {
  return remote.Player_getName(jarg1.Handle);
}


public static IntPtr Player_getUnits(HandleRef jarg1) {
  return remote.Player_getUnits(jarg1.Handle);
}


public static IntPtr Player_getRace(HandleRef jarg1) {
  return remote.Player_getRace(jarg1.Handle);
}


public static IntPtr Player_playerType(HandleRef jarg1) {
  return remote.Player_playerType(jarg1.Handle);
}


public static IntPtr Player_getForce(HandleRef jarg1) {
  return remote.Player_getForce(jarg1.Handle);
}


public static bool Player_isAlly(HandleRef jarg1, HandleRef jarg2) {
  return remote.Player_isAlly(jarg1.Handle, jarg2.Handle);
}


public static bool Player_isEnemy(HandleRef jarg1, HandleRef jarg2) {
  return remote.Player_isEnemy(jarg1.Handle, jarg2.Handle);
}


public static bool Player_isNeutral(HandleRef jarg1) {
  return remote.Player_isNeutral(jarg1.Handle);
}


public static IntPtr Player_getStartLocation(HandleRef jarg1) {
  return remote.Player_getStartLocation(jarg1.Handle);
}


public static bool Player_isVictorious(HandleRef jarg1) {
  return remote.Player_isVictorious(jarg1.Handle);
}


public static bool Player_isDefeated(HandleRef jarg1) {
  return remote.Player_isDefeated(jarg1.Handle);
}


public static bool Player_leftGame(HandleRef jarg1) {
  return remote.Player_leftGame(jarg1.Handle);
}


public static int Player_minerals(HandleRef jarg1) {
  return remote.Player_minerals(jarg1.Handle);
}


public static int Player_gas(HandleRef jarg1) {
  return remote.Player_gas(jarg1.Handle);
}


public static int Player_cumulativeMinerals(HandleRef jarg1) {
  return remote.Player_cumulativeMinerals(jarg1.Handle);
}


public static int Player_cumulativeGas(HandleRef jarg1) {
  return remote.Player_cumulativeGas(jarg1.Handle);
}


public static int Player_supplyTotal__SWIG_0(HandleRef jarg1) {
  return remote.Player_supplyTotal__SWIG_0(jarg1.Handle);
}


public static int Player_supplyUsed__SWIG_0(HandleRef jarg1) {
  return remote.Player_supplyUsed__SWIG_0(jarg1.Handle);
}


public static int Player_supplyTotal__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return remote.Player_supplyTotal__SWIG_1(jarg1.Handle, jarg2.Handle);
}


public static int Player_supplyUsed__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return remote.Player_supplyUsed__SWIG_1(jarg1.Handle, jarg2.Handle);
}


public static int Player_allUnitCount(HandleRef jarg1, HandleRef jarg2) {
  return remote.Player_allUnitCount(jarg1.Handle, jarg2.Handle);
}


public static int Player_completedUnitCount(HandleRef jarg1, HandleRef jarg2) {
  return remote.Player_completedUnitCount(jarg1.Handle, jarg2.Handle);
}


public static int Player_incompleteUnitCount(HandleRef jarg1, HandleRef jarg2) {
  return remote.Player_incompleteUnitCount(jarg1.Handle, jarg2.Handle);
}


public static int Player_deadUnitCount(HandleRef jarg1, HandleRef jarg2) {
  return remote.Player_deadUnitCount(jarg1.Handle, jarg2.Handle);
}


public static int Player_killedUnitCount(HandleRef jarg1, HandleRef jarg2) {
  return remote.Player_killedUnitCount(jarg1.Handle, jarg2.Handle);
}


public static int Player_getUpgradeLevel(HandleRef jarg1, HandleRef jarg2) {
  return remote.Player_getUpgradeLevel(jarg1.Handle, jarg2.Handle);
}


public static bool Player_hasResearched(HandleRef jarg1, HandleRef jarg2) {
  return remote.Player_hasResearched(jarg1.Handle, jarg2.Handle);
}


public static bool Player_isResearching(HandleRef jarg1, HandleRef jarg2) {
  return remote.Player_isResearching(jarg1.Handle, jarg2.Handle);
}


public static bool Player_isUpgrading(HandleRef jarg1, HandleRef jarg2) {
  return remote.Player_isUpgrading(jarg1.Handle, jarg2.Handle);
}


public static void delete_Player(HandleRef jarg1) {
  remote.delete_Player(jarg1.Handle);
}


public static IntPtr new_TilePosition__SWIG_0() {
  return remote.new_TilePosition__SWIG_0();
}


public static IntPtr new_TilePosition__SWIG_1(HandleRef jarg1) {
  return remote.new_TilePosition__SWIG_1(jarg1.Handle);
}


public static IntPtr new_TilePosition__SWIG_2(int jarg1, int jarg2) {
  return remote.new_TilePosition__SWIG_2(jarg1, jarg2);
}


public static bool TilePosition_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.TilePosition_opEquals(jarg1.Handle, jarg2.Handle);
}


public static bool TilePosition_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.TilePosition_opNotEquals(jarg1.Handle, jarg2.Handle);
}


public static bool TilePosition_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return remote.TilePosition_opLessThan(jarg1.Handle, jarg2.Handle);
}


public static IntPtr TilePosition_opPlus(HandleRef jarg1, HandleRef jarg2) {
  return remote.TilePosition_opPlus(jarg1.Handle, jarg2.Handle);
}


public static IntPtr TilePosition_opMinus(HandleRef jarg1, HandleRef jarg2) {
  return remote.TilePosition_opMinus(jarg1.Handle, jarg2.Handle);
}


public static IntPtr TilePosition_opAdd(HandleRef jarg1, HandleRef jarg2) {
  return remote.TilePosition_opAdd(jarg1.Handle, jarg2.Handle);
}


public static IntPtr TilePosition_opSubtract(HandleRef jarg1, HandleRef jarg2) {
  return remote.TilePosition_opSubtract(jarg1.Handle, jarg2.Handle);
}


public static double TilePosition_getDistance(HandleRef jarg1, HandleRef jarg2) {
  return remote.TilePosition_getDistance(jarg1.Handle, jarg2.Handle);
}


public static double TilePosition_getLength(HandleRef jarg1) {
  return remote.TilePosition_getLength(jarg1.Handle);
}


public static bool TilePosition_isValid(HandleRef jarg1) {
  return remote.TilePosition_isValid(jarg1.Handle);
}


public static IntPtr TilePosition_x(HandleRef jarg1) {
  return remote.TilePosition_x(jarg1.Handle);
}


public static IntPtr TilePosition_y(HandleRef jarg1) {
  return remote.TilePosition_y(jarg1.Handle);
}


public static int TilePosition_xConst(HandleRef jarg1) {
  return remote.TilePosition_xConst(jarg1.Handle);
}


public static int TilePosition_yConst(HandleRef jarg1) {
  return remote.TilePosition_yConst(jarg1.Handle);
}


public static void delete_TilePosition(HandleRef jarg1) {
  remote.delete_TilePosition(jarg1.Handle);
}


public static IntPtr TilePositionInvalid_get() {
  return remote.TilePositionInvalid_get();
}


public static IntPtr TilePositionNone_get() {
  return remote.TilePositionNone_get();
}


public static IntPtr TilePositionUnknown_get() {
  return remote.TilePositionUnknown_get();
}


public static int Unit_getID(HandleRef jarg1) {
  return remote.Unit_getID(jarg1.Handle);
}


public static IntPtr Unit_getPlayer(HandleRef jarg1) {
  return remote.Unit_getPlayer(jarg1.Handle);
}


public static IntPtr Unit_getType(HandleRef jarg1) {
  return remote.Unit_getType(jarg1.Handle);
}


public static IntPtr Unit_getInitialType(HandleRef jarg1) {
  return remote.Unit_getInitialType(jarg1.Handle);
}


public static int Unit_getHitPoints(HandleRef jarg1) {
  return remote.Unit_getHitPoints(jarg1.Handle);
}


public static int Unit_getInitialHitPoints(HandleRef jarg1) {
  return remote.Unit_getInitialHitPoints(jarg1.Handle);
}


public static int Unit_getShields(HandleRef jarg1) {
  return remote.Unit_getShields(jarg1.Handle);
}


public static int Unit_getEnergy(HandleRef jarg1) {
  return remote.Unit_getEnergy(jarg1.Handle);
}


public static int Unit_getResources(HandleRef jarg1) {
  return remote.Unit_getResources(jarg1.Handle);
}


public static int Unit_getInitialResources(HandleRef jarg1) {
  return remote.Unit_getInitialResources(jarg1.Handle);
}


public static int Unit_getKillCount(HandleRef jarg1) {
  return remote.Unit_getKillCount(jarg1.Handle);
}


public static int Unit_getGroundWeaponCooldown(HandleRef jarg1) {
  return remote.Unit_getGroundWeaponCooldown(jarg1.Handle);
}


public static int Unit_getAirWeaponCooldown(HandleRef jarg1) {
  return remote.Unit_getAirWeaponCooldown(jarg1.Handle);
}


public static int Unit_getSpellCooldown(HandleRef jarg1) {
  return remote.Unit_getSpellCooldown(jarg1.Handle);
}


public static int Unit_getDefenseMatrixPoints(HandleRef jarg1) {
  return remote.Unit_getDefenseMatrixPoints(jarg1.Handle);
}


public static int Unit_getDefenseMatrixTimer(HandleRef jarg1) {
  return remote.Unit_getDefenseMatrixTimer(jarg1.Handle);
}


public static int Unit_getEnsnareTimer(HandleRef jarg1) {
  return remote.Unit_getEnsnareTimer(jarg1.Handle);
}


public static int Unit_getIrradiateTimer(HandleRef jarg1) {
  return remote.Unit_getIrradiateTimer(jarg1.Handle);
}


public static int Unit_getLockdownTimer(HandleRef jarg1) {
  return remote.Unit_getLockdownTimer(jarg1.Handle);
}


public static int Unit_getMaelstromTimer(HandleRef jarg1) {
  return remote.Unit_getMaelstromTimer(jarg1.Handle);
}


public static int Unit_getPlagueTimer(HandleRef jarg1) {
  return remote.Unit_getPlagueTimer(jarg1.Handle);
}


public static int Unit_getRemoveTimer(HandleRef jarg1) {
  return remote.Unit_getRemoveTimer(jarg1.Handle);
}


public static int Unit_getStasisTimer(HandleRef jarg1) {
  return remote.Unit_getStasisTimer(jarg1.Handle);
}


public static int Unit_getStimTimer(HandleRef jarg1) {
  return remote.Unit_getStimTimer(jarg1.Handle);
}


public static IntPtr Unit_getPosition(HandleRef jarg1) {
  return remote.Unit_getPosition(jarg1.Handle);
}


public static IntPtr Unit_getInitialPosition(HandleRef jarg1) {
  return remote.Unit_getInitialPosition(jarg1.Handle);
}


public static IntPtr Unit_getTilePosition(HandleRef jarg1) {
  return remote.Unit_getTilePosition(jarg1.Handle);
}


public static IntPtr Unit_getInitialTilePosition(HandleRef jarg1) {
  return remote.Unit_getInitialTilePosition(jarg1.Handle);
}


public static double Unit_getDistance__SWIG_0(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_getDistance__SWIG_0(jarg1.Handle, jarg2.Handle);
}


public static double Unit_getDistance__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_getDistance__SWIG_1(jarg1.Handle, jarg2.Handle);
}


public static double Unit_getAngle(HandleRef jarg1) {
  return remote.Unit_getAngle(jarg1.Handle);
}


public static double Unit_getVelocityX(HandleRef jarg1) {
  return remote.Unit_getVelocityX(jarg1.Handle);
}


public static double Unit_getVelocityY(HandleRef jarg1) {
  return remote.Unit_getVelocityY(jarg1.Handle);
}


public static IntPtr Unit_getTarget(HandleRef jarg1) {
  return remote.Unit_getTarget(jarg1.Handle);
}


public static IntPtr Unit_getTargetPosition(HandleRef jarg1) {
  return remote.Unit_getTargetPosition(jarg1.Handle);
}


public static IntPtr Unit_getOrder(HandleRef jarg1) {
  return remote.Unit_getOrder(jarg1.Handle);
}


public static IntPtr Unit_getOrderTarget(HandleRef jarg1) {
  return remote.Unit_getOrderTarget(jarg1.Handle);
}


public static int Unit_getOrderTimer(HandleRef jarg1) {
  return remote.Unit_getOrderTimer(jarg1.Handle);
}


public static IntPtr Unit_getSecondaryOrder(HandleRef jarg1) {
  return remote.Unit_getSecondaryOrder(jarg1.Handle);
}


public static IntPtr Unit_getBuildUnit(HandleRef jarg1) {
  return remote.Unit_getBuildUnit(jarg1.Handle);
}


public static IntPtr Unit_getBuildType(HandleRef jarg1) {
  return remote.Unit_getBuildType(jarg1.Handle);
}


public static int Unit_getRemainingBuildTime(HandleRef jarg1) {
  return remote.Unit_getRemainingBuildTime(jarg1.Handle);
}


public static int Unit_getRemainingTrainTime(HandleRef jarg1) {
  return remote.Unit_getRemainingTrainTime(jarg1.Handle);
}


public static IntPtr Unit_getChild(HandleRef jarg1) {
  return remote.Unit_getChild(jarg1.Handle);
}


public static IntPtr Unit_getTrainingQueue(HandleRef jarg1) {
  return remote.Unit_getTrainingQueue(jarg1.Handle);
}


public static IntPtr Unit_getTransport(HandleRef jarg1) {
  return remote.Unit_getTransport(jarg1.Handle);
}


public static IntPtr Unit_getLoadedUnits(HandleRef jarg1) {
  return remote.Unit_getLoadedUnits(jarg1.Handle);
}


public static int Unit_getInterceptorCount(HandleRef jarg1) {
  return remote.Unit_getInterceptorCount(jarg1.Handle);
}


public static int Unit_getScarabCount(HandleRef jarg1) {
  return remote.Unit_getScarabCount(jarg1.Handle);
}


public static int Unit_getSpiderMineCount(HandleRef jarg1) {
  return remote.Unit_getSpiderMineCount(jarg1.Handle);
}


public static IntPtr Unit_getTech(HandleRef jarg1) {
  return remote.Unit_getTech(jarg1.Handle);
}


public static IntPtr Unit_getUpgrade(HandleRef jarg1) {
  return remote.Unit_getUpgrade(jarg1.Handle);
}


public static int Unit_getRemainingResearchTime(HandleRef jarg1) {
  return remote.Unit_getRemainingResearchTime(jarg1.Handle);
}


public static int Unit_getRemainingUpgradeTime(HandleRef jarg1) {
  return remote.Unit_getRemainingUpgradeTime(jarg1.Handle);
}


public static IntPtr Unit_getRallyPosition(HandleRef jarg1) {
  return remote.Unit_getRallyPosition(jarg1.Handle);
}


public static IntPtr Unit_getRallyUnit(HandleRef jarg1) {
  return remote.Unit_getRallyUnit(jarg1.Handle);
}


public static IntPtr Unit_getAddon(HandleRef jarg1) {
  return remote.Unit_getAddon(jarg1.Handle);
}


public static IntPtr Unit_getHatchery(HandleRef jarg1) {
  return remote.Unit_getHatchery(jarg1.Handle);
}


public static IntPtr Unit_getLarva(HandleRef jarg1) {
  return remote.Unit_getLarva(jarg1.Handle);
}


public static int Unit_getUpgradeLevel(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_getUpgradeLevel(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_exists(HandleRef jarg1) {
  return remote.Unit_exists(jarg1.Handle);
}


public static bool Unit_isAccelerating(HandleRef jarg1) {
  return remote.Unit_isAccelerating(jarg1.Handle);
}


public static bool Unit_isBeingConstructed(HandleRef jarg1) {
  return remote.Unit_isBeingConstructed(jarg1.Handle);
}


public static bool Unit_isBeingHealed(HandleRef jarg1) {
  return remote.Unit_isBeingHealed(jarg1.Handle);
}


public static bool Unit_isBlind(HandleRef jarg1) {
  return remote.Unit_isBlind(jarg1.Handle);
}


public static bool Unit_isBraking(HandleRef jarg1) {
  return remote.Unit_isBraking(jarg1.Handle);
}


public static bool Unit_isBurrowed(HandleRef jarg1) {
  return remote.Unit_isBurrowed(jarg1.Handle);
}


public static bool Unit_isCarryingGas(HandleRef jarg1) {
  return remote.Unit_isCarryingGas(jarg1.Handle);
}


public static bool Unit_isCarryingMinerals(HandleRef jarg1) {
  return remote.Unit_isCarryingMinerals(jarg1.Handle);
}


public static bool Unit_isCloaked(HandleRef jarg1) {
  return remote.Unit_isCloaked(jarg1.Handle);
}


public static bool Unit_isCompleted(HandleRef jarg1) {
  return remote.Unit_isCompleted(jarg1.Handle);
}


public static bool Unit_isConstructing(HandleRef jarg1) {
  return remote.Unit_isConstructing(jarg1.Handle);
}


public static bool Unit_isDefenseMatrixed(HandleRef jarg1) {
  return remote.Unit_isDefenseMatrixed(jarg1.Handle);
}


public static bool Unit_isEnsnared(HandleRef jarg1) {
  return remote.Unit_isEnsnared(jarg1.Handle);
}


public static bool Unit_isFollowing(HandleRef jarg1) {
  return remote.Unit_isFollowing(jarg1.Handle);
}


public static bool Unit_isGatheringGas(HandleRef jarg1) {
  return remote.Unit_isGatheringGas(jarg1.Handle);
}


public static bool Unit_isGatheringMinerals(HandleRef jarg1) {
  return remote.Unit_isGatheringMinerals(jarg1.Handle);
}


public static bool Unit_isHallucination(HandleRef jarg1) {
  return remote.Unit_isHallucination(jarg1.Handle);
}


public static bool Unit_isIdle(HandleRef jarg1) {
  return remote.Unit_isIdle(jarg1.Handle);
}


public static bool Unit_isIrradiated(HandleRef jarg1) {
  return remote.Unit_isIrradiated(jarg1.Handle);
}


public static bool Unit_isLifted(HandleRef jarg1) {
  return remote.Unit_isLifted(jarg1.Handle);
}


public static bool Unit_isLoaded(HandleRef jarg1) {
  return remote.Unit_isLoaded(jarg1.Handle);
}


public static bool Unit_isLockedDown(HandleRef jarg1) {
  return remote.Unit_isLockedDown(jarg1.Handle);
}


public static bool Unit_isMaelstrommed(HandleRef jarg1) {
  return remote.Unit_isMaelstrommed(jarg1.Handle);
}


public static bool Unit_isMorphing(HandleRef jarg1) {
  return remote.Unit_isMorphing(jarg1.Handle);
}


public static bool Unit_isMoving(HandleRef jarg1) {
  return remote.Unit_isMoving(jarg1.Handle);
}


public static bool Unit_isParasited(HandleRef jarg1) {
  return remote.Unit_isParasited(jarg1.Handle);
}


public static bool Unit_isPatrolling(HandleRef jarg1) {
  return remote.Unit_isPatrolling(jarg1.Handle);
}


public static bool Unit_isPlagued(HandleRef jarg1) {
  return remote.Unit_isPlagued(jarg1.Handle);
}


public static bool Unit_isRepairing(HandleRef jarg1) {
  return remote.Unit_isRepairing(jarg1.Handle);
}


public static bool Unit_isResearching(HandleRef jarg1) {
  return remote.Unit_isResearching(jarg1.Handle);
}


public static bool Unit_isSelected(HandleRef jarg1) {
  return remote.Unit_isSelected(jarg1.Handle);
}


public static bool Unit_isSieged(HandleRef jarg1) {
  return remote.Unit_isSieged(jarg1.Handle);
}


public static bool Unit_isStartingAttack(HandleRef jarg1) {
  return remote.Unit_isStartingAttack(jarg1.Handle);
}


public static bool Unit_isStasised(HandleRef jarg1) {
  return remote.Unit_isStasised(jarg1.Handle);
}


public static bool Unit_isStimmed(HandleRef jarg1) {
  return remote.Unit_isStimmed(jarg1.Handle);
}


public static bool Unit_isTraining(HandleRef jarg1) {
  return remote.Unit_isTraining(jarg1.Handle);
}


public static bool Unit_isUnderStorm(HandleRef jarg1) {
  return remote.Unit_isUnderStorm(jarg1.Handle);
}


public static bool Unit_isUnpowered(HandleRef jarg1) {
  return remote.Unit_isUnpowered(jarg1.Handle);
}


public static bool Unit_isUpgrading(HandleRef jarg1) {
  return remote.Unit_isUpgrading(jarg1.Handle);
}


public static bool Unit_isVisible(HandleRef jarg1) {
  return remote.Unit_isVisible(jarg1.Handle);
}


public static bool Unit_isBeingGathered(HandleRef jarg1) {
  return remote.Unit_isBeingGathered(jarg1.Handle);
}


public static bool Unit_attackMove(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_attackMove(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_attackUnit(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_attackUnit(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_rightClick__SWIG_0(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_rightClick__SWIG_0(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_rightClick__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_rightClick__SWIG_1(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_train(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_train(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_build(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3) {
  return remote.Unit_build(jarg1.Handle, jarg2.Handle, jarg3.Handle);
}


public static bool Unit_buildAddon(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_buildAddon(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_research(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_research(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_upgrade(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_upgrade(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_stop(HandleRef jarg1) {
  return remote.Unit_stop(jarg1.Handle);
}


public static bool Unit_holdPosition(HandleRef jarg1) {
  return remote.Unit_holdPosition(jarg1.Handle);
}


public static bool Unit_patrol(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_patrol(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_follow(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_follow(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_setRallyPosition(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_setRallyPosition(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_setRallyUnit(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_setRallyUnit(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_repair(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_repair(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_returnCargo(HandleRef jarg1) {
  return remote.Unit_returnCargo(jarg1.Handle);
}


public static bool Unit_morph(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_morph(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_burrow(HandleRef jarg1) {
  return remote.Unit_burrow(jarg1.Handle);
}


public static bool Unit_unburrow(HandleRef jarg1) {
  return remote.Unit_unburrow(jarg1.Handle);
}


public static bool Unit_siege(HandleRef jarg1) {
  return remote.Unit_siege(jarg1.Handle);
}


public static bool Unit_unsiege(HandleRef jarg1) {
  return remote.Unit_unsiege(jarg1.Handle);
}


public static bool Unit_cloak(HandleRef jarg1) {
  return remote.Unit_cloak(jarg1.Handle);
}


public static bool Unit_decloak(HandleRef jarg1) {
  return remote.Unit_decloak(jarg1.Handle);
}


public static bool Unit_lift(HandleRef jarg1) {
  return remote.Unit_lift(jarg1.Handle);
}


public static bool Unit_land(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_land(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_load(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_load(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_unload(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_unload(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_unloadAll__SWIG_0(HandleRef jarg1) {
  return remote.Unit_unloadAll__SWIG_0(jarg1.Handle);
}


public static bool Unit_unloadAll__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_unloadAll__SWIG_1(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_cancelConstruction(HandleRef jarg1) {
  return remote.Unit_cancelConstruction(jarg1.Handle);
}


public static bool Unit_haltConstruction(HandleRef jarg1) {
  return remote.Unit_haltConstruction(jarg1.Handle);
}


public static bool Unit_cancelMorph(HandleRef jarg1) {
  return remote.Unit_cancelMorph(jarg1.Handle);
}


public static bool Unit_cancelTrain__SWIG_0(HandleRef jarg1) {
  return remote.Unit_cancelTrain__SWIG_0(jarg1.Handle);
}


public static bool Unit_cancelTrain__SWIG_1(HandleRef jarg1, int jarg2) {
  return remote.Unit_cancelTrain__SWIG_1(jarg1.Handle, jarg2);
}


public static bool Unit_cancelAddon(HandleRef jarg1) {
  return remote.Unit_cancelAddon(jarg1.Handle);
}


public static bool Unit_cancelResearch(HandleRef jarg1) {
  return remote.Unit_cancelResearch(jarg1.Handle);
}


public static bool Unit_cancelUpgrade(HandleRef jarg1) {
  return remote.Unit_cancelUpgrade(jarg1.Handle);
}


public static bool Unit_useTech__SWIG_0(HandleRef jarg1, HandleRef jarg2) {
  return remote.Unit_useTech__SWIG_0(jarg1.Handle, jarg2.Handle);
}


public static bool Unit_useTech__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3) {
  return remote.Unit_useTech__SWIG_1(jarg1.Handle, jarg2.Handle, jarg3.Handle);
}


public static bool Unit_useTech__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3) {
  return remote.Unit_useTech__SWIG_2(jarg1.Handle, jarg2.Handle, jarg3.Handle);
}


public static void delete_Unit(HandleRef jarg1) {
  remote.delete_Unit(jarg1.Handle);
}


public static IntPtr new_UnitSizeType__SWIG_0() {
  return remote.new_UnitSizeType__SWIG_0();
}


public static IntPtr new_UnitSizeType__SWIG_1(int jarg1) {
  return remote.new_UnitSizeType__SWIG_1(jarg1);
}


public static IntPtr new_UnitSizeType__SWIG_2(HandleRef jarg1) {
  return remote.new_UnitSizeType__SWIG_2(jarg1.Handle);
}


public static IntPtr UnitSizeType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitSizeType_opAssign(jarg1.Handle, jarg2.Handle);
}


public static bool UnitSizeType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitSizeType_opEquals(jarg1.Handle, jarg2.Handle);
}


public static bool UnitSizeType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitSizeType_opNotEquals(jarg1.Handle, jarg2.Handle);
}


public static bool UnitSizeType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitSizeType_opLessThan(jarg1.Handle, jarg2.Handle);
}


public static int UnitSizeType_getID(HandleRef jarg1) {
  return remote.UnitSizeType_getID(jarg1.Handle);
}


public static string UnitSizeType_getName(HandleRef jarg1) {
  return remote.UnitSizeType_getName(jarg1.Handle);
}


public static void delete_UnitSizeType(HandleRef jarg1) {
  remote.delete_UnitSizeType(jarg1.Handle);
}


public static IntPtr getUnitSizeType(string jarg1) {
  return remote.getUnitSizeType(jarg1);
}


public static IntPtr allUnitSizeTypes() {
  return remote.allUnitSizeTypes();
}


public static void initUnitSizeTypes() {
  remote.initUnitSizeTypes();
}


public static IntPtr UnitSizeTypeIndependent_get() {
  return remote.UnitSizeTypeIndependent_get();
}


public static IntPtr Small_get() {
  return remote.Small_get();
}


public static IntPtr Medium_get() {
  return remote.Medium_get();
}


public static IntPtr Large_get() {
  return remote.Large_get();
}


public static IntPtr UnitSizeTypeNone_get() {
  return remote.UnitSizeTypeNone_get();
}


public static IntPtr UnitSizeTypeUnknown_get() {
  return remote.UnitSizeTypeUnknown_get();
}


public static IntPtr new_UnitType__SWIG_0() {
  return remote.new_UnitType__SWIG_0();
}


public static IntPtr new_UnitType__SWIG_1(int jarg1) {
  return remote.new_UnitType__SWIG_1(jarg1);
}


public static IntPtr new_UnitType__SWIG_2(HandleRef jarg1) {
  return remote.new_UnitType__SWIG_2(jarg1.Handle);
}


public static IntPtr UnitType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitType_opAssign(jarg1.Handle, jarg2.Handle);
}


public static bool UnitType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitType_opEquals(jarg1.Handle, jarg2.Handle);
}


public static bool UnitType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitType_opNotEquals(jarg1.Handle, jarg2.Handle);
}


public static bool UnitType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitType_opLessThan(jarg1.Handle, jarg2.Handle);
}


public static int UnitType_getID(HandleRef jarg1) {
  return remote.UnitType_getID(jarg1.Handle);
}


public static string UnitType_getName(HandleRef jarg1) {
  return remote.UnitType_getName(jarg1.Handle);
}


public static string UnitType_getSubLabel(HandleRef jarg1) {
  return remote.UnitType_getSubLabel(jarg1.Handle);
}


public static IntPtr UnitType_getRace(HandleRef jarg1) {
  return remote.UnitType_getRace(jarg1.Handle);
}


public static IntPtr UnitType_whatBuilds(HandleRef jarg1) {
  return remote.UnitType_whatBuilds(jarg1.Handle);
}


public static IntPtr UnitType_requiredUnits(HandleRef jarg1) {
  return remote.UnitType_requiredUnits(jarg1.Handle);
}


public static IntPtr UnitType_requiredTech(HandleRef jarg1) {
  return remote.UnitType_requiredTech(jarg1.Handle);
}


public static IntPtr UnitType_abilities(HandleRef jarg1) {
  return remote.UnitType_abilities(jarg1.Handle);
}


public static IntPtr UnitType_upgrades(HandleRef jarg1) {
  return remote.UnitType_upgrades(jarg1.Handle);
}


public static IntPtr UnitType_armorUpgrade(HandleRef jarg1) {
  return remote.UnitType_armorUpgrade(jarg1.Handle);
}


public static int UnitType_maxHitPoints(HandleRef jarg1) {
  return remote.UnitType_maxHitPoints(jarg1.Handle);
}


public static int UnitType_maxShields(HandleRef jarg1) {
  return remote.UnitType_maxShields(jarg1.Handle);
}


public static int UnitType_maxEnergy(HandleRef jarg1) {
  return remote.UnitType_maxEnergy(jarg1.Handle);
}


public static int UnitType_armor(HandleRef jarg1) {
  return remote.UnitType_armor(jarg1.Handle);
}


public static int UnitType_mineralPrice(HandleRef jarg1) {
  return remote.UnitType_mineralPrice(jarg1.Handle);
}


public static int UnitType_gasPrice(HandleRef jarg1) {
  return remote.UnitType_gasPrice(jarg1.Handle);
}


public static int UnitType_buildTime(HandleRef jarg1) {
  return remote.UnitType_buildTime(jarg1.Handle);
}


public static int UnitType_supplyRequired(HandleRef jarg1) {
  return remote.UnitType_supplyRequired(jarg1.Handle);
}


public static int UnitType_supplyProvided(HandleRef jarg1) {
  return remote.UnitType_supplyProvided(jarg1.Handle);
}


public static int UnitType_spaceRequired(HandleRef jarg1) {
  return remote.UnitType_spaceRequired(jarg1.Handle);
}


public static int UnitType_spaceProvided(HandleRef jarg1) {
  return remote.UnitType_spaceProvided(jarg1.Handle);
}


public static int UnitType_buildScore(HandleRef jarg1) {
  return remote.UnitType_buildScore(jarg1.Handle);
}


public static int UnitType_destroyScore(HandleRef jarg1) {
  return remote.UnitType_destroyScore(jarg1.Handle);
}


public static IntPtr UnitType_size(HandleRef jarg1) {
  return remote.UnitType_size(jarg1.Handle);
}


public static int UnitType_tileWidth(HandleRef jarg1) {
  return remote.UnitType_tileWidth(jarg1.Handle);
}


public static int UnitType_tileHeight(HandleRef jarg1) {
  return remote.UnitType_tileHeight(jarg1.Handle);
}


public static int UnitType_dimensionLeft(HandleRef jarg1) {
  return remote.UnitType_dimensionLeft(jarg1.Handle);
}


public static int UnitType_dimensionUp(HandleRef jarg1) {
  return remote.UnitType_dimensionUp(jarg1.Handle);
}


public static int UnitType_dimensionRight(HandleRef jarg1) {
  return remote.UnitType_dimensionRight(jarg1.Handle);
}


public static int UnitType_dimensionDown(HandleRef jarg1) {
  return remote.UnitType_dimensionDown(jarg1.Handle);
}


public static int UnitType_seekRange(HandleRef jarg1) {
  return remote.UnitType_seekRange(jarg1.Handle);
}


public static int UnitType_sightRange(HandleRef jarg1) {
  return remote.UnitType_sightRange(jarg1.Handle);
}


public static IntPtr UnitType_groundWeapon(HandleRef jarg1) {
  return remote.UnitType_groundWeapon(jarg1.Handle);
}


public static int UnitType_maxGroundHits(HandleRef jarg1) {
  return remote.UnitType_maxGroundHits(jarg1.Handle);
}


public static IntPtr UnitType_airWeapon(HandleRef jarg1) {
  return remote.UnitType_airWeapon(jarg1.Handle);
}


public static int UnitType_maxAirHits(HandleRef jarg1) {
  return remote.UnitType_maxAirHits(jarg1.Handle);
}


public static double UnitType_topSpeed(HandleRef jarg1) {
  return remote.UnitType_topSpeed(jarg1.Handle);
}


public static int UnitType_acceleration(HandleRef jarg1) {
  return remote.UnitType_acceleration(jarg1.Handle);
}


public static int UnitType_haltDistance(HandleRef jarg1) {
  return remote.UnitType_haltDistance(jarg1.Handle);
}


public static int UnitType_turnRadius(HandleRef jarg1) {
  return remote.UnitType_turnRadius(jarg1.Handle);
}


public static bool UnitType_canProduce(HandleRef jarg1) {
  return remote.UnitType_canProduce(jarg1.Handle);
}


public static bool UnitType_canAttack(HandleRef jarg1) {
  return remote.UnitType_canAttack(jarg1.Handle);
}


public static bool UnitType_canMove(HandleRef jarg1) {
  return remote.UnitType_canMove(jarg1.Handle);
}


public static bool UnitType_isFlyer(HandleRef jarg1) {
  return remote.UnitType_isFlyer(jarg1.Handle);
}


public static bool UnitType_regeneratesHP(HandleRef jarg1) {
  return remote.UnitType_regeneratesHP(jarg1.Handle);
}


public static bool UnitType_isSpellcaster(HandleRef jarg1) {
  return remote.UnitType_isSpellcaster(jarg1.Handle);
}


public static bool UnitType_hasPermanentCloak(HandleRef jarg1) {
  return remote.UnitType_hasPermanentCloak(jarg1.Handle);
}


public static bool UnitType_isInvincible(HandleRef jarg1) {
  return remote.UnitType_isInvincible(jarg1.Handle);
}


public static bool UnitType_isOrganic(HandleRef jarg1) {
  return remote.UnitType_isOrganic(jarg1.Handle);
}


public static bool UnitType_isMechanical(HandleRef jarg1) {
  return remote.UnitType_isMechanical(jarg1.Handle);
}


public static bool UnitType_isRobotic(HandleRef jarg1) {
  return remote.UnitType_isRobotic(jarg1.Handle);
}


public static bool UnitType_isDetector(HandleRef jarg1) {
  return remote.UnitType_isDetector(jarg1.Handle);
}


public static bool UnitType_isResourceContainer(HandleRef jarg1) {
  return remote.UnitType_isResourceContainer(jarg1.Handle);
}


public static bool UnitType_isResourceDepot(HandleRef jarg1) {
  return remote.UnitType_isResourceDepot(jarg1.Handle);
}


public static bool UnitType_isRefinery(HandleRef jarg1) {
  return remote.UnitType_isRefinery(jarg1.Handle);
}


public static bool UnitType_isWorker(HandleRef jarg1) {
  return remote.UnitType_isWorker(jarg1.Handle);
}


public static bool UnitType_requiresPsi(HandleRef jarg1) {
  return remote.UnitType_requiresPsi(jarg1.Handle);
}


public static bool UnitType_requiresCreep(HandleRef jarg1) {
  return remote.UnitType_requiresCreep(jarg1.Handle);
}


public static bool UnitType_isTwoUnitsInOneEgg(HandleRef jarg1) {
  return remote.UnitType_isTwoUnitsInOneEgg(jarg1.Handle);
}


public static bool UnitType_isBurrowable(HandleRef jarg1) {
  return remote.UnitType_isBurrowable(jarg1.Handle);
}


public static bool UnitType_isCloakable(HandleRef jarg1) {
  return remote.UnitType_isCloakable(jarg1.Handle);
}


public static bool UnitType_isBuilding(HandleRef jarg1) {
  return remote.UnitType_isBuilding(jarg1.Handle);
}


public static bool UnitType_isAddon(HandleRef jarg1) {
  return remote.UnitType_isAddon(jarg1.Handle);
}


public static bool UnitType_isFlyingBuilding(HandleRef jarg1) {
  return remote.UnitType_isFlyingBuilding(jarg1.Handle);
}


public static bool UnitType_isNeutral(HandleRef jarg1) {
  return remote.UnitType_isNeutral(jarg1.Handle);
}


public static void delete_UnitType(HandleRef jarg1) {
  remote.delete_UnitType(jarg1.Handle);
}


public static IntPtr getUnitType(string jarg1) {
  return remote.getUnitType(jarg1);
}


public static IntPtr allUnitTypes() {
  return remote.allUnitTypes();
}


public static void initUnitTypes() {
  remote.initUnitTypes();
}


public static IntPtr Terran_Marine_get() {
  return remote.Terran_Marine_get();
}


public static IntPtr Terran_Ghost_get() {
  return remote.Terran_Ghost_get();
}


public static IntPtr Terran_Vulture_get() {
  return remote.Terran_Vulture_get();
}


public static IntPtr Terran_Goliath_get() {
  return remote.Terran_Goliath_get();
}


public static IntPtr Terran_Siege_Tank_Tank_Mode_get() {
  return remote.Terran_Siege_Tank_Tank_Mode_get();
}


public static IntPtr Terran_SCV_get() {
  return remote.Terran_SCV_get();
}


public static IntPtr Terran_Wraith_get() {
  return remote.Terran_Wraith_get();
}


public static IntPtr Terran_Science_Vessel_get() {
  return remote.Terran_Science_Vessel_get();
}


public static IntPtr Terran_Dropship_get() {
  return remote.Terran_Dropship_get();
}


public static IntPtr Terran_Battlecruiser_get() {
  return remote.Terran_Battlecruiser_get();
}


public static IntPtr Terran_Vulture_Spider_Mine_get() {
  return remote.Terran_Vulture_Spider_Mine_get();
}


public static IntPtr Terran_Nuclear_Missile_get() {
  return remote.Terran_Nuclear_Missile_get();
}


public static IntPtr Terran_Siege_Tank_Siege_Mode_get() {
  return remote.Terran_Siege_Tank_Siege_Mode_get();
}


public static IntPtr Terran_Firebat_get() {
  return remote.Terran_Firebat_get();
}


public static IntPtr Spell_Scanner_Sweep_get() {
  return remote.Spell_Scanner_Sweep_get();
}


public static IntPtr Terran_Medic_get() {
  return remote.Terran_Medic_get();
}


public static IntPtr Zerg_Larva_get() {
  return remote.Zerg_Larva_get();
}


public static IntPtr Zerg_Egg_get() {
  return remote.Zerg_Egg_get();
}


public static IntPtr Zerg_Zergling_get() {
  return remote.Zerg_Zergling_get();
}


public static IntPtr Zerg_Hydralisk_get() {
  return remote.Zerg_Hydralisk_get();
}


public static IntPtr Zerg_Ultralisk_get() {
  return remote.Zerg_Ultralisk_get();
}


public static IntPtr Zerg_Broodling_get() {
  return remote.Zerg_Broodling_get();
}


public static IntPtr Zerg_Drone_get() {
  return remote.Zerg_Drone_get();
}


public static IntPtr Zerg_Overlord_get() {
  return remote.Zerg_Overlord_get();
}


public static IntPtr Zerg_Mutalisk_get() {
  return remote.Zerg_Mutalisk_get();
}


public static IntPtr Zerg_Guardian_get() {
  return remote.Zerg_Guardian_get();
}


public static IntPtr Zerg_Queen_get() {
  return remote.Zerg_Queen_get();
}


public static IntPtr Zerg_Defiler_get() {
  return remote.Zerg_Defiler_get();
}


public static IntPtr Zerg_Scourge_get() {
  return remote.Zerg_Scourge_get();
}


public static IntPtr Zerg_Infested_Terran_get() {
  return remote.Zerg_Infested_Terran_get();
}


public static IntPtr Terran_Valkyrie_get() {
  return remote.Terran_Valkyrie_get();
}


public static IntPtr Zerg_Cocoon_get() {
  return remote.Zerg_Cocoon_get();
}


public static IntPtr Protoss_Corsair_get() {
  return remote.Protoss_Corsair_get();
}


public static IntPtr Protoss_Dark_Templar_get() {
  return remote.Protoss_Dark_Templar_get();
}


public static IntPtr Zerg_Devourer_get() {
  return remote.Zerg_Devourer_get();
}


public static IntPtr Protoss_Dark_Archon_get() {
  return remote.Protoss_Dark_Archon_get();
}


public static IntPtr Protoss_Probe_get() {
  return remote.Protoss_Probe_get();
}


public static IntPtr Protoss_Zealot_get() {
  return remote.Protoss_Zealot_get();
}


public static IntPtr Protoss_Dragoon_get() {
  return remote.Protoss_Dragoon_get();
}


public static IntPtr Protoss_High_Templar_get() {
  return remote.Protoss_High_Templar_get();
}


public static IntPtr Protoss_Archon_get() {
  return remote.Protoss_Archon_get();
}


public static IntPtr Protoss_Shuttle_get() {
  return remote.Protoss_Shuttle_get();
}


public static IntPtr Protoss_Scout_get() {
  return remote.Protoss_Scout_get();
}


public static IntPtr Protoss_Arbiter_get() {
  return remote.Protoss_Arbiter_get();
}


public static IntPtr Protoss_Carrier_get() {
  return remote.Protoss_Carrier_get();
}


public static IntPtr Protoss_Interceptor_get() {
  return remote.Protoss_Interceptor_get();
}


public static IntPtr Protoss_Reaver_get() {
  return remote.Protoss_Reaver_get();
}


public static IntPtr Protoss_Observer_get() {
  return remote.Protoss_Observer_get();
}


public static IntPtr Protoss_Scarab_get() {
  return remote.Protoss_Scarab_get();
}


public static IntPtr Critter_Rhynadon_get() {
  return remote.Critter_Rhynadon_get();
}


public static IntPtr Critter_Bengalaas_get() {
  return remote.Critter_Bengalaas_get();
}


public static IntPtr Critter_Scantid_get() {
  return remote.Critter_Scantid_get();
}


public static IntPtr Critter_Kakaru_get() {
  return remote.Critter_Kakaru_get();
}


public static IntPtr Critter_Ragnasaur_get() {
  return remote.Critter_Ragnasaur_get();
}


public static IntPtr Critter_Ursadon_get() {
  return remote.Critter_Ursadon_get();
}


public static IntPtr Zerg_Lurker_Egg_get() {
  return remote.Zerg_Lurker_Egg_get();
}


public static IntPtr Zerg_Lurker_get() {
  return remote.Zerg_Lurker_get();
}


public static IntPtr Spell_Disruption_Web_get() {
  return remote.Spell_Disruption_Web_get();
}


public static IntPtr Terran_Command_Center_get() {
  return remote.Terran_Command_Center_get();
}


public static IntPtr Terran_Comsat_Station_get() {
  return remote.Terran_Comsat_Station_get();
}


public static IntPtr Terran_Nuclear_Silo_get() {
  return remote.Terran_Nuclear_Silo_get();
}


public static IntPtr Terran_Supply_Depot_get() {
  return remote.Terran_Supply_Depot_get();
}


public static IntPtr Terran_Refinery_get() {
  return remote.Terran_Refinery_get();
}


public static IntPtr Terran_Barracks_get() {
  return remote.Terran_Barracks_get();
}


public static IntPtr Terran_Academy_get() {
  return remote.Terran_Academy_get();
}


public static IntPtr Terran_Factory_get() {
  return remote.Terran_Factory_get();
}


public static IntPtr Terran_Starport_get() {
  return remote.Terran_Starport_get();
}


public static IntPtr Terran_Control_Tower_get() {
  return remote.Terran_Control_Tower_get();
}


public static IntPtr Terran_Science_Facility_get() {
  return remote.Terran_Science_Facility_get();
}


public static IntPtr Terran_Covert_Ops_get() {
  return remote.Terran_Covert_Ops_get();
}


public static IntPtr Terran_Physics_Lab_get() {
  return remote.Terran_Physics_Lab_get();
}


public static IntPtr Terran_Machine_Shop_get() {
  return remote.Terran_Machine_Shop_get();
}


public static IntPtr Terran_Engineering_Bay_get() {
  return remote.Terran_Engineering_Bay_get();
}


public static IntPtr Terran_Armory_get() {
  return remote.Terran_Armory_get();
}


public static IntPtr Terran_Missile_Turret_get() {
  return remote.Terran_Missile_Turret_get();
}


public static IntPtr Terran_Bunker_get() {
  return remote.Terran_Bunker_get();
}


public static IntPtr Special_Crashed_Norad_II_get() {
  return remote.Special_Crashed_Norad_II_get();
}


public static IntPtr Special_Ion_Cannon_get() {
  return remote.Special_Ion_Cannon_get();
}


public static IntPtr Zerg_Infested_Command_Center_get() {
  return remote.Zerg_Infested_Command_Center_get();
}


public static IntPtr Zerg_Hatchery_get() {
  return remote.Zerg_Hatchery_get();
}


public static IntPtr Zerg_Lair_get() {
  return remote.Zerg_Lair_get();
}


public static IntPtr Zerg_Hive_get() {
  return remote.Zerg_Hive_get();
}


public static IntPtr Zerg_Nydus_Canal_get() {
  return remote.Zerg_Nydus_Canal_get();
}


public static IntPtr Zerg_Hydralisk_Den_get() {
  return remote.Zerg_Hydralisk_Den_get();
}


public static IntPtr Zerg_Defiler_Mound_get() {
  return remote.Zerg_Defiler_Mound_get();
}


public static IntPtr Zerg_Greater_Spire_get() {
  return remote.Zerg_Greater_Spire_get();
}


public static IntPtr Zerg_Queens_Nest_get() {
  return remote.Zerg_Queens_Nest_get();
}


public static IntPtr Zerg_Evolution_Chamber_get() {
  return remote.Zerg_Evolution_Chamber_get();
}


public static IntPtr Zerg_Ultralisk_Cavern_get() {
  return remote.Zerg_Ultralisk_Cavern_get();
}


public static IntPtr Zerg_Spire_get() {
  return remote.Zerg_Spire_get();
}


public static IntPtr Zerg_Spawning_Pool_get() {
  return remote.Zerg_Spawning_Pool_get();
}


public static IntPtr Zerg_Creep_Colony_get() {
  return remote.Zerg_Creep_Colony_get();
}


public static IntPtr Zerg_Spore_Colony_get() {
  return remote.Zerg_Spore_Colony_get();
}


public static IntPtr Zerg_Sunken_Colony_get() {
  return remote.Zerg_Sunken_Colony_get();
}


public static IntPtr Special_Overmind_With_Shell_get() {
  return remote.Special_Overmind_With_Shell_get();
}


public static IntPtr Special_Overmind_get() {
  return remote.Special_Overmind_get();
}


public static IntPtr Zerg_Extractor_get() {
  return remote.Zerg_Extractor_get();
}


public static IntPtr Special_Mature_Chrysalis_get() {
  return remote.Special_Mature_Chrysalis_get();
}


public static IntPtr Special_Cerebrate_get() {
  return remote.Special_Cerebrate_get();
}


public static IntPtr Special_Cerebrate_Daggoth_get() {
  return remote.Special_Cerebrate_Daggoth_get();
}


public static IntPtr Protoss_Nexus_get() {
  return remote.Protoss_Nexus_get();
}


public static IntPtr Protoss_Robotics_Facility_get() {
  return remote.Protoss_Robotics_Facility_get();
}


public static IntPtr Protoss_Pylon_get() {
  return remote.Protoss_Pylon_get();
}


public static IntPtr Protoss_Assimilator_get() {
  return remote.Protoss_Assimilator_get();
}


public static IntPtr Protoss_Observatory_get() {
  return remote.Protoss_Observatory_get();
}


public static IntPtr Protoss_Gateway_get() {
  return remote.Protoss_Gateway_get();
}


public static IntPtr Protoss_Photon_Cannon_get() {
  return remote.Protoss_Photon_Cannon_get();
}


public static IntPtr Protoss_Citadel_of_Adun_get() {
  return remote.Protoss_Citadel_of_Adun_get();
}


public static IntPtr Protoss_Cybernetics_Core_get() {
  return remote.Protoss_Cybernetics_Core_get();
}


public static IntPtr Protoss_Templar_Archives_get() {
  return remote.Protoss_Templar_Archives_get();
}


public static IntPtr Protoss_Forge_get() {
  return remote.Protoss_Forge_get();
}


public static IntPtr Protoss_Stargate_get() {
  return remote.Protoss_Stargate_get();
}


public static IntPtr Special_Stasis_Cell_Prison_get() {
  return remote.Special_Stasis_Cell_Prison_get();
}


public static IntPtr Protoss_Fleet_Beacon_get() {
  return remote.Protoss_Fleet_Beacon_get();
}


public static IntPtr Protoss_Arbiter_Tribunal_get() {
  return remote.Protoss_Arbiter_Tribunal_get();
}


public static IntPtr Protoss_Robotics_Support_Bay_get() {
  return remote.Protoss_Robotics_Support_Bay_get();
}


public static IntPtr Protoss_Shield_Battery_get() {
  return remote.Protoss_Shield_Battery_get();
}


public static IntPtr Special_Khaydarin_Crystal_Form_get() {
  return remote.Special_Khaydarin_Crystal_Form_get();
}


public static IntPtr Special_Protoss_Temple_get() {
  return remote.Special_Protoss_Temple_get();
}


public static IntPtr Special_XelNaga_Temple_get() {
  return remote.Special_XelNaga_Temple_get();
}


public static IntPtr Resource_Mineral_Field_get() {
  return remote.Resource_Mineral_Field_get();
}


public static IntPtr Resource_Vespene_Geyser_get() {
  return remote.Resource_Vespene_Geyser_get();
}


public static IntPtr Special_Warp_Gate_get() {
  return remote.Special_Warp_Gate_get();
}


public static IntPtr Special_Psi_Disrupter_get() {
  return remote.Special_Psi_Disrupter_get();
}


public static IntPtr Special_Power_Generator_get() {
  return remote.Special_Power_Generator_get();
}


public static IntPtr Special_Overmind_Cocoon_get() {
  return remote.Special_Overmind_Cocoon_get();
}


public static IntPtr Spell_Dark_Swarm_get() {
  return remote.Spell_Dark_Swarm_get();
}


public static IntPtr UnitTypeNone_get() {
  return remote.UnitTypeNone_get();
}


public static IntPtr UnitTypeUnknown_get() {
  return remote.UnitTypeUnknown_get();
}


public static IntPtr new_WeaponType__SWIG_0() {
  return remote.new_WeaponType__SWIG_0();
}


public static IntPtr new_WeaponType__SWIG_1(int jarg1) {
  return remote.new_WeaponType__SWIG_1(jarg1);
}


public static IntPtr new_WeaponType__SWIG_2(HandleRef jarg1) {
  return remote.new_WeaponType__SWIG_2(jarg1.Handle);
}


public static IntPtr WeaponType_opAssign(HandleRef jarg1, HandleRef jarg2) {
  return remote.WeaponType_opAssign(jarg1.Handle, jarg2.Handle);
}


public static bool WeaponType_opEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.WeaponType_opEquals(jarg1.Handle, jarg2.Handle);
}


public static bool WeaponType_opNotEquals(HandleRef jarg1, HandleRef jarg2) {
  return remote.WeaponType_opNotEquals(jarg1.Handle, jarg2.Handle);
}


public static bool WeaponType_opLessThan(HandleRef jarg1, HandleRef jarg2) {
  return remote.WeaponType_opLessThan(jarg1.Handle, jarg2.Handle);
}


public static int WeaponType_getID(HandleRef jarg1) {
  return remote.WeaponType_getID(jarg1.Handle);
}


public static string WeaponType_getName(HandleRef jarg1) {
  return remote.WeaponType_getName(jarg1.Handle);
}


public static IntPtr WeaponType_getTech(HandleRef jarg1) {
  return remote.WeaponType_getTech(jarg1.Handle);
}


public static IntPtr WeaponType_whatUses(HandleRef jarg1) {
  return remote.WeaponType_whatUses(jarg1.Handle);
}


public static int WeaponType_damageAmount(HandleRef jarg1) {
  return remote.WeaponType_damageAmount(jarg1.Handle);
}


public static int WeaponType_damageBonus(HandleRef jarg1) {
  return remote.WeaponType_damageBonus(jarg1.Handle);
}


public static int WeaponType_damageCooldown(HandleRef jarg1) {
  return remote.WeaponType_damageCooldown(jarg1.Handle);
}


public static int WeaponType_damageFactor(HandleRef jarg1) {
  return remote.WeaponType_damageFactor(jarg1.Handle);
}


public static IntPtr WeaponType_upgradeType(HandleRef jarg1) {
  return remote.WeaponType_upgradeType(jarg1.Handle);
}


public static IntPtr WeaponType_damageType(HandleRef jarg1) {
  return remote.WeaponType_damageType(jarg1.Handle);
}


public static IntPtr WeaponType_explosionType(HandleRef jarg1) {
  return remote.WeaponType_explosionType(jarg1.Handle);
}


public static int WeaponType_minRange(HandleRef jarg1) {
  return remote.WeaponType_minRange(jarg1.Handle);
}


public static int WeaponType_maxRange(HandleRef jarg1) {
  return remote.WeaponType_maxRange(jarg1.Handle);
}


public static int WeaponType_innerSplashRadius(HandleRef jarg1) {
  return remote.WeaponType_innerSplashRadius(jarg1.Handle);
}


public static int WeaponType_medianSplashRadius(HandleRef jarg1) {
  return remote.WeaponType_medianSplashRadius(jarg1.Handle);
}


public static int WeaponType_outerSplashRadius(HandleRef jarg1) {
  return remote.WeaponType_outerSplashRadius(jarg1.Handle);
}


public static bool WeaponType_targetsAir(HandleRef jarg1) {
  return remote.WeaponType_targetsAir(jarg1.Handle);
}


public static bool WeaponType_targetsGround(HandleRef jarg1) {
  return remote.WeaponType_targetsGround(jarg1.Handle);
}


public static bool WeaponType_targetsMechanical(HandleRef jarg1) {
  return remote.WeaponType_targetsMechanical(jarg1.Handle);
}


public static bool WeaponType_targetsOrganic(HandleRef jarg1) {
  return remote.WeaponType_targetsOrganic(jarg1.Handle);
}


public static bool WeaponType_targetsNonBuilding(HandleRef jarg1) {
  return remote.WeaponType_targetsNonBuilding(jarg1.Handle);
}


public static bool WeaponType_targetsNonRobotic(HandleRef jarg1) {
  return remote.WeaponType_targetsNonRobotic(jarg1.Handle);
}


public static bool WeaponType_targetsTerrain(HandleRef jarg1) {
  return remote.WeaponType_targetsTerrain(jarg1.Handle);
}


public static bool WeaponType_targetsOrgOrMech(HandleRef jarg1) {
  return remote.WeaponType_targetsOrgOrMech(jarg1.Handle);
}


public static bool WeaponType_targetsOwn(HandleRef jarg1) {
  return remote.WeaponType_targetsOwn(jarg1.Handle);
}


public static void delete_WeaponType(HandleRef jarg1) {
  remote.delete_WeaponType(jarg1.Handle);
}


public static IntPtr getWeaponType(string jarg1) {
  return remote.getWeaponType(jarg1);
}


public static IntPtr allWeaponTypes() {
  return remote.allWeaponTypes();
}


public static IntPtr normalWeaponTypes() {
  return remote.normalWeaponTypes();
}


public static IntPtr specialWeaponTypes() {
  return remote.specialWeaponTypes();
}


public static void initWeaponTypes() {
  remote.initWeaponTypes();
}


public static IntPtr Gauss_Rifle_get() {
  return remote.Gauss_Rifle_get();
}


public static IntPtr C_10_Canister_Rifle_get() {
  return remote.C_10_Canister_Rifle_get();
}


public static IntPtr WeaponTypeFragmentation_Grenade_get() {
  return remote.WeaponTypeFragmentation_Grenade_get();
}


public static IntPtr WeaponTypeSpider_Mines_get() {
  return remote.WeaponTypeSpider_Mines_get();
}


public static IntPtr Twin_Autocannons_get() {
  return remote.Twin_Autocannons_get();
}


public static IntPtr Hellfire_Missile_Pack_get() {
  return remote.Hellfire_Missile_Pack_get();
}


public static IntPtr Arclite_Cannon_get() {
  return remote.Arclite_Cannon_get();
}


public static IntPtr Fusion_Cutter_get() {
  return remote.Fusion_Cutter_get();
}


public static IntPtr WeaponTypeGemini_Missiles_get() {
  return remote.WeaponTypeGemini_Missiles_get();
}


public static IntPtr WeaponTypeBurst_Lasers_get() {
  return remote.WeaponTypeBurst_Lasers_get();
}


public static IntPtr ATS_Laser_Battery_get() {
  return remote.ATS_Laser_Battery_get();
}


public static IntPtr ATA_Laser_Battery_get() {
  return remote.ATA_Laser_Battery_get();
}


public static IntPtr Flame_Thrower_get() {
  return remote.Flame_Thrower_get();
}


public static IntPtr Arclite_Shock_Cannon_get() {
  return remote.Arclite_Shock_Cannon_get();
}


public static IntPtr WeaponTypeLongbolt_Missile_get() {
  return remote.WeaponTypeLongbolt_Missile_get();
}


public static IntPtr Claws_get() {
  return remote.Claws_get();
}


public static IntPtr Needle_Spines_get() {
  return remote.Needle_Spines_get();
}


public static IntPtr Kaiser_Blades_get() {
  return remote.Kaiser_Blades_get();
}


public static IntPtr Toxic_Spores_get() {
  return remote.Toxic_Spores_get();
}


public static IntPtr Spines_get() {
  return remote.Spines_get();
}


public static IntPtr WeaponTypeAcid_Spore_get() {
  return remote.WeaponTypeAcid_Spore_get();
}


public static IntPtr WeaponTypeGlave_Wurm_get() {
  return remote.WeaponTypeGlave_Wurm_get();
}


public static IntPtr WeaponTypeSeeker_Spores_get() {
  return remote.WeaponTypeSeeker_Spores_get();
}


public static IntPtr Subterranean_Tentacle_get() {
  return remote.Subterranean_Tentacle_get();
}


public static IntPtr Suicide_Infested_Terran_get() {
  return remote.Suicide_Infested_Terran_get();
}


public static IntPtr Suicide_Scourge_get() {
  return remote.Suicide_Scourge_get();
}


public static IntPtr Particle_Beam_get() {
  return remote.Particle_Beam_get();
}


public static IntPtr Psi_Blades_get() {
  return remote.Psi_Blades_get();
}


public static IntPtr WeaponTypePhase_Disruptor_get() {
  return remote.WeaponTypePhase_Disruptor_get();
}


public static IntPtr Psionic_Shockwave_get() {
  return remote.Psionic_Shockwave_get();
}


public static IntPtr Dual_Photon_Blasters_get() {
  return remote.Dual_Photon_Blasters_get();
}


public static IntPtr Anti_Matter_Missiles_get() {
  return remote.Anti_Matter_Missiles_get();
}


public static IntPtr Phase_Disruptor_Cannon_get() {
  return remote.Phase_Disruptor_Cannon_get();
}


public static IntPtr WeaponTypePulse_Cannon_get() {
  return remote.WeaponTypePulse_Cannon_get();
}


public static IntPtr STS_Photon_Cannon_get() {
  return remote.STS_Photon_Cannon_get();
}


public static IntPtr STA_Photon_Cannon_get() {
  return remote.STA_Photon_Cannon_get();
}


public static IntPtr Scarab_get() {
  return remote.Scarab_get();
}


public static IntPtr WeaponTypeNeutron_Flare_get() {
  return remote.WeaponTypeNeutron_Flare_get();
}


public static IntPtr WeaponTypeHalo_Rockets_get() {
  return remote.WeaponTypeHalo_Rockets_get();
}


public static IntPtr WeaponTypeCorrosive_Acid_get() {
  return remote.WeaponTypeCorrosive_Acid_get();
}


public static IntPtr WeaponTypeSubterranean_Spines_get() {
  return remote.WeaponTypeSubterranean_Spines_get();
}


public static IntPtr Warp_Blades_get() {
  return remote.Warp_Blades_get();
}


public static IntPtr WeaponTypeYamato_Gun_get() {
  return remote.WeaponTypeYamato_Gun_get();
}


public static IntPtr WeaponTypeNuclear_Strike_get() {
  return remote.WeaponTypeNuclear_Strike_get();
}


public static IntPtr Lockdown_get() {
  return remote.Lockdown_get();
}


public static IntPtr EMP_Shockwave_get() {
  return remote.EMP_Shockwave_get();
}


public static IntPtr WeaponTypeIrradiate_get() {
  return remote.WeaponTypeIrradiate_get();
}


public static IntPtr Parasite_get() {
  return remote.Parasite_get();
}


public static IntPtr Spawn_Broodlings_get() {
  return remote.Spawn_Broodlings_get();
}


public static IntPtr WeaponTypeEnsnare_get() {
  return remote.WeaponTypeEnsnare_get();
}


public static IntPtr Dark_Swarm_get() {
  return remote.Dark_Swarm_get();
}


public static IntPtr WeaponTypePlague_get() {
  return remote.WeaponTypePlague_get();
}


public static IntPtr WeaponTypeConsume_get() {
  return remote.WeaponTypeConsume_get();
}


public static IntPtr Stasis_Field_get() {
  return remote.Stasis_Field_get();
}


public static IntPtr WeaponTypePsionic_Storm_get() {
  return remote.WeaponTypePsionic_Storm_get();
}


public static IntPtr Disruption_Web_get() {
  return remote.Disruption_Web_get();
}


public static IntPtr WeaponTypeRestoration_get() {
  return remote.WeaponTypeRestoration_get();
}


public static IntPtr WeaponTypeMind_Control_get() {
  return remote.WeaponTypeMind_Control_get();
}


public static IntPtr Feedback_get() {
  return remote.Feedback_get();
}


public static IntPtr Optical_Flare_get() {
  return remote.Optical_Flare_get();
}


public static IntPtr Maelstrom_get() {
  return remote.Maelstrom_get();
}


public static IntPtr WeaponTypeNone_get() {
  return remote.WeaponTypeNone_get();
}


public static IntPtr WeaponTypeUnknown_get() {
  return remote.WeaponTypeUnknown_get();
}


public static IntPtr monobridgeutil_getLastUnitParam() {
  return remote.monobridgeutil_getLastUnitParam();
}


public static IntPtr new_monobridgeutil() {
  return remote.new_monobridgeutil();
}


public static void delete_monobridgeutil(HandleRef jarg1) {
  remote.delete_monobridgeutil(jarg1.Handle);
}


public static IntPtr new_RectangleArrayDouble__SWIG_0(uint jarg1, uint jarg2, HandleRef jarg3) {
  return remote.new_RectangleArrayDouble__SWIG_0(jarg1, jarg2, jarg3.Handle);
}


public static IntPtr new_RectangleArrayDouble__SWIG_1(uint jarg1, uint jarg2) {
  return remote.new_RectangleArrayDouble__SWIG_1(jarg1, jarg2);
}


public static IntPtr new_RectangleArrayDouble__SWIG_2(uint jarg1) {
  return remote.new_RectangleArrayDouble__SWIG_2(jarg1);
}


public static IntPtr new_RectangleArrayDouble__SWIG_3() {
  return remote.new_RectangleArrayDouble__SWIG_3();
}


public static IntPtr new_RectangleArrayDouble__SWIG_4(HandleRef jarg1) {
  return remote.new_RectangleArrayDouble__SWIG_4(jarg1.Handle);
}


public static void delete_RectangleArrayDouble(HandleRef jarg1) {
  remote.delete_RectangleArrayDouble(jarg1.Handle);
}


public static uint RectangleArrayDouble_getWidth(HandleRef jarg1) {
  return remote.RectangleArrayDouble_getWidth(jarg1.Handle);
}


public static uint RectangleArrayDouble_getHeight(HandleRef jarg1) {
  return remote.RectangleArrayDouble_getHeight(jarg1.Handle);
}


public static IntPtr RectangleArrayDouble_getItem(HandleRef jarg1, uint jarg2, uint jarg3) {
  return remote.RectangleArrayDouble_getItem(jarg1.Handle, jarg2, jarg3);
}


public static void RectangleArrayDouble_setItem(HandleRef jarg1, uint jarg2, uint jarg3, HandleRef jarg4) {
  remote.RectangleArrayDouble_setItem(jarg1.Handle, jarg2, jarg3, jarg4.Handle);
}


public static void RectangleArrayDouble_resize(HandleRef jarg1, uint jarg2, uint jarg3) {
  remote.RectangleArrayDouble_resize(jarg1.Handle, jarg2, jarg3);
}


public static void RectangleArrayDouble_printToFile(HandleRef jarg1, HandleRef jarg2) {
  remote.RectangleArrayDouble_printToFile(jarg1.Handle, jarg2.Handle);
}


public static void RectangleArrayDouble_saveToFile(HandleRef jarg1, string jarg2) {
  remote.RectangleArrayDouble_saveToFile(jarg1.Handle, jarg2);
}


public static void RectangleArrayDouble_setTo(HandleRef jarg1, double jarg2) {
  remote.RectangleArrayDouble_setTo(jarg1.Handle, jarg2);
}


public static void RectangleArrayDouble_setBorderTo(HandleRef jarg1, double jarg2) {
  remote.RectangleArrayDouble_setBorderTo(jarg1.Handle, jarg2);
}


public static void readMap() {
  remote.readMap();
}


public static void analyze() {
  remote.analyze();
}


public static IntPtr getRegions() {
  return remote.getRegions();
}


public static IntPtr getChokepoints() {
  return remote.getChokepoints();
}


public static IntPtr getBaseLocations() {
  return remote.getBaseLocations();
}


public static IntPtr getStartLocations() {
  return remote.getStartLocations();
}


public static IntPtr getUnwalkablePolygons() {
  return remote.getUnwalkablePolygons();
}


public static IntPtr getStartLocation(HandleRef jarg1) {
  return remote.getStartLocation(jarg1.Handle);
}


public static IntPtr getRegion__SWIG_0(int jarg1, int jarg2) {
  return remote.getRegion__SWIG_0(jarg1, jarg2);
}


public static IntPtr getRegion__SWIG_1(HandleRef jarg1) {
  return remote.getRegion__SWIG_1(jarg1.Handle);
}


public static IntPtr getNearestChokepoint__SWIG_0(int jarg1, int jarg2) {
  return remote.getNearestChokepoint__SWIG_0(jarg1, jarg2);
}


public static IntPtr getNearestChokepoint__SWIG_1(HandleRef jarg1) {
  return remote.getNearestChokepoint__SWIG_1(jarg1.Handle);
}


public static IntPtr getNearestBaseLocation__SWIG_0(int jarg1, int jarg2) {
  return remote.getNearestBaseLocation__SWIG_0(jarg1, jarg2);
}


public static IntPtr getNearestBaseLocation__SWIG_1(HandleRef jarg1) {
  return remote.getNearestBaseLocation__SWIG_1(jarg1.Handle);
}


public static IntPtr getNearestUnwalkablePolygon__SWIG_0(int jarg1, int jarg2) {
  return remote.getNearestUnwalkablePolygon__SWIG_0(jarg1, jarg2);
}


public static IntPtr getNearestUnwalkablePolygon__SWIG_1(HandleRef jarg1) {
  return remote.getNearestUnwalkablePolygon__SWIG_1(jarg1.Handle);
}


public static IntPtr getNearestUnwalkablePosition(HandleRef jarg1) {
  return remote.getNearestUnwalkablePosition(jarg1.Handle);
}


public static bool isConnected__SWIG_0(int jarg1, int jarg2, int jarg3, int jarg4) {
  return remote.isConnected__SWIG_0(jarg1, jarg2, jarg3, jarg4);
}


public static bool isConnected__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return remote.isConnected__SWIG_1(jarg1.Handle, jarg2.Handle);
}


public static double getGroundDistance(HandleRef jarg1, HandleRef jarg2) {
  return remote.getGroundDistance(jarg1.Handle, jarg2.Handle);
}


public static IntPtr getNearestTilePosition(HandleRef jarg1, HandleRef jarg2) {
  return remote.getNearestTilePosition(jarg1.Handle, jarg2.Handle);
}


public static IntPtr getGroundDistances(HandleRef jarg1, HandleRef jarg2) {
  return remote.getGroundDistances(jarg1.Handle, jarg2.Handle);
}


public static void getGroundDistanceMap(HandleRef jarg1, HandleRef jarg2) {
  remote.getGroundDistanceMap(jarg1.Handle, jarg2.Handle);
}


public static IntPtr getShortestPath__SWIG_0(HandleRef jarg1, HandleRef jarg2) {
  return remote.getShortestPath__SWIG_0(jarg1.Handle, jarg2.Handle);
}


public static IntPtr getShortestPath__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return remote.getShortestPath__SWIG_1(jarg1.Handle, jarg2.Handle);
}


public static IntPtr BaseLocation_getPosition(HandleRef jarg1) {
  return remote.BaseLocation_getPosition(jarg1.Handle);
}


public static IntPtr BaseLocation_getTilePosition(HandleRef jarg1) {
  return remote.BaseLocation_getTilePosition(jarg1.Handle);
}


public static IntPtr BaseLocation_getRegion(HandleRef jarg1) {
  return remote.BaseLocation_getRegion(jarg1.Handle);
}


public static int BaseLocation_minerals(HandleRef jarg1) {
  return remote.BaseLocation_minerals(jarg1.Handle);
}


public static int BaseLocation_gas(HandleRef jarg1) {
  return remote.BaseLocation_gas(jarg1.Handle);
}


public static IntPtr BaseLocation_getMinerals(HandleRef jarg1) {
  return remote.BaseLocation_getMinerals(jarg1.Handle);
}


public static IntPtr BaseLocation_getStaticMinerals(HandleRef jarg1) {
  return remote.BaseLocation_getStaticMinerals(jarg1.Handle);
}


public static IntPtr BaseLocation_getGeysers(HandleRef jarg1) {
  return remote.BaseLocation_getGeysers(jarg1.Handle);
}


public static double BaseLocation_getGroundDistance(HandleRef jarg1, HandleRef jarg2) {
  return remote.BaseLocation_getGroundDistance(jarg1.Handle, jarg2.Handle);
}


public static double BaseLocation_getAirDistance(HandleRef jarg1, HandleRef jarg2) {
  return remote.BaseLocation_getAirDistance(jarg1.Handle, jarg2.Handle);
}


public static bool BaseLocation_isIsland(HandleRef jarg1) {
  return remote.BaseLocation_isIsland(jarg1.Handle);
}


public static bool BaseLocation_isMineralOnly(HandleRef jarg1) {
  return remote.BaseLocation_isMineralOnly(jarg1.Handle);
}


public static bool BaseLocation_isStartLocation(HandleRef jarg1) {
  return remote.BaseLocation_isStartLocation(jarg1.Handle);
}


public static void delete_BaseLocation(HandleRef jarg1) {
  remote.delete_BaseLocation(jarg1.Handle);
}


public static IntPtr Chokepoint_getRegions(HandleRef jarg1) {
  return remote.Chokepoint_getRegions(jarg1.Handle);
}


public static IntPtr Chokepoint_getSides(HandleRef jarg1) {
  return remote.Chokepoint_getSides(jarg1.Handle);
}


public static IntPtr Chokepoint_getCenter(HandleRef jarg1) {
  return remote.Chokepoint_getCenter(jarg1.Handle);
}


public static double Chokepoint_getWidth(HandleRef jarg1) {
  return remote.Chokepoint_getWidth(jarg1.Handle);
}


public static void delete_Chokepoint(HandleRef jarg1) {
  remote.delete_Chokepoint(jarg1.Handle);
}


public static void PositionVector_Clear(HandleRef jarg1) {
  remote.PositionVector_Clear(jarg1.Handle);
}


public static void PositionVector_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.PositionVector_Add(jarg1.Handle, jarg2.Handle);
}


public static uint PositionVector_size(HandleRef jarg1) {
  return remote.PositionVector_size(jarg1.Handle);
}


public static uint PositionVector_capacity(HandleRef jarg1) {
  return remote.PositionVector_capacity(jarg1.Handle);
}


public static void PositionVector_reserve(HandleRef jarg1, uint jarg2) {
  remote.PositionVector_reserve(jarg1.Handle, jarg2);
}


public static IntPtr new_PositionVector__SWIG_0() {
  return remote.new_PositionVector__SWIG_0();
}


public static IntPtr new_PositionVector__SWIG_1(HandleRef jarg1) {
  return remote.new_PositionVector__SWIG_1(jarg1.Handle);
}


public static IntPtr new_PositionVector__SWIG_2(int jarg1) {
  return remote.new_PositionVector__SWIG_2(jarg1);
}


public static IntPtr PositionVector_getitemcopy(HandleRef jarg1, int jarg2) {
  return remote.PositionVector_getitemcopy(jarg1.Handle, jarg2);
}


public static IntPtr PositionVector_getitem(HandleRef jarg1, int jarg2) {
  return remote.PositionVector_getitem(jarg1.Handle, jarg2);
}


public static void PositionVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3) {
  remote.PositionVector_setitem(jarg1.Handle, jarg2, jarg3.Handle);
}


public static void PositionVector_AddRange(HandleRef jarg1, HandleRef jarg2) {
  remote.PositionVector_AddRange(jarg1.Handle, jarg2.Handle);
}


public static IntPtr PositionVector_GetRange(HandleRef jarg1, int jarg2, int jarg3) {
  return remote.PositionVector_GetRange(jarg1.Handle, jarg2, jarg3);
}


public static void PositionVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3) {
  remote.PositionVector_Insert(jarg1.Handle, jarg2, jarg3.Handle);
}


public static void PositionVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3) {
  remote.PositionVector_InsertRange(jarg1.Handle, jarg2, jarg3.Handle);
}


public static void PositionVector_RemoveAt(HandleRef jarg1, int jarg2) {
  remote.PositionVector_RemoveAt(jarg1.Handle, jarg2);
}


public static void PositionVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3) {
  remote.PositionVector_RemoveRange(jarg1.Handle, jarg2, jarg3);
}


public static IntPtr PositionVector_Repeat(HandleRef jarg1, int jarg2) {
  return remote.PositionVector_Repeat(jarg1.Handle, jarg2);
}


public static void PositionVector_Reverse__SWIG_0(HandleRef jarg1) {
  remote.PositionVector_Reverse__SWIG_0(jarg1.Handle);
}


public static void PositionVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3) {
  remote.PositionVector_Reverse__SWIG_1(jarg1.Handle, jarg2, jarg3);
}


public static void PositionVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3) {
  remote.PositionVector_SetRange(jarg1.Handle, jarg2, jarg3.Handle);
}


public static void delete_PositionVector(HandleRef jarg1) {
  remote.delete_PositionVector(jarg1.Handle);
}


public static IntPtr new_Polygon() {
  return remote.new_Polygon();
}


public static double Polygon_getArea(HandleRef jarg1) {
  return remote.Polygon_getArea(jarg1.Handle);
}


public static double Polygon_getPerimeter(HandleRef jarg1) {
  return remote.Polygon_getPerimeter(jarg1.Handle);
}


public static IntPtr Polygon_getCenter(HandleRef jarg1) {
  return remote.Polygon_getCenter(jarg1.Handle);
}


public static bool Polygon_isInside(HandleRef jarg1, HandleRef jarg2) {
  return remote.Polygon_isInside(jarg1.Handle, jarg2.Handle);
}


public static IntPtr Polygon_getNearestPoint(HandleRef jarg1, HandleRef jarg2) {
  return remote.Polygon_getNearestPoint(jarg1.Handle, jarg2.Handle);
}


public static void delete_Polygon(HandleRef jarg1) {
  remote.delete_Polygon(jarg1.Handle);
}


public static IntPtr Region_getPolygon(HandleRef jarg1) {
  return remote.Region_getPolygon(jarg1.Handle);
}


public static IntPtr Region_getCenter(HandleRef jarg1) {
  return remote.Region_getCenter(jarg1.Handle);
}


public static IntPtr Region_getChokepoints(HandleRef jarg1) {
  return remote.Region_getChokepoints(jarg1.Handle);
}


public static IntPtr Region_getBaseLocations(HandleRef jarg1) {
  return remote.Region_getBaseLocations(jarg1.Handle);
}


public static bool Region_isReachable(HandleRef jarg1, HandleRef jarg2) {
  return remote.Region_isReachable(jarg1.Handle, jarg2.Handle);
}


public static IntPtr Region_getReachableRegions(HandleRef jarg1) {
  return remote.Region_getReachableRegions(jarg1.Handle);
}


public static void delete_Region(HandleRef jarg1) {
  remote.delete_Region(jarg1.Handle);
}


public static IntPtr new_UnitSet__SWIG_0() {
  return remote.new_UnitSet__SWIG_0();
}


public static IntPtr new_UnitSet__SWIG_1(HandleRef jarg1) {
  return remote.new_UnitSet__SWIG_1(jarg1.Handle);
}


public static uint UnitSet_size(HandleRef jarg1) {
  return remote.UnitSet_size(jarg1.Handle);
}


public static bool UnitSet_empty(HandleRef jarg1) {
  return remote.UnitSet_empty(jarg1.Handle);
}


public static void UnitSet_Clear(HandleRef jarg1) {
  remote.UnitSet_Clear(jarg1.Handle);
}


public static IntPtr UnitSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool UnitSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void UnitSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.UnitSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool UnitSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr UnitSet_create_iterator_begin(HandleRef jarg1) {
  return remote.UnitSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr UnitSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.UnitSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_UnitSet(HandleRef jarg1) {
  remote.delete_UnitSet(jarg1.Handle);
}


public static IntPtr new_AttackTypeSet__SWIG_0() {
  return remote.new_AttackTypeSet__SWIG_0();
}


public static IntPtr new_AttackTypeSet__SWIG_1(HandleRef jarg1) {
  return remote.new_AttackTypeSet__SWIG_1(jarg1.Handle);
}


public static uint AttackTypeSet_size(HandleRef jarg1) {
  return remote.AttackTypeSet_size(jarg1.Handle);
}


public static bool AttackTypeSet_empty(HandleRef jarg1) {
  return remote.AttackTypeSet_empty(jarg1.Handle);
}


public static void AttackTypeSet_Clear(HandleRef jarg1) {
  remote.AttackTypeSet_Clear(jarg1.Handle);
}


public static IntPtr AttackTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.AttackTypeSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool AttackTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.AttackTypeSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void AttackTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.AttackTypeSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool AttackTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.AttackTypeSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr AttackTypeSet_create_iterator_begin(HandleRef jarg1) {
  return remote.AttackTypeSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr AttackTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.AttackTypeSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_AttackTypeSet(HandleRef jarg1) {
  remote.delete_AttackTypeSet(jarg1.Handle);
}


public static IntPtr new_DamageTypeSet__SWIG_0() {
  return remote.new_DamageTypeSet__SWIG_0();
}


public static IntPtr new_DamageTypeSet__SWIG_1(HandleRef jarg1) {
  return remote.new_DamageTypeSet__SWIG_1(jarg1.Handle);
}


public static uint DamageTypeSet_size(HandleRef jarg1) {
  return remote.DamageTypeSet_size(jarg1.Handle);
}


public static bool DamageTypeSet_empty(HandleRef jarg1) {
  return remote.DamageTypeSet_empty(jarg1.Handle);
}


public static void DamageTypeSet_Clear(HandleRef jarg1) {
  remote.DamageTypeSet_Clear(jarg1.Handle);
}


public static IntPtr DamageTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.DamageTypeSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool DamageTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.DamageTypeSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void DamageTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.DamageTypeSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool DamageTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.DamageTypeSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr DamageTypeSet_create_iterator_begin(HandleRef jarg1) {
  return remote.DamageTypeSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr DamageTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.DamageTypeSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_DamageTypeSet(HandleRef jarg1) {
  remote.delete_DamageTypeSet(jarg1.Handle);
}


public static IntPtr new_ErrorSet__SWIG_0() {
  return remote.new_ErrorSet__SWIG_0();
}


public static IntPtr new_ErrorSet__SWIG_1(HandleRef jarg1) {
  return remote.new_ErrorSet__SWIG_1(jarg1.Handle);
}


public static uint ErrorSet_size(HandleRef jarg1) {
  return remote.ErrorSet_size(jarg1.Handle);
}


public static bool ErrorSet_empty(HandleRef jarg1) {
  return remote.ErrorSet_empty(jarg1.Handle);
}


public static void ErrorSet_Clear(HandleRef jarg1) {
  remote.ErrorSet_Clear(jarg1.Handle);
}


public static IntPtr ErrorSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.ErrorSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool ErrorSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.ErrorSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void ErrorSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.ErrorSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool ErrorSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.ErrorSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr ErrorSet_create_iterator_begin(HandleRef jarg1) {
  return remote.ErrorSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr ErrorSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.ErrorSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_ErrorSet(HandleRef jarg1) {
  remote.delete_ErrorSet(jarg1.Handle);
}


public static IntPtr new_ExplosionTypeSet__SWIG_0() {
  return remote.new_ExplosionTypeSet__SWIG_0();
}


public static IntPtr new_ExplosionTypeSet__SWIG_1(HandleRef jarg1) {
  return remote.new_ExplosionTypeSet__SWIG_1(jarg1.Handle);
}


public static uint ExplosionTypeSet_size(HandleRef jarg1) {
  return remote.ExplosionTypeSet_size(jarg1.Handle);
}


public static bool ExplosionTypeSet_empty(HandleRef jarg1) {
  return remote.ExplosionTypeSet_empty(jarg1.Handle);
}


public static void ExplosionTypeSet_Clear(HandleRef jarg1) {
  remote.ExplosionTypeSet_Clear(jarg1.Handle);
}


public static IntPtr ExplosionTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.ExplosionTypeSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool ExplosionTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.ExplosionTypeSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void ExplosionTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.ExplosionTypeSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool ExplosionTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.ExplosionTypeSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr ExplosionTypeSet_create_iterator_begin(HandleRef jarg1) {
  return remote.ExplosionTypeSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr ExplosionTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.ExplosionTypeSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_ExplosionTypeSet(HandleRef jarg1) {
  remote.delete_ExplosionTypeSet(jarg1.Handle);
}


public static IntPtr new_ForcePtrSet__SWIG_0() {
  return remote.new_ForcePtrSet__SWIG_0();
}


public static IntPtr new_ForcePtrSet__SWIG_1(HandleRef jarg1) {
  return remote.new_ForcePtrSet__SWIG_1(jarg1.Handle);
}


public static uint ForcePtrSet_size(HandleRef jarg1) {
  return remote.ForcePtrSet_size(jarg1.Handle);
}


public static bool ForcePtrSet_empty(HandleRef jarg1) {
  return remote.ForcePtrSet_empty(jarg1.Handle);
}


public static void ForcePtrSet_Clear(HandleRef jarg1) {
  remote.ForcePtrSet_Clear(jarg1.Handle);
}


public static IntPtr ForcePtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.ForcePtrSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool ForcePtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.ForcePtrSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void ForcePtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.ForcePtrSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool ForcePtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.ForcePtrSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr ForcePtrSet_create_iterator_begin(HandleRef jarg1) {
  return remote.ForcePtrSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr ForcePtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.ForcePtrSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_ForcePtrSet(HandleRef jarg1) {
  remote.delete_ForcePtrSet(jarg1.Handle);
}


public static IntPtr new_OrderSet__SWIG_0() {
  return remote.new_OrderSet__SWIG_0();
}


public static IntPtr new_OrderSet__SWIG_1(HandleRef jarg1) {
  return remote.new_OrderSet__SWIG_1(jarg1.Handle);
}


public static uint OrderSet_size(HandleRef jarg1) {
  return remote.OrderSet_size(jarg1.Handle);
}


public static bool OrderSet_empty(HandleRef jarg1) {
  return remote.OrderSet_empty(jarg1.Handle);
}


public static void OrderSet_Clear(HandleRef jarg1) {
  remote.OrderSet_Clear(jarg1.Handle);
}


public static IntPtr OrderSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.OrderSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool OrderSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.OrderSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void OrderSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.OrderSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool OrderSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.OrderSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr OrderSet_create_iterator_begin(HandleRef jarg1) {
  return remote.OrderSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr OrderSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.OrderSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_OrderSet(HandleRef jarg1) {
  remote.delete_OrderSet(jarg1.Handle);
}


public static IntPtr new_PlayerPtrSet__SWIG_0() {
  return remote.new_PlayerPtrSet__SWIG_0();
}


public static IntPtr new_PlayerPtrSet__SWIG_1(HandleRef jarg1) {
  return remote.new_PlayerPtrSet__SWIG_1(jarg1.Handle);
}


public static uint PlayerPtrSet_size(HandleRef jarg1) {
  return remote.PlayerPtrSet_size(jarg1.Handle);
}


public static bool PlayerPtrSet_empty(HandleRef jarg1) {
  return remote.PlayerPtrSet_empty(jarg1.Handle);
}


public static void PlayerPtrSet_Clear(HandleRef jarg1) {
  remote.PlayerPtrSet_Clear(jarg1.Handle);
}


public static IntPtr PlayerPtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.PlayerPtrSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool PlayerPtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.PlayerPtrSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void PlayerPtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.PlayerPtrSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool PlayerPtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.PlayerPtrSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr PlayerPtrSet_create_iterator_begin(HandleRef jarg1) {
  return remote.PlayerPtrSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr PlayerPtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.PlayerPtrSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_PlayerPtrSet(HandleRef jarg1) {
  remote.delete_PlayerPtrSet(jarg1.Handle);
}


public static IntPtr new_PlayerTypeSet__SWIG_0() {
  return remote.new_PlayerTypeSet__SWIG_0();
}


public static IntPtr new_PlayerTypeSet__SWIG_1(HandleRef jarg1) {
  return remote.new_PlayerTypeSet__SWIG_1(jarg1.Handle);
}


public static uint PlayerTypeSet_size(HandleRef jarg1) {
  return remote.PlayerTypeSet_size(jarg1.Handle);
}


public static bool PlayerTypeSet_empty(HandleRef jarg1) {
  return remote.PlayerTypeSet_empty(jarg1.Handle);
}


public static void PlayerTypeSet_Clear(HandleRef jarg1) {
  remote.PlayerTypeSet_Clear(jarg1.Handle);
}


public static IntPtr PlayerTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.PlayerTypeSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool PlayerTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.PlayerTypeSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void PlayerTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.PlayerTypeSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool PlayerTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.PlayerTypeSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr PlayerTypeSet_create_iterator_begin(HandleRef jarg1) {
  return remote.PlayerTypeSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr PlayerTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.PlayerTypeSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_PlayerTypeSet(HandleRef jarg1) {
  remote.delete_PlayerTypeSet(jarg1.Handle);
}


public static IntPtr new_RaceSet__SWIG_0() {
  return remote.new_RaceSet__SWIG_0();
}


public static IntPtr new_RaceSet__SWIG_1(HandleRef jarg1) {
  return remote.new_RaceSet__SWIG_1(jarg1.Handle);
}


public static uint RaceSet_size(HandleRef jarg1) {
  return remote.RaceSet_size(jarg1.Handle);
}


public static bool RaceSet_empty(HandleRef jarg1) {
  return remote.RaceSet_empty(jarg1.Handle);
}


public static void RaceSet_Clear(HandleRef jarg1) {
  remote.RaceSet_Clear(jarg1.Handle);
}


public static IntPtr RaceSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.RaceSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool RaceSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.RaceSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void RaceSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.RaceSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool RaceSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.RaceSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr RaceSet_create_iterator_begin(HandleRef jarg1) {
  return remote.RaceSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr RaceSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.RaceSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_RaceSet(HandleRef jarg1) {
  remote.delete_RaceSet(jarg1.Handle);
}


public static IntPtr new_TechTypePtrSet__SWIG_0() {
  return remote.new_TechTypePtrSet__SWIG_0();
}


public static IntPtr new_TechTypePtrSet__SWIG_1(HandleRef jarg1) {
  return remote.new_TechTypePtrSet__SWIG_1(jarg1.Handle);
}


public static uint TechTypePtrSet_size(HandleRef jarg1) {
  return remote.TechTypePtrSet_size(jarg1.Handle);
}


public static bool TechTypePtrSet_empty(HandleRef jarg1) {
  return remote.TechTypePtrSet_empty(jarg1.Handle);
}


public static void TechTypePtrSet_Clear(HandleRef jarg1) {
  remote.TechTypePtrSet_Clear(jarg1.Handle);
}


public static IntPtr TechTypePtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.TechTypePtrSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool TechTypePtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.TechTypePtrSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void TechTypePtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.TechTypePtrSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool TechTypePtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.TechTypePtrSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr TechTypePtrSet_create_iterator_begin(HandleRef jarg1) {
  return remote.TechTypePtrSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr TechTypePtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.TechTypePtrSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_TechTypePtrSet(HandleRef jarg1) {
  remote.delete_TechTypePtrSet(jarg1.Handle);
}


public static IntPtr new_TechTypeSet__SWIG_0() {
  return remote.new_TechTypeSet__SWIG_0();
}


public static IntPtr new_TechTypeSet__SWIG_1(HandleRef jarg1) {
  return remote.new_TechTypeSet__SWIG_1(jarg1.Handle);
}


public static uint TechTypeSet_size(HandleRef jarg1) {
  return remote.TechTypeSet_size(jarg1.Handle);
}


public static bool TechTypeSet_empty(HandleRef jarg1) {
  return remote.TechTypeSet_empty(jarg1.Handle);
}


public static void TechTypeSet_Clear(HandleRef jarg1) {
  remote.TechTypeSet_Clear(jarg1.Handle);
}


public static IntPtr TechTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.TechTypeSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool TechTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.TechTypeSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void TechTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.TechTypeSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool TechTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.TechTypeSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr TechTypeSet_create_iterator_begin(HandleRef jarg1) {
  return remote.TechTypeSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr TechTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.TechTypeSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_TechTypeSet(HandleRef jarg1) {
  remote.delete_TechTypeSet(jarg1.Handle);
}


public static IntPtr new_UnitSizeTypeSet__SWIG_0() {
  return remote.new_UnitSizeTypeSet__SWIG_0();
}


public static IntPtr new_UnitSizeTypeSet__SWIG_1(HandleRef jarg1) {
  return remote.new_UnitSizeTypeSet__SWIG_1(jarg1.Handle);
}


public static uint UnitSizeTypeSet_size(HandleRef jarg1) {
  return remote.UnitSizeTypeSet_size(jarg1.Handle);
}


public static bool UnitSizeTypeSet_empty(HandleRef jarg1) {
  return remote.UnitSizeTypeSet_empty(jarg1.Handle);
}


public static void UnitSizeTypeSet_Clear(HandleRef jarg1) {
  remote.UnitSizeTypeSet_Clear(jarg1.Handle);
}


public static IntPtr UnitSizeTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitSizeTypeSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool UnitSizeTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitSizeTypeSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void UnitSizeTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.UnitSizeTypeSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool UnitSizeTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitSizeTypeSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr UnitSizeTypeSet_create_iterator_begin(HandleRef jarg1) {
  return remote.UnitSizeTypeSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr UnitSizeTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.UnitSizeTypeSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_UnitSizeTypeSet(HandleRef jarg1) {
  remote.delete_UnitSizeTypeSet(jarg1.Handle);
}


public static IntPtr new_UnitTypePtrSet__SWIG_0() {
  return remote.new_UnitTypePtrSet__SWIG_0();
}


public static IntPtr new_UnitTypePtrSet__SWIG_1(HandleRef jarg1) {
  return remote.new_UnitTypePtrSet__SWIG_1(jarg1.Handle);
}


public static uint UnitTypePtrSet_size(HandleRef jarg1) {
  return remote.UnitTypePtrSet_size(jarg1.Handle);
}


public static bool UnitTypePtrSet_empty(HandleRef jarg1) {
  return remote.UnitTypePtrSet_empty(jarg1.Handle);
}


public static void UnitTypePtrSet_Clear(HandleRef jarg1) {
  remote.UnitTypePtrSet_Clear(jarg1.Handle);
}


public static IntPtr UnitTypePtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitTypePtrSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool UnitTypePtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitTypePtrSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void UnitTypePtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.UnitTypePtrSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool UnitTypePtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitTypePtrSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr UnitTypePtrSet_create_iterator_begin(HandleRef jarg1) {
  return remote.UnitTypePtrSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr UnitTypePtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.UnitTypePtrSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_UnitTypePtrSet(HandleRef jarg1) {
  remote.delete_UnitTypePtrSet(jarg1.Handle);
}


public static IntPtr new_UnitTypeSet__SWIG_0() {
  return remote.new_UnitTypeSet__SWIG_0();
}


public static IntPtr new_UnitTypeSet__SWIG_1(HandleRef jarg1) {
  return remote.new_UnitTypeSet__SWIG_1(jarg1.Handle);
}


public static uint UnitTypeSet_size(HandleRef jarg1) {
  return remote.UnitTypeSet_size(jarg1.Handle);
}


public static bool UnitTypeSet_empty(HandleRef jarg1) {
  return remote.UnitTypeSet_empty(jarg1.Handle);
}


public static void UnitTypeSet_Clear(HandleRef jarg1) {
  remote.UnitTypeSet_Clear(jarg1.Handle);
}


public static IntPtr UnitTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitTypeSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool UnitTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitTypeSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void UnitTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.UnitTypeSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool UnitTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitTypeSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr UnitTypeSet_create_iterator_begin(HandleRef jarg1) {
  return remote.UnitTypeSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr UnitTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.UnitTypeSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_UnitTypeSet(HandleRef jarg1) {
  remote.delete_UnitTypeSet(jarg1.Handle);
}


public static IntPtr new_UpgradeTypePtrSet__SWIG_0() {
  return remote.new_UpgradeTypePtrSet__SWIG_0();
}


public static IntPtr new_UpgradeTypePtrSet__SWIG_1(HandleRef jarg1) {
  return remote.new_UpgradeTypePtrSet__SWIG_1(jarg1.Handle);
}


public static uint UpgradeTypePtrSet_size(HandleRef jarg1) {
  return remote.UpgradeTypePtrSet_size(jarg1.Handle);
}


public static bool UpgradeTypePtrSet_empty(HandleRef jarg1) {
  return remote.UpgradeTypePtrSet_empty(jarg1.Handle);
}


public static void UpgradeTypePtrSet_Clear(HandleRef jarg1) {
  remote.UpgradeTypePtrSet_Clear(jarg1.Handle);
}


public static IntPtr UpgradeTypePtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.UpgradeTypePtrSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool UpgradeTypePtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.UpgradeTypePtrSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void UpgradeTypePtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.UpgradeTypePtrSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool UpgradeTypePtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.UpgradeTypePtrSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr UpgradeTypePtrSet_create_iterator_begin(HandleRef jarg1) {
  return remote.UpgradeTypePtrSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr UpgradeTypePtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.UpgradeTypePtrSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_UpgradeTypePtrSet(HandleRef jarg1) {
  remote.delete_UpgradeTypePtrSet(jarg1.Handle);
}


public static IntPtr new_UpgradeTypeSet__SWIG_0() {
  return remote.new_UpgradeTypeSet__SWIG_0();
}


public static IntPtr new_UpgradeTypeSet__SWIG_1(HandleRef jarg1) {
  return remote.new_UpgradeTypeSet__SWIG_1(jarg1.Handle);
}


public static uint UpgradeTypeSet_size(HandleRef jarg1) {
  return remote.UpgradeTypeSet_size(jarg1.Handle);
}


public static bool UpgradeTypeSet_empty(HandleRef jarg1) {
  return remote.UpgradeTypeSet_empty(jarg1.Handle);
}


public static void UpgradeTypeSet_Clear(HandleRef jarg1) {
  remote.UpgradeTypeSet_Clear(jarg1.Handle);
}


public static IntPtr UpgradeTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.UpgradeTypeSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool UpgradeTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.UpgradeTypeSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void UpgradeTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.UpgradeTypeSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool UpgradeTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.UpgradeTypeSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr UpgradeTypeSet_create_iterator_begin(HandleRef jarg1) {
  return remote.UpgradeTypeSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr UpgradeTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.UpgradeTypeSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_UpgradeTypeSet(HandleRef jarg1) {
  remote.delete_UpgradeTypeSet(jarg1.Handle);
}


public static IntPtr new_WeaponTypeSet__SWIG_0() {
  return remote.new_WeaponTypeSet__SWIG_0();
}


public static IntPtr new_WeaponTypeSet__SWIG_1(HandleRef jarg1) {
  return remote.new_WeaponTypeSet__SWIG_1(jarg1.Handle);
}


public static uint WeaponTypeSet_size(HandleRef jarg1) {
  return remote.WeaponTypeSet_size(jarg1.Handle);
}


public static bool WeaponTypeSet_empty(HandleRef jarg1) {
  return remote.WeaponTypeSet_empty(jarg1.Handle);
}


public static void WeaponTypeSet_Clear(HandleRef jarg1) {
  remote.WeaponTypeSet_Clear(jarg1.Handle);
}


public static IntPtr WeaponTypeSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.WeaponTypeSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool WeaponTypeSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.WeaponTypeSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void WeaponTypeSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.WeaponTypeSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool WeaponTypeSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.WeaponTypeSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr WeaponTypeSet_create_iterator_begin(HandleRef jarg1) {
  return remote.WeaponTypeSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr WeaponTypeSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.WeaponTypeSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_WeaponTypeSet(HandleRef jarg1) {
  remote.delete_WeaponTypeSet(jarg1.Handle);
}


public static IntPtr new_PositionPair__SWIG_0() {
  return remote.new_PositionPair__SWIG_0();
}


public static IntPtr new_PositionPair__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return remote.new_PositionPair__SWIG_1(jarg1.Handle, jarg2.Handle);
}


public static IntPtr new_PositionPair__SWIG_2(HandleRef jarg1) {
  return remote.new_PositionPair__SWIG_2(jarg1.Handle);
}


public static void PositionPair_first_set(HandleRef jarg1, HandleRef jarg2) {
  remote.PositionPair_first_set(jarg1.Handle, jarg2.Handle);
}


public static IntPtr PositionPair_first_get(HandleRef jarg1) {
  return remote.PositionPair_first_get(jarg1.Handle);
}


public static void PositionPair_second_set(HandleRef jarg1, HandleRef jarg2) {
  remote.PositionPair_second_set(jarg1.Handle, jarg2.Handle);
}


public static IntPtr PositionPair_second_get(HandleRef jarg1) {
  return remote.PositionPair_second_get(jarg1.Handle);
}


public static void delete_PositionPair(HandleRef jarg1) {
  remote.delete_PositionPair(jarg1.Handle);
}


public static IntPtr new_UnitTypePtrIntPair__SWIG_0() {
  return remote.new_UnitTypePtrIntPair__SWIG_0();
}


public static IntPtr new_UnitTypePtrIntPair__SWIG_1(HandleRef jarg1, int jarg2) {
  return remote.new_UnitTypePtrIntPair__SWIG_1(jarg1.Handle, jarg2);
}


public static IntPtr new_UnitTypePtrIntPair__SWIG_2(HandleRef jarg1) {
  return remote.new_UnitTypePtrIntPair__SWIG_2(jarg1.Handle);
}


public static void UnitTypePtrIntPair_first_set(HandleRef jarg1, HandleRef jarg2) {
  remote.UnitTypePtrIntPair_first_set(jarg1.Handle, jarg2.Handle);
}


public static IntPtr UnitTypePtrIntPair_first_get(HandleRef jarg1) {
  return remote.UnitTypePtrIntPair_first_get(jarg1.Handle);
}


public static void UnitTypePtrIntPair_second_set(HandleRef jarg1, int jarg2) {
  remote.UnitTypePtrIntPair_second_set(jarg1.Handle, jarg2);
}


public static int UnitTypePtrIntPair_second_get(HandleRef jarg1) {
  return remote.UnitTypePtrIntPair_second_get(jarg1.Handle);
}


public static void delete_UnitTypePtrIntPair(HandleRef jarg1) {
  remote.delete_UnitTypePtrIntPair(jarg1.Handle);
}


public static IntPtr new_TilePositionSet__SWIG_0() {
  return remote.new_TilePositionSet__SWIG_0();
}


public static IntPtr new_TilePositionSet__SWIG_1(HandleRef jarg1) {
  return remote.new_TilePositionSet__SWIG_1(jarg1.Handle);
}


public static uint TilePositionSet_size(HandleRef jarg1) {
  return remote.TilePositionSet_size(jarg1.Handle);
}


public static bool TilePositionSet_empty(HandleRef jarg1) {
  return remote.TilePositionSet_empty(jarg1.Handle);
}


public static void TilePositionSet_Clear(HandleRef jarg1) {
  remote.TilePositionSet_Clear(jarg1.Handle);
}


public static IntPtr TilePositionSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.TilePositionSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool TilePositionSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.TilePositionSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void TilePositionSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.TilePositionSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool TilePositionSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.TilePositionSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr TilePositionSet_create_iterator_begin(HandleRef jarg1) {
  return remote.TilePositionSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr TilePositionSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.TilePositionSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_TilePositionSet(HandleRef jarg1) {
  remote.delete_TilePositionSet(jarg1.Handle);
}


public static IntPtr new_TilePositionDoubleMap__SWIG_0() {
  return remote.new_TilePositionDoubleMap__SWIG_0();
}


public static IntPtr new_TilePositionDoubleMap__SWIG_1(HandleRef jarg1) {
  return remote.new_TilePositionDoubleMap__SWIG_1(jarg1.Handle);
}


public static uint TilePositionDoubleMap_size(HandleRef jarg1) {
  return remote.TilePositionDoubleMap_size(jarg1.Handle);
}


public static bool TilePositionDoubleMap_empty(HandleRef jarg1) {
  return remote.TilePositionDoubleMap_empty(jarg1.Handle);
}


public static void TilePositionDoubleMap_Clear(HandleRef jarg1) {
  remote.TilePositionDoubleMap_Clear(jarg1.Handle);
}


public static double TilePositionDoubleMap_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.TilePositionDoubleMap_getitem(jarg1.Handle, jarg2.Handle);
}


public static void TilePositionDoubleMap_setitem(HandleRef jarg1, HandleRef jarg2, double jarg3) {
  remote.TilePositionDoubleMap_setitem(jarg1.Handle, jarg2.Handle, jarg3);
}


public static bool TilePositionDoubleMap_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.TilePositionDoubleMap_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void TilePositionDoubleMap_Add(HandleRef jarg1, HandleRef jarg2, double jarg3) {
  remote.TilePositionDoubleMap_Add(jarg1.Handle, jarg2.Handle, jarg3);
}


public static bool TilePositionDoubleMap_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.TilePositionDoubleMap_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr TilePositionDoubleMap_create_iterator_begin(HandleRef jarg1) {
  return remote.TilePositionDoubleMap_create_iterator_begin(jarg1.Handle);
}


public static IntPtr TilePositionDoubleMap_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.TilePositionDoubleMap_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_TilePositionDoubleMap(HandleRef jarg1) {
  remote.delete_TilePositionDoubleMap(jarg1.Handle);
}


public static IntPtr new_TilePositionDoublePair__SWIG_0() {
  return remote.new_TilePositionDoublePair__SWIG_0();
}


public static IntPtr new_TilePositionDoublePair__SWIG_1(HandleRef jarg1, double jarg2) {
  return remote.new_TilePositionDoublePair__SWIG_1(jarg1.Handle, jarg2);
}


public static IntPtr new_TilePositionDoublePair__SWIG_2(HandleRef jarg1) {
  return remote.new_TilePositionDoublePair__SWIG_2(jarg1.Handle);
}


public static void TilePositionDoublePair_first_set(HandleRef jarg1, HandleRef jarg2) {
  remote.TilePositionDoublePair_first_set(jarg1.Handle, jarg2.Handle);
}


public static IntPtr TilePositionDoublePair_first_get(HandleRef jarg1) {
  return remote.TilePositionDoublePair_first_get(jarg1.Handle);
}


public static void TilePositionDoublePair_second_set(HandleRef jarg1, double jarg2) {
  remote.TilePositionDoublePair_second_set(jarg1.Handle, jarg2);
}


public static double TilePositionDoublePair_second_get(HandleRef jarg1) {
  return remote.TilePositionDoublePair_second_get(jarg1.Handle);
}


public static void delete_TilePositionDoublePair(HandleRef jarg1) {
  remote.delete_TilePositionDoublePair(jarg1.Handle);
}


public static void TilePositionVector_Clear(HandleRef jarg1) {
  remote.TilePositionVector_Clear(jarg1.Handle);
}


public static void TilePositionVector_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.TilePositionVector_Add(jarg1.Handle, jarg2.Handle);
}


public static uint TilePositionVector_size(HandleRef jarg1) {
  return remote.TilePositionVector_size(jarg1.Handle);
}


public static uint TilePositionVector_capacity(HandleRef jarg1) {
  return remote.TilePositionVector_capacity(jarg1.Handle);
}


public static void TilePositionVector_reserve(HandleRef jarg1, uint jarg2) {
  remote.TilePositionVector_reserve(jarg1.Handle, jarg2);
}


public static IntPtr new_TilePositionVector__SWIG_0() {
  return remote.new_TilePositionVector__SWIG_0();
}


public static IntPtr new_TilePositionVector__SWIG_1(HandleRef jarg1) {
  return remote.new_TilePositionVector__SWIG_1(jarg1.Handle);
}


public static IntPtr new_TilePositionVector__SWIG_2(int jarg1) {
  return remote.new_TilePositionVector__SWIG_2(jarg1);
}


public static IntPtr TilePositionVector_getitemcopy(HandleRef jarg1, int jarg2) {
  return remote.TilePositionVector_getitemcopy(jarg1.Handle, jarg2);
}


public static IntPtr TilePositionVector_getitem(HandleRef jarg1, int jarg2) {
  return remote.TilePositionVector_getitem(jarg1.Handle, jarg2);
}


public static void TilePositionVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3) {
  remote.TilePositionVector_setitem(jarg1.Handle, jarg2, jarg3.Handle);
}


public static void TilePositionVector_AddRange(HandleRef jarg1, HandleRef jarg2) {
  remote.TilePositionVector_AddRange(jarg1.Handle, jarg2.Handle);
}


public static IntPtr TilePositionVector_GetRange(HandleRef jarg1, int jarg2, int jarg3) {
  return remote.TilePositionVector_GetRange(jarg1.Handle, jarg2, jarg3);
}


public static void TilePositionVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3) {
  remote.TilePositionVector_Insert(jarg1.Handle, jarg2, jarg3.Handle);
}


public static void TilePositionVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3) {
  remote.TilePositionVector_InsertRange(jarg1.Handle, jarg2, jarg3.Handle);
}


public static void TilePositionVector_RemoveAt(HandleRef jarg1, int jarg2) {
  remote.TilePositionVector_RemoveAt(jarg1.Handle, jarg2);
}


public static void TilePositionVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3) {
  remote.TilePositionVector_RemoveRange(jarg1.Handle, jarg2, jarg3);
}


public static IntPtr TilePositionVector_Repeat(HandleRef jarg1, int jarg2) {
  return remote.TilePositionVector_Repeat(jarg1.Handle, jarg2);
}


public static void TilePositionVector_Reverse__SWIG_0(HandleRef jarg1) {
  remote.TilePositionVector_Reverse__SWIG_0(jarg1.Handle);
}


public static void TilePositionVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3) {
  remote.TilePositionVector_Reverse__SWIG_1(jarg1.Handle, jarg2, jarg3);
}


public static void TilePositionVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3) {
  remote.TilePositionVector_SetRange(jarg1.Handle, jarg2, jarg3.Handle);
}


public static void delete_TilePositionVector(HandleRef jarg1) {
  remote.delete_TilePositionVector(jarg1.Handle);
}


public static IntPtr new_UnitTypePtrIntMap__SWIG_0() {
  return remote.new_UnitTypePtrIntMap__SWIG_0();
}


public static IntPtr new_UnitTypePtrIntMap__SWIG_1(HandleRef jarg1) {
  return remote.new_UnitTypePtrIntMap__SWIG_1(jarg1.Handle);
}


public static uint UnitTypePtrIntMap_size(HandleRef jarg1) {
  return remote.UnitTypePtrIntMap_size(jarg1.Handle);
}


public static bool UnitTypePtrIntMap_empty(HandleRef jarg1) {
  return remote.UnitTypePtrIntMap_empty(jarg1.Handle);
}


public static void UnitTypePtrIntMap_Clear(HandleRef jarg1) {
  remote.UnitTypePtrIntMap_Clear(jarg1.Handle);
}


public static int UnitTypePtrIntMap_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitTypePtrIntMap_getitem(jarg1.Handle, jarg2.Handle);
}


public static void UnitTypePtrIntMap_setitem(HandleRef jarg1, HandleRef jarg2, int jarg3) {
  remote.UnitTypePtrIntMap_setitem(jarg1.Handle, jarg2.Handle, jarg3);
}


public static bool UnitTypePtrIntMap_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitTypePtrIntMap_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void UnitTypePtrIntMap_Add(HandleRef jarg1, HandleRef jarg2, int jarg3) {
  remote.UnitTypePtrIntMap_Add(jarg1.Handle, jarg2.Handle, jarg3);
}


public static bool UnitTypePtrIntMap_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitTypePtrIntMap_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr UnitTypePtrIntMap_create_iterator_begin(HandleRef jarg1) {
  return remote.UnitTypePtrIntMap_create_iterator_begin(jarg1.Handle);
}


public static IntPtr UnitTypePtrIntMap_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.UnitTypePtrIntMap_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_UnitTypePtrIntMap(HandleRef jarg1) {
  remote.delete_UnitTypePtrIntMap(jarg1.Handle);
}


public static void UnitPtrList_Clear(HandleRef jarg1) {
  remote.UnitPtrList_Clear(jarg1.Handle);
}


public static void UnitPtrList_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.UnitPtrList_Add(jarg1.Handle, jarg2.Handle);
}


public static uint UnitPtrList_size(HandleRef jarg1) {
  return remote.UnitPtrList_size(jarg1.Handle);
}


public static IntPtr new_UnitPtrList__SWIG_0() {
  return remote.new_UnitPtrList__SWIG_0();
}


public static IntPtr new_UnitPtrList__SWIG_1(HandleRef jarg1) {
  return remote.new_UnitPtrList__SWIG_1(jarg1.Handle);
}


public static IntPtr UnitPtrList_create_iterator_begin(HandleRef jarg1) {
  return remote.UnitPtrList_create_iterator_begin(jarg1.Handle);
}


public static IntPtr UnitPtrList_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.UnitPtrList_get_next_key(jarg1.Handle, jarg2);
}


public static bool UnitPtrList_Contains(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitPtrList_Contains(jarg1.Handle, jarg2.Handle);
}


public static bool UnitPtrList_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.UnitPtrList_Remove(jarg1.Handle, jarg2.Handle);
}


public static void delete_UnitPtrList(HandleRef jarg1) {
  remote.delete_UnitPtrList(jarg1.Handle);
}


public static void UnitTypeList_Clear(HandleRef jarg1) {
  remote.UnitTypeList_Clear(jarg1.Handle);
}


public static void UnitTypeList_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.UnitTypeList_Add(jarg1.Handle, jarg2.Handle);
}


public static uint UnitTypeList_size(HandleRef jarg1) {
  return remote.UnitTypeList_size(jarg1.Handle);
}


public static IntPtr new_UnitTypeList__SWIG_0() {
  return remote.new_UnitTypeList__SWIG_0();
}


public static IntPtr new_UnitTypeList__SWIG_1(HandleRef jarg1) {
  return remote.new_UnitTypeList__SWIG_1(jarg1.Handle);
}


public static IntPtr UnitTypeList_create_iterator_begin(HandleRef jarg1) {
  return remote.UnitTypeList_create_iterator_begin(jarg1.Handle);
}


public static IntPtr UnitTypeList_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.UnitTypeList_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_UnitTypeList(HandleRef jarg1) {
  remote.delete_UnitTypeList(jarg1.Handle);
}


public static IntPtr new_RegionPtrRegionPtrPair__SWIG_0() {
  return remote.new_RegionPtrRegionPtrPair__SWIG_0();
}


public static IntPtr new_RegionPtrRegionPtrPair__SWIG_1(HandleRef jarg1, HandleRef jarg2) {
  return remote.new_RegionPtrRegionPtrPair__SWIG_1(jarg1.Handle, jarg2.Handle);
}


public static IntPtr new_RegionPtrRegionPtrPair__SWIG_2(HandleRef jarg1) {
  return remote.new_RegionPtrRegionPtrPair__SWIG_2(jarg1.Handle);
}


public static void RegionPtrRegionPtrPair_first_set(HandleRef jarg1, HandleRef jarg2) {
  remote.RegionPtrRegionPtrPair_first_set(jarg1.Handle, jarg2.Handle);
}


public static IntPtr RegionPtrRegionPtrPair_first_get(HandleRef jarg1) {
  return remote.RegionPtrRegionPtrPair_first_get(jarg1.Handle);
}


public static void RegionPtrRegionPtrPair_second_set(HandleRef jarg1, HandleRef jarg2) {
  remote.RegionPtrRegionPtrPair_second_set(jarg1.Handle, jarg2.Handle);
}


public static IntPtr RegionPtrRegionPtrPair_second_get(HandleRef jarg1) {
  return remote.RegionPtrRegionPtrPair_second_get(jarg1.Handle);
}


public static void delete_RegionPtrRegionPtrPair(HandleRef jarg1) {
  remote.delete_RegionPtrRegionPtrPair(jarg1.Handle);
}


public static IntPtr new_BaseLocationPtrSet__SWIG_0() {
  return remote.new_BaseLocationPtrSet__SWIG_0();
}


public static IntPtr new_BaseLocationPtrSet__SWIG_1(HandleRef jarg1) {
  return remote.new_BaseLocationPtrSet__SWIG_1(jarg1.Handle);
}


public static uint BaseLocationPtrSet_size(HandleRef jarg1) {
  return remote.BaseLocationPtrSet_size(jarg1.Handle);
}


public static bool BaseLocationPtrSet_empty(HandleRef jarg1) {
  return remote.BaseLocationPtrSet_empty(jarg1.Handle);
}


public static void BaseLocationPtrSet_Clear(HandleRef jarg1) {
  remote.BaseLocationPtrSet_Clear(jarg1.Handle);
}


public static IntPtr BaseLocationPtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.BaseLocationPtrSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool BaseLocationPtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.BaseLocationPtrSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void BaseLocationPtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.BaseLocationPtrSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool BaseLocationPtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.BaseLocationPtrSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr BaseLocationPtrSet_create_iterator_begin(HandleRef jarg1) {
  return remote.BaseLocationPtrSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr BaseLocationPtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.BaseLocationPtrSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_BaseLocationPtrSet(HandleRef jarg1) {
  remote.delete_BaseLocationPtrSet(jarg1.Handle);
}


public static IntPtr new_ChokepointPtrSet__SWIG_0() {
  return remote.new_ChokepointPtrSet__SWIG_0();
}


public static IntPtr new_ChokepointPtrSet__SWIG_1(HandleRef jarg1) {
  return remote.new_ChokepointPtrSet__SWIG_1(jarg1.Handle);
}


public static uint ChokepointPtrSet_size(HandleRef jarg1) {
  return remote.ChokepointPtrSet_size(jarg1.Handle);
}


public static bool ChokepointPtrSet_empty(HandleRef jarg1) {
  return remote.ChokepointPtrSet_empty(jarg1.Handle);
}


public static void ChokepointPtrSet_Clear(HandleRef jarg1) {
  remote.ChokepointPtrSet_Clear(jarg1.Handle);
}


public static IntPtr ChokepointPtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.ChokepointPtrSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool ChokepointPtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.ChokepointPtrSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void ChokepointPtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.ChokepointPtrSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool ChokepointPtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.ChokepointPtrSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr ChokepointPtrSet_create_iterator_begin(HandleRef jarg1) {
  return remote.ChokepointPtrSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr ChokepointPtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.ChokepointPtrSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_ChokepointPtrSet(HandleRef jarg1) {
  remote.delete_ChokepointPtrSet(jarg1.Handle);
}


public static IntPtr new_PolygonPtrSet__SWIG_0() {
  return remote.new_PolygonPtrSet__SWIG_0();
}


public static IntPtr new_PolygonPtrSet__SWIG_1(HandleRef jarg1) {
  return remote.new_PolygonPtrSet__SWIG_1(jarg1.Handle);
}


public static uint PolygonPtrSet_size(HandleRef jarg1) {
  return remote.PolygonPtrSet_size(jarg1.Handle);
}


public static bool PolygonPtrSet_empty(HandleRef jarg1) {
  return remote.PolygonPtrSet_empty(jarg1.Handle);
}


public static void PolygonPtrSet_Clear(HandleRef jarg1) {
  remote.PolygonPtrSet_Clear(jarg1.Handle);
}


public static IntPtr PolygonPtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.PolygonPtrSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool PolygonPtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.PolygonPtrSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void PolygonPtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.PolygonPtrSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool PolygonPtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.PolygonPtrSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr PolygonPtrSet_create_iterator_begin(HandleRef jarg1) {
  return remote.PolygonPtrSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr PolygonPtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.PolygonPtrSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_PolygonPtrSet(HandleRef jarg1) {
  remote.delete_PolygonPtrSet(jarg1.Handle);
}


public static IntPtr new_RegionPtrSet__SWIG_0() {
  return remote.new_RegionPtrSet__SWIG_0();
}


public static IntPtr new_RegionPtrSet__SWIG_1(HandleRef jarg1) {
  return remote.new_RegionPtrSet__SWIG_1(jarg1.Handle);
}


public static uint RegionPtrSet_size(HandleRef jarg1) {
  return remote.RegionPtrSet_size(jarg1.Handle);
}


public static bool RegionPtrSet_empty(HandleRef jarg1) {
  return remote.RegionPtrSet_empty(jarg1.Handle);
}


public static void RegionPtrSet_Clear(HandleRef jarg1) {
  remote.RegionPtrSet_Clear(jarg1.Handle);
}


public static IntPtr RegionPtrSet_getitem(HandleRef jarg1, HandleRef jarg2) {
  return remote.RegionPtrSet_getitem(jarg1.Handle, jarg2.Handle);
}


public static bool RegionPtrSet_ContainsKey(HandleRef jarg1, HandleRef jarg2) {
  return remote.RegionPtrSet_ContainsKey(jarg1.Handle, jarg2.Handle);
}


public static void RegionPtrSet_Add(HandleRef jarg1, HandleRef jarg2) {
  remote.RegionPtrSet_Add(jarg1.Handle, jarg2.Handle);
}


public static bool RegionPtrSet_Remove(HandleRef jarg1, HandleRef jarg2) {
  return remote.RegionPtrSet_Remove(jarg1.Handle, jarg2.Handle);
}


public static IntPtr RegionPtrSet_create_iterator_begin(HandleRef jarg1) {
  return remote.RegionPtrSet_create_iterator_begin(jarg1.Handle);
}


public static IntPtr RegionPtrSet_get_next_key(HandleRef jarg1, IntPtr jarg2) {
  return remote.RegionPtrSet_get_next_key(jarg1.Handle, jarg2);
}


public static void delete_RegionPtrSet(HandleRef jarg1) {
  remote.delete_RegionPtrSet(jarg1.Handle);
}


public static IntPtr PolygonUpcast(IntPtr objectRef) {
  return remote.PolygonUpcast(objectRef);
}

}
}