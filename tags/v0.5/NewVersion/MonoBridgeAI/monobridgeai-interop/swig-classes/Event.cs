/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class Event : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Event(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Event obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Event() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_Event(swigCPtr);
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
    if (obj is Event)
      equal = (((Event)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(Event obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(Event obj1, Event obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(Event obj1, Event obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public Event() : this(bridgePINVOKE.new_Event(), true) {
  }

  public bool opEquals(Event other) {
    bool ret = bridgePINVOKE.Event_opEquals(swigCPtr, Event.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Event MatchStart() {
    Event ret = new Event(bridgePINVOKE.Event_MatchStart(), true);
    return ret;
  }

  public static Event MatchEnd(bool isWinner) {
    Event ret = new Event(bridgePINVOKE.Event_MatchEnd(isWinner), true);
    return ret;
  }

  public static Event MatchFrame() {
    Event ret = new Event(bridgePINVOKE.Event_MatchFrame(), true);
    return ret;
  }

  public static Event MenuFrame() {
    Event ret = new Event(bridgePINVOKE.Event_MenuFrame(), true);
    return ret;
  }

  public static Event SendText(string text) {
    Event ret = new Event(bridgePINVOKE.Event_SendText(text), true);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Event ReceiveText(Player player, string text) {
    Event ret = new Event(bridgePINVOKE.Event_ReceiveText(Player.getCPtr(player), text), true);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Event PlayerLeft(Player player) {
    Event ret = new Event(bridgePINVOKE.Event_PlayerLeft(Player.getCPtr(player)), true);
    return ret;
  }

  public static Event NukeDetect(SWIGTYPE_p_Position target) {
    Event ret = new Event(bridgePINVOKE.Event_NukeDetect(SWIGTYPE_p_Position.getCPtr(target)), true);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Event UnitDiscover(Unit unit) {
    Event ret = new Event(bridgePINVOKE.Event_UnitDiscover(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static Event UnitEvade(Unit unit) {
    Event ret = new Event(bridgePINVOKE.Event_UnitEvade(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static Event UnitShow(Unit unit) {
    Event ret = new Event(bridgePINVOKE.Event_UnitShow(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static Event UnitHide(Unit unit) {
    Event ret = new Event(bridgePINVOKE.Event_UnitHide(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static Event UnitCreate(Unit unit) {
    Event ret = new Event(bridgePINVOKE.Event_UnitCreate(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static Event UnitDestroy(Unit unit) {
    Event ret = new Event(bridgePINVOKE.Event_UnitDestroy(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static Event UnitMorph(Unit unit) {
    Event ret = new Event(bridgePINVOKE.Event_UnitMorph(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static Event UnitRenegade(Unit unit) {
    Event ret = new Event(bridgePINVOKE.Event_UnitRenegade(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static Event SaveGame(string gameName) {
    Event ret = new Event(bridgePINVOKE.Event_SaveGame(gameName), true);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_EventType__Enum type {
    set {
      bridgePINVOKE.Event_type_set(swigCPtr, SWIGTYPE_p_EventType__Enum.getCPtr(value));
      if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_EventType__Enum ret = new SWIGTYPE_p_EventType__Enum(bridgePINVOKE.Event_type_get(swigCPtr), true);
      if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_Position position {
    set {
      bridgePINVOKE.Event_position_set(swigCPtr, SWIGTYPE_p_Position.getCPtr(value));
      if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_Position ret = new SWIGTYPE_p_Position(bridgePINVOKE.Event_position_get(swigCPtr), true);
      if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string text {
    set {
      bridgePINVOKE.Event_text_set(swigCPtr, value);
      if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = bridgePINVOKE.Event_text_get(swigCPtr);
      if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Unit unit {
    set {
      bridgePINVOKE.Event_unit_set(swigCPtr, Unit.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.Event_unit_get(swigCPtr);
      Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
      return ret;
    } 
  }

  public Player player {
    set {
      bridgePINVOKE.Event_player_set(swigCPtr, Player.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.Event_player_get(swigCPtr);
      Player ret = (cPtr == IntPtr.Zero) ? null : new Player(cPtr, false);
      return ret;
    } 
  }

  public bool isWinner {
    set {
      bridgePINVOKE.Event_isWinner_set(swigCPtr, value);
    } 
    get {
      bool ret = bridgePINVOKE.Event_isWinner_get(swigCPtr);
      return ret;
    } 
  }

}

}