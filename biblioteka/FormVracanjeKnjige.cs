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
            if (cBCitalac.Text == string.Empty || cBKnjiga.Text == string.Empty || cBBibliotekar.Text == string.Empty)
            {
                MessageBox.Show("Jedno od polja nije popunjeno!");
            }
            else
            {
                if(dateTimePicker1.Value < dTVracanje.Value)
                {
                    MessageBox.Show("Citalac je knjigu vratio sa zakasnjenjem!");
                }
                StreamWriter vracanjeknjige = new StreamWriter("vracanjeFile.csv", append: true);
                vracanjeknjige.WriteLine(cBCitalac.Text + ";" + cBKnjiga.Text + ";" + cBBibliotekar.Text + ";" + dateTimePicker1.Text + ";" + dTVracanje.Text);
                string[] line = cBKnjiga.Text.Split(' ');
                int index = int.Parse(line[0]);
                //Izmena podatak izdate knjige (stanje - u biblioteci, citalac, bibliotekar, datumi)
                Data.ListaKnjiga[index - 1].Stanje = "u biblioteci";
                Data.ListaKnjiga[index - 1].Bibliotekar = cBBibliotekar.Text;
                Data.ListaKnjiga[index - 1].Citalac = cBCitalac.Text;
                Data.ListaKnjiga[index - 1].DatumIzdavanja = DateTime.Now;
                Data.ListaKnjiga[index - 1].RokZaVracanje = DateTime.Now;

                Data.SacuvajKnjige();
                popuniComboBox();
                cBKnjiga.Text = string.Empty;
                vracanjeknjige.Close();
                MessageBox.Show("Vracanje knjige je zabelezeno!");
                ControlClear();
            }
        }

        private void cBKnjiga_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] line = cBKnjiga.Text.Split(' ');
            int index = int.Parse(line[0]);
            cBCitalac.Text = Data.ListaKnjiga[index - 1].Citalac;
            dateTimePicker1.Value = Data.ListaKnjiga[index - 1].RokZaVracanje;

        }
        private void ControlClear()
        {
            cBCitalac.Text = string.Empty;
            cBKnjiga.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            dTVracanje.Value = DateTime.Now;
            cBBibliotekar.Text = string.Empty;
        }
    }
}
