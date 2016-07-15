using System;
using System.Reflection;


namespace DynInvoke
{
    class Program
    {
        public static void Main(string[] args)
        {
            A classA = new A();
            B classB = new B();
            C classC = new C();

            Console.WriteLine("Output for A:");
            Console.WriteLine(InvokeHello(classA, "A"));
            Console.WriteLine("Output for B:");
            Console.WriteLine(InvokeHello(classB, "B"));
            Console.WriteLine("Output for C:");
            Console.WriteLine(InvokeHello(classC, "C"));
        }

        private static string InvokeHello(object inputClass, string inputString)
        {
            Type[] types = new Type[] { typeof(string) };
            object[] parameters = new object[] { inputString };

            MethodInfo methodInfo = inputClass.GetType().GetMethod("Hello", types);
            return (string)methodInfo.Invoke(inputClass, parameters);
        }
    }
}
