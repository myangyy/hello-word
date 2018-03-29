using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace OderingSystem.Common
{
    public class Logger
    {
        public static void Error(Exception message)
        {
            object obj = new object();
            lock (obj)
            {
                using (FileStream fileStream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"\shulog.txt",
                    FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                {
                    StreamWriter writer = new StreamWriter(fileStream);
                    writer.WriteLine();
                    writer.WriteLine(DateTime.Now.ToString() + ": " + message);
                    writer.WriteLine();
                }
            }
        }
    }
}