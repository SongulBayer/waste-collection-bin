using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_odevi
{

    class metalAtikKutusu : atikKutusu//atikKutusu classından aldığımız özelliklere değer atama işlemi yaptık.
    {
        public metalAtikKutusu()
        {
            Kapasite = 2300;
            BoşaltmaPuanı = 800;
            DoluHacim = 1725;
            DolulukOranı = Kapasite * Convert.ToInt32(0.75);
        }
    }
}
