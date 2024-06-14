﻿using Ejercicio_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        Registro miregistro = new Registro();
        Controlador mismetodos = new Controlador();
        VerAlumnos opcion = new VerAlumnos();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
     

            if (miregistro.ShowDialog() == DialogResult.OK)
            {
                string nombre = miregistro.tbNombre.Text;
                double nota = Convert.ToDouble(miregistro.tbNota.Text);
                int Dni = Convert.ToInt32(miregistro.tbDni.Text);

                mismetodos.agregar(Dni, nombre, nota);

                miregistro.tbNombre.Clear();
                miregistro.tbDni.Clear();
                miregistro.tbNota.Clear();  
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            if (mismetodos.contador == 1)
            {
                lbPromedio.Text = Convert.ToString(mismetodos.notas[0]);

            }
            else
            {
                lbPromedio.Text = Convert.ToString(mismetodos.calcularpromedio());
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            while(opcion.ShowDialog() == DialogResult.OK)
            {
                mismetodos.calcularpromedio();
                mismetodos.Alumnosmayorpromedio();
                mismetodos.metodoburbuja();
                if (opcion.rbTodos.Checked)
                {
                    opcion.lbLista.Items.Clear();
                    for(int i = 0; i<mismetodos.contador; i++)
                    {
                        opcion.lbLista.Items.Add($"Nombre: {mismetodos.nombre[i]}");
                        opcion.lbLista.Items.Add($"DNI: {mismetodos.dni[i]}");
                        opcion.lbLista.Items.Add($"Nota: {mismetodos.notas[i]}");
                        opcion.lbLista.Items.Add($"---------------------------------");
                    }
                }
                else if (opcion.rbMayorMenor.Checked)
                {
                    opcion.lbLista.Items.Clear();
                    if (mismetodos.contadorprom > 1)
                    {
                        opcion.lbLista.Items.Add($"Nombre: {mismetodos.nombremayor[0]}");
                        opcion.lbLista.Items.Add($"DNI: {mismetodos.mayordni[0]}");
                        opcion.lbLista.Items.Add($"Nota: {mismetodos.mayornota[0]}");
                        opcion.lbLista.Items.Add($"---------------------------------");
                        opcion.lbLista.Items.Add($"Nombre: {mismetodos.nombremayor[mismetodos.contadorprom - 1]}");
                        opcion.lbLista.Items.Add($"DNI: {mismetodos.mayordni[mismetodos.contadorprom - 1]}");
                        opcion.lbLista.Items.Add($"Nota: {mismetodos.mayornota[mismetodos.contadorprom - 1]}");
                    }
                    else if(mismetodos.contadorprom == 1)
                    {
                        opcion.lbLista.Items.Clear();
                        opcion.lbLista.Items.Add("¡Solo un alumno supero el promedio!");
                    }
                    else
                    {
                        opcion.lbLista.Items.Clear();
                        opcion.lbLista.Items.Add("¡Ningun alumno ha superado el promedio!");
                        
                    }
                }
            }
            opcion.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(tbBuscar.Text);

            if(mismetodos.metodosecuencial(dni) != -1)
            {
                lbBuscar.Items.Clear();
                lbBuscar.Items.Add($"*Nombre: {mismetodos.nombre[mismetodos.metodosecuencial(dni)]}");
                lbBuscar.Items.Add($"*DNI: {dni}");
                lbBuscar.Items.Add($"*Nota: {mismetodos.notas[mismetodos.metodosecuencial(dni)]}");
            }
            else if(mismetodos.metodosecuencial(dni) == -1)
            {
                lbBuscar.Items.Clear();
                lbBuscar.Items.Add("¡Alumno no encontrado!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
