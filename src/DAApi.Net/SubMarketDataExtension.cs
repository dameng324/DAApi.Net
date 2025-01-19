using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace DAApi.Net;

public static class SubMarketDataExtension
{
    static IEnumerable<string[]> Chunk(string[] source, int chunkSize)
    {
        if (source.Length <= chunkSize)
        {
            yield return source;
            yield break;
        }

        for (int i = 0; i < source.Length; i += chunkSize)
        {
            yield return source.Skip(i).Take(chunkSize).ToArray();
        }
    }

    public static bool SubMarketData(this CMarketApi api, string[] symbols)
    {
        int maxSubCount = DaApiWrapper.MAX_SUB_COUNT;
        foreach (var eachCodes in Chunk(symbols, maxSubCount))
        {
            var subCodeBytes = new byte[maxSubCount * 256];
            for (int i = 0; i < eachCodes.Length; i++)
            {
                var codeBytes = Encoding.ASCII.GetBytes(eachCodes[i]);
                var length = Math.Min(codeBytes.Length, 256);
                for (int j = 0; j < length; j++)
                {
                    subCodeBytes[i * 256 + j] = codeBytes[j];
                }
            }
            // 将二维数组转换为一维数组
            IntPtr ptr = Marshal.AllocHGlobal(maxSubCount * 256);
            Marshal.Copy(subCodeBytes, 0, ptr, subCodeBytes.Length);
            var req = new CMarketReqMarketDataField
            {
                MarketType = DaApiWrapper.DAF_TYPE_Future,
                SubscMode = DaApiWrapper.DAF_SUB_Append,
                MarketCount = eachCodes.Length,
                MarketTrcode = new SWIGTYPE_p_a_256__char(ptr, false),
            };

            var result = api.ReqMarketData(req, 0);
            if (result is false)
            {
                return false;
            }
            Marshal.FreeHGlobal(ptr);
            Thread.Sleep(200);
        }

        return true;
    }
}
