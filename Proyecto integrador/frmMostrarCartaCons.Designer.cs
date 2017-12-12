namespace Proyecto_integrador
{
    partial class frmMostrarCartaCons
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
            this.pbxCarta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarta)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCarta
            // 
            this.pbxCarta.Location = new System.Drawing.Point(0, 0);
            this.pbxCarta.Name = "pbxCarta";
            this.pbxCarta.Size = new System.Drawing.Size(583, 760);
            this.pbxCarta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCarta.TabIndex = 0;
            this.pbxCarta.TabStop = false;
            // 
            // frmMostrarCartaCons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.pbxCarta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrarCartaCons";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCarta;
    }
}