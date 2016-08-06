using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace SyncDemo
{
    class SyncDemoHelper
    {
       
        public void RunSyncDemo()
        {
            Mutex mutex = new Mutex(false, "SyncFileMutex");
            StreamWriter writer = null;
            for (int i = 0; i < 10000; i++)
            {
			    mutex.WaitOne();
                try
                {
                    writer = new StreamWriter(@"c:\temp\data.txt", true);
                    writer.WriteLine($"current Process: {Process.GetCurrentProcess().Id}");
                    
                }
                catch (IOException)
                {

                }
                finally
                {
                    mutex.ReleaseMutex();
                    if (writer != null)
                    {
                        writer.Close();
                    }
                }
            }
            Console.WriteLine("Finish to write.");
        }
    }

}

