using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDAP
{
    public class Logs
    {
        public Dictionary<DateTime, string> Log { get; set; }
        public Logs() 
        {
            Log = new Dictionary<DateTime, string>();
        }
    }
}
