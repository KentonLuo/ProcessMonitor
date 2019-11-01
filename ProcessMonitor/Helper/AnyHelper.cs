using CsvHelper;
using ProcessMonitor.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMonitor.Helper
{
    class AnyHelper
    {
        static object s_lock = new object();
        public static void WriteCSV(string path, ProcessInfo info)
        {
            lock(s_lock)
            {
                try
                {
                    using (StreamWriter streamWriter = File.AppendText(path))
                    {
                        streamWriter.WriteLine($"{info.ProcessName},{info.ProcessId},{info.MemeryRatio},{info.CpuRatio}, {info.LocalTime}");
                    }
                }

                catch (Exception)
                {

                    throw;
                }
            }

        }

        public static void Alarm()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"alarm.wav";
            player.Load(); //同步加载声音
            player.Play(); //启用新线程播放
        }

        public static string BytesToString(long bytes)
        {
            if (bytes < 1024)
                return bytes + " B";
            int exp = (int)(Math.Log(bytes) / Math.Log(1024));
            string pre = "KMGTPE"[exp - 1] + " ";
            return string.Format("{0:F1} {1}B", bytes / Math.Pow(1024, exp), pre);

        }
    }
}
