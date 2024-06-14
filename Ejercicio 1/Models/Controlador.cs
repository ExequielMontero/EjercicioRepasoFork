using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    public class Controlador
    {
         public int[] dni = new int[1000];
         public string[] nombre = new string[1000];
         public double[] notas = new double[1000];
         public int contador = 0;
        public double promedio = 0;

        public void agregardni(int nmrodni)
        {
            dni[contador] = nmrodni;
        }

        public void agregarnombre(string nombre)
        {
            this.nombre[contador] = nombre;
        }
        public void agregarnota(double nota)
        {
            notas[contador] = nota;
        }

        public void calcularpromedio()
        {

            double acum = 0;
            for (int i = 0; i < contador; i++)
            {
                acum += notas[i];
            }
            if (contador > 0)
            {
                promedio = acum / contador;
            }

        }
    }

   


}
