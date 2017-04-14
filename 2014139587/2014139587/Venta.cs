using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139587
{
    public class Venta
    {
        List<Administrativo> _Administrativo;
        public Venta(int codAdmi)
        {
            _Administrativo = new List<Administrativo>(codAdmi);
        }

        List<Cliente> _Cliente;
        public int Venta1(int codCli)
        {
            _Cliente = new List<Cliente>(codCli);
            return codCli;
        }

        List<Servicio> _Servicio;
        public int Venta2(int codSer)
        {
            _Servicio = new List<Servicio>(codSer);
            return codSer;
        }

        List<TipoPago> _TipoPago;
        public int Venta3(int codTipPag)
        {
            _TipoPago = new List<TipoPago>(codTipPag);
            return codTipPag;
        }

        List<TipoComprobante> _TipoComprobante;
        public int Venta4 (int codTipComp)
        {
            _TipoComprobante = new List<TipoComprobante>(codTipComp);
            return codTipComp;
        }
    }
}
