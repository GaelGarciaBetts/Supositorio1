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
    }
}
