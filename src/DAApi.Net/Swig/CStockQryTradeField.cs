//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.3.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace DAApi.Net {

public class CStockQryTradeField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CStockQryTradeField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CStockQryTradeField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CStockQryTradeField obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~CStockQryTradeField() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          DaApiWrapperPINVOKE.delete_CStockQryTradeField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string UserId {
    set {
      DaApiWrapperPINVOKE.CStockQryTradeField_UserId_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockQryTradeField_UserId_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorDescription {
    set {
      DaApiWrapperPINVOKE.CStockQryTradeField_ErrorDescription_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockQryTradeField_ErrorDescription_get(swigCPtr);
      return ret;
    } 
  }

  public string lastFilledNo {
    set {
      DaApiWrapperPINVOKE.CStockQryTradeField_lastFilledNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockQryTradeField_lastFilledNo_get(swigCPtr);
      return ret;
    } 
  }

  public CStockQryTradeField() : this(DaApiWrapperPINVOKE.new_CStockQryTradeField(), true) {
  }

}

}
