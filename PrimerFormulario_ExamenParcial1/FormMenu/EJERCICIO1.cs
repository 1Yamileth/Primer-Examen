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
    public partial class EJERCICIO1 : Form
    {
        public EJERCICIO1()
        {
            InitializeComponent();
        }

        private void Ingresar_button_Click(object sender, EventArgs e)
        {
            string nombre = Nombre_textBox.Text;
            //VALIDAMOS QUE INGRESE LOS DATOS
            if (string.IsNullOrEmpty(Nombre_textBox.Text))
            {
                errorProvider1.SetError(Nombre_textBox, "Ingrese un usuario");
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(Contra_textBox.Text))
            {
                errorProvider1.SetError(Contra_textBox, "Ingrese una contraseña");
                return;
            }
            errorProvider1.Clear();

            //INSTANCIAMOS PARA ACCEDER A OTRO MENU
            SegundaParteEjercicio1 calculoForm = new SegundaParteEjercicio1();
            Hide();
            calculoForm.Show();

        }
        private void Mostrar_button_Click(object sender, EventArgs e)
        {

            if (Contra_textBox.PasswordChar == '*')
            {
                Contra_textBox.PasswordChar = '\0';//VALOR NULLEABLE, SI SE DETECTA EL *, LO PASAREMOS NULO
            }
            else
            {
                Contra_textBox.PasswordChar = '*';// LUEGO LE PASAMOS EL ASTERISCO DE NUEVO, SI ENCUENTRA LAS CADENAS INGRESADAS EN CONTRASENA
            }

        }

        private void Cancelar_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Mostrar_button_Click_1(object sender, EventArgs e)
        {
                if (Contra_textBox.PasswordChar == '*')
                {
                    Contra_textBox.PasswordChar = '\0';//VALOR NULLEABLE, SI SE DETECTA EL *, LO PASAREMOS NULO
                }
                else
                {
                    Contra_textBox.PasswordChar = '*';// LUEGO LE PASAMOS EL ASTERISCO DE NUEVO, SI ENCUENTRA LAS CADENAS INGRESADAS EN CONTRASENA
                }

            

        }

        private void EJERCICIO1_Load(object sender, EventArgs e)
        {

        }
    }
}
