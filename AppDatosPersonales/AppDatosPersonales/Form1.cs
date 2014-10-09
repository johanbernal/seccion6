using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDatosPersonales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult= MessageBox.Show("seguro", "confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "";
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
