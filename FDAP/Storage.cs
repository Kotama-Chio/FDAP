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
            private string mycallPath = "./mycalls/";
            private string relaycallPath = "./relaycalls/";
        private string filePath = "./files/";
            private string myfilePath = "./myfiles/";
            private string relayfilePath = "./relayfiles/";

        public Storage()
        {
            Directory.CreateDirectory(basePath);
        }
    }
}
