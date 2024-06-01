using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bibiloteka
{
    public class Covek : ICovek
    {

        public string ID;

        string status;
        string Status
        {
            get 
            { 
                return status; 
            }
            set 
            {
                if (value == "Aktivan" || value == "Neaktivan")
                {
                    status = value;
                }          
            }
        }

        public string Ime;
        public string Prezime;

        string pol;
        string Pol
        {
            get
            {
                return pol;
            }
            set
            {
                if (value == "Muski" || value == "Zenski")
                {
                    pol = value;    
                }
            }

        }
        public int GodinaRodjenja;
        public List<string> Naponena = new List<string>();

        public Covek(string id, string status, string ime, string prezime, string pol, int godinarodjenja, List<string> napomena)
        {
            this.ID = id;
            this.Status = status;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Pol = pol;
            this.GodinaRodjenja = godinarodjenja;
            this.Naponena = napomena;
        }

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