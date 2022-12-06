namespace Osztalyprogram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Hozzaadbutton = new System.Windows.Forms.Button();
            this.Mentesbutton = new System.Windows.Forms.Button();
            this.Torlesbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vezeteknevbox = new System.Windows.Forms.TextBox();
            this.keresztnevbox = new System.Windows.Forms.TextBox();
            this.szulidobox = new System.Windows.Forms.TextBox();
            this.osztalybox = new System.Windows.Forms.TextBox();
            this.telefonszambox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VezeteknevColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeresztnevColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SzuletesiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OsztalyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonszamColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újHozzáadásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkeztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Kilepesbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.emailbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hozzaadbutton
            // 
            this.Hozzaadbutton.Location = new System.Drawing.Point(23, 411);
            this.Hozzaadbutton.Name = "Hozzaadbutton";
            this.Hozzaadbutton.Size = new System.Drawing.Size(126, 32);
            this.Hozzaadbutton.TabIndex = 0;
            this.Hozzaadbutton.Text = "Új hozzáadása";
            this.Hozzaadbutton.UseVisualStyleBackColor = true;
            this.Hozzaadbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mentesbutton
            // 
            this.Mentesbutton.Location = new System.Drawing.Point(173, 411);
            this.Mentesbutton.Name = "Mentesbutton";
            this.Mentesbutton.Size = new System.Drawing.Size(105, 32);
            this.Mentesbutton.TabIndex = 0;
            this.Mentesbutton.Text = "Mentés";
            this.Mentesbutton.UseVisualStyleBackColor = true;
            this.Mentesbutton.Click += new System.EventHandler(this.Mentesbutton_Click);
            // 
            // Torlesbutton
            // 
            this.Torlesbutton.Location = new System.Drawing.Point(306, 411);
            this.Torlesbutton.Name = "Torlesbutton";
            this.Torlesbutton.Size = new System.Drawing.Size(105, 32);
            this.Torlesbutton.TabIndex = 0;
            this.Torlesbutton.Text = "Törlés";
            this.Torlesbutton.UseVisualStyleBackColor = true;
            this.Torlesbutton.Click += new System.EventHandler(this.Torlesbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vezetéknév: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keresztnév: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Születési idő:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Osztály:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(651, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telefonszám: ";
            // 
            // vezeteknevbox
            // 
            this.vezeteknevbox.Location = new System.Drawing.Point(123, 36);
            this.vezeteknevbox.Name = "vezeteknevbox";
            this.vezeteknevbox.Size = new System.Drawing.Size(204, 22);
            this.vezeteknevbox.TabIndex = 2;
            // 
            // keresztnevbox
            // 
            this.keresztnevbox.Location = new System.Drawing.Point(123, 70);
            this.keresztnevbox.Name = "keresztnevbox";
            this.keresztnevbox.Size = new System.Drawing.Size(204, 22);
            this.keresztnevbox.TabIndex = 2;
            // 
            // szulidobox
            // 
            this.szulidobox.Location = new System.Drawing.Point(441, 39);
            this.szulidobox.Name = "szulidobox";
            this.szulidobox.Size = new System.Drawing.Size(204, 22);
            this.szulidobox.TabIndex = 2;
            // 
            // osztalybox
            // 
            this.osztalybox.Location = new System.Drawing.Point(441, 72);
            this.osztalybox.Name = "osztalybox";
            this.osztalybox.Size = new System.Drawing.Size(204, 22);
            this.osztalybox.TabIndex = 2;
            // 
            // telefonszambox
            // 
            this.telefonszambox.Location = new System.Drawing.Point(754, 39);
            this.telefonszambox.Name = "telefonszambox";
            this.telefonszambox.Size = new System.Drawing.Size(204, 22);
            this.telefonszambox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VezeteknevColumn,
            this.KeresztnevColumn,
            this.SzuletesiColumn,
            this.OsztalyColumn,
            this.TelefonszamColumn,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(23, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(986, 262);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // VezeteknevColumn
            // 
            this.VezeteknevColumn.HeaderText = "Vezetéknév";
            this.VezeteknevColumn.Name = "VezeteknevColumn";
            this.VezeteknevColumn.ReadOnly = true;
            this.VezeteknevColumn.Width = 120;
            // 
            // KeresztnevColumn
            // 
            this.KeresztnevColumn.HeaderText = "Keresztnév";
            this.KeresztnevColumn.Name = "KeresztnevColumn";
            this.KeresztnevColumn.ReadOnly = true;
            this.KeresztnevColumn.Width = 120;
            // 
            // SzuletesiColumn
            // 
            this.SzuletesiColumn.HeaderText = "Születési idő";
            this.SzuletesiColumn.Name = "SzuletesiColumn";
            this.SzuletesiColumn.ReadOnly = true;
            this.SzuletesiColumn.Width = 120;
            // 
            // OsztalyColumn
            // 
            this.OsztalyColumn.HeaderText = "Osztály";
            this.OsztalyColumn.Name = "OsztalyColumn";
            this.OsztalyColumn.ReadOnly = true;
            this.OsztalyColumn.Width = 120;
            // 
            // TelefonszamColumn
            // 
            this.TelefonszamColumn.HeaderText = "Telefonszám";
            this.TelefonszamColumn.Name = "TelefonszamColumn";
            this.TelefonszamColumn.ReadOnly = true;
            this.TelefonszamColumn.Width = 120;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "E-mail";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.szerkeztésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újHozzáadásaToolStripMenuItem,
            this.mentésToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(43, 24);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // újHozzáadásaToolStripMenuItem
            // 
            this.újHozzáadásaToolStripMenuItem.Name = "újHozzáadásaToolStripMenuItem";
            this.újHozzáadásaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.újHozzáadásaToolStripMenuItem.Text = "Új hozzáadása";
            this.újHozzáadásaToolStripMenuItem.Click += new System.EventHandler(this.újHozzáadásaToolStripMenuItem_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.mentésToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // szerkeztésToolStripMenuItem
            // 
            this.szerkeztésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.törlésToolStripMenuItem});
            this.szerkeztésToolStripMenuItem.Name = "szerkeztésToolStripMenuItem";
            this.szerkeztésToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.szerkeztésToolStripMenuItem.Text = "Szerkeztés";
            this.szerkeztésToolStripMenuItem.Click += new System.EventHandler(this.szerkeztésToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // Kilepesbutton
            // 
            this.Kilepesbutton.Location = new System.Drawing.Point(428, 411);
            this.Kilepesbutton.Name = "Kilepesbutton";
            this.Kilepesbutton.Size = new System.Drawing.Size(105, 32);
            this.Kilepesbutton.TabIndex = 0;
            this.Kilepesbutton.Text = "Kilépés";
            this.Kilepesbutton.UseVisualStyleBackColor = true;
            this.Kilepesbutton.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "E-mail: ";
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(754, 70);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(204, 22);
            this.emailbox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 498);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.telefonszambox);
            this.Controls.Add(this.osztalybox);
            this.Controls.Add(this.szulidobox);
            this.Controls.Add(this.keresztnevbox);
            this.Controls.Add(this.vezeteknevbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kilepesbutton);
            this.Controls.Add(this.Torlesbutton);
            this.Controls.Add(this.Mentesbutton);
            this.Controls.Add(this.Hozzaadbutton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Osztály";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hozzaadbutton;
        private System.Windows.Forms.Button Mentesbutton;
        private System.Windows.Forms.Button Torlesbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vezeteknevbox;
        private System.Windows.Forms.TextBox keresztnevbox;
        private System.Windows.Forms.TextBox szulidobox;
        private System.Windows.Forms.TextBox osztalybox;
        private System.Windows.Forms.TextBox telefonszambox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újHozzáadásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkeztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.Button Kilepesbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn VezeteknevColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeresztnevColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SzuletesiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OsztalyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonszamColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

