# DAApi.Net

[![NuGet](https://img.shields.io/nuget/v/DAApi.Net.svg)](https://www.nuget.org/packages/DAApi.Net)

DAApi.Net is a .NET library for the DAApi Futures API which is popular worldwide future market trade api in China. 
This project is a wrapper of the DAApi C++ API using swig.

Please read FAQ before using this library.[FAQ](#faq)

## Features

- Support DAApi Trade API
- Support .NET Framework 4.5, .NET Standard 2.0, .NET 8, and .NET 10
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

## Build

### Requirements

Use the .NET SDK pinned in `global.json` and restore the repository tools:

```bash
dotnet tool restore
```

SWIG must match the version in `.swig-version` (currently 4.5.1). CI runs SWIG generation on Ubuntu 24.04 and builds the Windows wrapper and NuGet package on windows-latest. Windows native builds use CMake 4.3 or later with Visual Studio 2026.

### Build the solution

```bash
dotnet build DAApi.Net.slnx --configuration Release
```

### Regenerate SWIG bindings

From Ubuntu 24.04 in WSL2, run:

```bash
cd src/DAApiWrapper
dotnet tool restore
bash ./SwigGenerate.sh
```

This regenerates the C++ and C# wrappers, applies the shared C# post-processing, and formats the generated C# files.

### Build native wrappers

Build the Windows wrapper from Git Bash and the Linux wrapper from WSL2. Run these commands from `src/DAApiWrapper`:

```bash
bash ./win-build.sh
bash ./linux-build.sh
```


### GitHub Actions

Pull requests and pushes to `main` run `.github/workflows/ci.yml`. It calls `.github/workflows/build.yml` to generate SWIG bindings on Linux, build the Windows wrapper, and pack the NuGet package; the `.nupkg` is uploaded as a 30-day workflow artifact. All workflow run steps use Bash, including Git Bash on Windows. `.github/workflows/publish.yml` calls the same build workflow, then publishes to NuGet for a `vX.Y.Z` tag or a manual run from `main` with a supplied version; tag publishing also creates a GitHub Release.

## FAQ

### The version of the DAApi API?

ApiVersion:1.18.2.0

### dll doesn't copy to the output directory?

set `RuntimeIdentifier` to `win-x64` in the project file.

## License

MIT License