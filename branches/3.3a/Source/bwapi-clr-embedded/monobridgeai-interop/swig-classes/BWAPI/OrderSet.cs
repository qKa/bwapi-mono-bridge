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

public partial class OrderSet : IDisposable 
#if !SWIG_DOTNET_1
    , System.Collections.Generic.ICollection<Order>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OrderSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(OrderSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~OrderSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_OrderSet(swigCPtr);
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
 public System.Collections.Generic.ICollection<Order> Values {
    get {
      System.Collections.Generic.ICollection<Order> values = new System.Collections.Generic.List<Order>();
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
 
  public bool Contains(Order item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(Order[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( Order[] array, int arrayIndex) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<Order> keyList = new System.Collections.Generic.List<Order>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      Order currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< Order> System.Collections.Generic.IEnumerable<Order>.GetEnumerator() {
    return new OrderSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new OrderSetEnumerator(this);
  }

  public OrderSetEnumerator GetEnumerator() {
    return new OrderSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class OrderSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< Order>
  {
    private OrderSet collectionRef;
    private System.Collections.Generic.IList<Order> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public OrderSetEnumerator(OrderSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<Order>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  Order Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return ( Order)currentObject;
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
        Order currentKey = keyCollection[currentIndex];
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
  

  public OrderSet() : this(bwapiPINVOKE.new_OrderSet__SWIG_0(), true) {
  }

  public OrderSet(OrderSet other) : this(bwapiPINVOKE.new_OrderSet__SWIG_1(OrderSet.getCPtr(other)), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bwapiPINVOKE.OrderSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bwapiPINVOKE.OrderSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bwapiPINVOKE.OrderSet_Clear(swigCPtr);
  }

  public Order getitem(Order key) {
    Order ret = new Order(bwapiPINVOKE.OrderSet_getitem(swigCPtr, Order.getCPtr(key)), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(Order key) {
    bool ret = bwapiPINVOKE.OrderSet_ContainsKey(swigCPtr, Order.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(Order key) {
    bwapiPINVOKE.OrderSet_Add(swigCPtr, Order.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(Order key) {
    bool ret = bwapiPINVOKE.OrderSet_Remove(swigCPtr, Order.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public IntPtr create_iterator_begin() {
    IntPtr ret = bwapiPINVOKE.OrderSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public Order get_next_key(IntPtr swigiterator) {
    Order ret = new Order(bwapiPINVOKE.OrderSet_get_next_key(swigCPtr, swigiterator), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
