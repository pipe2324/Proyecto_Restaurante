namespace Proyecto_Restaurante
{
    partial class Usuario
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
            this.lab_CONTRASEÑA = new System.Windows.Forms.Label();
            this.but_ingresar = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
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
            // lab_CONTRASEÑA
            // 
            this.lab_CONTRASEÑA.AutoSize = true;
            this.lab_CONTRASEÑA.Location = new System.Drawing.Point(331, 316);
            this.lab_CONTRASEÑA.Name = "lab_CONTRASEÑA";
            this.lab_CONTRASEÑA.Size = new System.Drawing.Size(119, 20);
            this.lab_CONTRASEÑA.TabIndex = 2;
            this.lab_CONTRASEÑA.Text = "CONTRASEÑA";
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
            // user
            // 
            this.user.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.user.Location = new System.Drawing.Point(470, 258);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(203, 26);
            this.user.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Password.Location = new System.Drawing.Point(470, 316);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(203, 26);
            this.Password.TabIndex = 5;
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
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.but_ingresar);
            this.Controls.Add(this.lab_CONTRASEÑA);
            this.Controls.Add(this.lab_USUARIO);
            this.Controls.Add(this.lab_restaurante);
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCESO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_restaurante;
        private System.Windows.Forms.Label lab_USUARIO;
        private System.Windows.Forms.Label lab_CONTRASEÑA;
        private System.Windows.Forms.Button but_ingresar;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

