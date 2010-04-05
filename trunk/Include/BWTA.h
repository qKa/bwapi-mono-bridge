#pragma once
#include <BWAPI.h>
#include <BWTA/Chokepoint.h>
#include <BWTA/Polygon.h>
#include <BWTA/Region.h>
#include <BWTA/BaseLocation.h>
#include <BWTA/RectangleArray.h>
namespace BWTA
{
  void readMap();
  void analyze();
  const std::set<BWTA::Region*>& getRegions();
  const std::set<BWTA::Chokepoint*>& getChokepoints();
  const std::set<BWTA::BaseLocation*>& getBaseLocations();
  const std::set<BWTA::BaseLocation*>& getStartLocations();
  const std::set<BWTA::Polygon*>& getUnwalkablePolygons();

  BWTA::BaseLocation* getStartLocation(BWAPI::Player* player);

  BWTA::Region* getRegion(int x, int y);
  BWTA::Region* getRegion(BWAPI::TilePosition tileposition);

  BWTA::Chokepoint* getNearestChokepoint(int x, int y);
  BWTA::Chokepoint* getNearestChokepoint(BWAPI::TilePosition tileposition);

  BWTA::BaseLocation* getNearestBaseLocation(int x, int y);
  BWTA::BaseLocation* getNearestBaseLocation(BWAPI::TilePosition tileposition);

  BWTA::Polygon* getNearestUnwalkablePolygon(int x, int y);
  BWTA::Polygon* getNearestUnwalkablePolygon(BWAPI::TilePosition tileposition);
  BWAPI::Position getNearestUnwalkablePosition(BWAPI::Position position);

  bool isConnected(int x1, int y1, int x2, int y2);
  bool isConnected(BWAPI::TilePosition a, BWAPI::TilePosition b);

  double getGroundDistance(BWAPI::TilePosition start, BWAPI::TilePosition end);
  std::pair<BWAPI::TilePosition, double> getNearestTilePosition(BWAPI::TilePosition start, std::set<BWAPI::TilePosition>& targets);
  std::map<BWAPI::TilePosition, double> getGroundDistances(BWAPI::TilePosition start, std::set<BWAPI::TilePosition>& targets);
  void getGroundDistanceMap(BWAPI::TilePosition start, RectangleArray<double>& distanceMap);

  std::vector<BWAPI::TilePosition> getShortestPath(BWAPI::TilePosition start, BWAPI::TilePosition end);
  std::vector<BWAPI::TilePosition> getShortestPath(BWAPI::TilePosition start, std::set<BWAPI::TilePosition>& targets);

}