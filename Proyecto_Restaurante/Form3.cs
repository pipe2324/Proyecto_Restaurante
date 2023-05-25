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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form3 = new Form_seleccione();
            Form3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form3 = new Pagos();
            Form3.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-SCLIEH5U;Initial Catalog=Restaurante;Integrated Security=True";
            string query = "INSERT INTO Cliente VALUES (@ID, @Nombre_cliente, @Cedula, @Ubicacion, @Tipo_de_pedido, @Hora_del_pedido)";

            SqlConnection myConnection = new SqlConnection(connectionString);

            SqlCommand myCommand = new SqlCommand(query, myConnection);
            myCommand.Parameters.AddWithValue("@ID", Convert.ToInt64(IdentificacionCliente.Text));
            myCommand.Parameters.AddWithValue("@Nombre_cliente", NombreCliente.Text);
            myCommand.Parameters.AddWithValue("@Cedula", CedulaCliente.Text);
            myCommand.Parameters.AddWithValue("@Ubicacion", UbicacionCliente.Text);
            myCommand.Parameters.AddWithValue("@Tipo_de_pedido", TipodepedidoCliente.Text);
            myCommand.Parameters.AddWithValue("@Hora_del_pedido", HoradelpedidoCliente.Text);

            myConnection.Open();
            MessageBox.Show("Coneccion abierta!");
            myCommand.ExecuteNonQuery();

            myConnection.Close();
            MessageBox.Show("Coneccion cerrada!");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
