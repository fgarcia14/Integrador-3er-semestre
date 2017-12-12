using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_integrador
{
    public partial class frmACartaCons : Form
    {
        public frmACartaCons()
        {
            InitializeComponent();
        }
        String ruta;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmAñadir añadir = new frmAñadir(ruta);
            this.Hide();
            añadir.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivos JPG|*.jpg*";
            if (file.ShowDialog()==DialogResult.OK)
            {
                ruta = file.FileName;
                txtRuta.Text = file.FileName;
                btnGuardar.Enabled = true;
            }
        }
    }
}
