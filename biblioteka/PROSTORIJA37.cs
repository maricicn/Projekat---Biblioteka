using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class PROSTORIJA37 : Form
    {
        public PROSTORIJA37()
        {
            InitializeComponent();
            Data.UP();
            Data.UP1();
        }

        private void Sacuvaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sacuvaj");
            //Polica p = new Polica(Lorem.Text, Ipsum.Text, Dolor.Text);
            //try
            //{
            //    Data.listaPolica[Data.IP] = p;
            //}
            //catch
            //{
            //    Data.DodajPolicu(p);

            //}
            //Data.SP();


            string[] po = Dolor.Text.Split(',');
            List<Polica> s = new List<Polica>();
            foreach (string a in po)
            {
                for (int i = 0; i < Data.listaPolica.Count; i++)
                {
                    if (a == Data.listaPolica[i].Id)
                    {
                        s.Add(Data.listaPolica[i]);
                    }
                }
            }
            Prostorija po1 = new Prostorija(Lorem.Text, Ipsum.Text, s, comboBox1.Text == "Aktivan");
            try
            {
                Data.prostorGdeSeNalazeProstorije[Data.IP1] = po1;
            }
            catch
            {
                Data.DP(po1);
            }
            Data.SCUVAj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prostorija r = Data.GP2();
            IP(r);
        }

        void IP(Prostorija r)
        {
            Lorem.Text = r.Id;
            Ipsum.Text = r.o;
            comboBox1.Text = r.L_Aktivan ? "Aktivan" : "Neaktivan";
            string s = "";
            for (int i = 0; i < r.p.Count; i++)
            {
                s = $"{s},{r.p[i].Id}";
            }
            s = s.Substring(1, s.Length - 1);
            Dolor.Text = s;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data.IP1= (Data.IP1 +1)%Data.prostorGdeSeNalazeProstorije.Count;
            Prostorija r = Data.GP2();
            IP(r);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Data.IP1 =(Data.IP1- 1   +Data.prostorGdeSeNalazeProstorije.Count)     %Data.prostorGdeSeNalazeProstorije.Count;
            Prostorija     r = Data.
                GP2();
            IP(r);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Data.IP1 = -1;
            Lorem.Text = "";
            Ipsum.Text = "";
            Dolor.Text = "";
        }
    }
}
