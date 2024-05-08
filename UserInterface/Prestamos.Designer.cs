namespace UserInterface
{
    partial class Prestamos
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
            this.bttn_consul = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_libro = new System.Windows.Forms.ComboBox();
            this.dte_limite = new System.Windows.Forms.DateTimePicker();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dte_inicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_consul
            // 
            this.bttn_consul.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_consul.Location = new System.Drawing.Point(652, 12);
            this.bttn_consul.Name = "bttn_consul";
            this.bttn_consul.Size = new System.Drawing.Size(136, 62);
            this.bttn_consul.TabIndex = 0;
            this.bttn_consul.Text = "Consultar préstamo";
            this.bttn_consul.UseVisualStyleBackColor = true;
            this.bttn_consul.Click += new System.EventHandler(this.bttn_consul_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(354, 103);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre.TabIndex = 1;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(197, 103);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(83, 25);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Libro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha límite:";
            // 
            // cbo_libro
            // 
            this.cbo_libro.FormattingEnabled = true;
            this.cbo_libro.Location = new System.Drawing.Point(354, 147);
            this.cbo_libro.Name = "cbo_libro";
            this.cbo_libro.Size = new System.Drawing.Size(121, 24);
            this.cbo_libro.TabIndex = 7;
            // 
            // dte_limite
            // 
            this.dte_limite.Location = new System.Drawing.Point(354, 242);
            this.dte_limite.Name = "dte_limite";
            this.dte_limite.Size = new System.Drawing.Size(254, 22);
            this.dte_limite.TabIndex = 8;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(538, 333);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(150, 38);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.Text = "Solicitar Prestamo";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dte_inicio
            // 
            this.dte_inicio.Location = new System.Drawing.Point(354, 193);
            this.dte_inicio.Name = "dte_inicio";
            this.dte_inicio.Size = new System.Drawing.Size(254, 22);
            this.dte_inicio.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha Inicio:";
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 459);
            this.Controls.Add(this.dte_inicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dte_limite);
            this.Controls.Add(this.cbo_libro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.bttn_consul);
            this.Name = "Prestamos";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_consul;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_libro;
        private System.Windows.Forms.DateTimePicker dte_limite;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DateTimePicker dte_inicio;
        private System.Windows.Forms.Label label1;
    }
}