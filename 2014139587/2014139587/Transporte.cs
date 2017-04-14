using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139587
{
    public class Transporte : Servicio
    {
        List<TipoViaje> _TipoViaje;
        public  Transporte (int numViaje)
        {
            _TipoViaje = new List<TipoViaje>(numViaje);
        }

        List<LugarViaje> _LugarViaje;
        public int Transporte1 (int numLugar)
        {
            _LugarViaje = new List<LugarViaje>(numLugar);
            return numLugar;
        }

        List<Cliente> _Cliente;
        public int Transporte2 (int numCliente)
        {
            _Cliente = new List<Cliente>(numCliente);
            return numCliente;
        }

        List<Bus> _numBus;
        public int Transporte3(int bus)
        {
            _numBus = new List<Bus>(bus);
            return bus;
        }
    }
}
