namespace Soporte_tecnico
{
    partial class FLogin
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
            this.Cancelarbutton2 = new System.Windows.Forms.Button();
            this.Contrasenatxt = new System.Windows.Forms.TextBox();
            this.Usuariotxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Aceptarbutton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelarbutton2
            // 
            this.Cancelarbutton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelarbutton2.Image = global::Soporte_tecnico.Properties.Resources.boton_x;
            this.Cancelarbutton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarbutton2.Location = new System.Drawing.Point(306, 206);
            this.Cancelarbutton2.Name = "Cancelarbutton2";
            this.Cancelarbutton2.Size = new System.Drawing.Size(129, 33);
            this.Cancelarbutton2.TabIndex = 13;
            this.Cancelarbutton2.Text = "Cancelar";
            this.Cancelarbutton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelarbutton2.UseVisualStyleBackColor = true;
            this.Cancelarbutton2.Click += new System.EventHandler(this.Cancelarbutton2_Click);
            // 
            // Contrasenatxt
            // 
            this.Contrasenatxt.Location = new System.Drawing.Point(238, 137);
            this.Contrasenatxt.Name = "Contrasenatxt";
            this.Contrasenatxt.PasswordChar = 'X';
            this.Contrasenatxt.Size = new System.Drawing.Size(100, 26);
            this.Contrasenatxt.TabIndex = 11;
            this.Contrasenatxt.TextChanged += new System.EventHandler(this.Contrasenatxt_TextChanged);
            // 
            // Usuariotxt
            // 
            this.Usuariotxt.Location = new System.Drawing.Point(238, 75);
            this.Usuariotxt.Name = "Usuariotxt";
            this.Usuariotxt.Size = new System.Drawing.Size(100, 26);
            this.Usuariotxt.TabIndex = 10;
            this.Usuariotxt.TextChanged += new System.EventHandler(this.Usuariotxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Aceptarbutton1
            // 
            this.Aceptarbutton1.Image = global::Soporte_tecnico.Properties.Resources.aceptar__1_;
            this.Aceptarbutton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Aceptarbutton1.Location = new System.Drawing.Point(138, 206);
            this.Aceptarbutton1.Name = "Aceptarbutton1";
            this.Aceptarbutton1.Size = new System.Drawing.Size(129, 33);
            this.Aceptarbutton1.TabIndex = 12;
            this.Aceptarbutton1.Text = "Aceptar";
            this.Aceptarbutton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Aceptarbutton1.UseVisualStyleBackColor = true;
            this.Aceptarbutton1.Click += new System.EventHandler(this.Aceptarbutton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Soporte_tecnico.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(371, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 296);
            this.Controls.Add(this.Cancelarbutton2);
            this.Controls.Add(this.Aceptarbutton1);
            this.Controls.Add(this.Contrasenatxt);
            this.Controls.Add(this.Usuariotxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelarbutton2;
        private System.Windows.Forms.Button Aceptarbutton1;
        private System.Windows.Forms.TextBox Contrasenatxt;
        private System.Windows.Forms.TextBox Usuariotxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

