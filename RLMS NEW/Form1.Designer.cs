namespace RLMS_NEW
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBoxRLM = new System.Windows.Forms.TextBox();
            this.textBoxWeb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPversion = new System.Windows.Forms.TextBox();
            this.LabelPatch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxDetail = new System.Windows.Forms.RichTextBox();
            this.checkBoxEdit = new System.Windows.Forms.CheckBox();
            this.textBoxExe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCFG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox_Home = new System.Windows.Forms.PictureBox();
            this.pictureBox_Plus = new System.Windows.Forms.PictureBox();
            this.pictureBox_Minus = new System.Windows.Forms.PictureBox();
            this.pictureBox_DeleteServer = new System.Windows.Forms.PictureBox();
            this.label_line = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_ServerName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DeleteServer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(21, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.Size = new System.Drawing.Size(516, 253);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "RealmList:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1155, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBoxRLM
            // 
            this.textBoxRLM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRLM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRLM.Location = new System.Drawing.Point(12, 455);
            this.textBoxRLM.Name = "textBoxRLM";
            this.textBoxRLM.Size = new System.Drawing.Size(386, 24);
            this.textBoxRLM.TabIndex = 15;
            this.textBoxRLM.TextChanged += new System.EventHandler(this.textBoxRLM_TextChanged);
            this.textBoxRLM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Event_KeyUp);
            // 
            // textBoxWeb
            // 
            this.textBoxWeb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWeb.Location = new System.Drawing.Point(399, 40);
            this.textBoxWeb.Name = "textBoxWeb";
            this.textBoxWeb.Size = new System.Drawing.Size(302, 24);
            this.textBoxWeb.TabIndex = 17;
            this.textBoxWeb.TextChanged += new System.EventHandler(this.textBoxWeb_TextChanged);
            this.textBoxWeb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Event_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(305, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Website:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxPversion
            // 
            this.textBoxPversion.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPversion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPversion.ForeColor = System.Drawing.Color.Black;
            this.textBoxPversion.Location = new System.Drawing.Point(452, 4);
            this.textBoxPversion.Name = "textBoxPversion";
            this.textBoxPversion.Size = new System.Drawing.Size(134, 24);
            this.textBoxPversion.TabIndex = 19;
            this.textBoxPversion.TextChanged += new System.EventHandler(this.textBoxPversion_TextChanged);
            this.textBoxPversion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Event_KeyUp);
            // 
            // LabelPatch
            // 
            this.LabelPatch.AutoSize = true;
            this.LabelPatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelPatch.Location = new System.Drawing.Point(305, 6);
            this.LabelPatch.Name = "LabelPatch";
            this.LabelPatch.Size = new System.Drawing.Size(141, 22);
            this.LabelPatch.TabIndex = 18;
            this.LabelPatch.Text = "Patch Version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(577, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Details:";
            // 
            // richTextBoxDetail
            // 
            this.richTextBoxDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxDetail.Location = new System.Drawing.Point(581, 173);
            this.richTextBoxDetail.Name = "richTextBoxDetail";
            this.richTextBoxDetail.Size = new System.Drawing.Size(524, 228);
            this.richTextBoxDetail.TabIndex = 21;
            this.richTextBoxDetail.Text = "";
            this.richTextBoxDetail.TextChanged += new System.EventHandler(this.richTextBoxDetail_TextChanged);
            this.richTextBoxDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBoxDetail_KeyDown);
            this.richTextBoxDetail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Event_KeyUp);
            // 
            // checkBoxEdit
            // 
            this.checkBoxEdit.AutoSize = true;
            this.checkBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxEdit.Location = new System.Drawing.Point(986, 17);
            this.checkBoxEdit.Name = "checkBoxEdit";
            this.checkBoxEdit.Size = new System.Drawing.Size(119, 26);
            this.checkBoxEdit.TabIndex = 22;
            this.checkBoxEdit.Text = "Enable edit";
            this.toolTip1.SetToolTip(this.checkBoxEdit, "CTR + E");
            this.checkBoxEdit.UseVisualStyleBackColor = true;
            this.checkBoxEdit.CheckedChanged += new System.EventHandler(this.checkBoxEdit_CheckedChanged);
            // 
            // textBoxExe
            // 
            this.textBoxExe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxExe.Location = new System.Drawing.Point(12, 589);
            this.textBoxExe.Name = "textBoxExe";
            this.textBoxExe.Size = new System.Drawing.Size(379, 24);
            this.textBoxExe.TabIndex = 24;
            this.textBoxExe.TextChanged += new System.EventHandler(this.textBoxExe_TextChanged);
            this.textBoxExe.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Event_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(8, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Exe Path:";
            // 
            // textBoxCFG
            // 
            this.textBoxCFG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCFG.Location = new System.Drawing.Point(12, 518);
            this.textBoxCFG.Name = "textBoxCFG";
            this.textBoxCFG.Size = new System.Drawing.Size(390, 24);
            this.textBoxCFG.TabIndex = 26;
            this.textBoxCFG.TextChanged += new System.EventHandler(this.textBoxCFG_TextChanged);
            this.textBoxCFG.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Event_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(8, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Config Path:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button3);
            this.panel9.Location = new System.Drawing.Point(-13, 695);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1136, 25);
            this.panel9.TabIndex = 39;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(550, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 24);
            this.button3.TabIndex = 39;
            this.button3.Text = "^";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(379, 40);
            this.button1.TabIndex = 40;
            this.button1.Text = "Lunch Wow";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(124, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 24);
            this.button2.TabIndex = 41;
            this.button2.Text = "Set Realmlist";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.Location = new System.Drawing.Point(399, 38);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 26);
            this.linkLabel1.TabIndex = 42;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox_Home
            // 
            this.pictureBox_Home.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Home.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Home.Name = "pictureBox_Home";
            this.pictureBox_Home.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Home.TabIndex = 43;
            this.pictureBox_Home.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox_Home, "Back");
            this.pictureBox_Home.Click += new System.EventHandler(this.pictureBox1_Home_Click);
            // 
            // pictureBox_Plus
            // 
            this.pictureBox_Plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Plus.Location = new System.Drawing.Point(21, 109);
            this.pictureBox_Plus.Name = "pictureBox_Plus";
            this.pictureBox_Plus.Size = new System.Drawing.Size(35, 35);
            this.pictureBox_Plus.TabIndex = 44;
            this.pictureBox_Plus.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox_Plus, "Add account");
            this.pictureBox_Plus.Click += new System.EventHandler(this.pictureBoxPlus_Click);
            // 
            // pictureBox_Minus
            // 
            this.pictureBox_Minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Minus.Location = new System.Drawing.Point(66, 109);
            this.pictureBox_Minus.Name = "pictureBox_Minus";
            this.pictureBox_Minus.Size = new System.Drawing.Size(35, 35);
            this.pictureBox_Minus.TabIndex = 45;
            this.pictureBox_Minus.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox_Minus, "Remove Account");
            this.pictureBox_Minus.Click += new System.EventHandler(this.pictureBoxMinus_Click);
            // 
            // pictureBox_DeleteServer
            // 
            this.pictureBox_DeleteServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_DeleteServer.Location = new System.Drawing.Point(913, 6);
            this.pictureBox_DeleteServer.Name = "pictureBox_DeleteServer";
            this.pictureBox_DeleteServer.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_DeleteServer.TabIndex = 46;
            this.pictureBox_DeleteServer.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox_DeleteServer, "Delete curent server");
            this.pictureBox_DeleteServer.Click += new System.EventHandler(this.pictureBox_DeleteServer_Click);
            // 
            // label_line
            // 
            this.label_line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_line.Location = new System.Drawing.Point(12, 71);
            this.label_line.Name = "label_line";
            this.label_line.Size = new System.Drawing.Size(1123, 1);
            this.label_line.TabIndex = 47;
            this.label_line.Text = "label1";
            // 
            // textBox_ServerName
            // 
            this.textBox_ServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_ServerName.Location = new System.Drawing.Point(68, 16);
            this.textBox_ServerName.Name = "textBox_ServerName";
            this.textBox_ServerName.Size = new System.Drawing.Size(219, 45);
            this.textBox_ServerName.TabIndex = 48;
            this.textBox_ServerName.TextChanged += new System.EventHandler(this.textBox_ServerName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1155, 685);
            this.Controls.Add(this.textBox_ServerName);
            this.Controls.Add(this.label_line);
            this.Controls.Add(this.pictureBox_DeleteServer);
            this.Controls.Add(this.pictureBox_Minus);
            this.Controls.Add(this.pictureBox_Plus);
            this.Controls.Add(this.pictureBox_Home);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.textBoxCFG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxExe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxEdit);
            this.Controls.Add(this.richTextBoxDetail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPversion);
            this.Controls.Add(this.LabelPatch);
            this.Controls.Add(this.textBoxWeb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRLM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Event_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DeleteServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBoxRLM;
        private System.Windows.Forms.TextBox textBoxWeb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPversion;
        private System.Windows.Forms.Label LabelPatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxDetail;
        private System.Windows.Forms.CheckBox checkBoxEdit;
        private System.Windows.Forms.TextBox textBoxExe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCFG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox_Home;
        private System.Windows.Forms.PictureBox pictureBox_Plus;
        private System.Windows.Forms.PictureBox pictureBox_Minus;
        private System.Windows.Forms.PictureBox pictureBox_DeleteServer;
        private System.Windows.Forms.Label label_line;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox_ServerName;
    }
}

