using System;
using System.IO;
using System.Linq;

namespace SALT
{
    class Program
    {
        public static string? source;

        static void Main(string[] arguments)
        {
            if (arguments != null)
            {
                if (arguments[0] != null)
                {
                    string filePath = arguments[0];

                    if (File.Exists(filePath))
                    {
                        // Read the source.
                        using (StreamReader streamReader = new StreamReader(filePath))
                        {
                            streamReader.BaseStream.Position = 0;

                            while(!streamReader.EndOfStream)
                            {
                                source += streamReader.ReadToEnd();
                                Console.WriteLine(source);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("File not found. Please provide a filepath.");
                    }
                }
                else
                {
                    Console.WriteLine("No filepath provided. Please specify one.");
                }
            }

            Console.ReadKey();
        }
    }
}