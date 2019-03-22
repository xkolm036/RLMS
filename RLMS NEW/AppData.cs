using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLMS_NEW
{
    public class AppData
    {
        public static List<Models.Datadisk> Database { get; set; } = null;
        public static Server selectedServer { get; set; } = new Server();
        public static Models.Datadisk selectedDatadisk { get; set; } = new Models.Datadisk();
        

    }
}
