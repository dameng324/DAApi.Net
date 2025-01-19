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

public class CFutureReqOrderModifyField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CFutureReqOrderModifyField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CFutureReqOrderModifyField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CFutureReqOrderModifyField obj) {
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

  ~CFutureReqOrderModifyField() {
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
          DaApiWrapperPINVOKE.delete_CFutureReqOrderModifyField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string SystemNo {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_SystemNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_SystemNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UserId {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_UserId_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_UserId_get(swigCPtr);
      return ret;
    } 
  }

  public string LocalNo {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_LocalNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_LocalNo_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountNo {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeCode {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_ExchangeCode_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_ExchangeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractCode {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_ContractCode_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_ContractCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BidAskFlag {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_BidAskFlag_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_BidAskFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderQty {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_OrderQty_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_OrderQty_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderPrice {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_OrderPrice_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_OrderPrice_get(swigCPtr);
      return ret;
    } 
  }

  public string ModifyQty {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_ModifyQty_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_ModifyQty_get(swigCPtr);
      return ret;
    } 
  }

  public string ModifyPrice {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_ModifyPrice_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_ModifyPrice_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderType {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_OrderType_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public string TriggerPrice {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_TriggerPrice_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_TriggerPrice_get(swigCPtr);
      return ret;
    } 
  }

  public string ModifyTriggerPrice {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_ModifyTriggerPrice_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_ModifyTriggerPrice_get(swigCPtr);
      return ret;
    } 
  }

  public string TIF {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_TIF_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_TIF_get(swigCPtr);
      return ret;
    } 
  }

  public string Tag50 {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_Tag50_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_Tag50_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorDescription {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_ErrorDescription_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_ErrorDescription_get(swigCPtr);
      return ret;
    } 
  }

  public string OrgOrderLocationID {
    set {
      DaApiWrapperPINVOKE.CFutureReqOrderModifyField_OrgOrderLocationID_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureReqOrderModifyField_OrgOrderLocationID_get(swigCPtr);
      return ret;
    } 
  }

  public CFutureReqOrderModifyField() : this(DaApiWrapperPINVOKE.new_CFutureReqOrderModifyField(), true) {
  }

}

}
