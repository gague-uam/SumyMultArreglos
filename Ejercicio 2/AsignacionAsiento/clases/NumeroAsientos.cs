using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionAsiento.clases
{
    public class NumeroAsientos
    {
        private bool[] Seats = new bool[10];

        public int AsignarAsiento(int seccion) //
        {
            int iniciar = (seccion == 1) ? 0 : 5;       // Si la seccion es 1, iniciar en 0, si no, iniciar en 5
            int fin = (seccion == 1) ? 4 : 9;           // Si la seccion es 1, fin en 4, si no, fin en 9

            for (int i = iniciar; i <= fin; i++)
            {
                if (!Seats[i]) // Si el asiento no esta ocupado
                {
                    Seats[i] = true;
                    return i + 1;
                }
            }
            return -1;
        }

        public bool SeatFull(int seccion) // Si la seccion esta llena
        {
            int iniciar = (seccion == 1) ? 0 : 5;
            int fin = (seccion == 1) ? 4 : 9;

            for (int i = iniciar; i <= fin; i++) // Recorrer los asientos
            {
                if (!Seats[i]) // Si el asiento no esta ocupado
                {
                    return false;
                }
            }
            return true;
        }
    }
}
