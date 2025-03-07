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

public class CFutureRspOrderField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CFutureRspOrderField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CFutureRspOrderField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CFutureRspOrderField obj) {
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

  ~CFutureRspOrderField() {
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
          DaApiWrapperPINVOKE.delete_CFutureRspOrderField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string UserId {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_UserId_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_UserId_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountNo {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string SystemNo {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_SystemNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_SystemNo_get(swigCPtr);
      return ret;
    } 
  }

  public string LocalNo {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_LocalNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_LocalNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeCode {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_ExchangeCode_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_ExchangeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractCode {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_ContractCode_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_ContractCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BidAskFlag {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_BidAskFlag_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_BidAskFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderQty {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_OrderQty_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_OrderQty_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderPrice {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_OrderPrice_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_OrderPrice_get(swigCPtr);
      return ret;
    } 
  }

  public string FilledQty {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_FilledQty_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_FilledQty_get(swigCPtr);
      return ret;
    } 
  }

  public string FilledPrice {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_FilledPrice_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_FilledPrice_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderType {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_OrderType_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderDate {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_OrderDate_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_OrderDate_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderTime {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_OrderTime_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_OrderTime_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorCode {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_ErrorCode_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_ErrorCode_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderState {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_OrderState_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_OrderState_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelUserId {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_CancelUserId_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_CancelUserId_get(swigCPtr);
      return ret;
    } 
  }

  public string TriggerPrice {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_TriggerPrice_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_TriggerPrice_get(swigCPtr);
      return ret;
    } 
  }

  public string TIF {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_TIF_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_TIF_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenCloseFlag {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_OpenCloseFlag_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_OpenCloseFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string StrategyId {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_StrategyId_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_StrategyId_get(swigCPtr);
      return ret;
    } 
  }

  public string MaxShow {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_MaxShow_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_MaxShow_get(swigCPtr);
      return ret;
    } 
  }

  public string MinQty {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_MinQty_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_MinQty_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeTime {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_ExchangeTime_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_ExchangeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelTime {
    set {
      DaApiWrapperPINVOKE.CFutureRspOrderField_CancelTime_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspOrderField_CancelTime_get(swigCPtr);
      return ret;
    } 
  }

  public CFutureRspOrderField() : this(DaApiWrapperPINVOKE.new_CFutureRspOrderField(), true) {
  }

}

}
