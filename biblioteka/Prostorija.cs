using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace biblioteka
{
    internal class Prostorija : IProstorija
    {
        string ID;
        public string Id
        {
            get
            {
                return ID;
            }
        }
        public string o;
        public List<Polica> p = new List<Polica>();
        public bool L_Aktivan;

        public Prostorija(string lID, string lo, List<Polica> llp, bool lla)
        {
            if (string.IsNullOrEmpty(lID) || string.IsNullOrEmpty(lo) || llp == null) return;
            ID = lID;
o = lo;
            p = llp;
            L_Aktivan = lla;
        }

        public Prostorija(string lID, string lo, bool lla)
        {
            if (string.IsNullOrEmpty(lID) || string.IsNullOrEmpty(lo)) return;
            ID = lID;
            o = lo;
            L_Aktivan = lla;
        }

        public Prostorija(string s)
        {
            string[] S = s.Split(';');
            //if (S.Length != 3) return;
            ID = S[0];
            o = S[1];
            L_Aktivan = S[2].Trim() == "True";
            for (int i = 3; i < S.Length; i++)
            {
                p.Add(Data.FP(S[i]));
            }
        }

        public void Dodavanje(string ID, string lo, List<string> lp, List<Napomena> napomena)
        {
            if (string.IsNullOrEmpty(ID)) return;
            if (string.IsNullOrEmpty(lo)) return;
            if (lp == null) return;
            MessageBox.Show("Dodaj;");
        }
        public void IspravljanjePodataka(int ID)
        {
            MessageBox.Show("Ova funkcija nema dovoljno podataka da uradi apsolutno bilo sta, da bi mogao da promenim listu treba mi lista, tj. pokazivac na listu kao argument. Takodje nemam informaciju sta treba da budo novi podaci na mestu na koje mi ID pokazuje. Nemam ideju zasto postoji interfejs koji me tera da drzim ovu funkciju, ali postoji tako da cu je napraviti tako da nema nikakvu svrhu, koju nemoze da ima zbog malopre navedenih razloga, ali ce da ispisuje nesto sto mislim da niko nikada nece procitati do kraja");
        }
        public void PromenaStatusa()
        {
            L_Aktivan = !L_Aktivan;
        }

        public override string ToString()
        {
            string s = "";
            foreach (Polica lp in p)
            {
                s = $"{s};{lp.Id}";
            }
            return $"{ID};{o};{L_Aktivan}{s}";
        }
    }
}