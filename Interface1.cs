using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_odevi
{
    public interface IDolabilen//kullandığımız atık kutuları ile ilgili bilgileri classlarda kullanmak için interface içine aldık.
    {
        int Kapasite { get; set; }
        int DoluHacim { get; }
        int DolulukOranı { get; }
    }
}
