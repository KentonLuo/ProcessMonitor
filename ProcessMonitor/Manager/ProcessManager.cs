using ProcessMonitor.Data;
using ProcessMonitor.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessMonitor.Manager
{
    class ProcessManager
    {
        private Process objProcess = null;
        private string objLogPath = string.Empty;
        private bool objStopflag = false;

        public ProcessManager(Process process, string logPath)
        {
            this.objProcess = process;
            this.objLogPath = logPath;
        }

        public void StartMonitoring()
        {
            objStopflag = false;
            Task.Run(() =>
            {
            //PerformanceCounter curpcp = new PerformanceCounter("Process", "Working Set - Private", this.objProcess.ProcessName);
            //PerformanceCounter curpc = new PerformanceCounter("Process", "Working Set", this.objProcess.ProcessName);
            //PerformanceCounter curtime = new PerformanceCounter("Process", "% Processor Time", this.objProcess.ProcessName);

            //上次记录CPU的时间
            TimeSpan prevCpuTime = TimeSpan.Zero;
            //Sleep的时间间隔
            int interval = 1000;
            SystemInfo sys = new SystemInfo();

            var info = new ProcessInfo();
            info.ProcessId = objProcess.Id;
            info.ProcessName = objProcess.ProcessName;
            while (!objStopflag)
            {
                //当前时间

                var curTime = objProcess.TotalProcessorTime;

                //间隔时间内的CPU运行时间除以逻辑CPU数量

                double cpuValue = Math.Round((curTime - prevCpuTime).TotalMilliseconds / interval / Environment.ProcessorCount * 100, 2);
                double memValue = Math.Round((objProcess.WorkingSet64 * 1.00 / sys.PhysicalMemory * 1.00) * 100, 2);

                prevCpuTime = curTime;

                Console.WriteLine($"CPU使用率：{cpuValue}%");

                //TimeSpan curCpuTime = this.objProcess.TotalProcessorTime;
                //double value = (curCpuTime - prevCpuTime).TotalMilliseconds / interval / Environment.ProcessorCount * 100;
                //prevCpuTime = curCpuTime;

                //long totalBytesOfMemoryUsed = objProcess.WorkingSet64;
                info.CpuRatio = $"{cpuValue}%";
                info.MemeryRatio = $"{memValue}%";
                info.LocalTime = DateTime.Now.ToLocalTime().ToLongTimeString();

                AnyHelper.WriteCSV(this.objLogPath, info);

                //Console.WriteLine("{0}:{1}  {2:N}KB CPU使用率：{3}", objProcess.ProcessName, "工作集(进程类)", objProcess.WorkingSet64 / 1024, value); //这个工作集只是在一开始初始化，后期不变
                //Console.WriteLine("{0}:{1}  {2:N}KB CPU使用率：{3}", objProcess.ProcessName, "工作集        ", curpc.NextValue() / 1024, value); //这个工作集是动态更新的                                                                                                                                           //第二种计算CPU使用率的方法
                //Console.WriteLine("{0}:{1}  {2:N}KB CPU使用率：{3}%", objProcess.ProcessName, "私有工作集    ", curpcp.NextValue() / 1024, curtime.NextValue() / Environment.ProcessorCount);

                Thread.Sleep(interval);
            }
            });   
        }

        public void StopMonitoring()
        {
            this.objStopflag = true;
        }
    }
}
