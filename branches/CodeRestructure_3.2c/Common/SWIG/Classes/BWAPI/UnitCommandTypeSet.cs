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

public partial class UnitCommandTypeSet : IDisposable 
#if !SWIG_DOTNET_1
    , System.Collections.Generic.ICollection<UnitCommandType>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnitCommandTypeSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UnitCommandTypeSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnitCommandTypeSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_UnitCommandTypeSet(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }


  
  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsReadOnly {
    get { 
      return false; 
    }
  }

#if !SWIG_DOTNET_1
 public System.Collections.Generic.ICollection<UnitCommandType> Values {
    get {
      System.Collections.Generic.ICollection<UnitCommandType> values = new System.Collections.Generic.List<UnitCommandType>();
      IntPtr iter = create_iterator_begin();
      try {
        while (true) {
          values.Add(get_next_key(iter));
        }
      } catch (ArgumentOutOfRangeException) {
      }
      return values;
    }
  }
 
  public bool Contains(UnitCommandType item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(UnitCommandType[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( UnitCommandType[] array, int arrayIndex) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<UnitCommandType> keyList = new System.Collections.Generic.List<UnitCommandType>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      UnitCommandType currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< UnitCommandType> System.Collections.Generic.IEnumerable<UnitCommandType>.GetEnumerator() {
    return new UnitCommandTypeSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new UnitCommandTypeSetEnumerator(this);
  }

  public UnitCommandTypeSetEnumerator GetEnumerator() {
    return new UnitCommandTypeSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class UnitCommandTypeSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< UnitCommandType>
  {
    private UnitCommandTypeSet collectionRef;
    private System.Collections.Generic.IList<UnitCommandType> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public UnitCommandTypeSetEnumerator(UnitCommandTypeSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<UnitCommandType>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  UnitCommandType Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return ( UnitCommandType)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        UnitCommandType currentKey = keyCollection[currentIndex];
        currentObject = currentKey;
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
      currentIndex = -1;
      currentObject = null;
    }
  }
#endif
  

  public UnitCommandTypeSet() : this(bwapiPINVOKE.new_UnitCommandTypeSet__SWIG_0(), true) {
  }

  public UnitCommandTypeSet(UnitCommandTypeSet other) : this(bwapiPINVOKE.new_UnitCommandTypeSet__SWIG_1(UnitCommandTypeSet.getCPtr(other)), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bwapiPINVOKE.UnitCommandTypeSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bwapiPINVOKE.UnitCommandTypeSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bwapiPINVOKE.UnitCommandTypeSet_Clear(swigCPtr);
  }

  public UnitCommandType getitem(UnitCommandType key) {
    UnitCommandType ret = new UnitCommandType(bwapiPINVOKE.UnitCommandTypeSet_getitem(swigCPtr, UnitCommandType.getCPtr(key)), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(UnitCommandType key) {
    bool ret = bwapiPINVOKE.UnitCommandTypeSet_ContainsKey(swigCPtr, UnitCommandType.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(UnitCommandType key) {
    bwapiPINVOKE.UnitCommandTypeSet_Add(swigCPtr, UnitCommandType.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(UnitCommandType key) {
    bool ret = bwapiPINVOKE.UnitCommandTypeSet_Remove(swigCPtr, UnitCommandType.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public IntPtr create_iterator_begin() {
    IntPtr ret = bwapiPINVOKE.UnitCommandTypeSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public UnitCommandType get_next_key(IntPtr swigiterator) {
    UnitCommandType ret = new UnitCommandType(bwapiPINVOKE.UnitCommandTypeSet_get_next_key(swigCPtr, swigiterator), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}