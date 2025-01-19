/* File : swig.i */
%module(directors="1") DaApiWrapper
%{ 
    #include "include/DADataType.h"
    #include "include/DAMarketStruct.h"
    #include "include/DAMarketApi.h"
    #include "include/DAFutureStruct.h"
    #include "include/DAFutureApi.h"
    #include "include/DAStockStruct.h"
    #include "include/DAStockApi.h"
%}
/* turn on director wrapping Callback */
%feature("director") IMarketEvent;
%feature("director") IFutureEvent;
%feature("director") IStockEvent;
%include "include/DADataType.h"
%include "include/DAMarketStruct.h"
%include "include/DAMarketApi.h"
%include "include/DAFutureStruct.h"
%include "include/DAFutureApi.h"
%include "include/DAStockStruct.h"
%include "include/DAStockApi.h"