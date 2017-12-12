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
using System.IO;

namespace Proyecto_integrador
{
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }
        int ID;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Proyecto integrador;Integrated Security=True");
            SqlCommand Instruccion = new SqlCommand("SELECT * FROM DatosGenerales", Conexion);
            Conexion.Open();
            SqlDataReader lector = Instruccion.ExecuteReader();
            bool ban = true;
            
            while (lector.Read()) {              
                if (lector["Apellido paterno"].ToString()==txtAP.Text && lector["Apellido materno"].ToString()==txtAM.Text && lector["Nombres"].ToString()==txtNombres.Text)
                {
                    ID = Convert.ToInt32(lector["Id"]);
                    txtMAP.Text = lector["Apellido paterno"].ToString();
                    txtMAM.Text = lector["Apellido materno"].ToString();
                    txtMNombres.Text = lector["Nombres"].ToString();
                    txtFechaNac.Text = lector["Fecha de nacimiento"].ToString();
                    txtLugarNac.Text = lector["Lugar de nacimiento"].ToString();
                    // txtSexo.Text = lector["Sexo"].ToString();
                    if (lector["Sexo"].ToString() == "M")
                    {
                        txtSexo.Text = "Masculino";
                    }
                    else txtSexo.Text = "Femenino";
                    txtTutor.Text = lector["Tutor"].ToString();
                    txtTelefono.Text = lector["Telefono de contacto"].ToString();
                    System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])lector["Foto"]);
                    pbxFoto.Image = Image.FromStream(ms);
                    ban = false;
                    Conexion.Close();
                    Cursor = Cursors.Default;
                    btnCarta.Enabled = true;
                    btnMostrar.Enabled = true;
                    break;
                } 
            }
            if (ban)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("No se encontro registro, verifique si la informacion es correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            frmMostrarCartaCons mostrarCarta = new frmMostrarCartaCons(ID);
            mostrarCarta.ShowDialog();
        }
    }
}
