using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendedores.models;

namespace Vendedores
{
    public partial class Form1 : Form
    {
        private List<Sellings> ventas = new List<Sellings>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddSell_Click(object sender, EventArgs e)
        {
            int vendedor = int.Parse(tbSeller.Text);
            int producto = int.Parse(tbProduct.Text);
            float valorVenta = float.Parse(tbSell.Text);

            // Validar que los valores ingresados estén dentro del rango permitido
            if (vendedor >= 1 && vendedor <= 4 && producto >= 1 && producto <= 5)
            {
                // Crear una nueva venta y agregarla a la lista de ventas
                Sellings nuevaVenta = new Sellings(vendedor, producto, valorVenta);
                ventas.Add(nuevaVenta);

                MessageBox.Show("Se agrego la nueva venta");
            }
            else
            {
                MessageBox.Show("Error: El vendedor o el producto esta fuera del rango");
            }

            // Limpiar campos de texto
            tbSeller.Clear();
            tbProduct.Clear();
            tbSell.Clear();
        }

        private void btnShowSummary_Click(object sender, EventArgs e)
        {
            float[,] resumenVentas = new float[5, 4];

            // Sumar las ventas por vendedor y producto
            foreach (Sellings venta in ventas)
            {
                resumenVentas[venta.Product - 1, venta.Seller - 1] += venta.SellValue;
            }

            // Mostrar el reporte en el ListBox
            lbSummary.Items.Clear();
            lbSummary.Items.Add("Producto/Vendedor   1       2       3       4   | Total Producto");

            for (int producto = 0; producto < 5; producto++)
            {
                float totalProducto = 0;
                string linea = $"Producto {producto + 1}       ";

                for (int vendedor = 0; vendedor < 4; vendedor++)
                {
                    linea += $"{resumenVentas[producto, vendedor],8:F2} ";
                    totalProducto += resumenVentas[producto, vendedor];
                }

                linea += $"| {totalProducto,8:F2}";
                lbSummary.Items.Add(linea);
            }

            // Totales por vendedor
            lbSummary.Items.Add("----------------------------------------------------------");
            string lineaTotales = "Total Vendedor     ";
            for (int vendedor = 0; vendedor < 4; vendedor++)
            {
                float totalVendedor = 0;
                for (int producto = 0; producto < 5; producto++)
                {
                    totalVendedor += resumenVentas[producto, vendedor];
                }
                lineaTotales += $"{totalVendedor,8:F2} ";
            }
            lbSummary.Items.Add(lineaTotales);
        }
    }
}
