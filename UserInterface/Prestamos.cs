using BsnLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bttn_consul_Click(object sender, EventArgs e)
        {
            ConsultarPrestamos frmConsultarPrestamos = new ConsultarPrestamos();
            frmConsultarPrestamos.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                var libroSelected = (DO_Libro) cbo_libro.SelectedItem;
                BL_Prestamo.InsertOrUpdate(0, txt_nombre.Text, libroSelected.idLibro, dte_inicio.Value, dte_limite.Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese los datos corretamente", "Alerta");
            }
        }
    }
}
