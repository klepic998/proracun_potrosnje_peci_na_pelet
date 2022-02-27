using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pelet_Ivana
{
    public partial class Podesavanja : Form
    {
        public Podesavanja()
        {
            InitializeComponent();

            txtBoxRadP1.Text = Properties.Settings.Default.radP1.ToString();
            txtBoxRadP2.Text = Properties.Settings.Default.radP2.ToString();
            txtBoxRadP3.Text = Properties.Settings.Default.radP3.ToString();
            txtBoxPauzaP1.Text = Properties.Settings.Default.pauzaP1.ToString();
            txtBoxPauzaP2.Text = Properties.Settings.Default.radP2.ToString();
            txtBoxPauzaP3.Text = Properties.Settings.Default.radP3.ToString();
            txtBoxKalorijskaMocPeleta.Text = Properties.Settings.Default.kalorijskaMocPeleta.ToString();
            txtBoxKolicinaPeletaUMin.Text = Properties.Settings.Default.kolicinaPeletaUMin.ToString();
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {

                Properties.Settings.Default.radP1 = Convert.ToDouble(txtBoxRadP1.Text);
                Properties.Settings.Default.radP2 = Convert.ToDouble(txtBoxRadP2.Text);
                Properties.Settings.Default.radP3 = Convert.ToDouble(txtBoxRadP3.Text);
                Properties.Settings.Default.pauzaP1 = Convert.ToDouble(txtBoxPauzaP1.Text);
                Properties.Settings.Default.pauzaP2 = Convert.ToDouble(txtBoxPauzaP2.Text);
                Properties.Settings.Default.pauzaP3 = Convert.ToDouble(txtBoxPauzaP3.Text);
                Properties.Settings.Default.kalorijskaMocPeleta = Convert.ToDouble(txtBoxKalorijskaMocPeleta.Text);
                Properties.Settings.Default.kolicinaPeletaUMin = Convert.ToDouble(txtBoxKolicinaPeletaUMin.Text);
                Properties.Settings.Default.Save();
                MessageBox.Show("Uspjesno ste sacuvali podatke", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Greska prilikom unosa", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Box_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxRadP1.Text == "" || txtBoxRadP2.Text == "" || txtBoxRadP3.Text == "" || txtBoxPauzaP1.Text == "" || txtBoxPauzaP2.Text == "" || txtBoxPauzaP3.Text == "" || txtBoxKalorijskaMocPeleta.Text == "" || txtBoxKolicinaPeletaUMin.Text == "")
            {
                btnSnimi.Enabled = false;
            }
            else
                btnSnimi.Enabled = true;

        }


    }
}
