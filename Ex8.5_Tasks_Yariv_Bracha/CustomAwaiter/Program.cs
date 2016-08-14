using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CustomAwaiter
{
    class Program
    {
        static void Main(string[] args)
        {
            AwaiterHelper helper = new AwaiterHelper();
            helper.RunByMillis(1000).Wait();
            helper.RunBysecondes(2).Wait();
            helper.RunProcess("notepad").Wait();
        }
    }

    public static class AwaiterExtension
    {
       
        public static TaskAwaiter GetAwaiter(this int millis)
        {
            return TimeSpan.FromMilliseconds(millis).GetAwaiter();
        }

        public static TaskAwaiter<int> GetAwaiter(this Process process)
        {
            var taskCompelitionSource = new TaskCompletionSource<int>();
            process.EnableRaisingEvents = true;

            process.Exited += (obj, eventArgs) => taskCompelitionSource.TrySetResult(process.ExitCode);
            if (process.HasExited)
            {
                taskCompelitionSource.TrySetResult(process.ExitCode);
            }

            return taskCompelitionSource.Task.GetAwaiter();
        }

        public static TaskAwaiter GetAwaiter(this TimeSpan time)
        {
            return Task.Delay(time).GetAwaiter();
        }

    }
}
