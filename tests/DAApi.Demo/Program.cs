// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Tasks;
using DAApi.Net;

Console.WriteLine($"ApiVersion:{CMarketApi.GetVersion()}");

int ret = 0;
var api = CMarketApi.CreateMarketApi(false);

var spi = new SpiImpl(api);
api.RegisterSpi(spi);

api.RegisterNameServer("tcp://127.0.0.1:1234");
api.Init();

await Task.Delay(100000);

public class SpiImpl : IMarketEvent
{
    public SpiImpl(CMarketApi api)
    {
        Api = api;
    }

    public CMarketApi Api { get; }

    public override void OnFrontConnected()
    {
        Console.WriteLine("OnFrontConnected");

        var ret = Api.ReqUserLogin(
            new CMarketReqUserLoginField
            {
                UserId = "UserId",
                UserPwd = "Password",
                SoftwareName = "SoftwareName",
                SoftwareVersion = "SoftwareVersion",
                AuthorCode = "AuthCode",
                BrokerIDForMarketPrice = "BrokerIdForMarketPrice",
            },
            0
        );
        Console.WriteLine($"ReqUserLogin ret:{ret}");
    }

    public override void OnRspUserLogin(CMarketRspInfoField pRspInfo, int iRequestID, bool bIsLast)
    {
        Console.WriteLine($"OnRspUserLogin pRspInfo:{pRspInfo} iRequestID:{iRequestID} bIsLast:{bIsLast}");
    }

    public override void OnFrontDisconnected(int iReason)
    {
        Console.WriteLine($"OnFrontDisconnected iReason:{iReason}");
    }

    public override void OnRspMarketData(
        CMarketRspMarketDataField pRspMarketData,
        CMarketRspInfoField pRspInfo,
        int iRequestID,
        bool bIsLast
    )
    {
        Console.WriteLine($"OnRspMarketData pRspMarketData:{pRspMarketData} pRspInfo:{pRspInfo} iRequestID:{iRequestID} bIsLast:{bIsLast}");
    }
}
