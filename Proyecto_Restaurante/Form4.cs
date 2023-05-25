using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Restaurante
{
    public partial class Pagos : Form
    {
        public Pagos()
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
            Form Form4 = new Form_factura();
            Form4.ShowDialog();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-SCLIEH5U;Initial Catalog=Restaurante;Integrated Security=True";
            string query = "INSERT INTO Pagos VALUES (@ID, @Notificacion_del_pedido, @Hora_de_pedido, @Precio,@Pago)";

            SqlConnection myConnection = new SqlConnection(connectionString);

            SqlCommand myCommand = new SqlCommand(query, myConnection);
            myCommand.Parameters.AddWithValue("@ID", Convert.ToInt64(idcliente.Text));
            myCommand.Parameters.AddWithValue("@Notificacion_del_pedido", notificacioncliente.Text);
            myCommand.Parameters.AddWithValue("Hora_de_pedido", horapedidocliente.Text);
            myCommand.Parameters.AddWithValue("@Precio", precioproducto.Text);
            myCommand.Parameters.AddWithValue("@Pago", pagoproducto.Text);
         

            myConnection.Open();
            MessageBox.Show("Coneccion abierta!");
            myCommand.ExecuteNonQuery();

            myConnection.Close();
            MessageBox.Show("Coneccion cerrada!");
        }
    }
}
