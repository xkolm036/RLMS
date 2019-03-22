using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RLMS_NEW
{

    public partial class Form1 : Form
    {

        private List<TextBox> inputs = new List<TextBox>();
    

        public Form1()
        {
            InitializeComponent();

        dataGridView1.Font = new Font("arial", 18);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 2;
            dataGridView1.AutoSize = true;
            dataGridView1.AutoSizeColumnsMode =
             dataGridView1.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;


            this.Text = AppData.selectedServer.ServerName;
            textBox_ServerName.Text = AppData.selectedServer.ServerName;

            createtable(); //vytvori datagrid a naplni textboxy
            editlogic(); // edit radiobutton logika


            Form1_logic.CreatePicture(ref pictureBox_Home, 50, 50, pictureName: "home.png");
            Form1_logic.CreatePicture(ref pictureBox_Plus, 35, 35, pictureName: "plus.png");
            Form1_logic.CreatePicture(ref pictureBox_Minus, 35, 35, pictureName: "minus.png");
            Form1_logic.CreatePicture(ref pictureBox_DeleteServer, 50, 50, pictureName: "deleteServer.png");

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (AppData.Database.Count > 0)
                XML.SaveXml();
        }

        void createtable()
        {

            textBoxRLM.Text = AppData.selectedServer.RealmList;
            textBoxWeb.Text = AppData.selectedServer.Website;
            textBoxExe.Text = AppData.selectedServer.ExePath;
            textBoxCFG.Text = AppData.selectedServer.ConfigPath;
            textBoxWeb.Text = AppData.selectedServer.Website;
            //  textBoxPversion.Text = AppData.selectedDatadisk.patchVersion;
            textBoxPversion.Text = AppData.selectedServer.patchVersion;


            dataGridView1.Columns[0].Name = "AccountName";
            dataGridView1.Columns[0].HeaderText = "Acount";
            dataGridView1.Columns[0].DataPropertyName = "AccountName";
            dataGridView1.Columns[0].MinimumWidth = 200;
            dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView1.Columns[1].HeaderText = "Password";
            dataGridView1.Columns[1].Name = "AccountPassword";
            dataGridView1.Columns[1].DataPropertyName = "AccountPassword";
            dataGridView1.Columns[1].MinimumWidth = 183;

            /* dataGridView1.Columns[2].Name = "CharacterInfo";
             dataGridView1.Columns[2].HeaderText = "Postavy";
             dataGridView1.Columns[2].DataPropertyName = "CharacterInfo";
             dataGridView1.Columns[2].MinimumWidth = 314;*/
            dataGridView1.DataSource = AppData.selectedServer.Acc;

        }

        void editlogic()
        {
            if (checkBoxEdit.Checked == false)
            {
                //nastyluje vsechny textboxy v controlu
                foreach (var t in this.Controls)
                {
                    if (t.GetType() == typeof(TextBox))
                    {
                        TextBox tb = (TextBox)t;

                        tb.ReadOnly = true;
                        tb.BorderStyle = BorderStyle.None;
                    }
                }


                richTextBoxDetail.ReadOnly = true;
                textBoxWeb.Visible = false;
                linkLabel1.Visible = true;
                dataGridView1.ReadOnly = true;
                //icons
                pictureBox_Minus.Visible = false;
                pictureBox_DeleteServer.Visible = false;
     
            }
            else
            {

                //nastyluje vsechny textboxy v controlu
                foreach (var t in this.Controls)
                {
                    if (t.GetType() == typeof(TextBox))
                    {
                        TextBox tb = (TextBox)t;

                        tb.ReadOnly = false;
                        tb.BorderStyle = BorderStyle.FixedSingle;
                    }
                }

               
                richTextBoxDetail.ReadOnly = false;
                textBoxWeb.Visible = true;
                linkLabel1.Visible = false;
                dataGridView1.ReadOnly = false;
                //icons
                pictureBox_DeleteServer.Visible = true;
                pictureBox_Minus.Visible = true;

            }


        }



        private void button1_Click(object sender, EventArgs e)
        {
            XML.SaveXml();
            XML.ReadXMlFile();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int sloupec = dataGridView1.CurrentCell.ColumnIndex;
            string text = dataGridView1.CurrentRow.Cells[sloupec].Value.ToString();

            AppData.selectedServer.Acc[dataGridView1.CurrentCell.RowIndex].AccountName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            AppData.selectedServer.Acc[dataGridView1.CurrentCell.RowIndex].AccountPassword = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            //selectedServer.Acc[dataGridView1.CurrentCell.RowIndex].CharacterInfo = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();


        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                richTextBoxDetail.Text = AppData.selectedServer.Acc[dataGridView1.CurrentCell.RowIndex].CharacterInfo;
            }
            catch
            {

            }

        }

        private void textBoxRLM_TextChanged(object sender, EventArgs e)
        {
            AppData.selectedServer.RealmList = textBoxRLM.Text;
        }

        private void textBoxWeb_TextChanged(object sender, EventArgs e)
        {
            AppData.selectedServer.Website = textBoxWeb.Text;
            linkLabel1.Text = AppData.selectedServer.Website;
        }

        private void richTextBoxDetail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AppData.selectedServer.Acc[dataGridView1.CurrentCell.RowIndex].CharacterInfo = richTextBoxDetail.Text;
            }
            catch (System.NullReferenceException)
            {

            }

        }

        private void textBoxPversion_TextChanged(object sender, EventArgs e)
        {
            AppData.selectedServer.patchVersion = textBoxPversion.Text;
        }

        private void addServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddServerForm Fa = new AddServerForm();
            Fa.ShowDialog();

          //  comboBox1.Items.Clear();
           // refreshdb();


        }



 


        private void checkBoxEdit_CheckedChanged(object sender, EventArgs e)
        {
            editlogic();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1_logic.openWebPage(AppData.selectedServer.Website);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1_logic.runExe(AppData.selectedServer.ExePath);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBoxCFG.Text))
                ConfigEdit.confg(AppData.selectedDatadisk.datadiskName, AppData.selectedServer.RealmList, AppData.selectedServer.ConfigPath);
            else
                MessageBox.Show("Realm List path does not exist");
        }

        private void textBoxCFG_TextChanged(object sender, EventArgs e)
        {
            AppData.selectedServer.ConfigPath = textBoxCFG.Text;
        }

        private void textBoxExe_TextChanged(object sender, EventArgs e)
        {
            AppData.selectedServer.ExePath = textBoxExe.Text;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            {
                int sloupec = dataGridView1.CurrentCell.ColumnIndex;
                string text = dataGridView1.CurrentRow.Cells[sloupec].Value.ToString();
                if (text != "")
                    Clipboard.SetText(text);
                // MessageBox.Show(text);
            }
        }

        private void Event_KeyUp(object sender, KeyEventArgs e)
        {
            //richTextBoxDetail.ShortcutsEnabled = false;
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control && e.KeyCode == Keys.E)
            {
                if (checkBoxEdit.Checked == true)
                    checkBoxEdit.Checked = false;
                else
                    checkBoxEdit.Checked = true;


                e.SuppressKeyPress = true;
            }
            richTextBoxDetail.ShortcutsEnabled = true ;
        }
 
        private void dataGridView1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            {
               
                int sloupec = dataGridView1.CurrentCell.ColumnIndex;
                string text = dataGridView1.CurrentRow.Cells[sloupec].Value.ToString();
                if (text != "")
                    Clipboard.SetText(text);
            }
        }

        private void richTextBoxDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control && e.KeyCode == Keys.E)
            {
                richTextBoxDetail.ShortcutsEnabled = false;

                e.SuppressKeyPress = true;
            }
        }

        private void pictureBox1_Home_Click(object sender, EventArgs e)
        {
            AppData.selectedServer = null;
            this.Close();
        }

        private void pictureBoxPlus_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.AccountName = "";
            a.AccountPassword = "";
            a.CharacterInfo = "";
            AppData.selectedServer.Acc.Add(a);
            dataGridView1.DataSource = null;
          
            dataGridView1.DataSource = AppData.selectedServer.Acc;


            dataGridView1.ClearSelection();
            dataGridView1.Rows[dataGridView1.Rows.Count-1 ].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count-1].Cells[0]; 

            createtable();
        }

        private void pictureBoxMinus_Click(object sender, EventArgs e)
        {
            AppData.selectedServer.Acc.RemoveAt(dataGridView1.CurrentCell.RowIndex);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AppData.selectedServer.Acc;

            //select last index of datagrid
            dataGridView1.ClearSelection();
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
        }

        private void pictureBox_DeleteServer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want delete " + AppData.selectedServer.ServerName+ " server", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AppData.selectedDatadisk.servers.Remove(AppData.selectedServer);
                if (AppData.selectedDatadisk.servers.Count == 0)
                {
                    AppData.Database.Remove(AppData.selectedDatadisk);


                }
                this.Close();
            }



        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ServerName_TextChanged(object sender, EventArgs e)
        {
            AppData.selectedServer.ServerName = textBox_ServerName.Text;
        }
    }
}
