using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    internal class Zakasnjenje
    {
        public string citalac;
        public string knjiga;
        public int brojdana;

        public Zakasnjenje(string citalac, string knjiga, int brojdana)
        {
            this.citalac = citalac;
            this.knjiga = knjiga;
            this.brojdana = brojdana;
        }
        public Zakasnjenje()
        {

        }
    }
}
