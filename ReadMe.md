# DAApi.Net

[![NuGet](https://img.shields.io/nuget/v/DAApi.Net.svg)](https://www.nuget.org/packages/DAApi.Net)

DAApi.Net is a .NET library for the DAApi Futures API which is popular worldwide future market trade api in China. 
This project is a wrapper of the DAApi C++ API using swig.

Please read FAQ before using this library.[FAQ](#faq)

## Features

- Support DAApi Trade API
- Support .Net framework 4.5 and .Net Standard 2.0 and Modern .Net6 and .Net8
- Auto copy the native dlls to the output directory
- Native AOT support
- Solved the GB2312 encoding problem


## Installation

```bash
dotnet add package DAApi.Net
```

## Usage

```csharpusing System;
using System.Threading.Tasks;
using DAApi.Net;

Console.WriteLine($"ITapTradeAPIVersion:{CMarketApi.GetVersion()}");

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
```

## Build from source

### Prerequisites

- dotnet sdk 8.0 or later
- swig 4.3.0 or later, use `scoop install swig` to install swig on windows, do not use `winget`.
- cmake 3.31.3 or later.

### Build

1. Clone the repository and open the solution file `DAApi.Net.sln` with Visual Studio 2022.
2. run the command in `DAApiApi/SwigGenerator.sh` to generate the cpp and C# wrapper code.
3. run `win-build.sh` for windows native build or `linux-build.sh` for linux native build.
4. Build the `DAApi.Net` C# project.

## FAQ

### The version of the DAApi API?

ApiVersion:1.18.2.0

### dll doesn't copy to the output directory?

set `RuntimeIdentifier` to `win-x64` in the project file.

## License

MIT License