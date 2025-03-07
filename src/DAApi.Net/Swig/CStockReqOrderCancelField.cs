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

public class CStockReqOrderCancelField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CStockReqOrderCancelField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CStockReqOrderCancelField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CStockReqOrderCancelField obj) {
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

  ~CStockReqOrderCancelField() {
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
          DaApiWrapperPINVOKE.delete_CStockReqOrderCancelField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string UserId {
    set {
      DaApiWrapperPINVOKE.CStockReqOrderCancelField_UserId_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockReqOrderCancelField_UserId_get(swigCPtr);
      return ret;
    } 
  }

  public string LocalNo {
    set {
      DaApiWrapperPINVOKE.CStockReqOrderCancelField_LocalNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockReqOrderCancelField_LocalNo_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountNo {
    set {
      DaApiWrapperPINVOKE.CStockReqOrderCancelField_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockReqOrderCancelField_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string SystemNo {
    set {
      DaApiWrapperPINVOKE.CStockReqOrderCancelField_SystemNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockReqOrderCancelField_SystemNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      DaApiWrapperPINVOKE.CStockReqOrderCancelField_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockReqOrderCancelField_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeCode {
    set {
      DaApiWrapperPINVOKE.CStockReqOrderCancelField_ExchangeCode_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockReqOrderCancelField_ExchangeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractCode {
    set {
      DaApiWrapperPINVOKE.CStockReqOrderCancelField_ContractCode_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockReqOrderCancelField_ContractCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BidAskFlag {
    set {
      DaApiWrapperPINVOKE.CStockReqOrderCancelField_BidAskFlag_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockReqOrderCancelField_BidAskFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderQty {
    set {
      DaApiWrapperPINVOKE.CStockReqOrderCancelField_OrderQty_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockReqOrderCancelField_OrderQty_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderPrice {
    set {
      DaApiWrapperPINVOKE.CStockReqOrderCancelField_OrderPrice_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockReqOrderCancelField_OrderPrice_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderType {
    set {
      DaApiWrapperPINVOKE.CStockReqOrderCancelField_OrderType_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockReqOrderCancelField_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorDescription {
    set {
      DaApiWrapperPINVOKE.CStockReqOrderCancelField_ErrorDescription_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockReqOrderCancelField_ErrorDescription_get(swigCPtr);
      return ret;
    } 
  }

  public CStockReqOrderCancelField() : this(DaApiWrapperPINVOKE.new_CStockReqOrderCancelField(), true) {
  }

}

}
