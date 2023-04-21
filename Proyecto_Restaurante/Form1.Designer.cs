namespace Proyecto_Restaurante
{
    partial class Form_acceso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_restaurante = new System.Windows.Forms.Label();
            this.lab_USUARIO = new System.Windows.Forms.Label();
            this.lab_contraseña = new System.Windows.Forms.Label();
            this.but_ingresar = new System.Windows.Forms.Button();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_contraseña = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_restaurante
            // 
            this.lab_restaurante.AutoSize = true;
            this.lab_restaurante.Location = new System.Drawing.Point(424, 55);
            this.lab_restaurante.Name = "lab_restaurante";
            this.lab_restaurante.Size = new System.Drawing.Size(263, 20);
            this.lab_restaurante.TabIndex = 0;
            this.lab_restaurante.Text = "RESTAURANTE EL BUEN SABOR";
            // 
            // lab_USUARIO
            // 
            this.lab_USUARIO.AutoSize = true;
            this.lab_USUARIO.Location = new System.Drawing.Point(331, 264);
            this.lab_USUARIO.Name = "lab_USUARIO";
            this.lab_USUARIO.Size = new System.Drawing.Size(84, 20);
            this.lab_USUARIO.TabIndex = 1;
            this.lab_USUARIO.Text = "USUARIO";
            // 
            // lab_contraseña
            // 
            this.lab_contraseña.AutoSize = true;
            this.lab_contraseña.Location = new System.Drawing.Point(331, 316);
            this.lab_contraseña.Name = "lab_contraseña";
            this.lab_contraseña.Size = new System.Drawing.Size(119, 20);
            this.lab_contraseña.TabIndex = 2;
            this.lab_contraseña.Text = "CONTRASEÑA";
            // 
            // but_ingresar
            // 
            this.but_ingresar.BackColor = System.Drawing.Color.Salmon;
            this.but_ingresar.Location = new System.Drawing.Point(470, 373);
            this.but_ingresar.Name = "but_ingresar";
            this.but_ingresar.Size = new System.Drawing.Size(127, 51);
            this.but_ingresar.TabIndex = 3;
            this.but_ingresar.Text = "INGRESAR";
            this.but_ingresar.UseVisualStyleBackColor = false;
            this.but_ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_usuario.Location = new System.Drawing.Point(470, 258);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(203, 26);
            this.textBox_usuario.TabIndex = 4;
            // 
            // textBox_contraseña
            // 
            this.textBox_contraseña.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_contraseña.Location = new System.Drawing.Point(470, 316);
            this.textBox_contraseña.Name = "textBox_contraseña";
            this.textBox_contraseña.Size = new System.Drawing.Size(203, 26);
            this.textBox_contraseña.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Proyecto_Restaurante.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(470, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form_acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1050, 592);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_contraseña);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.but_ingresar);
            this.Controls.Add(this.lab_contraseña);
            this.Controls.Add(this.lab_USUARIO);
            this.Controls.Add(this.lab_restaurante);
            this.Name = "Form_acceso";
            this.Text = "ACCESO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_restaurante;
        private System.Windows.Forms.Label lab_USUARIO;
        private System.Windows.Forms.Label lab_contraseña;
        private System.Windows.Forms.Button but_ingresar;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.TextBox textBox_contraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

