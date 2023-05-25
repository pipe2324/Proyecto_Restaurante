using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Restaurante
{
    public partial class Form_factura : Form
    {
        public Form_factura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form4 = new Cliente();
            Form4.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form5 = new Usuario();
            Form5.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
