using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139587
{
    public class Cliente
    {
        public int _codCliente;

        public int codCliente
        {
            get
            {
                return _codCliente;
            }

            set
            {
                if (value>0)
                   _codCliente = value;
            }
        }

        public Cliente (int codigo)
        {
            codCliente = codigo;
        }


    }

}
