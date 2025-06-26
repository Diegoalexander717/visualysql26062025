namespace vistas.Formulario
{
    partial class frmdoctor
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
            this.dgvDatosDoctores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDoctores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosDoctores
            // 
            this.dgvDatosDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosDoctores.Location = new System.Drawing.Point(3, 30);
            this.dgvDatosDoctores.Name = "dgvDatosDoctores";
            this.dgvDatosDoctores.Size = new System.Drawing.Size(772, 383);
            this.dgvDatosDoctores.TabIndex = 0;
            // 
            // frmdoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDatosDoctores);
            this.Name = "frmdoctor";
            this.Text = "frmdoctor";
            this.Load += new System.EventHandler(this.frmdoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDoctores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosDoctores;
    }
}