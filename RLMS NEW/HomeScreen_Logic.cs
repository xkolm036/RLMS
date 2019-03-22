using RLMS_NEW.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RLMS_NEW
{
    public class HomeScreen_Logic
    {
        public static TableLayoutPanel CreateTable(int RowCount, int ColumnCount)
        {
            //vytvorim tabulku RowCount x ColumnCount
            TableLayoutPanel Table = new TableLayoutPanel();
            Table.AutoSize = true;
            Table.Font = new Font(Table.Font.FontFamily, 16);
            Table.ColumnCount = 2;
            Table.RowCount = 1;
            Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Table.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddRows;

            return Table;
        }

        public static Label CreateLabel(string text, int width, int height)
        {
            Label l = new Label();
            l.Text = text;
            l.Anchor = AnchorStyles.None;
            l.Width = 150;
            l.Height = 40;
            l.TextAlign = ContentAlignment.BottomCenter;
            l.Cursor = Cursors.Hand;
         
            return l;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="data"></param>
        /// <param name="adress">Adress==null -> default icon from pc</param>
        /// <returns></returns>
        public static PictureBoxDT CreatePicture(int width, int height, string data, string adress = null)
        {
            RLMS_NEW.Components.PictureBoxDT picture = new PictureBoxDT() { Width = width, Height = height, SizeMode = PictureBoxSizeMode.StretchImage };

            picture.data = data;
            picture.Cursor = Cursors.Hand;


            if (adress != null)
            {
                //stahnuti ikony ze serveru

                try
                {
                    string[] hostParts = new System.Uri(adress).Host.Split('.');
                    string domain = String.Join(".", hostParts.Skip(Math.Max(0, hostParts.Length - 2)).Take(2));
                    //PictureBoxDT img = new PictureBoxDT();
                    Uri favicon = new Uri("http://www.google.com/s2/favicons?domain=" + domain, UriKind.Absolute);
                    adress = favicon.ToString();
                    picture.Load(adress);
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
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/icons/" + data + ".png"))
                    picture.ImageLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/icons/" + data + ".png";
                else
                    picture.ImageLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/icons/error.png";

            }
            //Vytvořeni obrazku


            return picture;

        }





    }
}
