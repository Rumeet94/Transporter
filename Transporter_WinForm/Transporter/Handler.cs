using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Transporter
{
    class Handler
    {
        public static void AddFormat(string format,string path)
        {
            Data.Add(format, path);
        }

        public static void DelAllFormats(Dictionary<string, string> formats)
        {
            formats.Clear();
        }

        public static string GetParameters()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Исходный каталог:");
            builder.AppendLine(Data.Path == null ? "исходный каталог не указан" : Data.Path);
            builder.AppendLine();

            builder.AppendLine("Форматы файлов и каталоги, куда файлы будут перенесены:");
            if (Data.Formats.Count == 0)
                builder.AppendLine("Форматы файлов и каталоги не указаны");
            else
            {
                foreach (var format in Data.Formats)
                {
                    builder.AppendLine(string.Format("{0} => {1}", format.Key, format.Value));
                }
            }
            return builder.ToString();
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
                    Thread.Sleep(5000);
                }
                catch (IOException) { }
                catch (KeyNotFoundException) { }
            }
        }
    }
}
