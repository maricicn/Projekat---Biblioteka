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
    public partial class FormaKnjigaUnesiIliEdituj : Form
    {
        public FormaKnjigaUnesiIliEdituj()
        {
            InitializeComponent();
            popuniComboBox();
        }


        void popuniComboBox()
        {
            cbPisci.Items.Clear();
            for (int i = 0; i < Data.ListaKnjiga.Count; i++)
            {
                cbPisci.Items.Add(Data.ListaKnjiga[i].ID + " " + Data.ListaKnjiga[i].Naziv);
            }
        }


        private void btDodajKnjigu_Click(object sender, EventArgs e)
        {
            /*FormPisac dodajPisca = new FormPisac();
            dodajPisca.ShowDialog();
            if (dodajPisca.DialogResult == DialogResult.OK)
            {
                List<string> napomene = new List<string>();

                napomene = dodajPisca.txtNapomenePisca.Lines.ToList<string>();

                int g = int.Parse(dodajPisca.txtGodinaRodjenjaPisca.Text);
                Pisac p = new Pisac((Data.ListaPisaca.Count + 1).ToString(), dodajPisca.cbStatusPisca.Text, dodajPisca.txtImePisca.Text, dodajPisca.txtPrezimePisca.Text, dodajPisca.cbPol.Text, g, napomene);
                Data.DodajPisca(p);
                Data.SacuvajPisce();
                popuniComboBox();
            }*/



            FormaDodajKnjigu dodajKnjigu = new FormaDodajKnjigu();
            dodajKnjigu.ShowDialog();
            if(dodajKnjigu.DialogResult == DialogResult.OK)
            {
                List<string> napomene = new List<string>();
                napomene = dodajKnjigu.txtNapomene.Lines.ToList<string>();

                List<string> pisci = new List<string>();
                for (int i = 0; i < dodajKnjigu.clbPisci.SelectedItems.Count; i++)
                {
                    pisci.Add(dodajKnjigu.clbPisci.SelectedItems[i].ToString());
                }

                List<string> svaIzdanja = new List<string>();
                for (int i = 0; i < dodajKnjigu.clbSvaIzdavanja.SelectedItems.Count; i++)
                {
                    svaIzdanja.Add(dodajKnjigu.clbSvaIzdavanja.SelectedItems[i].ToString());
                }



                Knjiga k = new Knjiga((Data.ListaKnjiga.Count + 1).ToString(),
                    dodajKnjigu.cbStatus.Text,
                    dodajKnjigu.txtNaziv.Text,
                    dodajKnjigu.cbZanr.Text,
                    int.Parse(dodajKnjigu.txtRedniBrojIzdanja.Text),
                    int.Parse(dodajKnjigu.txtGodinaIzdavanja.Text),
                    dodajKnjigu.txtIzdavac.Text,
                    dodajKnjigu.txtISBN.Text,
                    dodajKnjigu.txtStanje.Text,
                    dodajKnjigu.cbProstorija.Text,
                    dodajKnjigu.cbPolica.Text,
                    int.Parse(dodajKnjigu.txtUkupanBrojPrimeraka.Text),
                    dodajKnjigu.cbCitalac.Text,
                    dodajKnjigu.cbBibliotekar.Text,
                    dodajKnjigu.txtDatumIzdavanja.Text,
                    dodajKnjigu.txtRokZaVracanje.Text,
                    svaIzdanja,
                    pisci,
                    napomene);

                Data.DodajKnjigu(k);
                Data.SacuvajKnjige();
                popuniComboBox();

            }    


        }

        private void btEditKnjiga_Click(object sender, EventArgs e)
        {


            /*int indeks = cbPisci.SelectedIndex;
            if (indeks != -1)
            {
                Pisac p = Data.ListaPisaca[indeks];
                FormPisac dodajPisca = new FormPisac(p);
                dodajPisca.ShowDialog();
                if (dodajPisca.DialogResult == DialogResult.OK)
                {
                    List<string> napomene = new List<string>();

                    napomene = dodajPisca.txtNapomenePisca.Lines.ToList<string>();

                    int g = int.Parse(dodajPisca.txtGodinaRodjenjaPisca.Text);
                    p.Status = dodajPisca.cbStatusPisca.Text;
                    p.Ime = dodajPisca.txtImePisca.Text;
                    p.Prezime = dodajPisca.txtPrezimePisca.Text;
                    p.Pol = dodajPisca.cbPol.Text;
                    p.GodinaRodjenja = int.Parse(dodajPisca.txtGodinaRodjenjaPisca.Text);
                    p.Napomena = dodajPisca.txtNapomenePisca.Lines.ToList<string>();

                    Data.SacuvajPisce();
                    popuniComboBox();
                }
            }*/


            int indeks = cbPisci.SelectedIndex;
            if (indeks != -1)
            {
                Knjiga k = Data.ListaKnjiga[indeks];
                FormaDodajKnjigu dodajKnjigu = new FormaDodajKnjigu(k);
                dodajKnjigu.ShowDialog();
                if (dodajKnjigu.DialogResult == DialogResult.OK)
                {
                    List<string> napomene = new List<string>();
                    napomene = dodajKnjigu.txtNapomene.Lines.ToList<string>();

                    List<string> pisci = new List<string>();
                    for (int i = 0; i < dodajKnjigu.clbPisci.SelectedItems.Count; i++)
                    {
                        pisci.Add(dodajKnjigu.clbPisci.SelectedItems[i].ToString());
                    }

                    List<string> svaIzdavanja = new List<string>();
                    for (int i = 0; i < dodajKnjigu.clbSvaIzdavanja.SelectedItems.Count; i++)
                    {
                        svaIzdavanja.Add(dodajKnjigu.clbSvaIzdavanja.SelectedItems[i].ToString());
                    }

                    k.Status = dodajKnjigu.cbStatus.Text;
                    k.Naziv = dodajKnjigu.txtNaziv.Text;
                    k.Pisac = pisci;
                    k.Zanr = dodajKnjigu.cbZanr.Text;
                    k.RedniBrojIzdanja = int.Parse(dodajKnjigu.txtRedniBrojIzdanja.Text);
                    k.GodinaIzdavanja = int.Parse(dodajKnjigu.txtGodinaIzdavanja.Text);
                    k.Izdavac = dodajKnjigu.txtIzdavac.Text;
                    k.ISBN = dodajKnjigu.txtISBN.Text;
                    k.Stanje = dodajKnjigu.txtStanje.Text;
                    k.Prostorija = dodajKnjigu.cbProstorija.Text;
                    k.Polica = dodajKnjigu.cbPolica.Text;
                    k.UkupanBrojPrimeraka = int.Parse(dodajKnjigu.txtUkupanBrojPrimeraka.Text);
                    k.SvaIzdavanja = svaIzdavanja;
                    k.Citalac = dodajKnjigu.cbCitalac.Text;
                    k.DatumIzdavanja = dodajKnjigu.txtDatumIzdavanja.Text;
                    k.RokZaVracanje = dodajKnjigu.txtRokZaVracanje.Text;
                    k.Bibliotekar = dodajKnjigu.cbBibliotekar.Text;
                    k.Napomena = napomene;

                    Data.SacuvajKnjige();
                    popuniComboBox();
                }
            }





        }
    }
}
