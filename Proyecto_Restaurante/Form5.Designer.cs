namespace Proyecto_Restaurante
{
    partial class Form_factura
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
            this.lab_id = new System.Windows.Forms.Label();
            this.lab_nombrecliente = new System.Windows.Forms.Label();
            this.lab_cedula = new System.Windows.Forms.Label();
            this.lab_pedido = new System.Windows.Forms.Label();
            this.lab_formapago = new System.Windows.Forms.Label();
            this.lab_precioproducto = new System.Windows.Forms.Label();
            this.lab_pago = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_precioproducto = new System.Windows.Forms.TextBox();
            this.textBox_formapago = new System.Windows.Forms.TextBox();
            this.textBox_pedido = new System.Windows.Forms.TextBox();
            this.textBox_cedula = new System.Windows.Forms.TextBox();
            this.textBox_cliente = new System.Windows.Forms.TextBox();
            this.textBox_pago = new System.Windows.Forms.TextBox();
            this.button_atras = new System.Windows.Forms.Button();
            this.button_siguiente = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.dataGridView_tablafactura = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tablafactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_id
            // 
            this.lab_id.AutoSize = true;
            this.lab_id.Location = new System.Drawing.Point(44, 42);
            this.lab_id.Name = "lab_id";
            this.lab_id.Size = new System.Drawing.Size(26, 20);
            this.lab_id.TabIndex = 0;
            this.lab_id.Text = "ID";
            // 
            // lab_nombrecliente
            // 
            this.lab_nombrecliente.AutoSize = true;
            this.lab_nombrecliente.Location = new System.Drawing.Point(44, 83);
            this.lab_nombrecliente.Name = "lab_nombrecliente";
            this.lab_nombrecliente.Size = new System.Drawing.Size(115, 20);
            this.lab_nombrecliente.TabIndex = 1;
            this.lab_nombrecliente.Text = "Nombre cliente";
            // 
            // lab_cedula
            // 
            this.lab_cedula.AutoSize = true;
            this.lab_cedula.Location = new System.Drawing.Point(44, 127);
            this.lab_cedula.Name = "lab_cedula";
            this.lab_cedula.Size = new System.Drawing.Size(59, 20);
            this.lab_cedula.TabIndex = 2;
            this.lab_cedula.Text = "Cedula";
            // 
            // lab_pedido
            // 
            this.lab_pedido.AutoSize = true;
            this.lab_pedido.Location = new System.Drawing.Point(44, 170);
            this.lab_pedido.Name = "lab_pedido";
            this.lab_pedido.Size = new System.Drawing.Size(58, 20);
            this.lab_pedido.TabIndex = 3;
            this.lab_pedido.Text = "Pedido";
            // 
            // lab_formapago
            // 
            this.lab_formapago.AutoSize = true;
            this.lab_formapago.Location = new System.Drawing.Point(44, 212);
            this.lab_formapago.Name = "lab_formapago";
            this.lab_formapago.Size = new System.Drawing.Size(117, 20);
            this.lab_formapago.TabIndex = 4;
            this.lab_formapago.Text = "Forma de pago";
            // 
            // lab_precioproducto
            // 
            this.lab_precioproducto.AutoSize = true;
            this.lab_precioproducto.Location = new System.Drawing.Point(44, 252);
            this.lab_precioproducto.Name = "lab_precioproducto";
            this.lab_precioproducto.Size = new System.Drawing.Size(145, 20);
            this.lab_precioproducto.TabIndex = 5;
            this.lab_precioproducto.Text = "Precio del producto";
            // 
            // lab_pago
            // 
            this.lab_pago.AutoSize = true;
            this.lab_pago.Location = new System.Drawing.Point(44, 290);
            this.lab_pago.Name = "lab_pago";
            this.lab_pago.Size = new System.Drawing.Size(46, 20);
            this.lab_pago.TabIndex = 6;
            this.lab_pago.Text = "Pago";
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_id.Location = new System.Drawing.Point(203, 42);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(234, 26);
            this.textBox_id.TabIndex = 7;
            // 
            // textBox_precioproducto
            // 
            this.textBox_precioproducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_precioproducto.Location = new System.Drawing.Point(203, 252);
            this.textBox_precioproducto.Name = "textBox_precioproducto";
            this.textBox_precioproducto.Size = new System.Drawing.Size(234, 26);
            this.textBox_precioproducto.TabIndex = 8;
            // 
            // textBox_formapago
            // 
            this.textBox_formapago.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_formapago.Location = new System.Drawing.Point(203, 212);
            this.textBox_formapago.Name = "textBox_formapago";
            this.textBox_formapago.Size = new System.Drawing.Size(234, 26);
            this.textBox_formapago.TabIndex = 9;
            this.textBox_formapago.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_pedido
            // 
            this.textBox_pedido.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_pedido.Location = new System.Drawing.Point(203, 170);
            this.textBox_pedido.Name = "textBox_pedido";
            this.textBox_pedido.Size = new System.Drawing.Size(234, 26);
            this.textBox_pedido.TabIndex = 10;
            // 
            // textBox_cedula
            // 
            this.textBox_cedula.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_cedula.Location = new System.Drawing.Point(203, 127);
            this.textBox_cedula.Name = "textBox_cedula";
            this.textBox_cedula.Size = new System.Drawing.Size(234, 26);
            this.textBox_cedula.TabIndex = 11;
            // 
            // textBox_cliente
            // 
            this.textBox_cliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_cliente.Location = new System.Drawing.Point(203, 83);
            this.textBox_cliente.Name = "textBox_cliente";
            this.textBox_cliente.Size = new System.Drawing.Size(234, 26);
            this.textBox_cliente.TabIndex = 12;
            // 
            // textBox_pago
            // 
            this.textBox_pago.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_pago.Location = new System.Drawing.Point(203, 290);
            this.textBox_pago.Name = "textBox_pago";
            this.textBox_pago.Size = new System.Drawing.Size(234, 26);
            this.textBox_pago.TabIndex = 13;
            // 
            // button_atras
            // 
            this.button_atras.BackColor = System.Drawing.Color.LightCoral;
            this.button_atras.Location = new System.Drawing.Point(659, 627);
            this.button_atras.Name = "button_atras";
            this.button_atras.Size = new System.Drawing.Size(121, 44);
            this.button_atras.TabIndex = 14;
            this.button_atras.Text = "ATRAS";
            this.button_atras.UseVisualStyleBackColor = false;
            this.button_atras.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_siguiente
            // 
            this.button_siguiente.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_siguiente.Location = new System.Drawing.Point(813, 627);
            this.button_siguiente.Name = "button_siguiente";
            this.button_siguiente.Size = new System.Drawing.Size(121, 44);
            this.button_siguiente.TabIndex = 15;
            this.button_siguiente.Text = "SIGUIENTE";
            this.button_siguiente.UseVisualStyleBackColor = false;
            this.button_siguiente.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_guardar
            // 
            this.button_guardar.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_guardar.Location = new System.Drawing.Point(48, 330);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(111, 55);
            this.button_guardar.TabIndex = 17;
            this.button_guardar.Text = "GUARDAR";
            this.button_guardar.UseVisualStyleBackColor = false;
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.Color.LightGreen;
            this.button_eliminar.Location = new System.Drawing.Point(191, 330);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(118, 55);
            this.button_eliminar.TabIndex = 18;
            this.button_eliminar.Text = "ELIMINAR";
            this.button_eliminar.UseVisualStyleBackColor = false;
            // 
            // dataGridView_tablafactura
            // 
            this.dataGridView_tablafactura.AllowUserToAddRows = false;
            this.dataGridView_tablafactura.AllowUserToDeleteRows = false;
            this.dataGridView_tablafactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_tablafactura.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView_tablafactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_tablafactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tablafactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView_tablafactura.Location = new System.Drawing.Point(48, 410);
            this.dataGridView_tablafactura.Name = "dataGridView_tablafactura";
            this.dataGridView_tablafactura.ReadOnly = true;
            this.dataGridView_tablafactura.RowHeadersVisible = false;
            this.dataGridView_tablafactura.RowHeadersWidth = 62;
            this.dataGridView_tablafactura.RowTemplate.Height = 28;
            this.dataGridView_tablafactura.Size = new System.Drawing.Size(937, 208);
            this.dataGridView_tablafactura.TabIndex = 19;
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
            this.Column2.HeaderText = "Nombre cliente";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cedula";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Pedido";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Forma de pago";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Precio del producto";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Pago";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Proyecto_Restaurante.Properties.Resources.factura_comercial;
            this.pictureBox1.Location = new System.Drawing.Point(559, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1006, 678);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView_tablafactura);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.button_siguiente);
            this.Controls.Add(this.button_atras);
            this.Controls.Add(this.textBox_pago);
            this.Controls.Add(this.textBox_cliente);
            this.Controls.Add(this.textBox_cedula);
            this.Controls.Add(this.textBox_pedido);
            this.Controls.Add(this.textBox_formapago);
            this.Controls.Add(this.textBox_precioproducto);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.lab_pago);
            this.Controls.Add(this.lab_precioproducto);
            this.Controls.Add(this.lab_formapago);
            this.Controls.Add(this.lab_pedido);
            this.Controls.Add(this.lab_cedula);
            this.Controls.Add(this.lab_nombrecliente);
            this.Controls.Add(this.lab_id);
            this.Name = "Form_factura";
            this.Text = "FACTURA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tablafactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_id;
        private System.Windows.Forms.Label lab_nombrecliente;
        private System.Windows.Forms.Label lab_cedula;
        private System.Windows.Forms.Label lab_pedido;
        private System.Windows.Forms.Label lab_formapago;
        private System.Windows.Forms.Label lab_precioproducto;
        private System.Windows.Forms.Label lab_pago;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_precioproducto;
        private System.Windows.Forms.TextBox textBox_formapago;
        private System.Windows.Forms.TextBox textBox_pedido;
        private System.Windows.Forms.TextBox textBox_cedula;
        private System.Windows.Forms.TextBox textBox_cliente;
        private System.Windows.Forms.TextBox textBox_pago;
        private System.Windows.Forms.Button button_atras;
        private System.Windows.Forms.Button button_siguiente;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.DataGridView dataGridView_tablafactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}