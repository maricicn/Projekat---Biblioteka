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
    public partial class FormVracanjeKnjige : Form
    {
        public FormVracanjeKnjige()
        {
            InitializeComponent();
            popuniComboBox();
        }
        private void popuniComboBox()
        {
            cBKnjiga.Items.Clear();
            for (int i = 0; i < Data.ListaKnjiga.Count; i++)
            {
                if (Data.ListaKnjiga[i].Stanje.ToLower() == "izdata" && Data.ListaKnjiga[i].Status.ToLower() == "aktivan")
                {
                    cBKnjiga.Items.Add(Data.ListaKnjiga[i].ID + " " + Data.ListaKnjiga[i].Naziv);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (cBCitalac.Text == string.Empty || cBKnjiga.Text == string.Empty || cBBibliotekar.Text == string.Empty)
            {
                MessageBox.Show("Jedno od polja nije popunjeno!");
            }
            else if (dTIzdavanje.Value > dTVracanje.Value)
            {
                MessageBox.Show("Rok za vracanje ne sme biti pre datuma izdavanja!");
            }
            else
            {
                StreamWriter izdavanjeknjige = new StreamWriter("izdavanjeFile.csv", append: true);
                izdavanjeknjige.WriteLine(cBCitalac.Text + ";" + cBKnjiga.Text + ";" + cBBibliotekar.Text + ";" + dTIzdavanje.Text + ";" + dTVracanje.Text);
                string[] line = cBKnjiga.Text.Split(' ');
                int index = int.Parse(line[0]);
                MessageBox.Show(index.ToString());
                //Izmena podatak izdate knjige (stanje - izdata, citalac, bibliotekar, datumi)
                Data.ListaKnjiga[index - 1].Stanje = "izdata";
                Data.ListaKnjiga[index - 1].Bibliotekar = cBBibliotekar.Text;
                Data.ListaKnjiga[index - 1].Citalac = cBCitalac.Text;
                //Data.ListaKnjiga[index - 1].DatumIzdavanja = dTIzdavanje.Value;
                //Data.ListaKnjiga[index - 1].RokZaVracanje = dTVracanje.Value;

                Data.SacuvajKnjige();
                popuniComboBox();
                cBKnjiga.Text = string.Empty;
                izdavanjeknjige.Close();
                MessageBox.Show("Izdavanje knjige je zabelezeno!");*/
        }

        private void cBKnjiga_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] line = cBKnjiga.Text.Split(' ');
            int index = int.Parse(line[0]);
            cBCitalac.Text = Data.ListaKnjiga[index - 1].Citalac;
        }
    }

    
}
