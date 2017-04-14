using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139587
{
    public class TipoLugar
    {
        public string _TipoLugarDesc;

        public string TipoLugarDesc
        {
            get
            {
                return  _TipoLugarDesc;
            }

            set
            {
                if (_TipoLugarDesc.Count() > 0)
                    _TipoLugarDesc = value;
               
            }
        }

        public TipoLugar(string tipoLugar)
        {
            _TipoLugarDesc = tipoLugar;
        }

    }
}
