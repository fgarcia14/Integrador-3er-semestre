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
    public partial class frmADatosGen : Form
    {
        public frmADatosGen()
        {
            InitializeComponent();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmAAntecedentes Antecendetes = new frmAAntecedentes();
            Antecendetes.ShowDialog();
        }
    }
}
