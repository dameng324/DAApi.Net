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

public class CFutureRtnCapitalField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CFutureRtnCapitalField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CFutureRtnCapitalField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CFutureRtnCapitalField obj) {
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

  ~CFutureRtnCapitalField() {
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
          DaApiWrapperPINVOKE.delete_CFutureRtnCapitalField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string ClientNo {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_ClientNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_ClientNo_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountNo {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyNo {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_CurrencyNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_CurrencyNo_get(swigCPtr);
      return ret;
    } 
  }

  public double Available {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_Available_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_Available_get(swigCPtr);
      return ret;
    } 
  }

  public double YAvailable {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_YAvailable_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_YAvailable_get(swigCPtr);
      return ret;
    } 
  }

  public double CanCashOut {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_CanCashOut_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_CanCashOut_get(swigCPtr);
      return ret;
    } 
  }

  public double Money {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_Money_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_Money_get(swigCPtr);
      return ret;
    } 
  }

  public double ExpiredProfit {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_ExpiredProfit_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_ExpiredProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenDeposit {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_FrozenDeposit_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_FrozenDeposit_get(swigCPtr);
      return ret;
    } 
  }

  public double Fee {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_Fee_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_Fee_get(swigCPtr);
      return ret;
    } 
  }

  public double Deposit {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_Deposit_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_Deposit_get(swigCPtr);
      return ret;
    } 
  }

  public double KeepDeposit {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_KeepDeposit_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_KeepDeposit_get(swigCPtr);
      return ret;
    } 
  }

  public int Status {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_Status_set(swigCPtr, value);
    } 
    get {
      int ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_Status_get(swigCPtr);
      return ret;
    } 
  }

  public double InMoney {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_InMoney_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_InMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double OutMoney {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_OutMoney_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_OutMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double UnexpiredProfit {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_UnexpiredProfit_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_UnexpiredProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double TodayTotal {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_TodayTotal_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_TodayTotal_get(swigCPtr);
      return ret;
    } 
  }

  public double UnaccountProfit {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_UnaccountProfit_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_UnaccountProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double Royalty {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_Royalty_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_Royalty_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public string TreatyCode {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_TreatyCode_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_TreatyCode_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public int OrderNumber {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_OrderNumber_set(swigCPtr, value);
    } 
    get {
      int ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_OrderNumber_get(swigCPtr);
      return ret;
    } 
  }

  public int FilledNumber {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_FilledNumber_set(swigCPtr, value);
    } 
    get {
      int ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_FilledNumber_get(swigCPtr);
      return ret;
    } 
  }

  public double FilledAdvPrice {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_FilledAdvPrice_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_FilledAdvPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int BuyHoldNumber {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_BuyHoldNumber_set(swigCPtr, value);
    } 
    get {
      int ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_BuyHoldNumber_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyHoldOpenPrice {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_BuyHoldOpenPrice_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_BuyHoldOpenPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyHoldPrice {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_BuyHoldPrice_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_BuyHoldPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int SaleHoldNumber {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_SaleHoldNumber_set(swigCPtr, value);
    } 
    get {
      int ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_SaleHoldNumber_get(swigCPtr);
      return ret;
    } 
  }

  public double SaleHoldOpenPrice {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_SaleHoldOpenPrice_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_SaleHoldOpenPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double SaleHoldPrice {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_SaleHoldPrice_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_SaleHoldPrice_get(swigCPtr);
      return ret;
    } 
  }

  public string IsCanceled {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_IsCanceled_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_IsCanceled_get(swigCPtr);
      return ret;
    } 
  }

  public double FilledTotalFee {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_FilledTotalFee_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_FilledTotalFee_get(swigCPtr);
      return ret;
    } 
  }

  public double Credit {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_Credit_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_Credit_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginLimit {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_MarginLimit_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_MarginLimit_get(swigCPtr);
      return ret;
    } 
  }

  public double BorrowValue {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_BorrowValue_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_BorrowValue_get(swigCPtr);
      return ret;
    } 
  }

  public double MortgageMoney {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_MortgageMoney_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_MortgageMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double T1 {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_T1_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_T1_get(swigCPtr);
      return ret;
    } 
  }

  public double T2 {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_T2_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_T2_get(swigCPtr);
      return ret;
    } 
  }

  public double T3 {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_T3_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_T3_get(swigCPtr);
      return ret;
    } 
  }

  public double TN {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_TN_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_TN_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeLimit {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_TradeLimit_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_TradeLimit_get(swigCPtr);
      return ret;
    } 
  }

  public double FCrossMax {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_FCrossMax_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_FCrossMax_get(swigCPtr);
      return ret;
    } 
  }

  public double SellFreezenMoney {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_SellFreezenMoney_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_SellFreezenMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double SellInterest {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_SellInterest_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_SellInterest_get(swigCPtr);
      return ret;
    } 
  }

  public double SellNeedAddMargin {
    set {
      DaApiWrapperPINVOKE.CFutureRtnCapitalField_SellNeedAddMargin_set(swigCPtr, value);
    } 
    get {
      double ret = DaApiWrapperPINVOKE.CFutureRtnCapitalField_SellNeedAddMargin_get(swigCPtr);
      return ret;
    } 
  }

  public CFutureRtnCapitalField() : this(DaApiWrapperPINVOKE.new_CFutureRtnCapitalField(), true) {
  }

}

}
