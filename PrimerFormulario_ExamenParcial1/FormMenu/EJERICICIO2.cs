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
    public partial class EJERICICIO2 : Form
    {
        private List<Producto> productos = new List<Producto>();

        public EJERICICIO2()
        {
            InitializeComponent();


        }

        private void EJERICICIO2_Load(object sender, EventArgs e)
        {

        }

        private async void Descuento_button_Click(object sender, EventArgs e)
        {
            double descuento = 0.15;
            double total = 0;

            // VALIDANDO QUE HAYA INGRESADO TODOS LO DATOS
            if (string.IsNullOrWhiteSpace(Producto_textBox.Text))
            {
                MessageBox.Show("Por favor ingrese los productos para calcular el descuento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(Precio_Pro_textBox.Text))
            {
                MessageBox.Show("Por favor ingrese el precio para calcular el descuento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ( string.IsNullOrWhiteSpace(Cantidad_Pro_textBox.Text))
            {
                MessageBox.Show("Por favor ingrese las cantidades para calcular el descuento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Calcular el total de la factura
            foreach (Producto producto in productos)
            {
                total += producto.Precio * producto.Cantidad;
            }

            // Aplicar el descuento asíncronamente
            await Task.Run(() =>
            {
                double descuentoCalculado = total * descuento;
                double totalPagar = total - descuentoCalculado;

                // Mostrar el resultado en la UI
                this.Invoke(new Action(() =>// CON EL INVOKE ASEGURAMOS QUE SE MUESTRE EN LA INTERFAZ COMO QUEREMOS
                {
                    MessageBox.Show($"El descuento del 15% es de: {descuentoCalculado:C}\nEl total a pagar es de: {totalPagar:C}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            });
        }

        private void Agregar_button_Click(object sender, EventArgs e)
        {

            //LEE LO QUE EL USUARIO INGRESA
            string producto = Producto_textBox.Text;
            double precio = Convert.ToDouble(Precio_Pro_textBox.Text);
            int cantidad = Convert.ToInt32(Cantidad_Pro_textBox.Text);
            //SE HACE UN OBJETO Y LOS VALORES SE AGREGAN A LA LISTA
            Producto nuevoProducto = new Producto(producto, precio, cantidad);
            productos.Add(nuevoProducto);

            Prodcutos_dataGridView.Rows.Add(producto, precio, cantidad);
        }
        private class Producto
        {
            /* para almacenar la información de cada producto ingresado
             * por el usuario (nombre, precio y cantidad), y se guarda una
             * lista de productos en la variable productos*/
            public string Nombre { get; set; }
            public double Precio { get; set; }
            public int Cantidad { get; set; }

            public Producto(string nombre, double precio, int cantidad)
            {
                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;
            }
        }
        //VALIDANDO QUE NO INGRESE LETRAS
        private void Deposito_textBox_KeyPress(object sender, KeyPressEventArgs e)
         {
               if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
               {
                   e.Handled = true;
               }
           }
      
        //VALIDANDO QUE NO ME INGRESE NUMEROS
        private void Producto_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
               {
                e.Handled = true;
            }
        }
        //VALIDANDO QUE NO INGRESE LETRAS
        private void Precio_Pro_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
               {
                e.Handled = true;
            }
        }

        private void Cantidad_Pro_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
               {
                e.Handled = true;
            }
        }
        private void Salir_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

   

     

