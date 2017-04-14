using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139587
{
    class Encomienda : Servicio
    {
        public DateTime FechaServicio  {get; set;}

        public void descServicio()
        {
            Console.WriteLine("La encomienda " + this.descEncomienda);
        }
    }
}
