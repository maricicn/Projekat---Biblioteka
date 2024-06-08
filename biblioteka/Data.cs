using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;

namespace biblioteka
{
    internal class Data
    {
        public static List<Pisac> ListaPisaca = new List<Pisac>();
        public static List<Knjiga> ListaKnjiga = new List<Knjiga>();

        public static void DodajPisca(Pisac p)
        {
            ListaPisaca.Add(p);
        }
        public static void DodajKnjigu(Knjiga k)
        {
            ListaKnjiga.Add(k);
        }


        public static void SacuvajKnjige()
        {
            StreamWriter sw = new StreamWriter("Knjige.txt.tmp");

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
            File.Delete("knjige.txt");
            File.Move("knjige.txt.tmp", "knjige.txt");

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
        

    }
}