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
        }

        private void Sacuvaj_Click(object sender, EventArgs e)
        {
            Polica p = new Polica(Lorem.Text, Ipsum.Text, Dolor.Text);
            try
            {
                Data.listaPolica[Data.IP] = p;
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
        Dolor.Text = r.p;
            }

        private void button3_Click(object sender, EventArgs e)
        {
            Data.UDP();
            Polica r = Data.GP1();
            Lorem.Text = r.Id;
            Ipsum.Text = r.o;
            Dolor.Text = r.p;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Data.ULP();
            Polica r = Data.GP1();
            Lorem.Text = r.Id;
            Ipsum.Text = r.o;
            Dolor.Text = r.p;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Data.NP();
            Lorem.Text = "";
            Ipsum.Text = "";
            Dolor.Text = "";
        }
    }
}
