using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporter
{
    class Data
    {
        private static readonly Dictionary<string, string> formatAndPath = new Dictionary<string, string>();
        public static Dictionary<string, string> FormatAndPath
        {
            get { return formatAndPath; }
        }
        private static bool isStart = false;
        public static bool IsStart
        {
            get { return isStart; }
            set { isStart = value; }
        }

        public static void Add(string format, string path)
        {
            if (format == null)
                format = "dir";

            if (!formatAndPath.ContainsKey(format))
                formatAndPath.Add(format, path);
            else
            {
                formatAndPath.Remove(format);
                formatAndPath.Add(format, path);
            }
        }
        /*
        public static void Delete(string comand)
        {
            string[] tmp = comand.Split(' ');
            formatAndPath.Remove(tmp[1]);
        }
        */

    }
}
