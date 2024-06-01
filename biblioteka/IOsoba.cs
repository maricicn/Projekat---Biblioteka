using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bibiloteka
{
    public interface IOsoba : ICovek
    {
        bool JMBGProvera();
        void UzimanjeKnjige();
        void VracanjeKnjige();
    }
}