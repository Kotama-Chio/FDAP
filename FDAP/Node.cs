using System.Net;
using System.Net.Sockets;

namespace FDAP
{
    public class Node
    {
        public List<IPAddress> Neighbors = new List<IPAddress>();


        public void Start(TcpListener listener, TcpClient sender)
        {
            listener.Start();
        }

        public void Logic(TcpListener listener, TcpClient sender)
        {
            _ = Task.Run(() => CallNetwork.Listen(listener));
        }
    }
}
