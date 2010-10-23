%include <stl.i>
%include "std_set.i"
%include "std_list.i"
%include "typemaps.i"
%include "cpointer.i"

//include headers in our generated code.
%module bwapi
%{
#include "BWAPI.h"
#include "BWAPI\Client.h"

using namespace BWAPI;
%}                    

//enhance the built-in typemaps with extra functionality
%include "class-enhancement.i"

//resolve ambiguities
%include "ambiguities.i"

//fix up operator overrides.
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

//BWAPI order of includes is important to stop SWIGTYPE_p etc class generation with and without namespace
%include "../BWTA/RectangleArray.h"
%include "../BWAPI.h"
%include "../BWAPI/EventType.h"
%include "../BWAPI/GameType.h"
%include "../BWAPI/Race.h"
%include "../BWAPI/TechType.h"
%include "../BWAPI/UpgradeType.h"
%include "../BWAPI/Position.h"
%include "../BWAPI/AIModule.h"
%include "../BWAPI/Color.h"
%include "../BWAPI/Constants.h"
%include "../BWAPI/CoordinateType.h"
%include "../BWAPI/DamageType.h"
%include "../BWAPI/Error.h"
%include "../BWAPI/ExplosionType.h"
%include "../BWAPI/Flag.h"
%include "../BWAPI/Force.h"
%include "../BWAPI/Input.h"
%include "../BWAPI/Event.h"
%include "../BWAPI/Game.h"
%include "../BWAPI/Latency.h"
%include "../BWAPI/Order.h"
%include "../BWAPI/PlayerType.h"
%include "../BWAPI/Player.h"
%include "../BWAPI/BulletType.h"
%include "../BWAPI/Bullet.h"
%include "../BWAPI/TilePosition.h"
%include "../BWAPI/UnitCommandType.h"
%include "../BWAPI/UnitCommand.h"
%include "../BWAPI/Unit.h"
%include "../BWAPI/UnitSizeType.h"
%include "../BWAPI/UnitType.h"
%include "../BWAPI/WeaponType.h"

//BWAPIClient - run swig with -DINCLUDE_CLIENT to include code for BWAPIClient.lib 
#ifdef INCLUDE_CLIENT
%include "../BWAPI/Client/BulletData.h"
%include "../BWAPI/Client/CommandType.h"
%include "../BWAPI/Client/Command.h"
%include "../BWAPI/Client/Event.h"
%include "../BWAPI/Client/ForceData.h"
%include "../BWAPI/Client/ForceImpl.h"
%include "../BWAPI/Client/UnitData.h"
%include "../BWAPI/Client/UnitImpl.h"
%include "../BWAPI/Client/PlayerData.h"
%include "../BWAPI/Client/PlayerImpl.h"
%include "../BWAPI/Client/GameData.h"
%include "../BWAPI/Client/GameImpl.h"
%include "../BWAPI/Client/ShapeType.h"
%include "../BWAPI/Client/Shape.h"
%include "../BWAPI/Client/UnitCommand.h"
%include "../BWAPI/Client/Client.h"
#endif


//Instantiate our templates
%template (PositionVector) std::vector<BWAPI::Position>;
%template (BulletPtrSet) std::set<BWAPI::Bullet *>;
%template (BulletTypeSet) std::set<BWAPI::BulletType>;
%template (DamageTypeSet) std::set<BWAPI::DamageType>;
%template (ErrorSet) std::set<BWAPI::Error>;
%template (ExplosionTypeSet) std::set<BWAPI::ExplosionType>;
%template (ForcePtrSet) std::set<BWAPI::Force *>;
%template (GameTypeSet) std::set<BWAPI::GameType>;
%template (OrderSet) std::set<BWAPI::Order>;
%template (PlayerPtrSet) std::set<BWAPI::Player *>;
%template (PlayerTypeSet) std::set<BWAPI::PlayerType>;
%template (RaceSet) std::set<BWAPI::Race>;
%template (TechTypeSet) std::set<BWAPI::TechType>;
%template (TilePositionSet) std::set<BWAPI::TilePosition>;
%template (UnitPtrSet) std::set<BWAPI::Unit*>;
%template (UnitCommandTypeSet) std::set<BWAPI::UnitCommandType>;
%template (UnitSizeTypeSet) std::set<BWAPI::UnitSizeType>;
%template (UnitTypeSet) std::set<BWAPI::UnitType>;
%template (UpgradeTypeSet) std::set<BWAPI::UpgradeType>;
%template (WeaponTypeSet) std::set<BWAPI::WeaponType>;
%template (EventList) std::list<BWAPI::Event>;
%template (UnitTypeList) std::list<BWAPI::UnitType>;
%template (TilePositionDoubleMap) std::map<BWAPI::TilePosition, double>;
%template (UnitTypeIntMap) std::map<BWAPI::UnitType, int>;
%template (PositionPair) std::pair<BWAPI::Position,BWAPI::Position>;
%template (TilePositionDoublePair) std::pair<BWAPI::TilePosition, double>;
%template (UnitTypeIntPair) std::pair<BWAPI::UnitType,int>;
%template (TilePositionVector) std::vector<BWAPI::TilePosition>;
