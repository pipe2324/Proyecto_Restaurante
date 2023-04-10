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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form2 = new Form3();
            Form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form2 = new Form1();
            Form2.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            
            if (comboBox1.Text == "ACCESO")
            {
                this.Hide();
                Form Form1 = new Form1();
                Form1.ShowDialog();
            }
            else if(comboBox1.Text== "CLIENTES")
            {
                this.Hide();
                Form Form3 = new Form3();
                Form3.ShowDialog();
            }else if (comboBox1.Text == "PAGOS")
            {
                this.Hide();
                Form Form4 = new Form4();
                Form4.ShowDialog();
            }else if(comboBox1.Text== "FACTURA")
            {
                this.Hide();
                Form Form5= new Form5();
                Form5.ShowDialog();
            }
        }
    }
}
