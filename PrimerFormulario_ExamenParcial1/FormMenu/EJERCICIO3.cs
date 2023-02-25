using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMenu
{
    public partial class EJERCICIO3 : Form
    {
        public EJERCICIO3()
        {
            InitializeComponent();
        }
        //LOS HICE ASINCRONO YA QUE SE TARDABA DEMASIADO EN GENERAR LOS PROCESOS
        private async void Ingresar_button_Click(object sender, EventArgs e)
        {
           Random random = new Random();
           int numeroAleatorio = random.Next(1, 100);
           await MostrarNumerosConNombreApellido(numeroAleatorio);
        }

        //VALIDANDO LOS NUMEROS
        public async Task MostrarNumerosConNombreApellido(int i)
        {
            string nombre = "Marilyn Yamileth", apellido = "Mejia Aguilar";

            // for (int i=1; i>=100; i++)
           // {
                //if (rand == i)
                //{
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Numero_textBox.Text = Convert.ToString(i);
                        Datos_textBox.Text = nombre + " " + apellido;
                    }
                    else if (i % 3 == 0)
                    {
                        Datos_textBox.Text = nombre;

                        Numero_textBox.Text = Convert.ToString(i);
                    }
                    else if (i % 5 == 0)
                    {
                        Numero_textBox.Text = Convert.ToString(i);
                        Datos_textBox.Text = apellido;
                    }
            await Task.CompletedTask;
            // }

            //}
        }

        private void Limpiar_button_Click(object sender, EventArgs e)
        {
            Numero_textBox.Clear();
            Datos_textBox.Clear();
        }


        

        private void Salir_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Regreso_button_Click(object sender, EventArgs e)
        {
            MENU form7 = new MENU();
            Hide();
            form7.Show();
        }
    }
}
