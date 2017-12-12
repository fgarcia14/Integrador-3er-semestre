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
    public partial class frmAñadir : Form
    {
        String carta;
        public frmAñadir(String carta)
        {
            InitializeComponent();
            this.carta = carta;
            pbxCarta.Image = Image.FromFile(carta);
        }


        private void btnGuardarDatosGenerales_Click(object sender, EventArgs e)
        {
            if (pbxFoto.Image == null || txtAP.Text == "" || txtAM.Text == "" || txtNombres.Text == "" || cbxDia.Text == "" || cbxMes.Text == "" || cbxAño.Text == "" || txtCalle.Text == "" || txtNumero.Text == "" || txtColonia.Text == "" || txtLocalidad.Text == "" || cbxEstado.Text == "" || txtCP.Text == "" || txtLugarNac.Text == "" || txtTutor.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pnlDatosGen.Enabled = false;
                tabAñadir.SelectedIndex = 1;
            }            
        }

        private void btnGuardarAntFamiliares_Click(object sender, EventArgs e)
        {
            if (txtEnfCronPrim.Text==""|| txtEnfCronSeg.Text=="" || txtEnfDegPrim.Text==""|| txtEnfDegSeg.Text=="")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                pnlAntFamiliares.Enabled = false;
                tabAñadir.SelectedIndex = 2;
            }
        }

        private void btnGuardarAntPerinetales_Click(object sender, EventArgs e)
        {
            if (txtEdad.Text==""||txtNoEmbarazo.Text==""||cbxRiesgo.Text==""||txtEnfermedades.Text==""||txtTratamientos.Text==""||txtTaxicomas.Text==""||txtConsPren.Text==""||cbxHemotipoMat.Text==""||cbxHemotipoPat.Text==""||cbxEdadGestacional.Text==""||cbxApgar.Text==""||txtPeso.Text==""||txtTalla.Text==""|| txtCefalico.Text==""||txtComplicaciones.Text==""||txtDetecciones.Text=="")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                pnlMadre.Enabled = false;
                pnlPaciente.Enabled = false;
                tabAñadir.SelectedIndex = 3;
            }
        }

        private void btnGuardarAntNoPatologicos_Click(object sender, EventArgs e)
        {
            if (txtAlimentacionInicial.Text==""||txtAblactacion.Text==""||txtAlimentacionActual.Text==""||txtHigiene.Text==""||txtDesteste.Text=="")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {              
                pnlAntNoPatologicos.Enabled = false;
                tabAñadir.SelectedIndex = 4;
            }
        }

        private void btnGuardarAntPatologicos_Click(object sender, EventArgs e)
        {
            if (txtEnfermedadesPrevias.Text==""||txtHospitalizaciones.Text==""||txtTraumatismos.Text==""||txtCirugias.Text==""||txtTratamientoAct.Text=="")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pnlAntPatologicos.Enabled = false;
                tabAñadir.SelectedIndex = 5;
            }
        }

        private void btnGuardarEvolucion_Click(object sender, EventArgs e)
        {
            if (pnlDatosGen.Enabled || pnlAntFamiliares.Enabled || pnlMadre.Enabled || pnlPaciente.Enabled || pnlAntNoPatologicos.Enabled || pnlAntPatologicos.Enabled || cbxSostenCefalico.Text == "" || cbxGateo.Text == "" || cbxDeambulacion.Text == "" || cbxEsfinteres.Text == "" || cbxSedestacion.Text == "" || cbxBipidestacion.Text == "" || cbxLenguaje.Text == "" || cbxDenticion.Text == "" || txtProblemasDes.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                //Datos generales
                SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Proyecto integrador;Integrated Security=True");
                SqlCommand Instruccion = new SqlCommand("INSERT INTO DatosGenerales VALUES(@Apellido_paterno,@Apellido_materno,@Nombres,@Sexo,@Fecha_de_nacimiento,@Lugar_de_nacimiento,@Calle, @Numero,@Colonia,@Localidad,@Estado,@Codigo_Postal,@Tutor,@Telefono_de_contacto,@Foto,@Carta_consentimiento)", Conexion);

                Instruccion.Parameters.AddWithValue("@Apellido_paterno", txtAP.Text);
                Instruccion.Parameters.AddWithValue("@Apellido_materno", txtAM.Text);
                Instruccion.Parameters.AddWithValue("@Nombres", txtNombres.Text);
                if (rdbMasculino.Checked)
                {
                    Instruccion.Parameters.AddWithValue("@Sexo", "M");
                }
                else Instruccion.Parameters.AddWithValue("@Sexo", "F");
                Instruccion.Parameters.AddWithValue("@Fecha_de_nacimiento", (cbxDia.Text + "/" + cbxMes.Text + "/" + cbxAño.Text));
                Instruccion.Parameters.AddWithValue("@Lugar_de_nacimiento", txtLugarNac.Text);
                Instruccion.Parameters.AddWithValue("@Calle", txtCalle.Text);
                Instruccion.Parameters.AddWithValue("@Numero", Convert.ToInt32(txtNumero.Text));
                Instruccion.Parameters.AddWithValue("@Colonia", txtColonia.Text);
                Instruccion.Parameters.AddWithValue("@Localidad", txtLocalidad.Text);
                Instruccion.Parameters.AddWithValue("@Estado", cbxEstado.Text);
                Instruccion.Parameters.AddWithValue("@Codigo_Postal", Convert.ToInt32(txtCP.Text));
                Instruccion.Parameters.AddWithValue("@Tutor", txtTutor.Text);
                Instruccion.Parameters.AddWithValue("@Telefono_de_contacto", Convert.ToInt64(txtTelefono.Text));
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pbxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                Instruccion.Parameters.Add("@Foto", SqlDbType.Image);
                Instruccion.Parameters["@Foto"].Value = ms.GetBuffer();
                ms = new System.IO.MemoryStream();
                pbxCarta.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                Instruccion.Parameters.Add("@Carta_Consentimiento", SqlDbType.Image);
                Instruccion.Parameters["@Carta_Consentimiento"].Value = ms.GetBuffer();
                Conexion.Open();
                Instruccion.ExecuteNonQuery();
                Conexion.Close();
                //Antecedentes familiares
                Instruccion = new SqlCommand("INSERT INTO AntecedentesFamiliares VALUES(@Enfermedades_cronicas_de_primer_grado, @Enfermedades_cronicas_de_segundo_grado, @Enfermedades_degenerativas_de_primer_grado, @Enfermedades_degenerativas_de_segundo_grado)", Conexion);
                Instruccion.Parameters.AddWithValue("@Enfermedades_cronicas_de_primer_grado", txtEnfCronPrim.Text);
                Instruccion.Parameters.AddWithValue("@Enfermedades_cronicas_de_segundo_grado", txtEnfCronSeg.Text);
                Instruccion.Parameters.AddWithValue("@Enfermedades_degenerativas_de_primer_grado", txtEnfDegPrim.Text);
                Instruccion.Parameters.AddWithValue("@Enfermedades_degenerativas_de_segundo_grado", txtEnfDegSeg.Text);
                Conexion.Open();
                Instruccion.ExecuteNonQuery();
                Conexion.Close();
                //Antecedentes perinatales de la madre
                Instruccion = new SqlCommand("INSERT INTO AntPerinetalesMadre VALUES(@Edad_embarazo, @Numero_embarazo,@Riesgo_durante_el_embarazo,@Enfermedades_durante_el_embarazo,@Tratamientos,@Taxicomas,@Hemotipo_paterno,@Hemotipo_materno,@Consultas_prenatales)", Conexion);
                Instruccion.Parameters.AddWithValue("@Edad_embarazo", Convert.ToInt32(txtEdad.Text));
                Instruccion.Parameters.AddWithValue("@Numero_embarazo", Convert.ToInt32(txtNoEmbarazo.Text));
                Instruccion.Parameters.AddWithValue("@Riesgo_durante_el_embarazo", cbxRiesgo.Text);
                Instruccion.Parameters.AddWithValue("@Enfermedades_durante_el_embarazo", txtEnfermedades.Text);
                Instruccion.Parameters.AddWithValue("@Tratamientos", txtTratamientos.Text);
                Instruccion.Parameters.AddWithValue("@Taxicomas", txtTaxicomas.Text);
                Instruccion.Parameters.AddWithValue("@Hemotipo_paterno", cbxHemotipoPat.Text);
                Instruccion.Parameters.AddWithValue("@Hemotipo_materno", cbxHemotipoMat.Text);
                Instruccion.Parameters.AddWithValue("@Consultas_prenatales", txtConsPren.Text);
                Conexion.Open();
                Instruccion.ExecuteNonQuery();
                Conexion.Close();
                //Antecedentes perinatales del paciente
                Instruccion = new SqlCommand("INSERT INTO AntPerinetalesPaciente VALUES(@Edad_gestacional_al_nacer, @Forma_de_nacimiento,@Evaluacion_de_apgar,@Peso_al_nacer,@Talla_al_nacer,@Perimetro_cefalico,@Complicaciones,@Detecciones_neonatales)", Conexion);
                Instruccion.Parameters.AddWithValue("@Edad_gestacional_al_nacer", cbxEdadGestacional.Text);
                if (rdbCesarea.Checked)
                {
                    Instruccion.Parameters.AddWithValue("@Forma_de_nacimiento", "Cesarea");
                }
                else Instruccion.Parameters.AddWithValue("@Forma_de_nacimiento", "Parto natural");
                Instruccion.Parameters.AddWithValue("@Evaluacion_de_apgar", Convert.ToInt32(cbxApgar.Text));
                Instruccion.Parameters.AddWithValue("@Peso_al_nacer", Convert.ToInt32(txtPeso.Text));
                Instruccion.Parameters.AddWithValue("@Talla_al_nacer", Convert.ToInt32(txtTalla.Text));
                Instruccion.Parameters.AddWithValue("@Perimetro_cefalico", Convert.ToInt32(txtCefalico.Text));
                Instruccion.Parameters.AddWithValue("@Complicaciones", txtComplicaciones.Text);
                Instruccion.Parameters.AddWithValue("@Detecciones_neonatales", txtDetecciones.Text);
                Conexion.Open();
                Instruccion.ExecuteNonQuery();
                Conexion.Close();
                //Antecedentes no patologicos
                 Instruccion = new SqlCommand("INSERT INTO AntNoPatologicos VALUES(@Alimentacion_inicial,@Ablactacion,@Alimentacion_actual,@Rutinas_de_higiene,@Desteste)", Conexion);
                Instruccion.Parameters.AddWithValue("@Alimentacion_inicial", txtAlimentacionInicial.Text);
                Instruccion.Parameters.AddWithValue("@Ablactacion", txtAblactacion.Text);
                Instruccion.Parameters.AddWithValue("@Alimentacion_actual", txtAlimentacionActual.Text);
                Instruccion.Parameters.AddWithValue("@Rutinas_de_higiene", txtHigiene.Text);
                Instruccion.Parameters.AddWithValue("@Desteste", txtDesteste.Text);
                Conexion.Open();
                Instruccion.ExecuteNonQuery();
                Conexion.Close();

                //Antecedentes Patologicos
                Instruccion = new SqlCommand("INSERT INTO AntPatologicos VALUES(@Enfermedades_previas,@Hospitalizaciones,@Traumatismos,@Transfusiones,@Cirugias,@Tratamiento_actual)", Conexion);
                Instruccion.Parameters.AddWithValue("@Enfermedades_previas", txtEnfermedadesPrevias.Text);
                Instruccion.Parameters.AddWithValue("@Hospitalizaciones", txtHospitalizaciones.Text);
                Instruccion.Parameters.AddWithValue("@Traumatismos", txtTraumatismos.Text);
                Instruccion.Parameters.AddWithValue("@Transfusiones", txtTransfusiones.Text);
                Instruccion.Parameters.AddWithValue("@Cirugias", txtCirugias.Text);
                Instruccion.Parameters.AddWithValue("@Tratamiento_actual", txtTratamientoAct.Text);
                Conexion.Open();
                Instruccion.ExecuteNonQuery();
                Conexion.Close();
                //Evolucion de desarrollo
                 Instruccion = new SqlCommand("INSERT INTO EvolucionDeDesarrollo VALUES(@Sosten_cefalico,@Sedestacion,@Gateo,@Bipidestacion,@Deambulacion,@Inicio_de_lenguaje,@Control_de_esfinteres,@Aparicion_de_denticion,@Problemas_de_desarollo)", Conexion);
                Instruccion.Parameters.AddWithValue("@Sosten_cefalico", cbxSostenCefalico.Text);
                Instruccion.Parameters.AddWithValue("@Sedestacion", cbxSedestacion.Text);
                Instruccion.Parameters.AddWithValue("@Gateo", cbxGateo.Text);
                Instruccion.Parameters.AddWithValue("@Bipidestacion", cbxBipidestacion.Text);
                Instruccion.Parameters.AddWithValue("@Deambulacion", cbxDeambulacion.Text);
                Instruccion.Parameters.AddWithValue("@Inicio_de_lenguaje", cbxLenguaje.Text);
                Instruccion.Parameters.AddWithValue("Control_de_esfinteres", cbxEsfinteres.Text);
                Instruccion.Parameters.AddWithValue("@Aparicion_de_denticion", cbxDenticion.Text);
                Instruccion.Parameters.AddWithValue("@Problemas_de_desarollo", txtProblemasDes.Text);
                Conexion.Open();
                Instruccion.ExecuteNonQuery();
                Conexion.Close();
                Cursor = Cursors.Default;
                MessageBox.Show("¡Registro exitoso!", "Terminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Close();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            foto.Filter = "Archivos JPG|*jpg*";
            if (foto.ShowDialog()==DialogResult.OK)
            {
                pbxFoto.Image = Image.FromFile(foto.FileName);
            }
        }

        private void txtAP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!(Char.IsLetter(e.KeyChar)) && !(Char.IsControl(e.KeyChar)) && !(Char.IsWhiteSpace(e.KeyChar))))
            {
                e.Handled = true; ;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!(Char.IsNumber(e.KeyChar)) && !(Char.IsControl(e.KeyChar))))
            {
                e.Handled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabAntPerinatales1.SelectedIndex = 1;
        }
    }
}
