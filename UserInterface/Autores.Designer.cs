namespace UserInterface
{
    partial class Autores
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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgr_autores = new System.Windows.Forms.DataGridView();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_nombrelibro = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_autores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(13, 13);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(167, 44);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar Autor";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.bttn_addAutor_Click);
            // 
            // dgr_autores
            // 
            this.dgr_autores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_autores.Location = new System.Drawing.Point(13, 63);
            this.dgr_autores.Name = "dgr_autores";
            this.dgr_autores.RowHeadersWidth = 51;
            this.dgr_autores.RowTemplate.Height = 24;
            this.dgr_autores.Size = new System.Drawing.Size(691, 375);
            this.dgr_autores.TabIndex = 1;
            this.dgr_autores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_autores_CellContentClick);
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(925, 152);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(123, 22);
            this.txt_apellidos.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(770, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Apellidos:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(925, 72);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 22);
            this.txt_id.TabIndex = 42;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(770, 69);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(38, 25);
            this.lbl_id.TabIndex = 41;
            this.lbl_id.Text = "Id:";
            // 
            // lbl_nombrelibro
            // 
            this.lbl_nombrelibro.AutoSize = true;
            this.lbl_nombrelibro.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombrelibro.Location = new System.Drawing.Point(770, 112);
            this.lbl_nombrelibro.Name = "lbl_nombrelibro";
            this.lbl_nombrelibro.Size = new System.Drawing.Size(83, 25);
            this.lbl_nombrelibro.TabIndex = 38;
            this.lbl_nombrelibro.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(927, 112);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 22);
            this.txt_nombre.TabIndex = 37;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(939, 371);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(160, 44);
            this.btn_delete.TabIndex = 34;
            this.btn_delete.Text = "Eliminar Autor";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(773, 371);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(160, 44);
            this.btn_edit.TabIndex = 33;
            this.btn_edit.Text = "Editar Autor";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // Autores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 465);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_nombrelibro);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dgr_autores);
            this.Controls.Add(this.btn_agregar);
            this.Name = "Autores";
            this.Text = "Autores";
            ((System.ComponentModel.ISupportInitialize)(this.dgr_autores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgr_autores;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_nombrelibro;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
    }
}