namespace UserInterface
{
    partial class ConsultarPrestamos
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
            this.dgr_prestamos = new System.Windows.Forms.DataGridView();
            this.txt_libro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_nombrelibro = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.lbl_autor = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.dt_inicio = new System.Windows.Forms.DateTimePicker();
            this.dt_fin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_prestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgr_prestamos
            // 
            this.dgr_prestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_prestamos.Location = new System.Drawing.Point(12, 36);
            this.dgr_prestamos.Name = "dgr_prestamos";
            this.dgr_prestamos.RowHeadersWidth = 51;
            this.dgr_prestamos.RowTemplate.Height = 24;
            this.dgr_prestamos.Size = new System.Drawing.Size(759, 402);
            this.dgr_prestamos.TabIndex = 3;
            this.dgr_prestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_prestamos_CellContentClick);
            // 
            // txt_libro
            // 
            this.txt_libro.Location = new System.Drawing.Point(958, 158);
            this.txt_libro.Name = "txt_libro";
            this.txt_libro.Size = new System.Drawing.Size(123, 22);
            this.txt_libro.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(825, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Libro:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(958, 78);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 22);
            this.txt_id.TabIndex = 42;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(825, 75);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(38, 25);
            this.lbl_id.TabIndex = 41;
            this.lbl_id.Text = "Id:";
            // 
            // lbl_nombrelibro
            // 
            this.lbl_nombrelibro.AutoSize = true;
            this.lbl_nombrelibro.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombrelibro.Location = new System.Drawing.Point(825, 118);
            this.lbl_nombrelibro.Name = "lbl_nombrelibro";
            this.lbl_nombrelibro.Size = new System.Drawing.Size(83, 25);
            this.lbl_nombrelibro.TabIndex = 38;
            this.lbl_nombrelibro.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(960, 118);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 22);
            this.txt_nombre.TabIndex = 37;
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.Location = new System.Drawing.Point(827, 242);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(43, 25);
            this.lbl_genero.TabIndex = 36;
            this.lbl_genero.Text = "Fin:";
            // 
            // lbl_autor
            // 
            this.lbl_autor.AutoSize = true;
            this.lbl_autor.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_autor.Location = new System.Drawing.Point(827, 198);
            this.lbl_autor.Name = "lbl_autor";
            this.lbl_autor.Size = new System.Drawing.Size(65, 25);
            this.lbl_autor.TabIndex = 35;
            this.lbl_autor.Text = "Inicio:";
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(943, 384);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(175, 44);
            this.btn_delete.TabIndex = 34;
            this.btn_delete.Text = "Eliminar Prestamo";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(777, 384);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(160, 44);
            this.btn_edit.TabIndex = 33;
            this.btn_edit.Text = "Editar Prestamo";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // dt_inicio
            // 
            this.dt_inicio.Location = new System.Drawing.Point(918, 198);
            this.dt_inicio.Name = "dt_inicio";
            this.dt_inicio.Size = new System.Drawing.Size(200, 22);
            this.dt_inicio.TabIndex = 45;
            // 
            // dt_fin
            // 
            this.dt_fin.Location = new System.Drawing.Point(918, 242);
            this.dt_fin.Name = "dt_fin";
            this.dt_fin.Size = new System.Drawing.Size(200, 22);
            this.dt_fin.TabIndex = 46;
            // 
            // ConsultarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 510);
            this.Controls.Add(this.dt_fin);
            this.Controls.Add(this.dt_inicio);
            this.Controls.Add(this.txt_libro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_nombrelibro);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.lbl_autor);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dgr_prestamos);
            this.Name = "ConsultarPrestamos";
            this.Text = "ConsultarPrestamos";
            ((System.ComponentModel.ISupportInitialize)(this.dgr_prestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgr_prestamos;
        private System.Windows.Forms.TextBox txt_libro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_nombrelibro;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Label lbl_autor;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DateTimePicker dt_inicio;
        private System.Windows.Forms.DateTimePicker dt_fin;
    }
}