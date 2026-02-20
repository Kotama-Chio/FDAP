using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FDAP
{
    public class Network
    {
        public static async Task BroadcastCall(List<IPAddress> neightbors, string callfilepath, Logs logs)
        {
            foreach (IPAddress address in neightbors)
            {
                var client = new TcpClient();
                client.Connect(address, 6866);
                await SendCall(client, callfilepath);
                client.Close();
            }
        }

        private static async Task SendCall(TcpClient tcpClient, string callfilepath)
        {
            Stream stream = tcpClient.GetStream();
            byte[] data = File.ReadAllBytes(callfilepath);
            await stream.WriteAsync(data, 0, data.Length);
        }
        public static async Task ReturnCall(string callfilepath)
        {

        }

        public static async Task Listen(TcpListener listener, Logs logs)
        {
            var client = await listener.AcceptTcpClientAsync();
            _ = Task.Run(() => HandleClient(client, logs));
        }


        private static async Task HandleClient(TcpClient tcpClient, Logs logs)
        {
            var stream = tcpClient.GetStream();
            byte[] buffer = new byte[4096];

            int bytes = await stream.ReadAsync(buffer, 0, buffer.Length);
            logs.Log.Add(DateTime.Now, $"Received {bytes}");

            await stream.WriteAsync(buffer, 0, bytes);
            tcpClient.Close();
        }
    }
}
