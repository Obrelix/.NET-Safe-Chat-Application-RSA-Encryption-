using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public static class RSATools
    {
        public static void GenerateKeys(out string publicKey, out string privateKey)
        {
            publicKey = string.Empty;
            privateKey = string.Empty;
            try
            {
                //Create a new instance of RSACryptoServiceProvider to generate
                //public and private key data.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048))
                {
                    try
                    {
                        privateKey = RSA.ToXmlString(true);
                        publicKey = RSA.ToXmlString(false);
                        Debug.WriteLine("Public Key: " + publicKey);
                        Debug.WriteLine("Private Key: " + privateKey);

                    }
                    finally
                    {
                        RSA.PersistKeyInCsp = false;
                    }

                }
            }
            catch (ArgumentNullException)
            {
                Debug.WriteLine("Encryption failed.");
            }
        }

        public static  byte[] RSAEncrypt(byte[] DataToEncrypt, string RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048))
                {
                    try
                    {
                        //Import the RSA Key information. This only needs
                        //toinclude the public key information.
                        RSA.FromXmlString(RSAKeyInfo);

                        //Encrypt the passed byte array and specify OAEP padding.  
                        //OAEP padding is only available on Microsoft Windows XP or
                        //later.  
                        encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                    }
                    finally
                    {
                        RSA.PersistKeyInCsp = false;
                    }

                }
                return encryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Debug.WriteLine(e.Message);

                return null;
            }

        }

        public static byte[] RSADecrypt(byte[] DataToDecrypt, string RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData = new byte[128];
                //MessageBox.Show("Data lenght" + DataToDecrypt.Length.ToString());
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048))
                {
                    try
                    {
                        //Import the RSA Key information. This needs
                        //to include the private key information.
                        RSA.FromXmlString(RSAKeyInfo);

                        //Decrypt the passed byte array and specify OAEP padding.  
                        //OAEP padding is only available on Microsoft Windows XP or
                        //later.  
                        decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                        ///The method RSA.Decrypt(byte[] array, bool FOAEEP) want array with max lenght 128 bytes
                        ///this is a problem for very large messages...
                    }
                    finally
                    {
                        RSA.PersistKeyInCsp = false;
                    }
                }
                return decryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Debug.WriteLine(e.ToString());
                MessageBox.Show(e.ToString());
                return null;
            }

        }
    }
}
