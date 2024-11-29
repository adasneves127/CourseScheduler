using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    internal class Settings
    {
        public static int semesterID = -1;
        public static string semesterName = null;
        public static string user = "";
        public static string host = "";
        public static string name = "";
        public static string password = "";
        public static string connString { get => "server=" + host + ";uid=" + user + ";pwd=" + password + ";database=" + name + ";"; }
    }
}
