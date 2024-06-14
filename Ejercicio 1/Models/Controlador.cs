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
        public int ret;
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

            contadorprom = 0;
            calcularpromedio();
            for (int i = 0;i < contador; i++)
            {
                if (notas[i] >= promedio)
                {
                    mayornota[contadorprom] = notas[i];
                    mayordni[contadorprom] = dni[i];
                    nombremayor[contadorprom] = nombre[i];

                    contadorprom++;
                }
            }

        }

        public void metodoburbuja()
        {
            for(int i = 0; i<contadorprom-1; i++)
            {
                for(int j = i+1; j<contadorprom; j++)
                {
                    if (mayornota[i] < mayornota[j])
                    {
                        double aux = mayornota[j];
                        mayornota[j] = mayornota[i];
                        mayornota[i] = aux;

                        string auxnombre = nombremayor[j];
                        nombremayor[j] = nombremayor[i];
                        nombremayor[i] = auxnombre;

                        int auxdni = mayordni[j];
                        mayordni[j] = mayordni[i];
                        mayordni[i] = auxdni;
                    }

                }


            }

        }


        public int metodosecuencial(int buscado)
        {
            ret = -1;

            for (int i = 0; i < contador;)
            {
                if (dni[i] == buscado)
                {
                    ret = i;
                }

            }

            return ret;

        }


    }

   


}
