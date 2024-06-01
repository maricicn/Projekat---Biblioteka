using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bibiloteka
{
    public class Osoba : Covek, IOsoba
    {
        public bool JMBGProvera()
        {
            return false;
        }
        public void UzimanjeKnjige()
        {

        }
        public void VracanjeKnjige()
        {

        }
    }
}