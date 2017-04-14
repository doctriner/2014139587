using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139587
{
    public class TipoTripulacion
    {
        public int _TipoTrip;

        public int TipoTrip
        {
            get
            {
                return _TipoTrip;
            }

            set
            {
                if (value > 0)
                    _TipoTrip = value;
            }
        }

        public TipoTripulacion (int tipoTrip)
        {
            TipoTrip = tipoTrip;
        }
    }
}
