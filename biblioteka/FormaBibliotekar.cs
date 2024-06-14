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

        public int indeks;

        
        public FormaBibliotekar()
        {
            InitializeComponent();
            btSkrozLevo.Visible = false;
            btSkrozDesno.Visible = false;
            btLevo.Visible = false;
            btDesno.Visible = false;
        }

        public FormaBibliotekar(Bibliotekar b, int indeks)
        {
            InitializeComponent();
            btSkrozLevo.Visible = true;
            btSkrozDesno.Visible = true;
            btLevo.Visible = true;
            btSkrozDesno.Visible = true;
            /*string ime = textBox1.Text;
            string prezime = textBox2.Text;
            string pol = comboBox4.SelectedItem.ToString();
            string status = comboBox1.SelectedItem.ToString();
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
            List<string> napomena = textBox4.Lines.ToList();*/
            this.indeks = indeks;
            textBox1.Text = b.Ime;
            textBox2.Text = b.Prezime;
            comboBox4.Text = b.Pol;
            comboBox1.Text = b.Status;
            textBox5.Text = b.DanRodjenja.ToString();
            textBox6.Text = b.MesecRodjenja.ToString();
            textBox3.Text = b.GodinaRodjenja.ToString();
            textBox7.Text = b.ImeJednogRoditelja;
            textBox8.Text = b.JMBG;
            textBox9.Text = b.AdresaUlicaBr;
            textBox10.Text = b.AdresaGrad;
            textBox11.Text = b.AdresaPostanskiBr.ToString();
            textBox12.Text = b.Telefon;
            textBox13.Text = b.Mail;
            textBox14.Text = b.StepenStrucneSpreme;
            textBox15.Text = b.SkolskoZvanje;
            textBox16.Text = b.RadnaPozicija;
            dateTimePicker1.Value = b.DatumZaposlenja;
            textBox18.Text = b.KorisnickoIme;
            textBox19.Text = b.Lozinka;
            textBox4.Lines = b.Napomena.ToArray();


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

        public string Text(List<string> lista)
        {
            string rez = "";
            foreach (string s in lista)
            {
                rez = rez + s;
            }
            return rez;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*//skupljanje podataka iz svih onih textboxova
            string ime = textBox1.Text;
            string prezime = textBox2.Text;
            string pol = comboBox4.SelectedItem.ToString();
            string status = comboBox1.SelectedItem.ToString();
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
            List<string> napomena = textBox4.Lines.ToList();

            List<string> izdate_knige = new List<string>();
            List<string> primljene_knjige = new List<string>();

            //pravljenje streamwritera za fajl bibliotekari.csv
            StreamWriter pisac = new StreamWriter("Bibliotekari.csv", append: true);
            
            //upisivanje podataka u csv fajl
            pisac.WriteLine(Convert.ToString(Bibliotekar.id) + "," + status + "," + ime + "," + prezime + "," + pol + "," + Convert.ToString(god_rodj) + "," + Text(napomena) + "," + ime_roditelja + "," + Convert.ToString(dan_rodj) + "," + Convert.ToString(mesec_rodj) + "," + jmbg + "," + ulica_broj + "," + grad + "," + Convert.ToString(post_broj) + "," + tel + "," + email + "," + strucna_sprema + "," + skolsko_zvanje + "," + radna_poz + "," + Convert.ToString(datum_zaposlenja) + "," + username + "," + password);
            pisac.Close();

            //pravljenje objekta i dodavanje u listu
            Bibliotekar bib = new Bibliotekar(Convert.ToString(Bibliotekar.id), status, ime, prezime, pol, god_rodj, napomena, ime_roditelja, dan_rodj, mesec_rodj, jmbg, ulica_broj, grad, post_broj, tel, email, strucna_sprema, skolsko_zvanje, radna_poz, datum_zaposlenja, username, password, izdate_knige, primljene_knjige);
            Bibliotekar.bibliotekari.Add(bib);
            
            //rucno povecavanje id bibliotekara
            Bibliotekar.id++;*/
            
        }

        private void FormaBibliotekar_Load(object sender, EventArgs e)
        {

        }

        private void btDesno_Click(object sender, EventArgs e)
        {
            /*indeks++;
            if (indeks > Data.ListaPisaca.Count) indeks = 1;
            Pisac p = Data.pomeranjePisca(indeks);
            cbStatusPisca.Text = p.Status;
            txtImePisca.Text = p.Ime;
            txtPrezimePisca.Text = p.Prezime;
            cbPol.Text = p.Pol;
            txtGodinaRodjenjaPisca.Text = p.GodinaRodjenja.ToString();

            txtNapomenePisca.Lines = p.Napomena.ToArray();*/
            if (Bibliotekar.bibliotekari.Count > 1)
            {
                indeks++;
                if (indeks > Bibliotekar.bibliotekari.Count) indeks = 1;
                Bibliotekar b = Data.pomeranjeBibliotekara(indeks);
                textBox1.Text = b.Ime;
                textBox2.Text = b.Prezime;
                comboBox4.Text = b.Pol;
                comboBox1.Text = b.Status;
                textBox5.Text = b.DanRodjenja.ToString();
                textBox6.Text = b.MesecRodjenja.ToString();
                textBox3.Text = b.GodinaRodjenja.ToString();
                textBox7.Text = b.ImeJednogRoditelja;
                textBox8.Text = b.JMBG;
                textBox9.Text = b.AdresaUlicaBr;
                textBox10.Text = b.AdresaGrad;
                textBox11.Text = b.AdresaPostanskiBr.ToString();
                textBox12.Text = b.Telefon;
                textBox13.Text = b.Mail;
                textBox14.Text = b.StepenStrucneSpreme;
                textBox15.Text = b.SkolskoZvanje;
                textBox16.Text = b.RadnaPozicija;
                dateTimePicker1.Value = b.DatumZaposlenja;
                textBox18.Text = b.KorisnickoIme;
                textBox19.Text = b.Lozinka;
                textBox4.Lines = b.Napomena.ToArray();
            }


        }

        private void btLevo_Click(object sender, EventArgs e)
        {
            if (Bibliotekar.bibliotekari.Count > 1)
            {
                indeks--;
                if (indeks <= 0) indeks = Bibliotekar.bibliotekari.Count;
                Bibliotekar b = Data.pomeranjeBibliotekara(indeks);

                textBox1.Text = b.Ime;
                textBox2.Text = b.Prezime;
                comboBox4.Text = b.Pol;
                comboBox1.Text = b.Status;
                textBox5.Text = b.DanRodjenja.ToString();
                textBox6.Text = b.MesecRodjenja.ToString();
                textBox3.Text = b.GodinaRodjenja.ToString();
                textBox7.Text = b.ImeJednogRoditelja;
                textBox8.Text = b.JMBG;
                textBox9.Text = b.AdresaUlicaBr;
                textBox10.Text = b.AdresaGrad;
                textBox11.Text = b.AdresaPostanskiBr.ToString();
                textBox12.Text = b.Telefon;
                textBox13.Text = b.Mail;
                textBox14.Text = b.StepenStrucneSpreme;
                textBox15.Text = b.SkolskoZvanje;
                textBox16.Text = b.RadnaPozicija;
                dateTimePicker1.Value = b.DatumZaposlenja;
                textBox18.Text = b.KorisnickoIme;
                textBox19.Text = b.Lozinka;
                textBox4.Lines = b.Napomena.ToArray();
            }
        }

        private void btSkrozDesno_Click(object sender, EventArgs e)
        {
            if (Bibliotekar.bibliotekari.Count > 1)
            {
                indeks = Bibliotekar.bibliotekari.Count;
                Bibliotekar b = Data.pomeranjeBibliotekara(indeks);
                textBox1.Text = b.Ime;
                textBox2.Text = b.Prezime;
                comboBox4.Text = b.Pol;
                comboBox1.Text = b.Status;
                textBox5.Text = b.DanRodjenja.ToString();
                textBox6.Text = b.MesecRodjenja.ToString();
                textBox3.Text = b.GodinaRodjenja.ToString();
                textBox7.Text = b.ImeJednogRoditelja;
                textBox8.Text = b.JMBG;
                textBox9.Text = b.AdresaUlicaBr;
                textBox10.Text = b.AdresaGrad;
                textBox11.Text = b.AdresaPostanskiBr.ToString();
                textBox12.Text = b.Telefon;
                textBox13.Text = b.Mail;
                textBox14.Text = b.StepenStrucneSpreme;
                textBox15.Text = b.SkolskoZvanje;
                textBox16.Text = b.RadnaPozicija;
                dateTimePicker1.Value = b.DatumZaposlenja;
                textBox18.Text = b.KorisnickoIme;
                textBox19.Text = b.Lozinka;
                textBox4.Lines = b.Napomena.ToArray();
            }
        }

        private void btSkrozLevo_Click(object sender, EventArgs e)
        {
            if (Bibliotekar.bibliotekari.Count > 1)
            {
                indeks = 1;
                Bibliotekar b = Data.pomeranjeBibliotekara(indeks);
                textBox1.Text = b.Ime;
                textBox2.Text = b.Prezime;
                comboBox4.Text = b.Pol;
                comboBox1.Text = b.Status;
                textBox5.Text = b.DanRodjenja.ToString();
                textBox6.Text = b.MesecRodjenja.ToString();
                textBox3.Text = b.GodinaRodjenja.ToString();
                textBox7.Text = b.ImeJednogRoditelja;
                textBox8.Text = b.JMBG;
                textBox9.Text = b.AdresaUlicaBr;
                textBox10.Text = b.AdresaGrad;
                textBox11.Text = b.AdresaPostanskiBr.ToString();
                textBox12.Text = b.Telefon;
                textBox13.Text = b.Mail;
                textBox14.Text = b.StepenStrucneSpreme;
                textBox15.Text = b.SkolskoZvanje;
                textBox16.Text = b.RadnaPozicija;
                dateTimePicker1.Value = b.DatumZaposlenja;
                textBox18.Text = b.KorisnickoIme;
                textBox19.Text = b.Lozinka;
                textBox4.Lines = b.Napomena.ToArray();
            }
        }
    }
}
