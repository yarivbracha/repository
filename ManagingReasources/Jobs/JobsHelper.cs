using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs
{
    class JobsHelper
    {
        public void Run()
        {
            Job firstJob = new Job();
            Process calcProcess = Process.Start("calc");
            Debug.Assert(calcProcess != null);
            firstJob.AddProcessToJob(calcProcess);
            Process notepadProcess = Process.Start("notepad");
            Debug.Assert(notepadProcess != null);
            firstJob.AddProcessToJob(notepadProcess);
            Console.WriteLine("Press enter to kill all firstJob processes");
            Console.ReadLine();
            firstJob.Kill();

            Job[] JobArray = new Job[20];
            string name;
            int memorySize = 1;
            for (int i = 1; i < 21; i++)
            {
                name = "Job " + i;
                JobArray[i - 1] = new Job(name, memorySize);
                if ((i - 1 != 0) && ((i - 1) % 2 == 0))
                {
                    memorySize++;
                }
            }
        }
    }
}
