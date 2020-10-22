using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_odevi
{
    class kagitAtikKutusu : atikKutusu//atikKutusu classından aldığımız özelliklere değer atama işlemi yaptık.
    {
        public kagitAtikKutusu()
        {
            Kapasite = 1200;
            BoşaltmaPuanı = 1000;
            DolulukOranı = Kapasite * Convert.ToInt32(0.75);
            DoluHacim = 900;
        }

    }
}
