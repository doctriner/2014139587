using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139587
{
    public class Administrativo : Empleado
    {
        public DateTime FechaRegistro { get; set; }

        public void Identificarse()
        {
            Console.WriteLine(" Soy un administrador, " + "mi numero de DNI es " + this.DNI);
        }

        public Administrativo()
        {

        }

        public Administrativo(string dni): base(dni)
        {

        }
    }
}
