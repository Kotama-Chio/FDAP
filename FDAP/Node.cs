using System.Net;
using System.Net.Sockets;

namespace FDAP
{
    public class Node
    {
        public void Start(List<IPAddress> neighbors, TcpListener listener, TcpClient sender)
        {
            listener.Start();
        }

        public void Logic(List<IPAddress> neighbors, TcpListener listener, TcpClient sender)
        {
            _ = Task.Run(() => CallNetwork.Listen(listener));
        }
    }
}
