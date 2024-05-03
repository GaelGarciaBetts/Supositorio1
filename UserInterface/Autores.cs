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
        }

        private void bttn_addAutor_Click(object sender, EventArgs e)
        {
            AddAutor frmAddAutor = new AddAutor();
            frmAddAutor.ShowDialog();
        }
    }
}
