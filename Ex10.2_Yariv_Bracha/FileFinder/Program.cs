using System;
using System.Collections.Generic;

namespace FileFinder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, long> filesInfoDictionary = new Dictionary<string, long>();
            FileFinderHelper fileFinderHelper = new FileFinderHelper();
            if (!(String.IsNullOrEmpty(args[0])) && (!String.IsNullOrEmpty(args[1])) || (args.Length != 2))
            {
                filesInfoDictionary = fileFinderHelper.FindWordInFiles(args[0], args[1]);
                if (filesInfoDictionary.Count != 0)
                {
                    foreach (var info in filesInfoDictionary)
                    {
                        Console.WriteLine("The word [{0}] found in {1} and the file length is {2}", args[1], info.Key, info.Value);
                    }
                }
                else
                {
                    Console.WriteLine("There is no file names with the word {{0}}}", args[1]);
                }
            }
            else
            {
                Console.WriteLine("There is a null or empty parameter that passed from the command line");
            }
        }
    }
}
