using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salarios.models
{
    internal class SallarySalesman
    {
        private const int PagoFijo = 200;
        private const double Comision = 0.09;

        public int GetSallary(int ventasBrutas)
        {
            return (int)(PagoFijo + (ventasBrutas * Comision));
        }
    }
}
