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
        public byte[] CallID {  get; set; }
    }

    public class CallAnswer
    {
        public string LastRelay { get; set; }
        public byte[] CallID { get; set; }
        public byte[] Answer { get; set; }
    }

    public class JsonCall
    {
        public static byte[] CreateCall(Call call)
        {
            string json = JsonSerializer.Serialize(call);
            return Encoding.UTF8.GetBytes(json);
        }

        public static Call LoadCall(byte[] data)
        {
            string json = Encoding.UTF8.GetString(data);
            return JsonSerializer.Deserialize<Call>(json);
        }
    }
}
