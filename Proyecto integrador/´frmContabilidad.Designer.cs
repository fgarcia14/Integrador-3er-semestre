namespace Proyecto_integrador
{
    partial class _frmContabilidad
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpbIngresos = new System.Windows.Forms.GroupBox();
            this.gpbEgresos = new System.Windows.Forms.GroupBox();
            this.btnGuardarIngresosyEgresos = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TabContabilidad = new System.Windows.Forms.TabControl();
            this.tabIngEgr = new System.Windows.Forms.TabPage();
            this.dgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbIngresos.SuspendLayout();
            this.gpbEgresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.TabContabilidad.SuspendLayout();
            this.tabIngEgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFecha,
            this.dgvImporte});
            this.dataGridView1.Location = new System.Drawing.Point(6, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // gpbIngresos
            // 
            this.gpbIngresos.Controls.Add(this.dataGridView1);
            this.gpbIngresos.Location = new System.Drawing.Point(16, 8);
            this.gpbIngresos.Name = "gpbIngresos";
            this.gpbIngresos.Size = new System.Drawing.Size(363, 433);
            this.gpbIngresos.TabIndex = 1;
            this.gpbIngresos.TabStop = false;
            this.gpbIngresos.Text = "Ingresos";
            // 
            // gpbEgresos
            // 
            this.gpbEgresos.Controls.Add(this.btnGuardarIngresosyEgresos);
            this.gpbEgresos.Controls.Add(this.dataGridView2);
            this.gpbEgresos.Location = new System.Drawing.Point(401, 12);
            this.gpbEgresos.Name = "gpbEgresos";
            this.gpbEgresos.Size = new System.Drawing.Size(399, 429);
            this.gpbEgresos.TabIndex = 2;
            this.gpbEgresos.TabStop = false;
            this.gpbEgresos.Text = "Egresos";
            // 
            // btnGuardarIngresosyEgresos
            // 
            this.btnGuardarIngresosyEgresos.Location = new System.Drawing.Point(241, 378);
            this.btnGuardarIngresosyEgresos.Name = "btnGuardarIngresosyEgresos";
            this.btnGuardarIngresosyEgresos.Size = new System.Drawing.Size(108, 47);
            this.btnGuardarIngresosyEgresos.TabIndex = 5;
            this.btnGuardarIngresosyEgresos.Text = "Guardar";
            this.btnGuardarIngresosyEgresos.UseVisualStyleBackColor = true;
            this.btnGuardarIngresosyEgresos.Click += new System.EventHandler(this.btnGuardar2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(6, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(343, 331);
            this.dataGridView2.TabIndex = 0;
            // 
            // TabContabilidad
            // 
            this.TabContabilidad.Controls.Add(this.tabIngEgr);
            this.TabContabilidad.Location = new System.Drawing.Point(12, 12);
            this.TabContabilidad.Name = "TabContabilidad";
            this.TabContabilidad.SelectedIndex = 0;
            this.TabContabilidad.Size = new System.Drawing.Size(811, 484);
            this.TabContabilidad.TabIndex = 3;
            // 
            // tabIngEgr
            // 
            this.tabIngEgr.Controls.Add(this.gpbIngresos);
            this.tabIngEgr.Controls.Add(this.gpbEgresos);
            this.tabIngEgr.Location = new System.Drawing.Point(4, 33);
            this.tabIngEgr.Name = "tabIngEgr";
            this.tabIngEgr.Padding = new System.Windows.Forms.Padding(3);
            this.tabIngEgr.Size = new System.Drawing.Size(803, 447);
            this.tabIngEgr.TabIndex = 0;
            this.tabIngEgr.Text = "Ingresos y egresos";
            this.tabIngEgr.UseVisualStyleBackColor = true;
            // 
            // dgvFecha
            // 
            this.dgvFecha.HeaderText = "Fecha";
            this.dgvFecha.Name = "dgvFecha";
            // 
            // dgvImporte
            // 
            this.dgvImporte.HeaderText = "Importe";
            this.dgvImporte.Name = "dgvImporte";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Importe";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // _frmContabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 499);
            this.Controls.Add(this.TabContabilidad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "_frmContabilidad";
            this.Text = "Contabilidad";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbIngresos.ResumeLayout(false);
            this.gpbEgresos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.TabContabilidad.ResumeLayout(false);
            this.tabIngEgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpbIngresos;
        private System.Windows.Forms.GroupBox gpbEgresos;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabControl TabContabilidad;
        private System.Windows.Forms.TabPage tabIngEgr;
        private System.Windows.Forms.Button btnGuardarIngresosyEgresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}