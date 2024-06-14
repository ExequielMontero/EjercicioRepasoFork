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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Registro miregistro = new Registro();
           Controlador mismetodos = new Controlador();

           if(miregistro.ShowDialog() == DialogResult.OK )
            {
                string nombre = miregistro.tbNombre.Text;
                double nota = Convert.ToDouble(miregistro.tbNota.Text);
                int Dni = Convert.ToInt32(miregistro.tbDni.Text);

                mismetodos.agregarnota(nota);
                mismetodos.agregarnombre(nombre);
                mismetodos.agregardni(Dni);
                

            }

        }
    }
}
