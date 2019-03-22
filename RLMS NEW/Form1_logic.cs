using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RLMS_NEW
{
   public class Form1_logic
    {


        /*
        public DataGridView CreateTable(string realmlist, string website,string exePath,string configPath,string website) {

            DataGridView dw = new DataGridView();
            dw.Columns[0].Name = "AccountName";
            dw.Columns[0].HeaderText = "Acount";
            dw.Columns[0].DataPropertyName = "AccountName";
            dw.Columns[0].MinimumWidth = 200;
            dw.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dw.Columns[1].HeaderText = "Password";
            dw.Columns[1].Name = "AccountPassword";
            dw.Columns[1].DataPropertyName = "AccountPassword";
            dw.Columns[1].MinimumWidth = 183;

            /* dataGridView1.Columns[2].Name = "CharacterInfo";
             dataGridView1.Columns[2].HeaderText = "Postavy";
             dataGridView1.Columns[2].DataPropertyName = "CharacterInfo";
             dataGridView1.Columns[2].MinimumWidth = 314;
            dataGridView1.DataSource = selectedServer.Acc;
            */


        public static PictureBox CreatePicture(ref PictureBox picture ,int width, int height, string webadress = null, string pictureName=null)
        {
         //  PictureBox picture = new PictureBox() { Width = width, Height = height, SizeMode = PictureBoxSizeMode.StretchImage };
       
            picture.Cursor = Cursors.Hand;

            picture.Width = width;
            picture.Height = height;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
         

            if (webadress != null)
            {
                //stahnuti ikony ze serveru

                try
                {
                    string[] hostParts = new System.Uri(webadress).Host.Split('.');
                    string domain = String.Join(".", hostParts.Skip(Math.Max(0, hostParts.Length - 2)).Take(2));
                    //PictureBoxDT img = new PictureBoxDT();
                    Uri favicon = new Uri("http://www.google.com/s2/favicons?domain=" + domain, UriKind.Absolute);
                    webadress = favicon.ToString();
                    picture.Load(webadress);
                }
                catch
                {
                    // adress = "./icons/error.png";
                    picture.ImageLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/icons/error.png";

                }

                //  picture.Load(adress);

            }
            else
            {
             
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/icons/"+pictureName))
                    picture.ImageLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/icons/"+ pictureName;
                else
                    picture.ImageLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/icons/error.png";

       
            }
            //Vytvořeni obrazku
      
            return picture;

        }



        public static void openWebPage(string adress)
        {
            try
            {
                if ((!adress.ToLower().Contains("http://")) && (!adress.ToLower().Contains("https://")))
                {
                    Process.Start("http://" + adress);
                }
                else
                    Process.Start(adress);
            }
            catch
            {
                MessageBox.Show("Website is not correct");
            }


        }

        public static void runExe(string path)
        {
            if (File.Exists(path))
                Process.Start(path);
            else
                MessageBox.Show("Check the wow.exe path");

        }
    }



}

