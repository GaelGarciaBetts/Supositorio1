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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bttn_prestamos_Click(object sender, EventArgs e)
        {
            Prestamos frmPrestamos = new Prestamos();
            frmPrestamos.ShowDialog();
        }

        private void bttn_altas_Click(object sender, EventArgs e)
        {
            Autores frmAutores = new Autores();
            frmAutores.ShowDialog();
        }

        private void bttn_libros_Click(object sender, EventArgs e)
        {
            Libros frmLibros = new Libros();
            frmLibros.ShowDialog();
        }

        private void bttn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
