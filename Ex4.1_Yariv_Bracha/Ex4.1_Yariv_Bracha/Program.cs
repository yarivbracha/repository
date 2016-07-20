using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._1_Yariv_Bracha
{
    class Program
    {
        static void Main(string[] args)
        {
            HelperLinqToObjects helper = new HelperLinqToObjects();
            Console.WriteLine("Display all public interfaces and their method sum\n");
            helper.DisplayInterMethodSumNonQuery();
            Console.WriteLine("\nDisplay all current processes that thread count < 5\n");
            helper.DisplayProcessesNonQuery();
            Console.WriteLine("\nDisplay all current processes by base priority\n");
            helper.DisplayProcessesByBasePriorityQuery();
            helper.DisplayProcessesSum();
            

           
        }
    }
}

