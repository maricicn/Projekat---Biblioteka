using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bibiloteka
{
    public class Covek : ICovek
    {
        string ID;
        string Status;
        string Ime;
        string Prezime;
        string Pol;
        int GodinaRodjenja;
        List<string> Naponena = new List<string>();


        public void Dodavanje(string ID, string status, string ime, string prezime, string pol, int godina_rodjenja, List<Napomena> napomena)
        {

        }
        public void IspravljanjePodataka(int ID)
        {

        }
        public void PromenaStatusa()
        {

        }

    }
}