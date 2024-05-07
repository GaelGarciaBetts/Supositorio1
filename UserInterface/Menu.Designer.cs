namespace UserInterface
{
    partial class Menu
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.bttn_libros = new System.Windows.Forms.Button();
            this.bttn_autores = new System.Windows.Forms.Button();
            this.bttn_prestamos = new System.Windows.Forms.Button();
            this.bttn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(194, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(366, 41);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "BIBLIOTECA PERRONA";
            // 
            // bttn_libros
            // 
            this.bttn_libros.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_libros.Location = new System.Drawing.Point(103, 133);
            this.bttn_libros.Name = "bttn_libros";
            this.bttn_libros.Size = new System.Drawing.Size(114, 48);
            this.bttn_libros.TabIndex = 1;
            this.bttn_libros.Text = "LIBROS";
            this.bttn_libros.UseVisualStyleBackColor = true;
            this.bttn_libros.Click += new System.EventHandler(this.bttn_libros_Click);
            // 
            // bttn_autores
            // 
            this.bttn_autores.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_autores.Location = new System.Drawing.Point(525, 133);
            this.bttn_autores.Name = "bttn_autores";
            this.bttn_autores.Size = new System.Drawing.Size(172, 48);
            this.bttn_autores.TabIndex = 2;
            this.bttn_autores.Text = "AUTORES";
            this.bttn_autores.UseVisualStyleBackColor = true;
            this.bttn_autores.Click += new System.EventHandler(this.bttn_altas_Click);
            // 
            // bttn_prestamos
            // 
            this.bttn_prestamos.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_prestamos.Location = new System.Drawing.Point(292, 133);
            this.bttn_prestamos.Name = "bttn_prestamos";
            this.bttn_prestamos.Size = new System.Drawing.Size(178, 48);
            this.bttn_prestamos.TabIndex = 3;
            this.bttn_prestamos.Text = "PRESTAMOS";
            this.bttn_prestamos.UseVisualStyleBackColor = true;
            this.bttn_prestamos.Click += new System.EventHandler(this.bttn_prestamos_Click);
            // 
            // bttn_salir
            // 
            this.bttn_salir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttn_salir.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_salir.Location = new System.Drawing.Point(539, 390);
            this.bttn_salir.Name = "bttn_salir";
            this.bttn_salir.Size = new System.Drawing.Size(213, 48);
            this.bttn_salir.TabIndex = 4;
            this.bttn_salir.Text = "LASIR pafuera";
            this.bttn_salir.UseVisualStyleBackColor = false;
            this.bttn_salir.Click += new System.EventHandler(this.bttn_salir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttn_salir);
            this.Controls.Add(this.bttn_prestamos);
            this.Controls.Add(this.bttn_autores);
            this.Controls.Add(this.bttn_libros);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button bttn_libros;
        private System.Windows.Forms.Button bttn_autores;
        private System.Windows.Forms.Button bttn_prestamos;
        private System.Windows.Forms.Button bttn_salir;
    }
}

