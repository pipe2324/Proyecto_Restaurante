namespace Proyecto_Restaurante
{
    partial class Pagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_atras = new System.Windows.Forms.Button();
            this.button_siguiente = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.label_notificacion = new System.Windows.Forms.Label();
            this.label_horapedido = new System.Windows.Forms.Label();
            this.label_precio = new System.Windows.Forms.Label();
            this.label_pago = new System.Windows.Forms.Label();
            this.idcliente = new System.Windows.Forms.TextBox();
            this.horapedidocliente = new System.Windows.Forms.TextBox();
            this.notificacioncliente = new System.Windows.Forms.TextBox();
            this.pagoproducto = new System.Windows.Forms.TextBox();
            this.precioproducto = new System.Windows.Forms.TextBox();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.dataGridView_tablaPagos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox_mano = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tablaPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mano)).BeginInit();
            this.SuspendLayout();
            // 
            // button_atras
            // 
            this.button_atras.BackColor = System.Drawing.Color.LightCoral;
            this.button_atras.Location = new System.Drawing.Point(640, 584);
            this.button_atras.Name = "button_atras";
            this.button_atras.Size = new System.Drawing.Size(115, 47);
            this.button_atras.TabIndex = 0;
            this.button_atras.Text = "ATRAS";
            this.button_atras.UseVisualStyleBackColor = false;
            this.button_atras.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_siguiente
            // 
            this.button_siguiente.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_siguiente.Location = new System.Drawing.Point(813, 585);
            this.button_siguiente.Name = "button_siguiente";
            this.button_siguiente.Size = new System.Drawing.Size(126, 46);
            this.button_siguiente.TabIndex = 1;
            this.button_siguiente.Text = "SIGUIENTE";
            this.button_siguiente.UseVisualStyleBackColor = false;
            this.button_siguiente.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(45, 55);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(26, 20);
            this.label_id.TabIndex = 2;
            this.label_id.Text = "ID";
            // 
            // label_notificacion
            // 
            this.label_notificacion.AutoSize = true;
            this.label_notificacion.Location = new System.Drawing.Point(45, 94);
            this.label_notificacion.Name = "label_notificacion";
            this.label_notificacion.Size = new System.Drawing.Size(168, 20);
            this.label_notificacion.TabIndex = 3;
            this.label_notificacion.Text = "Notificación del pedido";
            // 
            // label_horapedido
            // 
            this.label_horapedido.AutoSize = true;
            this.label_horapedido.Location = new System.Drawing.Point(45, 133);
            this.label_horapedido.Name = "label_horapedido";
            this.label_horapedido.Size = new System.Drawing.Size(121, 20);
            this.label_horapedido.TabIndex = 4;
            this.label_horapedido.Text = "Hora del pedido";
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Location = new System.Drawing.Point(45, 173);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(53, 20);
            this.label_precio.TabIndex = 5;
            this.label_precio.Text = "Precio";
            // 
            // label_pago
            // 
            this.label_pago.AutoSize = true;
            this.label_pago.Location = new System.Drawing.Point(45, 213);
            this.label_pago.Name = "label_pago";
            this.label_pago.Size = new System.Drawing.Size(46, 20);
            this.label_pago.TabIndex = 6;
            this.label_pago.Text = "Pago";
            // 
            // idcliente
            // 
            this.idcliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.idcliente.Location = new System.Drawing.Point(228, 55);
            this.idcliente.Name = "idcliente";
            this.idcliente.Size = new System.Drawing.Size(242, 26);
            this.idcliente.TabIndex = 7;
            // 
            // horapedidocliente
            // 
            this.horapedidocliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.horapedidocliente.Location = new System.Drawing.Point(228, 133);
            this.horapedidocliente.Name = "horapedidocliente";
            this.horapedidocliente.Size = new System.Drawing.Size(242, 26);
            this.horapedidocliente.TabIndex = 8;
            // 
            // notificacioncliente
            // 
            this.notificacioncliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.notificacioncliente.Location = new System.Drawing.Point(228, 94);
            this.notificacioncliente.Name = "notificacioncliente";
            this.notificacioncliente.Size = new System.Drawing.Size(242, 26);
            this.notificacioncliente.TabIndex = 9;
            // 
            // pagoproducto
            // 
            this.pagoproducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pagoproducto.Location = new System.Drawing.Point(228, 213);
            this.pagoproducto.Name = "pagoproducto";
            this.pagoproducto.Size = new System.Drawing.Size(242, 26);
            this.pagoproducto.TabIndex = 10;
            // 
            // precioproducto
            // 
            this.precioproducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.precioproducto.Location = new System.Drawing.Point(228, 173);
            this.precioproducto.Name = "precioproducto";
            this.precioproducto.Size = new System.Drawing.Size(242, 26);
            this.precioproducto.TabIndex = 11;
            // 
            // button_guardar
            // 
            this.button_guardar.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_guardar.Location = new System.Drawing.Point(33, 273);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(103, 53);
            this.button_guardar.TabIndex = 13;
            this.button_guardar.Text = "GUARDAR";
            this.button_guardar.UseVisualStyleBackColor = false;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.Color.LightGreen;
            this.button_eliminar.Location = new System.Drawing.Point(154, 273);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(105, 53);
            this.button_eliminar.TabIndex = 14;
            this.button_eliminar.Text = "ELIMINAR";
            this.button_eliminar.UseVisualStyleBackColor = false;
            // 
            // dataGridView_tablaPagos
            // 
            this.dataGridView_tablaPagos.AllowUserToAddRows = false;
            this.dataGridView_tablaPagos.AllowUserToDeleteRows = false;
            this.dataGridView_tablaPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_tablaPagos.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView_tablaPagos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_tablaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tablaPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView_tablaPagos.Location = new System.Drawing.Point(22, 357);
            this.dataGridView_tablaPagos.Name = "dataGridView_tablaPagos";
            this.dataGridView_tablaPagos.ReadOnly = true;
            this.dataGridView_tablaPagos.RowHeadersVisible = false;
            this.dataGridView_tablaPagos.RowHeadersWidth = 62;
            this.dataGridView_tablaPagos.RowTemplate.Height = 28;
            this.dataGridView_tablaPagos.Size = new System.Drawing.Size(1013, 208);
            this.dataGridView_tablaPagos.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Notificacion del pedido";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hora del pedido";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Pago";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // pictureBox_mano
            // 
            this.pictureBox_mano.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_mano.Image = global::Proyecto_Restaurante.Properties.Resources.pago;
            this.pictureBox_mano.Location = new System.Drawing.Point(617, 22);
            this.pictureBox_mano.Name = "pictureBox_mano";
            this.pictureBox_mano.Size = new System.Drawing.Size(338, 290);
            this.pictureBox_mano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_mano.TabIndex = 12;
            this.pictureBox_mano.TabStop = false;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1058, 644);
            this.Controls.Add(this.dataGridView_tablaPagos);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.pictureBox_mano);
            this.Controls.Add(this.precioproducto);
            this.Controls.Add(this.pagoproducto);
            this.Controls.Add(this.notificacioncliente);
            this.Controls.Add(this.horapedidocliente);
            this.Controls.Add(this.idcliente);
            this.Controls.Add(this.label_pago);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.label_horapedido);
            this.Controls.Add(this.label_notificacion);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button_siguiente);
            this.Controls.Add(this.button_atras);
            this.MaximumSize = new System.Drawing.Size(1080, 700);
            this.MinimumSize = new System.Drawing.Size(1080, 700);
            this.Name = "Pagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAGOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tablaPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_atras;
        private System.Windows.Forms.Button button_siguiente;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_notificacion;
        private System.Windows.Forms.Label label_horapedido;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.Label label_pago;
        private System.Windows.Forms.TextBox idcliente;
        private System.Windows.Forms.TextBox horapedidocliente;
        private System.Windows.Forms.TextBox notificacioncliente;
        private System.Windows.Forms.TextBox pagoproducto;
        private System.Windows.Forms.TextBox precioproducto;
        private System.Windows.Forms.PictureBox pictureBox_mano;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.DataGridView dataGridView_tablaPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}