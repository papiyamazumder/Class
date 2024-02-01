//using System;
//using System.IO;

//class FileHandling
//{
//    static void Main()
//    {
//        string filePath = "example.txt";

//        // Writing to a file
//        try
//        {
//            using (StreamWriter writer = new StreamWriter(filePath))
//            {
//                writer.WriteLine("Hello, this is a text file.");
//                writer.WriteLine("It contains multiple lines of text.");
//                writer.WriteLine("We will now read this text from the file.");
//            }
//            Console.WriteLine("Data written to the file successfully.");
//        }
//        catch (IOException e)
//        {
//            Console.WriteLine("An error occurred while writing to the file: " + e.Message);
//            return;
//        }

//        // Reading from a file
//        try
//        {
//            using (StreamReader reader = new StreamReader(filePath))
//            {
//                Console.WriteLine("Reading data from the file:");
//                string line;
//                while ((line = reader.ReadLine()) != null)
//                {
//                    Console.WriteLine(line);
//                }
//            }
//        }
//        catch (IOException e)
//        {
//            Console.WriteLine("An error occurred while reading the file: " + e.Message);
//        }
//    }
//}
