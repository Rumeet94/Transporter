using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Transporter
{
    class Handler
    {
        public static void AddFormat(string format,string path)
        {
            Data.Add(format, path);
        }

        public static string CreateMessage(string message)
        {
            return DateTime.Now.ToString("dd.MM.yy hh:mm:ss ") + message;
        }

        public static void MoveFiles(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    var files = Directory.GetFiles(Data.Path);
                    foreach (string file in files)
                    {
                        foreach (var format in Data.Formats)
                        {
                            var fileInfo = new FileInfo(file);
                            if (fileInfo.Extension.Contains(format.Key))
                            {
                                fileInfo.MoveTo(format.Value + @"\" + DateTime.Now.ToString("yyyyMMdd_hhmmss_") + fileInfo.Name);
                            }
                        }
                    }
                }
                catch (IOException) { }
                catch (KeyNotFoundException) { }
            }
        }
    }
}
