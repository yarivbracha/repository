using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectBuilder
{
    class ProjectBuilderHelper
    {
        public void SequentiallyBuild()
        {
            for (int i = 1; i < 9; i++)
            {
                BuildProject(i);
            }
        }

        public void ParallelBuild()
        {
            Task task1 = Task.Factory.StartNew(() => BuildProject(1));
            Task task2 = Task.Factory.StartNew(() => BuildProject(2));
            Task task3 = Task.Factory.StartNew(() => BuildProject(3));
            Task task4 = task1.ContinueWith(_ => BuildProject(4));
            Task task5 = Task.Factory.ContinueWhenAll(new Task[] { task1, task2, task3 }, _ => BuildProject(5));
            Task task6 = Task.Factory.ContinueWhenAll(new Task[] { task3, task4 }, _ => BuildProject(6));
            Task task7 = Task.Factory.ContinueWhenAll(new Task[] { task5, task6 }, _ => BuildProject(7));
            Task task8 = task5.ContinueWith(_ => BuildProject(8));
            Task.WaitAll(task7, task8);
        }

        private void BuildProject(int projectIndex)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Build project {projectIndex}");
        }
    }
}
