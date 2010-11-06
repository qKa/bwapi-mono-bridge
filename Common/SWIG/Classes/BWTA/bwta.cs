/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SWIG.BWTA {

using System;
using System.Runtime.InteropServices;
using BWAPI;

public class bwta {
  public static void readMap() {
    bwtaPINVOKE.readMap();
  }

  public static void analyze() {
    bwtaPINVOKE.analyze();
  }

  public static RegionPtrSet getRegions() {
    RegionPtrSet ret = new RegionPtrSet(bwtaPINVOKE.getRegions(), false);
    return ret;
  }

  public static ChokepointPtrSet getChokepoints() {
    ChokepointPtrSet ret = new ChokepointPtrSet(bwtaPINVOKE.getChokepoints(), false);
    return ret;
  }

  public static BaseLocationPtrSet getBaseLocations() {
    BaseLocationPtrSet ret = new BaseLocationPtrSet(bwtaPINVOKE.getBaseLocations(), false);
    return ret;
  }

  public static BaseLocationPtrSet getStartLocations() {
    BaseLocationPtrSet ret = new BaseLocationPtrSet(bwtaPINVOKE.getStartLocations(), false);
    return ret;
  }

  public static PolygonPtrSet getUnwalkablePolygons() {
    PolygonPtrSet ret = new PolygonPtrSet(bwtaPINVOKE.getUnwalkablePolygons(), false);
    return ret;
  }

  public static BaseLocation getStartLocation(Player player) {
    IntPtr cPtr = bwtaPINVOKE.getStartLocation(Player.getCPtr(player));
    BaseLocation ret = (cPtr == IntPtr.Zero) ? null : new BaseLocation(cPtr, false);
    return ret;
  }

  public static Region getRegion(int x, int y) {
    IntPtr cPtr = bwtaPINVOKE.getRegion__SWIG_0(x, y);
    Region ret = (cPtr == IntPtr.Zero) ? null : new Region(cPtr, false);
    return ret;
  }

  public static Region getRegion(TilePosition tileposition) {
    IntPtr cPtr = bwtaPINVOKE.getRegion__SWIG_1(TilePosition.getCPtr(tileposition));
    Region ret = (cPtr == IntPtr.Zero) ? null : new Region(cPtr, false);
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Chokepoint getNearestChokepoint(int x, int y) {
    IntPtr cPtr = bwtaPINVOKE.getNearestChokepoint__SWIG_0(x, y);
    Chokepoint ret = (cPtr == IntPtr.Zero) ? null : new Chokepoint(cPtr, false);
    return ret;
  }

  public static Chokepoint getNearestChokepoint(TilePosition tileposition) {
    IntPtr cPtr = bwtaPINVOKE.getNearestChokepoint__SWIG_1(TilePosition.getCPtr(tileposition));
    Chokepoint ret = (cPtr == IntPtr.Zero) ? null : new Chokepoint(cPtr, false);
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static BaseLocation getNearestBaseLocation(int x, int y) {
    IntPtr cPtr = bwtaPINVOKE.getNearestBaseLocation__SWIG_0(x, y);
    BaseLocation ret = (cPtr == IntPtr.Zero) ? null : new BaseLocation(cPtr, false);
    return ret;
  }

  public static BaseLocation getNearestBaseLocation(TilePosition tileposition) {
    IntPtr cPtr = bwtaPINVOKE.getNearestBaseLocation__SWIG_1(TilePosition.getCPtr(tileposition));
    BaseLocation ret = (cPtr == IntPtr.Zero) ? null : new BaseLocation(cPtr, false);
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Polygon getNearestUnwalkablePolygon(int x, int y) {
    IntPtr cPtr = bwtaPINVOKE.getNearestUnwalkablePolygon__SWIG_0(x, y);
    Polygon ret = (cPtr == IntPtr.Zero) ? null : new Polygon(cPtr, false);
    return ret;
  }

  public static Polygon getNearestUnwalkablePolygon(TilePosition tileposition) {
    IntPtr cPtr = bwtaPINVOKE.getNearestUnwalkablePolygon__SWIG_1(TilePosition.getCPtr(tileposition));
    Polygon ret = (cPtr == IntPtr.Zero) ? null : new Polygon(cPtr, false);
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Position getNearestUnwalkablePosition(Position position) {
    Position ret = new Position(bwtaPINVOKE.getNearestUnwalkablePosition(Position.getCPtr(position)), true);
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool isConnected(int x1, int y1, int x2, int y2) {
    bool ret = bwtaPINVOKE.isConnected__SWIG_0(x1, y1, x2, y2);
    return ret;
  }

  public static bool isConnected(TilePosition a, TilePosition b) {
    bool ret = bwtaPINVOKE.isConnected__SWIG_1(TilePosition.getCPtr(a), TilePosition.getCPtr(b));
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double getGroundDistance(TilePosition start, TilePosition end) {
    double ret = bwtaPINVOKE.getGroundDistance(TilePosition.getCPtr(start), TilePosition.getCPtr(end));
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static TilePositionDoublePair getNearestTilePosition(TilePosition start, TilePositionSet targets) {
    TilePositionDoublePair ret = new TilePositionDoublePair(bwtaPINVOKE.getNearestTilePosition(TilePosition.getCPtr(start), TilePositionSet.getCPtr(targets)), true);
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static TilePositionDoubleMap getGroundDistances(TilePosition start, TilePositionSet targets) {
    TilePositionDoubleMap ret = new TilePositionDoubleMap(bwtaPINVOKE.getGroundDistances(TilePosition.getCPtr(start), TilePositionSet.getCPtr(targets)), true);
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void getGroundDistanceMap(TilePosition start, RectangleArrayDouble distanceMap) {
    bwtaPINVOKE.getGroundDistanceMap(TilePosition.getCPtr(start), RectangleArrayDouble.getCPtr(distanceMap));
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
  }

  public static TilePositionVector getShortestPath(TilePosition start, TilePosition end) {
    TilePositionVector ret = new TilePositionVector(bwtaPINVOKE.getShortestPath__SWIG_0(TilePosition.getCPtr(start), TilePosition.getCPtr(end)), true);
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static TilePositionVector getShortestPath(TilePosition start, TilePositionSet targets) {
    TilePositionVector ret = new TilePositionVector(bwtaPINVOKE.getShortestPath__SWIG_1(TilePosition.getCPtr(start), TilePositionSet.getCPtr(targets)), true);
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}