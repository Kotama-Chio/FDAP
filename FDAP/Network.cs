using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FDAP
{
    public class Network
    {

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
