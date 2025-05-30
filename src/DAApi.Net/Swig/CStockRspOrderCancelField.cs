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

public class CStockRspOrderCancelField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CStockRspOrderCancelField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CStockRspOrderCancelField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CStockRspOrderCancelField obj) {
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

  ~CStockRspOrderCancelField() {
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
          DaApiWrapperPINVOKE.delete_CStockRspOrderCancelField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string UserId {
    set {
      DaApiWrapperPINVOKE.CStockRspOrderCancelField_UserId_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockRspOrderCancelField_UserId_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountNo {
    set {
      DaApiWrapperPINVOKE.CStockRspOrderCancelField_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockRspOrderCancelField_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string SystemNo {
    set {
      DaApiWrapperPINVOKE.CStockRspOrderCancelField_SystemNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockRspOrderCancelField_SystemNo_get(swigCPtr);
      return ret;
    } 
  }

  public string LocalNo {
    set {
      DaApiWrapperPINVOKE.CStockRspOrderCancelField_LocalNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockRspOrderCancelField_LocalNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      DaApiWrapperPINVOKE.CStockRspOrderCancelField_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockRspOrderCancelField_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelNo {
    set {
      DaApiWrapperPINVOKE.CStockRspOrderCancelField_CancelNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockRspOrderCancelField_CancelNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeCode {
    set {
      DaApiWrapperPINVOKE.CStockRspOrderCancelField_ExchangeCode_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockRspOrderCancelField_ExchangeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractCode {
    set {
      DaApiWrapperPINVOKE.CStockRspOrderCancelField_ContractCode_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockRspOrderCancelField_ContractCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BidAskFlag {
    set {
      DaApiWrapperPINVOKE.CStockRspOrderCancelField_BidAskFlag_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockRspOrderCancelField_BidAskFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderQty {
    set {
      DaApiWrapperPINVOKE.CStockRspOrderCancelField_OrderQty_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockRspOrderCancelField_OrderQty_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderPrice {
    set {
      DaApiWrapperPINVOKE.CStockRspOrderCancelField_OrderPrice_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockRspOrderCancelField_OrderPrice_get(swigCPtr);
      return ret;
    } 
  }

  public string FilledQty {
    set {
      DaApiWrapperPINVOKE.CStockRspOrderCancelField_FilledQty_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockRspOrderCancelField_FilledQty_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelledQty {
    set {
      DaApiWrapperPINVOKE.CStockRspOrderCancelField_CancelledQty_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockRspOrderCancelField_CancelledQty_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderType {
    set {
      DaApiWrapperPINVOKE.CStockRspOrderCancelField_OrderType_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockRspOrderCancelField_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelledDate {
    set {
      DaApiWrapperPINVOKE.CStockRspOrderCancelField_CancelledDate_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockRspOrderCancelField_CancelledDate_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelledTime {
    set {
      DaApiWrapperPINVOKE.CStockRspOrderCancelField_CancelledTime_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockRspOrderCancelField_CancelledTime_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorCode {
    set {
      DaApiWrapperPINVOKE.CStockRspOrderCancelField_ErrorCode_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CStockRspOrderCancelField_ErrorCode_get(swigCPtr);
      return ret;
    } 
  }

  public CStockRspOrderCancelField() : this(DaApiWrapperPINVOKE.new_CStockRspOrderCancelField(), true) {
  }

}

}
