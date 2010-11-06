/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class UnitCommand : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnitCommand(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UnitCommand obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnitCommand() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_UnitCommand(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
public override int GetHashCode()
{
   return this.swigCPtr.Handle.GetHashCode();
}

public override bool Equals(object obj)
{
    bool equal = false;
    if (obj is UnitCommand)
      equal = (((UnitCommand)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(UnitCommand obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(UnitCommand obj1, UnitCommand obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(UnitCommand obj1, UnitCommand obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public UnitCommand() : this(bwapiPINVOKE.new_UnitCommand__SWIG_0(), true) {
  }

  public UnitCommand(Unit source, UnitCommandType _type, Unit _target, int _x, int _y, int _extra) : this(bwapiPINVOKE.new_UnitCommand__SWIG_1(Unit.getCPtr(source), UnitCommandType.getCPtr(_type), Unit.getCPtr(_target), _x, _y, _extra), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public static UnitCommand attackMove(Unit unit, Position target) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_attackMove(Unit.getCPtr(unit), Position.getCPtr(target)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UnitCommand attackUnit(Unit unit, Unit target) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_attackUnit(Unit.getCPtr(unit), Unit.getCPtr(target)), true);
    return ret;
  }

  public static UnitCommand build(Unit unit, TilePosition target, UnitType type) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_build(Unit.getCPtr(unit), TilePosition.getCPtr(target), UnitType.getCPtr(type)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UnitCommand buildAddon(Unit unit, UnitType type) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_buildAddon(Unit.getCPtr(unit), UnitType.getCPtr(type)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UnitCommand train(Unit unit, UnitType type) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_train(Unit.getCPtr(unit), UnitType.getCPtr(type)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UnitCommand morph(Unit unit, UnitType type) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_morph(Unit.getCPtr(unit), UnitType.getCPtr(type)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UnitCommand research(Unit unit, TechType tech) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_research(Unit.getCPtr(unit), TechType.getCPtr(tech)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UnitCommand upgrade(Unit unit, UpgradeType upgrade) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_upgrade(Unit.getCPtr(unit), UpgradeType.getCPtr(upgrade)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UnitCommand setRallyPosition(Unit unit, Position target) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_setRallyPosition(Unit.getCPtr(unit), Position.getCPtr(target)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UnitCommand setRallyUnit(Unit unit, Unit target) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_setRallyUnit(Unit.getCPtr(unit), Unit.getCPtr(target)), true);
    return ret;
  }

  public static UnitCommand move(Unit unit, Position target) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_move(Unit.getCPtr(unit), Position.getCPtr(target)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UnitCommand patrol(Unit unit, Position target) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_patrol(Unit.getCPtr(unit), Position.getCPtr(target)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UnitCommand holdPosition(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_holdPosition(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand stop(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_stop(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand follow(Unit unit, Unit target) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_follow(Unit.getCPtr(unit), Unit.getCPtr(target)), true);
    return ret;
  }

  public static UnitCommand gather(Unit unit, Unit target) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_gather(Unit.getCPtr(unit), Unit.getCPtr(target)), true);
    return ret;
  }

  public static UnitCommand returnCargo(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_returnCargo(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand repair(Unit unit, Unit target) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_repair(Unit.getCPtr(unit), Unit.getCPtr(target)), true);
    return ret;
  }

  public static UnitCommand burrow(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_burrow(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand unburrow(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_unburrow(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand cloak(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_cloak(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand decloak(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_decloak(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand siege(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_siege(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand unsiege(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_unsiege(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand lift(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_lift(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand land(Unit unit, TilePosition target) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_land(Unit.getCPtr(unit), TilePosition.getCPtr(target)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UnitCommand load(Unit unit, Unit target) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_load(Unit.getCPtr(unit), Unit.getCPtr(target)), true);
    return ret;
  }

  public static UnitCommand unload(Unit unit, Unit target) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_unload(Unit.getCPtr(unit), Unit.getCPtr(target)), true);
    return ret;
  }

  public static UnitCommand unloadAll(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_unloadAll__SWIG_0(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand unloadAll(Unit unit, Position target) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_unloadAll__SWIG_1(Unit.getCPtr(unit), Position.getCPtr(target)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UnitCommand rightClick(Unit unit, Position target) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_rightClick__SWIG_0(Unit.getCPtr(unit), Position.getCPtr(target)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UnitCommand rightClick(Unit unit, Unit target) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_rightClick__SWIG_1(Unit.getCPtr(unit), Unit.getCPtr(target)), true);
    return ret;
  }

  public static UnitCommand haltConstruction(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_haltConstruction(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand cancelConstruction(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_cancelConstruction(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand cancelAddon(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_cancelAddon(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand cancelTrain(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_cancelTrain__SWIG_0(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand cancelTrain(Unit unit, int slot) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_cancelTrain__SWIG_1(Unit.getCPtr(unit), slot), true);
    return ret;
  }

  public static UnitCommand cancelMorph(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_cancelMorph(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand cancelResearch(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_cancelResearch(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand cancelUpgrade(Unit unit) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_cancelUpgrade(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static UnitCommand useTech(Unit unit, TechType tech) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_useTech__SWIG_0(Unit.getCPtr(unit), TechType.getCPtr(tech)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UnitCommand useTech(Unit unit, TechType tech, Position target) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_useTech__SWIG_1(Unit.getCPtr(unit), TechType.getCPtr(tech), Position.getCPtr(target)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UnitCommand useTech(Unit unit, TechType tech, Unit target) {
    UnitCommand ret = new UnitCommand(bwapiPINVOKE.UnitCommand_useTech__SWIG_2(Unit.getCPtr(unit), TechType.getCPtr(tech), Unit.getCPtr(target)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Unit unit {
    set {
      bwapiPINVOKE.UnitCommand_unit_set(swigCPtr, Unit.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiPINVOKE.UnitCommand_unit_get(swigCPtr);
      Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
      return ret;
    } 
  }

  public UnitCommandType type {
    set {
      bwapiPINVOKE.UnitCommand_type_set(swigCPtr, UnitCommandType.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiPINVOKE.UnitCommand_type_get(swigCPtr);
      UnitCommandType ret = (cPtr == IntPtr.Zero) ? null : new UnitCommandType(cPtr, false);
      return ret;
    } 
  }

  public Unit target {
    set {
      bwapiPINVOKE.UnitCommand_target_set(swigCPtr, Unit.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiPINVOKE.UnitCommand_target_get(swigCPtr);
      Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
      return ret;
    } 
  }

  public int x {
    set {
      bwapiPINVOKE.UnitCommand_x_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiPINVOKE.UnitCommand_x_get(swigCPtr);
      return ret;
    } 
  }

  public int y {
    set {
      bwapiPINVOKE.UnitCommand_y_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiPINVOKE.UnitCommand_y_get(swigCPtr);
      return ret;
    } 
  }

  public int extra {
    set {
      bwapiPINVOKE.UnitCommand_extra_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiPINVOKE.UnitCommand_extra_get(swigCPtr);
      return ret;
    } 
  }

}

}
