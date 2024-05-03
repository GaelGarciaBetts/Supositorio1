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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombrelibro = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_anopub = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_edicion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.Location = new System.Drawing.Point(251, 201);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(77, 25);
            this.lbl_genero.TabIndex = 11;
            this.lbl_genero.Text = "Género:";
            // 
            // lbl_autor
            // 
            this.lbl_autor.AutoSize = true;
            this.lbl_autor.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_autor.Location = new System.Drawing.Point(251, 157);
            this.lbl_autor.Name = "lbl_autor";
            this.lbl_autor.Size = new System.Drawing.Size(65, 25);
            this.lbl_autor.TabIndex = 10;
            this.lbl_autor.Text = "Autor:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(408, 157);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre.TabIndex = 9;
            // 
            // lbl_nombrelibro
            // 
            this.lbl_nombrelibro.AutoSize = true;
            this.lbl_nombrelibro.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombrelibro.Location = new System.Drawing.Point(251, 115);
            this.lbl_nombrelibro.Name = "lbl_nombrelibro";
            this.lbl_nombrelibro.Size = new System.Drawing.Size(83, 25);
            this.lbl_nombrelibro.TabIndex = 15;
            this.lbl_nombrelibro.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(408, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(406, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 16;
            // 
            // lbl_anopub
            // 
            this.lbl_anopub.AutoSize = true;
            this.lbl_anopub.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anopub.Location = new System.Drawing.Point(163, 251);
            this.lbl_anopub.Name = "lbl_anopub";
            this.lbl_anopub.Size = new System.Drawing.Size(171, 25);
            this.lbl_anopub.TabIndex = 17;
            this.lbl_anopub.Text = "Año de Publicación:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(408, 254);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(408, 298);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 20;
            // 
            // lbl_edicion
            // 
            this.lbl_edicion.AutoSize = true;
            this.lbl_edicion.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edicion.Location = new System.Drawing.Point(239, 295);
            this.lbl_edicion.Name = "lbl_edicion";
            this.lbl_edicion.Size = new System.Drawing.Size(77, 25);
            this.lbl_edicion.TabIndex = 19;
            this.lbl_edicion.Text = "Edición:";
            // 
            // AddLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lbl_edicion);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl_anopub);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_nombrelibro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.lbl_autor);
            this.Controls.Add(this.txt_nombre);
            this.Name = "AddLibro";
            this.Text = "AddLibro";
            this.Load += new System.EventHandler(this.AddLibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Label lbl_autor;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombrelibro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_anopub;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_edicion;
    }
}