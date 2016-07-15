using System;
using System.Reflection;


namespace AttribDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            AttribDemoHelper helper = new AttribDemoHelper();
            Console.WriteLine("Output for current assembly\n");
            bool isApprovedCode = helper.AnalyzeAssembly(Assembly.GetExecutingAssembly());
            Console.WriteLine("For this assembly - All reviewed types are approved --> {0}", isApprovedCode);

            //check other assembly (string)
            Console.WriteLine("\nOutput for string Assembly\n");
            isApprovedCode = helper.AnalyzeAssembly(Assembly.GetAssembly(typeof(string)));
            Console.WriteLine("For string addembly - All reviewed types are approved --> {0}", isApprovedCode);

            //There is no output for other assembly because there is no Code Review atrributes in this assembly
        }
    }
}
