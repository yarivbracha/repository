using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Jobs
{
    static class NativeJob
    {
        [DllImport("kernel32")]
        public static extern IntPtr CreateJobObject(IntPtr sa, string name);

        [DllImport("kernel32", SetLastError = true)]
        public static extern bool AssignProcessToJobObject(IntPtr hjob, IntPtr hprocess);

        [DllImport("kernel32")]
        public static extern bool CloseHandle(IntPtr h);

        [DllImport("kernel32")]
        public static extern bool TerminateJobObject(IntPtr hjob, uint code);
    }

    public class Job : IDisposable
    {
        private IntPtr _hJob;
        private List<Process> _processes;
        private int memorySize;

        public Job(string name)
        {
            InitJob(name);
        }

        public Job(string name, int memorySize)
        {
            if(memorySize < 1)
            {
                throw new InvalidOperationException("Invalid memory size - Job not created!");
            }
            InitJob(name);
            this.memorySize = memorySize;
            GC.AddMemoryPressure(memorySize);
            Console.WriteLine($"Created job with {memorySize} memory bytes");
        }

        public Job()
            : this(null)
        {
        }

         ~Job()
        {
            NativeJob.CloseHandle(_hJob);
            if (memorySize > 0)
            {
                GC.RemoveMemoryPressure(memorySize);
                Console.WriteLine($"Released job with {memorySize} memory bytes");
            }
        }

        private void InitJob(string name)
        {
            _hJob = NativeJob.CreateJobObject(IntPtr.Zero, name);
            _processes = new List<Process>();
            if (_hJob == IntPtr.Zero)
            {
                throw new InvalidOperationException("The job not created!");
            }
        }

        protected void AddProcessToJob(IntPtr hProcess)
        {
            CheckIfDisposed();
            if (!NativeJob.AssignProcessToJobObject(_hJob, hProcess))
            {
                throw new InvalidOperationException("Adding process to job failed!!");
            }
        }

        private void CheckIfDisposed()
        {
            if (_hJob == IntPtr.Zero)
            {
                throw new ObjectDisposedException("_hJob");
            }
        }

        public void AddProcessToJob(int pid)
        {
            AddProcessToJob(Process.GetProcessById(pid));
        }

        public void AddProcessToJob(Process proc)
        {
            Debug.Assert(proc != null);
            AddProcessToJob(proc.Handle);
            _processes.Add(proc);
        }

        public void Kill()
        {
            CheckIfDisposed();
            NativeJob.TerminateJobObject(_hJob, 0);
        }

        public void Dispose()
        {
            NativeJob.CloseHandle(_hJob);
            foreach (Process process in _processes)
            {
                process.Dispose();
            }
            GC.SuppressFinalize(this);
            _hJob = IntPtr.Zero;
        }
    }
}
