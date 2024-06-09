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
        public FormIzvestaj()
        {
            InitializeComponent();
            if(Data.ListaIzdavanja.Count() > 0)
            {
                IzvestajIspisi(0);
            }
            

        }
        private void IzvestajIspisi(int index)
        {
            textBox1.Text = Data.ListaIzdavanja[index].citalac;
            textBox2.Text = Data.ListaIzdavanja[index].knjiga;
            dateTimePicker1.Value = Data.ListaIzdavanja[index].datumizdavanja;
            dateTimePicker1.Value = Data.ListaIzdavanja[index].rokzavracanje;
            textBox3.Text = Data.ListaIzdavanja[index].bibliotekar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index < Data.ListaIzdavanja.Count() - 1)
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
            IzvestajIspisi(index);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = Data.ListaIzdavanja.Count();
            IzvestajIspisi(index - 1);
        }
    }
}
