﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139587
{
    public class Transporte : Servicio
    {
        public List<Bus> _Bus;
        private TipoViaje _TipoViaje;
        private Cliente _Cliente;
        private LugarViaje _LugarViaje;
        public List<Bus> bus
        {
            get { return _Bus; }
            set { if (value.Count > 0) _Bus = value; }
        }
        public Transporte(TipoViaje tipoViaje, Cliente cliente, LugarViaje lugarViaje)
        {
            _TipoViaje = tipoViaje;
            _Cliente = cliente;
            _LugarViaje = lugarViaje;
        }
        public Transporte(string servicioDesc)
            : base(servicioDesc)
        { }
        public Transporte(List<Bus> bus)
        {
            _Bus = bus;
        }
    }
}
