using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    internal class Vracanje
    {
        public string citalac;
        public string knjiga;
        public DateTime rokvracanja; //cita se iz izdavanja
        public DateTime datumvracanja;
        public string bibliotekar;
        public string zakasnjenje;
        public int zakasnjenjeDani;

        public Vracanje()
        {

        }

        public Vracanje(string citalac, string knjiga, DateTime rokvracanja, DateTime datumvracanja, string bibliotekar, string zakasnjenje, int zakasnjenjeDani)
        {
            this.citalac = citalac;
            this.knjiga = knjiga;
            this.rokvracanja = rokvracanja;
            this.datumvracanja = datumvracanja;
            this.bibliotekar = bibliotekar;
            this.zakasnjenje = zakasnjenje;
            this.zakasnjenjeDani = zakasnjenjeDani;
        }
    }
}
