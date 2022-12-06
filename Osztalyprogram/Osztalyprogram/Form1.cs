using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Osztalyprogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ujhozza();
            
        }
        private void ujhozza()
        {
            if (string.IsNullOrEmpty(vezeteknevbox.Text) || string.IsNullOrEmpty(keresztnevbox.Text) ||
               string.IsNullOrEmpty(szulidobox.Text) || string.IsNullOrEmpty(osztalybox.Text) ||
               string.IsNullOrEmpty(telefonszambox.Text) || string.IsNullOrEmpty(emailbox.Text))
            {
                vezeteknevbox.Focus();
                MessageBox.Show("Minden mező kitöltése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                dataGridView1.Rows.Add(vezeteknevbox.Text, keresztnevbox.Text, szulidobox.Text, osztalybox.Text, telefonszambox.Text, emailbox.Text);
            }



            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kilepes();
        }



        // Kilépés methoodus létrehozása
    
        private void Kilepes()
        {
            DialogResult kilep;
            kilep = MessageBox.Show("Valóban ki szeretne lépni ?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );
            if (kilep == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kilepes();
        }

        private void Torlesbutton_Click(object sender, EventArgs e)
        {
            Torles();
        }


        //Törlés methoodus létrehozása

        private void Torles()
        {
            foreach (DataGridViewRow data in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(data.Index);
            }
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Torles();
        }

        private void frissítésToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void szerkeztésToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Mentesbutton_Click(object sender, EventArgs e)
        {
            Mentes();
            
            
        }
        // Mentés
        private void Mentes()
        {
            if (string.IsNullOrEmpty(vezeteknevbox.Text) || string.IsNullOrEmpty(keresztnevbox.Text) ||
               string.IsNullOrEmpty(szulidobox.Text) || string.IsNullOrEmpty(osztalybox.Text) ||
               string.IsNullOrEmpty(telefonszambox.Text) || string.IsNullOrEmpty(emailbox.Text))
            {
                {
                    vezeteknevbox.Focus();
                    MessageBox.Show("Minden mező kitöltése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else {
            StreamWriter iras = new StreamWriter(Application.StartupPath + "\\Diak\\" + vezeteknevbox.Text + " " + keresztnevbox.Text + ".xml");
            iras.WriteLine("Vezetéknév: " + vezeteknevbox.Text);
            iras.WriteLine("Keresztnév: " + keresztnevbox.Text);
            iras.WriteLine("Születési idő: " + szulidobox.Text);
            iras.WriteLine("Osztály: " + osztalybox.Text);
            iras.WriteLine("Telefonszám: " + telefonszambox.Text);
            iras.WriteLine("E-mail cím: " + emailbox.Text);
            iras.Close();
            MessageBox.Show("Sikeres mentés!", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vezeteknevbox.Clear();
                keresztnevbox.Clear();
                szulidobox.Clear();
                osztalybox.Clear();
                telefonszambox.Clear();
                emailbox.Clear();

            }

        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mentes();
        }

        private void újHozzáadásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ujhozza();
        }
    }
}
