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

public partial class TilePositionSet : IDisposable 
#if !SWIG_DOTNET_1
    , System.Collections.Generic.ICollection<TilePosition>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TilePositionSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TilePositionSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TilePositionSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_TilePositionSet(swigCPtr);
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
 public System.Collections.Generic.ICollection<TilePosition> Values {
    get {
      System.Collections.Generic.ICollection<TilePosition> values = new System.Collections.Generic.List<TilePosition>();
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
 
  public bool Contains(TilePosition item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(TilePosition[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( TilePosition[] array, int arrayIndex) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<TilePosition> keyList = new System.Collections.Generic.List<TilePosition>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      TilePosition currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< TilePosition> System.Collections.Generic.IEnumerable<TilePosition>.GetEnumerator() {
    return new TilePositionSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new TilePositionSetEnumerator(this);
  }

  public TilePositionSetEnumerator GetEnumerator() {
    return new TilePositionSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class TilePositionSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< TilePosition>
  {
    private TilePositionSet collectionRef;
    private System.Collections.Generic.IList<TilePosition> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public TilePositionSetEnumerator(TilePositionSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<TilePosition>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  TilePosition Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return ( TilePosition)currentObject;
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
        TilePosition currentKey = keyCollection[currentIndex];
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
  

  public TilePositionSet() : this(bridgePINVOKE.new_TilePositionSet__SWIG_0(), true) {
  }

  public TilePositionSet(TilePositionSet other) : this(bridgePINVOKE.new_TilePositionSet__SWIG_1(TilePositionSet.getCPtr(other)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bridgePINVOKE.TilePositionSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bridgePINVOKE.TilePositionSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bridgePINVOKE.TilePositionSet_Clear(swigCPtr);
  }

  public TilePosition getitem(TilePosition key) {
    TilePosition ret = new TilePosition(bridgePINVOKE.TilePositionSet_getitem(swigCPtr, TilePosition.getCPtr(key)), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(TilePosition key) {
    bool ret = bridgePINVOKE.TilePositionSet_ContainsKey(swigCPtr, TilePosition.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(TilePosition key) {
    bridgePINVOKE.TilePositionSet_Add(swigCPtr, TilePosition.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(TilePosition key) {
    bool ret = bridgePINVOKE.TilePositionSet_Remove(swigCPtr, TilePosition.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public IntPtr create_iterator_begin() {
    IntPtr ret = bridgePINVOKE.TilePositionSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public TilePosition get_next_key(IntPtr swigiterator) {
    TilePosition ret = new TilePosition(bridgePINVOKE.TilePositionSet_get_next_key(swigCPtr, swigiterator), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
