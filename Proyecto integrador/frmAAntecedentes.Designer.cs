namespace Proyecto_integrador
{
    partial class frmAAntecedentes
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
            this.components = new System.ComponentModel.Container();
            this.lblAntFamiliares = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ttpIndicacion = new System.Windows.Forms.ToolTip(this.components);
            this.lblAyuda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAntFamiliares
            // 
            this.lblAntFamiliares.AutoSize = true;
            this.lblAntFamiliares.Location = new System.Drawing.Point(8, 32);
            this.lblAntFamiliares.Name = "lblAntFamiliares";
            this.lblAntFamiliares.Size = new System.Drawing.Size(215, 24);
            this.lblAntFamiliares.TabIndex = 0;
            this.lblAntFamiliares.Text = "Antecendetes familiares:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 319);
            this.textBox1.TabIndex = 1;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Location = new System.Drawing.Point(309, 32);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(20, 24);
            this.lblAyuda.TabIndex = 2;
            this.lblAyuda.Text = "?";
            this.ttpIndicacion.SetToolTip(this.lblAyuda, "Se refiere a los antecedentes de enfermedades crónicas y degenerativas en primero" +
        " y segundo orden de los familiares consanguíneos del paciente.");
            // 
            // frmAAntecedentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 424);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAntFamiliares);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAAntecedentes";
            this.Text = "Datos clinicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAntFamiliares;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip ttpIndicacion;
        private System.Windows.Forms.Label lblAyuda;
    }
}