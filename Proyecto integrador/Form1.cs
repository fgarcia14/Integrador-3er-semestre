using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_integrador
{
    public partial class frmMenu : Form
    {
        
        public frmMenu(bool ban=true)
        {
            
            InitializeComponent();
            frmLogin login = new frmLogin();
            if (ban)
            {

                login.ShowDialog();
                ban = false;
            }
            
        }

        private void btnBuscarExp_Click(object sender, EventArgs e)
        {
            frmBuscar Buscar = new frmBuscar();
            this.Hide();
            Buscar.ShowDialog();
            this.Show();
        }

        private void btnAgregarExp_Click(object sender, EventArgs e)
        {
            frmACartaCons Agregar = new frmACartaCons();
            this.Hide();
            Agregar.ShowDialog();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            frmAgenda agenda = new frmAgenda();
            this.Hide();
            agenda.ShowDialog();
            this.Show();
        }

        private void btnGestiones_Click(object sender, EventArgs e)
        {
            _frmContabilidad contabilidad = new _frmContabilidad();
            this.Hide();
            contabilidad.ShowDialog();
            this.Show();
        }


        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
