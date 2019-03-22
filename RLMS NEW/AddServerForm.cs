using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RLMS_NEW
{
    public partial class AddServerForm : Form
    {
      
        public AddServerForm()
        {
            InitializeComponent();

            if (AppData.Database.Count != 0)
            {
                foreach (Models.Datadisk d in AppData.Database)
                {
                    comboBox1.Items.Add(d.datadiskName);
                }

                if (AppData.selectedDatadisk != null)
                {
                    comboBox1.SelectedItem = AppData.selectedDatadisk.datadiskName;
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.AccountName = "";
            a.AccountPassword = "";
            Server s = new Server();
            s.Acc = new List<Account>();
            s.Acc.Add(a);
            s.ServerName = textBox1.Text;

            Models.Datadisk d = new Models.Datadisk();
            d.datadiskName = comboBox1.Text;
            d.servers = new List<Server>();
            //d.servers.Add(s);

            int isinDB = 0;
            foreach (Models.Datadisk dad in AppData.Database)
            {
                if (dad.datadiskName == d.datadiskName)
                {
                    dad.servers.Add(s);
                    isinDB = 1;
                    break;
                }
            }

            if (isinDB == 0)
            {
                AppData.Database.Add(d);
            }

      
            this.Close();
        }
    }
}
