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
    public partial class FormaKnjigaUnesiIliEdituj : Form
    {
        public FormaKnjigaUnesiIliEdituj()
        {
            InitializeComponent();
        }

        private void btDodajKnjigu_Click(object sender, EventArgs e)
        {
            FormaDodajKnjigu forma = new FormaDodajKnjigu();
            forma.ShowDialog();
        }
    }
}
