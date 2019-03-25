using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace HashCalculator
{
    class hashFile
    {
        private SHA256 sha256;


        private byte[] HashYourFileWithSha256(string file)
        {
            sha256 = SHA256.Create();
            using (FileStream stream = File.OpenRead(file)) { 
                return sha256.ComputeHash(stream);
            }
        }


    }
}
