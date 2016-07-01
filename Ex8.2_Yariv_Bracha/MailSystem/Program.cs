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

            mailManager.SimulateMailArrived("first mail title", "first mail body");

            //checking if the mail title and  mail body is empty
            mailManager.SimulateMailArrived("", "");

            //checking if the mail title and mail body is null
            mailManager.SimulateMailArrived(null, null);

            Timer timer = new Timer((obj) =>
            {
                mailManager.SimulateMailArrived("simulate mail title", "simulate mail body");
            }, null, 0, 1000);

            Console.ReadLine();
        }

        private void PrintMailDetails(object obj, MailArrivedEventArgs eventArgs)
        {
            Console.WriteLine("Title mail: {0}\nBody mail: {1}\n", eventArgs.Title, eventArgs.Body);
        }

    }
}

