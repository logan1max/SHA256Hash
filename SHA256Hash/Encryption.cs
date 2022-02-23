using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SHA256Hash.Models;
using System.Security.Cryptography;

namespace SHA256Hash
{
    internal class Encryption
    {
        private PartHash partHash;

        public void ReadFromFile()
        {
            string fileName = @"C:\Users\logan\1.zip";
            long blockSize = 1500;

            using (FileStream fs = File.Open(fileName, FileMode.Open))
            {                
                FileInfo fi = new FileInfo(fileName);                

                Console.WriteLine(fi.Length);

                byte[] data = new byte[blockSize];

                fs.Read(data, 0, data.Length);

                Encoding encoding = new ASCIIEncoding();

                Console.WriteLine(encoding.GetString(GetHashFromByteArray(data)));
                fs.Close();                
            }
        }

        private byte[] GetHashFromByteArray(byte[] bytes)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                byte[] result = mySHA256.ComputeHash(bytes);
                Encoding encoding = new ASCIIEncoding();

                Console.WriteLine(encoding.GetString(result));
                return result;
            }
        }
    }
}
