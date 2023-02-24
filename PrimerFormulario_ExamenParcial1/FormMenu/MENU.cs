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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EJERCICIO1 form1 = new EJERCICIO1();
            Hide();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EJERICICIO2 form2 = new EJERICICIO2();
            Hide();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EJERCICIO3 form3 = new EJERCICIO3();
            Hide();
            form3.Show();
        }
    }
}
