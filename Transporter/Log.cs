﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumeet94_Transporter
{
    public class Log
    {
        private const string LogFile = "log.txt";
        private static object sync = new object();
        public static void Write(Exception ex)
        {
            try
            {
                if (!File.Exists(LogFile))
                {
                    File.Create(LogFile);
                }
                string fullText = string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] [{1}.{2}()] {3}\r\n", DateTime.Now, 
                                                                                                    ex.TargetSite.DeclaringType, 
                                                                                                    ex.TargetSite.Name, 
                                                                                                    ex.Message
                                               );
                lock (sync)
                {
                    File.AppendAllText(LogFile, fullText, Encoding.GetEncoding("Windows-1251"));
                }
            }
            catch(Exception)
            {

            }
        }
    }
}
