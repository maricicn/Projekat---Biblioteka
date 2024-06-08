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
    public partial class FormaDodajKnjigu : Form
    {
        public FormaDodajKnjigu()
        {
            InitializeComponent();
        }

        public FormaDodajKnjigu(Knjiga k)
        {
            InitializeComponent();
            /*cbStatusPisca.Text = p.Status;
            txtImePisca.Text = p.Ime;
            txtPrezimePisca.Text = p.Prezime;
            cbPol.Text = p.Pol;
            txtGodinaRodjenjaPisca.Text = p.GodinaRodjenja.ToString();

            txtNapomenePisca.Lines = p.Napomena.ToArray();*/


            cbStatus.Text = k.Status;
            txtNaziv.Text = k.Naziv;


            for (int i = 0; i < k.Pisac.Count; i++)
            {
                clbPisci.Text += k.Pisac[i].ToString() + '\n';
            }

            cbZanr.Text = k.Zanr;
            txtRedniBrojIzdanja.Text = k.RedniBrojIzdanja.ToString();
            txtGodinaIzdavanja.Text = k.GodinaIzdavanja.ToString();
            txtIzdavac.Text = k.Izdavac;
            txtISBN.Text = k.ISBN;
            txtStanje.Text = k.Stanje;
            cbProstorija.Text = k.Prostorija;
            cbPolica.Text = k.Polica;
            txtUkupanBrojPrimeraka.Text = k.UkupanBrojPrimeraka.ToString();

            for (int i = 0; i < k.SvaIzdavanja.Count; i++)
            {
                clbSvaIzdavanja.Text += k.SvaIzdavanja[i].ToString() + '\n';
            }

            cbCitalac.Text = k.Citalac;
            txtDatumIzdavanja.Text = k.DatumIzdavanja.ToString();
            txtRokZaVracanje.Text = k.RokZaVracanje.ToString();
            cbBibliotekar.Text = k.Bibliotekar;
            txtNapomene.Lines = k.Napomena.ToArray();

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {

        }
    }
}
