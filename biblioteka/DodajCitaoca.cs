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
    public partial class DodajCitaoca : Form
    {

        public int indeks;

        public DodajCitaoca()
        {
            InitializeComponent();
            btSkrozLevo.Visible = false;
            btSkrozDesno.Visible = false;
            btLevo.Visible = false;
            btDesno.Visible = false;
        }

        public DodajCitaoca(Citalac c, int indeks)
        {
            InitializeComponent();
            btSkrozLevo.Visible = true;
            btSkrozDesno.Visible = true;
            btLevo.Visible = true;
            btDesno.Visible = true;
            this.indeks = indeks;
            /*cbStatusPisca.Text = p.Status;
            txtImePisca.Text = p.Ime;
            txtPrezimePisca.Text = p.Prezime;
            cbPol.Text = p.Pol;
            txtGodinaRodjenjaPisca.Text = p.GodinaRodjenja.ToString();

            txtNapomenePisca.Lines = p.Napomena.ToArray();*/



            comboBox1.Text = c.Status;
            textBox1.Text = c.Ime;
            textBox2.Text = c.Prezime;
            textBox7.Text = c.ImeJednogRoditelja;
            comboBox4.Text = c.Pol;
            textBox5.Text = c.DanRodjenja.ToString();
            textBox6.Text = c.MesecRodjenja.ToString();
            textBox3.Text = c.GodinaRodjenja.ToString();
            textBox8.Text = c.JMBG;
            textBox9.Text = c.AdresaUlicaBr;
            textBox10.Text = c.AdresaGrad;
            textBox11.Text = c.AdresaPostanskiBr.ToString();
            textBox12.Text = c.Telefon;
            textBox13.Text = c.Mail;
            textBox14.Text = c.StepenStrucneSpreme;
            textBox15.Text = c.SkolskoZvanje;
            textBox16.Text = c.TrenRadniStatus;
            textBox17.Text = c.BrojIDDokumenta;
            textBox20.Text = c.BrojClanskeKarte;
            dateTimePicker2.Value = c.PrviUpis;
            dateTimePicker1.Value = c.ProduzenjeClanstva;
            textBox21.Text = c.IznosClanarine.ToString();
            dateTimePicker3.Value = c.TrajanjeClanstva;
            textBox4.Lines = c.Napomena.ToArray();


            /*for (int i = 0; i < c.SveKnjige.Count; i++)
            {
                checkedListBox1.Items.Add(c.SveKnjige[i]);
            }

            for (int i = 0; i < c.SveTrenutneKnjige.Count; i++)
            {
                checkedListBox2.Items.Add(c.SveTrenutneKnjige[i]);
            }




            for (int i = 0; i < Data.ListaCitalaca.Count; i++)
            {
                string IdImePrezimeCitaoca = Data.ListaCitalaca[i].ID + " " + Data.ListaCitalaca[i].Ime + " " + Data.ListaCitalaca[i].Prezime;
                checkedListBox1.Items.Add(IdImePrezimeCitaoca);

                if (c.SveKnjige.Contains(IdImePrezimeCitaoca))
                {
                    checkedListBox1.SetItemChecked(i, true);
                }

            }

            for (int i = 0; i < Data.ListaCitalaca.Count; i++)
            {
                for (int j = 0; j < c.SveKnjige.Count; j++)
                {
                    if (c.SveKnjige[j] == (Data.ListaCitalaca[i].ID + " " + Data.ListaCitalaca[i].Ime + " " + Data.ListaCitalaca[i].Prezime))
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                }
            }



            for (int i = 0; i < Data.ListaCitalaca.Count; i++)
            {
                string IdImePrezimeCitaoca = Data.ListaCitalaca[i].ID + " " + Data.ListaCitalaca[i].Ime + " " + Data.ListaCitalaca[i].Prezime;
                checkedListBox2.Items.Add(IdImePrezimeCitaoca);

                if (c.SveTrenutneKnjige.Contains(IdImePrezimeCitaoca))
                {
                    checkedListBox2.SetItemChecked(i, true);
                }

            }

            for (int i = 0; i < Data.ListaCitalaca.Count; i++)
            {
                for (int j = 0; j < c.SveTrenutneKnjige.Count; j++)
                {
                    if (c.SveTrenutneKnjige[j] == (Data.ListaCitalaca[i].ID + " " + Data.ListaCitalaca[i].Ime + " " + Data.ListaCitalaca[i].Prezime))
                    {
                        checkedListBox2.SetItemChecked(i, true);
                    }
                }
            }*/

        }

        private void btDesno_Click(object sender, EventArgs e)
        {
            indeks++;
            if (indeks > Data.ListaCitalaca.Count) indeks = 1;
            Citalac c = Data.pomeranjeCitaoca(indeks);
            comboBox1.Text = c.Status;
            textBox1.Text = c.Ime;
            textBox2.Text = c.Prezime;
            textBox7.Text = c.ImeJednogRoditelja;
            comboBox4.Text = c.Pol;
            textBox5.Text = c.DanRodjenja.ToString();
            textBox6.Text = c.MesecRodjenja.ToString();
            textBox3.Text = c.GodinaRodjenja.ToString();
            textBox8.Text = c.JMBG;
            textBox9.Text = c.AdresaUlicaBr;
            textBox10.Text = c.AdresaGrad;
            textBox11.Text = c.AdresaPostanskiBr.ToString();
            textBox12.Text = c.Telefon;
            textBox13.Text = c.Mail;
            textBox14.Text = c.StepenStrucneSpreme;
            textBox15.Text = c.SkolskoZvanje;
            textBox16.Text = c.TrenRadniStatus;
            textBox17.Text = c.BrojIDDokumenta;
            textBox20.Text = c.BrojClanskeKarte;
            dateTimePicker2.Value = c.PrviUpis;
            dateTimePicker1.Value = c.ProduzenjeClanstva;
            textBox21.Text = c.IznosClanarine.ToString();
            dateTimePicker3.Value = c.TrajanjeClanstva;
            textBox4.Lines = c.Napomena.ToArray();

        }

        private void btLevo_Click(object sender, EventArgs e)
        {
            indeks--;
            if (indeks <= 0) indeks = Data.ListaCitalaca.Count;
            Citalac c = Data.pomeranjeCitaoca(indeks);

            comboBox1.Text = c.Status;
            textBox1.Text = c.Ime;
            textBox2.Text = c.Prezime;
            textBox7.Text = c.ImeJednogRoditelja;
            comboBox4.Text = c.Pol;
            textBox5.Text = c.DanRodjenja.ToString();
            textBox6.Text = c.MesecRodjenja.ToString();
            textBox3.Text = c.GodinaRodjenja.ToString();
            textBox8.Text = c.JMBG;
            textBox9.Text = c.AdresaUlicaBr;
            textBox10.Text = c.AdresaGrad;
            textBox11.Text = c.AdresaPostanskiBr.ToString();
            textBox12.Text = c.Telefon;
            textBox13.Text = c.Mail;
            textBox14.Text = c.StepenStrucneSpreme;
            textBox15.Text = c.SkolskoZvanje;
            textBox16.Text = c.TrenRadniStatus;
            textBox17.Text = c.BrojIDDokumenta;
            textBox20.Text = c.BrojClanskeKarte;
            dateTimePicker2.Value = c.PrviUpis;
            dateTimePicker1.Value = c.ProduzenjeClanstva;
            textBox21.Text = c.IznosClanarine.ToString();
            dateTimePicker3.Value = c.TrajanjeClanstva;
            textBox4.Lines = c.Napomena.ToArray();

        }

        private void btSkrozDesno_Click(object sender, EventArgs e)
        {
            indeks = 1;
            Citalac c = Data.pomeranjeCitaoca(indeks);
            comboBox1.Text = c.Status;
            textBox1.Text = c.Ime;
            textBox2.Text = c.Prezime;
            textBox7.Text = c.ImeJednogRoditelja;
            comboBox4.Text = c.Pol;
            textBox5.Text = c.DanRodjenja.ToString();
            textBox6.Text = c.MesecRodjenja.ToString();
            textBox3.Text = c.GodinaRodjenja.ToString();
            textBox8.Text = c.JMBG;
            textBox9.Text = c.AdresaUlicaBr;
            textBox10.Text = c.AdresaGrad;
            textBox11.Text = c.AdresaPostanskiBr.ToString();
            textBox12.Text = c.Telefon;
            textBox13.Text = c.Mail;
            textBox14.Text = c.StepenStrucneSpreme;
            textBox15.Text = c.SkolskoZvanje;
            textBox16.Text = c.TrenRadniStatus;
            textBox17.Text = c.BrojIDDokumenta;
            textBox20.Text = c.BrojClanskeKarte;
            dateTimePicker2.Value = c.PrviUpis;
            dateTimePicker1.Value = c.ProduzenjeClanstva;
            textBox21.Text = c.IznosClanarine.ToString();
            dateTimePicker3.Value = c.TrajanjeClanstva;
            textBox4.Lines = c.Napomena.ToArray();

        }

        private void btSkrozLevo_Click(object sender, EventArgs e)
        {
            indeks = Data.ListaCitalaca.Count;
            Citalac c = Data.pomeranjeCitaoca(indeks);
            comboBox1.Text = c.Status;
            textBox1.Text = c.Ime;
            textBox2.Text = c.Prezime;
            textBox7.Text = c.ImeJednogRoditelja;
            comboBox4.Text = c.Pol;
            textBox5.Text = c.DanRodjenja.ToString();
            textBox6.Text = c.MesecRodjenja.ToString();
            textBox3.Text = c.GodinaRodjenja.ToString();
            textBox8.Text = c.JMBG;
            textBox9.Text = c.AdresaUlicaBr;
            textBox10.Text = c.AdresaGrad;
            textBox11.Text = c.AdresaPostanskiBr.ToString();
            textBox12.Text = c.Telefon;
            textBox13.Text = c.Mail;
            textBox14.Text = c.StepenStrucneSpreme;
            textBox15.Text = c.SkolskoZvanje;
            textBox16.Text = c.TrenRadniStatus;
            textBox17.Text = c.BrojIDDokumenta;
            textBox20.Text = c.BrojClanskeKarte;
            dateTimePicker2.Value = c.PrviUpis;
            dateTimePicker1.Value = c.ProduzenjeClanstva;
            textBox21.Text = c.IznosClanarine.ToString();
            dateTimePicker3.Value = c.TrajanjeClanstva;
            textBox4.Lines = c.Napomena.ToArray();

        }
    }
}
