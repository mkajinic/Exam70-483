using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Net;

namespace Exam70_483
{
    class _4_1_TestFileIO
    {
        public static void RunTestIO() { 
        DirectoryInfo currDir = new DirectoryInfo(".");

        DirectoryInfo lenasDir = new DirectoryInfo(@"C:\Users\MKajinic");

            Console.WriteLine(lenasDir.FullName);
            Console.WriteLine(lenasDir.Name);
            Console.WriteLine(lenasDir.Parent);
            Console.WriteLine(lenasDir.Attributes);
            Console.WriteLine(lenasDir.CreationTime);

            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\MKajinic\source\repos\Exam70-483");

            //Read and write files
            string[] customers =
            {
                "Bob",
                "John",
                "Paddy"
            };

            //create string to a file
            string textFilePath = @"C:\Users\MKajinic\source\repos\Exam70-483\testfile1.txt";

            //write array to a file
            File.WriteAllLines(textFilePath, customers);

            //read strings from a file
            foreach (string cus in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Customer : {cus}" );
            }

            //get info about file
            DirectoryInfo myDataInfo = new DirectoryInfo(@"C:\Users\MKajinic\source\repos\Exam70-483");

            FileInfo[] txtFiles = myDataInfo.GetFiles("*.txt", SearchOption.AllDirectories);

            //output number of matches
            Console.WriteLine("Found: {0} ", txtFiles.Length);


            foreach (FileInfo file in txtFiles)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }

            #region FileStream
            //FileStream is used when you want to read and write a byte or array of bytes

            //create a path to text file
            string txtFilePath2 = @"C:\Users\MKajinic\source\repos\Exam70-483\testfile2.txt";

            //open or create a file 
            FileStream fs = File.Open(txtFilePath2, FileMode.Create);

            string randString = "Some random string";

            //to store the string we need to convert into byte array
            byte[] rsByteArray = Encoding.Default.GetBytes(randString);

            //write to the file (find the byte array and the index to start writing from
            fs.Write(rsByteArray, 0, rsByteArray.Length);

            //read data from it (change the fileStream position back to the begining of the filestream
            fs.Position = 0;

            // create bytearray to hold that filedata
            byte[] fileByteArray = new byte[rsByteArray.Length];

            //put the bytes inside the array so we can manupulate it
            for (int i = 0; i < rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }
            Console.WriteLine(Encoding.Default.GetString(fileByteArray));
            fs.Close();

            #endregion

            #region StreamWriter and StreamReader
            //used for writing and reading strings

            string textFilePath3 = @"C:\Users\MKajinic\source\repos\Exam70-483\testfile3.txt";

            //create a text file
            StreamWriter sw = File.CreateText(textFilePath3);

            //write to a file
            sw.Write("This is a random "); //without a new line
            sw.WriteLine("sentance for Stream writer/reader");
            sw.WriteLine("Another sentance");
            sw.Close();


            //open file for reading 
            StreamReader sr = File.OpenText(textFilePath3);

            Console.WriteLine("Peek: {0} ", Convert.ToChar(sr.Peek()));

            Console.WriteLine("1st string: {0} ", sr.ReadLine());

            Console.WriteLine("Everything: {0} ", sr.ReadToEnd());
            sr.Close();
            #endregion

            #region BinaryReaders and Binary Writers
            //used to read and write data types

            string textFilePath4 = @"C:\Users\MKajinic\source\repos\Exam70-483\testfile4.dat";

            //get the file
            FileInfo datFile = new FileInfo(textFilePath4);

            //open
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            //store something there
            string randText = "This is some text for binary reader and writer";
            int myAge = 29;
            double myHeight = 5.5;

            //write that info
            bw.Write(randText);
            bw.Write(myAge);
            bw.Write(myHeight);

            bw.Close();

            //open file for reading
            BinaryReader br = new BinaryReader(datFile.OpenRead());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());

            br.Close();




            #endregion


            #region WebRequest
            Console.WriteLine("****Web request***");

            WebRequest webRequest = WebRequest.Create("https://www.microsoft.com");
            WebResponse webResponse = webRequest.GetResponse();

            using (StreamReader responseReader = new StreamReader(webResponse.GetResponseStream())) 
            {
                string siteText = responseReader.ReadToEnd();
                Console.WriteLine(siteText);
            }




            #endregion
            Console.ReadLine();


        }
    }
}
