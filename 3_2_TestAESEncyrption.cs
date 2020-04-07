﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Exam70_483
{
    class _3_2_TestAESEncyrption
    {

        static void DumpBytes(string title, byte[] bytes)
        {
            Console.Write(title);
            foreach (byte b in bytes)
            {
                Console.Write("{0:X} ", b);
            }
            Console.WriteLine();
        }


        public static void RunEncriptionAndDecription()
        {
            string plainText = "This is my super secret data";

            // byte array to hold the encrypted message
            byte[] cypherText;

            // byte array to hold the key that was used for encryption
            byte[] key;

            // byte array to hold the initialization vector that was used for encryption
            byte[] initializationVector;

            // Create an Aes instance
            // This creates a random key and initialization vector

            using (Aes aes = Aes.Create())
            {
                // copy the key and the initialization vector
                key = aes.Key;
                initializationVector = aes.IV;

                // create an encryptor to encrypt some data
                ICryptoTransform encryptor = aes.CreateEncryptor();

                // Create a new memory stream to receive the 
                // encrypted data. 

                using (MemoryStream encryptMemoryStream = new MemoryStream())
                {
                    // create a CryptoStream, tell it the stream to write to
                    // and the encryptor to use. Also set the mode
                    using (CryptoStream encryptCryptoStream = new CryptoStream(encryptMemoryStream,
                        encryptor, CryptoStreamMode.Write))
                    {
                        // make a stream writer from the cryptostream
                        using (StreamWriter swEncrypt = new StreamWriter(encryptCryptoStream))
                        {
                            //Write the secret message to the stream.
                            swEncrypt.Write(plainText);
                        }
                        // get the encrypted message from the stream
                        cypherText = encryptMemoryStream.ToArray();
                    }
                }

            }



            // Dump out our data
            Console.WriteLine("String to encrypt: {0}", plainText);
            DumpBytes("Key: ", key);
            DumpBytes("Initialization Vector: ", initializationVector);
            DumpBytes("Encrypted: ", cypherText);

         //   Console.ReadKey();





            // Now do the decryption
            string decryptedText;

            using (Aes aes = Aes.Create())
            {
                // Configure the aes instances with the key and 
                // initialization vector to use for the decryption
                aes.Key = key;
                aes.IV = initializationVector;

                // Create a decryptor from aes
                ICryptoTransform decryptor = aes.CreateDecryptor();

                using (MemoryStream decryptStream = new MemoryStream(cypherText))
                {
                    using (CryptoStream decryptCryptoStream =
                        new CryptoStream(decryptStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(decryptCryptoStream))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            decryptedText = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            Console.WriteLine("Decrypted string: {0}", decryptedText);

            Console.ReadKey();




        }
    }
}
