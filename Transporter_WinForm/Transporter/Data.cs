﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Rumeet94_Transporter
{
    public class Data
    {
        public Data()
        {
            string fileName = settingsFile;

            try
            {
                XElement xElem2 = XElement.Load(fileName);
                formats = xElem2.Descendants("item")
                                .ToDictionary(x => (string)x.Attribute("format"), x => (string)x.Attribute("path"));
            }
            catch(FileNotFoundException)
            {
                formats = new Dictionary<string, string>();
            }
            catch (UnauthorizedAccessException)
            {
                formats = new Dictionary<string, string>();
            }
        }

        private const string settingsFile = "settings.xml";

        private readonly Dictionary<string, string> formats;
        public Dictionary<string, string> Formats
        {
            get { return formats; }
        }
        private string path = null;
        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public void Add(string format, string path)
        {
            if (!formats.ContainsKey(format))
            {
                formats.Add(format, path);
            }
            else
            {
                formats[format] = path;
            }
        }
        
        public void Save()
        {
            string fileName = settingsFile;

            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
                {
                    XElement xElem = new XElement
                    (
                     "items",
                     formats.Select(x => new XElement("item", new XAttribute("format", x.Key), new XAttribute("path", x.Value)))
                    );
                    xElem.Save(fileStream);
                }
            }
            catch
            {

            }
        }

        public void RemoveSettingsFile()
        {
            if (File.Exists(settingsFile))
            {
                File.Delete(settingsFile);
            }
        }

        public string GetAllFormatsToStr()
        {
            var builder = new StringBuilder().AppendLine("Форматы файлов и каталоги, куда файлы будут перенесены:");

            if (formats.Count == 0)
            {
                builder.AppendLine("Форматы файлов и каталоги не указаны");
            }
            else
            {
                foreach (var format in formats)
                {
                    builder.Append(format.Key).Append(" => ").AppendLine(format.Value);
                }
            }

            return builder.ToString();
        }

        public string GetPathToStr()
        {
            var builder = new StringBuilder().AppendLine("Исходный каталог:")
                                             .AppendLine(path ?? "исходный каталог не указан");
            return builder.ToString();                                 
        }
    }

    public class Item
    {
        public string path;
        public string format;
    }
}
