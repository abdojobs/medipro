using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;
using System.Security.Cryptography;

namespace exaCore
{
    public static class Crypto
    {
        public static string Encrypt(string clearText)
        {
            string EncryptionKey = "EXAMYANMAR-4145"; //"MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "EXAMYANMAR-4145"; // "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        //private static DESCryptoServiceProvider DESProvider = new DESCryptoServiceProvider();
        //private static MD5CryptoServiceProvider MD5Provider = new MD5CryptoServiceProvider();

        //public static byte[] MD5hash(string data)
        //{
        //    //This is one implementation of the abstract class MD5.
        //    //MD5 md5 = new MD5CryptoServiceProvider();

        //    byte[] result = ASCIIEncoding.ASCII.GetBytes(data);

        //    return result;
        //}

        //public static string Encrypt(string strToEncrypt)
        //{
        //    try
        //    {
        //        //DESProvider.Key = MD5Provider.ComputeHash(ASCIIEncoding.ASCII.GetBytes("MediProEXA4145"));
        //        DESProvider.Key = MD5hash("exaMyanm");
        //        DESProvider.Mode = CipherMode.ECB;
        //        byte[] Buffer = ASCIIEncoding.ASCII.GetBytes(strToEncrypt);
        //        return Convert.ToBase64String(DESProvider.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length));
        //    }
        //    catch (Exception exp)
        //    {
        //        throw exp;
        //    }
        //}

        //public static string Decrypt(string encryptedString)
        //{
        //    try
        //    {
        //        DESProvider.Key = MD5hash("exaMyanm");
        //        DESProvider.Mode = CipherMode.ECB;
        //        //byte[] Buffer = Convert.FromBase64String(encryptedString);
        //        byte[] Buffer = new byte[8];
        //        Buffer = Convert.FromBase64String(encryptedString);
        //        return ASCIIEncoding.ASCII.GetString(DESProvider.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length));
        //    }
        //    catch (Exception exp)
        //    {
        //        throw exp;
        //    }
        //}
    }
}
