using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMonitor.Helper
{
    public class LogHelper
    {
        static object mylock = new object();
        public static void WriteLog(string text)
        {
            lock(mylock)
            {
                var logPath = Environment.CurrentDirectory + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "_Log.txt";
                if (!File.Exists(logPath))
                {
                    File.Create(logPath).Dispose();
                }

                using (StreamWriter streamWriter = File.AppendText(logPath))
                {
                    streamWriter.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + text);
                }
            }

        }
    }
}
