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

public partial class UnitSizeType : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnitSizeType(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UnitSizeType obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnitSizeType() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_UnitSizeType(swigCPtr);
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
    if (obj is UnitSizeType)
      equal = (((UnitSizeType)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(UnitSizeType obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(UnitSizeType obj1, UnitSizeType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(UnitSizeType obj1, UnitSizeType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public UnitSizeType() : this(bwapiPINVOKE.new_UnitSizeType__SWIG_0(), true) {
  }

  public UnitSizeType(int id) : this(bwapiPINVOKE.new_UnitSizeType__SWIG_1(id), true) {
  }

  public UnitSizeType(UnitSizeType other) : this(bwapiPINVOKE.new_UnitSizeType__SWIG_2(UnitSizeType.getCPtr(other)), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public UnitSizeType opAssign(UnitSizeType other) {
    UnitSizeType ret = new UnitSizeType(bwapiPINVOKE.UnitSizeType_opAssign(swigCPtr, UnitSizeType.getCPtr(other)), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int opInt() {
    int ret = bwapiPINVOKE.UnitSizeType_opInt(swigCPtr);
    return ret;
  }

  public int getID() {
    int ret = bwapiPINVOKE.UnitSizeType_getID(swigCPtr);
    return ret;
  }

  public string getName() {
    string ret = bwapiPINVOKE.UnitSizeType_getName(swigCPtr);
    return ret;
  }

}

}