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
    public partial class Autores : Form
    {
        public Autores()
        {
            InitializeComponent();
            loadInformacion();
        }

        private void loadInformacion()
        {
            dgr_autores.DataSource = BL_Autor.Get();
        }

        private void bttn_addAutor_Click(object sender, EventArgs e)
        {
            AddAutor frmAddAutor = new AddAutor();
            frmAddAutor.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                BL_Autor.InsertOrUpdate(Convert.ToInt32(txt_id.Text), txt_nombre.Text, txt_apellidos.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el elemento a EDITAR", "Alerta");
            }
        }

        private void dgr_autores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_agregar.Enabled = false;

            DataGridViewRow selectedRow = dgr_autores.Rows[e.RowIndex];

            if (selectedRow != null)
            {
                txt_id.Text = selectedRow.Cells["IDAutor"].Value.ToString();
                txt_nombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txt_apellidos.Text = selectedRow.Cells["Apellidos"].Value.ToString();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                BL_Autor.Delete(Convert.ToInt32(txt_id.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el elemento a ELIMINAR", "Alerta");
            }
        }
    }
}
