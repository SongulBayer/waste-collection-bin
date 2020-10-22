using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_odevi
{
    class organikAtikKutusu : atikKutusu//atikKutusu classından aldığımız özelliklere değer atama işlemi yaptık.
    {

        public organikAtikKutusu()
        {
            Kapasite = 700;
            BoşaltmaPuanı = 0;
            DoluHacim = 525;
            DolulukOranı = Kapasite * Convert.ToInt32(0.75);

        }


    }
}
