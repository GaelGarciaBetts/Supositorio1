namespace UserInterface
{
    partial class AddAutor
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
            this.lbl_nombreAutor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nacionalidad = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_nombreAutor
            // 
            this.lbl_nombreAutor.AutoSize = true;
            this.lbl_nombreAutor.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreAutor.Location = new System.Drawing.Point(246, 155);
            this.lbl_nombreAutor.Name = "lbl_nombreAutor";
            this.lbl_nombreAutor.Size = new System.Drawing.Size(83, 25);
            this.lbl_nombreAutor.TabIndex = 19;
            this.lbl_nombreAutor.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(403, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 18;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido.Location = new System.Drawing.Point(246, 197);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(84, 25);
            this.lbl_Apellido.TabIndex = 17;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(403, 197);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre.TabIndex = 16;
            // 
            // lbl_nacionalidad
            // 
            this.lbl_nacionalidad.AutoSize = true;
            this.lbl_nacionalidad.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nacionalidad.Location = new System.Drawing.Point(208, 231);
            this.lbl_nacionalidad.Name = "lbl_nacionalidad";
            this.lbl_nacionalidad.Size = new System.Drawing.Size(122, 25);
            this.lbl_nacionalidad.TabIndex = 23;
            this.lbl_nacionalidad.Text = "Nacionalidad:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(404, 234);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 22;
            // 
            // AddAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_nacionalidad);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_nombreAutor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.txt_nombre);
            this.Name = "AddAutor";
            this.Text = "AddAutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombreAutor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nacionalidad;
        private System.Windows.Forms.TextBox textBox2;
    }
}