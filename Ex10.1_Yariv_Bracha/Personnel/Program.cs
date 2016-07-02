using System;

namespace Personnel
{
    class Program
    {
        public static void Main(string[] args)
        {
            if ((!String.IsNullOrEmpty(args[0])) && (args.Length != 0))
            {
                FileReaderHelper helper = new FileReaderHelper(args[0]);
                helper.ReadFileLines();
            }
            else
            {
                Console.WriteLine("Error! wrong parameters from the command line!");
            }
        }
            
    }
}
