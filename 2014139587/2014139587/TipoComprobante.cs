using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139587
{
    public class TipoComprobante
    {
        public string _TipoComprob;

        public string TipoComprob
        {
            get
            {
                return _TipoComprob;
            }

            set
            {
                if (_TipoComprob.Count() > 0)
                    _TipoComprob = value;
            }
        }

        public TipoComprobante ( string tipoComprob)
        {
            TipoComprob = tipoComprob;
        }
    }
}
