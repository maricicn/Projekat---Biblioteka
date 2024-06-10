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
    public partial class POLICA2 : Form
    {
        public POLICA2()
        {
            InitializeComponent();
            Data.UP();
            Data.UP1();
            foreach (Prostorija p in Data.prostorGdeSeNalazeProstorije)
            {
                comboBox2.Items.Add(p.o);
            }
        }

        private void Sacuvaj_Click(object sender, EventArgs e)
        {
            Polica p = new Polica(Lorem.Text, Ipsum.Text, comboBox2.Text, comboBox1.Text == "Aktivan");
            if (string.IsNullOrEmpty(comboBox2.Text)) throw new Exception("polica nije u prostoriji");
            try
            {
               Data.listaPolica[Data.IP] = Data.listaPolica[Data.IP];
                for (int i = 0; i < Data.prostorGdeSeNalazeProstorije.Count; i++)
                {
                    for (int j = Data.prostorGdeSeNalazeProstorije[i].p.Count - 1; j >= 0; j--)
                    {
                        if (Data.prostorGdeSeNalazeProstorije[i].p[j].o.Trim() == p.o.Trim())
                        {
                            Data.prostorGdeSeNalazeProstorije[i].p.RemoveAt(j);
                        }
                    }
                }
                Data.SCUVAj();
                Data.listaPolica[Data.IP] = p;
                Data.listaPolica.Add(p);
                for (int i = 0; i < Data.prostorGdeSeNalazeProstorije.Count; i++)
                {
                    if (p.p == Data.prostorGdeSeNalazeProstorije[i].o)
                    {
                        Data.prostorGdeSeNalazeProstorije[i].p.Add(p);
                        Data.SCUVAj();
                    }
                }
            }
            catch
            {
                Data.DodajPolicu(p);

            }
            Data.SP();
        }

            private void button1_Click(object sender, EventArgs e)
            {
        Polica r = Data.GP1();
        Lorem.Text = r.Id;
        Ipsum.Text = r.o;
        comboBox2.Text = r.p;
        comboBox1.Text = r.L_Aktivan ? "Aktivan" : "Neaktivan";
            }

        private void button3_Click(object sender, EventArgs e)
        {
            Data.UDP();
            Polica r = Data.GP1();
            Lorem.Text = r.Id;
            Ipsum.Text = r.o;
            comboBox2.Text = r.p;
            comboBox1.Text = r.L_Aktivan ? "Aktivan" : "Neaktivan";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Data.ULP();
            Polica r = Data.GP1();
            Lorem.Text = r.Id;
            Ipsum.Text = r.o;
            comboBox2.Text = r.p;
            comboBox1.Text = r.L_Aktivan ? "Aktivan" : "Neaktivan";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Data.NP();
            Lorem.Text = "";
            Ipsum.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string t = textBox1.Text;
            for (int i = 0; i < Data.listaPolica.Count; i++)
            {
                if (t == Data.listaPolica[i].o)
                {
                    Lorem.Text = Data.listaPolica[i].Id;
                    Ipsum.Text = Data.listaPolica[i].o;
                    comboBox2.Text = Data.listaPolica[i].p;
                    comboBox1.Text = Data.listaPolica[i].L_Aktivan ? "Aktivan" : "Neaktivan";
                }
            }
        }
    }
}
