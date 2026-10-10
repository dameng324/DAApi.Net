# DAApi.Net

[![NuGet](https://img.shields.io/nuget/v/DAApi.Net.svg)](https://www.nuget.org/packages/DAApi.Net)
[![CI](https://github.com/dameng324/DAApi.Net/actions/workflows/ci.yml/badge.svg)](https://github.com/dameng324/DAApi.Net/actions/workflows/ci.yml)
[![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

直达期货 API 的 .NET 封装，包含期货、行情和股票接口。项目通过 SWIG 生成 C# 绑定，并处理 GB2312 字符串编码。

## 支持范围

| 项目 | 支持范围 |
|---|---|
| .NET 目标框架 | .NET 8、.NET 10、.NET Framework 4.5、.NET Standard 2.0 |
| 原生运行时 | Windows x64（win-x64）、Linux x64（linux-x64） |
| API | 期货、行情、股票 |

.NET 8 和 .NET 10 目标设置了 IsAotCompatible=true。发布应用时，RID 仍须与上表中的原生运行时匹配。

## 安装

~~~bash
dotnet add package DAApi.Net
~~~

## 快速开始

下面展示行情 API 的创建和版本查询。接收回调和登录请求时，请按接口要求实现 IMarketEvent。

~~~csharp
using System;
using DAApi.Net;

Console.WriteLine(CMarketApi.GetVersion());
var marketApi = CMarketApi.CreateMarketApi(false);
~~~

CFutureApi 和 CStockApi 分别提供期货和股票接口。

## API 版本

仓库中记录的 DAApi 版本为 1.18.2.0。运行时可通过对应 API 的 GetVersion() 查询版本。

## 原生依赖

NuGet 包包含以下平台目录中的原生库：

- Windows x64：runtimes/win-x64/native
- Linux x64：runtimes/linux-x64/native

发布应用时，将 RuntimeIdentifier 设置为 win-x64 或 linux-x64，以选择目标平台对应的原生依赖。

## 构建

### 环境与本地构建

- 使用 global.json 指定的 .NET SDK，并在仓库根目录执行 dotnet tool restore。
- 使用 .swig-version 指定的 SWIG 版本。
- 原生构建需要 CMake 和对应平台的 C++ 工具链。Windows 使用 Git Bash 和 Visual Studio C++ 工具；Linux 构建可在 Linux 或 WSL2 中运行。

SWIG 生成的 C# 和 C++ 文件不提交到 Git。每次本地构建前，进入 SWIG 项目重新生成：

~~~bash
cd src/DAApiWrapper
bash ./SwigGenerate.sh
~~~

在 Git Bash 中构建 Windows 原生库：

~~~bash
bash ./win-build.sh
~~~

在 Linux 或 WSL2 中构建 Linux 原生库：

~~~bash
bash ./linux-build.sh
~~~

回到仓库根目录构建解决方案并检查格式：

~~~bash
cd ../..
dotnet build DAApi.Net.slnx --configuration Release
dotnet tool run csharpier check .
~~~

### GitHub Actions

向 main 提交 PR 或推送提交时，ci.yml 调用共享的 build.yml：Ubuntu job 生成 SWIG 绑定并构建 Linux 原生库，Windows job 构建 Windows 原生库、构建解决方案并打包 NuGet。CI 不会发布到 NuGet；生成的 nupkg 会作为保留 30 天的 workflow artifact。

publish.yml 复用同一构建流程。推送 v 前缀版本 tag 会发布 NuGet 包并创建 GitHub Release；也可以在 main 上手动运行该 workflow，并填写不带 v 前缀的版本号。

## 许可证

[MIT License](LICENSE)

问题与建议请提交到 [GitHub Issues](https://github.com/dameng324/DAApi.Net/issues)。
