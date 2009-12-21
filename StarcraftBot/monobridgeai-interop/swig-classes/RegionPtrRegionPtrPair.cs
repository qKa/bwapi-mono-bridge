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

public partial class RegionPtrRegionPtrPair : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RegionPtrRegionPtrPair(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RegionPtrRegionPtrPair obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RegionPtrRegionPtrPair() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_RegionPtrRegionPtrPair(swigCPtr);
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
    if (obj is RegionPtrRegionPtrPair)
      equal = (((RegionPtrRegionPtrPair)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(RegionPtrRegionPtrPair obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(RegionPtrRegionPtrPair obj1, RegionPtrRegionPtrPair obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(RegionPtrRegionPtrPair obj1, RegionPtrRegionPtrPair obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public RegionPtrRegionPtrPair() : this(bridgePINVOKE.new_RegionPtrRegionPtrPair__SWIG_0(), true) {
  }

  public RegionPtrRegionPtrPair(Region t, Region u) : this(bridgePINVOKE.new_RegionPtrRegionPtrPair__SWIG_1(Region.getCPtr(t), Region.getCPtr(u)), true) {
  }

  public RegionPtrRegionPtrPair(RegionPtrRegionPtrPair p) : this(bridgePINVOKE.new_RegionPtrRegionPtrPair__SWIG_2(RegionPtrRegionPtrPair.getCPtr(p)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public Region first {
    set {
      bridgePINVOKE.RegionPtrRegionPtrPair_first_set(swigCPtr, Region.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.RegionPtrRegionPtrPair_first_get(swigCPtr);
      Region ret = (cPtr == IntPtr.Zero) ? null : new Region(cPtr, false);
      return ret;
    } 
  }

  public Region second {
    set {
      bridgePINVOKE.RegionPtrRegionPtrPair_second_set(swigCPtr, Region.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.RegionPtrRegionPtrPair_second_get(swigCPtr);
      Region ret = (cPtr == IntPtr.Zero) ? null : new Region(cPtr, false);
      return ret;
    } 
  }

}

}