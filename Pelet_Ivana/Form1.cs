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
    public partial class Form1 : Form
    {
        double potrosnjaPoSatu;
        double radZaIzabranuSnagu;
        double pauzaZaIzabranuSnagu;
        double snagaPeci;
        double potrosnjaPoDanu;
        

        public Form1()
        {
            InitializeComponent();
            lblVrijeme.Text = DateTime.Now.ToString("dd.MMMM yyyy. HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblVrijeme.Text =  DateTime.Now.ToString("dd.MMMM yyyy. HH:mm:ss");
        }

        private void podesavanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Podesavanja pod = new Podesavanja();
            pod.ShowDialog();
        }

        private void izlazIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Box1_TextChanged(object sender, EventArgs e)
        {
            if (cmbBoxIzaberiteSnagu.SelectedItem != "" && txtBoxBrSatiRadaUDanu.Text != "")
            {
                btnIzracunaj.Enabled = true;
            }
            else btnIzracunaj.Enabled = false;

        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            if (cmbBoxIzaberiteSnagu.SelectedItem == "P1")
            {
                radZaIzabranuSnagu = Properties.Settings.Default.radP1;
                pauzaZaIzabranuSnagu = Properties.Settings.Default.pauzaP1;
            }
            else if (cmbBoxIzaberiteSnagu.SelectedItem == "P2")
            {
                radZaIzabranuSnagu = Properties.Settings.Default.radP2;
                pauzaZaIzabranuSnagu = Properties.Settings.Default.pauzaP2;
            }
            else if (cmbBoxIzaberiteSnagu.SelectedItem == "P3")
            {
                radZaIzabranuSnagu = Properties.Settings.Default.radP3;
                pauzaZaIzabranuSnagu = Properties.Settings.Default.pauzaP3;
            }

            potrosnjaPoSatu = (Properties.Settings.Default.kolicinaPeletaUMin / 1000) * radZaIzabranuSnagu * 60 / (radZaIzabranuSnagu + pauzaZaIzabranuSnagu);
            snagaPeci = potrosnjaPoSatu * Properties.Settings.Default.kalorijskaMocPeleta;
            potrosnjaPoDanu = potrosnjaPoSatu * Convert.ToDouble(txtBoxBrSatiRadaUDanu.Text);

            lblSnagakWh.Text = Math.Round(snagaPeci, 2).ToString();
            lblPotrosnjaKgH.Text = Math.Round(potrosnjaPoSatu, 2).ToString();
            lblPotrosnjaKgDan.Text = Math.Round(potrosnjaPoDanu, 2).ToString();
        }



    }
}
