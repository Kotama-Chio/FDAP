using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDAP
{
    public class Logs
    {
        public static Dictionary<DateTime, string> Log =  new Dictionary<DateTime, string>();

        public static void Add(string text)
        {
            Log.Add(DateTime.Now, text);
        }
        public static void Clear()
        {
            Log.Clear();
        }
    }
}
