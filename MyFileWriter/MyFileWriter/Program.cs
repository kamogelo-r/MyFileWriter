using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"test.txt";
            string[] arrOfLines;

            #region ex6
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                    Console.WriteLine("File deleted.");
                }
                else
                {
                    Console.WriteLine("Number of lines?");
                    int numberofLines = int.Parse(Console.ReadLine());
                    arrOfLines = new string[numberofLines];
                    Console.WriteLine("Input {0} strings below :\n", numberofLines);
                    for (int i = 0; i < numberofLines; i++)
                    {
                        Console.Write("Line number: {0}", i+1);
                        arrOfLines[i] = Console.ReadLine();
                    }

                    File.WriteAllLines(fileName, arrOfLines);

                    using (StreamReader reader = File.OpenText(fileName))
                    {
                        string text = "";

                        Console.WriteLine("Contents of the file:");
                        while ((text = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(" {0} ", text);
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {

                throw;
            }
            #endregion

            #region ex1
            //try
            //{  
            //    Console.WriteLine("...");

            //    if (File.Exists(fileName))
            //    {
            //        File.Delete(fileName);
            //        Console.WriteLine("File Successfully deleted.");
            //    }
            //    else
            //    {
            //        //Console.WriteLine("File does not exist.");
            //        //Console.WriteLine("Creating file:");
            //        //using (FileStream fileStream = File.Create(fileName))
            //        //{
            //        //    Console.WriteLine("File Created. Name: test.txt");
            //        //}

            //        Console.WriteLine("Writing to file  ");
            //        using (StreamWriter writer = File.CreateText(fileName))
            //        {
            //            writer.Write("Test File \n");
            //            writer.Write("Hello World");
            //            for (int i = 0; i < myText.Length; i++)
            //            {
            //                writer.Write(myText[i]);
            //            }
            //        }
            //    }

            //}
            //catch (FileNotFoundException e)
            //{
            //    Console.WriteLine("Error creating the file:" + e); ;
            //}
            #endregion

            Console.Read();
        }
    }
}
