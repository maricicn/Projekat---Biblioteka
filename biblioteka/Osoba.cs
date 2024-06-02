using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Bibiloteka
{
    public class Osoba : Covek, IOsoba
        
    {
        
        public string ImeJednogRoditelja;
        public int DanRodjenja;
        public int MesecRodjenja;
        public string JMBG;
        public string AdresaUlicaBr;
        public string AdresaGrad;
        public int AdresaPostanskiBr;
        public string Telefon;
        public string Mail;

        string stepenstrucnespreme;
        public string StepenStrucneSpreme
        {
            get
            {
                return stepenstrucnespreme;
            }
            set
            {
                if (value == "I" || value == "II" || value == "III" || value == "IV" || value == "V" || value == "VI" || value == "VII" || value == "VIII" )
                {
                    stepenstrucnespreme = value;
                }
            }
        }

        public string SkolskoZvanje;

        public bool JMBGProvera()
        {
            if (JMBG.Length < 7)
            {
                return false; 
            }

            string danMesecGodina = DanRodjenja.ToString("D2") + MesecRodjenja.ToString("D2") + GodinaRodjenja.ToString("D3");
            string prvihSedamCifara = JMBG.Substring(0, 7);

            return danMesecGodina == prvihSedamCifara;
        }
        public void UzimanjeKnjige()
        {
        
        }
        public void VracanjeKnjige()
        {

        }
    }
}