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
    public partial class AddLibro : Form
    {
        BL_LIBRO bL_LIBRO;
        public AddLibro()
        {
            InitializeComponent();
            bL_LIBRO = new BL_LIBRO();
            loadInformacion();
        }

        private void loadInformacion()
        {
            cbo_autor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_autor.DataSource = BL_Autor.Get();
            cbo_autor.DisplayMember = "Nombre";
            cbo_autor.Text = "Seleccione una opcion";
        }

        private void AddLibro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var autorSelected = (DO_Autor) cbo_autor.SelectedItem;
                BL_LIBRO.InsertOrUpdate(0, txt_nombre.Text, 1, autorSelected.idAutor, txt_editorial.Text);
                MessageBox.Show("Libro Agregado Correctamente", "Exito");
                limpiarInformacion();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese los Datos correctos", "ALERTA");
            }
        }

        private void limpiarInformacion()
        {
            txt_nombre.Text = "";
            txt_editorial.Text = "";
            cbo_autor.Text = "Seleccione una opcion";
        }
    }
}
