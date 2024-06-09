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
        public int indeksPronadjenogBibliotekara;

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
            formaBibliotekar.btDesno.Hide();
            formaBibliotekar.btLevo.Hide();
            if (formaBibliotekar.DialogResult == DialogResult.OK)
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
                Bibliotekar bib = new Bibliotekar(Convert.ToString(Bibliotekar.bibliotekari.Count+1), status, ime, prezime, pol, god_rodj, napomena, ime_roditelja, dan_rodj, mesec_rodj, jmbg, ulica_broj, grad, post_broj, tel, email, strucna_sprema, skolsko_zvanje, radna_poz, datum_zaposlenja, username, password, izdate_knige, primljene_knjige);
                Bibliotekar.bibliotekari.Add(bib);
            
                //rucno povecavanje id bibliotekara
                //Bibliotekar.id++;

                Data.sacuvajBibliotekare();
                popuniComboBox();
            }
            
        }

        private void BibliotekarLoby_Load(object sender, EventArgs e)
        {




        }







        private void button2_Click(object sender, EventArgs e)
        {
            int indeks = cbBibliotekari.SelectedIndex + 1;

            if (indeks == 0)
            {
                indeks = indeksPronadjenogBibliotekara;
            }

            if (indeks != 0)
            {
                Bibliotekar b = Bibliotekar.bibliotekari[indeks - 1];

                FormaBibliotekar formaBibliotekar = new FormaBibliotekar(b, indeks);
                formaBibliotekar.ShowDialog();
                formaBibliotekar.btDesno.Show();
                formaBibliotekar.btLevo.Show();
                if (formaBibliotekar.DialogResult == DialogResult.OK)
                {
                    Bibliotekar b2 = Data.pomeranjeBibliotekara(formaBibliotekar.indeks);

                    b2.Ime = formaBibliotekar.textBox1.Text;
                    b2.Prezime = formaBibliotekar.textBox2.Text;
                    b2.Pol = formaBibliotekar.comboBox4.SelectedItem.ToString();
                    b2.Status = formaBibliotekar.comboBox1.SelectedItem.ToString();
                    b2.DanRodjenja = Convert.ToInt32(formaBibliotekar.textBox5.Text);
                    b2.MesecRodjenja = Convert.ToInt32(formaBibliotekar.textBox6.Text);
                    b2.GodinaRodjenja = Convert.ToInt32(formaBibliotekar.textBox3.Text);
                    b2.ImeJednogRoditelja = formaBibliotekar.textBox7.Text;
                    b2.JMBG = formaBibliotekar.textBox8.Text;
                    b2.AdresaUlicaBr = formaBibliotekar.textBox9.Text;
                    b2.AdresaGrad = formaBibliotekar.textBox10.Text;
                    b2.AdresaPostanskiBr = Convert.ToInt32(formaBibliotekar.textBox11.Text);
                    b2.Telefon = formaBibliotekar.textBox12.Text;
                    b2.Mail = formaBibliotekar.textBox13.Text;
                    b2.StepenStrucneSpreme = formaBibliotekar.textBox14.Text;
                    b2.SkolskoZvanje = formaBibliotekar.textBox15.Text;
                    b2.RadnaPozicija = formaBibliotekar.textBox16.Text;
                    b2.DatumZaposlenja = formaBibliotekar.dateTimePicker1.Value;
                    b2.KorisnickoIme = formaBibliotekar.textBox18.Text;
                    b2.Lozinka = formaBibliotekar.textBox19.Text;
                    b2.Napomena = formaBibliotekar.textBox4.Lines.ToList();

                    List<string> izdate_knige = new List<string>();
                    List<string> primljene_knjige = new List<string>();


                    Data.sacuvajBibliotekare();
                    popuniComboBox();
                }
            
            }
            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            string ime = "";
            string prezime = "";
            bool predji = false;
            for (int i = 0; i < txtPretraga.Text.Length; i++)
            {
                if (txtPretraga.Text[i].Equals(' '))
                {
                    predji = true;
                    continue;
                }
                if (predji == false)
                {
                    ime += txtPretraga.Text[i];
                }
                if (predji == true)
                {
                    prezime += txtPretraga.Text[i];
                }
            }



            for (int i = 0; i < Bibliotekar.bibliotekari.Count; i++)
            {
                if (ime == Bibliotekar.bibliotekari[i].Ime && prezime == Bibliotekar.bibliotekari[i].Prezime)
                {
                    indeksPronadjenogBibliotekara = int.Parse(Bibliotekar.bibliotekari[i].ID);
                    lblPronadjenBibliotekar.Text = Bibliotekar.bibliotekari[i].ID + " " + ime + " " + prezime;
                }
            }

        }
    }
}
