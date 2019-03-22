using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RLMS_NEW.Models;
using RLMS_NEW.Components;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace RLMS_NEW
{

    public partial class Home_screen : Form
    {
        int DTflowLayoutContendWidth = 0; // sirka obrazku s datadiskama

        public Home_screen()
        {
            InitializeComponent();

            
            if (AppData.Database == null)
            {
                try
                {
                    AppData.Database = new List<Datadisk>(XML.ReadXMlFile());
                    fillDatadisk();
                }
                catch
                {
                    MessageBox.Show("Nepodarilo se najit soubor s db");
                    AppData.Database = new List<Datadisk>();
                }
            }

            Form1_logic.CreatePicture(ref pictureBox_Home, 50, 50, pictureName: RLMS_NEW.Icon.home);
            Form1_logic.CreatePicture(ref pictureBox_AddServer, 50, 50, pictureName: RLMS_NEW.Icon.plus);
            Form1_logic.CreatePicture(ref pictureBox_DeleteDatadisk, 20, 20, pictureName: RLMS_NEW.Icon.minus);
            Form1_logic.CreatePicture(ref pictureBox_RenameDatadisk, 20, 20, pictureName: RLMS_NEW.Icon.pen);

        }

        private void fillDatadisk()
        {
            DTflowLayoutContendWidth = 0;
            DataDiskflowLayoutPanel1.Controls.Clear();

            pictureBox_AddServer.Location = new Point(10, 10);

            int width = 150;
            int height = 200;

            // DataDiskflowLayoutPanel1.Height = 100;

            //Zobrazení datadisku
            foreach (Datadisk d in AppData.Database)
            {

                //vytvorim tabulku 1x2
                TableLayoutPanel Table = new TableLayoutPanel();
                Table = HomeScreen_Logic.CreateTable(2, 1);


                //Vytvorim si novy label a vlozim dotabulky
                Label l = new Label();
                l = HomeScreen_Logic.CreateLabel(d.datadiskName, width, 70);
                Table.Controls.Add(l, 0, 1);

                //vytvorim obrazek + nastavim jeho vlastnosti
                RLMS_NEW.Components.PictureBoxDT picture = new PictureBoxDT();
                picture = HomeScreen_Logic.CreatePicture(width, height, d.datadiskName);

                picture.MouseClick += new MouseEventHandler(this.pictureDatadisk_Click); //po kliknuti na obrazek posle objekt metode p_Click  
                picture.MouseEnter += new EventHandler(this.pictureDatadisk_MouseEnter);
                picture.MouseLeave += new EventHandler(this.pictureDatadisk_MouseLeave);

                DTflowLayoutContendWidth += width + 15;
                DataDiskflowLayoutPanel1.Width = DTflowLayoutContendWidth;

                Table.Controls.Add(picture, 0, 0); //co chci pridat ,sloupec,radek
                DataDiskflowLayoutPanel1.Controls.Add(Table); //pridám tabulku do panelu
                Home_screen_Resize(null, null);


            }

        }




        //Zobrazení serveru
        private void fillServerToLayout(string datadisk)
        {
            serverButtonsLogic();
            ServersflowLayoutPanel1.Controls.Clear();
            label1.Text = AppData.selectedDatadisk.datadiskName;


            //select servers by datadisk
            List<Server> servers = null;
            foreach (Datadisk d in AppData.Database)
            {
                if (d.datadiskName == datadisk)
                    servers = d.servers;
            }

            foreach (Server s in servers)
            {
                //vytvorim tabulku 1x2
                TableLayoutPanel Table = new TableLayoutPanel();
                Table = HomeScreen_Logic.CreateTable(1, 2);

                //Vytvorim si novy label a vlozim dotabulky
                Label l = new Label();
                l = HomeScreen_Logic.CreateLabel(s.ServerName, 150, 40);
                l.TextAlign = ContentAlignment.TopLeft;
                l.MouseClick += new MouseEventHandler(this.labelServer_Click);
                Table.Controls.Add(l, 1, 0);


                //vytvorim obrazek + nastavim jeho vlastnosti
                RLMS_NEW.Components.PictureBoxDT picture = new PictureBoxDT() { Width = 16, Height = 16, SizeMode = PictureBoxSizeMode.StretchImage };
                picture = HomeScreen_Logic.CreatePicture(16, 16, s.ServerName, s.Website);
                picture.MouseClick += new MouseEventHandler(this.pictureServer_Click); //po kliknuti na obrazek posle objekt metode p_Click  
                Table.Controls.Add(picture, 0, 0); //co chci pridat ,sloupec,radek

                ServersflowLayoutPanel1.Controls.Add(Table); //pridám tabulku do panelu
            }


        }

        private void deleteDatadisk()
        {
            if (MessageBox.Show("Do you want ot delete datadisk: " + AppData.selectedDatadisk.datadiskName, "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AppData.Database.Remove(AppData.selectedDatadisk);
                fillDatadisk();
                datadiskButtonsLogic();
            }
        }

        private void serverButtonsLogic()
        {
            //button_Back.Visible = true;
            pictureBox_Home.Visible = true;
            panel1.Visible = false;
            ServersflowLayoutPanel1.Visible = true;
            label_line.Visible = true;

            //button_DeleteDatadisk.Visible = true;
            pictureBox_DeleteDatadisk.Visible = true;
            pictureBox_AddServer.Visible = true;
            //button_AddDatadisk.Visible = true;
            //  button_DatadiskRename.Visible = true;
            pictureBox_RenameDatadisk.Visible = true;
            pictureBox_AddServer.Location = new Point(86, 6);
            pictureBox_AddServer.Width = 20;
            pictureBox_AddServer.Height = 20;
            label1.Visible = true;
        }
        private void datadiskButtonsLogic()
        {
            
            
            ServersflowLayoutPanel1.Controls.Clear();
            //button_Back.Visible = false;
            pictureBox_Home.Visible = false;
            ServersflowLayoutPanel1.Visible = false;
            panel1.Visible = true;
            AppData.selectedDatadisk = null;
            deleteCurentDatadiskToolStripMenuItem.Visible = false;
            pictureBox_DeleteDatadisk.Visible = false;
            pictureBox_AddServer.Visible = true;
          

            //button_DatadiskRename.Visible = false;
            pictureBox_RenameDatadisk.Visible = false;
            label_line.Visible = false ;
            label1.Visible = false;


            pictureBox_AddServer.Location = new Point(10, 10);
            pictureBox_AddServer.Width = 50;
            pictureBox_AddServer.Height = 50;
            pictureBox_AddServer.Location = new Point(10, 10);
        }

        //event hendlers

        private void pictureDatadisk_MouseEnter(object sender, EventArgs e)
        {
            PictureBoxDT picture = (PictureBoxDT)sender;
            picture.BackColor = SystemColors.ControlLight;

        }
        private void pictureDatadisk_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxDT picture = (PictureBoxDT)sender;
            picture.BackColor = SystemColors.Control;

        }


        private void pictureDatadisk_Click(object sender, EventArgs e)
        {
            PictureBoxDT picture = (PictureBoxDT)sender;
            AppData.selectedDatadisk = AppData.Database.FirstOrDefault(d => d.datadiskName == picture.data);
            fillServerToLayout(picture.data);
            serverButtonsLogic();
        }

        private void pictureServer_Click(object sender, EventArgs e)
        {
            PictureBoxDT picture = (PictureBoxDT)sender;
            AppData.selectedServer = AppData.selectedDatadisk.servers.FirstOrDefault(s => s.ServerName == picture.data);
            Form1 f = new Form1();
            f.Show();
            fillServerToLayout(AppData.selectedDatadisk.datadiskName);
        }

        private void labelServer_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            AppData.selectedServer = AppData.selectedDatadisk.servers.FirstOrDefault(s => s.ServerName == l.Text);
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            f = null;
            Show();
            fillServerToLayout(AppData.selectedDatadisk.datadiskName);
        }

        private void Home_screen_Resize(object sender, EventArgs e)
        {
            label_line.Width = this.Width - 170;
            //drzi stejnou vzdalenost tlacitek od praveho okraje
            //PB button_DatadiskRename.Location = new Point(this.Width - button_DatadiskRename.Width - spaceFromRight, button_DatadiskRename.Location.Y);
            //PB button_AddDatadisk.Location = new Point(this.Width - button_AddDatadisk.Width - spaceFromRight, button_AddDatadisk.Location.Y);
            //button_Back.Location = new Point((this.Width - button_Back.Width - spaceFromRight) / 2, button_Back.Location.Y);
            //PB button_DeleteDatadisk.Location = new Point(this.Width - button_DeleteDatadisk.Width - spaceFromRight, button_DeleteDatadisk.Location.Y);

            //Udrzuje stejnou delku panelu s datadisky jako ma okno
            panel1.Width = this.Width - 60;

            //vycentruje ikony s datadiskem do prostred okna
            if (panel1.Width >= (DTflowLayoutContendWidth))
            { 
                int y = DataDiskflowLayoutPanel1.Location.Y;
                int x = (panel1.Width - DTflowLayoutContendWidth) / 2;
                DataDiskflowLayoutPanel1.Location = new Point(x, y);
            }

            //pri priliz velkem zmenseni posune ikony s datadisky do leva nahoru
            if (DTflowLayoutContendWidth > panel1.Width)
            {
                DataDiskflowLayoutPanel1.Width = panel1.Width;
                panel1.Height = this.Height - 70;
                DataDiskflowLayoutPanel1.Height = panel1.Height - 20;
                panel1.Location = new Point(0, 25);
            }
            else
            {
                panel1.Location = new Point(25, 179);
                panel1.Height = DataDiskflowLayoutPanel1.Height + 20;
            }

        }


        private void addServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddServerForm Fa = new AddServerForm();
            this.Hide();
            Fa.ShowDialog();
            this.Show();
            fillDatadisk();
            //  DataDiskflowLayoutPanel1.Controls.Add(AppData.Database.l)

        }

        private void Home_screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (AppData.Database.Count > 0)
                XML.SaveXml();
        }


        private void button_Back_Click(object sender, EventArgs e)
        {
         
        }

        private void wowDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.wowdb.com");
        }

        private void addonsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("https://wow.curseforge.com/addons");
        }

        private void wowheadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.wowhead.com");
        }

    

        private void button_DeleteDatadisk_Click(object sender, EventArgs e)
        {
         

        }

        private void button_AddDatadisk_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_AddServer_Click(object sender, EventArgs e)
        {
            AddServerForm Fa = new AddServerForm();
            this.Hide();
            Fa.ShowDialog();
            this.Show();
            if (AppData.selectedDatadisk.datadiskName == null)
            {
                fillDatadisk();
               
            }
           else
            {
                //fillDatadisk();
                fillServerToLayout(AppData.selectedDatadisk.datadiskName);
            }
        }

        private void pictureBox_DeleteDatadisk_Click(object sender, EventArgs e)
        {
            deleteDatadisk();
        }

        private void button_DatadiskRename_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Home_Click(object sender, EventArgs e)
        {
            datadiskButtonsLogic();
        }

        private void pictureBox_RenameDatadisk_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Write new name of datadisk", "Rename", "");
            name = name.Trim();
            if (name != "")
            {
                label1.Text = AppData.selectedDatadisk.datadiskName;
                AppData.selectedDatadisk.datadiskName = name;
                fillServerToLayout(AppData.selectedDatadisk.datadiskName);
            }
                
        


         

        }
    }
}
