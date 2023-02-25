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
    public partial class SegundaParteEjercicio1 : Form
    {
        public SegundaParteEjercicio1()
        {
            InitializeComponent();
        }

        private void Ingreso_Deposito_button_Click(object sender, EventArgs e)
        {
            double deposito = 200000, tasa = 1.15;
            //VALIDAMOS QUE INGRESE LOS DATOS
            if (string.IsNullOrEmpty(Ingreso_Deposito_button.Text))
            {
                errorProvider1.SetError(Ingreso_Deposito_button, "Ingrese una Cantidad");
                return;
            }


            double[] intereses = new double[12];

            // calcular el interés para cada mes
            for (int i = 0; i < 12; i++)
            {
                double interes = CalcularInteres(deposito, tasa);//LLamamos al metodo calcular y pasamos los parametrox
                intereses[i] = interes;
                deposito += interes;
            }

            // mostrar el resultado en el ListBox
            MostrarResultado(intereses);


        }

        //VALIDANDO QUE NO INGRESE LETRAS
        //private void Deposito_textBox_KeyPress(object sender, KeyPressEventArgs e)
     /*   {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }*/
        //CALCULANDO EL INTERES MENSUAL
        public double CalcularInteres(double capital, double tasa)
        {
            // tasa de interés mensual en decimal
            double tasaMensual = (tasa / 100) / 12;

            // interés mensual
            double interes = capital * tasaMensual;

            return interes;
        }

        //MOSTRANDO EN EL LIST
        private void MostrarResultado(double[] intereses)
        {
            // nombres de los meses
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            // limpiar el ListBox
            Informe_listBox.Items.Clear();

            /// mostrar los intereses acumulados hasta cada mes en el ListBox
            double totalIntereses = 0;
            for (int i = 0; i < intereses.Length; i++)
            {
                double interes = intereses[i];
                string mes = meses[i];

                totalIntereses += interes;//ACUMULADOR DE LOS INTERESES
                Informe_listBox.Items.Add(mes + ": L " + totalIntereses.ToString("N2"));
            }
        }

       

        private void Salir_button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Regresar_button_Click(object sender, EventArgs e)
        {
            MENU form4 = new MENU();
            Hide();
            form4.Show();
        }
    }
}
