using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_odevi
{
    class camAtikKutusu : atikKutusu//atikKutusu classından aldığımız özelliklere değer atama işlemi yaptık.
    {
        public camAtikKutusu()
        {
            Kapasite = 2200;
            BoşaltmaPuanı = 600;
            DolulukOranı = Kapasite * Convert.ToInt32(0.75);
            DoluHacim = 1650;
        }
    }
}
