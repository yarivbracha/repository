using System;
using System.Diagnostics;
using System.Linq;

namespace Ex4._1_Yariv_Bracha
{
    class HelperLinqToObjects
    {
        public void DisplayInterMethodSumNonQuery()
        {
            var interfaces = typeof(string).Assembly.GetExportedTypes()
                             .Where(type => type.IsInterface)
                             .OrderBy(type => type.Name)
                             .Select(type => new
                             {
                                 name = type.Name,
                                 methodSum = type.GetMethods().Length
                             });

            foreach (var inter in interfaces)
            {
                Console.WriteLine(inter);
            }
        }

        public void DisplayProcessesNonQuery()
        {
            var processes = Process.GetProcesses()
                .Where(process => (process.Threads.Count < 5) && (isLegalAccess(process)))
                .OrderBy(process => process.Id)
                .Select(process => new
                {
                    name = process.ProcessName,
                    ID = process.Id,
                    start = process.StartTime
                });

            foreach (var process in processes)
            {
                Console.WriteLine(process);
            }
        }

        public void DisplayProcessesByBasePriorityQuery()
        {
            var processes = from process in Process.GetProcesses()
                             where ((process.Threads.Count < 5) && (isLegalAccess(process)))
                             orderby process.Id
                             group new
                             {
                                 Name = process.ProcessName,
                                 ID = process.Id,
                                 Threads = process.Threads.Count
                             } 
                             by process.BasePriority
                                  into groupProcess
                             orderby groupProcess.Key
                             select groupProcess;

            foreach (var group in processes)
            {
                foreach (var process in group)
                {
                    Console.WriteLine(process);
                }
            }
        }
        
        private bool isLegalAccess(Process process)
        {
            try
            {
                return process.Handle != IntPtr.Zero;
            }
            catch
            {
                return false;
            }
        }

        public void DisplayProcessesSum()
        {
            Console.WriteLine($"Threads sum -> {Process.GetProcesses().Sum(process => process.Threads.Count)}");
        }
    }
}
