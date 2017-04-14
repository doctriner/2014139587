using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139587
{
    public class TipoViaje
    {
        public int _CategoriaViaje;

        public int CategoriaViaje
        {
            get
            {
                return _CategoriaViaje;
            }

            set
            {
                if (value >0)
                    _CategoriaViaje= value;
            }      
        }

        public TipoViaje (int categoriaViaje)
        {
            CategoriaViaje = categoriaViaje;
        }
        
     }
}
