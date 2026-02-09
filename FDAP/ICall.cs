using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FDAP
{
    public interface ICall
    {
        IPAddress LastRelay { get; }
        byte[] HashRequest { get; }
    }
}
