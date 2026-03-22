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

        public void Store(byte[] hash, byte[] content)
        {
            string hashHex = Crypto.ToHex(hash);
            string filePath = Path.Combine(basePath, hashHex);

            File.WriteAllBytes(filePath, content);

            Logs.Add($"File {filePath} was successfully stored.");
        }

        public byte[] Get(byte[] hash)
        {
            string hashHex = Crypto.ToHex(hash);
            string filePath = Path.Combine(basePath, hashHex);

            if (File.Exists(filePath))
            {
                Console.WriteLine($"File {hashHex} was successfully founded");
                return File.ReadAllBytes(filePath);
            }

            Console.WriteLine($"File {hashHex} not found.");
            return null;
        }
        public bool Has(byte[] hash)
        {
            string hashHex = Crypto.ToHex(hash);
            string filePath = Path.Combine(basePath, hashHex);
            return File.Exists(filePath);
        }
        public List<string> ListAll()
        {
            var files = Directory.GetFiles(basePath);
            return files.Select(Path.GetFileName).ToList();
        }
    }
}
