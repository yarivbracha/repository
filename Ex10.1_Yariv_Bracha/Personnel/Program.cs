using System;

namespace Personnel
{
    class Program
    {
        public static void Main(string[] args)
        {
            if ((!String.IsNullOrEmpty(args[0])) && (args.Length != 0))
            {
                FileReaderHelper helper = new FileReaderHelper();
                helper.ReadFileLines(args[0]);
            }
            else
            {
                Console.WriteLine("Error! wrong parameters from the command line!");
            }
        }
            
    }
}
