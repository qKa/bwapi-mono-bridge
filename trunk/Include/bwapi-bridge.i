%include <stl.i>
%include "std_set.i"
%include "std_list.i"

%module bridge
%{
#include "BWAPI.h"
#include "BWTA.h"
#include "monobridge.h"
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
%rename (AttackTypeAcid_Spore) BWAPI::AttackTypes::Acid_Spore;
%rename (AttackTypeBurst_Lasers) BWAPI::AttackTypes::Burst_Lasers;
%rename (AttackTypeHalo_Rockets) BWAPI::AttackTypes::Halo_Rockets;
%rename (AttackTypeFragmentation_Grenade) BWAPI::AttackTypes::Fragmentation_Grenade;
%rename (AttackTypeGemeni_Missiles) BWAPI::AttackTypes::Gemini_Missiles;
%rename (AttackTypeGlave_Wurm) BWAPI::AttackTypes::Glave_Wurm;
%rename (initAttackTypes) BWAPI::AttackTypes::init;
%rename (AttackTypeLongbolt_Missile) BWAPI::AttackTypes::Longbolt_Missile;
%rename (AttackTypeNone) BWAPI::AttackTypes::None;
%rename (AttackTypePhase_Disruptor) BWAPI::AttackTypes::Phase_Disruptor;
%rename (AttackTypePulse_Cannon) BWAPI::AttackTypes::Pulse_Cannon;
%rename (AttackTypeSeeker_Spores) BWAPI::AttackTypes::Seeker_Spores;
%rename (AttackTypeSubterranean_Spines) BWAPI::AttackTypes::Subterranean_Spines;
%rename (AttackTypeUnknown) BWAPI::AttackTypes::Unknown;
%rename (AttackTypeYamato_Gun) BWAPI::AttackTypes::Yamato_Gun;

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

%rename (OrderConsume) BWAPI::Orders::Consume;
%rename (OrderEnsnare) BWAPI::Orders::Ensnare;
%rename (initOrders) BWAPI::Orders::init;
%rename (OrderIrradiate) BWAPI::Orders::Irradiate;
%rename (OrderNeutral) BWAPI::Orders::Neutral;
%rename (OrderNone) BWAPI::Orders::None;
%rename (OrderPlague) BWAPI::Orders::Plague;
%rename (OrderRestoration) BWAPI::Orders::Restoration;
%rename (OrderUnknown) BWAPI::Orders::Unknown;

%rename (initPlayerTypes) BWAPI::PlayerTypes::init;
%rename (PlayerTypeNeutral) BWAPI::PlayerTypes::Neutral;
%rename (PlayerTypeNone) BWAPI::PlayerTypes::None;
%rename (PlayerTypeUnknown) BWAPI::PlayerTypes::Unknown;

%rename (xConst) BWAPI::Position::x() const;
%rename (yConst) BWAPI::Position::y() const;
%rename (PositionInvalid) BWAPI::Positions::Invalid;
%rename (PositionNone) BWAPI::Positions::None;
%rename (PositionUnknown) BWAPI::Positions::Unknown;

%rename (initRaces) BWAPI::Races::init;
%rename (RaceNone) BWAPI::Races::None;
%rename (RaceUnknown) BWAPI::Races::Unknown;

%rename (TechTypeConsume) BWAPI::TechTypes::Consume;
%rename (TechTypeDark_Swarm) BWAPI::TechTypes::Dark_Swarm;
%rename (TechTypeDisruption_Web) BWAPI::TechTypes::Disruption_Web;
%rename (TechTypeEMP_Shockwave) BWAPI::TechTypes::EMP_Shockwave;
%rename (TechTypeEnsnare) BWAPI::TechTypes::Ensnare;
%rename (TechTypeFeedback) BWAPI::TechTypes::Feedback;
%rename (initTechTypes) BWAPI::TechTypes::init;
%rename (TechTypeIrradiate) BWAPI::TechTypes::Irradiate;
%rename (TechTypeLockdown) BWAPI::TechTypes::Lockdown;
%rename (TechTypeMaelstrom) BWAPI::TechTypes::Maelstrom;
%rename (TechTypeMind_Control) BWAPI::TechTypes::Mind_Control;
%rename (TechTypeNone) BWAPI::TechTypes::None;
%rename (TechTypeNuclear_Strike) BWAPI::TechTypes::Nuclear_Strike;
%rename (TechTypeOptical_Flare) BWAPI::TechTypes::Optical_Flare;
%rename (TechTypeParasite) BWAPI::TechTypes::Parasite;
%rename (TechTypePlague) BWAPI::TechTypes::Plague;
%rename (TechTypePsionic_Storm) BWAPI::TechTypes::Psionic_Storm;
%rename (TechTypeRestoration) BWAPI::TechTypes::Restoration;
%rename (TechTypeSpawn_Broodlings) BWAPI::TechTypes::Spawn_Broodlings;
%rename (TechTypeStasis_Field) BWAPI::TechTypes::Stasis_Field;
%rename (TechTypeUnknown) BWAPI::TechTypes::Unknown;
%rename (TechTypeYamato_Gun) BWAPI::TechTypes::Yamato_Gun;
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


%include "BWAPI.h"
%include "BWAPI/Race.h"
%include "BWAPI/TechType.h"
%include "BWAPI/UpgradeType.h"
%include "BWAPI/Position.h"
%include "BWAPI/AIModule.h"
%include "BWAPI/AttackType.h"
%include "BWAPI/Color.h"
%include "BWAPI/Constants.h"
%include "BWAPI/CoordinateType.h"
%include "BWAPI/DamageType.h"
%include "BWAPI/Error.h"
%include "BWAPI/ExplosionType.h"
%include "BWAPI/Flag.h"
%include "BWAPI/Force.h"
%include "BWAPI/Game.h"
%include "BWAPI/Latency.h"
%include "BWAPI/Order.h"
%include "BWAPI/PlayerType.h"
%include "BWAPI/Player.h"




%include "BWAPI/TilePosition.h"
%include "BWAPI/Unit.h"
%include "BWAPI/UnitSizeType.h"
%include "BWAPI/UnitType.h"

%include "BWAPI/WeaponType.h"
%{
using namespace BWAPI;
%}

%include "monobridge.h"

%include "BWTA.h"
%include "BWTA/BaseLocation.h"
%include "BWTA/Chokepoint.h"

%template (PositionVector) std::vector<BWAPI::Position>;



%include "BWTA/Polygon.h"
%include "BWTA/Region.h"



%template (UnitSet) std::set<BWAPI::Unit*>;
%template (AttackTypeSet) std::set<BWAPI::AttackType>;

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

%template (UnitTypePtrIntMap) std::map<const BWAPI::UnitType *, int>;

%template (UnitPtrList) std::list<BWAPI::Unit *>;
%template (UnitTypeList) std::list<BWAPI::UnitType>;

/* BWTA */

%template (RegionPtrRegionPtrPair) std::pair<BWTA::Region *, BWTA::Region *>;
%template (BaseLocationPtrSet) std::set<BWTA::BaseLocation *>;
%template (ChokepointPtrSet) std::set<BWTA::Chokepoint *>;
%template (PolygonPtrSet) std::set<BWTA::Polygon *>;
%template (RegionPtrSet) std::set<BWTA::Region *>;

