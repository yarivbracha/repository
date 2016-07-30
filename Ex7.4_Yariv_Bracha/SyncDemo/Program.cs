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
            //Task.Run(() => firstApp.RunSyncDemo());
            //Task.Run(() => secondApp.RunSyncDemo());
            Thread t1 = new Thread(() => firstApp.RunSyncDemo());
            Thread t2 = new Thread(() => secondApp.RunSyncDemo());
            t1.Start();
            t2.Start();
            Console.Read();

            
        }
    }
}
