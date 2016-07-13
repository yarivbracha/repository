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
            Console.WriteLine("All reviewed types are approved --> {0}", isApprovedCode);
        }
    }
}
