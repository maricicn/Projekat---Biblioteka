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

        public int indeksPronadjenogCitaoca;

        public FormaCItalac()
        {
            InitializeComponent();
            popuniComboBox();
        }




        void popuniComboBox()
        {
            cbCitaoci.Items.Clear();
            for (int i = 0; i < Data.ListaCitalaca.Count; i++)
            {
                cbCitaoci.Items.Add(Data.ListaCitalaca[i].ID + " " + Data.ListaCitalaca[i].Ime + " " + Data.ListaCitalaca[i].Prezime);
            }
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
                marko.ID = (Data.ListaCitalaca.Count + 1).ToString();
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
                marko.AdresaGrad = dodaj.textBox10.Text;
                marko.AdresaPostanskiBr = int.Parse(dodaj.textBox11.Text);
                marko.Telefon = dodaj.textBox12.Text;
                marko.Mail = dodaj.textBox13.Text;
                marko.StepenStrucneSpreme = dodaj.textBox14.Text;
                marko.SkolskoZvanje = dodaj.textBox15.Text;
                marko.TrenRadniStatus = dodaj.textBox16.Text;
                marko.BrojIDDokumenta = dodaj.textBox17.Text;
                marko.BrojClanskeKarte = dodaj.textBox20.Text;
                marko.PrviUpis = dodaj.dateTimePicker2.Value;
                marko.ProduzenjeClanstva = dodaj.dateTimePicker1.Value;
                marko.IznosClanarine = int.Parse(dodaj.textBox21.Text);
                marko.TrajanjeClanstva = dodaj.dateTimePicker3.Value;

                List<string> sk = new List<string>();
                foreach (string knjiga in dodaj.checkedListBox1.CheckedItems)
                {
                    sk.Add(knjiga);
                }
                marko.SveKnjige = sk;

                List<string> stk = new List<string>();
                foreach (string knjiga in dodaj.checkedListBox2.CheckedItems)
                {
                    stk.Add(knjiga);
                }
                marko.SveTrenutneKnjige = stk;

                marko.Napomena = dodaj.textBox4.Lines.ToList<string>();

                Data.DodajCitaoca(marko);
                Data.SacuvajCitaoce();
                popuniComboBox();
            }

        }

        private void btEditCitaoca_Click(object sender, EventArgs e)
        {
            int indeks = cbCitaoci.SelectedIndex + 1;
            if (indeks == 0)
            {
                indeks = indeksPronadjenogCitaoca;
            }

            if (indeks != 0)
            {
                Citalac c = Data.ListaCitalaca[indeks-1];
                DodajCitaoca dodaj = new DodajCitaoca(c, indeks);
                dodaj.ShowDialog();
                dodaj.btDesno.Show();
                dodaj.btLevo.Show();



                if (dodaj.DialogResult == DialogResult.OK)
                {
                    Citalac marko = Data.pomeranjeCitaoca(dodaj.indeks);
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
                    marko.AdresaGrad = dodaj.textBox10.Text;
                    marko.AdresaPostanskiBr = int.Parse(dodaj.textBox11.Text);
                    marko.Telefon = dodaj.textBox12.Text;
                    marko.Mail = dodaj.textBox13.Text;
                    marko.StepenStrucneSpreme = dodaj.textBox14.Text;
                    marko.SkolskoZvanje = dodaj.textBox15.Text;
                    marko.TrenRadniStatus = dodaj.textBox16.Text;
                    marko.BrojIDDokumenta = dodaj.textBox17.Text;
                    marko.BrojClanskeKarte = dodaj.textBox20.Text;
                    marko.PrviUpis = dodaj.dateTimePicker2.Value;
                    marko.ProduzenjeClanstva = dodaj.dateTimePicker1.Value;
                    marko.IznosClanarine = int.Parse(dodaj.textBox21.Text);
                    marko.TrajanjeClanstva = dodaj.dateTimePicker3.Value;

                    List<string> sk = new List<string>();
                    foreach (string knjiga in dodaj.checkedListBox1.CheckedItems)
                    {
                        sk.Add(knjiga);
                    }
                    marko.SveKnjige = sk;

                    List<string> stk = new List<string>();
                    foreach (string knjiga in dodaj.checkedListBox2.CheckedItems)
                    {
                        stk.Add(knjiga);
                    }
                    marko.SveTrenutneKnjige = stk;

                    marko.Napomena = dodaj.textBox4.Lines.ToList<string>();

                    Data.SacuvajCitaoce();
                    popuniComboBox();
                }
            }
        }




        /*int indeks = cbPisci.SelectedIndex + 1;
            if (indeks == 0)
            {
                indeks = indeksPronadjenogPisca;
            }

            if (indeks != 0)
            {
                Pisac p = Data.ListaPisaca[indeks-1];
                FormPisac dodajPisca = new FormPisac(p, indeks);
                dodajPisca.ShowDialog();
                dodajPisca.btDesno.Show();
                dodajPisca.btLevo.Show();



                if (dodajPisca.DialogResult == DialogResult.OK)
                {
                    List<string> napomene = new List<string>();

                    Pisac p2 = Data.pomeranjePisca(dodajPisca.indeks);

                    napomene = dodajPisca.txtNapomenePisca.Lines.ToList<string>();

                    int g = int.Parse(dodajPisca.txtGodinaRodjenjaPisca.Text);
                    p2.Status = dodajPisca.cbStatusPisca.Text;
                    p2.Ime = dodajPisca.txtImePisca.Text;
                    p2.Prezime = dodajPisca.txtPrezimePisca.Text;
                    p2.Pol = dodajPisca.cbPol.Text;
                    p2.GodinaRodjenja = int.Parse(dodajPisca.txtGodinaRodjenjaPisca.Text);
                    p2.Napomena = dodajPisca.txtNapomenePisca.Lines.ToList<string>();

                    Data.SacuvajPisce();
                    popuniComboBox();
                }
            }*/




        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPretraga_TextChanged_1(object sender, EventArgs e)
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



            for (int i = 0; i < Data.ListaCitalaca.Count; i++)
            {
                if ((ime == Data.ListaCitalaca[i].Ime) && (prezime == Data.ListaCitalaca[i].Prezime))
                {
                    indeksPronadjenogCitaoca = int.Parse(Data.ListaCitalaca[i].ID);
                    lblPronadjenCitalac.Text = Data.ListaCitalaca[i].ID + " " + ime + " " + prezime;
                }
            }
        }

        private void cbCitaoci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
