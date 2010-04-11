
namespace BWAPI {

using System;
using System.Runtime.InteropServices;


public class bridgePINVOKEDynamic: MarshalByRefObject {

	
public class SWIGPendingExceptionDynamic: MarshalByRefObject {
    public bool Pending {
      get {
          lock (typeof(bridgePINVOKE))
          {
              return bridgePINVOKE.SWIGPendingException.Pending;
          }
      } 
    }

    public void Set(Exception e) {
        lock (typeof(bridgePINVOKE))
        {
            bridgePINVOKE.SWIGPendingException.Set(e);
        }
	}

    public Exception Retrieve() {
        lock (typeof(bridgePINVOKE))
        {
            return bridgePINVOKE.SWIGPendingException.Retrieve();
        }
    }
}

public SWIGPendingExceptionDynamic SWIGPendingException;

public bridgePINVOKEDynamic() {
	SWIGPendingException = new SWIGPendingExceptionDynamic();
}



public void BWAPI_init( ) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.BWAPI_init();
}
}


public IntPtr new_Race__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_Race__SWIG_0();
}
}


public IntPtr new_Race__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_Race__SWIG_1(jarg1);
}
}


public IntPtr new_Race__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_Race__SWIG_2(new HandleRef(null,jarg1));
}
}


public IntPtr Race_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Race_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Race_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Race_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Race_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Race_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Race_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Race_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int Race_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Race_getID(new HandleRef(null,jarg1));
}
}


public string Race_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Race_getName(new HandleRef(null,jarg1));
}
}


public IntPtr Race_getWorker(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Race_getWorker(new HandleRef(null,jarg1));
}
}


public IntPtr Race_getCenter(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Race_getCenter(new HandleRef(null,jarg1));
}
}


public IntPtr Race_getRefinery(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Race_getRefinery(new HandleRef(null,jarg1));
}
}


public IntPtr Race_getTransport(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Race_getTransport(new HandleRef(null,jarg1));
}
}


public IntPtr Race_getSupplyProvider(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Race_getSupplyProvider(new HandleRef(null,jarg1));
}
}


public void delete_Race(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_Race(new HandleRef(null,jarg1));
}
}


public IntPtr getRace(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getRace(jarg1);
}
}


public IntPtr allRaces( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.allRaces();
}
}


public void initRaces( ) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.initRaces();
}
}


public IntPtr Zerg_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_get();
}
}


public IntPtr Terran_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_get();
}
}


public IntPtr Protoss_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_get();
}
}


public IntPtr Random_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Random_get();
}
}


public IntPtr Other_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Other_get();
}
}


public IntPtr RaceNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RaceNone_get();
}
}


public IntPtr RaceUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RaceUnknown_get();
}
}


public IntPtr new_TechType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TechType__SWIG_0();
}
}


public IntPtr new_TechType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TechType__SWIG_1(jarg1);
}
}


public IntPtr new_TechType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TechType__SWIG_2(new HandleRef(null,jarg1));
}
}


public IntPtr TechType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool TechType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool TechType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool TechType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int TechType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechType_getID(new HandleRef(null,jarg1));
}
}


public string TechType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechType_getName(new HandleRef(null,jarg1));
}
}


public int TechType_mineralPrice(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechType_mineralPrice(new HandleRef(null,jarg1));
}
}


public int TechType_gasPrice(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechType_gasPrice(new HandleRef(null,jarg1));
}
}


public int TechType_energyUsed(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechType_energyUsed(new HandleRef(null,jarg1));
}
}


public IntPtr TechType_whatResearches(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechType_whatResearches(new HandleRef(null,jarg1));
}
}


public IntPtr TechType_getWeapon(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechType_getWeapon(new HandleRef(null,jarg1));
}
}


public IntPtr TechType_whatUses(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechType_whatUses(new HandleRef(null,jarg1));
}
}


public void delete_TechType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_TechType(new HandleRef(null,jarg1));
}
}


public IntPtr getTechType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getTechType(jarg1);
}
}


public IntPtr allTechTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.allTechTypes();
}
}


public void initTechTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.initTechTypes();
}
}


public IntPtr Stim_Packs_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Stim_Packs_get();
}
}


public IntPtr TechTypeLockdown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeLockdown_get();
}
}


public IntPtr TechTypeEMP_Shockwave_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeEMP_Shockwave_get();
}
}


public IntPtr Spider_Mines_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Spider_Mines_get();
}
}


public IntPtr Scanner_Sweep_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Scanner_Sweep_get();
}
}


public IntPtr Tank_Siege_Mode_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Tank_Siege_Mode_get();
}
}


public IntPtr Defensive_Matrix_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Defensive_Matrix_get();
}
}


public IntPtr TechTypeIrradiate_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeIrradiate_get();
}
}


public IntPtr TechTypeYamato_Gun_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeYamato_Gun_get();
}
}


public IntPtr Cloaking_Field_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Cloaking_Field_get();
}
}


public IntPtr Personnel_Cloaking_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Personnel_Cloaking_get();
}
}


public IntPtr Burrowing_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Burrowing_get();
}
}


public IntPtr Infestation_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Infestation_get();
}
}


public IntPtr TechTypeSpawn_Broodlings_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeSpawn_Broodlings_get();
}
}


public IntPtr TechTypeDark_Swarm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeDark_Swarm_get();
}
}


public IntPtr TechTypePlague_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypePlague_get();
}
}


public IntPtr TechTypeConsume_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeConsume_get();
}
}


public IntPtr TechTypeEnsnare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeEnsnare_get();
}
}


public IntPtr TechTypeParasite_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeParasite_get();
}
}


public IntPtr TechTypePsionic_Storm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypePsionic_Storm_get();
}
}


public IntPtr Hallucination_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Hallucination_get();
}
}


public IntPtr Recall_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Recall_get();
}
}


public IntPtr TechTypeStasis_Field_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeStasis_Field_get();
}
}


public IntPtr Archon_Warp_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Archon_Warp_get();
}
}


public IntPtr TechTypeRestoration_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeRestoration_get();
}
}


public IntPtr TechTypeDisruption_Web_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeDisruption_Web_get();
}
}


public IntPtr TechTypeMind_Control_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeMind_Control_get();
}
}


public IntPtr Dark_Archon_Meld_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Dark_Archon_Meld_get();
}
}


public IntPtr TechTypeFeedback_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeFeedback_get();
}
}


public IntPtr TechTypeOptical_Flare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeOptical_Flare_get();
}
}


public IntPtr TechTypeMaelstrom_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeMaelstrom_get();
}
}


public IntPtr Lurker_Aspect_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Lurker_Aspect_get();
}
}


public IntPtr Healing_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Healing_get();
}
}


public IntPtr TechTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeNone_get();
}
}


public IntPtr TechTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeUnknown_get();
}
}


public IntPtr TechTypeNuclear_Strike_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeNuclear_Strike_get();
}
}


public IntPtr new_UpgradeType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UpgradeType__SWIG_0();
}
}


public IntPtr new_UpgradeType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UpgradeType__SWIG_1(jarg1);
}
}


public IntPtr new_UpgradeType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UpgradeType__SWIG_2(new HandleRef(null,jarg1));
}
}


public IntPtr UpgradeType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UpgradeType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UpgradeType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UpgradeType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int UpgradeType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeType_getID(new HandleRef(null,jarg1));
}
}


public string UpgradeType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeType_getName(new HandleRef(null,jarg1));
}
}


public IntPtr UpgradeType_getRace(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeType_getRace(new HandleRef(null,jarg1));
}
}


public int UpgradeType_mineralPriceBase(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeType_mineralPriceBase(new HandleRef(null,jarg1));
}
}


public int UpgradeType_mineralPriceFactor(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeType_mineralPriceFactor(new HandleRef(null,jarg1));
}
}


public int UpgradeType_gasPriceBase(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeType_gasPriceBase(new HandleRef(null,jarg1));
}
}


public int UpgradeType_gasPriceFactor(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeType_gasPriceFactor(new HandleRef(null,jarg1));
}
}


public int UpgradeType_upgradeTimeBase(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeType_upgradeTimeBase(new HandleRef(null,jarg1));
}
}


public int UpgradeType_upgradeTimeFactor(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeType_upgradeTimeFactor(new HandleRef(null,jarg1));
}
}


public int UpgradeType_maxRepeats(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeType_maxRepeats(new HandleRef(null,jarg1));
}
}


public IntPtr UpgradeType_whatUpgrades(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeType_whatUpgrades(new HandleRef(null,jarg1));
}
}


public IntPtr UpgradeType_whatUses(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeType_whatUses(new HandleRef(null,jarg1));
}
}


public void delete_UpgradeType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_UpgradeType(new HandleRef(null,jarg1));
}
}


public IntPtr getUpgradeType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getUpgradeType(jarg1);
}
}


public IntPtr allUpgradeTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.allUpgradeTypes();
}
}


public void initUpgradeTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.initUpgradeTypes();
}
}


public IntPtr Terran_Infantry_Armor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Infantry_Armor_get();
}
}


public IntPtr Terran_Vehicle_Plating_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Vehicle_Plating_get();
}
}


public IntPtr Terran_Ship_Plating_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Ship_Plating_get();
}
}


public IntPtr Zerg_Carapace_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Carapace_get();
}
}


public IntPtr Zerg_Flyer_Carapace_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Flyer_Carapace_get();
}
}


public IntPtr Protoss_Armor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Armor_get();
}
}


public IntPtr Protoss_Plating_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Plating_get();
}
}


public IntPtr Terran_Infantry_Weapons_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Infantry_Weapons_get();
}
}


public IntPtr Terran_Vehicle_Weapons_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Vehicle_Weapons_get();
}
}


public IntPtr Terran_Ship_Weapons_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Ship_Weapons_get();
}
}


public IntPtr Zerg_Melee_Attacks_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Melee_Attacks_get();
}
}


public IntPtr Zerg_Missile_Attacks_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Missile_Attacks_get();
}
}


public IntPtr Zerg_Flyer_Attacks_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Flyer_Attacks_get();
}
}


public IntPtr Protoss_Ground_Weapons_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Ground_Weapons_get();
}
}


public IntPtr Protoss_Air_Weapons_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Air_Weapons_get();
}
}


public IntPtr Protoss_Plasma_Shields_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Plasma_Shields_get();
}
}


public IntPtr U_238_Shells_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.U_238_Shells_get();
}
}


public IntPtr Ion_Thrusters_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Ion_Thrusters_get();
}
}


public IntPtr Titan_Reactor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Titan_Reactor_get();
}
}


public IntPtr Ocular_Implants_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Ocular_Implants_get();
}
}


public IntPtr Moebius_Reactor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Moebius_Reactor_get();
}
}


public IntPtr Apollo_Reactor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Apollo_Reactor_get();
}
}


public IntPtr Colossus_Reactor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Colossus_Reactor_get();
}
}


public IntPtr Ventral_Sacs_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Ventral_Sacs_get();
}
}


public IntPtr Antennae_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Antennae_get();
}
}


public IntPtr Pneumatized_Carapace_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Pneumatized_Carapace_get();
}
}


public IntPtr Metabolic_Boost_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Metabolic_Boost_get();
}
}


public IntPtr Adrenal_Glands_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Adrenal_Glands_get();
}
}


public IntPtr Muscular_Augments_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Muscular_Augments_get();
}
}


public IntPtr Grooved_Spines_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Grooved_Spines_get();
}
}


public IntPtr Gamete_Meiosis_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Gamete_Meiosis_get();
}
}


public IntPtr Metasynaptic_Node_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Metasynaptic_Node_get();
}
}


public IntPtr Singularity_Charge_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Singularity_Charge_get();
}
}


public IntPtr Leg_Enhancements_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Leg_Enhancements_get();
}
}


public IntPtr Scarab_Damage_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Scarab_Damage_get();
}
}


public IntPtr Reaver_Capacity_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Reaver_Capacity_get();
}
}


public IntPtr Gravitic_Drive_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Gravitic_Drive_get();
}
}


public IntPtr Sensor_Array_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Sensor_Array_get();
}
}


public IntPtr Gravitic_Boosters_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Gravitic_Boosters_get();
}
}


public IntPtr Khaydarin_Amulet_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Khaydarin_Amulet_get();
}
}


public IntPtr Apial_Sensors_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Apial_Sensors_get();
}
}


public IntPtr Gravitic_Thrusters_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Gravitic_Thrusters_get();
}
}


public IntPtr Carrier_Capacity_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Carrier_Capacity_get();
}
}


public IntPtr Khaydarin_Core_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Khaydarin_Core_get();
}
}


public IntPtr Argus_Jewel_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Argus_Jewel_get();
}
}


public IntPtr Argus_Talisman_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Argus_Talisman_get();
}
}


public IntPtr Caduceus_Reactor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Caduceus_Reactor_get();
}
}


public IntPtr Chitinous_Plating_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Chitinous_Plating_get();
}
}


public IntPtr Anabolic_Synthesis_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Anabolic_Synthesis_get();
}
}


public IntPtr Charon_Booster_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Charon_Booster_get();
}
}


public IntPtr UpgradeTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeTypeNone_get();
}
}


public IntPtr UpgradeTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeTypeUnknown_get();
}
}


public IntPtr new_Position__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_Position__SWIG_0();
}
}


public IntPtr new_Position__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_Position__SWIG_1(new HandleRef(null,jarg1));
}
}


public IntPtr new_Position__SWIG_2(int jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_Position__SWIG_2(jarg1, jarg2);
}
}


public bool Position_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Position_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Position_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Position_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Position_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Position_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr Position_opPlus(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Position_opPlus(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr Position_opMinus(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Position_opMinus(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr Position_opAdd(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Position_opAdd(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr Position_opSubtract(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Position_opSubtract(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public double Position_getDistance(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Position_getDistance(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public double Position_getApproxDistance(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Position_getApproxDistance(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public double Position_getLength(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Position_getLength(new HandleRef(null,jarg1));
}
}


public IntPtr Position_x(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Position_x(new HandleRef(null,jarg1));
}
}


public IntPtr Position_y(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Position_y(new HandleRef(null,jarg1));
}
}


public int Position_xConst(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Position_xConst(new HandleRef(null,jarg1));
}
}


public int Position_yConst(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Position_yConst(new HandleRef(null,jarg1));
}
}


public void delete_Position(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_Position(new HandleRef(null,jarg1));
}
}


public IntPtr PositionInvalid_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PositionInvalid_get();
}
}


public IntPtr PositionNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PositionNone_get();
}
}


public IntPtr PositionUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PositionUnknown_get();
}
}


public IntPtr new_AIModule( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_AIModule();
}
}


public void delete_AIModule(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_AIModule(new HandleRef(null,jarg1));
}
}


public void AIModule_onStart(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.AIModule_onStart(new HandleRef(null,jarg1));
}
}


public void AIModule_onEnd(IntPtr jarg1, bool jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.AIModule_onEnd(new HandleRef(null,jarg1), jarg2);
}
}


public void AIModule_onFrame(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.AIModule_onFrame(new HandleRef(null,jarg1));
}
}


public bool AIModule_onSendText(IntPtr jarg1, string jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AIModule_onSendText(new HandleRef(null,jarg1), jarg2);
}
}


public void AIModule_onPlayerLeft(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.AIModule_onPlayerLeft(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void AIModule_onNukeDetect(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.AIModule_onNukeDetect(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void AIModule_onUnitCreate(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.AIModule_onUnitCreate(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void AIModule_onUnitDestroy(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.AIModule_onUnitDestroy(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void AIModule_onUnitMorph(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.AIModule_onUnitMorph(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void AIModule_onUnitShow(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.AIModule_onUnitShow(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void AIModule_onUnitHide(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.AIModule_onUnitHide(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void AIModule_onUnitRenegade(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.AIModule_onUnitRenegade(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr new_AttackType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_AttackType__SWIG_0();
}
}


public IntPtr new_AttackType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_AttackType__SWIG_1(jarg1);
}
}


public IntPtr new_AttackType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_AttackType__SWIG_2(new HandleRef(null,jarg1));
}
}


public IntPtr AttackType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool AttackType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool AttackType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool AttackType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int AttackType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackType_getID(new HandleRef(null,jarg1));
}
}


public string AttackType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackType_getName(new HandleRef(null,jarg1));
}
}


public void delete_AttackType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_AttackType(new HandleRef(null,jarg1));
}
}


public IntPtr getAttackType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getAttackType(jarg1);
}
}


public IntPtr allAttackTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.allAttackTypes();
}
}


public void initAttackTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.initAttackTypes();
}
}


public IntPtr Melee_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Melee_get();
}
}


public IntPtr Fusion_Cutter_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Fusion_Cutter_Hit_get();
}
}


public IntPtr Gauss_Rifle_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Gauss_Rifle_Hit_get();
}
}


public IntPtr C_10_Canister_Rifle_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.C_10_Canister_Rifle_Hit_get();
}
}


public IntPtr AttackTypeGemeni_Missiles_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeGemeni_Missiles_get();
}
}


public IntPtr AttackTypeFragmentation_Grenade_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeFragmentation_Grenade_get();
}
}


public IntPtr AttackTypeLongbolt_Missile_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeLongbolt_Missile_get();
}
}


public IntPtr ATS_ATA_Laser_Battery_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ATS_ATA_Laser_Battery_get();
}
}


public IntPtr AttackTypeBurst_Lasers_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeBurst_Lasers_get();
}
}


public IntPtr Arclite_Shock_Cannon_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Arclite_Shock_Cannon_Hit_get();
}
}


public IntPtr EMP_Missile_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.EMP_Missile_get();
}
}


public IntPtr Dual_Photon_Blasters_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Dual_Photon_Blasters_Hit_get();
}
}


public IntPtr Particle_Beam_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Particle_Beam_Hit_get();
}
}


public IntPtr Anti_Matter_Missile_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Anti_Matter_Missile_get();
}
}


public IntPtr AttackTypePulse_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypePulse_Cannon_get();
}
}


public IntPtr Psionic_Shockwave_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Psionic_Shockwave_Hit_get();
}
}


public IntPtr Psionic_Storm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Psionic_Storm_get();
}
}


public IntPtr AttackTypeYamato_Gun_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeYamato_Gun_get();
}
}


public IntPtr AttackTypePhase_Disruptor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypePhase_Disruptor_get();
}
}


public IntPtr STA_STS_Cannon_Overlay_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.STA_STS_Cannon_Overlay_get();
}
}


public IntPtr Sunken_Colony_Tentacle_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Sunken_Colony_Tentacle_get();
}
}


public IntPtr AttackTypeAcid_Spore_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeAcid_Spore_get();
}
}


public IntPtr AttackTypeGlave_Wurm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeGlave_Wurm_get();
}
}


public IntPtr AttackTypeSeeker_Spores_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeSeeker_Spores_get();
}
}


public IntPtr Queen_Spell_Carrier_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Queen_Spell_Carrier_get();
}
}


public IntPtr Plague_Cloud_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Plague_Cloud_get();
}
}


public IntPtr Consume_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Consume_get();
}
}


public IntPtr Needle_Spine_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Needle_Spine_Hit_get();
}
}


public IntPtr Invisible_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Invisible_get();
}
}


public IntPtr Optical_Flare_Grenade_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Optical_Flare_Grenade_get();
}
}


public IntPtr AttackTypeHalo_Rockets_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeHalo_Rockets_get();
}
}


public IntPtr AttackTypeSubterranean_Spines_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeSubterranean_Spines_get();
}
}


public IntPtr Corrosive_Acid_Shot_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Corrosive_Acid_Shot_get();
}
}


public IntPtr Neutron_Flare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Neutron_Flare_get();
}
}


public IntPtr AttackTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeNone_get();
}
}


public IntPtr AttackTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeUnknown_get();
}
}


public IntPtr new_Color__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_Color__SWIG_0();
}
}


public IntPtr new_Color__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_Color__SWIG_1(jarg1);
}
}


public IntPtr new_Color__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_Color__SWIG_2(new HandleRef(null,jarg1));
}
}


public IntPtr new_Color__SWIG_3(int jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_Color__SWIG_3(jarg1, jarg2, jarg3);
}
}


public IntPtr Color_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Color_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Color_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Color_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Color_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Color_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Color_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Color_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int Color_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Color_getID(new HandleRef(null,jarg1));
}
}


public int Color_red(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Color_red(new HandleRef(null,jarg1));
}
}


public int Color_green(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Color_green(new HandleRef(null,jarg1));
}
}


public int Color_blue(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Color_blue(new HandleRef(null,jarg1));
}
}


public void delete_Color(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_Color(new HandleRef(null,jarg1));
}
}


public void initColors( ) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.initColors();
}
}


public IntPtr Red_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Red_get();
}
}


public IntPtr Green_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Green_get();
}
}


public IntPtr Blue_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Blue_get();
}
}


public IntPtr Yellow_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Yellow_get();
}
}


public IntPtr Cyan_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Cyan_get();
}
}


public IntPtr Purple_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Purple_get();
}
}


public IntPtr Orange_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Orange_get();
}
}


public IntPtr Black_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Black_get();
}
}


public IntPtr White_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.White_get();
}
}


public IntPtr Grey_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Grey_get();
}
}


public int TILE_SIZE_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TILE_SIZE_get();
}
}


public int PYLON_X_RADIUS_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PYLON_X_RADIUS_get();
}
}


public int PYLON_Y_RADIUS_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PYLON_Y_RADIUS_get();
}
}


public IntPtr new_DamageType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_DamageType__SWIG_0();
}
}


public IntPtr new_DamageType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_DamageType__SWIG_1(jarg1);
}
}


public IntPtr new_DamageType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_DamageType__SWIG_2(new HandleRef(null,jarg1));
}
}


public IntPtr DamageType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DamageType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool DamageType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DamageType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool DamageType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DamageType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool DamageType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DamageType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int DamageType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DamageType_getID(new HandleRef(null,jarg1));
}
}


public string DamageType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DamageType_getName(new HandleRef(null,jarg1));
}
}


public void delete_DamageType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_DamageType(new HandleRef(null,jarg1));
}
}


public IntPtr getDamageType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getDamageType(jarg1);
}
}


public IntPtr allDamageTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.allDamageTypes();
}
}


public void initDamageTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.initDamageTypes();
}
}


public IntPtr DamageTypeIndependent_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DamageTypeIndependent_get();
}
}


public IntPtr Explosive_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Explosive_get();
}
}


public IntPtr Concussive_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Concussive_get();
}
}


public IntPtr DamageTypeNormal_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DamageTypeNormal_get();
}
}


public IntPtr Ignore_Armor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Ignore_Armor_get();
}
}


public IntPtr DamageTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DamageTypeNone_get();
}
}


public IntPtr DamageTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DamageTypeUnknown_get();
}
}


public IntPtr new_Error__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_Error__SWIG_0();
}
}


public IntPtr new_Error__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_Error__SWIG_1(jarg1);
}
}


public IntPtr new_Error__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_Error__SWIG_2(new HandleRef(null,jarg1));
}
}


public IntPtr Error_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Error_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Error_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Error_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Error_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Error_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Error_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Error_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int Error_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Error_getID(new HandleRef(null,jarg1));
}
}


public string Error_toErrorString(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Error_toErrorString(new HandleRef(null,jarg1));
}
}


public void delete_Error(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_Error(new HandleRef(null,jarg1));
}
}


public IntPtr getError(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getError(jarg1);
}
}


public IntPtr allErrors( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.allErrors();
}
}


public void initErrors( ) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.initErrors();
}
}


public IntPtr Unit_Does_Not_Exist_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_Does_Not_Exist_get();
}
}


public IntPtr Unit_Not_Visible_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_Not_Visible_get();
}
}


public IntPtr Unit_Not_Owned_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_Not_Owned_get();
}
}


public IntPtr Unit_Busy_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_Busy_get();
}
}


public IntPtr Incompatible_UnitType_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Incompatible_UnitType_get();
}
}


public IntPtr Incompatible_TechType_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Incompatible_TechType_get();
}
}


public IntPtr Already_Researched_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Already_Researched_get();
}
}


public IntPtr Fully_Upgraded_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Fully_Upgraded_get();
}
}


public IntPtr Insufficient_Minerals_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Insufficient_Minerals_get();
}
}


public IntPtr Insufficient_Gas_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Insufficient_Gas_get();
}
}


public IntPtr Insufficient_Supply_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Insufficient_Supply_get();
}
}


public IntPtr Insufficient_Energy_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Insufficient_Energy_get();
}
}


public IntPtr Insufficient_Tech_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Insufficient_Tech_get();
}
}


public IntPtr Insufficient_Ammo_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Insufficient_Ammo_get();
}
}


public IntPtr Insufficient_Space_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Insufficient_Space_get();
}
}


public IntPtr Unbuildable_Location_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unbuildable_Location_get();
}
}


public IntPtr Out_Of_Range_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Out_Of_Range_get();
}
}


public IntPtr Unable_To_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unable_To_Hit_get();
}
}


public IntPtr Access_Denied_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Access_Denied_get();
}
}


public IntPtr ErrorNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ErrorNone_get();
}
}


public IntPtr ErrorUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ErrorUnknown_get();
}
}


public IntPtr new_ExplosionType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_ExplosionType__SWIG_0();
}
}


public IntPtr new_ExplosionType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_ExplosionType__SWIG_1(jarg1);
}
}


public IntPtr new_ExplosionType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_ExplosionType__SWIG_2(new HandleRef(null,jarg1));
}
}


public IntPtr ExplosionType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool ExplosionType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool ExplosionType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool ExplosionType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int ExplosionType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionType_getID(new HandleRef(null,jarg1));
}
}


public string ExplosionType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionType_getName(new HandleRef(null,jarg1));
}
}


public void delete_ExplosionType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_ExplosionType(new HandleRef(null,jarg1));
}
}


public IntPtr getExplosionType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getExplosionType(jarg1);
}
}


public IntPtr allExplosionTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.allExplosionTypes();
}
}


public void initExplosionTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.initExplosionTypes();
}
}


public IntPtr ExplosionTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeNone_get();
}
}


public IntPtr ExplosionTypeNormal_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeNormal_get();
}
}


public IntPtr Radial_Splash_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Radial_Splash_get();
}
}


public IntPtr Enemy_Splash_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Enemy_Splash_get();
}
}


public IntPtr ExplosionTypeLockdown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeLockdown_get();
}
}


public IntPtr Nuclear_Missile_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Nuclear_Missile_get();
}
}


public IntPtr ExplosionTypeParasite_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeParasite_get();
}
}


public IntPtr Broodlings_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Broodlings_get();
}
}


public IntPtr ExplosionTypeEMP_Shockwave_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeEMP_Shockwave_get();
}
}


public IntPtr ExplosionTypeIrradiate_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeIrradiate_get();
}
}


public IntPtr ExplosionTypeEnsnare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeEnsnare_get();
}
}


public IntPtr ExplosionTypePlague_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypePlague_get();
}
}


public IntPtr ExplosionTypeStasis_Field_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeStasis_Field_get();
}
}


public IntPtr ExplosionTypeDark_Swarm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeDark_Swarm_get();
}
}


public IntPtr ExplosionTypeConsume_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeConsume_get();
}
}


public IntPtr ExplosionTypeYamato_Gun_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeYamato_Gun_get();
}
}


public IntPtr ExplosionTypeRestoration_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeRestoration_get();
}
}


public IntPtr ExplosionTypeDisruption_Web_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeDisruption_Web_get();
}
}


public IntPtr ExplosionTypeCorrosive_Acid_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeCorrosive_Acid_get();
}
}


public IntPtr ExplosionTypeMind_Control_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeMind_Control_get();
}
}


public IntPtr ExplosionTypeFeedback_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeFeedback_get();
}
}


public IntPtr ExplosionTypeOptical_Flare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeOptical_Flare_get();
}
}


public IntPtr ExplosionTypeMaelstrom_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeMaelstrom_get();
}
}


public IntPtr Air_Splash_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Air_Splash_get();
}
}


public IntPtr ExplosionTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeUnknown_get();
}
}


public int FLAG_COUNT_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.FLAG_COUNT_get();
}
}


public string Force_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Force_getName(new HandleRef(null,jarg1));
}
}


public IntPtr Force_getPlayers(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Force_getPlayers(new HandleRef(null,jarg1));
}
}


public void delete_Force(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_Force(new HandleRef(null,jarg1));
}
}


public IntPtr Game_getForces(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getForces(new HandleRef(null,jarg1));
}
}


public IntPtr Game_getPlayers(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getPlayers(new HandleRef(null,jarg1));
}
}


public IntPtr Game_getAllUnits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getAllUnits(new HandleRef(null,jarg1));
}
}


public IntPtr Game_getMinerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getMinerals(new HandleRef(null,jarg1));
}
}


public IntPtr Game_getGeysers(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getGeysers(new HandleRef(null,jarg1));
}
}


public IntPtr Game_getNeutralUnits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getNeutralUnits(new HandleRef(null,jarg1));
}
}


public IntPtr Game_getStaticMinerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getStaticMinerals(new HandleRef(null,jarg1));
}
}


public IntPtr Game_getStaticGeysers(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getStaticGeysers(new HandleRef(null,jarg1));
}
}


public IntPtr Game_getStaticNeutralUnits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getStaticNeutralUnits(new HandleRef(null,jarg1));
}
}


public int Game_getLatency(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getLatency(new HandleRef(null,jarg1));
}
}


public int Game_getFrameCount(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getFrameCount(new HandleRef(null,jarg1));
}
}


public int Game_getMouseX(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getMouseX(new HandleRef(null,jarg1));
}
}


public int Game_getMouseY(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getMouseY(new HandleRef(null,jarg1));
}
}


public IntPtr Game_getMousePosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getMousePosition(new HandleRef(null,jarg1));
}
}


public bool Game_getMouseState__SWIG_0(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getMouseState__SWIG_0(new HandleRef(null,jarg1), jarg2);
}
}


public bool Game_getMouseState__SWIG_1(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getMouseState__SWIG_1(new HandleRef(null,jarg1), jarg2);
}
}


public bool Game_getKeyState__SWIG_0(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getKeyState__SWIG_0(new HandleRef(null,jarg1), jarg2);
}
}


public bool Game_getKeyState__SWIG_1(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getKeyState__SWIG_1(new HandleRef(null,jarg1), jarg2);
}
}


public int Game_getScreenX(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getScreenX(new HandleRef(null,jarg1));
}
}


public int Game_getScreenY(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getScreenY(new HandleRef(null,jarg1));
}
}


public IntPtr Game_getScreenPosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getScreenPosition(new HandleRef(null,jarg1));
}
}


public void Game_setScreenPosition__SWIG_0(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_setScreenPosition__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3);
}
}


public void Game_setScreenPosition__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_setScreenPosition__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void Game_pingMinimap__SWIG_0(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_pingMinimap__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3);
}
}


public void Game_pingMinimap__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_pingMinimap__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Game_isFlagEnabled(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_isFlagEnabled(new HandleRef(null,jarg1), jarg2);
}
}


public void Game_enableFlag(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_enableFlag(new HandleRef(null,jarg1), jarg2);
}
}


public IntPtr Game_unitsOnTile(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_unitsOnTile(new HandleRef(null,jarg1), jarg2, jarg3);
}
}


public IntPtr Game_getLastError(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getLastError(new HandleRef(null,jarg1));
}
}


public int Game_mapWidth(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_mapWidth(new HandleRef(null,jarg1));
}
}


public int Game_mapHeight(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_mapHeight(new HandleRef(null,jarg1));
}
}


public string Game_mapFilename(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_mapFilename(new HandleRef(null,jarg1));
}
}


public string Game_mapName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_mapName(new HandleRef(null,jarg1));
}
}


public int Game_getMapHash(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getMapHash(new HandleRef(null,jarg1));
}
}


public int Game_getGroundHeight(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getGroundHeight(new HandleRef(null,jarg1), jarg2, jarg3);
}
}


public bool Game_isWalkable(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_isWalkable(new HandleRef(null,jarg1), jarg2, jarg3);
}
}


public bool Game_isBuildable__SWIG_0(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_isBuildable__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3);
}
}


public bool Game_isVisible__SWIG_0(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_isVisible__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3);
}
}


public bool Game_isExplored__SWIG_0(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_isExplored__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3);
}
}


public bool Game_hasCreep__SWIG_0(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_hasCreep__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3);
}
}


public bool Game_hasPower__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_hasPower__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5);
}
}


public bool Game_isBuildable__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_isBuildable__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Game_isVisible__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_isVisible__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Game_isExplored__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_isExplored__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Game_hasCreep__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_hasCreep__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Game_hasPower__SWIG_1(IntPtr jarg1, IntPtr jarg2, int jarg3, int jarg4) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_hasPower__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2), jarg3, jarg4);
}
}


public bool Game_canBuildHere(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_canBuildHere(new HandleRef(null,jarg1), new HandleRef(null,jarg2), new HandleRef(null,jarg3), new HandleRef(null,jarg4));
}
}


public bool Game_canMake(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_canMake(new HandleRef(null,jarg1), new HandleRef(null,jarg2), new HandleRef(null,jarg3));
}
}


public bool Game_canResearch(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_canResearch(new HandleRef(null,jarg1), new HandleRef(null,jarg2), new HandleRef(null,jarg3));
}
}


public bool Game_canUpgrade(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_canUpgrade(new HandleRef(null,jarg1), new HandleRef(null,jarg2), new HandleRef(null,jarg3));
}
}


public IntPtr Game_getStartLocations(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getStartLocations(new HandleRef(null,jarg1));
}
}


public void Game_printf(IntPtr jarg1, string jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_printf(new HandleRef(null,jarg1), jarg2);
}
}


public void Game_sendText(IntPtr jarg1, string jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_sendText(new HandleRef(null,jarg1), jarg2);
}
}


public void Game_changeRace(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_changeRace(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Game_isMultiplayer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_isMultiplayer(new HandleRef(null,jarg1));
}
}


public bool Game_isPaused(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_isPaused(new HandleRef(null,jarg1));
}
}


public bool Game_isReplay(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_isReplay(new HandleRef(null,jarg1));
}
}


public void Game_startGame(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_startGame(new HandleRef(null,jarg1));
}
}


public void Game_pauseGame(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_pauseGame(new HandleRef(null,jarg1));
}
}


public void Game_resumeGame(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_resumeGame(new HandleRef(null,jarg1));
}
}


public void Game_leaveGame(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_leaveGame(new HandleRef(null,jarg1));
}
}


public void Game_restartGame(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_restartGame(new HandleRef(null,jarg1));
}
}


public void Game_setLocalSpeed__SWIG_0(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_setLocalSpeed__SWIG_0(new HandleRef(null,jarg1), jarg2);
}
}


public void Game_setLocalSpeed__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_setLocalSpeed__SWIG_1(new HandleRef(null,jarg1));
}
}


public IntPtr Game_getSelectedUnits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_getSelectedUnits(new HandleRef(null,jarg1));
}
}


public IntPtr Game_self(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_self(new HandleRef(null,jarg1));
}
}


public IntPtr Game_enemy(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Game_enemy(new HandleRef(null,jarg1));
}
}


public void Game_drawText(IntPtr jarg1, int jarg2, int jarg3, int jarg4, string jarg5) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawText(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5);
}
}


public void Game_drawTextMap(IntPtr jarg1, int jarg2, int jarg3, string jarg4) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawTextMap(new HandleRef(null,jarg1), jarg2, jarg3, jarg4);
}
}


public void Game_drawTextMouse(IntPtr jarg1, int jarg2, int jarg3, string jarg4) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawTextMouse(new HandleRef(null,jarg1), jarg2, jarg3, jarg4);
}
}


public void Game_drawTextScreen(IntPtr jarg1, int jarg2, int jarg3, string jarg4) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawTextScreen(new HandleRef(null,jarg1), jarg2, jarg3, jarg4);
}
}


public void Game_drawBox__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, IntPtr jarg7, bool jarg8) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawBox__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, new HandleRef(null,jarg7), jarg8);
}
}


public void Game_drawBox__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, IntPtr jarg7) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawBox__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, new HandleRef(null,jarg7));
}
}


public void Game_drawBoxMap__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, bool jarg7) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawBoxMap__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6), jarg7);
}
}


public void Game_drawBoxMap__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawBoxMap__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
}
}


public void Game_drawBoxMouse__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, bool jarg7) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawBoxMouse__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6), jarg7);
}
}


public void Game_drawBoxMouse__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawBoxMouse__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
}
}


public void Game_drawBoxScreen__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, bool jarg7) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawBoxScreen__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6), jarg7);
}
}


public void Game_drawBoxScreen__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawBoxScreen__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
}
}


public void Game_drawTriangle__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, int jarg8, IntPtr jarg9, bool jarg10) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawTriangle__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8, new HandleRef(null,jarg9), jarg10);
}
}


public void Game_drawTriangle__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, int jarg8, IntPtr jarg9) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawTriangle__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8, new HandleRef(null,jarg9));
}
}


public void Game_drawTriangleMap__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, IntPtr jarg8, bool jarg9) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawTriangleMap__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, new HandleRef(null,jarg8), jarg9);
}
}


public void Game_drawTriangleMap__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, IntPtr jarg8) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawTriangleMap__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, new HandleRef(null,jarg8));
}
}


public void Game_drawTriangleMouse__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, IntPtr jarg8, bool jarg9) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawTriangleMouse__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, new HandleRef(null,jarg8), jarg9);
}
}


public void Game_drawTriangleMouse__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, IntPtr jarg8) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawTriangleMouse__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, new HandleRef(null,jarg8));
}
}


public void Game_drawTriangleScreen__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, IntPtr jarg8, bool jarg9) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawTriangleScreen__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, new HandleRef(null,jarg8), jarg9);
}
}


public void Game_drawTriangleScreen__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, IntPtr jarg8) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawTriangleScreen__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, new HandleRef(null,jarg8));
}
}


public void Game_drawCircle__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, bool jarg7) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawCircle__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6), jarg7);
}
}


public void Game_drawCircle__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawCircle__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
}
}


public void Game_drawCircleMap__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, IntPtr jarg5, bool jarg6) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawCircleMap__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, new HandleRef(null,jarg5), jarg6);
}
}


public void Game_drawCircleMap__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, IntPtr jarg5) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawCircleMap__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, new HandleRef(null,jarg5));
}
}


public void Game_drawCircleMouse__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, IntPtr jarg5, bool jarg6) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawCircleMouse__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, new HandleRef(null,jarg5), jarg6);
}
}


public void Game_drawCircleMouse__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, IntPtr jarg5) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawCircleMouse__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, new HandleRef(null,jarg5));
}
}


public void Game_drawCircleScreen__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, IntPtr jarg5, bool jarg6) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawCircleScreen__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, new HandleRef(null,jarg5), jarg6);
}
}


public void Game_drawCircleScreen__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, IntPtr jarg5) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawCircleScreen__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, new HandleRef(null,jarg5));
}
}


public void Game_drawEllipse__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, IntPtr jarg7, bool jarg8) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawEllipse__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, new HandleRef(null,jarg7), jarg8);
}
}


public void Game_drawEllipse__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, IntPtr jarg7) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawEllipse__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, new HandleRef(null,jarg7));
}
}


public void Game_drawEllipseMap__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, bool jarg7) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawEllipseMap__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6), jarg7);
}
}


public void Game_drawEllipseMap__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawEllipseMap__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
}
}


public void Game_drawEllipseMouse__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, bool jarg7) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawEllipseMouse__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6), jarg7);
}
}


public void Game_drawEllipseMouse__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawEllipseMouse__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
}
}


public void Game_drawEllipseScreen__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, bool jarg7) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawEllipseScreen__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6), jarg7);
}
}


public void Game_drawEllipseScreen__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawEllipseScreen__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
}
}


public void Game_drawDot(IntPtr jarg1, int jarg2, int jarg3, int jarg4, IntPtr jarg5) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawDot(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, new HandleRef(null,jarg5));
}
}


public void Game_drawDotMap(IntPtr jarg1, int jarg2, int jarg3, IntPtr jarg4) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawDotMap(new HandleRef(null,jarg1), jarg2, jarg3, new HandleRef(null,jarg4));
}
}


public void Game_drawDotMouse(IntPtr jarg1, int jarg2, int jarg3, IntPtr jarg4) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawDotMouse(new HandleRef(null,jarg1), jarg2, jarg3, new HandleRef(null,jarg4));
}
}


public void Game_drawDotScreen(IntPtr jarg1, int jarg2, int jarg3, IntPtr jarg4) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawDotScreen(new HandleRef(null,jarg1), jarg2, jarg3, new HandleRef(null,jarg4));
}
}


public void Game_drawLine(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, IntPtr jarg7) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawLine(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, new HandleRef(null,jarg7));
}
}


public void Game_drawLineMap(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawLineMap(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
}
}


public void Game_drawLineMouse(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawLineMouse(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
}
}


public void Game_drawLineScreen(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Game_drawLineScreen(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
}
}


public void delete_Game(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_Game(new HandleRef(null,jarg1));
}
}


public void Broodwar_set(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.Broodwar_set(new HandleRef(null,jarg1));
}
}


public IntPtr Broodwar_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Broodwar_get();
}
}


public IntPtr new_Order__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_Order__SWIG_0();
}
}


public IntPtr new_Order__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_Order__SWIG_1(jarg1);
}
}


public IntPtr new_Order__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_Order__SWIG_2(new HandleRef(null,jarg1));
}
}


public IntPtr Order_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Order_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Order_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Order_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Order_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Order_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Order_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Order_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int Order_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Order_getID(new HandleRef(null,jarg1));
}
}


public string Order_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Order_getName(new HandleRef(null,jarg1));
}
}


public void delete_Order(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_Order(new HandleRef(null,jarg1));
}
}


public IntPtr getOrder(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getOrder(jarg1);
}
}


public IntPtr allOrders( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.allOrders();
}
}


public void initOrders( ) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.initOrders();
}
}


public IntPtr Die_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Die_get();
}
}


public IntPtr Stop_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Stop_get();
}
}


public IntPtr Guard_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Guard_get();
}
}


public IntPtr PlayerGuard_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerGuard_get();
}
}


public IntPtr TurretGuard_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TurretGuard_get();
}
}


public IntPtr BunkerGuard_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BunkerGuard_get();
}
}


public IntPtr Move_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Move_get();
}
}


public IntPtr ReaverStop_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ReaverStop_get();
}
}


public IntPtr Attack1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Attack1_get();
}
}


public IntPtr Attack2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Attack2_get();
}
}


public IntPtr AttackUnit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackUnit_get();
}
}


public IntPtr AttackFixedRange_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackFixedRange_get();
}
}


public IntPtr AttackTile_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTile_get();
}
}


public IntPtr Hover_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Hover_get();
}
}


public IntPtr AttackMove_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackMove_get();
}
}


public IntPtr InfestMine1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.InfestMine1_get();
}
}


public IntPtr Nothing1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Nothing1_get();
}
}


public IntPtr Powerup1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Powerup1_get();
}
}


public IntPtr TowerGuard_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TowerGuard_get();
}
}


public IntPtr TowerAttack_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TowerAttack_get();
}
}


public IntPtr VultureMine_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.VultureMine_get();
}
}


public IntPtr StayinRange_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.StayinRange_get();
}
}


public IntPtr TurretAttack_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TurretAttack_get();
}
}


public IntPtr Nothing2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Nothing2_get();
}
}


public IntPtr Nothing3_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Nothing3_get();
}
}


public IntPtr DroneStartBuild_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DroneStartBuild_get();
}
}


public IntPtr DroneBuild_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DroneBuild_get();
}
}


public IntPtr InfestMine2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.InfestMine2_get();
}
}


public IntPtr InfestMine3_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.InfestMine3_get();
}
}


public IntPtr InfestMine4_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.InfestMine4_get();
}
}


public IntPtr BuildTerran_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BuildTerran_get();
}
}


public IntPtr BuildProtoss1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BuildProtoss1_get();
}
}


public IntPtr BuildProtoss2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BuildProtoss2_get();
}
}


public IntPtr ConstructingBuilding_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ConstructingBuilding_get();
}
}


public IntPtr Repair1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Repair1_get();
}
}


public IntPtr Repair2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Repair2_get();
}
}


public IntPtr PlaceAddon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlaceAddon_get();
}
}


public IntPtr BuildAddon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BuildAddon_get();
}
}


public IntPtr Train_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Train_get();
}
}


public IntPtr RallyPoint1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RallyPoint1_get();
}
}


public IntPtr RallyPoint2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RallyPoint2_get();
}
}


public IntPtr ZergBirth_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ZergBirth_get();
}
}


public IntPtr Morph1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Morph1_get();
}
}


public IntPtr Morph2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Morph2_get();
}
}


public IntPtr BuildSelf1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BuildSelf1_get();
}
}


public IntPtr ZergBuildSelf_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ZergBuildSelf_get();
}
}


public IntPtr Build5_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Build5_get();
}
}


public IntPtr Enternyduscanal_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Enternyduscanal_get();
}
}


public IntPtr BuildSelf2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BuildSelf2_get();
}
}


public IntPtr Follow_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Follow_get();
}
}


public IntPtr Carrier_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Carrier_get();
}
}


public IntPtr CarrierIgnore1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CarrierIgnore1_get();
}
}


public IntPtr CarrierStop_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CarrierStop_get();
}
}


public IntPtr CarrierAttack1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CarrierAttack1_get();
}
}


public IntPtr CarrierAttack2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CarrierAttack2_get();
}
}


public IntPtr CarrierIgnore2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CarrierIgnore2_get();
}
}


public IntPtr CarrierFight_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CarrierFight_get();
}
}


public IntPtr HoldPosition1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.HoldPosition1_get();
}
}


public IntPtr Reaver_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Reaver_get();
}
}


public IntPtr ReaverAttack1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ReaverAttack1_get();
}
}


public IntPtr ReaverAttack2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ReaverAttack2_get();
}
}


public IntPtr ReaverFight_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ReaverFight_get();
}
}


public IntPtr ReaverHold_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ReaverHold_get();
}
}


public IntPtr TrainFighter_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TrainFighter_get();
}
}


public IntPtr StrafeUnit1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.StrafeUnit1_get();
}
}


public IntPtr StrafeUnit2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.StrafeUnit2_get();
}
}


public IntPtr RechargeShields1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RechargeShields1_get();
}
}


public IntPtr Rechargeshields2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Rechargeshields2_get();
}
}


public IntPtr ShieldBattery_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ShieldBattery_get();
}
}


public IntPtr Return_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Return_get();
}
}


public IntPtr DroneLand_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DroneLand_get();
}
}


public IntPtr BuildingLand_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BuildingLand_get();
}
}


public IntPtr BuildingLiftoff_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BuildingLiftoff_get();
}
}


public IntPtr DroneLiftoff_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DroneLiftoff_get();
}
}


public IntPtr Liftoff_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Liftoff_get();
}
}


public IntPtr ResearchTech_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ResearchTech_get();
}
}


public IntPtr Upgrade_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Upgrade_get();
}
}


public IntPtr Larva_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Larva_get();
}
}


public IntPtr SpawningLarva_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.SpawningLarva_get();
}
}


public IntPtr Harvest1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Harvest1_get();
}
}


public IntPtr Harvest2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Harvest2_get();
}
}


public IntPtr MoveToGas_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.MoveToGas_get();
}
}


public IntPtr WaitForGas_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WaitForGas_get();
}
}


public IntPtr HarvestGas_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.HarvestGas_get();
}
}


public IntPtr ReturnGas_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ReturnGas_get();
}
}


public IntPtr MoveToMinerals_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.MoveToMinerals_get();
}
}


public IntPtr WaitForMinerals_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WaitForMinerals_get();
}
}


public IntPtr MiningMinerals_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.MiningMinerals_get();
}
}


public IntPtr Harvest3_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Harvest3_get();
}
}


public IntPtr Harvest4_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Harvest4_get();
}
}


public IntPtr ReturnMinerals_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ReturnMinerals_get();
}
}


public IntPtr Harvest5_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Harvest5_get();
}
}


public IntPtr EnterTransport_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.EnterTransport_get();
}
}


public IntPtr Pickup1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Pickup1_get();
}
}


public IntPtr Pickup2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Pickup2_get();
}
}


public IntPtr Pickup3_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Pickup3_get();
}
}


public IntPtr Pickup4_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Pickup4_get();
}
}


public IntPtr Powerup2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Powerup2_get();
}
}


public IntPtr SiegeMode_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.SiegeMode_get();
}
}


public IntPtr TankMode_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TankMode_get();
}
}


public IntPtr WatchTarget_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WatchTarget_get();
}
}


public IntPtr InitCreepGrowth_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.InitCreepGrowth_get();
}
}


public IntPtr SpreadCreep_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.SpreadCreep_get();
}
}


public IntPtr StoppingCreepGrowth_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.StoppingCreepGrowth_get();
}
}


public IntPtr GuardianAspect_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.GuardianAspect_get();
}
}


public IntPtr WarpingArchon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WarpingArchon_get();
}
}


public IntPtr CompletingArchonsummon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CompletingArchonsummon_get();
}
}


public IntPtr HoldPosition2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.HoldPosition2_get();
}
}


public IntPtr HoldPosition3_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.HoldPosition3_get();
}
}


public IntPtr Cloak_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Cloak_get();
}
}


public IntPtr Decloak_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Decloak_get();
}
}


public IntPtr Unload_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unload_get();
}
}


public IntPtr MoveUnload_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.MoveUnload_get();
}
}


public IntPtr FireYamatoGun1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.FireYamatoGun1_get();
}
}


public IntPtr FireYamatoGun2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.FireYamatoGun2_get();
}
}


public IntPtr MagnaPulse_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.MagnaPulse_get();
}
}


public IntPtr Burrow_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Burrow_get();
}
}


public IntPtr Burrowed_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Burrowed_get();
}
}


public IntPtr Unburrow_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unburrow_get();
}
}


public IntPtr DarkSwarm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DarkSwarm_get();
}
}


public IntPtr CastParasite_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CastParasite_get();
}
}


public IntPtr SummonBroodlings_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.SummonBroodlings_get();
}
}


public IntPtr EmpShockwave_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.EmpShockwave_get();
}
}


public IntPtr NukeWait_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.NukeWait_get();
}
}


public IntPtr NukeTrain_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.NukeTrain_get();
}
}


public IntPtr NukeLaunch_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.NukeLaunch_get();
}
}


public IntPtr NukePaint_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.NukePaint_get();
}
}


public IntPtr NukeUnit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.NukeUnit_get();
}
}


public IntPtr NukeGround_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.NukeGround_get();
}
}


public IntPtr NukeTrack_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.NukeTrack_get();
}
}


public IntPtr InitArbiter_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.InitArbiter_get();
}
}


public IntPtr CloakNearbyUnits_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CloakNearbyUnits_get();
}
}


public IntPtr PlaceMine_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlaceMine_get();
}
}


public IntPtr Rightclickaction_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Rightclickaction_get();
}
}


public IntPtr SapUnit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.SapUnit_get();
}
}


public IntPtr SapLocation_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.SapLocation_get();
}
}


public IntPtr HoldPosition4_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.HoldPosition4_get();
}
}


public IntPtr Teleport_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Teleport_get();
}
}


public IntPtr TeleporttoLocation_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TeleporttoLocation_get();
}
}


public IntPtr PlaceScanner_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlaceScanner_get();
}
}


public IntPtr Scanner_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Scanner_get();
}
}


public IntPtr DefensiveMatrix_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DefensiveMatrix_get();
}
}


public IntPtr PsiStorm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PsiStorm_get();
}
}


public IntPtr OrderIrradiate_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.OrderIrradiate_get();
}
}


public IntPtr OrderPlague_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.OrderPlague_get();
}
}


public IntPtr OrderConsume_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.OrderConsume_get();
}
}


public IntPtr OrderEnsnare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.OrderEnsnare_get();
}
}


public IntPtr StasisField_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.StasisField_get();
}
}


public IntPtr Hallucination1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Hallucination1_get();
}
}


public IntPtr Hallucination2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Hallucination2_get();
}
}


public IntPtr ResetCollision1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ResetCollision1_get();
}
}


public IntPtr ResetCollision2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ResetCollision2_get();
}
}


public IntPtr Patrol_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Patrol_get();
}
}


public IntPtr CTFCOPInit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CTFCOPInit_get();
}
}


public IntPtr CTFCOP1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CTFCOP1_get();
}
}


public IntPtr CTFCOP2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CTFCOP2_get();
}
}


public IntPtr ComputerAI_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ComputerAI_get();
}
}


public IntPtr AtkMoveEP_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AtkMoveEP_get();
}
}


public IntPtr HarassMove_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.HarassMove_get();
}
}


public IntPtr AIPatrol_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AIPatrol_get();
}
}


public IntPtr GuardPost_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.GuardPost_get();
}
}


public IntPtr RescuePassive_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RescuePassive_get();
}
}


public IntPtr OrderNeutral_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.OrderNeutral_get();
}
}


public IntPtr ComputerReturn_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ComputerReturn_get();
}
}


public IntPtr InitPsiProvider_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.InitPsiProvider_get();
}
}


public IntPtr SelfDestrucing_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.SelfDestrucing_get();
}
}


public IntPtr Critter_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Critter_get();
}
}


public IntPtr HiddenGun_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.HiddenGun_get();
}
}


public IntPtr OpenDoor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.OpenDoor_get();
}
}


public IntPtr CloseDoor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CloseDoor_get();
}
}


public IntPtr HideTrap_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.HideTrap_get();
}
}


public IntPtr RevealTrap_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RevealTrap_get();
}
}


public IntPtr Enabledoodad_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Enabledoodad_get();
}
}


public IntPtr Disabledoodad_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Disabledoodad_get();
}
}


public IntPtr Warpin_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Warpin_get();
}
}


public IntPtr Medic_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Medic_get();
}
}


public IntPtr MedicHeal1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.MedicHeal1_get();
}
}


public IntPtr HealMove_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.HealMove_get();
}
}


public IntPtr MedicHoldPosition_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.MedicHoldPosition_get();
}
}


public IntPtr MedicHeal2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.MedicHeal2_get();
}
}


public IntPtr OrderRestoration_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.OrderRestoration_get();
}
}


public IntPtr CastDisruptionWeb_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CastDisruptionWeb_get();
}
}


public IntPtr CastMindControl_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CastMindControl_get();
}
}


public IntPtr WarpingDarkArchon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WarpingDarkArchon_get();
}
}


public IntPtr CastFeedback_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CastFeedback_get();
}
}


public IntPtr CastOpticalFlare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CastOpticalFlare_get();
}
}


public IntPtr CastMaelstrom_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.CastMaelstrom_get();
}
}


public IntPtr JunkYardDog_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.JunkYardDog_get();
}
}


public IntPtr Fatal_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Fatal_get();
}
}


public IntPtr OrderNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.OrderNone_get();
}
}


public IntPtr OrderUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.OrderUnknown_get();
}
}


public IntPtr new_PlayerType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_PlayerType__SWIG_0();
}
}


public IntPtr new_PlayerType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_PlayerType__SWIG_1(jarg1);
}
}


public IntPtr new_PlayerType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_PlayerType__SWIG_2(new HandleRef(null,jarg1));
}
}


public IntPtr PlayerType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool PlayerType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool PlayerType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool PlayerType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int PlayerType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerType_getID(new HandleRef(null,jarg1));
}
}


public string PlayerType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerType_getName(new HandleRef(null,jarg1));
}
}


public void delete_PlayerType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_PlayerType(new HandleRef(null,jarg1));
}
}


public IntPtr getPlayerType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getPlayerType(jarg1);
}
}


public IntPtr allPlayerTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.allPlayerTypes();
}
}


public void initPlayerTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.initPlayerTypes();
}
}


public IntPtr NotUsed_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.NotUsed_get();
}
}


public IntPtr Computer_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Computer_get();
}
}


public IntPtr Human_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Human_get();
}
}


public IntPtr Rescuable_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Rescuable_get();
}
}


public IntPtr ComputerSlot_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ComputerSlot_get();
}
}


public IntPtr OpenSlot_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.OpenSlot_get();
}
}


public IntPtr PlayerTypeNeutral_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerTypeNeutral_get();
}
}


public IntPtr ClosedSlot_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ClosedSlot_get();
}
}


public IntPtr HumanDefeated_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.HumanDefeated_get();
}
}


public IntPtr ComputerDefeated_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ComputerDefeated_get();
}
}


public IntPtr PlayerTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerTypeNone_get();
}
}


public IntPtr PlayerTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerTypeUnknown_get();
}
}


public int Player_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_getID(new HandleRef(null,jarg1));
}
}


public string Player_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_getName(new HandleRef(null,jarg1));
}
}


public IntPtr Player_getUnits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_getUnits(new HandleRef(null,jarg1));
}
}


public IntPtr Player_getRace(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_getRace(new HandleRef(null,jarg1));
}
}


public IntPtr Player_playerType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_playerType(new HandleRef(null,jarg1));
}
}


public IntPtr Player_getForce(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_getForce(new HandleRef(null,jarg1));
}
}


public bool Player_isAlly(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_isAlly(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Player_isEnemy(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_isEnemy(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Player_isNeutral(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_isNeutral(new HandleRef(null,jarg1));
}
}


public IntPtr Player_getStartLocation(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_getStartLocation(new HandleRef(null,jarg1));
}
}


public bool Player_isVictorious(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_isVictorious(new HandleRef(null,jarg1));
}
}


public bool Player_isDefeated(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_isDefeated(new HandleRef(null,jarg1));
}
}


public bool Player_leftGame(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_leftGame(new HandleRef(null,jarg1));
}
}


public int Player_minerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_minerals(new HandleRef(null,jarg1));
}
}


public int Player_gas(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_gas(new HandleRef(null,jarg1));
}
}


public int Player_cumulativeMinerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_cumulativeMinerals(new HandleRef(null,jarg1));
}
}


public int Player_cumulativeGas(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_cumulativeGas(new HandleRef(null,jarg1));
}
}


public int Player_supplyTotal__SWIG_0(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_supplyTotal__SWIG_0(new HandleRef(null,jarg1));
}
}


public int Player_supplyUsed__SWIG_0(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_supplyUsed__SWIG_0(new HandleRef(null,jarg1));
}
}


public int Player_supplyTotal__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_supplyTotal__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int Player_supplyUsed__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_supplyUsed__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int Player_allUnitCount(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_allUnitCount(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int Player_completedUnitCount(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_completedUnitCount(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int Player_incompleteUnitCount(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_incompleteUnitCount(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int Player_deadUnitCount(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_deadUnitCount(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int Player_killedUnitCount(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_killedUnitCount(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int Player_getUpgradeLevel(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_getUpgradeLevel(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Player_hasResearched(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_hasResearched(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Player_isResearching(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_isResearching(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Player_isUpgrading(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Player_isUpgrading(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void delete_Player(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_Player(new HandleRef(null,jarg1));
}
}


public IntPtr new_TilePosition__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TilePosition__SWIG_0();
}
}


public IntPtr new_TilePosition__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TilePosition__SWIG_1(new HandleRef(null,jarg1));
}
}


public IntPtr new_TilePosition__SWIG_2(int jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TilePosition__SWIG_2(jarg1, jarg2);
}
}


public bool TilePosition_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePosition_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool TilePosition_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePosition_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool TilePosition_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePosition_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr TilePosition_opPlus(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePosition_opPlus(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr TilePosition_opMinus(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePosition_opMinus(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr TilePosition_opAdd(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePosition_opAdd(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr TilePosition_opSubtract(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePosition_opSubtract(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public double TilePosition_getDistance(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePosition_getDistance(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public double TilePosition_getLength(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePosition_getLength(new HandleRef(null,jarg1));
}
}


public bool TilePosition_isValid(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePosition_isValid(new HandleRef(null,jarg1));
}
}


public IntPtr TilePosition_x(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePosition_x(new HandleRef(null,jarg1));
}
}


public IntPtr TilePosition_y(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePosition_y(new HandleRef(null,jarg1));
}
}


public int TilePosition_xConst(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePosition_xConst(new HandleRef(null,jarg1));
}
}


public int TilePosition_yConst(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePosition_yConst(new HandleRef(null,jarg1));
}
}


public void delete_TilePosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_TilePosition(new HandleRef(null,jarg1));
}
}


public IntPtr TilePositionInvalid_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionInvalid_get();
}
}


public IntPtr TilePositionNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionNone_get();
}
}


public IntPtr TilePositionUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionUnknown_get();
}
}


public int Unit_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getID(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getPlayer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getPlayer(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getType(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getInitialType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getInitialType(new HandleRef(null,jarg1));
}
}


public int Unit_getHitPoints(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getHitPoints(new HandleRef(null,jarg1));
}
}


public int Unit_getInitialHitPoints(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getInitialHitPoints(new HandleRef(null,jarg1));
}
}


public int Unit_getShields(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getShields(new HandleRef(null,jarg1));
}
}


public int Unit_getEnergy(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getEnergy(new HandleRef(null,jarg1));
}
}


public int Unit_getResources(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getResources(new HandleRef(null,jarg1));
}
}


public int Unit_getInitialResources(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getInitialResources(new HandleRef(null,jarg1));
}
}


public int Unit_getKillCount(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getKillCount(new HandleRef(null,jarg1));
}
}


public int Unit_getGroundWeaponCooldown(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getGroundWeaponCooldown(new HandleRef(null,jarg1));
}
}


public int Unit_getAirWeaponCooldown(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getAirWeaponCooldown(new HandleRef(null,jarg1));
}
}


public int Unit_getSpellCooldown(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getSpellCooldown(new HandleRef(null,jarg1));
}
}


public int Unit_getDefenseMatrixPoints(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getDefenseMatrixPoints(new HandleRef(null,jarg1));
}
}


public int Unit_getDefenseMatrixTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getDefenseMatrixTimer(new HandleRef(null,jarg1));
}
}


public int Unit_getEnsnareTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getEnsnareTimer(new HandleRef(null,jarg1));
}
}


public int Unit_getIrradiateTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getIrradiateTimer(new HandleRef(null,jarg1));
}
}


public int Unit_getLockdownTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getLockdownTimer(new HandleRef(null,jarg1));
}
}


public int Unit_getMaelstromTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getMaelstromTimer(new HandleRef(null,jarg1));
}
}


public int Unit_getPlagueTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getPlagueTimer(new HandleRef(null,jarg1));
}
}


public int Unit_getRemoveTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getRemoveTimer(new HandleRef(null,jarg1));
}
}


public int Unit_getStasisTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getStasisTimer(new HandleRef(null,jarg1));
}
}


public int Unit_getStimTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getStimTimer(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getPosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getPosition(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getInitialPosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getInitialPosition(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getTilePosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getTilePosition(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getInitialTilePosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getInitialTilePosition(new HandleRef(null,jarg1));
}
}


public double Unit_getDistance__SWIG_0(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getDistance__SWIG_0(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public double Unit_getDistance__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getDistance__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public double Unit_getAngle(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getAngle(new HandleRef(null,jarg1));
}
}


public double Unit_getVelocityX(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getVelocityX(new HandleRef(null,jarg1));
}
}


public double Unit_getVelocityY(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getVelocityY(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getTarget(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getTarget(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getTargetPosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getTargetPosition(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getOrder(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getOrder(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getOrderTarget(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getOrderTarget(new HandleRef(null,jarg1));
}
}


public int Unit_getOrderTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getOrderTimer(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getSecondaryOrder(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getSecondaryOrder(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getBuildUnit(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getBuildUnit(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getBuildType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getBuildType(new HandleRef(null,jarg1));
}
}


public int Unit_getRemainingBuildTime(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getRemainingBuildTime(new HandleRef(null,jarg1));
}
}


public int Unit_getRemainingTrainTime(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getRemainingTrainTime(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getChild(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getChild(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getTrainingQueue(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getTrainingQueue(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getTransport(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getTransport(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getLoadedUnits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getLoadedUnits(new HandleRef(null,jarg1));
}
}


public int Unit_getInterceptorCount(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getInterceptorCount(new HandleRef(null,jarg1));
}
}


public int Unit_getScarabCount(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getScarabCount(new HandleRef(null,jarg1));
}
}


public int Unit_getSpiderMineCount(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getSpiderMineCount(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getTech(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getTech(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getUpgrade(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getUpgrade(new HandleRef(null,jarg1));
}
}


public int Unit_getRemainingResearchTime(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getRemainingResearchTime(new HandleRef(null,jarg1));
}
}


public int Unit_getRemainingUpgradeTime(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getRemainingUpgradeTime(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getRallyPosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getRallyPosition(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getRallyUnit(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getRallyUnit(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getAddon(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getAddon(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getHatchery(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getHatchery(new HandleRef(null,jarg1));
}
}


public IntPtr Unit_getLarva(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getLarva(new HandleRef(null,jarg1));
}
}


public int Unit_getUpgradeLevel(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_getUpgradeLevel(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_exists(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_exists(new HandleRef(null,jarg1));
}
}


public bool Unit_isAccelerating(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isAccelerating(new HandleRef(null,jarg1));
}
}


public bool Unit_isBeingConstructed(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isBeingConstructed(new HandleRef(null,jarg1));
}
}


public bool Unit_isBeingHealed(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isBeingHealed(new HandleRef(null,jarg1));
}
}


public bool Unit_isBlind(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isBlind(new HandleRef(null,jarg1));
}
}


public bool Unit_isBraking(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isBraking(new HandleRef(null,jarg1));
}
}


public bool Unit_isBurrowed(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isBurrowed(new HandleRef(null,jarg1));
}
}


public bool Unit_isCarryingGas(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isCarryingGas(new HandleRef(null,jarg1));
}
}


public bool Unit_isCarryingMinerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isCarryingMinerals(new HandleRef(null,jarg1));
}
}


public bool Unit_isCloaked(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isCloaked(new HandleRef(null,jarg1));
}
}


public bool Unit_isCompleted(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isCompleted(new HandleRef(null,jarg1));
}
}


public bool Unit_isConstructing(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isConstructing(new HandleRef(null,jarg1));
}
}


public bool Unit_isDefenseMatrixed(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isDefenseMatrixed(new HandleRef(null,jarg1));
}
}


public bool Unit_isEnsnared(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isEnsnared(new HandleRef(null,jarg1));
}
}


public bool Unit_isFollowing(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isFollowing(new HandleRef(null,jarg1));
}
}


public bool Unit_isGatheringGas(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isGatheringGas(new HandleRef(null,jarg1));
}
}


public bool Unit_isGatheringMinerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isGatheringMinerals(new HandleRef(null,jarg1));
}
}


public bool Unit_isHallucination(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isHallucination(new HandleRef(null,jarg1));
}
}


public bool Unit_isIdle(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isIdle(new HandleRef(null,jarg1));
}
}


public bool Unit_isIrradiated(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isIrradiated(new HandleRef(null,jarg1));
}
}


public bool Unit_isLifted(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isLifted(new HandleRef(null,jarg1));
}
}


public bool Unit_isLoaded(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isLoaded(new HandleRef(null,jarg1));
}
}


public bool Unit_isLockedDown(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isLockedDown(new HandleRef(null,jarg1));
}
}


public bool Unit_isMaelstrommed(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isMaelstrommed(new HandleRef(null,jarg1));
}
}


public bool Unit_isMorphing(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isMorphing(new HandleRef(null,jarg1));
}
}


public bool Unit_isMoving(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isMoving(new HandleRef(null,jarg1));
}
}


public bool Unit_isParasited(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isParasited(new HandleRef(null,jarg1));
}
}


public bool Unit_isPatrolling(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isPatrolling(new HandleRef(null,jarg1));
}
}


public bool Unit_isPlagued(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isPlagued(new HandleRef(null,jarg1));
}
}


public bool Unit_isRepairing(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isRepairing(new HandleRef(null,jarg1));
}
}


public bool Unit_isResearching(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isResearching(new HandleRef(null,jarg1));
}
}


public bool Unit_isSelected(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isSelected(new HandleRef(null,jarg1));
}
}


public bool Unit_isSieged(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isSieged(new HandleRef(null,jarg1));
}
}


public bool Unit_isStartingAttack(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isStartingAttack(new HandleRef(null,jarg1));
}
}


public bool Unit_isStasised(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isStasised(new HandleRef(null,jarg1));
}
}


public bool Unit_isStimmed(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isStimmed(new HandleRef(null,jarg1));
}
}


public bool Unit_isTraining(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isTraining(new HandleRef(null,jarg1));
}
}


public bool Unit_isUnderStorm(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isUnderStorm(new HandleRef(null,jarg1));
}
}


public bool Unit_isUnpowered(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isUnpowered(new HandleRef(null,jarg1));
}
}


public bool Unit_isUpgrading(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isUpgrading(new HandleRef(null,jarg1));
}
}


public bool Unit_isVisible(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isVisible(new HandleRef(null,jarg1));
}
}


public bool Unit_isBeingGathered(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_isBeingGathered(new HandleRef(null,jarg1));
}
}


public bool Unit_attackMove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_attackMove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_attackUnit(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_attackUnit(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_rightClick__SWIG_0(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_rightClick__SWIG_0(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_rightClick__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_rightClick__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_train(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_train(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_build(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_build(new HandleRef(null,jarg1), new HandleRef(null,jarg2), new HandleRef(null,jarg3));
}
}


public bool Unit_buildAddon(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_buildAddon(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_research(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_research(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_upgrade(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_upgrade(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_stop(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_stop(new HandleRef(null,jarg1));
}
}


public bool Unit_holdPosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_holdPosition(new HandleRef(null,jarg1));
}
}


public bool Unit_patrol(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_patrol(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_follow(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_follow(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_setRallyPosition(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_setRallyPosition(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_setRallyUnit(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_setRallyUnit(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_repair(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_repair(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_returnCargo(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_returnCargo(new HandleRef(null,jarg1));
}
}


public bool Unit_morph(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_morph(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_burrow(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_burrow(new HandleRef(null,jarg1));
}
}


public bool Unit_unburrow(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_unburrow(new HandleRef(null,jarg1));
}
}


public bool Unit_siege(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_siege(new HandleRef(null,jarg1));
}
}


public bool Unit_unsiege(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_unsiege(new HandleRef(null,jarg1));
}
}


public bool Unit_cloak(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_cloak(new HandleRef(null,jarg1));
}
}


public bool Unit_decloak(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_decloak(new HandleRef(null,jarg1));
}
}


public bool Unit_lift(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_lift(new HandleRef(null,jarg1));
}
}


public bool Unit_land(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_land(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_load(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_load(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_unload(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_unload(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_unloadAll__SWIG_0(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_unloadAll__SWIG_0(new HandleRef(null,jarg1));
}
}


public bool Unit_unloadAll__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_unloadAll__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_cancelConstruction(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_cancelConstruction(new HandleRef(null,jarg1));
}
}


public bool Unit_haltConstruction(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_haltConstruction(new HandleRef(null,jarg1));
}
}


public bool Unit_cancelMorph(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_cancelMorph(new HandleRef(null,jarg1));
}
}


public bool Unit_cancelTrain__SWIG_0(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_cancelTrain__SWIG_0(new HandleRef(null,jarg1));
}
}


public bool Unit_cancelTrain__SWIG_1(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_cancelTrain__SWIG_1(new HandleRef(null,jarg1), jarg2);
}
}


public bool Unit_cancelAddon(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_cancelAddon(new HandleRef(null,jarg1));
}
}


public bool Unit_cancelResearch(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_cancelResearch(new HandleRef(null,jarg1));
}
}


public bool Unit_cancelUpgrade(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_cancelUpgrade(new HandleRef(null,jarg1));
}
}


public bool Unit_useTech__SWIG_0(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_useTech__SWIG_0(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool Unit_useTech__SWIG_1(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_useTech__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2), new HandleRef(null,jarg3));
}
}


public bool Unit_useTech__SWIG_2(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Unit_useTech__SWIG_2(new HandleRef(null,jarg1), new HandleRef(null,jarg2), new HandleRef(null,jarg3));
}
}


public void delete_Unit(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_Unit(new HandleRef(null,jarg1));
}
}


public IntPtr new_UnitSizeType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitSizeType__SWIG_0();
}
}


public IntPtr new_UnitSizeType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitSizeType__SWIG_1(jarg1);
}
}


public IntPtr new_UnitSizeType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitSizeType__SWIG_2(new HandleRef(null,jarg1));
}
}


public IntPtr UnitSizeType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSizeType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UnitSizeType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSizeType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UnitSizeType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSizeType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UnitSizeType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSizeType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int UnitSizeType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSizeType_getID(new HandleRef(null,jarg1));
}
}


public string UnitSizeType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSizeType_getName(new HandleRef(null,jarg1));
}
}


public void delete_UnitSizeType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_UnitSizeType(new HandleRef(null,jarg1));
}
}


public IntPtr getUnitSizeType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getUnitSizeType(jarg1);
}
}


public IntPtr allUnitSizeTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.allUnitSizeTypes();
}
}


public void initUnitSizeTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.initUnitSizeTypes();
}
}


public IntPtr UnitSizeTypeIndependent_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSizeTypeIndependent_get();
}
}


public IntPtr Small_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Small_get();
}
}


public IntPtr Medium_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Medium_get();
}
}


public IntPtr Large_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Large_get();
}
}


public IntPtr UnitSizeTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSizeTypeNone_get();
}
}


public IntPtr UnitSizeTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSizeTypeUnknown_get();
}
}


public IntPtr new_UnitType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitType__SWIG_0();
}
}


public IntPtr new_UnitType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitType__SWIG_1(jarg1);
}
}


public IntPtr new_UnitType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitType__SWIG_2(new HandleRef(null,jarg1));
}
}


public IntPtr UnitType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UnitType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UnitType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UnitType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int UnitType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_getID(new HandleRef(null,jarg1));
}
}


public string UnitType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_getName(new HandleRef(null,jarg1));
}
}


public string UnitType_getSubLabel(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_getSubLabel(new HandleRef(null,jarg1));
}
}


public IntPtr UnitType_getRace(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_getRace(new HandleRef(null,jarg1));
}
}


public IntPtr UnitType_whatBuilds(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_whatBuilds(new HandleRef(null,jarg1));
}
}


public IntPtr UnitType_requiredUnits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_requiredUnits(new HandleRef(null,jarg1));
}
}


public IntPtr UnitType_requiredTech(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_requiredTech(new HandleRef(null,jarg1));
}
}


public IntPtr UnitType_abilities(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_abilities(new HandleRef(null,jarg1));
}
}


public IntPtr UnitType_upgrades(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_upgrades(new HandleRef(null,jarg1));
}
}


public IntPtr UnitType_armorUpgrade(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_armorUpgrade(new HandleRef(null,jarg1));
}
}


public int UnitType_maxHitPoints(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_maxHitPoints(new HandleRef(null,jarg1));
}
}


public int UnitType_maxShields(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_maxShields(new HandleRef(null,jarg1));
}
}


public int UnitType_maxEnergy(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_maxEnergy(new HandleRef(null,jarg1));
}
}


public int UnitType_armor(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_armor(new HandleRef(null,jarg1));
}
}


public int UnitType_mineralPrice(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_mineralPrice(new HandleRef(null,jarg1));
}
}


public int UnitType_gasPrice(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_gasPrice(new HandleRef(null,jarg1));
}
}


public int UnitType_buildTime(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_buildTime(new HandleRef(null,jarg1));
}
}


public int UnitType_supplyRequired(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_supplyRequired(new HandleRef(null,jarg1));
}
}


public int UnitType_supplyProvided(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_supplyProvided(new HandleRef(null,jarg1));
}
}


public int UnitType_spaceRequired(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_spaceRequired(new HandleRef(null,jarg1));
}
}


public int UnitType_spaceProvided(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_spaceProvided(new HandleRef(null,jarg1));
}
}


public int UnitType_buildScore(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_buildScore(new HandleRef(null,jarg1));
}
}


public int UnitType_destroyScore(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_destroyScore(new HandleRef(null,jarg1));
}
}


public IntPtr UnitType_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_size(new HandleRef(null,jarg1));
}
}


public int UnitType_tileWidth(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_tileWidth(new HandleRef(null,jarg1));
}
}


public int UnitType_tileHeight(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_tileHeight(new HandleRef(null,jarg1));
}
}


public int UnitType_dimensionLeft(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_dimensionLeft(new HandleRef(null,jarg1));
}
}


public int UnitType_dimensionUp(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_dimensionUp(new HandleRef(null,jarg1));
}
}


public int UnitType_dimensionRight(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_dimensionRight(new HandleRef(null,jarg1));
}
}


public int UnitType_dimensionDown(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_dimensionDown(new HandleRef(null,jarg1));
}
}


public int UnitType_seekRange(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_seekRange(new HandleRef(null,jarg1));
}
}


public int UnitType_sightRange(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_sightRange(new HandleRef(null,jarg1));
}
}


public IntPtr UnitType_groundWeapon(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_groundWeapon(new HandleRef(null,jarg1));
}
}


public int UnitType_maxGroundHits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_maxGroundHits(new HandleRef(null,jarg1));
}
}


public IntPtr UnitType_airWeapon(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_airWeapon(new HandleRef(null,jarg1));
}
}


public int UnitType_maxAirHits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_maxAirHits(new HandleRef(null,jarg1));
}
}


public double UnitType_topSpeed(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_topSpeed(new HandleRef(null,jarg1));
}
}


public int UnitType_acceleration(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_acceleration(new HandleRef(null,jarg1));
}
}


public int UnitType_haltDistance(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_haltDistance(new HandleRef(null,jarg1));
}
}


public int UnitType_turnRadius(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_turnRadius(new HandleRef(null,jarg1));
}
}


public bool UnitType_canProduce(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_canProduce(new HandleRef(null,jarg1));
}
}


public bool UnitType_canAttack(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_canAttack(new HandleRef(null,jarg1));
}
}


public bool UnitType_canMove(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_canMove(new HandleRef(null,jarg1));
}
}


public bool UnitType_isFlyer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isFlyer(new HandleRef(null,jarg1));
}
}


public bool UnitType_regeneratesHP(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_regeneratesHP(new HandleRef(null,jarg1));
}
}


public bool UnitType_isSpellcaster(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isSpellcaster(new HandleRef(null,jarg1));
}
}


public bool UnitType_hasPermanentCloak(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_hasPermanentCloak(new HandleRef(null,jarg1));
}
}


public bool UnitType_isInvincible(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isInvincible(new HandleRef(null,jarg1));
}
}


public bool UnitType_isOrganic(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isOrganic(new HandleRef(null,jarg1));
}
}


public bool UnitType_isMechanical(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isMechanical(new HandleRef(null,jarg1));
}
}


public bool UnitType_isRobotic(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isRobotic(new HandleRef(null,jarg1));
}
}


public bool UnitType_isDetector(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isDetector(new HandleRef(null,jarg1));
}
}


public bool UnitType_isResourceContainer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isResourceContainer(new HandleRef(null,jarg1));
}
}


public bool UnitType_isResourceDepot(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isResourceDepot(new HandleRef(null,jarg1));
}
}


public bool UnitType_isRefinery(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isRefinery(new HandleRef(null,jarg1));
}
}


public bool UnitType_isWorker(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isWorker(new HandleRef(null,jarg1));
}
}


public bool UnitType_requiresPsi(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_requiresPsi(new HandleRef(null,jarg1));
}
}


public bool UnitType_requiresCreep(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_requiresCreep(new HandleRef(null,jarg1));
}
}


public bool UnitType_isTwoUnitsInOneEgg(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isTwoUnitsInOneEgg(new HandleRef(null,jarg1));
}
}


public bool UnitType_isBurrowable(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isBurrowable(new HandleRef(null,jarg1));
}
}


public bool UnitType_isCloakable(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isCloakable(new HandleRef(null,jarg1));
}
}


public bool UnitType_isBuilding(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isBuilding(new HandleRef(null,jarg1));
}
}


public bool UnitType_isAddon(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isAddon(new HandleRef(null,jarg1));
}
}


public bool UnitType_isFlyingBuilding(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isFlyingBuilding(new HandleRef(null,jarg1));
}
}


public bool UnitType_isNeutral(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitType_isNeutral(new HandleRef(null,jarg1));
}
}


public void delete_UnitType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_UnitType(new HandleRef(null,jarg1));
}
}


public IntPtr getUnitType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getUnitType(jarg1);
}
}


public IntPtr allUnitTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.allUnitTypes();
}
}


public void initUnitTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.initUnitTypes();
}
}


public IntPtr Terran_Marine_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Marine_get();
}
}


public IntPtr Terran_Ghost_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Ghost_get();
}
}


public IntPtr Terran_Vulture_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Vulture_get();
}
}


public IntPtr Terran_Goliath_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Goliath_get();
}
}


public IntPtr Terran_Siege_Tank_Tank_Mode_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Siege_Tank_Tank_Mode_get();
}
}


public IntPtr Terran_SCV_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_SCV_get();
}
}


public IntPtr Terran_Wraith_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Wraith_get();
}
}


public IntPtr Terran_Science_Vessel_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Science_Vessel_get();
}
}


public IntPtr Terran_Dropship_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Dropship_get();
}
}


public IntPtr Terran_Battlecruiser_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Battlecruiser_get();
}
}


public IntPtr Terran_Vulture_Spider_Mine_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Vulture_Spider_Mine_get();
}
}


public IntPtr Terran_Nuclear_Missile_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Nuclear_Missile_get();
}
}


public IntPtr Terran_Siege_Tank_Siege_Mode_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Siege_Tank_Siege_Mode_get();
}
}


public IntPtr Terran_Firebat_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Firebat_get();
}
}


public IntPtr Spell_Scanner_Sweep_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Spell_Scanner_Sweep_get();
}
}


public IntPtr Terran_Medic_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Medic_get();
}
}


public IntPtr Zerg_Larva_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Larva_get();
}
}


public IntPtr Zerg_Egg_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Egg_get();
}
}


public IntPtr Zerg_Zergling_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Zergling_get();
}
}


public IntPtr Zerg_Hydralisk_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Hydralisk_get();
}
}


public IntPtr Zerg_Ultralisk_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Ultralisk_get();
}
}


public IntPtr Zerg_Broodling_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Broodling_get();
}
}


public IntPtr Zerg_Drone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Drone_get();
}
}


public IntPtr Zerg_Overlord_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Overlord_get();
}
}


public IntPtr Zerg_Mutalisk_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Mutalisk_get();
}
}


public IntPtr Zerg_Guardian_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Guardian_get();
}
}


public IntPtr Zerg_Queen_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Queen_get();
}
}


public IntPtr Zerg_Defiler_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Defiler_get();
}
}


public IntPtr Zerg_Scourge_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Scourge_get();
}
}


public IntPtr Zerg_Infested_Terran_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Infested_Terran_get();
}
}


public IntPtr Terran_Valkyrie_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Valkyrie_get();
}
}


public IntPtr Zerg_Cocoon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Cocoon_get();
}
}


public IntPtr Protoss_Corsair_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Corsair_get();
}
}


public IntPtr Protoss_Dark_Templar_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Dark_Templar_get();
}
}


public IntPtr Zerg_Devourer_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Devourer_get();
}
}


public IntPtr Protoss_Dark_Archon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Dark_Archon_get();
}
}


public IntPtr Protoss_Probe_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Probe_get();
}
}


public IntPtr Protoss_Zealot_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Zealot_get();
}
}


public IntPtr Protoss_Dragoon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Dragoon_get();
}
}


public IntPtr Protoss_High_Templar_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_High_Templar_get();
}
}


public IntPtr Protoss_Archon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Archon_get();
}
}


public IntPtr Protoss_Shuttle_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Shuttle_get();
}
}


public IntPtr Protoss_Scout_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Scout_get();
}
}


public IntPtr Protoss_Arbiter_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Arbiter_get();
}
}


public IntPtr Protoss_Carrier_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Carrier_get();
}
}


public IntPtr Protoss_Interceptor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Interceptor_get();
}
}


public IntPtr Protoss_Reaver_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Reaver_get();
}
}


public IntPtr Protoss_Observer_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Observer_get();
}
}


public IntPtr Protoss_Scarab_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Scarab_get();
}
}


public IntPtr Critter_Rhynadon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Critter_Rhynadon_get();
}
}


public IntPtr Critter_Bengalaas_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Critter_Bengalaas_get();
}
}


public IntPtr Critter_Scantid_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Critter_Scantid_get();
}
}


public IntPtr Critter_Kakaru_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Critter_Kakaru_get();
}
}


public IntPtr Critter_Ragnasaur_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Critter_Ragnasaur_get();
}
}


public IntPtr Critter_Ursadon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Critter_Ursadon_get();
}
}


public IntPtr Zerg_Lurker_Egg_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Lurker_Egg_get();
}
}


public IntPtr Zerg_Lurker_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Lurker_get();
}
}


public IntPtr Spell_Disruption_Web_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Spell_Disruption_Web_get();
}
}


public IntPtr Terran_Command_Center_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Command_Center_get();
}
}


public IntPtr Terran_Comsat_Station_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Comsat_Station_get();
}
}


public IntPtr Terran_Nuclear_Silo_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Nuclear_Silo_get();
}
}


public IntPtr Terran_Supply_Depot_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Supply_Depot_get();
}
}


public IntPtr Terran_Refinery_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Refinery_get();
}
}


public IntPtr Terran_Barracks_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Barracks_get();
}
}


public IntPtr Terran_Academy_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Academy_get();
}
}


public IntPtr Terran_Factory_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Factory_get();
}
}


public IntPtr Terran_Starport_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Starport_get();
}
}


public IntPtr Terran_Control_Tower_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Control_Tower_get();
}
}


public IntPtr Terran_Science_Facility_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Science_Facility_get();
}
}


public IntPtr Terran_Covert_Ops_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Covert_Ops_get();
}
}


public IntPtr Terran_Physics_Lab_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Physics_Lab_get();
}
}


public IntPtr Terran_Machine_Shop_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Machine_Shop_get();
}
}


public IntPtr Terran_Engineering_Bay_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Engineering_Bay_get();
}
}


public IntPtr Terran_Armory_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Armory_get();
}
}


public IntPtr Terran_Missile_Turret_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Missile_Turret_get();
}
}


public IntPtr Terran_Bunker_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Terran_Bunker_get();
}
}


public IntPtr Special_Crashed_Norad_II_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Special_Crashed_Norad_II_get();
}
}


public IntPtr Special_Ion_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Special_Ion_Cannon_get();
}
}


public IntPtr Zerg_Infested_Command_Center_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Infested_Command_Center_get();
}
}


public IntPtr Zerg_Hatchery_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Hatchery_get();
}
}


public IntPtr Zerg_Lair_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Lair_get();
}
}


public IntPtr Zerg_Hive_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Hive_get();
}
}


public IntPtr Zerg_Nydus_Canal_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Nydus_Canal_get();
}
}


public IntPtr Zerg_Hydralisk_Den_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Hydralisk_Den_get();
}
}


public IntPtr Zerg_Defiler_Mound_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Defiler_Mound_get();
}
}


public IntPtr Zerg_Greater_Spire_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Greater_Spire_get();
}
}


public IntPtr Zerg_Queens_Nest_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Queens_Nest_get();
}
}


public IntPtr Zerg_Evolution_Chamber_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Evolution_Chamber_get();
}
}


public IntPtr Zerg_Ultralisk_Cavern_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Ultralisk_Cavern_get();
}
}


public IntPtr Zerg_Spire_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Spire_get();
}
}


public IntPtr Zerg_Spawning_Pool_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Spawning_Pool_get();
}
}


public IntPtr Zerg_Creep_Colony_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Creep_Colony_get();
}
}


public IntPtr Zerg_Spore_Colony_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Spore_Colony_get();
}
}


public IntPtr Zerg_Sunken_Colony_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Sunken_Colony_get();
}
}


public IntPtr Special_Overmind_With_Shell_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Special_Overmind_With_Shell_get();
}
}


public IntPtr Special_Overmind_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Special_Overmind_get();
}
}


public IntPtr Zerg_Extractor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Zerg_Extractor_get();
}
}


public IntPtr Special_Mature_Chrysalis_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Special_Mature_Chrysalis_get();
}
}


public IntPtr Special_Cerebrate_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Special_Cerebrate_get();
}
}


public IntPtr Special_Cerebrate_Daggoth_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Special_Cerebrate_Daggoth_get();
}
}


public IntPtr Protoss_Nexus_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Nexus_get();
}
}


public IntPtr Protoss_Robotics_Facility_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Robotics_Facility_get();
}
}


public IntPtr Protoss_Pylon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Pylon_get();
}
}


public IntPtr Protoss_Assimilator_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Assimilator_get();
}
}


public IntPtr Protoss_Observatory_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Observatory_get();
}
}


public IntPtr Protoss_Gateway_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Gateway_get();
}
}


public IntPtr Protoss_Photon_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Photon_Cannon_get();
}
}


public IntPtr Protoss_Citadel_of_Adun_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Citadel_of_Adun_get();
}
}


public IntPtr Protoss_Cybernetics_Core_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Cybernetics_Core_get();
}
}


public IntPtr Protoss_Templar_Archives_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Templar_Archives_get();
}
}


public IntPtr Protoss_Forge_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Forge_get();
}
}


public IntPtr Protoss_Stargate_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Stargate_get();
}
}


public IntPtr Special_Stasis_Cell_Prison_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Special_Stasis_Cell_Prison_get();
}
}


public IntPtr Protoss_Fleet_Beacon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Fleet_Beacon_get();
}
}


public IntPtr Protoss_Arbiter_Tribunal_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Arbiter_Tribunal_get();
}
}


public IntPtr Protoss_Robotics_Support_Bay_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Robotics_Support_Bay_get();
}
}


public IntPtr Protoss_Shield_Battery_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Protoss_Shield_Battery_get();
}
}


public IntPtr Special_Khaydarin_Crystal_Form_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Special_Khaydarin_Crystal_Form_get();
}
}


public IntPtr Special_Protoss_Temple_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Special_Protoss_Temple_get();
}
}


public IntPtr Special_XelNaga_Temple_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Special_XelNaga_Temple_get();
}
}


public IntPtr Resource_Mineral_Field_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Resource_Mineral_Field_get();
}
}


public IntPtr Resource_Vespene_Geyser_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Resource_Vespene_Geyser_get();
}
}


public IntPtr Special_Warp_Gate_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Special_Warp_Gate_get();
}
}


public IntPtr Special_Psi_Disrupter_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Special_Psi_Disrupter_get();
}
}


public IntPtr Special_Power_Generator_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Special_Power_Generator_get();
}
}


public IntPtr Special_Overmind_Cocoon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Special_Overmind_Cocoon_get();
}
}


public IntPtr Spell_Dark_Swarm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Spell_Dark_Swarm_get();
}
}


public IntPtr UnitTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypeNone_get();
}
}


public IntPtr UnitTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypeUnknown_get();
}
}


public IntPtr new_WeaponType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_WeaponType__SWIG_0();
}
}


public IntPtr new_WeaponType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_WeaponType__SWIG_1(jarg1);
}
}


public IntPtr new_WeaponType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_WeaponType__SWIG_2(new HandleRef(null,jarg1));
}
}


public IntPtr WeaponType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool WeaponType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool WeaponType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool WeaponType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public int WeaponType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_getID(new HandleRef(null,jarg1));
}
}


public string WeaponType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_getName(new HandleRef(null,jarg1));
}
}


public IntPtr WeaponType_getTech(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_getTech(new HandleRef(null,jarg1));
}
}


public IntPtr WeaponType_whatUses(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_whatUses(new HandleRef(null,jarg1));
}
}


public int WeaponType_damageAmount(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_damageAmount(new HandleRef(null,jarg1));
}
}


public int WeaponType_damageBonus(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_damageBonus(new HandleRef(null,jarg1));
}
}


public int WeaponType_damageCooldown(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_damageCooldown(new HandleRef(null,jarg1));
}
}


public int WeaponType_damageFactor(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_damageFactor(new HandleRef(null,jarg1));
}
}


public IntPtr WeaponType_upgradeType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_upgradeType(new HandleRef(null,jarg1));
}
}


public IntPtr WeaponType_damageType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_damageType(new HandleRef(null,jarg1));
}
}


public IntPtr WeaponType_explosionType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_explosionType(new HandleRef(null,jarg1));
}
}


public int WeaponType_minRange(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_minRange(new HandleRef(null,jarg1));
}
}


public int WeaponType_maxRange(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_maxRange(new HandleRef(null,jarg1));
}
}


public int WeaponType_innerSplashRadius(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_innerSplashRadius(new HandleRef(null,jarg1));
}
}


public int WeaponType_medianSplashRadius(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_medianSplashRadius(new HandleRef(null,jarg1));
}
}


public int WeaponType_outerSplashRadius(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_outerSplashRadius(new HandleRef(null,jarg1));
}
}


public bool WeaponType_targetsAir(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_targetsAir(new HandleRef(null,jarg1));
}
}


public bool WeaponType_targetsGround(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_targetsGround(new HandleRef(null,jarg1));
}
}


public bool WeaponType_targetsMechanical(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_targetsMechanical(new HandleRef(null,jarg1));
}
}


public bool WeaponType_targetsOrganic(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_targetsOrganic(new HandleRef(null,jarg1));
}
}


public bool WeaponType_targetsNonBuilding(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_targetsNonBuilding(new HandleRef(null,jarg1));
}
}


public bool WeaponType_targetsNonRobotic(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_targetsNonRobotic(new HandleRef(null,jarg1));
}
}


public bool WeaponType_targetsTerrain(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_targetsTerrain(new HandleRef(null,jarg1));
}
}


public bool WeaponType_targetsOrgOrMech(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_targetsOrgOrMech(new HandleRef(null,jarg1));
}
}


public bool WeaponType_targetsOwn(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponType_targetsOwn(new HandleRef(null,jarg1));
}
}


public void delete_WeaponType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_WeaponType(new HandleRef(null,jarg1));
}
}


public IntPtr getWeaponType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getWeaponType(jarg1);
}
}


public IntPtr allWeaponTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.allWeaponTypes();
}
}


public IntPtr normalWeaponTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.normalWeaponTypes();
}
}


public IntPtr specialWeaponTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.specialWeaponTypes();
}
}


public void initWeaponTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.initWeaponTypes();
}
}


public IntPtr Gauss_Rifle_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Gauss_Rifle_get();
}
}


public IntPtr C_10_Canister_Rifle_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.C_10_Canister_Rifle_get();
}
}


public IntPtr WeaponTypeFragmentation_Grenade_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeFragmentation_Grenade_get();
}
}


public IntPtr WeaponTypeSpider_Mines_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeSpider_Mines_get();
}
}


public IntPtr Twin_Autocannons_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Twin_Autocannons_get();
}
}


public IntPtr Hellfire_Missile_Pack_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Hellfire_Missile_Pack_get();
}
}


public IntPtr Arclite_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Arclite_Cannon_get();
}
}


public IntPtr Fusion_Cutter_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Fusion_Cutter_get();
}
}


public IntPtr WeaponTypeGemini_Missiles_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeGemini_Missiles_get();
}
}


public IntPtr WeaponTypeBurst_Lasers_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeBurst_Lasers_get();
}
}


public IntPtr ATS_Laser_Battery_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ATS_Laser_Battery_get();
}
}


public IntPtr ATA_Laser_Battery_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ATA_Laser_Battery_get();
}
}


public IntPtr Flame_Thrower_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Flame_Thrower_get();
}
}


public IntPtr Arclite_Shock_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Arclite_Shock_Cannon_get();
}
}


public IntPtr WeaponTypeLongbolt_Missile_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeLongbolt_Missile_get();
}
}


public IntPtr Claws_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Claws_get();
}
}


public IntPtr Needle_Spines_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Needle_Spines_get();
}
}


public IntPtr Kaiser_Blades_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Kaiser_Blades_get();
}
}


public IntPtr Toxic_Spores_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Toxic_Spores_get();
}
}


public IntPtr Spines_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Spines_get();
}
}


public IntPtr WeaponTypeAcid_Spore_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeAcid_Spore_get();
}
}


public IntPtr WeaponTypeGlave_Wurm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeGlave_Wurm_get();
}
}


public IntPtr WeaponTypeSeeker_Spores_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeSeeker_Spores_get();
}
}


public IntPtr Subterranean_Tentacle_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Subterranean_Tentacle_get();
}
}


public IntPtr Suicide_Infested_Terran_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Suicide_Infested_Terran_get();
}
}


public IntPtr Suicide_Scourge_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Suicide_Scourge_get();
}
}


public IntPtr Particle_Beam_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Particle_Beam_get();
}
}


public IntPtr Psi_Blades_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Psi_Blades_get();
}
}


public IntPtr WeaponTypePhase_Disruptor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypePhase_Disruptor_get();
}
}


public IntPtr Psionic_Shockwave_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Psionic_Shockwave_get();
}
}


public IntPtr Dual_Photon_Blasters_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Dual_Photon_Blasters_get();
}
}


public IntPtr Anti_Matter_Missiles_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Anti_Matter_Missiles_get();
}
}


public IntPtr Phase_Disruptor_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Phase_Disruptor_Cannon_get();
}
}


public IntPtr WeaponTypePulse_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypePulse_Cannon_get();
}
}


public IntPtr STS_Photon_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.STS_Photon_Cannon_get();
}
}


public IntPtr STA_Photon_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.STA_Photon_Cannon_get();
}
}


public IntPtr Scarab_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Scarab_get();
}
}


public IntPtr WeaponTypeNeutron_Flare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeNeutron_Flare_get();
}
}


public IntPtr WeaponTypeHalo_Rockets_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeHalo_Rockets_get();
}
}


public IntPtr WeaponTypeCorrosive_Acid_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeCorrosive_Acid_get();
}
}


public IntPtr WeaponTypeSubterranean_Spines_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeSubterranean_Spines_get();
}
}


public IntPtr Warp_Blades_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Warp_Blades_get();
}
}


public IntPtr WeaponTypeYamato_Gun_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeYamato_Gun_get();
}
}


public IntPtr WeaponTypeNuclear_Strike_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeNuclear_Strike_get();
}
}


public IntPtr Lockdown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Lockdown_get();
}
}


public IntPtr EMP_Shockwave_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.EMP_Shockwave_get();
}
}


public IntPtr WeaponTypeIrradiate_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeIrradiate_get();
}
}


public IntPtr Parasite_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Parasite_get();
}
}


public IntPtr Spawn_Broodlings_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Spawn_Broodlings_get();
}
}


public IntPtr WeaponTypeEnsnare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeEnsnare_get();
}
}


public IntPtr Dark_Swarm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Dark_Swarm_get();
}
}


public IntPtr WeaponTypePlague_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypePlague_get();
}
}


public IntPtr WeaponTypeConsume_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeConsume_get();
}
}


public IntPtr Stasis_Field_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Stasis_Field_get();
}
}


public IntPtr WeaponTypePsionic_Storm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypePsionic_Storm_get();
}
}


public IntPtr Disruption_Web_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Disruption_Web_get();
}
}


public IntPtr WeaponTypeRestoration_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeRestoration_get();
}
}


public IntPtr WeaponTypeMind_Control_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeMind_Control_get();
}
}


public IntPtr Feedback_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Feedback_get();
}
}


public IntPtr Optical_Flare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Optical_Flare_get();
}
}


public IntPtr Maelstrom_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Maelstrom_get();
}
}


public IntPtr WeaponTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeNone_get();
}
}


public IntPtr WeaponTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeUnknown_get();
}
}


public IntPtr monobridgeutil_getLastUnitParam( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.monobridgeutil_getLastUnitParam();
}
}


public IntPtr new_monobridgeutil( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_monobridgeutil();
}
}


public void delete_monobridgeutil(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_monobridgeutil(new HandleRef(null,jarg1));
}
}


public IntPtr new_RectangleArrayDouble__SWIG_0(uint jarg1, uint jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_RectangleArrayDouble__SWIG_0(jarg1, jarg2, new HandleRef(null,jarg3));
}
}


public IntPtr new_RectangleArrayDouble__SWIG_1(uint jarg1, uint jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_RectangleArrayDouble__SWIG_1(jarg1, jarg2);
}
}


public IntPtr new_RectangleArrayDouble__SWIG_2(uint jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_RectangleArrayDouble__SWIG_2(jarg1);
}
}


public IntPtr new_RectangleArrayDouble__SWIG_3( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_RectangleArrayDouble__SWIG_3();
}
}


public IntPtr new_RectangleArrayDouble__SWIG_4(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_RectangleArrayDouble__SWIG_4(new HandleRef(null,jarg1));
}
}


public void delete_RectangleArrayDouble(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_RectangleArrayDouble(new HandleRef(null,jarg1));
}
}


public uint RectangleArrayDouble_getWidth(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RectangleArrayDouble_getWidth(new HandleRef(null,jarg1));
}
}


public uint RectangleArrayDouble_getHeight(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RectangleArrayDouble_getHeight(new HandleRef(null,jarg1));
}
}


public IntPtr RectangleArrayDouble_getItem(IntPtr jarg1, uint jarg2, uint jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RectangleArrayDouble_getItem(new HandleRef(null,jarg1), jarg2, jarg3);
}
}


public void RectangleArrayDouble_setItem(IntPtr jarg1, uint jarg2, uint jarg3, IntPtr jarg4) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.RectangleArrayDouble_setItem(new HandleRef(null,jarg1), jarg2, jarg3, new HandleRef(null,jarg4));
}
}


public void RectangleArrayDouble_resize(IntPtr jarg1, uint jarg2, uint jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.RectangleArrayDouble_resize(new HandleRef(null,jarg1), jarg2, jarg3);
}
}


public void RectangleArrayDouble_printToFile(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.RectangleArrayDouble_printToFile(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void RectangleArrayDouble_saveToFile(IntPtr jarg1, string jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.RectangleArrayDouble_saveToFile(new HandleRef(null,jarg1), jarg2);
}
}


public void RectangleArrayDouble_setTo(IntPtr jarg1, double jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.RectangleArrayDouble_setTo(new HandleRef(null,jarg1), jarg2);
}
}


public void RectangleArrayDouble_setBorderTo(IntPtr jarg1, double jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.RectangleArrayDouble_setBorderTo(new HandleRef(null,jarg1), jarg2);
}
}


public void readMap( ) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.readMap();
}
}


public void analyze( ) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.analyze();
}
}


public IntPtr getRegions( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getRegions();
}
}


public IntPtr getChokepoints( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getChokepoints();
}
}


public IntPtr getBaseLocations( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getBaseLocations();
}
}


public IntPtr getStartLocations( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getStartLocations();
}
}


public IntPtr getUnwalkablePolygons( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getUnwalkablePolygons();
}
}


public IntPtr getStartLocation(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getStartLocation(new HandleRef(null,jarg1));
}
}


public IntPtr getRegion__SWIG_0(int jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getRegion__SWIG_0(jarg1, jarg2);
}
}


public IntPtr getRegion__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getRegion__SWIG_1(new HandleRef(null,jarg1));
}
}


public IntPtr getNearestChokepoint__SWIG_0(int jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getNearestChokepoint__SWIG_0(jarg1, jarg2);
}
}


public IntPtr getNearestChokepoint__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getNearestChokepoint__SWIG_1(new HandleRef(null,jarg1));
}
}


public IntPtr getNearestBaseLocation__SWIG_0(int jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getNearestBaseLocation__SWIG_0(jarg1, jarg2);
}
}


public IntPtr getNearestBaseLocation__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getNearestBaseLocation__SWIG_1(new HandleRef(null,jarg1));
}
}


public IntPtr getNearestUnwalkablePolygon__SWIG_0(int jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getNearestUnwalkablePolygon__SWIG_0(jarg1, jarg2);
}
}


public IntPtr getNearestUnwalkablePolygon__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getNearestUnwalkablePolygon__SWIG_1(new HandleRef(null,jarg1));
}
}


public IntPtr getNearestUnwalkablePosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getNearestUnwalkablePosition(new HandleRef(null,jarg1));
}
}


public bool isConnected__SWIG_0(int jarg1, int jarg2, int jarg3, int jarg4) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.isConnected__SWIG_0(jarg1, jarg2, jarg3, jarg4);
}
}


public bool isConnected__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.isConnected__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public double getGroundDistance(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getGroundDistance(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr getNearestTilePosition(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getNearestTilePosition(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr getGroundDistances(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getGroundDistances(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void getGroundDistanceMap(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.getGroundDistanceMap(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr getShortestPath__SWIG_0(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getShortestPath__SWIG_0(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr getShortestPath__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.getShortestPath__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr BaseLocation_getPosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocation_getPosition(new HandleRef(null,jarg1));
}
}


public IntPtr BaseLocation_getTilePosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocation_getTilePosition(new HandleRef(null,jarg1));
}
}


public IntPtr BaseLocation_getRegion(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocation_getRegion(new HandleRef(null,jarg1));
}
}


public int BaseLocation_minerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocation_minerals(new HandleRef(null,jarg1));
}
}


public int BaseLocation_gas(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocation_gas(new HandleRef(null,jarg1));
}
}


public IntPtr BaseLocation_getMinerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocation_getMinerals(new HandleRef(null,jarg1));
}
}


public IntPtr BaseLocation_getStaticMinerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocation_getStaticMinerals(new HandleRef(null,jarg1));
}
}


public IntPtr BaseLocation_getGeysers(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocation_getGeysers(new HandleRef(null,jarg1));
}
}


public double BaseLocation_getGroundDistance(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocation_getGroundDistance(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public double BaseLocation_getAirDistance(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocation_getAirDistance(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool BaseLocation_isIsland(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocation_isIsland(new HandleRef(null,jarg1));
}
}


public bool BaseLocation_isMineralOnly(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocation_isMineralOnly(new HandleRef(null,jarg1));
}
}


public bool BaseLocation_isStartLocation(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocation_isStartLocation(new HandleRef(null,jarg1));
}
}


public void delete_BaseLocation(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_BaseLocation(new HandleRef(null,jarg1));
}
}


public IntPtr Chokepoint_getRegions(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Chokepoint_getRegions(new HandleRef(null,jarg1));
}
}


public IntPtr Chokepoint_getSides(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Chokepoint_getSides(new HandleRef(null,jarg1));
}
}


public IntPtr Chokepoint_getCenter(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Chokepoint_getCenter(new HandleRef(null,jarg1));
}
}


public double Chokepoint_getWidth(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Chokepoint_getWidth(new HandleRef(null,jarg1));
}
}


public void delete_Chokepoint(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_Chokepoint(new HandleRef(null,jarg1));
}
}


public void PositionVector_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PositionVector_Clear(new HandleRef(null,jarg1));
}
}


public void PositionVector_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PositionVector_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public uint PositionVector_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PositionVector_size(new HandleRef(null,jarg1));
}
}


public uint PositionVector_capacity(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PositionVector_capacity(new HandleRef(null,jarg1));
}
}


public void PositionVector_reserve(IntPtr jarg1, uint jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PositionVector_reserve(new HandleRef(null,jarg1), jarg2);
}
}


public IntPtr new_PositionVector__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_PositionVector__SWIG_0();
}
}


public IntPtr new_PositionVector__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_PositionVector__SWIG_1(new HandleRef(null,jarg1));
}
}


public IntPtr new_PositionVector__SWIG_2(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_PositionVector__SWIG_2(jarg1);
}
}


public IntPtr PositionVector_getitemcopy(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PositionVector_getitemcopy(new HandleRef(null,jarg1), jarg2);
}
}


public IntPtr PositionVector_getitem(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PositionVector_getitem(new HandleRef(null,jarg1), jarg2);
}
}


public void PositionVector_setitem(IntPtr jarg1, int jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PositionVector_setitem(new HandleRef(null,jarg1), jarg2, new HandleRef(null,jarg3));
}
}


public void PositionVector_AddRange(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PositionVector_AddRange(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr PositionVector_GetRange(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PositionVector_GetRange(new HandleRef(null,jarg1), jarg2, jarg3);
}
}


public void PositionVector_Insert(IntPtr jarg1, int jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PositionVector_Insert(new HandleRef(null,jarg1), jarg2, new HandleRef(null,jarg3));
}
}


public void PositionVector_InsertRange(IntPtr jarg1, int jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PositionVector_InsertRange(new HandleRef(null,jarg1), jarg2, new HandleRef(null,jarg3));
}
}


public void PositionVector_RemoveAt(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PositionVector_RemoveAt(new HandleRef(null,jarg1), jarg2);
}
}


public void PositionVector_RemoveRange(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PositionVector_RemoveRange(new HandleRef(null,jarg1), jarg2, jarg3);
}
}


public IntPtr PositionVector_Repeat(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PositionVector_Repeat(new HandleRef(null,jarg1), jarg2);
}
}


public void PositionVector_Reverse__SWIG_0(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PositionVector_Reverse__SWIG_0(new HandleRef(null,jarg1));
}
}


public void PositionVector_Reverse__SWIG_1(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PositionVector_Reverse__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3);
}
}


public void PositionVector_SetRange(IntPtr jarg1, int jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PositionVector_SetRange(new HandleRef(null,jarg1), jarg2, new HandleRef(null,jarg3));
}
}


public void delete_PositionVector(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_PositionVector(new HandleRef(null,jarg1));
}
}


public IntPtr new_Polygon( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_Polygon();
}
}


public double Polygon_getArea(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Polygon_getArea(new HandleRef(null,jarg1));
}
}


public double Polygon_getPerimeter(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Polygon_getPerimeter(new HandleRef(null,jarg1));
}
}


public IntPtr Polygon_getCenter(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Polygon_getCenter(new HandleRef(null,jarg1));
}
}


public bool Polygon_isInside(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Polygon_isInside(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr Polygon_getNearestPoint(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Polygon_getNearestPoint(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void delete_Polygon(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_Polygon(new HandleRef(null,jarg1));
}
}


public IntPtr Region_getPolygon(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Region_getPolygon(new HandleRef(null,jarg1));
}
}


public IntPtr Region_getCenter(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Region_getCenter(new HandleRef(null,jarg1));
}
}


public IntPtr Region_getChokepoints(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Region_getChokepoints(new HandleRef(null,jarg1));
}
}


public IntPtr Region_getBaseLocations(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Region_getBaseLocations(new HandleRef(null,jarg1));
}
}


public bool Region_isReachable(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Region_isReachable(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr Region_getReachableRegions(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.Region_getReachableRegions(new HandleRef(null,jarg1));
}
}


public void delete_Region(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_Region(new HandleRef(null,jarg1));
}
}


public IntPtr new_UnitSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitSet__SWIG_0();
}
}


public IntPtr new_UnitSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint UnitSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSet_size(new HandleRef(null,jarg1));
}
}


public bool UnitSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSet_empty(new HandleRef(null,jarg1));
}
}


public void UnitSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UnitSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr UnitSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UnitSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void UnitSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UnitSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UnitSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr UnitSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr UnitSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_UnitSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_UnitSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_AttackTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_AttackTypeSet__SWIG_0();
}
}


public IntPtr new_AttackTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_AttackTypeSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint AttackTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeSet_size(new HandleRef(null,jarg1));
}
}


public bool AttackTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeSet_empty(new HandleRef(null,jarg1));
}
}


public void AttackTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.AttackTypeSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr AttackTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool AttackTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void AttackTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.AttackTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool AttackTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr AttackTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr AttackTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.AttackTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_AttackTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_AttackTypeSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_DamageTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_DamageTypeSet__SWIG_0();
}
}


public IntPtr new_DamageTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_DamageTypeSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint DamageTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DamageTypeSet_size(new HandleRef(null,jarg1));
}
}


public bool DamageTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DamageTypeSet_empty(new HandleRef(null,jarg1));
}
}


public void DamageTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.DamageTypeSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr DamageTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DamageTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool DamageTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DamageTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void DamageTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.DamageTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool DamageTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DamageTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr DamageTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DamageTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr DamageTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.DamageTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_DamageTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_DamageTypeSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_ErrorSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_ErrorSet__SWIG_0();
}
}


public IntPtr new_ErrorSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_ErrorSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint ErrorSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ErrorSet_size(new HandleRef(null,jarg1));
}
}


public bool ErrorSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ErrorSet_empty(new HandleRef(null,jarg1));
}
}


public void ErrorSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.ErrorSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr ErrorSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ErrorSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool ErrorSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ErrorSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void ErrorSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.ErrorSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool ErrorSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ErrorSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr ErrorSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ErrorSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr ErrorSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ErrorSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_ErrorSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_ErrorSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_ExplosionTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_ExplosionTypeSet__SWIG_0();
}
}


public IntPtr new_ExplosionTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_ExplosionTypeSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint ExplosionTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeSet_size(new HandleRef(null,jarg1));
}
}


public bool ExplosionTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeSet_empty(new HandleRef(null,jarg1));
}
}


public void ExplosionTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.ExplosionTypeSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr ExplosionTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool ExplosionTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void ExplosionTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.ExplosionTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool ExplosionTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr ExplosionTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr ExplosionTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ExplosionTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_ExplosionTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_ExplosionTypeSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_ForcePtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_ForcePtrSet__SWIG_0();
}
}


public IntPtr new_ForcePtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_ForcePtrSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint ForcePtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ForcePtrSet_size(new HandleRef(null,jarg1));
}
}


public bool ForcePtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ForcePtrSet_empty(new HandleRef(null,jarg1));
}
}


public void ForcePtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.ForcePtrSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr ForcePtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ForcePtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool ForcePtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ForcePtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void ForcePtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.ForcePtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool ForcePtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ForcePtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr ForcePtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ForcePtrSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr ForcePtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ForcePtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_ForcePtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_ForcePtrSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_OrderSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_OrderSet__SWIG_0();
}
}


public IntPtr new_OrderSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_OrderSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint OrderSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.OrderSet_size(new HandleRef(null,jarg1));
}
}


public bool OrderSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.OrderSet_empty(new HandleRef(null,jarg1));
}
}


public void OrderSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.OrderSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr OrderSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.OrderSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool OrderSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.OrderSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void OrderSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.OrderSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool OrderSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.OrderSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr OrderSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.OrderSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr OrderSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.OrderSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_OrderSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_OrderSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_PlayerPtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_PlayerPtrSet__SWIG_0();
}
}


public IntPtr new_PlayerPtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_PlayerPtrSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint PlayerPtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerPtrSet_size(new HandleRef(null,jarg1));
}
}


public bool PlayerPtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerPtrSet_empty(new HandleRef(null,jarg1));
}
}


public void PlayerPtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PlayerPtrSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr PlayerPtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerPtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool PlayerPtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerPtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void PlayerPtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PlayerPtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool PlayerPtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerPtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr PlayerPtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerPtrSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr PlayerPtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerPtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_PlayerPtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_PlayerPtrSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_PlayerTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_PlayerTypeSet__SWIG_0();
}
}


public IntPtr new_PlayerTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_PlayerTypeSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint PlayerTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerTypeSet_size(new HandleRef(null,jarg1));
}
}


public bool PlayerTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerTypeSet_empty(new HandleRef(null,jarg1));
}
}


public void PlayerTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PlayerTypeSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr PlayerTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool PlayerTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void PlayerTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PlayerTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool PlayerTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr PlayerTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr PlayerTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PlayerTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_PlayerTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_PlayerTypeSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_RaceSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_RaceSet__SWIG_0();
}
}


public IntPtr new_RaceSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_RaceSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint RaceSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RaceSet_size(new HandleRef(null,jarg1));
}
}


public bool RaceSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RaceSet_empty(new HandleRef(null,jarg1));
}
}


public void RaceSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.RaceSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr RaceSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RaceSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool RaceSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RaceSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void RaceSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.RaceSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool RaceSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RaceSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr RaceSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RaceSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr RaceSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RaceSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_RaceSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_RaceSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_TechTypePtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TechTypePtrSet__SWIG_0();
}
}


public IntPtr new_TechTypePtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TechTypePtrSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint TechTypePtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypePtrSet_size(new HandleRef(null,jarg1));
}
}


public bool TechTypePtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypePtrSet_empty(new HandleRef(null,jarg1));
}
}


public void TechTypePtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TechTypePtrSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr TechTypePtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypePtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool TechTypePtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypePtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void TechTypePtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TechTypePtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool TechTypePtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypePtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr TechTypePtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypePtrSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr TechTypePtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypePtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_TechTypePtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_TechTypePtrSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_TechTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TechTypeSet__SWIG_0();
}
}


public IntPtr new_TechTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TechTypeSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint TechTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeSet_size(new HandleRef(null,jarg1));
}
}


public bool TechTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeSet_empty(new HandleRef(null,jarg1));
}
}


public void TechTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TechTypeSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr TechTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool TechTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void TechTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TechTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool TechTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr TechTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr TechTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TechTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_TechTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_TechTypeSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_UnitSizeTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitSizeTypeSet__SWIG_0();
}
}


public IntPtr new_UnitSizeTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitSizeTypeSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint UnitSizeTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSizeTypeSet_size(new HandleRef(null,jarg1));
}
}


public bool UnitSizeTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSizeTypeSet_empty(new HandleRef(null,jarg1));
}
}


public void UnitSizeTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UnitSizeTypeSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr UnitSizeTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSizeTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UnitSizeTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSizeTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void UnitSizeTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UnitSizeTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UnitSizeTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSizeTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr UnitSizeTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSizeTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr UnitSizeTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitSizeTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_UnitSizeTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_UnitSizeTypeSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_UnitTypePtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitTypePtrSet__SWIG_0();
}
}


public IntPtr new_UnitTypePtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitTypePtrSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint UnitTypePtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypePtrSet_size(new HandleRef(null,jarg1));
}
}


public bool UnitTypePtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypePtrSet_empty(new HandleRef(null,jarg1));
}
}


public void UnitTypePtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UnitTypePtrSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr UnitTypePtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypePtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UnitTypePtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypePtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void UnitTypePtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UnitTypePtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UnitTypePtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypePtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr UnitTypePtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypePtrSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr UnitTypePtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypePtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_UnitTypePtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_UnitTypePtrSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_UnitTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitTypeSet__SWIG_0();
}
}


public IntPtr new_UnitTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitTypeSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint UnitTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypeSet_size(new HandleRef(null,jarg1));
}
}


public bool UnitTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypeSet_empty(new HandleRef(null,jarg1));
}
}


public void UnitTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UnitTypeSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr UnitTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UnitTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void UnitTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UnitTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UnitTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr UnitTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr UnitTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_UnitTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_UnitTypeSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_UpgradeTypePtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UpgradeTypePtrSet__SWIG_0();
}
}


public IntPtr new_UpgradeTypePtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UpgradeTypePtrSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint UpgradeTypePtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeTypePtrSet_size(new HandleRef(null,jarg1));
}
}


public bool UpgradeTypePtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeTypePtrSet_empty(new HandleRef(null,jarg1));
}
}


public void UpgradeTypePtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UpgradeTypePtrSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr UpgradeTypePtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeTypePtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UpgradeTypePtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeTypePtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void UpgradeTypePtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UpgradeTypePtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UpgradeTypePtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeTypePtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr UpgradeTypePtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeTypePtrSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr UpgradeTypePtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeTypePtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_UpgradeTypePtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_UpgradeTypePtrSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_UpgradeTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UpgradeTypeSet__SWIG_0();
}
}


public IntPtr new_UpgradeTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UpgradeTypeSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint UpgradeTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeTypeSet_size(new HandleRef(null,jarg1));
}
}


public bool UpgradeTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeTypeSet_empty(new HandleRef(null,jarg1));
}
}


public void UpgradeTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UpgradeTypeSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr UpgradeTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UpgradeTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void UpgradeTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UpgradeTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UpgradeTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr UpgradeTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr UpgradeTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UpgradeTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_UpgradeTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_UpgradeTypeSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_WeaponTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_WeaponTypeSet__SWIG_0();
}
}


public IntPtr new_WeaponTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_WeaponTypeSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint WeaponTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeSet_size(new HandleRef(null,jarg1));
}
}


public bool WeaponTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeSet_empty(new HandleRef(null,jarg1));
}
}


public void WeaponTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.WeaponTypeSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr WeaponTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool WeaponTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void WeaponTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.WeaponTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool WeaponTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr WeaponTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr WeaponTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.WeaponTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_WeaponTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_WeaponTypeSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_PositionPair__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_PositionPair__SWIG_0();
}
}


public IntPtr new_PositionPair__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_PositionPair__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr new_PositionPair__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_PositionPair__SWIG_2(new HandleRef(null,jarg1));
}
}


public void PositionPair_first_set(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PositionPair_first_set(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr PositionPair_first_get(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PositionPair_first_get(new HandleRef(null,jarg1));
}
}


public void PositionPair_second_set(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PositionPair_second_set(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr PositionPair_second_get(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PositionPair_second_get(new HandleRef(null,jarg1));
}
}


public void delete_PositionPair(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_PositionPair(new HandleRef(null,jarg1));
}
}


public IntPtr new_UnitTypePtrIntPair__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitTypePtrIntPair__SWIG_0();
}
}


public IntPtr new_UnitTypePtrIntPair__SWIG_1(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitTypePtrIntPair__SWIG_1(new HandleRef(null,jarg1), jarg2);
}
}


public IntPtr new_UnitTypePtrIntPair__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitTypePtrIntPair__SWIG_2(new HandleRef(null,jarg1));
}
}


public void UnitTypePtrIntPair_first_set(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UnitTypePtrIntPair_first_set(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr UnitTypePtrIntPair_first_get(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypePtrIntPair_first_get(new HandleRef(null,jarg1));
}
}


public void UnitTypePtrIntPair_second_set(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UnitTypePtrIntPair_second_set(new HandleRef(null,jarg1), jarg2);
}
}


public int UnitTypePtrIntPair_second_get(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypePtrIntPair_second_get(new HandleRef(null,jarg1));
}
}


public void delete_UnitTypePtrIntPair(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_UnitTypePtrIntPair(new HandleRef(null,jarg1));
}
}


public IntPtr new_TilePositionSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TilePositionSet__SWIG_0();
}
}


public IntPtr new_TilePositionSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TilePositionSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint TilePositionSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionSet_size(new HandleRef(null,jarg1));
}
}


public bool TilePositionSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionSet_empty(new HandleRef(null,jarg1));
}
}


public void TilePositionSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr TilePositionSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool TilePositionSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void TilePositionSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool TilePositionSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr TilePositionSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr TilePositionSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_TilePositionSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_TilePositionSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_TilePositionDoubleMap__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TilePositionDoubleMap__SWIG_0();
}
}


public IntPtr new_TilePositionDoubleMap__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TilePositionDoubleMap__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint TilePositionDoubleMap_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionDoubleMap_size(new HandleRef(null,jarg1));
}
}


public bool TilePositionDoubleMap_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionDoubleMap_empty(new HandleRef(null,jarg1));
}
}


public void TilePositionDoubleMap_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionDoubleMap_Clear(new HandleRef(null,jarg1));
}
}


public double TilePositionDoubleMap_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionDoubleMap_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void TilePositionDoubleMap_setitem(IntPtr jarg1, IntPtr jarg2, double jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionDoubleMap_setitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2), jarg3);
}
}


public bool TilePositionDoubleMap_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionDoubleMap_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void TilePositionDoubleMap_Add(IntPtr jarg1, IntPtr jarg2, double jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionDoubleMap_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2), jarg3);
}
}


public bool TilePositionDoubleMap_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionDoubleMap_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr TilePositionDoubleMap_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionDoubleMap_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr TilePositionDoubleMap_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionDoubleMap_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_TilePositionDoubleMap(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_TilePositionDoubleMap(new HandleRef(null,jarg1));
}
}


public IntPtr new_TilePositionDoublePair__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TilePositionDoublePair__SWIG_0();
}
}


public IntPtr new_TilePositionDoublePair__SWIG_1(IntPtr jarg1, double jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TilePositionDoublePair__SWIG_1(new HandleRef(null,jarg1), jarg2);
}
}


public IntPtr new_TilePositionDoublePair__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TilePositionDoublePair__SWIG_2(new HandleRef(null,jarg1));
}
}


public void TilePositionDoublePair_first_set(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionDoublePair_first_set(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr TilePositionDoublePair_first_get(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionDoublePair_first_get(new HandleRef(null,jarg1));
}
}


public void TilePositionDoublePair_second_set(IntPtr jarg1, double jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionDoublePair_second_set(new HandleRef(null,jarg1), jarg2);
}
}


public double TilePositionDoublePair_second_get(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionDoublePair_second_get(new HandleRef(null,jarg1));
}
}


public void delete_TilePositionDoublePair(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_TilePositionDoublePair(new HandleRef(null,jarg1));
}
}


public void TilePositionVector_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionVector_Clear(new HandleRef(null,jarg1));
}
}


public void TilePositionVector_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionVector_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public uint TilePositionVector_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionVector_size(new HandleRef(null,jarg1));
}
}


public uint TilePositionVector_capacity(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionVector_capacity(new HandleRef(null,jarg1));
}
}


public void TilePositionVector_reserve(IntPtr jarg1, uint jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionVector_reserve(new HandleRef(null,jarg1), jarg2);
}
}


public IntPtr new_TilePositionVector__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TilePositionVector__SWIG_0();
}
}


public IntPtr new_TilePositionVector__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TilePositionVector__SWIG_1(new HandleRef(null,jarg1));
}
}


public IntPtr new_TilePositionVector__SWIG_2(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_TilePositionVector__SWIG_2(jarg1);
}
}


public IntPtr TilePositionVector_getitemcopy(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionVector_getitemcopy(new HandleRef(null,jarg1), jarg2);
}
}


public IntPtr TilePositionVector_getitem(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionVector_getitem(new HandleRef(null,jarg1), jarg2);
}
}


public void TilePositionVector_setitem(IntPtr jarg1, int jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionVector_setitem(new HandleRef(null,jarg1), jarg2, new HandleRef(null,jarg3));
}
}


public void TilePositionVector_AddRange(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionVector_AddRange(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr TilePositionVector_GetRange(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionVector_GetRange(new HandleRef(null,jarg1), jarg2, jarg3);
}
}


public void TilePositionVector_Insert(IntPtr jarg1, int jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionVector_Insert(new HandleRef(null,jarg1), jarg2, new HandleRef(null,jarg3));
}
}


public void TilePositionVector_InsertRange(IntPtr jarg1, int jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionVector_InsertRange(new HandleRef(null,jarg1), jarg2, new HandleRef(null,jarg3));
}
}


public void TilePositionVector_RemoveAt(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionVector_RemoveAt(new HandleRef(null,jarg1), jarg2);
}
}


public void TilePositionVector_RemoveRange(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionVector_RemoveRange(new HandleRef(null,jarg1), jarg2, jarg3);
}
}


public IntPtr TilePositionVector_Repeat(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.TilePositionVector_Repeat(new HandleRef(null,jarg1), jarg2);
}
}


public void TilePositionVector_Reverse__SWIG_0(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionVector_Reverse__SWIG_0(new HandleRef(null,jarg1));
}
}


public void TilePositionVector_Reverse__SWIG_1(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionVector_Reverse__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3);
}
}


public void TilePositionVector_SetRange(IntPtr jarg1, int jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.TilePositionVector_SetRange(new HandleRef(null,jarg1), jarg2, new HandleRef(null,jarg3));
}
}


public void delete_TilePositionVector(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_TilePositionVector(new HandleRef(null,jarg1));
}
}


public IntPtr new_UnitTypePtrIntMap__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitTypePtrIntMap__SWIG_0();
}
}


public IntPtr new_UnitTypePtrIntMap__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitTypePtrIntMap__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint UnitTypePtrIntMap_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypePtrIntMap_size(new HandleRef(null,jarg1));
}
}


public bool UnitTypePtrIntMap_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypePtrIntMap_empty(new HandleRef(null,jarg1));
}
}


public void UnitTypePtrIntMap_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UnitTypePtrIntMap_Clear(new HandleRef(null,jarg1));
}
}


public int UnitTypePtrIntMap_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypePtrIntMap_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void UnitTypePtrIntMap_setitem(IntPtr jarg1, IntPtr jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UnitTypePtrIntMap_setitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2), jarg3);
}
}


public bool UnitTypePtrIntMap_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypePtrIntMap_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void UnitTypePtrIntMap_Add(IntPtr jarg1, IntPtr jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UnitTypePtrIntMap_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2), jarg3);
}
}


public bool UnitTypePtrIntMap_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypePtrIntMap_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr UnitTypePtrIntMap_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypePtrIntMap_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr UnitTypePtrIntMap_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypePtrIntMap_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_UnitTypePtrIntMap(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_UnitTypePtrIntMap(new HandleRef(null,jarg1));
}
}


public void UnitPtrList_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UnitPtrList_Clear(new HandleRef(null,jarg1));
}
}


public void UnitPtrList_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UnitPtrList_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public uint UnitPtrList_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitPtrList_size(new HandleRef(null,jarg1));
}
}


public IntPtr new_UnitPtrList__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitPtrList__SWIG_0();
}
}


public IntPtr new_UnitPtrList__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitPtrList__SWIG_1(new HandleRef(null,jarg1));
}
}


public IntPtr UnitPtrList_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitPtrList_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr UnitPtrList_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitPtrList_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public bool UnitPtrList_Contains(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitPtrList_Contains(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool UnitPtrList_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitPtrList_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void delete_UnitPtrList(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_UnitPtrList(new HandleRef(null,jarg1));
}
}


public void UnitTypeList_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UnitTypeList_Clear(new HandleRef(null,jarg1));
}
}


public void UnitTypeList_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.UnitTypeList_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public uint UnitTypeList_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypeList_size(new HandleRef(null,jarg1));
}
}


public IntPtr new_UnitTypeList__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitTypeList__SWIG_0();
}
}


public IntPtr new_UnitTypeList__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_UnitTypeList__SWIG_1(new HandleRef(null,jarg1));
}
}


public IntPtr UnitTypeList_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypeList_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr UnitTypeList_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.UnitTypeList_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_UnitTypeList(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_UnitTypeList(new HandleRef(null,jarg1));
}
}


public IntPtr new_RegionPtrRegionPtrPair__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_RegionPtrRegionPtrPair__SWIG_0();
}
}


public IntPtr new_RegionPtrRegionPtrPair__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_RegionPtrRegionPtrPair__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr new_RegionPtrRegionPtrPair__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_RegionPtrRegionPtrPair__SWIG_2(new HandleRef(null,jarg1));
}
}


public void RegionPtrRegionPtrPair_first_set(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.RegionPtrRegionPtrPair_first_set(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr RegionPtrRegionPtrPair_first_get(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RegionPtrRegionPtrPair_first_get(new HandleRef(null,jarg1));
}
}


public void RegionPtrRegionPtrPair_second_set(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.RegionPtrRegionPtrPair_second_set(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr RegionPtrRegionPtrPair_second_get(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RegionPtrRegionPtrPair_second_get(new HandleRef(null,jarg1));
}
}


public void delete_RegionPtrRegionPtrPair(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_RegionPtrRegionPtrPair(new HandleRef(null,jarg1));
}
}


public IntPtr new_BaseLocationPtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_BaseLocationPtrSet__SWIG_0();
}
}


public IntPtr new_BaseLocationPtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_BaseLocationPtrSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint BaseLocationPtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocationPtrSet_size(new HandleRef(null,jarg1));
}
}


public bool BaseLocationPtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocationPtrSet_empty(new HandleRef(null,jarg1));
}
}


public void BaseLocationPtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.BaseLocationPtrSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr BaseLocationPtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocationPtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool BaseLocationPtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocationPtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void BaseLocationPtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.BaseLocationPtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool BaseLocationPtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocationPtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr BaseLocationPtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocationPtrSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr BaseLocationPtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.BaseLocationPtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_BaseLocationPtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_BaseLocationPtrSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_ChokepointPtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_ChokepointPtrSet__SWIG_0();
}
}


public IntPtr new_ChokepointPtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_ChokepointPtrSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint ChokepointPtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ChokepointPtrSet_size(new HandleRef(null,jarg1));
}
}


public bool ChokepointPtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ChokepointPtrSet_empty(new HandleRef(null,jarg1));
}
}


public void ChokepointPtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.ChokepointPtrSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr ChokepointPtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ChokepointPtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool ChokepointPtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ChokepointPtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void ChokepointPtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.ChokepointPtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool ChokepointPtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ChokepointPtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr ChokepointPtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ChokepointPtrSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr ChokepointPtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.ChokepointPtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_ChokepointPtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_ChokepointPtrSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_PolygonPtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_PolygonPtrSet__SWIG_0();
}
}


public IntPtr new_PolygonPtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_PolygonPtrSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint PolygonPtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PolygonPtrSet_size(new HandleRef(null,jarg1));
}
}


public bool PolygonPtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PolygonPtrSet_empty(new HandleRef(null,jarg1));
}
}


public void PolygonPtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PolygonPtrSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr PolygonPtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PolygonPtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool PolygonPtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PolygonPtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void PolygonPtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.PolygonPtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool PolygonPtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PolygonPtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr PolygonPtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PolygonPtrSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr PolygonPtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PolygonPtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_PolygonPtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_PolygonPtrSet(new HandleRef(null,jarg1));
}
}


public IntPtr new_RegionPtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_RegionPtrSet__SWIG_0();
}
}


public IntPtr new_RegionPtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.new_RegionPtrSet__SWIG_1(new HandleRef(null,jarg1));
}
}


public uint RegionPtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RegionPtrSet_size(new HandleRef(null,jarg1));
}
}


public bool RegionPtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RegionPtrSet_empty(new HandleRef(null,jarg1));
}
}


public void RegionPtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.RegionPtrSet_Clear(new HandleRef(null,jarg1));
}
}


public IntPtr RegionPtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RegionPtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool RegionPtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RegionPtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public void RegionPtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.RegionPtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public bool RegionPtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RegionPtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
}
}


public IntPtr RegionPtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RegionPtrSet_create_iterator_begin(new HandleRef(null,jarg1));
}
}


public IntPtr RegionPtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.RegionPtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
}
}


public void delete_RegionPtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
  bridgePINVOKE.delete_RegionPtrSet(new HandleRef(null,jarg1));
}
}


public IntPtr PolygonUpcast(IntPtr objectRef) {
 lock(typeof(bridgePINVOKE)) { 
  return bridgePINVOKE.PolygonUpcast(objectRef);
}
}

}
}