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
    public partial class Form_seleccione : Form
    {
        public Form_seleccione()
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
            Form Form2 = new Form_clientes();
            Form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form2 = new Form_acceso();
            Form2.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox_lista.Text == "ACCESO")
            {
                this.Hide();
                Form Form1 = new Form_acceso();
                Form1.ShowDialog();
            }
            else if(comboBox_lista.Text== "CLIENTES")
            {
                this.Hide();
                Form Form3 = new Form_clientes();
                Form3.ShowDialog();
            }else if (comboBox_lista.Text == "PAGOS")
            {
                this.Hide();
                Form Form4 = new Form_pagos();
                Form4.ShowDialog();
            }else if(comboBox_lista.Text== "FACTURA")
            {
                this.Hide();
                Form Form5= new Form_factura();
                Form5.ShowDialog();
            }
        }
    }
}
