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

public class CMarketApi : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CMarketApi(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CMarketApi obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CMarketApi obj) {
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

  ~CMarketApi() {
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
          DaApiWrapperPINVOKE.delete_CMarketApi(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public static string GetVersion() {
    string ret = DaApiWrapperPINVOKE.CMarketApi_GetVersion();
    return ret;
  }

  public static CMarketApi CreateMarketApi(bool bRecordLog, string lpszLogFileName) {
    global::System.IntPtr cPtr = DaApiWrapperPINVOKE.CMarketApi_CreateMarketApi__SWIG_0(bRecordLog, lpszLogFileName);
    CMarketApi ret = (cPtr == global::System.IntPtr.Zero) ? null : new CMarketApi(cPtr, false);
    return ret;
  }

  public static CMarketApi CreateMarketApi(bool bRecordLog) {
    global::System.IntPtr cPtr = DaApiWrapperPINVOKE.CMarketApi_CreateMarketApi__SWIG_1(bRecordLog);
    CMarketApi ret = (cPtr == global::System.IntPtr.Zero) ? null : new CMarketApi(cPtr, false);
    return ret;
  }

  public virtual bool Init() {
    bool ret = DaApiWrapperPINVOKE.CMarketApi_Init(swigCPtr);
    return ret;
  }

  public virtual void Release() {
    DaApiWrapperPINVOKE.CMarketApi_Release(swigCPtr);
  }

  public virtual void SetHeartBeatTimeout(int iTimeout, bool bIsStrictCheck) {
    DaApiWrapperPINVOKE.CMarketApi_SetHeartBeatTimeout__SWIG_0(swigCPtr, iTimeout, bIsStrictCheck);
  }

  public virtual void SetHeartBeatTimeout(int iTimeout) {
    DaApiWrapperPINVOKE.CMarketApi_SetHeartBeatTimeout__SWIG_1(swigCPtr, iTimeout);
  }

  public virtual void RegisterSpi(IMarketEvent pIMarketEvent) {
    DaApiWrapperPINVOKE.CMarketApi_RegisterSpi(swigCPtr, IMarketEvent.getCPtr(pIMarketEvent));
  }

  public virtual void RegisterNameServer(string pszNsAddress) {
    DaApiWrapperPINVOKE.CMarketApi_RegisterNameServer(swigCPtr, pszNsAddress);
  }

  public virtual bool ReqUserLogin(CMarketReqUserLoginField pReqUserLoginField, int iRequestID) {
    bool ret = DaApiWrapperPINVOKE.CMarketApi_ReqUserLogin(swigCPtr, CMarketReqUserLoginField.getCPtr(pReqUserLoginField), iRequestID);
    return ret;
  }

  public virtual bool ReqBrokerData(CMarketReqBrokerDataField pReqBrokerDataField, int iRequestID) {
    bool ret = DaApiWrapperPINVOKE.CMarketApi_ReqBrokerData(swigCPtr, CMarketReqBrokerDataField.getCPtr(pReqBrokerDataField), iRequestID);
    return ret;
  }

  public virtual bool ReqMarketData(CMarketReqMarketDataField pReqMarketDataField, int iRequestID) {
    bool ret = DaApiWrapperPINVOKE.CMarketApi_ReqMarketData(swigCPtr, CMarketReqMarketDataField.getCPtr(pReqMarketDataField), iRequestID);
    return ret;
  }

}

}
