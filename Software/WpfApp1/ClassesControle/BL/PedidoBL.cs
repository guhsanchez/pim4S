using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesControle.BL
{
    public class PedidoBL
    {
        private static PedidoBL instancia = null;
        private PedidoBL() { }
        public static PedidoBL getinstancia()
        {
            if (instancia == null)
                instancia = new PedidoBL();
            return instancia;
        }
    }
}
