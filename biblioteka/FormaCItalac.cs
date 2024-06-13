using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class FormaCItalac : Form
    {
        public FormaCItalac()
        {
            InitializeComponent();
        }

        private void btDodajCitaoca_Click(object sender, EventArgs e)
        {
            DodajCitaoca dodaj = new DodajCitaoca();
            dodaj.ShowDialog();
            dodaj.btLevo.Enabled = false;
            dodaj.btDesno.Enabled = false;
            dodaj.btSkrozLevo.Enabled = false;
            dodaj.btSkrozDesno.Enabled = false;
            if (dodaj.DialogResult == DialogResult.OK)
            {
                Citalac marko = new Citalac();
                marko.ID = (Data.listaCitalaca.Count + 1).ToString();
                marko.Status = dodaj.comboBox1.Text;
                marko.Ime = dodaj.textBox1.Text; 
                marko.Prezime = dodaj.textBox2.Text;
                marko.ImeJednogRoditelja = dodaj.textBox7.Text;
                marko.Pol = dodaj.comboBox4.Text;
                marko.DanRodjenja = int.Parse(dodaj.textBox5.Text);
                marko.MesecRodjenja = int.Parse(dodaj.textBox6.Text);
                marko.GodinaRodjenja = int.Parse(dodaj.textBox3.Text);
                marko.JMBG = dodaj.textBox8.Text;
                marko.AdresaUlicaBr = dodaj.textBox9.Text;
            }

        }

        private void btEditCitaoca_Click(object sender, EventArgs e)
        {

        }
    }
}
