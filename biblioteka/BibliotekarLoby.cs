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
    public partial class BibliotekarLoby : Form
    {
        

        void popuniComboBox()
        {
            cbBibliotekari.Items.Clear();
            for (int i = 0; i < Bibliotekar.bibliotekari.Count; i++)
            {
                cbBibliotekari.Items.Add(Bibliotekar.bibliotekari[i].ID + " " + Bibliotekar.bibliotekari[i].Ime + " " + Bibliotekar.bibliotekari[i].Prezime);
            }
        }

        public BibliotekarLoby()
        {
            InitializeComponent();

            popuniComboBox();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaBibliotekar formaBibliotekar = new FormaBibliotekar();
            formaBibliotekar.ShowDialog();
            if(formaBibliotekar.DialogResult == DialogResult.OK)
            {
                string ime = formaBibliotekar.textBox1.Text;
                string prezime = formaBibliotekar.textBox2.Text;
                string pol = formaBibliotekar.comboBox4.SelectedItem.ToString();
                string status = formaBibliotekar.comboBox1.SelectedItem.ToString();
                int dan_rodj = Convert.ToInt32(formaBibliotekar.textBox5.Text);
                int mesec_rodj = Convert.ToInt32(formaBibliotekar.textBox6.Text);
                int god_rodj = Convert.ToInt32(formaBibliotekar.textBox3.Text);
                string ime_roditelja = formaBibliotekar.textBox7.Text;
                string jmbg = formaBibliotekar.textBox8.Text;
                string ulica_broj = formaBibliotekar.textBox9.Text;
                string grad = formaBibliotekar.textBox10.Text;
                int post_broj = Convert.ToInt32(formaBibliotekar.textBox11.Text);
                string tel = formaBibliotekar.textBox12.Text;
                string email = formaBibliotekar.textBox13.Text;
                string strucna_sprema = formaBibliotekar.textBox14.Text;
                string skolsko_zvanje = formaBibliotekar.textBox15.Text;
                string radna_poz = formaBibliotekar.textBox16.Text;
                DateTime datum_zaposlenja = formaBibliotekar.dateTimePicker1.Value;
                string username = formaBibliotekar.textBox18.Text;
                string password = formaBibliotekar.textBox19.Text;
                List<string> napomena = formaBibliotekar.textBox4.Lines.ToList();

                List<string> izdate_knige = new List<string>();
                List<string> primljene_knjige = new List<string>();

                //pravljenje objekta i dodavanje u listu
                Bibliotekar bib = new Bibliotekar(Convert.ToString(Bibliotekar.id), status, ime, prezime, pol, god_rodj, napomena, ime_roditelja, dan_rodj, mesec_rodj, jmbg, ulica_broj, grad, post_broj, tel, email, strucna_sprema, skolsko_zvanje, radna_poz, datum_zaposlenja, username, password, izdate_knige, primljene_knjige);
                Bibliotekar.bibliotekari.Add(bib);
            
                //rucno povecavanje id bibliotekara
                Bibliotekar.id++;

                Data.sacuvajBibliotekare();
                popuniComboBox();
            }
            
        }

        private void BibliotekarLoby_Load(object sender, EventArgs e)
        {




        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indeks = cbBibliotekari.SelectedIndex;

            if (indeks == -1) return;

            Bibliotekar b = Bibliotekar.bibliotekari[indeks];

            FormaBibliotekar formaBibliotekar = new FormaBibliotekar(b);
            formaBibliotekar.ShowDialog();
            if (formaBibliotekar.DialogResult == DialogResult.OK)
            {
                b.Ime = formaBibliotekar.textBox1.Text;
                b.Prezime = formaBibliotekar.textBox2.Text;
                b.Pol = formaBibliotekar.comboBox4.SelectedItem.ToString();
                b.Status = formaBibliotekar.comboBox1.SelectedItem.ToString();
                b.DanRodjenja = Convert.ToInt32(formaBibliotekar.textBox5.Text);
                b.MesecRodjenja = Convert.ToInt32(formaBibliotekar.textBox6.Text);
                b.GodinaRodjenja = Convert.ToInt32(formaBibliotekar.textBox3.Text);
                b.ImeJednogRoditelja = formaBibliotekar.textBox7.Text;
                b.JMBG = formaBibliotekar.textBox8.Text;
                b.AdresaUlicaBr = formaBibliotekar.textBox9.Text;
                b.AdresaGrad = formaBibliotekar.textBox10.Text;
                b.AdresaPostanskiBr = Convert.ToInt32(formaBibliotekar.textBox11.Text);
                b.Telefon = formaBibliotekar.textBox12.Text;
                b.Mail = formaBibliotekar.textBox13.Text;
                b.StepenStrucneSpreme = formaBibliotekar.textBox14.Text;
                b.SkolskoZvanje = formaBibliotekar.textBox15.Text;
                b.RadnaPozicija = formaBibliotekar.textBox16.Text;
                b.DatumZaposlenja = formaBibliotekar.dateTimePicker1.Value;
                b.KorisnickoIme = formaBibliotekar.textBox18.Text;
                b.Lozinka = formaBibliotekar.textBox19.Text;
                b.Napomena = formaBibliotekar.textBox4.Lines.ToList();

                List<string> izdate_knige = new List<string>();
                List<string> primljene_knjige = new List<string>();


                Data.sacuvajBibliotekare();
                popuniComboBox();
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
