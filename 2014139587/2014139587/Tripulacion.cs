using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139587
{
    public class Tripulacion : Empleado
    {
        public DateTime FechaContratacion { get; set; }

        public void Identificarse()
        {
            Console.WriteLine("Soy un tripulante, " + "mi numero de DNI es " + this.DNI);
        }

        public Tripulacion()
        {

        }

        public Tripulacion (string dni) : base(dni)
        {

        }
    }
}
