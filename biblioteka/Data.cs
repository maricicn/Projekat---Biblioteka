using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace biblioteka
{
    internal class Data
    {
        public static List<Pisac> ListaPisaca = new List<Pisac>();

        public static void DodajPisca(Pisac p)
        {
            ListaPisaca.Add(p);
        }

        public static void UcitajPisce()
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

        public static void SacuvajPisce()
        {
            StreamWriter sw = new StreamWriter("pisci.txt");

            for (int i = 0; i < ListaPisaca.Count; i++)
            {
                Pisac p = ListaPisaca[i];
                string n = "";
                for (int j = 0; j < p.Napomena.Count; j++)
                {
                    n += p.Napomena[j] + '$';
                }


                sw.WriteLine(p.ID + "," + p.Status + "," + p.Ime + "," + p.Prezime + "," + p.Pol + "," + p.GodinaRodjenja + "," + n);
            }

            sw.Close();
        }

    }
}