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
    public partial class AddAutor : Form
    {
        public AddAutor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BL_Autor.InsertOrUpdate(0, txt_nombre.Text, txt_apellido.Text);
                MessageBox.Show("Autor Agregado Correctamente", "Exito");
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
            txt_apellido.Text = "";
        }
    }
}
