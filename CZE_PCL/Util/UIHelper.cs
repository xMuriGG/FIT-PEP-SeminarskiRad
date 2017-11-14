using PCLCrypto;
using System;
using System.Security.Cryptography;
using System.Text;
namespace CZE_PCL.Util
{
    public class UIHelper
    {
        public static string GenerateSalt(int length=16)
        {
            byte[] arr = new byte[length];
            RNGCryptoServiceProvider cripto = new RNGCryptoServiceProvider();
            cripto.GetBytes(arr);
            return Convert.ToBase64String(arr);
        }
        public static string GenerateHash(string lozinka, string salt)
        {
            byte[] pass = Encoding.Unicode.GetBytes(lozinka);
            byte[] dodatak = Convert.FromBase64String(salt);
            byte[] forHash = new byte[pass.Length + dodatak.Length];

            System.Buffer.BlockCopy(pass, 0, forHash,0, pass.Length);
            System.Buffer.BlockCopy(dodatak, 0, forHash, pass.Length, dodatak.Length);

            var hAlg = WinRTCrypto.HashAlgorithmProvider.OpenAlgorithm(HashAlgorithm.Sha1);//HashAlgorithm.Create("SHA1");
            byte[] hashed= hAlg.HashData(forHash);
            return Convert.ToBase64String(hashed);

        }
    }
}