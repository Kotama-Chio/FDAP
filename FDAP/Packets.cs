using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDAP
{
    public class Packet
    {
        byte Info { get; set;  }
        byte[] Data { get; set; }
        public Packet(byte info, byte[] data) 
        { 
            Info = info;
            Data = data;
        }
    }
}
