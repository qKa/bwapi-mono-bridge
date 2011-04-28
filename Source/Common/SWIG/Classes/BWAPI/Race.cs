/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SWIG.BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class Race : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Race(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Race obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Race() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_Race(swigCPtr);
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
    if (obj is Race)
      equal = (((Race)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(Race obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(Race obj1, Race obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(Race obj1, Race obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public Race() : this(bwapiPINVOKE.new_Race__SWIG_0(), true) {
  }

  public Race(int id) : this(bwapiPINVOKE.new_Race__SWIG_1(id), true) {
  }

  public Race(Race other) : this(bwapiPINVOKE.new_Race__SWIG_2(Race.getCPtr(other)), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public Race opAssign(Race other) {
    Race ret = new Race(bwapiPINVOKE.Race_opAssign(swigCPtr, Race.getCPtr(other)), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int opInt() {
    int ret = bwapiPINVOKE.Race_opInt(swigCPtr);
    return ret;
  }

  public int getID() {
    int ret = bwapiPINVOKE.Race_getID(swigCPtr);
    return ret;
  }

  public string getName() {
    string ret = bwapiPINVOKE.Race_getName(swigCPtr);
    return ret;
  }

  public UnitType getWorker() {
    UnitType ret = new UnitType(bwapiPINVOKE.Race_getWorker(swigCPtr), true);
    return ret;
  }

  public UnitType getCenter() {
    UnitType ret = new UnitType(bwapiPINVOKE.Race_getCenter(swigCPtr), true);
    return ret;
  }

  public UnitType getRefinery() {
    UnitType ret = new UnitType(bwapiPINVOKE.Race_getRefinery(swigCPtr), true);
    return ret;
  }

  public UnitType getTransport() {
    UnitType ret = new UnitType(bwapiPINVOKE.Race_getTransport(swigCPtr), true);
    return ret;
  }

  public UnitType getSupplyProvider() {
    UnitType ret = new UnitType(bwapiPINVOKE.Race_getSupplyProvider(swigCPtr), true);
    return ret;
  }

}

}