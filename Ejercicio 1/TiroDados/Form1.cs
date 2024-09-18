using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiroDados.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TiroDados
{
    public partial class Form1 : Form
    {
        private RollDice tirodados;
        

        public Form1()
        {
            InitializeComponent();
            tirodados = new RollDice();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            // Realizar un tiro
            var (dice1, dice2, sum) = tirodados.Roll();

            // Actualiza las etiquetas con los resultados
            lblDice1.Text = $"Dado 1: {dice1}";
            lblDice2.Text = $"Dado 2: {dice2}";
            lblResult.Text = $"Suma: {sum}";

            // Actualiza el ListBox con los conteos de las sumas
            GetSumCount();
        }
        private void GetSumCount()
        {
            int[] conteoSumas = tirodados.GetSums();

            // Actualiza el ListBox con los conteos de las sumas
            lbSumCount.Items.Clear();
            lbSumCount.Items.Add("Suma\tCantidad");

            for (int i = 0; i < conteoSumas.Length; i++)
            {
                int suma = i + 2;
                int cantidad = conteoSumas[i];
                lbSumCount.Items.Add($"{suma}\t{cantidad}");
            }
        }
    }
}
