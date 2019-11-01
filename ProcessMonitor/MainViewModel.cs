using ProcessMonitor.Data;
using ProcessMonitor.Helper;
using ProcessMonitor.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;
using System.Media;
using ProcessMonitor.Dialog;

namespace ProcessMonitor
{
    public class AppSetting
    {
        public double CpuLimitValue { set; get; }
        public double MemoryLimitValue { set; get; }
        public long DiskLimitSize { set; get; }
        public bool IsWriteLog { set; get; }
        public string StartTime { set; get; }
        public string EndTime { set; get; }
    }

    public class HardDisk : INotifyPropertyChanged
    {
        private string diskName;
        private string total;
        private string available;
        private double usedRate;
        private string tip;

        public string DiskName
        {
            set
            {
                diskName = value;
                OnPropertyChanged("DiskName");
            }
            get
            {
                return diskName;
            }
        }

        public string Total
        {
            set
            {
                total = value;
                OnPropertyChanged("Total");
            }
            get
            {
                return total;
            }
        }
        public string Available
        {
            set
            {
                available = value;
                OnPropertyChanged("Available");
            }
            get
            {
                return available;
            }
        }
        public double UsedRate
        {
            set
            {
                usedRate = value;
                OnPropertyChanged("UsedRate");
            }
            get
            {
                return usedRate;
            }
        }

        public string Tip
        {
            set
            {
                tip = value;
                OnPropertyChanged("Tip");
            }
            get
            {
                return tip;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {          
            this.InitAppSettings();
            this.GetAllProcesses();
            this.RealTimeMonitoring();
            this.InitDrivers();
            this.RealTimeHardDisk();
            this.ClearLog();
        }
    
        string logDir = System.IO.Directory.GetCurrentDirectory();
        private List<ProcessManager> objMgrs = new List<ProcessManager>();
        private DriveInfo[] objDriveInfo = null;
        private List<NotificationDialog> _notificationDialogs = new List<NotificationDialog>();

        private List<ProcessInfo> apps = new List<ProcessInfo>();
        public List<ProcessInfo> Apps
        {
            set
            {
                apps = value;
                OnPropertyChanged("Apps");
            }

            get
            {
                return apps;
            }
        }

        private List<HardDisk> hardDisks = new List<HardDisk>();
        public List<HardDisk> HardDisks
        {
            set
            {
                hardDisks = value;
                OnPropertyChanged("HardDisks");
            }

            get
            {
                return hardDisks;
            }
        }

        private bool? isAllSelected = false;
        public bool? IsAllSelected
        {
            set
            {
                isAllSelected = value;
                OnPropertyChanged("IsAllSelected");
            }
            get
            {
                return isAllSelected;
            }
        }

        private double cpuProgress = 0;
        public double CpuProgress
        {
            set
            {
                cpuProgress = value;
                OnPropertyChanged("CpuProgress");
            }
            get
            {
                return cpuProgress;
            }
        }

        private double memoryProgress = 0;
        public double MemoryProgress
        {
            set
            {
                memoryProgress = value;
                OnPropertyChanged("MemoryProgress");
            }
            get
            {
                return memoryProgress;
            }
        }

        private double cpuLimitValue = 70;
        public double CpuLimitValue
        {
            set
            {
                cpuLimitValue = value;
                OnPropertyChanged("CpuLimitValue");
            }
            get
            {
                return cpuLimitValue;
            }
        }

        private double memoryLimitValue = 70;
        public double MemoryLimitValue
        {
            set
            {
                memoryLimitValue = value;
                OnPropertyChanged("MemoryLimitValue");
            }
            get
            {
                return memoryLimitValue;
            }
        }

        private long diskLimitValue;

        public long DiskLimitSize
        {
            set
            {
                diskLimitValue = value;
                OnPropertyChanged("DiskLimitSize");
            }
            get
            {
                return diskLimitValue;
            }
        }

        private bool isWriteLog;
        public bool IsWriteLog
        {
            set
            {
                isWriteLog = value;
                OnPropertyChanged("IsWriteLog");
            }
            get
            {
                return isWriteLog;
            }
        }

        private string startTime;
        public string StartTime
        {
            set
            {
                startTime = value;
                OnPropertyChanged("StartTime");
            }
            get
            {
                return startTime;
            }
        }

        private string endTime;
        public string EndTime
        {
            set
            {
                endTime = value;
                OnPropertyChanged("EndTime");
            }
            get
            {
                return endTime;
            }
        }

        private void InitAppSettings()
        {
            if (!File.Exists("AppSetting.json"))
            {
                return;
            }

            try
            {
                string text = File.ReadAllText("AppSetting.json");
                var appSettings = LitJson.JsonMapper.ToObject<AppSetting>(text);
                this.CpuLimitValue = appSettings.CpuLimitValue;
                this.MemoryLimitValue = appSettings.MemoryLimitValue;
                this.DiskLimitSize = appSettings.DiskLimitSize;
                this.IsWriteLog = appSettings.IsWriteLog;
                this.StartTime = appSettings.StartTime;
                this.EndTime = appSettings.EndTime;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex.Message);
            }
        }

        private void GetAllProcesses()
        {
            try
            {
                Process[] processes = Process.GetProcesses();
                foreach (Process instance in processes)
                {
                    var info = new ProcessInfo();
                    info.ProcessName = instance.ProcessName;
                    info.ProcessId = instance.Id;
                    info.IsSelected = false;
                    Apps.Add(info);
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex.Message);
            }

        }

        private void InitDrivers()
        {
            try
            {
                objDriveInfo = DriveInfo.GetDrives();
                foreach (var item in objDriveInfo)
                {
                    var hardDisk = new HardDisk();
                    hardDisk.DiskName = item.Name;
                    hardDisk.Available = AnyHelper.BytesToString(item.AvailableFreeSpace);
                    hardDisk.Total = AnyHelper.BytesToString(item.TotalSize);
                    hardDisk.UsedRate = 100 - (int)(item.AvailableFreeSpace / (item.TotalSize * 1.00) * 100);
                    hardDisk.Tip = "正常";
                    HardDisks.Add(hardDisk);
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex.Message);
            }

        }

        public void RealTimeMonitoring()
        {
            Task.Run(() =>
            {
                try
                {
                    // Sleep的时间间隔
                    int interval = 2000;
                    PerformanceCounter totalcpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                    SystemInfo sys = new SystemInfo();
                    const int KB_DIV = 1024;
                    const int MB_DIV = 1024 * 1024;
                    const int GB_DIV = 1024 * 1024 * 1024;
                    while (true)
                    {
                        double cpu = sys.CpuLoad;
                        double memory = (sys.PhysicalMemory - sys.MemoryAvailable) * 1.0 / (sys.PhysicalMemory * 1.0) * 100;
                        this.CpuProgress = Math.Round(cpu);
                        this.MemoryProgress = Math.Round(memory);
                        if (IsWriteLog)
                        {
                            DateTime localTime = DateTime.Now;
                            DateTime.TryParse(StartTime, out DateTime starTime);
                            DateTime.TryParse(EndTime, out DateTime endTime);
                            if (localTime > starTime && localTime < endTime)
                            {
                                WriteLog(new ProcessInfo
                                {
                                    CpuRatio = this.CpuProgress.ToString(),
                                    MemeryRatio = this.MemoryProgress.ToString(),
                                    LocalTime = localTime.ToString(),
                                    ProcessName = "total"
                                }) ;
                            }
                        }
                        if (cpu > CpuLimitValue || memory > MemoryLimitValue)
                        {
                            AnyHelper.Alarm();
                            App.Current.Dispatcher.BeginInvoke((Action)delegate ()
                            {
                                this.ShowNotification("警告", "请注意，CPU或者内存过载");
                            });
                        }
                        Thread.Sleep(interval);
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.WriteLog(ex.Message);
                }              
            });
        }

        public void RealTimeHardDisk()
        {
            Task.Run(() =>
            {
                try
                {
                    while (true)
                    {
                        foreach (var item in objDriveInfo)
                        {
                            string diskName = item.Name;
                            var hardDisk = HardDisks.Find(p => p.DiskName == diskName);
                            if (hardDisk != null)
                            {
                                hardDisk.Available = AnyHelper.BytesToString(item.AvailableFreeSpace);
                                if (item.AvailableFreeSpace < this.DiskLimitSize)
                                {
                                    hardDisk.Tip = "磁盘空间不足";
                                    AnyHelper.Alarm();
                                    App.Current.Dispatcher.BeginInvoke((Action)delegate ()
                                    {
                                        this.ShowNotification("警告", "请注意，磁盘控件不足，请及时清理");
                                    });
                                }

                                else
                                {
                                    hardDisk.Tip = "正常";
                                }

                                hardDisk.UsedRate = hardDisk.UsedRate = 100 - (int)(item.AvailableFreeSpace / (item.TotalSize * 1.00) * 100);
                            }

                            Thread.Sleep(2000);
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.WriteLog(ex.Message);
                }
            });
        }

        private void WriteLog(ProcessInfo info)
        {
            string dirPath = $"{logDir}\\log\\{DateTime.Today.ToString("yyyyMMdd")}";
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            string totalPath = dirPath + "\\" + "total.csv";
            if (!File.Exists(totalPath))
            {
                File.WriteAllLines(totalPath, new string[]
                {
                        "进程名, 进程ID, 内存使用率, CPU使用率, 本地时间"
                }, Encoding.UTF8);
            }
            AnyHelper.WriteCSV(totalPath, info);
        }

        private void ClearLog()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    if (DateTime.Now.ToLongTimeString().CompareTo("23:00:00") > 0 && DateTime.Now.ToLongTimeString().CompareTo("23:00:30") < 0)
                    {
                        string today = DateTime.Today.ToString("yyyyMMdd");
                        var childDirs = Directory.GetDirectories(logDir + "\\log");
                        foreach (var item in childDirs)
                        {
                            if (item != today)
                            {
                                Directory.Delete(item, true);
                            }
                        }
                    }
                    Thread.Sleep(500);
                }
            });
        }

        public void Start()
        {
            LogHelper.WriteLog("启动监测");
            Task.Run(() =>
            {
                try
                {
                    if (Apps == null || Apps.Count == 0)
                    {
                        return;
                    }

                    string dirPath = $"{logDir}\\log\\{DateTime.Today.ToString("yyyyMMdd")}";
                    if (!Directory.Exists(dirPath))
                    {
                        Directory.CreateDirectory(dirPath);
                    }

                    foreach (var app in Apps)
                    {
                        if (app.IsSelected)
                        {
                            string logPath = $"{dirPath}\\{app.ProcessName}-{app.ProcessId}.csv";
                            if (!File.Exists(logPath))
                            {
                                File.WriteAllLines(logPath, new string[]
                                {
                                "进程名, 进程ID, 内存使用率, CPU使用率, 本地时间"
                                }, Encoding.UTF8);
                            }

                            Process process = Process.GetProcessById(app.ProcessId);
                            ProcessManager mgr = new ProcessManager(process, logPath);
                            mgr.StartMonitoring();
                            this.objMgrs.Add(mgr);
                        }                       
                    }                  
                }
                catch (Exception ex)
                {
                    LogHelper.WriteLog(ex.Message);
                }

            });
            
        }

        public void Stop()
        {
            foreach (var item in this.objMgrs)
            {
                item.StopMonitoring();
            }
        }

        /// <summary>
        /// 判断选择状态
        /// </summary>
        /// <returns></returns>
        public bool? JudgeCheckAllState()
        {
            int selectedCount = 0;
            foreach (var item in this.Apps)
            {
                if (item.IsSelected)
                {
                    selectedCount++;
                }
            }

            if (selectedCount == 0)
            {
                this.IsAllSelected = false;
            }
            else if (selectedCount == Apps.Count)
            {
                this.IsAllSelected = true;
            }
            else
            {
                this.IsAllSelected = null;
            }

            return this.IsAllSelected;
        }

        /// <summary>
        /// 全选
        /// </summary>
        public void SelectAll()
        {
            foreach (var item in this.Apps)
            {
                item.IsSelected = true;
            }
        }

        /// <summary>
        /// 取消全选
        /// </summary>
        public void UnSelectAll()
        {
            foreach (var item in this.Apps)
            {
                item.IsSelected = false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                new PropertyChangedEventArgs(propertyName));
            }
        }

        private void ShowNotification(string title, string msg)
        {
            NotifyData data = new NotifyData();
            data.Title = title;
            data.Content = msg;

            NotificationDialog dialog = new NotificationDialog();//new 一个通知
            dialog.Closed += Dialog_Closed;
            dialog.TopFrom = GetTopFrom();
            _notificationDialogs.Add(dialog);
            dialog.DataContext = data;//设置通知里要显示的数据
            dialog.ShowActivated = false;
            dialog.Show();
        }

        private void Dialog_Closed(object sender, EventArgs e)
        {
            var closedDialog = sender as NotificationDialog;
            _notificationDialogs.Remove(closedDialog);
        }
        double GetTopFrom()
        {
            //屏幕的高度-底部TaskBar的高度。
            double topFrom = System.Windows.SystemParameters.WorkArea.Bottom - 10;
            bool isContinueFind = _notificationDialogs.Any(o => o.TopFrom == topFrom);

            while (isContinueFind)
            {
                topFrom = topFrom - 110;//此处100是NotifyWindow的高 110-100剩下的10  是通知之间的间距
                isContinueFind = _notificationDialogs.Any(o => o.TopFrom == topFrom);
            }

            if (topFrom <= 0)
                topFrom = System.Windows.SystemParameters.WorkArea.Bottom - 10;

            return topFrom;
        }
    }
}
