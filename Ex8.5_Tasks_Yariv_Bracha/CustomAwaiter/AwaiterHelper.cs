using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CustomAwaiter
{
    class AwaiterHelper
    {
        public async Task RunByMillis(int millis)
        {
            if (millis > 0)
            {
                Console.WriteLine($"Await {millis} millisecondes - int ");
                await millis;
            }
            else
            {
                Console.WriteLine("Illegal millisecondes value!");
            }
        }

        public async Task RunBysecondes(int secondes)
        {
            if (secondes > 0)
            {
                Console.WriteLine($"Await {secondes} seconds - TimeSpan");
                await TimeSpan.FromSeconds(secondes);
            }
            else
            {
                Console.WriteLine("Illegal secondes value!");
            }
        }

        public async Task RunProcess(string processName)
        {
            if (!String.IsNullOrEmpty(processName))
            {
                try
                {
                    Console.WriteLine($"Process {processName} - start...");
                    await Process.Start(processName);
                    Console.WriteLine($"Process {processName} exited.");
                }
                catch (Win32Exception)
                {
                    Console.WriteLine($"The process name {processName} is not exist!!");
                }
            }
            else
            {
                Console.WriteLine("The process name is empty!");
            }
        }
    }
}
