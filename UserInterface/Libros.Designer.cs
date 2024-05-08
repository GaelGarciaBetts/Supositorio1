namespace UserInterface
{
    partial class Libros
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
            this.components = new System.ComponentModel.Container();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgr_libros = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_editorial = new System.Windows.Forms.TextBox();
            this.lbl_nombrelibro = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.lbl_autor = new System.Windows.Forms.Label();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_dispon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_libros)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(12, 12);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(160, 44);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar Libro";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgr_libros
            // 
            this.dgr_libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_libros.Location = new System.Drawing.Point(12, 63);
            this.dgr_libros.Name = "dgr_libros";
            this.dgr_libros.RowHeadersWidth = 51;
            this.dgr_libros.RowTemplate.Height = 24;
            this.dgr_libros.Size = new System.Drawing.Size(674, 375);
            this.dgr_libros.TabIndex = 2;
            this.dgr_libros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_libros_CellContentClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(727, 394);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(160, 44);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Editar Libro";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(893, 394);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(160, 44);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Eliminar Libro";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_editorial
            // 
            this.txt_editorial.Location = new System.Drawing.Point(881, 263);
            this.txt_editorial.Name = "txt_editorial";
            this.txt_editorial.Size = new System.Drawing.Size(123, 22);
            this.txt_editorial.TabIndex = 27;
            // 
            // lbl_nombrelibro
            // 
            this.lbl_nombrelibro.AutoSize = true;
            this.lbl_nombrelibro.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombrelibro.Location = new System.Drawing.Point(724, 135);
            this.lbl_nombrelibro.Name = "lbl_nombrelibro";
            this.lbl_nombrelibro.Size = new System.Drawing.Size(83, 25);
            this.lbl_nombrelibro.TabIndex = 26;
            this.lbl_nombrelibro.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(881, 135);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 22);
            this.txt_nombre.TabIndex = 25;
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.Location = new System.Drawing.Point(726, 259);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(89, 25);
            this.lbl_genero.TabIndex = 24;
            this.lbl_genero.Text = "Editorial:";
            // 
            // lbl_autor
            // 
            this.lbl_autor.AutoSize = true;
            this.lbl_autor.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_autor.Location = new System.Drawing.Point(726, 215);
            this.lbl_autor.Name = "lbl_autor";
            this.lbl_autor.Size = new System.Drawing.Size(65, 25);
            this.lbl_autor.TabIndex = 23;
            this.lbl_autor.Text = "Autor:";
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(881, 218);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(123, 22);
            this.txt_autor.TabIndex = 28;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(724, 92);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(38, 25);
            this.lbl_id.TabIndex = 29;
            this.lbl_id.Text = "Id:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(879, 95);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 22);
            this.txt_id.TabIndex = 30;
            // 
            // txt_dispon
            // 
            this.txt_dispon.Location = new System.Drawing.Point(879, 175);
            this.txt_dispon.Name = "txt_dispon";
            this.txt_dispon.Size = new System.Drawing.Size(123, 22);
            this.txt_dispon.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(724, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Disponibilidad:";
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 552);
            this.Controls.Add(this.txt_dispon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.txt_editorial);
            this.Controls.Add(this.lbl_nombrelibro);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.lbl_autor);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dgr_libros);
            this.Controls.Add(this.btn_agregar);
            this.Name = "Libros";
            this.Text = "Libros";
            ((System.ComponentModel.ISupportInitialize)(this.dgr_libros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgr_libros;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_editorial;
        private System.Windows.Forms.Label lbl_nombrelibro;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Label lbl_autor;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_dispon;
        private System.Windows.Forms.Label label1;
    }
}