namespace UserInterface
{
    partial class AddLibro
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
            this.lbl_genero = new System.Windows.Forms.Label();
            this.lbl_autor = new System.Windows.Forms.Label();
            this.lbl_nombrelibro = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_editorial = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.cbo_autor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.Location = new System.Drawing.Point(109, 153);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(89, 25);
            this.lbl_genero.TabIndex = 11;
            this.lbl_genero.Text = "Editorial:";
            // 
            // lbl_autor
            // 
            this.lbl_autor.AutoSize = true;
            this.lbl_autor.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_autor.Location = new System.Drawing.Point(109, 109);
            this.lbl_autor.Name = "lbl_autor";
            this.lbl_autor.Size = new System.Drawing.Size(65, 25);
            this.lbl_autor.TabIndex = 10;
            this.lbl_autor.Text = "Autor:";
            // 
            // lbl_nombrelibro
            // 
            this.lbl_nombrelibro.AutoSize = true;
            this.lbl_nombrelibro.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombrelibro.Location = new System.Drawing.Point(109, 67);
            this.lbl_nombrelibro.Name = "lbl_nombrelibro";
            this.lbl_nombrelibro.Size = new System.Drawing.Size(83, 25);
            this.lbl_nombrelibro.TabIndex = 15;
            this.lbl_nombrelibro.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(266, 67);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 22);
            this.txt_nombre.TabIndex = 14;
            // 
            // txt_editorial
            // 
            this.txt_editorial.Location = new System.Drawing.Point(264, 157);
            this.txt_editorial.Name = "txt_editorial";
            this.txt_editorial.Size = new System.Drawing.Size(123, 22);
            this.txt_editorial.TabIndex = 16;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(275, 219);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(112, 43);
            this.btn_agregar.TabIndex = 21;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbo_autor
            // 
            this.cbo_autor.FormattingEnabled = true;
            this.cbo_autor.Location = new System.Drawing.Point(266, 109);
            this.cbo_autor.Name = "cbo_autor";
            this.cbo_autor.Size = new System.Drawing.Size(121, 24);
            this.cbo_autor.TabIndex = 22;
            // 
            // AddLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 370);
            this.Controls.Add(this.cbo_autor);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_editorial);
            this.Controls.Add(this.lbl_nombrelibro);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.lbl_autor);
            this.Name = "AddLibro";
            this.Text = "Agregar Libro";
            this.Load += new System.EventHandler(this.AddLibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Label lbl_autor;
        private System.Windows.Forms.Label lbl_nombrelibro;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_editorial;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox cbo_autor;
    }
}