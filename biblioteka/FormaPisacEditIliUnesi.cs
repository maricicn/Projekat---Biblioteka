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
    public partial class FormaPisacEditIliUnesi : Form
    {
        public FormaPisacEditIliUnesi()
        {
            InitializeComponent();

            popuniComboBox();

        }


        void popuniComboBox()
        {
            cbPisci.Items.Clear();
            for (int i = 0; i < Data.ListaPisaca.Count; i++)
            {
                cbPisci.Items.Add(Data.ListaPisaca[i].ID + " " + Data.ListaPisaca[i].Ime + " " + Data.ListaPisaca[i].Prezime);
            }
        }

        private void btDodajPisca_Click(object sender, EventArgs e)
        {
            FormPisac dodajPisca = new FormPisac();
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
            }


        }

        private void btEditPisca_Click(object sender, EventArgs e)
        {
            int indeks = cbPisci.SelectedIndex;
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
            }
        }

        private void cbPisci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
