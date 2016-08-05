using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBuilder
{
    class Program
    {
        public static void Main(string[] args)
        {
            ProjectBuilderHelper builderHelper = new ProjectBuilderHelper();
            Console.WriteLine("Sequentialiy build start..");
            builderHelper.SequentiallyBuild();
            Console.WriteLine("Sequentialiy build done..");
            Console.WriteLine("\nParallel build start..");
            builderHelper.ParallelBuild();
            Console.WriteLine("Parallel build done..");
        }
    }
}

