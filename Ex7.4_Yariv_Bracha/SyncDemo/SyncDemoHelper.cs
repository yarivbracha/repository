﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SyncDemo
{
    class SyncDemoHelper
    {
        Mutex mutex = new Mutex(false, "SyncFileMutex");
    }
}
