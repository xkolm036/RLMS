using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLMS_NEW.Models
{
    public class Datadisk
    {
        public string datadiskName { get; set; }
       // public string patchVersion { get; set; }
        public string iconPath { get; set; }
        public List<Server> servers { get; set; }

    }
}
