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
        public string[] nombremayor = new string[1000];
        public double[] mayornota = new double[1000];
        public int[] mayordni = new int[1000];
         public int contador = 0;
        public int contadorprom = 0;
        public double promedio = 0;

        public void agregar(int nmrodni, string nombre, double nota)
        {
            dni[contador] = nmrodni;
            this.nombre[contador] = nombre;
            notas[contador] = nota;

            contador ++;
        }

        public double calcularpromedio()
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

            return promedio;

        }


        public void Alumnosmayorpromedio()
        {

            calcularpromedio();

            for (int i = 0;i < contador; i++)
            {
                contadorprom = 0;
                if (notas[i] > promedio)
                {
                    mayornota[contadorprom] = notas[i];
                    mayordni[contadorprom] = dni[i];
                    nombremayor[contadorprom] = nombre[i];

                    contadorprom++;
                }
            }


        }
    }

   


}
