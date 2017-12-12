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
    public partial class frmMostrarCartaCons : Form
    {
        public frmMostrarCartaCons(int ID)
        {
            InitializeComponent();
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Proyecto integrador;Integrated Security=True");
            SqlCommand Instrucción = new SqlCommand("SELECT * FROM DatosGenerales WHERE Id="+ID, Conexion);
            Conexion.Open();
            SqlDataReader Lector = Instrucción.ExecuteReader();
            Lector.Read();
            System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])Lector["Carta Consentimiento"]);
            pbxCarta.Image = Image.FromStream(ms);
            Conexion.Close();
        }
    }
}
