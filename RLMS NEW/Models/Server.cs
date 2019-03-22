using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLMS_NEW
{
    public class Server
    {
        public string ServerName { get; set; }
        public string ConfigPath { get; set; }
        public string ExePath { get; set; }
        public string RealmList { get; set; }
        public string Website { get; set; }
        public string patchVersion { get; set; }
        public List<Account> Acc { get; set; }

    }
}
