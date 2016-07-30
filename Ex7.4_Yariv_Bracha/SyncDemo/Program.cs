using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SyncDemoHelper firstApp = new SyncDemoHelper();
            SyncDemoHelper secondApp = new SyncDemoHelper();
            Thread first = new Thread(() => firstApp.RunSyncDemo());
            Thread second = new Thread(() => secondApp.RunSyncDemo());
            first.Start();
            second.Start();
            Console.Read();

            
        }
    }
}
