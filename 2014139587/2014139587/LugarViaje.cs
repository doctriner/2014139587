﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139587
{
    public class LugarViaje
    {
        public List<TipoLugar> _TipoLugares;

        public LugarViaje(int tipLugares)
        {
            _TipoLugares = new List<TipoLugar>(tipLugares);
        }
    }
}
