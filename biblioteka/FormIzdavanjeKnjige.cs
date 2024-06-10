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
    public partial class FormIzdavanjeKnjige : Form
    {

        public FormIzdavanjeKnjige()
        {
            InitializeComponent();
            dTVracanje.Value = dTIzdavanje.Value.AddDays(21);
            popuniComboBox();
            popuniComboBoxBibliotekari();
            cBBibliotekar.Text = Form1.idimeprezime;
        }
        void popuniComboBox()
        {
            cBKnjiga.Items.Clear();
            for (int i = 0; i < Data.ListaKnjiga.Count; i++)
            {
                if (Data.ListaKnjiga[i].Stanje.ToLower() != "izdata" && Data.ListaKnjiga[i].Status.ToLower() == "aktivan")
                {
                    cBKnjiga.Items.Add(Data.ListaKnjiga[i].ID + " " + Data.ListaKnjiga[i].Naziv);
                }
            }
        }
        void popuniComboBoxBibliotekari()
        {
            cBBibliotekar.Items.Clear();
            for (int i = 0; i < Bibliotekar.bibliotekari.Count; i++)
            {
                if (Bibliotekar.bibliotekari[i].Status.ToLower() == "aktivan")
                {
                    cBBibliotekar.Items.Add(Bibliotekar.bibliotekari[i].ID + " " + Bibliotekar.bibliotekari[i].Ime + " " + Bibliotekar.bibliotekari[i].Prezime);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (cBCitalac.Text == string.Empty || cBKnjiga.Text == string.Empty || cBBibliotekar.Text == string.Empty)
            {
                MessageBox.Show("Jedno od polja nije popunjeno!");
            }
            else if(dTIzdavanje.Value > dTVracanje.Value)
            {
                MessageBox.Show("Rok za vracanje ne sme biti pre datuma izdavanja!");
            }
            else
            {
                StreamWriter izdavanjeknjige = new StreamWriter("izdavanjeFile.csv", append: true);
                izdavanjeknjige.WriteLine(cBCitalac.Text + ";" + cBKnjiga.Text + ";" + cBBibliotekar.Text + ";" + dTIzdavanje.Value + ";" + dTVracanje.Value);
                Izdavanje izd = new Izdavanje(cBCitalac.Text, cBKnjiga.Text, dTIzdavanje.Value, dTVracanje.Value, cBBibliotekar.Text);
                Data.ListaIzdavanja.Add(izd);
                Data.PopuniListuZakasnjenja();
                string[] line = cBKnjiga.Text.Split(' ');
                int index = int.Parse(line[0]);
    
                //Izmena podatak izdate knjige (stanje - izdata, citalac, bibliotekar, datumi)
                Data.ListaKnjiga[index - 1].Stanje = "izdata";
                Data.ListaKnjiga[index - 1].Bibliotekar = cBBibliotekar.Text;
                Data.ListaKnjiga[index - 1].Citalac = cBCitalac.Text;
                Data.ListaKnjiga[index - 1].DatumIzdavanja = dTIzdavanje.Value;
                Data.ListaKnjiga[index - 1].RokZaVracanje = dTVracanje.Value;
                //Data.ListaKnjiga[index - 1].SvaIzdavanja.Add(izd.dt);

                Data.SacuvajKnjige();
                popuniComboBox();
                cBKnjiga.Text = string.Empty;
                izdavanjeknjige.Close();
                MessageBox.Show("Izdavanje knjige je zabelezeno!");
                ControlClear();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dTVracanje.Value = dTIzdavanje.Value.AddDays(21);
        }
        private void ControlClear()
        {
            cBCitalac.Text = string.Empty;
            cBKnjiga.Text = string.Empty;
            dTIzdavanje.Value = DateTime.Now;
            dTVracanje.Value = DateTime.Now;
            cBBibliotekar.Text = string.Empty;
        }
    }
}
