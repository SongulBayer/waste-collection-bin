using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_odevi
{
    class Atik : IAtik //IAtik interfacesinden aldığımız özelliğe değer atanabilecek duruma getirdik.
    {
        protected int _hacim;


        int IAtik.hacim { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int hacim
        {
            get { return _hacim; }
        }



    }
}
