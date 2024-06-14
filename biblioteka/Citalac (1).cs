using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace biblioteka
{
    internal class Citalac : Osoba, ICitalac
    {
        public string TrenRadniStatus;
        public string BrojIDDokumenta;
        public string BrojClanskeKarte;
        public DateTime PrviUpis;
        public DateTime ProduzenjeClanstva;
        public float IznosClanarine;
        public DateTime TrajanjeClanstva;
        public List<Izdavanje> SveKnjige = new List<Izdavanje>();
        public List<Izdavanje> SveTrenutneKnjige = new List<Izdavanje>();

        public Citalac(string id, string status, string ime, string prezime, string pol, int godinarodjenja, List<string> napomena, string imejednogroditelja, 
                        int danrodjenja, int mesecrodjenja, string jmbg, string adresaulicabr, string adresagrad, int adresapostanskibr, string telefon,
                        string mail, string stepenstrucnespreme, string skolskozvanje, 
                        string TrenRadniStatus, string BrojIDDokumenta, string BrojClanskeKarte, DateTime PrviUpis, DateTime ProduzenjeClanstva,
                        float IznosClanarine, DateTime TrajanjeClanstva, List<Izdavanje> SveKnjige, List<Izdavanje> SveTrenutneKnjige)
            : base(id, status, ime, prezime, pol, godinarodjenja, napomena, imejednogroditelja, danrodjenja, mesecrodjenja, jmbg, adresaulicabr, 
                  adresagrad, adresapostanskibr, telefon, mail, stepenstrucnespreme, skolskozvanje)
        {
            this.TrenRadniStatus = TrenRadniStatus;
            this.BrojIDDokumenta = BrojIDDokumenta;
            this.BrojClanskeKarte = BrojClanskeKarte;
            this.PrviUpis = PrviUpis;
            this.ProduzenjeClanstva = ProduzenjeClanstva;
            this.IznosClanarine = IznosClanarine;
            this.TrajanjeClanstva = TrajanjeClanstva;
            this.SveKnjige = SveKnjige;
            this.SveTrenutneKnjige = SveTrenutneKnjige;
        }
        public Citalac()
        {

        }





    }
}