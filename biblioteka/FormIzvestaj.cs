using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class FormIzvestaj : Form
    {
        public int index;
        public int indexZakasnjenja;
        
        public FormIzvestaj()
        {
            InitializeComponent();
            Data.TrenutnaIzdavanja.Clear();
            index = 0;
            for(int i = 0; i < Data.ListaKnjiga.Count; i++)
            {
                if (Data.ListaKnjiga[i].Stanje.ToLower() == "izdata")
                {
                    for(int j = Data.ListaIzdavanja.Count() - 1; j >= 0; j--)
                    {
                        if (Data.ListaIzdavanja[j].knjiga == (Data.ListaKnjiga[i].ID + " " + Data.ListaKnjiga[i].Naziv))
                        {
                            Izdavanje iz = Data.ListaIzdavanja[j];
                            Data.TrenutnaIzdavanja.Add(iz);
                            break;
                        }
                    }
                }
            }
            if(Data.TrenutnaIzdavanja.Count > 0)
            {
                IzvestajIspisi(0);
            }

            Data.ListaZakasnjenja.Clear();
            indexZakasnjenja = 0;
            for(int i = 0; i < Data.TrenutnaIzdavanja.Count; i++)
            {
                
                if (Data.TrenutnaIzdavanja[i].rokzavracanje < DateTime.Now)
                {
                    string citalac = Data.TrenutnaIzdavanja[i].citalac;
                    string knjiga = Data.TrenutnaIzdavanja[i].knjiga;
                    int zaks = (DateTime.Now - Data.TrenutnaIzdavanja[i].rokzavracanje).Days;
                    Zakasnjenje zak = new Zakasnjenje(citalac, knjiga, zaks);
                    Data.ListaZakasnjenja.Add(zak);
                }
            }
            if (Data.ListaZakasnjenja.Count > 0)
            {
                ZakasnjenjeIspisi(0);
            }
        }
        private void IzvestajIspisi(int index)
        {
            textBox1.Text = Data.TrenutnaIzdavanja[index].citalac;
            textBox2.Text = Data.TrenutnaIzdavanja[index].knjiga;
            dateTimePicker1.Value = Data.TrenutnaIzdavanja[index].datumizdavanja;
            dateTimePicker1.Value = Data.TrenutnaIzdavanja[index].rokzavracanje;
            textBox3.Text = Data.TrenutnaIzdavanja[index].bibliotekar;
        }
        private void ZakasnjenjeIspisi(int indexZakasnjenja)
        {
            textBox5.Text = Data.ListaZakasnjenja[indexZakasnjenja].citalac;
            textBox4.Text = Data.ListaZakasnjenja[indexZakasnjenja].knjiga;
            textBox7.Text = Data.ListaZakasnjenja[indexZakasnjenja].brojdana.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (index < Data.TrenutnaIzdavanja.Count() - 1)
            {
                index++;
                IzvestajIspisi(index);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index >= 1)
            {
                index--;
                IzvestajIspisi(index);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = 0;
            if (Data.TrenutnaIzdavanja.Count > 0)
            {
                IzvestajIspisi(index);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = Data.TrenutnaIzdavanja.Count();
            if (index > 0)
            {
                IzvestajIspisi(index - 1);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (indexZakasnjenja < Data.ListaZakasnjenja.Count() - 1)
            {
                indexZakasnjenja++;
                ZakasnjenjeIspisi(indexZakasnjenja);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (indexZakasnjenja >= 1)
            {
                indexZakasnjenja--;
                ZakasnjenjeIspisi(indexZakasnjenja);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            indexZakasnjenja = 0;
            if (Data.ListaZakasnjenja.Count > 0)
            {
                ZakasnjenjeIspisi(indexZakasnjenja);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            indexZakasnjenja = Data.ListaZakasnjenja.Count();
            if (indexZakasnjenja > 0)
            {
                ZakasnjenjeIspisi(indexZakasnjenja - 1);
            }
        }
    }
}
