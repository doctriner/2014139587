using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139587
{
    public class TipoPago
    {
        public int _TipoPagoDesc;

        public int TipoPagoDesc
        {
            get
            {
                return _TipoPagoDesc;
            }

            set
            {
                if (value > 0)
                    _TipoPagoDesc = value;
            }
        }
         
        public TipoPago (int tipoPagoDesc)
        {
            TipoPagoDesc = tipoPagoDesc;
        }
    }
}
