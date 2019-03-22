using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RLMS_NEW
{
    public class XML
    {
        /// <summary>
        /// Write databese to the xml file
        /// </summary>
        /// <param name="Database"></param>
        public static void SaveXml()
        {
            AppData.Database = AppData.Database.OrderBy(x => x.datadiskName).ToList();

            XmlWriterSettings set = new XmlWriterSettings();
            set.Indent = true;

            using (XmlWriter w = XmlWriter.Create(@"Database.xml", set))
            {
                w.WriteStartDocument();
                w.WriteStartElement("DB");

                string datadisk = AppData.Database[0].datadiskName;
                w.WriteStartElement("datadisk");
                w.WriteAttributeString("DatadiskName", datadisk);
                //w.WriteAttributeString("patchVersion", AppData.Database[0].patchVersion);

                foreach (Models.Datadisk d in AppData.Database)
                {
                    if (datadisk != d.datadiskName)
                    {
                        w.WriteEndElement();
                        datadisk = d.datadiskName;
                        w.WriteStartElement("datadisk");
                        w.WriteAttributeString("DatadiskName", datadisk);
                 //       w.WriteAttributeString("patchVersion", d.patchVersion);
                        w.WriteAttributeString("iconPath", d.iconPath);
                    }

                    foreach (Server s in d.servers)
                    {

                        w.WriteStartElement("Servers");
                        w.WriteAttributeString("ServerName", s.ServerName);
                        w.WriteAttributeString("ConfigPath", s.ConfigPath);
                        w.WriteAttributeString("RealmList", s.RealmList);
                        w.WriteAttributeString("ExePath", s.ExePath);
                        w.WriteAttributeString("Website", s.Website);
                        w.WriteAttributeString("patchVersion", s.patchVersion);

                        foreach (Account a in s.Acc)
                        {

                            w.WriteStartElement("Acc");
                            w.WriteAttributeString("AccountName", a.AccountName);
                            w.WriteAttributeString("AccountPassword", a.AccountPassword);
                            w.WriteAttributeString("CharacterInfo", a.CharacterInfo);
                            w.WriteEndElement();

                        }
                        w.WriteEndElement();
                    }
                }
                w.WriteEndElement();
                w.WriteEndElement();
                w.WriteEndDocument();
                w.Flush();
            }




        }
        /// <summary>
        /// Read Xml database
        /// </summary>
        /// <returns>List of datadisk</returns>
        public static List<Models.Datadisk> ReadXMlFile()
        {

            List<Models.Datadisk> database = new List<Models.Datadisk>();
            Models.Datadisk d = new Models.Datadisk();
            Server s = new Server();
            List<Account> a = new List<Account>();
            List<Server> LS = new List<Server>();


            using (XmlReader xr = XmlReader.Create(@"Database.xml"))
            {
                while (xr.Read())
                {
                    if (xr.NodeType == XmlNodeType.Element)
                    {
                        if (xr.Depth == 1)
                        {
                            d = new Models.Datadisk();
                            d.datadiskName = xr.Name;
                            d.datadiskName = xr.GetAttribute("DatadiskName");
                       //     d.patchVersion = xr.GetAttribute("patchVersion");
                            d.iconPath = xr.GetAttribute("iconPath");
                        }
                        if (xr.Depth == 2)
                        {
                            s = new Server();
                            s.ServerName = xr.GetAttribute("ServerName");
                            s.ConfigPath = xr.GetAttribute("ConfigPath");
                            s.RealmList = xr.GetAttribute("RealmList");
                            s.ExePath = xr.GetAttribute("ExePath");
                            s.Website = xr.GetAttribute("Website");
                            s.patchVersion = xr.GetAttribute("patchVersion");
                        }

                        if (xr.Depth == 3)
                        {
                            Account acc = new Account();
                            acc.AccountName = xr.GetAttribute("AccountName");
                            acc.AccountPassword = xr.GetAttribute("AccountPassword");
                            acc.CharacterInfo = xr.GetAttribute("CharacterInfo");
                            a.Add(acc);

                        }
                    }

                    if (xr.NodeType == XmlNodeType.EndElement)
                    {
                        if (xr.Depth == 2)
                        {
                            s.Acc = new List<Account>();
                            foreach (Account ak in a)
                            {
                                s.Acc.Add(ak);
                            }

                            LS.Add(s);
                            a.Clear();

                        }

                        if (xr.Depth == 1)
                        {

                            d.servers = new List<Server>();
                            foreach (Server sr in LS)
                            {
                                d.servers.Add(sr);
                            }


                            database.Add(d);
                            LS.Clear();
                        }

                    }

                }
            }

            return database;
        }

    }
}
