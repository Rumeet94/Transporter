using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporter
{
    class Handler
    {
        public static void DoAdd(string format,string path)
        {
            Data.Add(format, path);
        }

        public static void DoDel(string comand)
        {
            Data.Delete(comand);
        }

        public static void DoHelp()
        {
            Console.WriteLine("======================================================================================================");
            Console.WriteLine("Для начала работы Вам необходимо задать параметры:");
            Console.WriteLine("1) Команда 'add dir <путь директории>' добавляет исходный каталог, откуда необходимо переносить файлы.");
            Console.WriteLine("2) Команда 'add <разрешение файла> <путь директории>' добавляет разрешение файла и каталог, куда");
            Console.WriteLine("  необходимо переносить файлы.");
            Console.WriteLine("3) Команда 'status' отображает текущие параметры.");
            Console.WriteLine("4) Команда 'start' запускает перенос файлов.");
            Console.WriteLine("======================================================================================================");
        }

        public static void DoStart()
        {
            try
            {
                while (true)
                {
                    try
                    {
                        List<string> filesname = Directory.GetFiles(Data.formatAndPath["dir"]).ToList<string>();
                        foreach (string file in filesname)
                        {
                            if (File.Exists(file))
                                foreach (KeyValuePair<string, string> format in Data.formatAndPath)
                                {
                                    FileInfo fileInf = new FileInfo(file);
                                    if (fileInf.Extension.Contains(format.Key) && !format.Key.Equals("dir"))
                                    {
                                        fileInf.MoveTo(format.Value + @"\" + DateTime.Now.ToString("yyyyMMdd_hhmmss_") + fileInf.Name);
                                        Console.WriteLine("Файл {0} перенесен", fileInf.Name);
                                    }
                                }
                        }
                    }
                    catch (IOException) { }
                }
            }
            catch (KeyNotFoundException) { Console.WriteLine("Не указаны необходимые параметры для запуска"); }

        }

        public static void DoStatus()
        {
            try
            {
                Console.WriteLine("Перенос файлов из дирректории {0}", Data.formatAndPath["dir"]);
            }
            catch
            {
                Console.WriteLine("Исходная дирректория не указана.");
            }

            if (Data.formatAndPath.Values.ToList<string>().Count > 1)
            {
                Console.WriteLine("Перенос файлов в директории по форматам:");
                foreach (KeyValuePair<string, string> x in Data.formatAndPath)
                {
                    if (!x.Key.Equals("dir"))
                        Console.WriteLine("    {0} {1}", x.Key, x.Value);
                }
            }
            else
            {
                Console.WriteLine("Форматы файлов и каталоги для переноса не указаны");
            }

        }
    }
}
