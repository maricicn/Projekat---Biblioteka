using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;

namespace biblioteka
{
    internal class Data
    {
        public static string ImeFaJlaGDESECJUPOliCe = "OvdeSeCuvajuDugackeRavneDaskaPricvrscenaHorizontalnoCestoUzZidIliUOrmaricuTakoDaSeNaNjojMoguCuvatiPredmeti.csv";
        public static List<Pisac> ListaPisaca = new List<Pisac>();
        public static List<Knjiga> ListaKnjiga = new List<Knjiga>();
        public static List<Polica> listaPolica = new List<Polica>();
        public static List<Izdavanje> ListaIzdavanja = new List<Izdavanje>();
        public static List<Izdavanje> TrenutnaIzdavanja = new List<Izdavanje>();
        public static List<Vracanje> ListaVracanja = new List<Vracanje>();
        public static List<Citalac> ListaCitalaca = new List<Citalac>();
        public static List<Zakasnjenje> ListaZakasnjenja = new List<Zakasnjenje>();
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




        public static Citalac pomeranjeCitaoca(int g)
        {
            string indeks = g.ToString();
            Citalac c = new Citalac();
            for (int i = 0; i < ListaCitalaca.Count; i++)
            {
                if (ListaCitalaca[i].ID == indeks)
                {
                    c = ListaCitalaca[i];
                }
            }
            return c;
        }


        public static Bibliotekar pomeranjeBibliotekara(int g)
        {
            string indeks = g.ToString();
            Bibliotekar b = new Bibliotekar();
            for (int i = 0; i < Bibliotekar.bibliotekari.Count; i++)
            {
                if (ListaKnjiga[i].ID == indeks)
                {
                    b = Bibliotekar.bibliotekari[i];
                }
            }
            return b;
        }



        public static Knjiga pomeranjeKnjige(int g)
        {
            string indeks = g.ToString();
            Knjiga k = new Knjiga();
            for (int i = 0; i < ListaKnjiga.Count; i++)
            {
                if (ListaKnjiga[i].ID == indeks)
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
                if (ListaPisaca[i].ID == indeks)
                {
                    p = ListaPisaca[i];
                }
            }
            return p;
        }






        public static void DodajCitaoca(Citalac c)
        {
            ListaCitalaca.Add(c);
        }

        public static void SacuvajCitaoce()
        {
            try
            {
                StreamWriter sw = new StreamWriter("citaoci.csv");

                for (int i = 0; i < ListaCitalaca.Count; i++)
                {
                    Citalac c = ListaCitalaca[i];
                    string n = "";
                    string sk = "";
                    string stk = "";

                    if (c.Napomena.Count > 0)
                    {
                        for (int j = 0; j < c.Napomena.Count - 1; j++)
                        {
                            n += c.Napomena[j] + '$';
                        }
                        n += c.Napomena[c.Napomena.Count - 1];
                    }


                    if (c.SveKnjige.Count > 0)
                    {
                        for (int j = 0; j < c.SveKnjige.Count - 1; j++)
                        {
                            sk += c.SveKnjige[j] + '$';
                        }
                        sk += c.SveKnjige[c.SveKnjige.Count - 1];
                    }


                    if (c.SveTrenutneKnjige.Count > 0)
                    {
                        for (int j = 0; j < c.SveTrenutneKnjige.Count - 1; j++)
                        {
                            stk = c.SveTrenutneKnjige[j] + '$';
                        }
                        stk = c.SveTrenutneKnjige[c.SveTrenutneKnjige.Count - 1];
                    }

                    //string id, string status, string ime, string prezime, string pol, int godinarodjenja, string imejednogroditelja,
                    /*int danrodjenja, int mesecrodjenja, string jmbg, string adresaulicabr, string adresagrad, int adresapostanskibr, string telefon,
                        string mail, string stepenstrucnespreme, string skolskozvanje,
                        string TrenRadniStatus, string BrojIDDokumenta, string BrojClanskeKarte, DateTime PrviUpis, DateTime ProduzenjeClanstva,
                        float IznosClanarine, DateTime TrajanjeClanstva;*/
                    string x = c.PrviUpis.ToString();
                    sw.WriteLine(c.ID
                        + ";" + c.Status
                        + ";" + c.Ime
                        + ";" + c.Prezime
                        + ";" + c.Pol
                        + ";" + c.GodinaRodjenja
                        + ";" + c.ImeJednogRoditelja
                        + ";" + c.DanRodjenja
                        + ";" + c.MesecRodjenja
                        + ";" + c.JMBG
                        + ";" + c.AdresaUlicaBr
                        + ";" + c.AdresaGrad
                        + ";" + c.AdresaPostanskiBr
                        + ";" + c.Telefon
                        + ";" + c.Mail
                        + ";" + c.StepenStrucneSpreme
                        + ";" + c.SkolskoZvanje
                        + ";" + c.TrenRadniStatus
                        + ";" + c.BrojIDDokumenta
                        + ";" + c.BrojClanskeKarte
                        + ";" + c.PrviUpis
                        + ";" + c.ProduzenjeClanstva
                        + ";" + c.IznosClanarine
                        + ";" + c.TrajanjeClanstva
                        + ";" + sk + ";" + stk + ";" + n);
                }

                sw.Close();
            }
            catch (Exception e)
            {

            }
        }






        public static void UcitajCitaoce()
        {
            try
            {
                StreamReader sr = new StreamReader("citaoci.csv", true);
                while (!sr.EndOfStream)
                {
                    string l = sr.ReadLine();

                    List<string> delovi = new List<string>();
                    delovi = l.Split(';').ToList<string>();
                    //string[] delovi = l.Split(',');

                    List<string> napomene = new List<string>();
                    List<string> sveKnjige = new List<string>();
                    List<string> sveTrenutneKnjige = new List<string>();

                    napomene = delovi[delovi.Count - 1].Split('$').ToList<string>();
                    sveTrenutneKnjige = delovi[delovi.Count - 2].Split('$').ToList<string>();
                    sveKnjige = delovi[delovi.Count - 3].Split('$').ToList<string>();


                    
                    Citalac c = new Citalac(delovi[0], delovi[1], delovi[2], delovi[3], delovi[4], int.Parse(delovi[5]), delovi[6], int.Parse(delovi[7]), int.Parse(delovi[8]), delovi[9], delovi[10], delovi[11], int.Parse(delovi[12]), delovi[13], delovi[14], delovi[15], delovi[16], delovi[17], delovi[18], delovi[19], DateTime.Parse(delovi[20]), DateTime.Parse(delovi[21]), float.Parse(delovi[22]), DateTime.Parse(delovi[23]), sveKnjige, sveTrenutneKnjige, napomene);
                    ListaCitalaca.Add(c);
                }
                sr.Close();
            }
            catch (Exception e)
            {

            }
        }








        public static void SacuvajKnjige()
        {
            try
            {
                StreamWriter sw = new StreamWriter("knjige.csv");

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



                    sw.WriteLine(k.ID + ";" +
                        k.Status + ";" +
                        k.Naziv + ";" +
                        k.Zanr + ";" +
                        k.RedniBrojIzdanja + ";" +
                        k.GodinaIzdavanja + ";" +
                        k.Izdavac + ";" +
                        k.ISBN + ";" +
                        k.Stanje + ";" +
                        k.Prostorija + ";" +
                        k.Polica + ";" +
                        k.UkupanBrojPrimeraka + ";" +
                        k.Citalac + ";" +
                        k.Bibliotekar + ";" +
                        k.DatumIzdavanja + ";" +
                        k.RokZaVracanje + si + ";" + p + ";" + n);
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
                StreamReader sr = new StreamReader("knjige.csv", true);
                while (!sr.EndOfStream)
                {
                    string l = sr.ReadLine();

                    List<string> delovi = new List<string>();
                    delovi = l.Split(';').ToList<string>();
                    //string[] delovi = l.Split(',');

                    List<string> napomene = new List<string>();
                    List<string> SvaIzdanja = new List<string>();
                    List<string> Pisac = new List<string>();

                    napomene = delovi[delovi.Count - 1].Split('$').ToList<string>();
                    SvaIzdanja = delovi[delovi.Count - 3].Split('$').ToList<string>();
                    Pisac = delovi[delovi.Count - 2].Split('$').ToList<string>();


                    //sva izdanja, pisac, napomena;
                    Knjiga k = new Knjiga(delovi[0], delovi[1], delovi[2], delovi[3], int.Parse(delovi[4]), int.Parse(delovi[5]), delovi[6], delovi[7], delovi[8], delovi[9], delovi[10], int.Parse(delovi[11]), delovi[12], delovi[13], DateTime.Parse(delovi[14]), DateTime.Parse(delovi[15]), SvaIzdanja, Pisac, napomene);
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
                StreamReader sr = new StreamReader("pisci.csv", true);
                while (!sr.EndOfStream)
                {
                    string l = sr.ReadLine();
                    string[] delovi = l.Split(';');

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
        /*public static void UcitajIzdavanja()
        {
            ListaIzdavanja.Clear();
            try
            {
                StreamReader izdavanja = new StreamReader("izdavanjeFile.csv");
                while (!izdavanja.EndOfStream)
                {
                    string l = izdavanja.ReadLine();
                    string[] delovi = l.Split(';');

                    //List<string> napomene = new List<string>();
                    //if (delovi.Length >= 7)
                    //{
                    //    napomene = delovi[6].Split('$').ToList<string>();
                    //}
                    string knjiga = delovi[1];
                    for(int j = 0; j < Data.ListaKnjiga.Count; j++)
                    {
                        if ((Data.ListaKnjiga[j].ID + " " + Data.ListaKnjiga[j].Naziv) == knjiga)
                        {
                            if (Data.ListaKnjiga[j].Stanje.ToLower() == "izdata") {
                                Izdavanje i = new Izdavanje(delovi[0], delovi[1], DateTime.Parse(delovi[3]), DateTime.Parse(delovi[4]), delovi[2]);
                                ListaIzdavanja.Add(i);
                            }
                        }
                    }
                    
                    //string id, string status, string ime, string prezime, string pol, int godinarodjenja, List<string> napomena
                }
                izdavanja.Close();
            }
            catch (Exception e)
            {

            }
        }*/
        public static void UcitajIzdavanja()
        {
            ListaIzdavanja.Clear();
            try
            {
                StreamReader izdavanja = new StreamReader("izdavanjeFile.csv");
                while (!izdavanja.EndOfStream)
                {
                    string l = izdavanja.ReadLine();
                    string[] delovi = l.Split(';');
                    Izdavanje i = new Izdavanje(delovi[0], delovi[1], DateTime.Parse(delovi[3]), DateTime.Parse(delovi[4]), delovi[2]);
                    ListaIzdavanja.Add(i);
                }
                izdavanja.Close();
            }
            catch(Exception e)
            {

            }
        }
        public static void UcitajVracanja()
        {
            ListaVracanja.Clear();
            try
            {
                StreamReader vracanje = new StreamReader("vracanjeFile.csv");
                while (!vracanje.EndOfStream)
                {
                    string l = vracanje.ReadLine();
                    string[] delovi = l.Split(';');
                    Vracanje v = new Vracanje(delovi[0], delovi[1], DateTime.Parse(delovi[3]), DateTime.Parse(delovi[4]), delovi[2], delovi[5], int.Parse(delovi[6]));
                    ListaVracanja.Add(v);
                }
                vracanje.Close();
            }
            catch (Exception e)
            {

            }
        }
        public static void PopuniListuZakasnjenja()
        {
            ListaZakasnjenja.Clear();
            for (int i = 0; i < ListaIzdavanja.Count; i++)
            {
                if (ListaIzdavanja[i].rokzavracanje < DateTime.Now)
                {
                    string citalac = ListaIzdavanja[i].citalac;
                    string knjiga = ListaIzdavanja[i].knjiga;
                    int zaks = (DateTime.Now- ListaIzdavanja[i].rokzavracanje).Days;
                    Zakasnjenje zak = new Zakasnjenje(citalac, knjiga, zaks);
                    ListaZakasnjenja.Add(zak);

                }
            }
        }

        public static void SacuvajPisce()
        {
            StreamWriter sw = new StreamWriter("pisci.csv");

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
                


                sw.WriteLine(p.ID + ";" + p.Status + ";" + p.Ime + ";" + p.Prezime + ";" + p.Pol + ";" + p.GodinaRodjenja + ";" + n);
            }

            sw.Close();
        }




        public static void ucitajBibliotekare()
        {
            try
            {
                StreamReader sr = new StreamReader("Bibliotekari.csv", true);
                while (!sr.EndOfStream)
                {
                    string l = sr.ReadLine();
                    string[] delovi = l.Split(';');

                    List<string> napomene = new List<string>();
                    List<string> SveIzdateKnjige = new List<string>();
                    List<string> SvePrimljeneKnjige = new List<string>();

                    napomene = delovi[6].Split('$').ToList<string>();
                    SveIzdateKnjige = delovi[delovi.Length - 2].Split('$').ToList<string>();
                    SvePrimljeneKnjige = delovi[delovi.Length - 1].Split('$').ToList<string>();




                    Bibliotekar bib = new Bibliotekar(delovi[0], delovi[1], delovi[2], delovi[3], delovi[4], int.Parse(delovi[5]), napomene, delovi[7], int.Parse(delovi[8]), int.Parse(delovi[9]), delovi[10], delovi[11], delovi[12], int.Parse(delovi[13]), delovi[14], delovi[15], delovi[16], delovi[17], delovi[18], DateTime.Parse(delovi[19]), delovi[20], delovi[21], SveIzdateKnjige, SvePrimljeneKnjige);
                    //bib.WriteLine(Convert.ToString(Bibliotekar.id) + ";" + b.Status + ";" + b.Ime + ";" + b.Prezime + ";" + b.Pol + ";" + Convert.ToString(b.GodinaRodjenja) + ";" + n + ";" + b.ImeJednogRoditelja + ";" + Convert.ToString(b.DanRodjenja) + ";" + Convert.ToString(b.MesecRodjenja) + ";" + b.JMBG + ";" + b.AdresaUlicaBr + ";" + b.AdresaGrad + ";" + Convert.ToString(b.AdresaPostanskiBr) + ";" + b.Telefon + ";" + b.Mail + ";" + b.StepenStrucneSpreme + ";" + b.SkolskoZvanje + ";" + b.RadnaPozicija + ";" + Convert.ToString(b.DatumZaposlenja) + ";" + b.KorisnickoIme + ";" + b.Lozinka);
                    
                    Bibliotekar.bibliotekari.Add(bib);
                    //Bibliotekar.id++;
                    //string id, string status, string ime, string prezime, string pol, int godinarodjenja, List<string> napomena
                }
                sr.Close();
            }
            catch (Exception e)
            {

            }
        }



        public static void sacuvajBibliotekare()
        {
            try
            {
                StreamWriter bib = new StreamWriter("Bibliotekari.csv");

                for (int i = 0; i < Bibliotekar.bibliotekari.Count; i++)
                {
                    Bibliotekar b = Bibliotekar.bibliotekari[i];
                    string n = "";
                    string sik = "";
                    string spk = "";

                    if (b.Napomena.Count > 0)
                    {
                        for (int j = 0; j < b.Napomena.Count - 1; j++)
                        {
                            n += b.Napomena[j] + '$';
                        }
                        n += b.Napomena[b.Napomena.Count - 1];
                    }

                    if (b.SveIzdateKnjige.Count > 0)
                    {
                        for (int j = 0; j < b.SveIzdateKnjige.Count - 1; j++)
                        {
                            sik += b.SveIzdateKnjige[j] + '$';
                        }
                        sik += b.SveIzdateKnjige[b.SveIzdateKnjige.Count - 1];
                    }


                    if (b.SvePrimljeneKnjige.Count > 0)
                    {
                        for (int j = 0; j < b.SvePrimljeneKnjige.Count - 1; j++)
                        {
                            spk = b.SvePrimljeneKnjige[j] + '$';
                        }
                        spk = b.SvePrimljeneKnjige[b.SvePrimljeneKnjige.Count - 1];
                    }

                    bib.WriteLine(b.ID + ";" + b.Status + ";" + b.Ime + ";" + b.Prezime + ";" + b.Pol + ";" + Convert.ToString(b.GodinaRodjenja) + ";" + n + ";" + b.ImeJednogRoditelja + ";" + Convert.ToString(b.DanRodjenja) + ";" + Convert.ToString(b.MesecRodjenja) + ";" + b.JMBG + ";" + b.AdresaUlicaBr + ";" + b.AdresaGrad + ";" + Convert.ToString(b.AdresaPostanskiBr) + ";" + b.Telefon + ";" + b.Mail + ";" + b.StepenStrucneSpreme + ";" + b.SkolskoZvanje + ";" + b.RadnaPozicija + ";" + Convert.ToString(b.DatumZaposlenja) + ";" + b.KorisnickoIme + ";" + b.Lozinka + ";" + sik + ";" + spk);

                }

                bib.Close();
            }
            catch (Exception e)
            {

            }
        }





        public static void DodajPolicu(Polica p)
        {
            listaPolica.Add(p);
            for (int i = 0; i < prostorGdeSeNalazeProstorije.Count; i++)
            {
                if(p.p == prostorGdeSeNalazeProstorije[i].o)
                {
                    prostorGdeSeNalazeProstorije[i].p.Add(p);
                    SCUVAj();
                }
            }
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