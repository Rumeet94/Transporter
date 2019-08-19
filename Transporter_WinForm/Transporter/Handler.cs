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
        private readonly Data data = new Data();
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
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Исходный каталог:");
            builder.AppendLine(data.Path == null ? "исходный каталог не указан" : data.Path);
            builder.AppendLine();

            builder.AppendLine("Форматы файлов и каталоги, куда файлы будут перенесены:");
            if (data.Formats.Count == 0)
            {
                builder.AppendLine("Форматы файлов и каталоги не указаны");
            }
            else
            {
                foreach (var format in data.Formats)
                {
                    builder.AppendLine(string.Format("{0} => {1}", format.Key, format.Value));
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
                    Thread.Sleep(5000);
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
