using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FDAP
{
    public class Call
    {
        public string LastRelay {  get; set; }
        public byte[] HashRequest {  get; set; }
    }

    public class JsonCall
    {
        public static void CreateCall(Call call)
        {
            JsonSerializer.Serialize(call);
        }
        public static Call LoadCall(string fill)
        {
            return JsonSerializer.Deserialize<Call>(fill);
        }
    }
}
