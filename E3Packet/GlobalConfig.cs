using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3Packet
{
    class GlobalConfig
    {
        public static string scriptsDirName = ConfigurationManager.AppSettings["scriptsPath"];
        public static string filesDirName = ConfigurationManager.AppSettings["filesPath"];
    }
}
