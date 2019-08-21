using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Rumeet94_Transporter
{
    class Handler
    {
        private readonly Data data = new Data();
        private const int WaitTimeBetweenTransfers = 5000;

        public void AddFormat(string format,string path)
        {
            data.Add(format, path);
        }

        public void AddPath(string path)
        {
            data.Path = path;
        }

        public void DelAllFormats()
        {
            data.Formats.Clear();
            data.RemoveSettingsFile();
        }

        public string GetParameters()
        {
            var builder = new StringBuilder().AppendLine("Исходный каталог:")
                                             .AppendLine(data.Path ?? "исходный каталог не указан")
                                             .AppendLine()
                                             .AppendLine("Форматы файлов и каталоги, куда файлы будут перенесены:");
            if (data.Formats.Count == 0)
            {
                builder.AppendLine("Форматы файлов и каталоги не указаны");
            }
            else
            {
                foreach (var format in data.Formats)
                {
                    builder.Append(format.Key).Append(" => ").AppendLine(format.Value);
                }
            }
            return builder.ToString();
        }

        public void MoveFiles(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    var files = Directory.GetFiles(data.Path);
                    foreach (string file in files)
                    {
                        foreach (var format in data.Formats)
                        {
                            var fileInfo = new FileInfo(file);
                            if (fileInfo.Extension.ToLower().Contains(format.Key.ToLower()))
                            {
                                fileInfo.MoveTo(format.Value + @"\" + DateTime.Now.ToString("yyyyMMdd_hhmmss_") + fileInfo.Name);
                            }
                        }
                    }
                    Thread.Sleep(WaitTimeBetweenTransfers);
                }
                catch (IOException) { }
                catch (KeyNotFoundException) { }
            }
        }

        public void SaveSetting()
        {
            data.Save();
        }

        public bool checkParametrsForStart()
        {
            return data.Path != null && data.Formats.Count > 0;
        }
    }
}
