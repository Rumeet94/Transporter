using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Transporter
{
    public struct Data
    {
        public static readonly Dictionary<string, string> formatAndPath = new Dictionary<string, string>();
        public Dictionary<string, string> FormatAndPath
        {
            get { return formatAndPath; }
        }

        public static void Add(string comand)
        {
            string[] tmp = comand.Split(" ");
            if (!formatAndPath.ContainsKey(tmp[1]))
                formatAndPath.Add(tmp[1], tmp[2]);
            else
            {
                formatAndPath.Remove(tmp[1]);
                formatAndPath.Add(tmp[1], tmp[2]);
            }

        }

        public static void Delete(string comand)
        {
            string[] tmp = comand.Split(" ");
            formatAndPath.Remove(tmp[1]);
        }
    }

    public class Handler
    {
        public static void DoAdd(string comand)
        {
            Data.Add(comand);
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

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую! Чем я могу Вам помочь? Для справки введите команду help.");

            string input = null;
            while(!(input = Console.ReadLine()).Equals("exit"))
            {
                if (input.Contains("add") && CheckKeyAndPath(input)) Handler.DoAdd(input);
                if (input.Contains("del") && CheckKeyAndPath(input)) Handler.DoDel(input);
                if (input.Equals("start")) Handler.DoStart();
                if (input.Equals("status")) Handler.DoStatus();
                if (input.Equals("help")) Handler.DoHelp();
            } 
        }

        private static bool CheckKeyAndPath(string input)
        {
            try
            {
                string key = input.Split(" ")[1];

                if(input.Contains("add"))
                {
                    string val = input.Split(" ")[2];
                }

                return true;
            }
            catch
            {
                Console.WriteLine("Команда введена некорретно. Для помощи введите команду help.");
                return false;
            }
        }
    }    
}
