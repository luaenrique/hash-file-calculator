using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace HashCalculator
{
    class HashFile
    {
        private SHA256 sha256;


        public byte[] HashYourFileWithSha256(string file)
        {
            sha256 = SHA256.Create();
            using (FileStream stream = File.OpenRead(file)) { 
                return sha256.ComputeHash(stream);
            }
        }


        public static string ConvertSha256BytesToString(byte[] hashedFile)
        {
            string result = "";

            foreach (byte b in hashedFile)
            {
                result += b.ToString("x2");
            }

            return result;
        }



    }
}
