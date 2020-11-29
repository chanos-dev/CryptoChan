using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoChan
{
    public class Encrypt
    {
        private string encKey = "chansos!@#$%^&*()_+";

        private Encrypt() { }        

        private static Encrypt _instance;
        
        public string ext { get; set; }
        public string encExt => ".chan";
        public byte[] encryptionFile { get; set; } 
        public bool isEncrypt { get; set; }

        public static Encrypt Instance
        {
            get
            {
                if(_instance is null)
                {
                    _instance = new Encrypt();
                }

                return _instance;
            }
        }

        //http://curlybrackets.com/posts/43017/how-to-encrypt-and-decrypt-a-string-in-c-sharp
        public string EncyptPass(string passWord)
        { 
            if (!string.IsNullOrEmpty(passWord))
            { 
                using (var md5 = new MD5CryptoServiceProvider())
                {
                    using (var tdes = new TripleDESCryptoServiceProvider())
                    {
                        tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(encKey));
                        tdes.Mode = CipherMode.ECB;
                        tdes.Padding = PaddingMode.PKCS7;

                        using (var transform = tdes.CreateEncryptor())
                        {
                            byte[] textBytes = UTF8Encoding.UTF8.GetBytes(passWord);
                            byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                            return Convert.ToBase64String(bytes, 0, bytes.Length);
                        }
                    }
                }
            }
            else
            {
                return null;
            } 
        }

        public string DecryptPass(string passWord)
        {
            if (!string.IsNullOrEmpty(passWord))
            {
                using (var md5 = new MD5CryptoServiceProvider())
                {
                    using (var tdes = new TripleDESCryptoServiceProvider())
                    {
                        tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(encKey));
                        tdes.Mode = CipherMode.ECB;
                        tdes.Padding = PaddingMode.PKCS7;

                        using (var transform = tdes.CreateDecryptor())
                        {
                            byte[] cipherBytes = Convert.FromBase64String(passWord);
                            byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                            return UTF8Encoding.UTF8.GetString(bytes);
                        }
                    }
                }
            }
            else
            {
                return null;
            }
        }

        //file 
        //https://msftstack.wordpress.com/2014/12/31/simple-aes-byte-encryption-and-decryption-routines-in-c/
        public byte[] EncryptFile(byte[] clearBytes, byte[] passBytes, byte[] saltBytes)
        {
            byte[] encryptedBytes = null;

            // create a key from the password and salt, use 32K iterations – see note
            var key = new Rfc2898DeriveBytes(passBytes, saltBytes, 32768);

            // create an AES object
            using (Aes aes = new AesManaged())
            {
                // set the key size to 256 
                aes.KeySize = 256;
                aes.Key = key.GetBytes(aes.KeySize / 8);
                aes.IV = key.GetBytes(aes.BlockSize / 8);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(),CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }
            return encryptedBytes;
        }

        public byte[] DecryptFile(byte[] cryptBytes, byte[] passBytes, byte[] saltBytes)
        {
            byte[] clearBytes = null;

            // create a key from the password and salt, use 32K iterations
            var key = new Rfc2898DeriveBytes(passBytes, saltBytes, 32768);

            using (Aes aes = new AesManaged())
            {
                // set the key size to 256
                aes.KeySize = 256;
                aes.Key = key.GetBytes(aes.KeySize / 8);
                aes.IV = key.GetBytes(aes.BlockSize / 8);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cryptBytes, 0, cryptBytes.Length);
                        cs.Close();
                    }
                    clearBytes = ms.ToArray();
                }
            }

            return clearBytes;
        }


        public bool FileEncryption(string filePath, string passWord)
        {
            string encPW = EncyptPass(passWord);
            byte[] keyBytes = Encoding.UTF8.GetBytes(encPW);
            byte[] saltBytes = SHA512.Create().ComputeHash(keyBytes);
            byte[] fileBytes = null; 

            try
            { 
                if (ext.Contains("chan")) //복호화
                {
                    isEncrypt = false;
                    byte[] exts = null;

                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    { 
                        fileBytes = new byte[fs.Length]; 

                        fs.Read(fileBytes, 0, Convert.ToInt32(fs.Length));  
                    } 

                    int indexDot = 0; 

                    for(int i=fileBytes.Length-1; i>=0; i--)
                    {
                        if (fileBytes[i] == 46)
                        {
                            indexDot = i;
                            break;
                        } 
                    }

                    exts = new byte[fileBytes.Length-indexDot];
                    Array.Copy(fileBytes, indexDot, exts, 0, fileBytes.Length - indexDot);
                    Array.Resize(ref fileBytes, indexDot);

                    try
                    {
                        encryptionFile = DecryptFile(fileBytes, keyBytes, saltBytes);
                    }
                    catch
                    {
                        throw new Exception(Properties.Resources.EncryptPass);
                    }
                    ext = Encoding.Default.GetString(exts); 
                }
                else //암호화
                {
                    isEncrypt = true;
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {                         
                        fileBytes = new byte[fs.Length];
                         
                        fs.Read(fileBytes, 0, Convert.ToInt32(fs.Length));
                    }
                     
                    encryptionFile = EncryptFile(fileBytes, keyBytes, saltBytes); 
                }
            }
            catch(Exception e)
            {
                throw e;
            }

            return true;
        }
    }
}
