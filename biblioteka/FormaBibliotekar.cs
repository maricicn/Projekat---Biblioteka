using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class FormaBibliotekar : Form
    {
        public FormaBibliotekar()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //skupljanje podataka iz svih onih textboxova
            string ime = textBox1.Text;
            string prezime = textBox2.Text;
            string pol = comboBox4.SelectedItem.ToString();
            int dan_rodj = Convert.ToInt32(textBox5.Text);
            int mesec_rodj = Convert.ToInt32(textBox6.Text);
            int god_rodj = Convert.ToInt32(textBox3.Text);
            string ime_roditelja = textBox7.Text;
            string jmbg = textBox8.Text;
            string ulica_broj = textBox9.Text;
            string grad = textBox10.Text;
            int post_broj = Convert.ToInt32(textBox11.Text);
            string tel = textBox12.Text;
            string email = textBox13.Text;
            string strucna_sprema = textBox14.Text;
            string skolsko_zvanje = textBox15.Text;
            string radna_poz = textBox16.Text;
            DateTime datum_zaposlenja = dateTimePicker1.Value;
            string username = textBox18.Text;
            string password = textBox19.Text;
            string napomena = textBox4.Text;

            //pravljenje streamwritera za fajl bibliotekari.csv
            StreamWriter pisac = new StreamWriter("Bibliotekari.csv", append: true);
            
            //upisivanje podataka u csv fajl
            pisac.WriteLine(Convert.ToString(Bibliotekar.id) + "," + "/" + "," + ime + "," + prezime + "," + pol + "," + Convert.ToString(god_rodj) + "," + napomena + "," + ime_roditelja + "," + Convert.ToString(dan_rodj) + "," + Convert.ToString(mesec_rodj) + "," + jmbg + "," + ulica_broj + "," + grad + "," + Convert.ToString(post_broj) + "," + tel + "," + email + "," + strucna_sprema + "," + skolsko_zvanje + "," + radna_poz + "," + Convert.ToString(datum_zaposlenja) + "," + username + "," + password);
            pisac.Close();

            //rucno povecavanje id bibliotekara
            Bibliotekar.id++;
        }

        private void FormaBibliotekar_Load(object sender, EventArgs e)
        {

        }
    }
}
