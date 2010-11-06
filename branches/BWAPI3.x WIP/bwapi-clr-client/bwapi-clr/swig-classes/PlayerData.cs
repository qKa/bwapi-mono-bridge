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

public partial class PlayerData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PlayerData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PlayerData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PlayerData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_PlayerData(swigCPtr);
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
    if (obj is PlayerData)
      equal = (((PlayerData)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(PlayerData obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(PlayerData obj1, PlayerData obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(PlayerData obj1, PlayerData obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public string name {
    set {
      bridgePINVOKE.PlayerData_name_set(swigCPtr, value);
    } 
    get {
      string ret = bridgePINVOKE.PlayerData_name_get(swigCPtr);
      return ret;
    } 
  }

  public int race {
    set {
      bridgePINVOKE.PlayerData_race_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.PlayerData_race_get(swigCPtr);
      return ret;
    } 
  }

  public int type {
    set {
      bridgePINVOKE.PlayerData_type_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.PlayerData_type_get(swigCPtr);
      return ret;
    } 
  }

  public int force {
    set {
      bridgePINVOKE.PlayerData_force_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.PlayerData_force_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_bool isAlly {
    set {
      bridgePINVOKE.PlayerData_isAlly_set(swigCPtr, SWIGTYPE_p_bool.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.PlayerData_isAlly_get(swigCPtr);
      SWIGTYPE_p_bool ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_bool(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_bool isEnemy {
    set {
      bridgePINVOKE.PlayerData_isEnemy_set(swigCPtr, SWIGTYPE_p_bool.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.PlayerData_isEnemy_get(swigCPtr);
      SWIGTYPE_p_bool ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_bool(cPtr, false);
      return ret;
    } 
  }

  public bool isNeutral {
    set {
      bridgePINVOKE.PlayerData_isNeutral_set(swigCPtr, value);
    } 
    get {
      bool ret = bridgePINVOKE.PlayerData_isNeutral_get(swigCPtr);
      return ret;
    } 
  }

  public int startLocationX {
    set {
      bridgePINVOKE.PlayerData_startLocationX_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.PlayerData_startLocationX_get(swigCPtr);
      return ret;
    } 
  }

  public int startLocationY {
    set {
      bridgePINVOKE.PlayerData_startLocationY_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.PlayerData_startLocationY_get(swigCPtr);
      return ret;
    } 
  }

  public bool isVictorious {
    set {
      bridgePINVOKE.PlayerData_isVictorious_set(swigCPtr, value);
    } 
    get {
      bool ret = bridgePINVOKE.PlayerData_isVictorious_get(swigCPtr);
      return ret;
    } 
  }

  public bool isDefeated {
    set {
      bridgePINVOKE.PlayerData_isDefeated_set(swigCPtr, value);
    } 
    get {
      bool ret = bridgePINVOKE.PlayerData_isDefeated_get(swigCPtr);
      return ret;
    } 
  }

  public bool leftGame {
    set {
      bridgePINVOKE.PlayerData_leftGame_set(swigCPtr, value);
    } 
    get {
      bool ret = bridgePINVOKE.PlayerData_leftGame_get(swigCPtr);
      return ret;
    } 
  }

  public int minerals {
    set {
      bridgePINVOKE.PlayerData_minerals_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.PlayerData_minerals_get(swigCPtr);
      return ret;
    } 
  }

  public int gas {
    set {
      bridgePINVOKE.PlayerData_gas_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.PlayerData_gas_get(swigCPtr);
      return ret;
    } 
  }

  public int cumulativeMinerals {
    set {
      bridgePINVOKE.PlayerData_cumulativeMinerals_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.PlayerData_cumulativeMinerals_get(swigCPtr);
      return ret;
    } 
  }

  public int cumulativeGas {
    set {
      bridgePINVOKE.PlayerData_cumulativeGas_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.PlayerData_cumulativeGas_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_int supplyTotal {
    set {
      bridgePINVOKE.PlayerData_supplyTotal_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.PlayerData_supplyTotal_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int supplyUsed {
    set {
      bridgePINVOKE.PlayerData_supplyUsed_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.PlayerData_supplyUsed_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int allUnitCount {
    set {
      bridgePINVOKE.PlayerData_allUnitCount_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.PlayerData_allUnitCount_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int completedUnitCount {
    set {
      bridgePINVOKE.PlayerData_completedUnitCount_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.PlayerData_completedUnitCount_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int deadUnitCount {
    set {
      bridgePINVOKE.PlayerData_deadUnitCount_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.PlayerData_deadUnitCount_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int killedUnitCount {
    set {
      bridgePINVOKE.PlayerData_killedUnitCount_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.PlayerData_killedUnitCount_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int upgradeLevel {
    set {
      bridgePINVOKE.PlayerData_upgradeLevel_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.PlayerData_upgradeLevel_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_bool hasResearched {
    set {
      bridgePINVOKE.PlayerData_hasResearched_set(swigCPtr, SWIGTYPE_p_bool.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.PlayerData_hasResearched_get(swigCPtr);
      SWIGTYPE_p_bool ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_bool(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_bool isResearching {
    set {
      bridgePINVOKE.PlayerData_isResearching_set(swigCPtr, SWIGTYPE_p_bool.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.PlayerData_isResearching_get(swigCPtr);
      SWIGTYPE_p_bool ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_bool(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_bool isUpgrading {
    set {
      bridgePINVOKE.PlayerData_isUpgrading_set(swigCPtr, SWIGTYPE_p_bool.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.PlayerData_isUpgrading_get(swigCPtr);
      SWIGTYPE_p_bool ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_bool(cPtr, false);
      return ret;
    } 
  }

  public int colorByte {
    set {
      bridgePINVOKE.PlayerData_colorByte_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.PlayerData_colorByte_get(swigCPtr);
      return ret;
    } 
  }

  public int color {
    set {
      bridgePINVOKE.PlayerData_color_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.PlayerData_color_get(swigCPtr);
      return ret;
    } 
  }

  public PlayerData() : this(bridgePINVOKE.new_PlayerData(), true) {
  }

}

}