using Ejercicio_1.Models;
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
            if(opcion.ShowDialog() == DialogResult.OK)
            {
                if (opcion.rbTodos.Checked)
                {
                    lbLista.Items.Clear();
                    for(int i = 0; i<mismetodos.contador; i++)
                    {
                        lbLista.Items.Add($"Nombre: {mismetodos.nombre[i]}");
                        lbLista.Items.Add($"DNI: {mismetodos.dni[i]}");
                        lbLista.Items.Add($"Nota: {mismetodos.notas[i]}");
                        lbLista.Items.Add($"---------------------------------");
                    }
                }
                else if (opcion.rbMayorMenor.Checked)
                {
                    lbLista.Items.Clear();
                    for (int i = 0; i < mismetodos.contadorprom; i++)
                    {
                        lbLista.Items.Add($"Nombre: {mismetodos.nombremayor[i]}");
                        lbLista.Items.Add($"DNI: {mismetodos.mayordni[i]}");
                        lbLista.Items.Add($"Nota: {mismetodos.mayornota[i]}");
                        lbLista.Items.Add($"---------------------------------");
                    }
                }
            }
        }
    }
}
