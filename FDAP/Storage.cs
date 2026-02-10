using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDAP
{
    public class Storage
    {
        public string basePath = "./fdap-storage/";
        private string callPath = "./calls/";
        private string filePath = "./files/";

        public Storage()
        {
            Directory.CreateDirectory(basePath);
        }
    }
}
