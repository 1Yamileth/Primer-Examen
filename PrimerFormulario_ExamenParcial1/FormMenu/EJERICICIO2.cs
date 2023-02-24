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
        private Producto[] productos;
        private int cantidadProductos;
        public EJERICICIO2()
        {
            InitializeComponent();

            Products_GridView.Columns.Add("Nombre", "Nombre");
            Products_GridView.Columns.Add("Precio", "Precio");
            Products_GridView.Columns.Add("Cantidad", "Cantidad");
            Products_GridView.Columns["Precio"].DefaultCellStyle.Format = "C2";

            productos = new Producto[10];
            cantidadProductos = 0;

        }

        private void EJERICICIO2_Load(object sender, EventArgs e)
        {

        }

        private void NuevoP_button_Click(object sender, EventArgs e)
        {
            if (cantidadProductos < productos.Length)
            {
                Producto producto = new Producto();
                producto.Nombre = Producto_textBox.Text;
                if (decimal.TryParse(Precio_Pro_textBox.Text, out decimal precio))
                {
                    producto.Precio = precio;
                }
                else
                {
                    MessageBox.Show("El precio " + Precio_Pro_textBox.Text + " no es válido.");
                    return;
                }
                if (int.TryParse(Cantidad_Pro_textBox.Text, out int cantidad))
                {
                    producto.Cantidad = cantidad;
                }
                else
                {
                    MessageBox.Show("La cantidad " + Cantidad_Pro_textBox.Text + " no es válida.");
                    return;
                }

                productos[cantidadProductos] = producto;
                cantidadProductos++;


                Products_GridView.Rows.Add(producto.Nombre, producto.Precio, producto.Cantidad);


                Products_GridView.Text = "";
                Precio_Pro_textBox.Text = "";
                Cantidad_Pro_textBox.Text = "";
            }
            else
            {
                MessageBox.Show("No se pueden agregar más productos.");
            }
        }

        private async void Descuento_button_Click(object sender, EventArgs e)
        {

            List<Producto> productos = new List<Producto>();
            foreach (DataGridViewRow row in Products_GridView.Rows)
            {
                string nombre = row.Cells["Nombre"].Value?.ToString();
                decimal precio = 0;
                if (decimal.TryParse(row.Cells["Precio"].Value?.ToString(), out precio))
                {
                    int cantidad = 0;
                    if (int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out cantidad))
                    {
                        Producto producto = new Producto();
                        producto.Nombre = nombre;
                        producto.Precio = precio;
                        producto.Cantidad = cantidad;
                        productos.Add(producto);
                    }
                }
            }
            // Calcular el descuento del 15%
            decimal descuento = await CalculoDeDescuentoAsync(productos.ToArray());

            // Calcular el total a pagar
            decimal total = productos.Sum(p => p.Precio * p.Cantidad) - descuento;

            // Mostrar el descuento y el total a pagar al usuario
            MessageBox.Show("Descuento del 15%: $" + descuento.ToString("0.00") + "\nTotal a pagar: $" + total.ToString("0.00"));

        }

        private async Task<decimal> CalculoDeDescuentoAsync(Producto[] productos)
        {

            await Task.Delay(1000);

            decimal total = productos.Sum(p => p.Precio);
            decimal descuento = total * 0.15m;
            return descuento;
        }
        
      
        public class Producto
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }
        }

        private void Products_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

