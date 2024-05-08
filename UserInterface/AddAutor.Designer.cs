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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nombreAutor
            // 
            this.lbl_nombreAutor.AutoSize = true;
            this.lbl_nombreAutor.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreAutor.Location = new System.Drawing.Point(124, 68);
            this.lbl_nombreAutor.Name = "lbl_nombreAutor";
            this.lbl_nombreAutor.Size = new System.Drawing.Size(83, 25);
            this.lbl_nombreAutor.TabIndex = 19;
            this.lbl_nombreAutor.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(281, 68);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre.TabIndex = 18;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido.Location = new System.Drawing.Point(124, 110);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(84, 25);
            this.lbl_Apellido.TabIndex = 17;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(281, 110);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 22);
            this.txt_apellido.TabIndex = 16;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(284, 165);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(97, 38);
            this.btn_agregar.TabIndex = 24;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 271);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_nombreAutor);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.txt_apellido);
            this.Name = "AddAutor";
            this.Text = "AddAutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombreAutor;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Button btn_agregar;
    }
}