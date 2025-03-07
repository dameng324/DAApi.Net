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

public class CFutureRspCapitalField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CFutureRspCapitalField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CFutureRspCapitalField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CFutureRspCapitalField obj) {
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

  ~CFutureRspCapitalField() {
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
          DaApiWrapperPINVOKE.delete_CFutureRspCapitalField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string UserId {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_UserId_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_UserId_get(swigCPtr);
      return ret;
    } 
  }

  public string Deposit {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_Deposit_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_Deposit_get(swigCPtr);
      return ret;
    } 
  }

  public string Withdraw {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_Withdraw_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_Withdraw_get(swigCPtr);
      return ret;
    } 
  }

  public string TodayTradableFund {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_TodayTradableFund_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_TodayTradableFund_get(swigCPtr);
      return ret;
    } 
  }

  public string TodayInitialBalance {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_TodayInitialBalance_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_TodayInitialBalance_get(swigCPtr);
      return ret;
    } 
  }

  public string TodayRealtimeBalance {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_TodayRealtimeBalance_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_TodayRealtimeBalance_get(swigCPtr);
      return ret;
    } 
  }

  public string FrozenFund {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_FrozenFund_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_FrozenFund_get(swigCPtr);
      return ret;
    } 
  }

  public string Commission {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_Commission_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_Commission_get(swigCPtr);
      return ret;
    } 
  }

  public string InitialMargin {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_InitialMargin_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_InitialMargin_get(swigCPtr);
      return ret;
    } 
  }

  public string YdTradableFund {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_YdTradableFund_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_YdTradableFund_get(swigCPtr);
      return ret;
    } 
  }

  public string YdInitialBalance {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_YdInitialBalance_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_YdInitialBalance_get(swigCPtr);
      return ret;
    } 
  }

  public string YdFinalBalance {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_YdFinalBalance_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_YdFinalBalance_get(swigCPtr);
      return ret;
    } 
  }

  public string ProfitLoss {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_ProfitLoss_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_ProfitLoss_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyNo {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_CurrencyNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_CurrencyNo_get(swigCPtr);
      return ret;
    } 
  }

  public double CurrencyRate {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_CurrencyRate_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_CurrencyRate_get(swigCPtr);
      return ret;
    } 
  }

  public double LMEUnexpiredPL {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_LMEUnexpiredPL_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_LMEUnexpiredPL_get(swigCPtr);
      return ret;
    } 
  }

  public double LMEUnaccountPL {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_LMEUnaccountPL_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_LMEUnaccountPL_get(swigCPtr);
      return ret;
    } 
  }

  public double MaintenanceMargin {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_MaintenanceMargin_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_MaintenanceMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double Premium {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_Premium_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_Premium_get(swigCPtr);
      return ret;
    } 
  }

  public double CreditAmount {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_CreditAmount_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_CreditAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double IntialFund {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_IntialFund_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_IntialFund_get(swigCPtr);
      return ret;
    } 
  }

  public string FundAccountNo {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_FundAccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_FundAccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeLimit {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_TradeLimit_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_TradeLimit_get(swigCPtr);
      return ret;
    } 
  }

  public double CanCashOutMoneyAmount {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_CanCashOutMoneyAmount_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_CanCashOutMoneyAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double DepositInterest {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_DepositInterest_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_DepositInterest_get(swigCPtr);
      return ret;
    } 
  }

  public double LoanInterest {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_LoanInterest_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_LoanInterest_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorDescription {
    set {
      DaApiWrapperPINVOKE.CFutureRspCapitalField_ErrorDescription_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspCapitalField_ErrorDescription_get(swigCPtr);
      return ret;
    } 
  }

  public CFutureRspCapitalField() : this(DaApiWrapperPINVOKE.new_CFutureRspCapitalField(), true) {
  }

}

}
