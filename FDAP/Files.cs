using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FDAP
{
    public class Files_Sender
    {
        private string FilePath { get; set; }
        private byte[] FileData { get; set; }
        public Files_Sender(string filePath) 
        { 
            FilePath = filePath;
            OpenFile();
        }

        private void OpenFile()
        {
            FileData = File.ReadAllBytes(FilePath);
        }

        public List<Packet> CreatePacket()
        {
            List<Packet> packets = new List<Packet>();
            foreach (var packet in FileData)
            {
                //Faire un systeme pour savoir quel packet est quel packet
                //packets.Add(new Packet(, FileData));
            }
            return packets;
        }
    }
    public class Files_Recreator
    {
        private string FilePath { get; set; }
    }
}
