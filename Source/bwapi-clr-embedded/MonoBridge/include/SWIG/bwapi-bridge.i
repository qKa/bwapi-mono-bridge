%include <stl.i>
%include "std_set.i"
%include "std_list.i"
%include "typemaps.i"
%include "cpointer.i"


%module bridge
%{
#include "BWAPI.h"
#include "BWTA.h"
#include "BWAPI\Client.h"

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
//resolve ambiguities
%include "ambiguities.i"



%rename (opAssign) *::operator =;
%rename (opEquals) *::operator ==;
%rename (opLessThan) *::operator <;
%rename (opMinus) *::operator -;
%rename (opNotEquals) *::operator !=;                         
%rename (opPlus) *::operator +;

%rename (opAdd) *::operator +=;
%rename (opSubtract) *::operator -=;

//use getcolumn instead
%ignore BWTA::RectangleArray::operator[];






//fix up const strings.
%apply const std::string & {std::string &};


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




%{
//using namespace BWAPIC;
%}
/* run swig with -DINCLUDE_CLIENT to include code for BWAPIClient.lib */

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

%{
//using namespace BWTA;

%}




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
%template (RegionPtrRegionPtrPair) std::pair<BWTA::Region *, BWTA::Region *>;

%template (TilePositionVector) std::vector<BWAPI::TilePosition>;
%template (PolygonVector) std::vector<BWTA::Polygon>;
%template (PositionVector) std::vector<BWAPI::Position>;



%include "../BWTA/RectangleArray.h"
%template (RectangleArrayDouble) BWTA::RectangleArray<double>; 





%include "../BWTA/BaseLocation.h"
%include "../BWTA/Chokepoint.h"
%template (BaseLocationPtrSet) std::set<BWTA::BaseLocation *>;
%template (RegionPtrSet) std::set<BWTA::Region *>;
%template (ChokepointPtrSet) std::set<BWTA::Chokepoint *>;
%template (PolygonPtrSet) std::set<BWTA::Polygon *>;





%include "../BWTA/Polygon.h"
%include "../BWTA/Region.h"
%include "../BWTA.h"









