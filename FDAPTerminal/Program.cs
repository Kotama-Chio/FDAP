using FDAP;
using FDAPTerminal;
using System.Net;
using System.Net.Sockets;

Node node = new Node();
List<IPAddress> Address = new List<IPAddress>();
TcpListener tcpListener = new TcpListener(6866);
TcpClient tcpClient = new TcpClient();
Logs logs = new Logs();

node.Start(Address, tcpListener, tcpClient);

while (true)
{
    node.Logic(Address, tcpListener, tcpClient, logs);
    LogPrint.PrintLogs(logs);
}