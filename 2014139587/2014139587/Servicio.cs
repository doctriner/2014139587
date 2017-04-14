using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139587
{
    public abstract class Servicio
    {
        public int codEncomienda {get; set; }
        public string descEncomienda {get; set;}

        public Servicio()
        {
        }

        public Servicio (string descripcion)
        {
            descEncomienda = descripcion;
        }



    }
}
