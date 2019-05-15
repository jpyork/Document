using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Document1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Document" + " ");
                Console.WriteLine("What is the name of the document?");
                String name = Console.ReadLine();
                String fileName = (name + ".txt");
                Console.WriteLine("What information would you like to put into the document?");
                String input = Console.ReadLine();
                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    writer.Write(input);
                }
                FileStream fs = new FileStream(input, FileMode.Append);
                System.IO.File.WriteAllText(fileName, input);
                string count = File.ReadAllText(fileName);
                Console.WriteLine(fileName + " was a successfully saved. The document contains " + count.Length + " characters.");
                System.Environment.Exit(1);
                /*FileStream F = new FileStream(name + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);*/
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("The file can not be opened or created.");
                System.Environment.Exit(1);
            }


        }
    }
}
