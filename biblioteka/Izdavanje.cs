using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    internal class Izdavanje
    {
        public string citalac;
        public string knjiga;
        public DateTime datumizdavanja;
        public DateTime rokzavracanje;
        public string bibliotekar;

        public Izdavanje()
        {

        }

        public Izdavanje(string citalac, string knjiga, DateTime datumizdavanja, DateTime rokzavracanje, string bibliotekar)
        {
            this.citalac = citalac;
            this.knjiga = knjiga;   
            this.datumizdavanja = datumizdavanja;
            this.rokzavracanje = rokzavracanje;
            this.bibliotekar = bibliotekar;
        }

    }
}
