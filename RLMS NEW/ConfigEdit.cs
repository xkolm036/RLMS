using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RLMS_NEW
{
    public class ConfigEdit
    {

        public static void confg(string datadisk, string realm, string path)
        {
            string olds = "";
            switch (datadisk)
            {
                case "TBC":
                    olds = "wwwww";
                    break;
                case "WOTLK":
                    olds = "SET realmlist ";
                    break;
                case "CATA":
                    olds = "SET realmlist ";
                    break;
                case "MOP":
                    olds = "SET realmlist ";
                    break;
                case "WOD":
                    olds = "SET realmlist ";
                    break;
                case "LEGION":
                    olds = "SET portal ";
                    break;
                default: olds = "SET portal ";
                    break;

            }



            int pom = 0;
            string pam = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.ToLower().Contains(olds.ToLower()))
                    {
                        line = olds + realm;
                        pom = 1;
                    }
                    pam += line;
                    pam += ";";
                    // MessageBox.Show(line);
                }

            }
            if (pom == 1)
            {
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    string row = "";
                    foreach (char c in pam)
                    {
                        if (c != ';')
                            row += c;
                        else
                        {
                            sw.WriteLine(row);
                            row = "";
                        }
                    }
                    MessageBox.Show("Realm byl zmenen");
                }
            }
            else
                MessageBox.Show("Realm nebyl zmenen");

        }


    }
}
