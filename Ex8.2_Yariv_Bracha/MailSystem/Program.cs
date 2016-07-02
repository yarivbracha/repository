using System;
using System.Threading;


namespace MailSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            MailManager mailManager = new MailManager();
            mailManager.MailArrived += program.PrintMailDetails;

            Timer timer = new Timer((obj) =>
            {
                mailManager.SimulateMailArrived();
            }, null, 0, 1000);

            Console.ReadLine();
        }

        private void PrintMailDetails(object obj, MailArrivedEventArgs eventArgs)
        {
            Console.WriteLine("Title mail: {0}\nBody mail: {1}\n", eventArgs.Title, eventArgs.Body);
        }

    }
}

