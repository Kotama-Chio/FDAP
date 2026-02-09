using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FDAP
{
    public interface ICall
    {
        IPAddress LastRelay { get; }
        byte[] HashRequest { get; }
    }

    public class JsonCall
    {
        public static void CreateCall(ICall call)
        {
            JsonSerializer.Serialize(call);
        }
        public static ICall LoadCall(string fill)
        {
            return JsonSerializer.Deserialize<ICall>(fill);
        }
    }
}
