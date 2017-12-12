namespace Proyecto_integrador
{
    partial class frmAgenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mcrCalendario = new System.Windows.Forms.MonthCalendar();
            this.lblCitas = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.gbxAñadir = new System.Windows.Forms.GroupBox();
            this.lblAFecha = new System.Windows.Forms.Label();
            this.cbxDia = new System.Windows.Forms.ComboBox();
            this.cbxAño = new System.Windows.Forms.ComboBox();
            this.cbxMes = new System.Windows.Forms.ComboBox();
            this.lblAHora = new System.Windows.Forms.Label();
            this.cbxHora = new System.Windows.Forms.ComboBox();
            this.cbxMinuts = new System.Windows.Forms.ComboBox();
            this.cbxParte = new System.Windows.Forms.ComboBox();
            this.lblAPaciente = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.gbxAñadir.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcrCalendario
            // 
            this.mcrCalendario.Location = new System.Drawing.Point(18, 54);
            this.mcrCalendario.Name = "mcrCalendario";
            this.mcrCalendario.TabIndex = 0;
            // 
            // lblCitas
            // 
            this.lblCitas.AutoSize = true;
            this.lblCitas.Location = new System.Drawing.Point(288, 54);
            this.lblCitas.Name = "lblCitas";
            this.lblCitas.Size = new System.Drawing.Size(135, 24);
            this.lblCitas.TabIndex = 1;
            this.lblCitas.Text = "Proximas citas:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(288, 95);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 24);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(288, 144);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(56, 24);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(288, 192);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(88, 24);
            this.lblPaciente.TabIndex = 4;
            this.lblPaciente.Text = "Paciente:";
            // 
            // gbxAñadir
            // 
            this.gbxAñadir.Controls.Add(this.txtPaciente);
            this.gbxAñadir.Controls.Add(this.lblAPaciente);
            this.gbxAñadir.Controls.Add(this.cbxParte);
            this.gbxAñadir.Controls.Add(this.cbxMinuts);
            this.gbxAñadir.Controls.Add(this.cbxHora);
            this.gbxAñadir.Controls.Add(this.lblAHora);
            this.gbxAñadir.Controls.Add(this.cbxMes);
            this.gbxAñadir.Controls.Add(this.cbxAño);
            this.gbxAñadir.Controls.Add(this.cbxDia);
            this.gbxAñadir.Controls.Add(this.lblAFecha);
            this.gbxAñadir.Location = new System.Drawing.Point(18, 248);
            this.gbxAñadir.Name = "gbxAñadir";
            this.gbxAñadir.Size = new System.Drawing.Size(517, 204);
            this.gbxAñadir.TabIndex = 5;
            this.gbxAñadir.TabStop = false;
            this.gbxAñadir.Text = "Agregar cita";
            // 
            // lblAFecha
            // 
            this.lblAFecha.AutoSize = true;
            this.lblAFecha.Location = new System.Drawing.Point(30, 45);
            this.lblAFecha.Name = "lblAFecha";
            this.lblAFecha.Size = new System.Drawing.Size(69, 24);
            this.lblAFecha.TabIndex = 0;
            this.lblAFecha.Text = "Fecha:";
            // 
            // cbxDia
            // 
            this.cbxDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDia.FormattingEnabled = true;
            this.cbxDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxDia.Location = new System.Drawing.Point(105, 37);
            this.cbxDia.Name = "cbxDia";
            this.cbxDia.Size = new System.Drawing.Size(54, 32);
            this.cbxDia.TabIndex = 1;
            // 
            // cbxAño
            // 
            this.cbxAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAño.FormattingEnabled = true;
            this.cbxAño.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxAño.Location = new System.Drawing.Point(225, 37);
            this.cbxAño.Name = "cbxAño";
            this.cbxAño.Size = new System.Drawing.Size(81, 32);
            this.cbxAño.TabIndex = 2;
            // 
            // cbxMes
            // 
            this.cbxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMes.FormattingEnabled = true;
            this.cbxMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxMes.Location = new System.Drawing.Point(165, 37);
            this.cbxMes.Name = "cbxMes";
            this.cbxMes.Size = new System.Drawing.Size(54, 32);
            this.cbxMes.TabIndex = 3;
            // 
            // lblAHora
            // 
            this.lblAHora.AutoSize = true;
            this.lblAHora.Location = new System.Drawing.Point(41, 97);
            this.lblAHora.Name = "lblAHora";
            this.lblAHora.Size = new System.Drawing.Size(136, 24);
            this.lblAHora.TabIndex = 4;
            this.lblAHora.Text = "Hora:               :";
            // 
            // cbxHora
            // 
            this.cbxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHora.FormattingEnabled = true;
            this.cbxHora.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxHora.Location = new System.Drawing.Point(105, 94);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(54, 32);
            this.cbxHora.TabIndex = 5;
            // 
            // cbxMinuts
            // 
            this.cbxMinuts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinuts.FormattingEnabled = true;
            this.cbxMinuts.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbxMinuts.Location = new System.Drawing.Point(183, 94);
            this.cbxMinuts.Name = "cbxMinuts";
            this.cbxMinuts.Size = new System.Drawing.Size(54, 32);
            this.cbxMinuts.TabIndex = 6;
            // 
            // cbxParte
            // 
            this.cbxParte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParte.FormattingEnabled = true;
            this.cbxParte.Items.AddRange(new object[] {
            "a. m.",
            "p. m."});
            this.cbxParte.Location = new System.Drawing.Point(252, 94);
            this.cbxParte.Name = "cbxParte";
            this.cbxParte.Size = new System.Drawing.Size(54, 32);
            this.cbxParte.TabIndex = 7;
            // 
            // lblAPaciente
            // 
            this.lblAPaciente.AutoSize = true;
            this.lblAPaciente.Location = new System.Drawing.Point(11, 141);
            this.lblAPaciente.Name = "lblAPaciente";
            this.lblAPaciente.Size = new System.Drawing.Size(88, 24);
            this.lblAPaciente.TabIndex = 8;
            this.lblAPaciente.Text = "Paciente:";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(105, 141);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(369, 29);
            this.txtPaciente.TabIndex = 9;
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 482);
            this.Controls.Add(this.gbxAñadir);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCitas);
            this.Controls.Add(this.mcrCalendario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAgenda";
            this.Text = "Agenda";
            this.gbxAñadir.ResumeLayout(false);
            this.gbxAñadir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcrCalendario;
        private System.Windows.Forms.Label lblCitas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.GroupBox gbxAñadir;
        private System.Windows.Forms.ComboBox cbxDia;
        private System.Windows.Forms.Label lblAFecha;
        private System.Windows.Forms.ComboBox cbxMes;
        private System.Windows.Forms.ComboBox cbxAño;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblAPaciente;
        private System.Windows.Forms.ComboBox cbxParte;
        private System.Windows.Forms.ComboBox cbxMinuts;
        private System.Windows.Forms.ComboBox cbxHora;
        private System.Windows.Forms.Label lblAHora;
    }
}