using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Reflection;

namespace biblioteka
{
    internal class Data
    {
        public static string ImeFaJlaGDESECJUPOliCe = "OvdeSeCuvajuDugackeRavneDaskaPricvrscenaHorizontalnoCestoUzZidIliUOrmaricuTakoDaSeNaNjojMoguCuvatiPredmeti.csv";
        public static List<Pisac> ListaPisaca = new List<Pisac>();
        public static List<Knjiga> ListaKnjiga = new List<Knjiga>();
        public static List<Polica> listaPolica = new List<Polica>();
        public static int IP;
        public static int IP1;
        public static List<Prostorija> prostorGdeSeNalazeProstorije = new List<Prostorija>();

        public static string ImeFaJlaGDESECJUprost = "prostor unutar građevine. Najčešće je odvojena zidom i vratima.csv";

        public static void DodajPisca(Pisac p)
        {
            ListaPisaca.Add(p);
        }
        public static void DodajKnjigu(Knjiga k)
        {
            ListaKnjiga.Add(k);
        }



        public static Knjiga pomeranjeKnjige(int g)
        {
            string indeks = g.ToString();
            Knjiga k = new Knjiga();
            for (int i = 0; i < ListaKnjiga.Count; i++)
            {
                if(ListaKnjiga[i].ID == indeks)
                {
                    k = ListaKnjiga[i];
                }
            }
            return k;
        }

        public static Pisac pomeranjePisca(int g)
        {
            string indeks = g.ToString();
            Pisac p = new Pisac();
            for (int i = 0; i < ListaPisaca.Count; i++)
            {
                if(ListaPisaca[i].ID == indeks)
                {
                    p = ListaPisaca[i];
                }
            }
            return p;
        }

        public static void SacuvajKnjige()
        {
            try
            {
                StreamWriter sw = new StreamWriter("knjige.txt");

                for (int i = 0; i < ListaKnjiga.Count; i++)
                {
                    Knjiga k = ListaKnjiga[i];
                    string si = "";
                    string p = "";
                    string n = "";

                    if (k.Napomena.Count > 0)
                    {
                        for (int j = 0; j < k.Napomena.Count - 1; j++)
                        {
                            n += k.Napomena[j] + '$';
                        }
                        n += k.Napomena[k.Napomena.Count - 1];
                    }


                    if (k.Pisac.Count > 0)
                    {
                        for (int j = 0; j < k.Pisac.Count - 1; j++)
                        {
                            p += k.Pisac[j] + '$';
                        }
                        p += k.Pisac[k.Pisac.Count - 1];
                    }


                    if (k.SvaIzdavanja.Count > 0)
                    {
                        for (int j = 0; j < k.SvaIzdavanja.Count - 1; j++)
                        {
                            p = k.SvaIzdavanja[j] + '$';
                        }
                        p = k.SvaIzdavanja[k.SvaIzdavanja.Count - 1];
                    }



                    sw.WriteLine(k.ID + "," +
                        k.Status + "," +
                        k.Naziv + "," +
                        k.Zanr + "," +
                        k.RedniBrojIzdanja + "," +
                        k.GodinaIzdavanja + "," +
                        k.Izdavac + "," +
                        k.ISBN + "," +
                        k.Stanje + "," +
                        k.Prostorija + "," +
                        k.Polica + "," +
                        k.UkupanBrojPrimeraka + "," +
                        k.Citalac + "," +
                        k.Bibliotekar + "," +
                        k.DatumIzdavanja + "," +
                        k.RokZaVracanje + si + "," + p + "," + n);
                }

                sw.Close();
            }
            catch (Exception e) 
            {

            }

        }

        public static void UcitajKnjige()
        {
            try
            {
                StreamReader sr = new StreamReader("knjige.txt", true);
                while (!sr.EndOfStream)
                {
                    string l = sr.ReadLine();

                    List<string> delovi = new List<string>();
                    delovi = l.Split(',').ToList<string>();
                    //string[] delovi = l.Split(',');

                    List<string> napomene = new List<string>();
                    List<string> SvaIzdanja = new List<string>();
                    List<string> Pisac = new List<string>();
                    if (delovi.Count >= 7)
                    {
                        napomene = delovi[delovi.Count-1].Split('$').ToList<string>();
                        SvaIzdanja = delovi[delovi.Count - 2].Split('$').ToList<string>();
                        Pisac = delovi[delovi.Count - 3].Split('$').ToList<string>();
                    }

                    //sva izdanja, pisac, napomena;
                    Knjiga k = new Knjiga(delovi[0], delovi[1], delovi[2], delovi[3], int.Parse(delovi[4]), int.Parse(delovi[5]), delovi[6], delovi[7],delovi[8], delovi[9], delovi[10], int.Parse(delovi[11]), delovi[12], delovi[13], delovi[14], delovi[15] ,SvaIzdanja, Pisac,napomene);
                    ListaKnjiga.Add(k);
                }
                sr.Close();
            }
            catch (Exception e)
            {

            }
        }

        public static void UP1()
        {
            prostorGdeSeNalazeProstorije.Clear();
            if (!File.Exists(ImeFaJlaGDESECJUprost)) return;
            StreamReader sr = new StreamReader(ImeFaJlaGDESECJUprost);
            foreach (string l in sr.ReadToEnd().Split('\n'))
            {
                if (string.IsNullOrEmpty(l)) continue;
                prostorGdeSeNalazeProstorije.Add(new Prostorija(l));
            }
            sr.Close();
        }

        public static void UP()
        {
            listaPolica.Clear();
            if (!File.Exists(ImeFaJlaGDESECJUPOliCe)) return;
            StreamReader sr = new StreamReader(ImeFaJlaGDESECJUPOliCe);
            foreach (string l in sr.ReadToEnd().Split('\n'))
            {
                if (string.IsNullOrEmpty(l)) continue;
                listaPolica.Add(new Polica(l));
            }
            sr.Close();
        }

        public static void UcitajPisce()
        {
            try
            {
                StreamReader sr = new StreamReader("pisci.txt", true);
                while (!sr.EndOfStream)
                {
                    string l = sr.ReadLine();
                    string[] delovi = l.Split(',');

                    List<string> napomene = new List<string>();
                    if (delovi.Length >= 7)
                    {
                        napomene = delovi[6].Split('$').ToList<string>();
                    }

                    Pisac p = new Pisac(delovi[0], delovi[1], delovi[2], delovi[3], delovi[4], int.Parse(delovi[5]), napomene);
                    ListaPisaca.Add(p);
                    //string id, string status, string ime, string prezime, string pol, int godinarodjenja, List<string> napomena
                }
                sr.Close();
            }
            catch (Exception e)
            {
                
            }
        }

        public static void SacuvajPisce()
        {
            StreamWriter sw = new StreamWriter("pisci.txt");

            for (int i = 0; i < ListaPisaca.Count; i++)
            {
                Pisac p = ListaPisaca[i];
                string n = "";

                if (p.Napomena.Count > 0)
                {
                    for (int j = 0; j < p.Napomena.Count - 1; j++)
                    {
                        n += p.Napomena[j] + '$';
                    }
                    n += p.Napomena[p.Napomena.Count - 1];
                }
                


                sw.WriteLine(p.ID + "," + p.Status + "," + p.Ime + "," + p.Prezime + "," + p.Pol + "," + p.GodinaRodjenja + "," + n);
            }

            sw.Close();
        }

        public static void DodajPolicu(Polica p)
        {
            listaPolica.Add(p);
        }

        public void PromenaPolice(string ID, Polica n)
        {
            for (int i = 0; i < listaPolica.Count; i++)
            {
                if (listaPolica[i].Id == ID)
                {
                    listaPolica[i] = n;
                    SP();
                    return;
                }
            }
            MessageBox.Show("Polica sa datim ID-jem ne postoji");
        }

        public static void UDP()
        {
            IP =(IP + 1)%listaPolica.Count;
        }

        public static Polica GP1()
        {
            try
            {
                return listaPolica[IP];
            }
            catch
            {
                IP = 1;
                return listaPolica[0];
            }
        }

        public static Prostorija GP2()
        {
            try
            {
                return prostorGdeSeNalazeProstorije[IP1];
            }
            catch
            {
                IP1 = 0;
                return prostorGdeSeNalazeProstorije[0];
            }
        }

        public static Polica FP(string ln)
        {
            if (ln.EndsWith("\r"))
            {
                ln = ln.Substring(0, ln.Length - 1);
            }
            for (int i = 0; i < listaPolica.Count; i++)
            {
                if (listaPolica[i].Id == ln)
                {
                    SP();
                    return listaPolica[i];
                }
            }
            throw new Exception("Ne postoji polica sa datim ID-jem");
        }

        public static void ULP()
        {
            IP= (IP - 1+listaPolica.Count) % listaPolica.Count;
        }

        public static void NP()
        {
            IP = - 1;
        }

        public static void SP()
        {
            SacuvajListu(listaPolica, ImeFaJlaGDESECJUPOliCe);
        }

        public static void DP(Prostorija pROStorija)
        {
            prostorGdeSeNalazeProstorije.Add(pROStorija);
        }

        public static void SCUVAj()
        {
            SacuvajListu(prostorGdeSeNalazeProstorije, ImeFaJlaGDESECJUprost);
        }

        public static void SacuvajListu<T>(List<T> listazaCuvanje, string imeFajla){
            StreamWriter upisivac = new StreamWriter(imeFajla);
            for (int i = 0; i < listazaCuvanje.Count; i++)
            {
                upisivac.WriteLine(listazaCuvanje[i].ToString());
            }
            upisivac.Close();
        }
    }
}