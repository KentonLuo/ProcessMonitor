using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMonitor.Data
{
    public class ProcessInfo
    {
        public int ProcessId { get; set; }

        public string ProcessName { get; set; }

        public string CpuRatio { get; set; }

        public string MemeryRatio { get; set; }

        public string LocalTime { get; set; }

        public bool IsSelected { get; set; }
    }
}
