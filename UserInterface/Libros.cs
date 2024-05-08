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
    public partial class Libros : Form
    {
        BL_LIBRO bl_libro;
        public Libros()
        {
            InitializeComponent();
            bl_libro = new BL_LIBRO();
            loadInformacion();
        }

        private void loadInformacion()
        {
            dgr_libros.DataSource = BL_LIBRO.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddLibro frmAddLibro = new AddLibro();
            frmAddLibro.ShowDialog();
        }

        private void dgr_libros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_agregar.Enabled = false;

            DataGridViewRow selectedRow = dgr_libros.Rows[e.RowIndex];

            if (selectedRow != null)
            {
                txt_id.Text = selectedRow.Cells["ID_Libro"].Value.ToString();
                txt_nombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txt_dispon.Text = selectedRow.Cells["Disponibilidad"].Value.ToString();
                txt_autor.Text = selectedRow.Cells["IDAutor"].Value.ToString();
                txt_editorial.Text = selectedRow.Cells["Editorial"].Value.ToString();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                BL_LIBRO.InsertOrUpdate(Convert.ToInt32(txt_id.Text), txt_nombre.Text, Convert.ToInt32(txt_dispon), Convert.ToInt32(txt_autor), txt_editorial.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el elemento a EDITAR", "Alerta");
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
