namespace Proyecto_integrador
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnBuscarExp = new System.Windows.Forms.Button();
            this.btnGestiones = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.gpbExpedientes = new System.Windows.Forms.GroupBox();
            this.btnAgregarExp = new System.Windows.Forms.Button();
            this.gpbConsultorio = new System.Windows.Forms.GroupBox();
            this.sstPrincipal = new System.Windows.Forms.StatusStrip();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gpbExpedientes.SuspendLayout();
            this.gpbConsultorio.SuspendLayout();
            this.sstPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(221, 27);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(135, 24);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu principal";
            // 
            // btnBuscarExp
            // 
            this.btnBuscarExp.Location = new System.Drawing.Point(6, 42);
            this.btnBuscarExp.Name = "btnBuscarExp";
            this.btnBuscarExp.Size = new System.Drawing.Size(240, 36);
            this.btnBuscarExp.TabIndex = 1;
            this.btnBuscarExp.Text = "Buscar";
            this.btnBuscarExp.UseVisualStyleBackColor = true;
            this.btnBuscarExp.Click += new System.EventHandler(this.btnBuscarExp_Click);
            // 
            // btnGestiones
            // 
            this.btnGestiones.Location = new System.Drawing.Point(6, 92);
            this.btnGestiones.Name = "btnGestiones";
            this.btnGestiones.Size = new System.Drawing.Size(246, 40);
            this.btnGestiones.TabIndex = 2;
            this.btnGestiones.Text = "Gestiones Financieras";
            this.btnGestiones.UseVisualStyleBackColor = true;
            this.btnGestiones.Click += new System.EventHandler(this.btnGestiones_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.Location = new System.Drawing.Point(6, 42);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(246, 36);
            this.btnAgenda.TabIndex = 3;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(225, 244);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(135, 30);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Salir";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // gpbExpedientes
            // 
            this.gpbExpedientes.Controls.Add(this.btnAgregarExp);
            this.gpbExpedientes.Controls.Add(this.btnBuscarExp);
            this.gpbExpedientes.Location = new System.Drawing.Point(21, 81);
            this.gpbExpedientes.Name = "gpbExpedientes";
            this.gpbExpedientes.Size = new System.Drawing.Size(256, 138);
            this.gpbExpedientes.TabIndex = 5;
            this.gpbExpedientes.TabStop = false;
            this.gpbExpedientes.Text = "Expedientes";
            // 
            // btnAgregarExp
            // 
            this.btnAgregarExp.Location = new System.Drawing.Point(6, 92);
            this.btnAgregarExp.Name = "btnAgregarExp";
            this.btnAgregarExp.Size = new System.Drawing.Size(240, 40);
            this.btnAgregarExp.TabIndex = 2;
            this.btnAgregarExp.Text = "Agregar";
            this.btnAgregarExp.UseVisualStyleBackColor = true;
            this.btnAgregarExp.Click += new System.EventHandler(this.btnAgregarExp_Click);
            // 
            // gpbConsultorio
            // 
            this.gpbConsultorio.Controls.Add(this.btnGestiones);
            this.gpbConsultorio.Controls.Add(this.btnAgenda);
            this.gpbConsultorio.Location = new System.Drawing.Point(314, 81);
            this.gpbConsultorio.Name = "gpbConsultorio";
            this.gpbConsultorio.Size = new System.Drawing.Size(261, 138);
            this.gpbConsultorio.TabIndex = 6;
            this.gpbConsultorio.TabStop = false;
            this.gpbConsultorio.Text = "Consultorio";
            // 
            // sstPrincipal
            // 
            this.sstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHora});
            this.sstPrincipal.Location = new System.Drawing.Point(0, 285);
            this.sstPrincipal.Name = "sstPrincipal";
            this.sstPrincipal.Size = new System.Drawing.Size(592, 22);
            this.sstPrincipal.TabIndex = 7;
            this.sstPrincipal.Text = "statusStrip1";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 307);
            this.Controls.Add(this.sstPrincipal);
            this.Controls.Add(this.gpbConsultorio);
            this.Controls.Add(this.gpbExpedientes);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.gpbExpedientes.ResumeLayout(false);
            this.gpbConsultorio.ResumeLayout(false);
            this.sstPrincipal.ResumeLayout(false);
            this.sstPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnBuscarExp;
        private System.Windows.Forms.Button btnGestiones;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.GroupBox gpbExpedientes;
        private System.Windows.Forms.Button btnAgregarExp;
        private System.Windows.Forms.GroupBox gpbConsultorio;
        private System.Windows.Forms.StatusStrip sstPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}

