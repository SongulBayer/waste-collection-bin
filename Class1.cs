using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_odevi
{
   
   
    internal class atikKutusu : IAtikKutusu //IAtik kutusundan aldığımız bilgileri sınıflarda değer atanabilecek hale getirdik.
    {
        private int _Kapasite;
        private int _DoluHacim;
        private int _DolulukOranı;
        private int _BoşaltmaPuanı;
        public int BoşaltmaPuanı 
        { 
            get => _BoşaltmaPuanı;
            set => _BoşaltmaPuanı = value;
        }
        
    
        public int Kapasite
        { 
            get => _Kapasite;
            set => _Kapasite=value; 
        }

        public int DoluHacim
        {
            get => _DoluHacim;
            set => _DoluHacim = value;
        }

        public int DolulukOranı
        {
            get =>  _DolulukOranı;
            set => _DolulukOranı = value;
            
        }
      
    }
   

}

