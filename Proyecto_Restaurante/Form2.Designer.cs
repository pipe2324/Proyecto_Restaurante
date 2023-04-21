namespace Proyecto_Restaurante
{
    partial class Form_seleccione
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
            this.comboBox_lista = new System.Windows.Forms.ComboBox();
            this.but_atras = new System.Windows.Forms.Button();
            this.but_siguiente = new System.Windows.Forms.Button();
            this.label_descripcion = new System.Windows.Forms.Label();
            this.label_informacion = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_lista
            // 
            this.comboBox_lista.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox_lista.FormattingEnabled = true;
            this.comboBox_lista.Items.AddRange(new object[] {
            "ACCESO",
            "CLIENTES",
            "PAGOS",
            "FACTURA"});
            this.comboBox_lista.Location = new System.Drawing.Point(101, 31);
            this.comboBox_lista.Name = "comboBox_lista";
            this.comboBox_lista.Size = new System.Drawing.Size(296, 28);
            this.comboBox_lista.TabIndex = 0;
            this.comboBox_lista.Text = "RESTAURANTE EL BUEN SABOR";
            this.comboBox_lista.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // but_atras
            // 
            this.but_atras.BackColor = System.Drawing.Color.LightCoral;
            this.but_atras.Location = new System.Drawing.Point(702, 563);
            this.but_atras.Name = "but_atras";
            this.but_atras.Size = new System.Drawing.Size(112, 48);
            this.but_atras.TabIndex = 1;
            this.but_atras.Text = "ATRAS";
            this.but_atras.UseVisualStyleBackColor = false;
            this.but_atras.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_siguiente
            // 
            this.but_siguiente.BackColor = System.Drawing.Color.LightSkyBlue;
            this.but_siguiente.Location = new System.Drawing.Point(871, 563);
            this.but_siguiente.Name = "but_siguiente";
            this.but_siguiente.Size = new System.Drawing.Size(119, 48);
            this.but_siguiente.TabIndex = 2;
            this.but_siguiente.Text = "SIGUIENTE";
            this.but_siguiente.UseVisualStyleBackColor = false;
            this.but_siguiente.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label_descripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descripcion.Location = new System.Drawing.Point(96, 359);
            this.label_descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.label_descripcion.MaximumSize = new System.Drawing.Size(400, 400);
            this.label_descripcion.MinimumSize = new System.Drawing.Size(30, 30);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(392, 135);
            this.label_descripcion.TabIndex = 4;
            this.label_descripcion.Text = "El restaurante el buen sabor es un lugar expectacular.\r\nEn el cual se puede disfr" +
    "utar de diferentes platos exoticos \r\na un precio unico al publico.";
            // 
            // label_informacion
            // 
            this.label_informacion.AutoSize = true;
            this.label_informacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_informacion.Location = new System.Drawing.Point(123, 547);
            this.label_informacion.Name = "label_informacion";
            this.label_informacion.Size = new System.Drawing.Size(507, 108);
            this.label_informacion.TabIndex = 5;
            this.label_informacion.Text = "Ubicacion: Corabastos Bodega 86 Local 97-98\r\n\r\n\r\nTelefono de contacto:3118680724";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Restaurante.Properties.Resources.telefono;
            this.pictureBox2.Location = new System.Drawing.Point(45, 615);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_logo.Image = global::Proyecto_Restaurante.Properties.Resources.mesa;
            this.pictureBox_logo.Location = new System.Drawing.Point(559, 31);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(457, 491);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 3;
            this.pictureBox_logo.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proyecto_Restaurante.Properties.Resources.ubica;
            this.pictureBox3.Location = new System.Drawing.Point(45, 529);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // Form_seleccione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1081, 693);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_informacion);
            this.Controls.Add(this.label_descripcion);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.but_siguiente);
            this.Controls.Add(this.but_atras);
            this.Controls.Add(this.comboBox_lista);
            this.Name = "Form_seleccione";
            this.Text = "SELECCIONE HACIA DONDE QUIERA IR";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_lista;
        private System.Windows.Forms.Button but_atras;
        private System.Windows.Forms.Button but_siguiente;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.Label label_informacion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}