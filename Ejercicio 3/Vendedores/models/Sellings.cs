using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendedores.models
{
    public class Sellings
    {
        public int Seller { get; set; }
        public int Product { get; set; }
        public float SellValue { get; set; }

        public Sellings(int vendedor, int producto, float valorVenta)
        {
            Seller = vendedor;
            Product = producto;
            SellValue = valorVenta;
        }
    }
}
