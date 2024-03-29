/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SWIG.BWTA {
 
	// defaults
	using System; 
	using System.Runtime.InteropServices; 
	// BWAPI
	using BWAPI;

public partial class Polygon : PositionVector {
  private HandleRef swigCPtr;

  internal Polygon(IntPtr cPtr, bool cMemoryOwn) : base(bwtaPINVOKE.Polygon_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Polygon obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Polygon() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwtaPINVOKE.delete_Polygon(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
public override int GetHashCode()
{
   return this.swigCPtr.Handle.GetHashCode();
}

public override bool Equals(object obj)
{
    bool equal = false;
    if (obj is Polygon)
      equal = (((Polygon)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(Polygon obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(Polygon obj1, Polygon obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(Polygon obj1, Polygon obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public Polygon() : this(bwtaPINVOKE.new_Polygon__SWIG_0(), true) {
  }

  public Polygon(Polygon b) : this(bwtaPINVOKE.new_Polygon__SWIG_1(Polygon.getCPtr(b)), true) {
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
  }

  public double getArea() {
    double ret = bwtaPINVOKE.Polygon_getArea(swigCPtr);
    return ret;
  }

  public double getPerimeter() {
    double ret = bwtaPINVOKE.Polygon_getPerimeter(swigCPtr);
    return ret;
  }

  public Position getCenter() {
    Position ret = new Position(bwtaPINVOKE.Polygon_getCenter(swigCPtr), true);
    return ret;
  }

  public bool isInside(Position p) {
    bool ret = bwtaPINVOKE.Polygon_isInside(swigCPtr, Position.getCPtr(p));
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Position getNearestPoint(Position p) {
    Position ret = new Position(bwtaPINVOKE.Polygon_getNearestPoint(swigCPtr, Position.getCPtr(p)), true);
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PolygonVector getHoles() {
    PolygonVector ret = new PolygonVector(bwtaPINVOKE.Polygon_getHoles(swigCPtr), false);
    return ret;
  }

  public PolygonVector holes {
    set {
      bwtaPINVOKE.Polygon_holes_set(swigCPtr, PolygonVector.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwtaPINVOKE.Polygon_holes_get(swigCPtr);
      PolygonVector ret = (cPtr == IntPtr.Zero) ? null : new PolygonVector(cPtr, false);
      return ret;
    } 
  }

}

}
