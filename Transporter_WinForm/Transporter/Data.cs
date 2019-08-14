using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporter
{
    class Data
    {
        private static readonly Dictionary<string, string> formats = new Dictionary<string, string>();
        public static Dictionary<string, string> Formats
        {
            get { return formats; }
        }

        private static string path = null;
        public static string Path
        {
            get { return path; }
            set { path = value; }
        }

        public static void Add(string format, string path)
        {
            if (!formats.ContainsKey(format))
                formats.Add(format, path);
            else
            {
                formats.Remove(format);
                formats.Add(format, path);
            }
        }
    }
}
