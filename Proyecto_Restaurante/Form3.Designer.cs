namespace Proyecto_Restaurante
{
    partial class Cliente
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
            this.ID = new System.Windows.Forms.Label();
            this.Nombre_cliente = new System.Windows.Forms.Label();
            this.Cedula = new System.Windows.Forms.Label();
            this.Ubicacion = new System.Windows.Forms.Label();
            this.Tipo_de_pedido = new System.Windows.Forms.Label();
            this.Hora_del_pedido = new System.Windows.Forms.Label();
            this.IdentificacionCliente = new System.Windows.Forms.TextBox();
            this.NombreCliente = new System.Windows.Forms.TextBox();
            this.CedulaCliente = new System.Windows.Forms.TextBox();
            this.TipodepedidoCliente = new System.Windows.Forms.TextBox();
            this.HoradelpedidoCliente = new System.Windows.Forms.TextBox();
            this.UbicacionCliente = new System.Windows.Forms.TextBox();
            this.button_atras = new System.Windows.Forms.Button();
            this.button_siguiente = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.dataGridView_tablaclientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox_persona = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tablaclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_persona)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(33, 29);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // Nombre_cliente
            // 
            this.Nombre_cliente.AutoSize = true;
            this.Nombre_cliente.Location = new System.Drawing.Point(33, 74);
            this.Nombre_cliente.Name = "Nombre_cliente";
            this.Nombre_cliente.Size = new System.Drawing.Size(115, 20);
            this.Nombre_cliente.TabIndex = 1;
            this.Nombre_cliente.Text = "Nombre cliente";
            // 
            // Cedula
            // 
            this.Cedula.AutoSize = true;
            this.Cedula.Location = new System.Drawing.Point(33, 118);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(59, 20);
            this.Cedula.TabIndex = 2;
            this.Cedula.Text = "Cedula";
            // 
            // Ubicacion
            // 
            this.Ubicacion.AutoSize = true;
            this.Ubicacion.Location = new System.Drawing.Point(33, 162);
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.Size = new System.Drawing.Size(79, 20);
            this.Ubicacion.TabIndex = 3;
            this.Ubicacion.Text = "Ubicacion";
            // 
            // Tipo_de_pedido
            // 
            this.Tipo_de_pedido.AutoSize = true;
            this.Tipo_de_pedido.Location = new System.Drawing.Point(33, 199);
            this.Tipo_de_pedido.Name = "Tipo_de_pedido";
            this.Tipo_de_pedido.Size = new System.Drawing.Size(113, 20);
            this.Tipo_de_pedido.TabIndex = 4;
            this.Tipo_de_pedido.Text = "Tipo de pedido";
            // 
            // Hora_del_pedido
            // 
            this.Hora_del_pedido.AutoSize = true;
            this.Hora_del_pedido.Location = new System.Drawing.Point(33, 237);
            this.Hora_del_pedido.Name = "Hora_del_pedido";
            this.Hora_del_pedido.Size = new System.Drawing.Size(121, 20);
            this.Hora_del_pedido.TabIndex = 5;
            this.Hora_del_pedido.Text = "Hora del pedido";
            // 
            // IdentificacionCliente
            // 
            this.IdentificacionCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.IdentificacionCliente.Location = new System.Drawing.Point(170, 29);
            this.IdentificacionCliente.Name = "IdentificacionCliente";
            this.IdentificacionCliente.Size = new System.Drawing.Size(226, 26);
            this.IdentificacionCliente.TabIndex = 6;
            // 
            // NombreCliente
            // 
            this.NombreCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NombreCliente.Location = new System.Drawing.Point(170, 74);
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(226, 26);
            this.NombreCliente.TabIndex = 7;
            // 
            // CedulaCliente
            // 
            this.CedulaCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CedulaCliente.Location = new System.Drawing.Point(170, 115);
            this.CedulaCliente.Name = "CedulaCliente";
            this.CedulaCliente.Size = new System.Drawing.Size(226, 26);
            this.CedulaCliente.TabIndex = 8;
            this.CedulaCliente.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TipodepedidoCliente
            // 
            this.TipodepedidoCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TipodepedidoCliente.Location = new System.Drawing.Point(170, 199);
            this.TipodepedidoCliente.Name = "TipodepedidoCliente";
            this.TipodepedidoCliente.Size = new System.Drawing.Size(226, 26);
            this.TipodepedidoCliente.TabIndex = 9;
            // 
            // HoradelpedidoCliente
            // 
            this.HoradelpedidoCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.HoradelpedidoCliente.Location = new System.Drawing.Point(170, 237);
            this.HoradelpedidoCliente.Name = "HoradelpedidoCliente";
            this.HoradelpedidoCliente.Size = new System.Drawing.Size(226, 26);
            this.HoradelpedidoCliente.TabIndex = 10;
            // 
            // UbicacionCliente
            // 
            this.UbicacionCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UbicacionCliente.Location = new System.Drawing.Point(170, 162);
            this.UbicacionCliente.Name = "UbicacionCliente";
            this.UbicacionCliente.Size = new System.Drawing.Size(226, 26);
            this.UbicacionCliente.TabIndex = 11;
            // 
            // button_atras
            // 
            this.button_atras.BackColor = System.Drawing.Color.LightCoral;
            this.button_atras.Location = new System.Drawing.Point(644, 606);
            this.button_atras.Name = "button_atras";
            this.button_atras.Size = new System.Drawing.Size(104, 50);
            this.button_atras.TabIndex = 12;
            this.button_atras.Text = "ATRAS";
            this.button_atras.UseVisualStyleBackColor = false;
            this.button_atras.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_siguiente
            // 
            this.button_siguiente.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_siguiente.Location = new System.Drawing.Point(795, 606);
            this.button_siguiente.Name = "button_siguiente";
            this.button_siguiente.Size = new System.Drawing.Size(113, 50);
            this.button_siguiente.TabIndex = 13;
            this.button_siguiente.Text = "SIGUIENTE";
            this.button_siguiente.UseVisualStyleBackColor = false;
            this.button_siguiente.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_guardar
            // 
            this.button_guardar.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_guardar.Location = new System.Drawing.Point(29, 290);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(117, 49);
            this.button_guardar.TabIndex = 15;
            this.button_guardar.Text = "GUARDAR";
            this.button_guardar.UseVisualStyleBackColor = false;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.Color.LightGreen;
            this.button_eliminar.Location = new System.Drawing.Point(170, 290);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(113, 49);
            this.button_eliminar.TabIndex = 16;
            this.button_eliminar.Text = "ELIMINAR";
            this.button_eliminar.UseVisualStyleBackColor = false;
            // 
            // dataGridView_tablaclientes
            // 
            this.dataGridView_tablaclientes.AllowUserToAddRows = false;
            this.dataGridView_tablaclientes.AllowUserToDeleteRows = false;
            this.dataGridView_tablaclientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_tablaclientes.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView_tablaclientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_tablaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tablaclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView_tablaclientes.Location = new System.Drawing.Point(29, 382);
            this.dataGridView_tablaclientes.Name = "dataGridView_tablaclientes";
            this.dataGridView_tablaclientes.RowHeadersVisible = false;
            this.dataGridView_tablaclientes.RowHeadersWidth = 62;
            this.dataGridView_tablaclientes.RowTemplate.Height = 28;
            this.dataGridView_tablaclientes.Size = new System.Drawing.Size(956, 208);
            this.dataGridView_tablaclientes.TabIndex = 17;
            this.dataGridView_tablaclientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre cliente";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cedula";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ubicacion";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "tipo de pedido";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "hora del pedido";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // pictureBox_persona
            // 
            this.pictureBox_persona.Image = global::Proyecto_Restaurante.Properties.Resources.cliente;
            this.pictureBox_persona.Location = new System.Drawing.Point(540, 29);
            this.pictureBox_persona.Name = "pictureBox_persona";
            this.pictureBox_persona.Size = new System.Drawing.Size(368, 272);
            this.pictureBox_persona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_persona.TabIndex = 14;
            this.pictureBox_persona.TabStop = false;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1018, 694);
            this.Controls.Add(this.dataGridView_tablaclientes);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.pictureBox_persona);
            this.Controls.Add(this.button_siguiente);
            this.Controls.Add(this.button_atras);
            this.Controls.Add(this.UbicacionCliente);
            this.Controls.Add(this.HoradelpedidoCliente);
            this.Controls.Add(this.TipodepedidoCliente);
            this.Controls.Add(this.CedulaCliente);
            this.Controls.Add(this.NombreCliente);
            this.Controls.Add(this.IdentificacionCliente);
            this.Controls.Add(this.Hora_del_pedido);
            this.Controls.Add(this.Tipo_de_pedido);
            this.Controls.Add(this.Ubicacion);
            this.Controls.Add(this.Cedula);
            this.Controls.Add(this.Nombre_cliente);
            this.Controls.Add(this.ID);
            this.MaximumSize = new System.Drawing.Size(1040, 750);
            this.MinimumSize = new System.Drawing.Size(1040, 750);
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tablaclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_persona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Nombre_cliente;
        private System.Windows.Forms.Label Cedula;
        private System.Windows.Forms.Label Ubicacion;
        private System.Windows.Forms.Label Tipo_de_pedido;
        private System.Windows.Forms.Label Hora_del_pedido;
        private System.Windows.Forms.TextBox IdentificacionCliente;
        private System.Windows.Forms.TextBox NombreCliente;
        private System.Windows.Forms.TextBox CedulaCliente;
        private System.Windows.Forms.TextBox TipodepedidoCliente;
        private System.Windows.Forms.TextBox HoradelpedidoCliente;
        private System.Windows.Forms.TextBox UbicacionCliente;
        private System.Windows.Forms.Button button_atras;
        private System.Windows.Forms.Button button_siguiente;
        private System.Windows.Forms.PictureBox pictureBox_persona;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.DataGridView dataGridView_tablaclientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}