#pragma once
#include <BWAPI.h>
#include <BWTA/Chokepoint.h>
#include <BWTA/Polygon.h>
#include <BWTA/Region.h>
#include <BWTA/BaseLocation.h>
namespace BWTA
{
  void readMap();
  void analyze();
  const std::set<BWTA::Region*>& getRegions();
  const std::set<BWTA::Chokepoint*>& getChokepoints();
  const std::set<BWTA::BaseLocation*>& getBaseLocations();
  const std::set<BWTA::BaseLocation*>& getStartLocations();
  const std::set<BWTA::Polygon*>& getUnwalkablePolygons();
  BWAPI::Position getNearestUnwalkablePosition(BWAPI::Position position);
  BWTA::BaseLocation* getStartLocation(BWAPI::Player* player);
  BWTA::BaseLocation* getNearestBaseLocation(BWAPI::TilePosition position);
}