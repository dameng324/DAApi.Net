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

public class CFutureRspAccountField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CFutureRspAccountField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CFutureRspAccountField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CFutureRspAccountField obj) {
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

  ~CFutureRspAccountField() {
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
          DaApiWrapperPINVOKE.delete_CFutureRspAccountField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string UserId {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_UserId_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_UserId_get(swigCPtr);
      return ret;
    } 
  }

  public string UserName {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_UserName_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_UserName_get(swigCPtr);
      return ret;
    } 
  }

  public string UserType {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_UserType_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_UserType_get(swigCPtr);
      return ret;
    } 
  }

  public string LoginPwd {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_LoginPwd_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_LoginPwd_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountNo {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string TradePwd {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_TradePwd_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_TradePwd_get(swigCPtr);
      return ret;
    } 
  }

  public string IsSimulation {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_IsSimulation_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_IsSimulation_get(swigCPtr);
      return ret;
    } 
  }

  public string FrontendIp {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_FrontendIp_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_FrontendIp_get(swigCPtr);
      return ret;
    } 
  }

  public string FrontendPort {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_FrontendPort_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_FrontendPort_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyNo {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_CurrencyNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_CurrencyNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UserState {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_UserState_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_UserState_get(swigCPtr);
      return ret;
    } 
  }

  public string SelAll {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_SelAll_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_SelAll_get(swigCPtr);
      return ret;
    } 
  }

  public string Strategy {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_Strategy_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_Strategy_get(swigCPtr);
      return ret;
    } 
  }

  public string Inner {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_Inner_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_Inner_get(swigCPtr);
      return ret;
    } 
  }

  public string YingSun {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_YingSun_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_YingSun_get(swigCPtr);
      return ret;
    } 
  }

  public string ChaoDan {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_ChaoDan_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_ChaoDan_get(swigCPtr);
      return ret;
    } 
  }

  public string Option {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_Option_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_Option_get(swigCPtr);
      return ret;
    } 
  }

  public string CmeMarket {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_CmeMarket_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_CmeMarket_get(swigCPtr);
      return ret;
    } 
  }

  public string CmeCOMEXMarket {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_CmeCOMEXMarket_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_CmeCOMEXMarket_get(swigCPtr);
      return ret;
    } 
  }

  public string CmeNYMEXMarket {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_CmeNYMEXMarket_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_CmeNYMEXMarket_get(swigCPtr);
      return ret;
    } 
  }

  public string CmeCBTMarket {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_CmeCBTMarket_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_CmeCBTMarket_get(swigCPtr);
      return ret;
    } 
  }

  public string IceUSMarket {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_IceUSMarket_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_IceUSMarket_get(swigCPtr);
      return ret;
    } 
  }

  public string IceECMarket {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_IceECMarket_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_IceECMarket_get(swigCPtr);
      return ret;
    } 
  }

  public string IceEFMarket {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_IceEFMarket_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_IceEFMarket_get(swigCPtr);
      return ret;
    } 
  }

  public string CanTradeStockHK {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_CanTradeStockHK_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_CanTradeStockHK_get(swigCPtr);
      return ret;
    } 
  }

  public string CanTradeStockAM {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_CanTradeStockAM_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_CanTradeStockAM_get(swigCPtr);
      return ret;
    } 
  }

  public string MultiLogin {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_MultiLogin_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_MultiLogin_get(swigCPtr);
      return ret;
    } 
  }

  public string SellStockHK {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_SellStockHK_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_SellStockHK_get(swigCPtr);
      return ret;
    } 
  }

  public string SellStockAM {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_SellStockAM_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_SellStockAM_get(swigCPtr);
      return ret;
    } 
  }

  public string CanTradeStockKRX {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_CanTradeStockKRX_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_CanTradeStockKRX_get(swigCPtr);
      return ret;
    } 
  }

  public string HkexMarket {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_HkexMarket_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_HkexMarket_get(swigCPtr);
      return ret;
    } 
  }

  public string IdNumber {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_IdNumber_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_IdNumber_get(swigCPtr);
      return ret;
    } 
  }

  public string HkexMarketFee {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_HkexMarketFee_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_HkexMarketFee_get(swigCPtr);
      return ret;
    } 
  }

  public string IsProfessional {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_IsProfessional_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_IsProfessional_get(swigCPtr);
      return ret;
    } 
  }

  public string IsOverSea {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_IsOverSea_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_IsOverSea_get(swigCPtr);
      return ret;
    } 
  }

  public string IsFirstLogin {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_IsFirstLogin_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_IsFirstLogin_get(swigCPtr);
      return ret;
    } 
  }

  public string UserMobile {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_UserMobile_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_UserMobile_get(swigCPtr);
      return ret;
    } 
  }

  public string HasSetQA {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_HasSetQA_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_HasSetQA_get(swigCPtr);
      return ret;
    } 
  }

  public string CanTradeStockSGXQ {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_CanTradeStockSGXQ_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_CanTradeStockSGXQ_get(swigCPtr);
      return ret;
    } 
  }

  public string ExistMac {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_ExistMac_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_ExistMac_get(swigCPtr);
      return ret;
    } 
  }

  public string RatioINE {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_RatioINE_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_RatioINE_get(swigCPtr);
      return ret;
    } 
  }

  public string EurexMarket {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_EurexMarket_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_EurexMarket_get(swigCPtr);
      return ret;
    } 
  }

  public string HkexIsOverMaxTerminal {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_HkexIsOverMaxTerminal_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_HkexIsOverMaxTerminal_get(swigCPtr);
      return ret;
    } 
  }

  public string HkexOverMoney {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_HkexOverMoney_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_HkexOverMoney_get(swigCPtr);
      return ret;
    } 
  }

  public string CanTradeStockAU {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_CanTradeStockAU_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_CanTradeStockAU_get(swigCPtr);
      return ret;
    } 
  }

  public string NyFlag {
    set {
      DaApiWrapperPINVOKE.CFutureRspAccountField_NyFlag_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspAccountField_NyFlag_get(swigCPtr);
      return ret;
    } 
  }

  public CFutureRspAccountField() : this(DaApiWrapperPINVOKE.new_CFutureRspAccountField(), true) {
  }

}

}
