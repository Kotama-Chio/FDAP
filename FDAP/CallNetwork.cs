using System.Net;
using System.Net.Sockets;

namespace FDAP
{
    public class CallNetwork
    {
        public static async Task BroadcastCall(List<IPAddress> neightbors, string callfilepath)
        {
            foreach (IPAddress address in neightbors)
            {
                var client = new TcpClient();
                client.Connect(address, 6866);
                await SendCall(client, callfilepath);
                client.Close();
            }
            Logs.Add($"Sent {callfilepath} broadcast");
        }

        private static async Task SendCall(TcpClient tcpClient, string callfilepath)
        {
            Stream stream = tcpClient.GetStream();
            byte[] data = File.ReadAllBytes(callfilepath);
            await stream.WriteAsync(data, 0, data.Length);
            Logs.Add($"Sent {callfilepath} to  {tcpClient.Client.AddressFamily.ToString()}");
        }
        public static async Task ReturnCallAnswer(string callfilepath)
        {

        }

        public static async Task Listen(TcpListener listener)
        {
            var client = await listener.AcceptTcpClientAsync();
            _ = Task.Run(() => HandleClient(client));
        }

        private static async Task HandleClient(TcpClient tcpClient)
        {
            var stream = tcpClient.GetStream();
            byte[] buffer = new byte[4096];

            int bytes = await stream.ReadAsync(buffer, 0, buffer.Length);
            Logs.Add($"Received {bytes}");

            await stream.WriteAsync(buffer, 0, bytes);
            tcpClient.Close();
        }
    }
}
