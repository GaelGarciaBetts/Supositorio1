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
    public partial class ConsultarPrestamos : Form
    {
        public ConsultarPrestamos()
        {
            InitializeComponent();
            loadInformacion();
        }

        private void loadInformacion()
        {
            dgr_prestamos.DataSource = BL_Prestamo.Get();
        }

        private void dgr_prestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgr_prestamos.Rows[e.RowIndex];

            if (selectedRow != null)
            {
                txt_id.Text = selectedRow.Cells["IDPrestamo"].Value.ToString();
                txt_nombre.Text = selectedRow.Cells["NombrePersona"].Value.ToString();
                txt_libro.Text = selectedRow.Cells["IDLibro"].Value.ToString();
                dt_inicio.Value = (DateTime) selectedRow.Cells["FechaPrestamoInicio"].Value;
                dt_fin.Value = (DateTime) selectedRow.Cells["FechaPrestamoInicio"].Value;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {

                BL_Prestamo.InsertOrUpdate(Convert.ToInt32(txt_id.Text), txt_nombre.Text, Convert.ToInt32(txt_libro), dt_inicio.Value, dt_fin.Value);
            }
            catch
            {
                MessageBox.Show("Selecione el elemento a editar", "Alerta");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                BL_Prestamo.Delete(Convert.ToInt32(txt_id.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el elemento a ELEMINAR", "Alerta");
            }
        }
    }
}
