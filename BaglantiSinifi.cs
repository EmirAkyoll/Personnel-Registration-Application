using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Kayıt_Uygulaması_veritabanlı_
{
    class BaglantiSinifi
    {
        public string Adres = System.IO.File.ReadAllText(@"C:\SQLAdresi.txt");
    }
}
