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

public class CFutureRspQuestionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CFutureRspQuestionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CFutureRspQuestionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CFutureRspQuestionField obj) {
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

  ~CFutureRspQuestionField() {
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
          DaApiWrapperPINVOKE.delete_CFutureRspQuestionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string QuestionType {
    set {
      DaApiWrapperPINVOKE.CFutureRspQuestionField_QuestionType_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspQuestionField_QuestionType_get(swigCPtr);
      return ret;
    } 
  }

  public string QuestionId {
    set {
      DaApiWrapperPINVOKE.CFutureRspQuestionField_QuestionId_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspQuestionField_QuestionId_get(swigCPtr);
      return ret;
    } 
  }

  public string QuestionCN {
    set {
      DaApiWrapperPINVOKE.CFutureRspQuestionField_QuestionCN_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspQuestionField_QuestionCN_get(swigCPtr);
      return ret;
    } 
  }

  public string QuestionEN {
    set {
      DaApiWrapperPINVOKE.CFutureRspQuestionField_QuestionEN_set(swigCPtr, value);
    } 
    get {
      string ret = DaApiWrapperPINVOKE.CFutureRspQuestionField_QuestionEN_get(swigCPtr);
      return ret;
    } 
  }

  public CFutureRspQuestionField() : this(DaApiWrapperPINVOKE.new_CFutureRspQuestionField(), true) {
  }

}

}
