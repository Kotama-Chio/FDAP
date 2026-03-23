using FDAP;
using FDAPTerminal;
using System.Net;
using System.Net.Sockets;

Node node = new Node();
TcpListener tcpListener = new TcpListener(6866);
TcpClient tcpClient = new TcpClient();

node.Start(tcpListener, tcpClient);

while (true)
{
    node.Logic(tcpListener, tcpClient);
    LogPrint.PrintLogs();
}
