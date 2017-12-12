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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Proyecto integrador;Integrated Security=True");
            SqlCommand Instruccion = new SqlCommand("SELECT * FROM Login", Conexion);
            Conexion.Open();
            SqlDataReader lector = Instruccion.ExecuteReader();
            bool ban = true;
            while (lector.Read()) 
            {
                if (txtUsuario.Text==lector["Usuario"].ToString() && txtContraseña.Text==lector["Contraseña"].ToString())
                {
                    ban = false;
                    MessageBox.Show("Usuario aceptado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    frmMenu menu = new frmMenu(false);
                    this.Hide();
                    menu.ShowDialog();
                    break;
                }
            }

            if (ban)
            {
                MessageBox.Show("Usuario o contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
