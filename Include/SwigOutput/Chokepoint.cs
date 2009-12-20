/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace BWAPI {

using System;
using System.Runtime.InteropServices;

public class Chokepoint : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Chokepoint(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Chokepoint obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Chokepoint() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_Chokepoint(swigCPtr);
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
    if (obj is Chokepoint)
      equal = (((Chokepoint)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(Chokepoint obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(Chokepoint obj1, Chokepoint obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(Chokepoint obj1, Chokepoint obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public virtual RegionPtrRegionPtrPair getRegions() {
    RegionPtrRegionPtrPair ret = new RegionPtrRegionPtrPair(bridgePINVOKE.Chokepoint_getRegions(swigCPtr), false);
    return ret;
  }

  public virtual PositionPair getSides() {
    PositionPair ret = new PositionPair(bridgePINVOKE.Chokepoint_getSides(swigCPtr), false);
    return ret;
  }

  public virtual Position getCenter() {
    Position ret = new Position(bridgePINVOKE.Chokepoint_getCenter(swigCPtr), true);
    return ret;
  }

  public virtual double getWidth() {
    double ret = bridgePINVOKE.Chokepoint_getWidth(swigCPtr);
    return ret;
  }

}

}
