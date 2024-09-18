using System;
using System.Windows.Forms;

namespace Salarios
{
    public partial class Form1 : Form
    {
        private int[] SallaryRange = new int[9];
        public Form1()
        {
            InitializeComponent();
        }

        private void GetSallary(int ventasBrutas)
        {
            int salario = (int)(200 + 0.09 * ventasBrutas);

            if (salario >= 1000)
            {
                SallaryRange[8]++;
            }
            else if (salario >= 900)
            {
                SallaryRange[7]++;
            }
            else if (salario >= 800)
            {
                SallaryRange[6]++;
            }
            else if (salario >= 700)
            {
                SallaryRange[5]++;
            }
            else if (salario >= 600)
            {
                SallaryRange[4]++;
            }
            else if (salario >= 500)
            {
                SallaryRange[3]++;
            }
            else if (salario >= 400)
            {
                SallaryRange[2]++;
            }
            else if (salario >= 300)
            {
                SallaryRange[1]++;
            }
            else
            {
                SallaryRange[0]++;
            }
        }

        private void btnAddSell_Click(object sender, EventArgs e)
        {
            int ventasBrutas;
            if (int.TryParse(tbSellings.Text, out ventasBrutas))
            {
                GetSallary(ventasBrutas);
                MessageBox.Show("La venta se ha registrado");
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida");
            }

            tbSellings.Clear();
        }

        private void btnShowSummary_Click(object sender, EventArgs e)
        {
            lbSummary.Items.Clear();
            lbSummary.Items.Add("Rangos de salarios:");
            lbSummary.Items.Add($"$200-$299:   {SallaryRange[0]} vendedores");
            lbSummary.Items.Add($"$300-$399:   {SallaryRange[1]} vendedores");
            lbSummary.Items.Add($"$400-$499:   {SallaryRange[2]} vendedores");
            lbSummary.Items.Add($"$500-$599:   {SallaryRange[3]} vendedores");
            lbSummary.Items.Add($"$600-$699:   {SallaryRange[4]} vendedores");
            lbSummary.Items.Add($"$700-$799:   {SallaryRange[5]} vendedores");
            lbSummary.Items.Add($"$800-$899:   {SallaryRange[6]} vendedores");
            lbSummary.Items.Add($"$900-$999:   {SallaryRange[7]} vendedores");
            lbSummary.Items.Add($"$1000 o más: {SallaryRange[8]} vendedores");
        }
    }
}
