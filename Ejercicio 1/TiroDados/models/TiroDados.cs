using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiroDados.models
{
    public partial class RollDice
    {
        private int[] sumCount = new int[11]; // Arreglo para contar las sumas de 2 a 12

        public (int dice1, int dice2, int sum) Roll()
        {
            Random random = new Random();
            int dice1 = random.Next(1, 7); // Lanza el dado entre 1 a 6
            int dice2 = random.Next(1, 7); // Lanza el dado entre 1 a 6
            int sum = dice1 + dice2;    // Calcula la suma de los dos dados

            sumCount[sum - 2]++; // Incrementa el contador de la suma
            return (dice1, dice2, sum); // Retorna los valores
        }

        public int[] GetSums()
        {
            return sumCount;
        }
    }
}
