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

namespace biblioteka
{
    public partial class FormPisac : Form
    {
     
        public FormPisac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> napomene = new List<string>();

            napomene = txtNapomenePisca.Lines.ToList<string>();

            int g = int.Parse(txtGodinaRodjenjaPisca.Text);
            Pisac p = new Pisac((Data.ListaPisaca.Count + 1).ToString(), cbStatusPisca.Text, txtImePisca.Text, txtPrezimePisca.Text, cbPol.Text, g, napomene);
            Data.DodajPisca(p);
            Data.SacuvajPisce();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPol_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
