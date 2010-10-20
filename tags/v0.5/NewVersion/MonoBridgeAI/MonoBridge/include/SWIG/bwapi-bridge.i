%include <stl.i>
%include "std_set.i"
%include "std_list.i"
%include "typemaps.i"
%include "cpointer.i"


%module bridge
%{
#include "BWAPI.h"
#include "BWAPI/UpgradeType.h"
#include "BWAPI/Color.h"
#include "BWTA.h"
using namespace BWAPI;
%}                    

//partial classes to allow users to add methods to the generated classes.
%typemap(csclassmodifiers) SWIGTYPE "public partial class"



//lets add some functionality to our types
%typemap(cscode) SWIGTYPE %{
  
public override int GetHashCode()
{
   return this.swigCPtr.Handle.GetHashCode();
}

public override bool Equals(object obj)
{
    bool equal = false;
    if (obj is $csclassname)
      equal = ((($csclassname)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals($csclassname obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==($csclassname obj1, $csclassname obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=($csclassname obj1, $csclassname obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}



%}




//Abiguities
%rename (initBulletTypes) BWAPI::BulletTypes::init;
%rename (BulletTypeMelee) BWAPI::BulletTypes::Melee;
%rename (BulletTypeFusion_Cutter_Hit) BWAPI::BulletTypes::Fusion_Cutter_Hit;
%rename (BulletTypeGauss_Rifle_Hit) BWAPI::BulletTypes::Gauss_Rifle_Hit;
%rename (BulletTypeC_10_Canister_Rifle_Hit) BWAPI::BulletTypes::C_10_Canister_Rifle_Hit;
%rename (BulletTypeGemini_Missiles) BWAPI::BulletTypes::Gemini_Missiles;
%rename (BulletTypeFragmentation_Grenade) BWAPI::BulletTypes::Fragmentation_Grenade;
%rename (BulletTypeLongbolt_Missile) BWAPI::BulletTypes::Longbolt_Missile;
%rename (BulletTypeATS_ATA_Laser_Battery) BWAPI::BulletTypes::ATS_ATA_Laser_Battery;
%rename (BulletTypeBurst_Lasers) BWAPI::BulletTypes::Burst_Lasers;
%rename (BulletTypeArclite_Shock_Cannon_Hit) BWAPI::BulletTypes::Arclite_Shock_Cannon_Hit;
%rename (BulletTypeEMP_Missile) BWAPI::BulletTypes::EMP_Missile;
%rename (BulletTypeDual_Photon_Blasters_Hit) BWAPI::BulletTypes::Dual_Photon_Blasters_Hit;
%rename (BulletTypeParticle_Beam_Hit) BWAPI::BulletTypes::Particle_Beam_Hit;
%rename (BulletTypeAnti_Matter_Missile) BWAPI::BulletTypes::Anti_Matter_Missile;
%rename (BulletTypePulse_Cannon) BWAPI::BulletTypes::Pulse_Cannon;
%rename (BulletTypePsionic_Shockwave_Hit) BWAPI::BulletTypes::Psionic_Shockwave_Hit;
%rename (BulletTypePsionic_Storm) BWAPI::BulletTypes::Psionic_Storm;
%rename (BulletTypeYamato_Gun) BWAPI::BulletTypes::Yamato_Gun;
%rename (BulletTypePhase_Disruptor) BWAPI::BulletTypes::Phase_Disruptor;
%rename (BulletTypeSTA_STS_Cannon_Overlay) BWAPI::BulletTypes::STA_STS_Cannon_Overlay;
%rename (BulletTypeSunken_Colony_Tentacle) BWAPI::BulletTypes::Sunken_Colony_Tentacle;
%rename (BulletTypeAcid_Spore) BWAPI::BulletTypes::Acid_Spore;
%rename (BulletTypeGlave_Wurm) BWAPI::BulletTypes::Glave_Wurm;
%rename (BulletTypeSeeker_Spores) BWAPI::BulletTypes::Seeker_Spores;
%rename (BulletTypeQueen_Spell_Carrier) BWAPI::BulletTypes::Queen_Spell_Carrier;
%rename (BulletTypePlague_Cloud) BWAPI::BulletTypes::Plague_Cloud;
%rename (BulletTypeConsume) BWAPI::BulletTypes::Consume;
%rename (BulletTypeNeedle_Spine_Hit) BWAPI::BulletTypes::Needle_Spine_Hit;
%rename (BulletTypeInvisible) BWAPI::BulletTypes::Invisible;
%rename (BulletTypeOptical_Flare_Grenade) BWAPI::BulletTypes::Optical_Flare_Grenade;
%rename (BulletTypeHalo_Rockets) BWAPI::BulletTypes::Halo_Rockets;
%rename (BulletTypeSubterranean_Spines) BWAPI::BulletTypes::Subterranean_Spines;
%rename (BulletTypeCorrosive_Acid_Shot) BWAPI::BulletTypes::Corrosive_Acid_Shot;
%rename (BulletTypeNeutron_Flare) BWAPI::BulletTypes::Neutron_Flare;
%rename (BulletTypeNone) BWAPI::BulletTypes::None;
%rename (BulletTypeUnknown) BWAPI::BulletTypes::Unknown;

%rename (initColors) BWAPI::Colors::init;

%rename (CoordinateType) BWAPI::CoordinateType::Enum;

%rename (DamageTypeIndependent) BWAPI::DamageTypes::Independent;
%rename (initDamageTypes) BWAPI::DamageTypes::init;
%rename (DamageTypeNone) BWAPI::DamageTypes::None;
%rename (DamageTypeNormal) BWAPI::DamageTypes::Normal;
%rename (DamageTypeUnknown) BWAPI::DamageTypes::Unknown;

%rename (toErrorString) BWAPI::Error::toString;
%rename (initErrors) BWAPI::Errors::init;
%rename (ErrorNone) BWAPI::Errors::None;
%rename (ErrorUnknown) BWAPI::Errors::Unknown;

%rename (ExplosionTypeConsume) BWAPI::ExplosionTypes::Consume;
%rename (ExplosionTypeCorrosive_Acid) BWAPI::ExplosionTypes::Corrosive_Acid;
%rename (ExplosionTypeDark_Swarm) BWAPI::ExplosionTypes::Dark_Swarm;
%rename (ExplosionTypeDisruption_Web) BWAPI::ExplosionTypes::Disruption_Web;
%rename (ExplosionTypeEMP_Shockwave) BWAPI::ExplosionTypes::EMP_Shockwave;
%rename (ExplosionTypeEnsnare) BWAPI::ExplosionTypes::Ensnare;
%rename (ExplosionTypeFeedback) BWAPI::ExplosionTypes::Feedback;
%rename (initExplosionTypes) BWAPI::ExplosionTypes::init;
%rename (ExplosionTypeIrradiate) BWAPI::ExplosionTypes::Irradiate;
%rename (ExplosionTypeLockdown) BWAPI::ExplosionTypes::Lockdown;
%rename (ExplosionTypeMaelstrom) BWAPI::ExplosionTypes::Maelstrom;
%rename (ExplosionTypeMind_Control) BWAPI::ExplosionTypes::Mind_Control;
%rename (ExplosionTypeNone) BWAPI::ExplosionTypes::None;
%rename (ExplosionTypeNormal) BWAPI::ExplosionTypes::Normal;
%rename (ExplosionTypeOptical_Flare) BWAPI::ExplosionTypes::Optical_Flare;
%rename (ExplosionTypeParasite) BWAPI::ExplosionTypes::Parasite;
%rename (ExplosionTypePlague) BWAPI::ExplosionTypes::Plague;
%rename (ExplosionTypeRestoration) BWAPI::ExplosionTypes::Restoration;
%rename (ExplosionTypeStasis_Field) BWAPI::ExplosionTypes::Stasis_Field;
%rename (ExplosionTypeUnknown) BWAPI::ExplosionTypes::Unknown;
%rename (ExplosionTypeYamato_Gun) BWAPI::ExplosionTypes::Yamato_Gun;

%rename (Flag) BWAPI::Flag::Enum;

%rename (Latency) BWAPI::Latency::Enum;

%rename (initOrders) BWAPI::Orders::init;
%rename (OrderDie) BWAPI::Order::Die;
%rename (OrderStop) BWAPI::Order::Stop;
%rename (OrderGuard) BWAPI::Order::Guard;
%rename (OrderPlayerGuard) BWAPI::Order::PlayerGuard;
%rename (OrderTurretGuard) BWAPI::Order::TurretGuard;
%rename (OrderBunkerGuard) BWAPI::Order::BunkerGuard;
%rename (OrderMove) BWAPI::Order::Move;
%rename (OrderAttackUnit) BWAPI::Order::AttackUnit;
%rename (OrderAttackTile) BWAPI::Order::AttackTile;
%rename (OrderHover) BWAPI::Order::Hover;
%rename (OrderAttackMove) BWAPI::Order::AttackMove;
%rename (OrderInfestedCommandCenter) BWAPI::Order::InfestedCommandCenter;
%rename (OrderUnusedNothing) BWAPI::Order::UnusedNothing;
%rename (OrderUnusedPowerup) BWAPI::Order::UnusedPowerup;
%rename (OrderTowerGuard) BWAPI::Order::TowerGuard;
%rename (OrderVultureMine) BWAPI::Order::VultureMine;
%rename (OrderNothing) BWAPI::Order::Nothing;
%rename (OrderNothing3) BWAPI::Order::Nothing3;
%rename (OrderCastInfestation) BWAPI::Order::CastInfestation;
%rename (OrderInfestingCommandCenter) BWAPI::Order::InfestingCommandCenter;
%rename (OrderPlaceBuilding) BWAPI::Order::PlaceBuilding;
%rename (OrderBuildProtoss2) BWAPI::Order::BuildProtoss2;
%rename (OrderConstructingBuilding) BWAPI::Order::ConstructingBuilding;
%rename (OrderRepair) BWAPI::Order::Repair;
%rename (OrderPlaceAddon) BWAPI::Order::PlaceAddon;
%rename (OrderBuildAddon) BWAPI::Order::BuildAddon;
%rename (OrderTrain) BWAPI::Order::Train;
%rename (OrderRallyPointUnit) BWAPI::Order::RallyPointUnit;
%rename (OrderRallyPointTile) BWAPI::Order::RallyPointTile;
%rename (OrderZergBirth) BWAPI::Order::ZergBirth;
%rename (OrderZergUnitMorph) BWAPI::Order::ZergUnitMorph;
%rename (OrderZergBuildingMorph) BWAPI::Order::ZergBuildingMorph;
%rename (OrderIncompleteBuilding) BWAPI::Order::IncompleteBuilding;
%rename (OrderBuildNydusExit) BWAPI::Order::BuildNydusExit;
%rename (OrderEnterNydusCanal) BWAPI::Order::EnterNydusCanal;
%rename (OrderFollow) BWAPI::Order::Follow;
%rename (OrderCarrier) BWAPI::Order::Carrier;
%rename (OrderReaverCarrierMove) BWAPI::Order::ReaverCarrierMove;
%rename (OrderCarrierIgnore2) BWAPI::Order::CarrierIgnore2;
%rename (OrderReaver) BWAPI::Order::Reaver;
%rename (OrderTrainFighter) BWAPI::Order::TrainFighter;
%rename (OrderInterceptorAttack) BWAPI::Order::InterceptorAttack;
%rename (OrderScarabAttack) BWAPI::Order::ScarabAttack;
%rename (OrderRechargeShieldsUnit) BWAPI::Order::RechargeShieldsUnit;
%rename (OrderRechargeShieldsBattery) BWAPI::Order::RechargeShieldsBattery;
%rename (OrderShieldBattery) BWAPI::Order::ShieldBattery;
%rename (OrderInterceptorReturn) BWAPI::Order::InterceptorReturn;
%rename (OrderBuildingLand) BWAPI::Order::BuildingLand;
%rename (OrderBuildingLiftOff) BWAPI::Order::BuildingLiftOff;
%rename (OrderDroneLiftOff) BWAPI::Order::DroneLiftOff;
%rename (OrderLiftingOff) BWAPI::Order::LiftingOff;
%rename (OrderResearchTech) BWAPI::Order::ResearchTech;
%rename (OrderUpgrade) BWAPI::Order::Upgrade;
%rename (OrderLarva) BWAPI::Order::Larva;
%rename (OrderSpawningLarva) BWAPI::Order::SpawningLarva;
%rename (OrderHarvest1) BWAPI::Order::Harvest1;
%rename (OrderHarvest2) BWAPI::Order::Harvest2;
%rename (OrderMoveToGas) BWAPI::Order::MoveToGas;
%rename (OrderWaitForGas) BWAPI::Order::WaitForGas;
%rename (OrderHarvestGas) BWAPI::Order::HarvestGas;
%rename (OrderReturnGas) BWAPI::Order::ReturnGas;
%rename (OrderMoveToMinerals) BWAPI::Order::MoveToMinerals;
%rename (OrderWaitForMinerals) BWAPI::Order::WaitForMinerals;
%rename (OrderMiningMinerals) BWAPI::Order::MiningMinerals;
%rename (OrderHarvest3) BWAPI::Order::Harvest3;
%rename (OrderHarvest4) BWAPI::Order::Harvest4;
%rename (OrderReturnMinerals) BWAPI::Order::ReturnMinerals;
%rename (OrderInterrupted) BWAPI::Order::Interrupted;
%rename (OrderEnterTransport) BWAPI::Order::EnterTransport;
%rename (OrderPickupIdle) BWAPI::Order::PickupIdle;
%rename (OrderPickupTransport) BWAPI::Order::PickupTransport;
%rename (OrderPickupBunker) BWAPI::Order::PickupBunker;
%rename (OrderPickup4) BWAPI::Order::Pickup4;
%rename (OrderPowerupIdle) BWAPI::Order::PowerupIdle;
%rename (OrderSieging) BWAPI::Order::Sieging;
%rename (OrderUnsieging) BWAPI::Order::Unsieging;
%rename (OrderInitCreepGrowth) BWAPI::Order::InitCreepGrowth;
%rename (OrderSpreadCreep) BWAPI::Order::SpreadCreep;
%rename (OrderStoppingCreepGrowth) BWAPI::Order::StoppingCreepGrowth;
%rename (OrderGuardianAspect) BWAPI::Order::GuardianAspect;
%rename (OrderArchonWarp) BWAPI::Order::ArchonWarp;
%rename (OrderCompletingArchonsummon) BWAPI::Order::CompletingArchonsummon;
%rename (OrderHoldPosition) BWAPI::Order::HoldPosition;
%rename (OrderCloak) BWAPI::Order::Cloak;
%rename (OrderDecloak) BWAPI::Order::Decloak;
%rename (OrderUnload) BWAPI::Order::Unload;
%rename (OrderMoveUnload) BWAPI::Order::MoveUnload;
%rename (OrderFireYamatoGun) BWAPI::Order::FireYamatoGun;
%rename (OrderCastLockdown) BWAPI::Order::CastLockdown;
%rename (OrderBurrowing) BWAPI::Order::Burrowing;
%rename (OrderBurrowed) BWAPI::Order::Burrowed;
%rename (OrderUnburrowing) BWAPI::Order::Unburrowing;
%rename (OrderCastDarkSwarm) BWAPI::Order::CastDarkSwarm;
%rename (OrderCastParasite) BWAPI::Order::CastParasite;
%rename (OrderCastSpawnBroodlings) BWAPI::Order::CastSpawnBroodlings;
%rename (OrderCastEMPShockwave) BWAPI::Order::CastEMPShockwave;
%rename (OrderNukeWait) BWAPI::Order::NukeWait;
%rename (OrderNukeTrain) BWAPI::Order::NukeTrain;
%rename (OrderNukeLaunch) BWAPI::Order::NukeLaunch;
%rename (OrderNukeUnit) BWAPI::Order::NukeUnit;
%rename (OrderCastNuclearStrike) BWAPI::Order::CastNuclearStrike;
%rename (OrderNukeTrack) BWAPI::Order::NukeTrack;
%rename (OrderCloakNearbyUnits) BWAPI::Order::CloakNearbyUnits;
%rename (OrderPlaceMine) BWAPI::Order::PlaceMine;
%rename (OrderRightClickAction) BWAPI::Order::RightClickAction;
%rename (OrderCastRecall) BWAPI::Order::CastRecall;
%rename (OrderTeleporttoLocation) BWAPI::Order::TeleporttoLocation;
%rename (OrderCastScannerSweep) BWAPI::Order::CastScannerSweep;
%rename (OrderScanner) BWAPI::Order::Scanner;
%rename (OrderCastDefensiveMatrix) BWAPI::Order::CastDefensiveMatrix;
%rename (OrderCastPsionicStorm) BWAPI::Order::CastPsionicStorm;
%rename (OrderCastIrradiate) BWAPI::Order::CastIrradiate;
%rename (OrderCastPlague) BWAPI::Order::CastPlague;
%rename (OrderCastConsume) BWAPI::Order::CastConsume;
%rename (OrderCastEnsnare) BWAPI::Order::CastEnsnare;
%rename (OrderCastStasisField) BWAPI::Order::CastStasisField;
%rename (OrderCastHallucination) BWAPI::Order::CastHallucination;
%rename (OrderHallucination2) BWAPI::Order::Hallucination2;
%rename (OrderResetCollision) BWAPI::Order::ResetCollision;
%rename (OrderPatrol) BWAPI::Order::Patrol;
%rename (OrderCTFCOPInit) BWAPI::Order::CTFCOPInit;
%rename (OrderCTFCOP1) BWAPI::Order::CTFCOP1;
%rename (OrderCTFCOP2) BWAPI::Order::CTFCOP2;
%rename (OrderComputerAI) BWAPI::Order::ComputerAI;
%rename (OrderAtkMoveEP) BWAPI::Order::AtkMoveEP;
%rename (OrderHarassMove) BWAPI::Order::HarassMove;
%rename (OrderAIPatrol) BWAPI::Order::AIPatrol;
%rename (OrderGuardPost) BWAPI::Order::GuardPost;
%rename (OrderRescuePassive) BWAPI::Order::RescuePassive;
%rename (OrderNeutral) BWAPI::Order::Neutral;
%rename (OrderComputerReturn) BWAPI::Order::ComputerReturn;
%rename (OrderSelfDestrucing) BWAPI::Order::SelfDestrucing;
%rename (OrderCritter) BWAPI::Order::Critter;
%rename (OrderHiddenGun) BWAPI::Order::HiddenGun;
%rename (OrderOpenDoor) BWAPI::Order::OpenDoor;
%rename (OrderCloseDoor) BWAPI::Order::CloseDoor;
%rename (OrderHideTrap) BWAPI::Order::HideTrap;
%rename (OrderRevealTrap) BWAPI::Order::RevealTrap;
%rename (OrderEnabledoodad) BWAPI::Order::Enabledoodad;
%rename (OrderDisabledoodad) BWAPI::Order::Disabledoodad;
%rename (OrderWarpin) BWAPI::Order::Warpin;
%rename (OrderMedic) BWAPI::Order::Medic;
%rename (OrderMedicHeal1) BWAPI::Order::MedicHeal1;
%rename (OrderHealMove) BWAPI::Order::HealMove;
%rename (OrderMedicHeal2) BWAPI::Order::MedicHeal2;
%rename (OrderCastRestoration) BWAPI::Order::CastRestoration;
%rename (OrderCastDisruptionWeb) BWAPI::Order::CastDisruptionWeb;
%rename (OrderCastMindControl) BWAPI::Order::CastMindControl;
%rename (OrderDarkArchonMeld) BWAPI::Order::DarkArchonMeld;
%rename (OrderCastFeedback) BWAPI::Order::CastFeedback;
%rename (OrderCastOpticalFlare) BWAPI::Order::CastOpticalFlare;
%rename (OrderCastMaelstrom) BWAPI::Order::CastMaelstrom;
%rename (OrderJunkYardDog) BWAPI::Order::JunkYardDog;
%rename (OrderFatal) BWAPI::Order::Fatal;
%rename (OrderNone) BWAPI::Order::None;
%rename (OrderUnknown) BWAPI::Order::Unknown;

%rename (initPlayerTypes) BWAPI::PlayerTypes::init;
%rename (PlayerTypeNone) BWAPI::PlayerTypes::None;
%rename (PlayerTypeComputer) BWAPI::PlayerTypes::Computer;
%rename (PlayerTypePlayer) BWAPI::PlayerTypes::Player;
%rename (PlayerTypeRescuePassive) BWAPI::PlayerTypes::RescuePassive;
%rename (PlayerTypeEitherPreferComputer) BWAPI::PlayerTypes::EitherPreferComputer;
%rename (PlayerTypeEitherPreferHuman) BWAPI::PlayerTypes::EitherPreferHuman;
%rename (PlayerTypeNeutral) BWAPI::PlayerTypes::Neutral;
%rename (PlayerTypeClosed) BWAPI::PlayerTypes::Closed;
%rename (PlayerTypePlayerLeft) BWAPI::PlayerTypes::PlayerLeft;
%rename (PlayerTypeComputerLeft) BWAPI::PlayerTypes::ComputerLeft;
%rename (PlayerTypeUnknown) BWAPI::PlayerTypes::Unknown;

%rename (xConst) BWAPI::Position::x() const;
%rename (yConst) BWAPI::Position::y() const;
%rename (PositionInvalid) BWAPI::Positions::Invalid;
%rename (PositionNone) BWAPI::Positions::None;
%rename (PositionUnknown) BWAPI::Positions::Unknown;

%rename (initRaces) BWAPI::Races::init;
%rename (RaceNone) BWAPI::Races::None;
%rename (RaceUnknown) BWAPI::Races::Unknown;

%rename (TechTypeStim_Packs) BWAPI::TechTypes::Stim_Packs;
%rename (TechTypeLockdown) BWAPI::TechTypes::Lockdown;
%rename (TechTypeEMP_Shockwave) BWAPI::TechTypes::EMP_Shockwave;
%rename (TechTypeSpider_Mines) BWAPI::TechTypes::Spider_Mines;
%rename (TechTypeScanner_Sweep) BWAPI::TechTypes::Scanner_Sweep;
%rename (TechTypeTank_Siege_Mode) BWAPI::TechTypes::Tank_Siege_Mode;
%rename (TechTypeDefensive_Matrix) BWAPI::TechTypes::Defensive_Matrix;
%rename (TechTypeIrradiate) BWAPI::TechTypes::Irradiate;
%rename (TechTypeYamato_Gun) BWAPI::TechTypes::Yamato_Gun;
%rename (TechTypeCloaking_Field) BWAPI::TechTypes::Cloaking_Field;
%rename (TechTypePersonnel_Cloaking) BWAPI::TechTypes::Personnel_Cloaking;
%rename (TechTypeBurrowing) BWAPI::TechTypes::Burrowing;
%rename (TechTypeInfestation) BWAPI::TechTypes::Infestation;
%rename (TechTypeSpawn_Broodlings) BWAPI::TechTypes::Spawn_Broodlings;
%rename (TechTypeDark_Swarm) BWAPI::TechTypes::Dark_Swarm;
%rename (TechTypePlague) BWAPI::TechTypes::Plague;
%rename (TechTypeConsume) BWAPI::TechTypes::Consume;
%rename (TechTypeEnsnare) BWAPI::TechTypes::Ensnare;
%rename (TechTypeParasite) BWAPI::TechTypes::Parasite;
%rename (TechTypePsionic_Storm) BWAPI::TechTypes::Psionic_Storm;
%rename (TechTypeHallucination) BWAPI::TechTypes::Hallucination;
%rename (TechTypeRecall) BWAPI::TechTypes::Recall;
%rename (TechTypeStasis_Field) BWAPI::TechTypes::Stasis_Field;
%rename (TechTypeArchon_Warp) BWAPI::TechTypes::Archon_Warp;
%rename (TechTypeRestoration) BWAPI::TechTypes::Restoration;
%rename (TechTypeDisruption_Web) BWAPI::TechTypes::Disruption_Web;
%rename (TechTypeMind_Control) BWAPI::TechTypes::Mind_Control;
%rename (TechTypeDark_Archon_Meld) BWAPI::TechTypes::Dark_Archon_Meld;
%rename (TechTypeFeedback) BWAPI::TechTypes::Feedback;
%rename (TechTypeOptical_Flare) BWAPI::TechTypes::Optical_Flare;
%rename (TechTypeMaelstrom) BWAPI::TechTypes::Maelstrom;
%rename (TechTypeLurker_Aspect) BWAPI::TechTypes::Lurker_Aspect;
%rename (TechTypeHealing) BWAPI::TechTypes::Healing;
%rename (TechTypeNone) BWAPI::TechTypes::None;
%rename (TechTypeUnknown) BWAPI::TechTypes::Unknown;
%rename (TechTypeNuclear_Strike) BWAPI::TechTypes::Nuclear_Strike;
//arg!
%ignore BWAPI::TechType::getRace;

%rename (xConst) BWAPI::TilePosition::x() const;
%rename (yConst) BWAPI::TilePosition::y() const;
%rename (TilePositionInvalid) BWAPI::TilePositions::Invalid;
%rename (TilePositionNone) BWAPI::TilePositions::None;
%rename (TilePositionUnknown) BWAPI::TilePositions::Unknown;

%rename (UnitSizeTypeIndependent) BWAPI::UnitSizeTypes::Independent;
%rename (initUnitSizeTypes) BWAPI::UnitSizeTypes::init;
%rename (UnitSizeTypeNone) BWAPI::UnitSizeTypes::None;
%rename (UnitSizeTypeUnknown) BWAPI::UnitSizeTypes::Unknown;

%rename (initUnitTypes) BWAPI::UnitTypes::init;
%rename (UnitTypeNone) BWAPI::UnitTypes::None;
%rename (UnitTypeUnknown) BWAPI::UnitTypes::Unknown;

%rename (initUpgradeTypes) BWAPI::UpgradeTypes::init;
%rename (UpgradeTypeNone) BWAPI::UpgradeTypes::None;
%rename (UpgradeTypeUnknown) BWAPI::UpgradeTypes::Unknown;

%rename (WeaponTypeAcid_Spore) BWAPI::WeaponTypes::Acid_Spore;
%rename (WeaponTypeBurst_Lasers) BWAPI::WeaponTypes::Burst_Lasers;
%rename (WeaponTypeConsume) BWAPI::WeaponTypes::Consume;
%rename (WeaponTypeCorrosive_Acid) BWAPI::WeaponTypes::Corrosive_Acid;
%rename (WeaponTypeEnsnare) BWAPI::WeaponTypes::Ensnare;
%rename (WeaponTypeFragmentation_Grenade) BWAPI::WeaponTypes::Fragmentation_Grenade;
%rename (WeaponTypeGemini_Missiles) BWAPI::WeaponTypes::Gemini_Missiles;
%rename (WeaponTypeGlave_Wurm) BWAPI::WeaponTypes::Glave_Wurm;
%rename (WeaponTypeHalo_Rockets) BWAPI::WeaponTypes::Halo_Rockets;
%rename (initWeaponTypes) BWAPI::WeaponTypes::init;
%rename (WeaponTypeIrradiate) BWAPI::WeaponTypes::Irradiate;
%rename (WeaponTypeLongbolt_Missile) BWAPI::WeaponTypes::Longbolt_Missile;
%rename (WeaponTypeMind_Control) BWAPI::WeaponTypes::Mind_Control;
%rename (WeaponTypeNone) BWAPI::WeaponTypes::None;
%rename (WeaponTypeNuclear_Strike) BWAPI::WeaponTypes::Nuclear_Strike;
%rename (WeaponTypeNeutron_Flare) BWAPI::WeaponTypes::Neutron_Flare;
%rename (WeaponTypePhase_Disruptor) BWAPI::WeaponTypes::Phase_Disruptor;
%rename (WeaponTypePulse_Cannon) BWAPI::WeaponTypes::Pulse_Cannon;
%rename (WeaponTypePlague) BWAPI::WeaponTypes::Plague;
%rename (WeaponTypePsionic_Storm) BWAPI::WeaponTypes::Psionic_Storm;
%rename (WeaponTypeRestoration) BWAPI::WeaponTypes::Restoration;
%rename (WeaponTypeSeeker_Spores) BWAPI::WeaponTypes::Seeker_Spores;
%rename (WeaponTypeSpawn_Broodlings) BWAPI::WeaponTypes::SpawnBroodlings;
%rename (WeaponTypeSpider_Mines) BWAPI::WeaponTypes::Spider_Mines;
%rename (WeaponTypeSubterranean_Spines) BWAPI::WeaponTypes::Subterranean_Spines;
%rename (WeaponTypeUnknown) BWAPI::WeaponTypes::Unknown;
%rename (WeaponTypeYamato_Gun) BWAPI::WeaponTypes::Yamato_Gun;

%rename (initGameTypes) BWAPI::GameTypes::init;
%rename (GameTypeMelee) BWAPI::GameTypes::Melee;
%rename (GameTypeFree_For_All) BWAPI::GameTypes::Free_For_All;
%rename (GameTypeOne_on_One) BWAPI::GameTypes::One_on_One;
%rename (GameTypeCapture_The_Flag) BWAPI::GameTypes::Capture_The_Flag;
%rename (GameTypeGreed) BWAPI::GameTypes::Greed;
%rename (GameTypeSlaughter) BWAPI::GameTypes::Slaughter;
%rename (GameTypeSudden_Death) BWAPI::GameTypes::Sudden_Death;
%rename (GameTypeLadder) BWAPI::GameTypes::Ladder;
%rename (GameTypeUse_Map_Settings) BWAPI::GameTypes::Use_Map_Settings;
%rename (GameTypeTeam_Melee) BWAPI::GameTypes::Team_Melee;
%rename (GameTypeTeam_Free_For_All) BWAPI::GameTypes::Team_Free_For_All;
%rename (GameTypeTeam_Capture_The_Flag) BWAPI::GameTypes::Team_Capture_The_Flag;
%rename (GameTypeTop_vs_Bottom) BWAPI::GameTypes::Top_vs_Bottom;
%rename (GameTypePro_Gamer_League) BWAPI::GameTypes::Pro_Gamer_League;
%rename (GameTypeNone) BWAPI::GameTypes::None;
%rename (GameTypeUnknown) BWAPI::GameTypes::Unknown;

%rename (initUnitCommandTypes) BWAPI::UnitCommandTypes::init;
%rename (UnitCommandTypeAttack_Move) BWAPI::UnitCommandTypes::Attack_Move;
%rename (UnitCommandTypeAttack_Unit) BWAPI::UnitCommandTypes::Attack_Unit;
%rename (UnitCommandTypeBuild) BWAPI::UnitCommandTypes::Build;
%rename (UnitCommandTypeBuild_Addon) BWAPI::UnitCommandTypes::Build_Addon;
%rename (UnitCommandTypeTrain) BWAPI::UnitCommandTypes::Train;
%rename (UnitCommandTypeMorph) BWAPI::UnitCommandTypes::Morph;
%rename (UnitCommandTypeResearch) BWAPI::UnitCommandTypes::Research;
%rename (UnitCommandTypeUpgrade) BWAPI::UnitCommandTypes::Upgrade;
%rename (UnitCommandTypeSet_Rally_Position) BWAPI::UnitCommandTypes::Set_Rally_Position;
%rename (UnitCommandTypeSet_Rally_Unit) BWAPI::UnitCommandTypes::Set_Rally_Unit;
%rename (UnitCommandTypeMove) BWAPI::UnitCommandTypes::Move;
%rename (UnitCommandTypePatrol) BWAPI::UnitCommandTypes::Patrol;
%rename (UnitCommandTypeHold_Position) BWAPI::UnitCommandTypes::Hold_Position;
%rename (UnitCommandTypeStop) BWAPI::UnitCommandTypes::Stop;
%rename (UnitCommandTypeFollow) BWAPI::UnitCommandTypes::Follow;
%rename (UnitCommandTypeGather) BWAPI::UnitCommandTypes::Gather;
%rename (UnitCommandTypeReturn_Cargo) BWAPI::UnitCommandTypes::Return_Cargo;
%rename (UnitCommandTypeRepair) BWAPI::UnitCommandTypes::Repair;
%rename (UnitCommandTypeBurrow) BWAPI::UnitCommandTypes::Burrow;
%rename (UnitCommandTypeUnburrow) BWAPI::UnitCommandTypes::Unburrow;
%rename (UnitCommandTypeCloak) BWAPI::UnitCommandTypes::Cloak;
%rename (UnitCommandTypeDecloak) BWAPI::UnitCommandTypes::Decloak;
%rename (UnitCommandTypeSiege) BWAPI::UnitCommandTypes::Siege;
%rename (UnitCommandTypeUnsiege) BWAPI::UnitCommandTypes::Unsiege;
%rename (UnitCommandTypeLift) BWAPI::UnitCommandTypes::Lift;
%rename (UnitCommandTypeLand) BWAPI::UnitCommandTypes::Land;
%rename (UnitCommandTypeLoad) BWAPI::UnitCommandTypes::Load;
%rename (UnitCommandTypeUnload) BWAPI::UnitCommandTypes::Unload;
%rename (UnitCommandTypeUnload_All) BWAPI::UnitCommandTypes::Unload_All;
%rename (UnitCommandTypeUnload_All_Position) BWAPI::UnitCommandTypes::Unload_All_Position;
%rename (UnitCommandTypeRight_Click_Position) BWAPI::UnitCommandTypes::Right_Click_Position;
%rename (UnitCommandTypeRight_Click_Unit) BWAPI::UnitCommandTypes::Right_Click_Unit;
%rename (UnitCommandTypeHalt_Construction) BWAPI::UnitCommandTypes::Halt_Construction;
%rename (UnitCommandTypeCancel_Construction) BWAPI::UnitCommandTypes::Cancel_Construction;
%rename (UnitCommandTypeCancel_Addon) BWAPI::UnitCommandTypes::Cancel_Addon;
%rename (UnitCommandTypeCancel_Train) BWAPI::UnitCommandTypes::Cancel_Train;
%rename (UnitCommandTypeCancel_Train_Slot) BWAPI::UnitCommandTypes::Cancel_Train_Slot;
%rename (UnitCommandTypeCancel_Morph) BWAPI::UnitCommandTypes::Cancel_Morph;
%rename (UnitCommandTypeCancel_Research) BWAPI::UnitCommandTypes::Cancel_Research;
%rename (UnitCommandTypeCancel_Upgrade) BWAPI::UnitCommandTypes::Cancel_Upgrade;
%rename (UnitCommandTypeUse_Tech) BWAPI::UnitCommandTypes::Use_Tech;
%rename (UnitCommandTypeUse_Tech_Position) BWAPI::UnitCommandTypes::Use_Tech_Position;
%rename (UnitCommandTypeUse_Tech_Unit) BWAPI::UnitCommandTypes::Use_Tech_Unit;
%rename (UnitCommandTypeNone) BWAPI::UnitCommandTypes::None;
%rename (UnitCommandTypeUnknown) BWAPI::UnitCommandTypes::Unknown;


%rename (opAssign) *::operator =;
%rename (opEquals) *::operator ==;
%rename (opLessThan) *::operator <;
%rename (opMinus) *::operator -;
%rename (opNotEquals) *::operator !=;                         
%rename (opPlus) *::operator +;

%rename (opAdd) *::operator +=;
%rename (opSubtract) *::operator -=;

//fix up const strings.
%apply const std::string & {std::string &};


%include "../BWAPI.h"
%include "../BWAPI/AIModule.h"
%include "../BWAPI/Bullet.h"
%include "../BWAPI/BulletType.h"
%include "../BWAPI/Constants.h"
%include "../BWAPI/CoordinateType.h"
%include "../BWAPI/DamageType.h"
%include "../BWAPI/Error.h"
%include "../BWAPI/Event.h"
%include "../BWAPI/EventType.h"
%include "../BWAPI/ExplosionType.h"
%include "../BWAPI/Flag.h"
%include "../BWAPI/Force.h"
%include "../BWAPI/Game.h"
%include "../BWAPI/GameType.h"
%include "../BWAPI/Input.h"
%include "../BWAPI/Latency.h"
%include "../BWAPI/Order.h"
%include "../BWAPI/Player.h"
%include "../BWAPI/PlayerType.h"
%include "../BWAPI/Position.h"
%include "../BWAPI/Race.h"
%include "../BWAPI/TechType.h"
%include "../BWAPI/TilePosition.h"
%include "../BWAPI/Unit.h"
%include "../BWAPI/UnitCommand.h"
%include "../BWAPI/UnitCommandType.h"
%include "../BWAPI/UnitSizeType.h"
%include "../BWAPI/UnitType.h"
%include "../BWAPI/UpgradeType.h"
%include "../BWAPI/WeaponType.h"

%{
using namespace BWTA;

%}

%include "../BWTA/RectangleArray.h"



%template (RectangleArrayDouble) BWTA::RectangleArray<double>;

%include "../BWTA.h"
%include "../BWTA/BaseLocation.h"
%include "../BWTA/Chokepoint.h"

%template (PositionVector) std::vector<BWAPI::Position>;

%include "../BWTA/Polygon.h"
%include "../BWTA/Region.h"

%template (UnitSet) std::set<BWAPI::Unit*>;


%template (DamageTypeSet) std::set<BWAPI::DamageType>;

%template (ErrorSet) std::set<BWAPI::Error>;

%template (ExplosionTypeSet) std::set<BWAPI::ExplosionType>;

%template (ForcePtrSet) std::set<BWAPI::Force *>;
%template (OrderSet) std::set<BWAPI::Order>;
%template (PlayerPtrSet) std::set<BWAPI::Player *>;
%template (PlayerTypeSet) std::set<BWAPI::PlayerType>;
%template (RaceSet) std::set<BWAPI::Race>;

%template (TechTypePtrSet) std::set<const BWAPI::TechType *>;
%template (TechTypeSet) std::set<BWAPI::TechType>;
%template (UnitSizeTypeSet) std::set<BWAPI::UnitSizeType>;
%template (UnitTypePtrSet) std::set<const BWAPI::UnitType *>;
%template (UnitTypeSet) std::set<BWAPI::UnitType>;
%template (UpgradeTypePtrSet) std::set<const BWAPI::UpgradeType *>;
%template (UpgradeTypeSet) std::set<BWAPI::UpgradeType>;
%template (WeaponTypeSet) std::set<BWAPI::WeaponType>;

%template (PositionPair) std::pair<BWAPI::Position,BWAPI::Position>;
%template (UnitTypePtrIntPair) std::pair<const BWAPI::UnitType *,int>;

%template (TilePositionSet) std::set<BWAPI::TilePosition>;
%template (TilePositionDoubleMap) std::map<BWAPI::TilePosition, double>;
%template (TilePositionDoublePair) std::pair<BWAPI::TilePosition, double>;
%template (TilePositionVector) std::vector<BWAPI::TilePosition>;

%template (UnitTypePtrIntMap) std::map<const BWAPI::UnitType *, int>;

%template (UnitPtrList) std::list<BWAPI::Unit *>;
%template (UnitTypeList) std::list<BWAPI::UnitType>;


/* BWTA */

%template (RegionPtrRegionPtrPair) std::pair<BWTA::Region *, BWTA::Region *>;
%template (BaseLocationPtrSet) std::set<BWTA::BaseLocation *>;
%template (ChokepointPtrSet) std::set<BWTA::Chokepoint *>;
%template (PolygonPtrSet) std::set<BWTA::Polygon *>;
%template (RegionPtrSet) std::set<BWTA::Region *>;



