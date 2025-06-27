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
            this.gpbDatosDelDoctor = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEspexialidad = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtespecialidad = new System.Windows.Forms.TextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDoctores)).BeginInit();
            this.gpbDatosDelDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatosDoctores
            // 
            this.dgvDatosDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosDoctores.Location = new System.Drawing.Point(33, 225);
            this.dgvDatosDoctores.Name = "dgvDatosDoctores";
            this.dgvDatosDoctores.Size = new System.Drawing.Size(644, 196);
            this.dgvDatosDoctores.TabIndex = 0;
            // 
            // gpbDatosDelDoctor
            // 
            this.gpbDatosDelDoctor.Controls.Add(this.btnEliminar);
            this.gpbDatosDelDoctor.Controls.Add(this.btnAgregar);
            this.gpbDatosDelDoctor.Controls.Add(this.btnActualizar);
            this.gpbDatosDelDoctor.Controls.Add(this.txtcargo);
            this.gpbDatosDelDoctor.Controls.Add(this.txtespecialidad);
            this.gpbDatosDelDoctor.Controls.Add(this.txtapellido);
            this.gpbDatosDelDoctor.Controls.Add(this.txtnombre);
            this.gpbDatosDelDoctor.Controls.Add(this.lblCargo);
            this.gpbDatosDelDoctor.Controls.Add(this.lblEspexialidad);
            this.gpbDatosDelDoctor.Controls.Add(this.lblApellido);
            this.gpbDatosDelDoctor.Controls.Add(this.lblNombre);
            this.gpbDatosDelDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosDelDoctor.Location = new System.Drawing.Point(33, 12);
            this.gpbDatosDelDoctor.Name = "gpbDatosDelDoctor";
            this.gpbDatosDelDoctor.Size = new System.Drawing.Size(676, 207);
            this.gpbDatosDelDoctor.TabIndex = 1;
            this.gpbDatosDelDoctor.TabStop = false;
            this.gpbDatosDelDoctor.Text = "Datos Del Doctor";
            this.gpbDatosDelDoctor.Enter += new System.EventHandler(this.gpbDatosDelDoctor_Enter);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 88);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(72, 18);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblEspexialidad
            // 
            this.lblEspexialidad.AutoSize = true;
            this.lblEspexialidad.Location = new System.Drawing.Point(6, 123);
            this.lblEspexialidad.Name = "lblEspexialidad";
            this.lblEspexialidad.Size = new System.Drawing.Size(108, 18);
            this.lblEspexialidad.TabIndex = 4;
            this.lblEspexialidad.Text = "Especialidad:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(6, 160);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(59, 18);
            this.lblCargo.TabIndex = 5;
            this.lblCargo.Text = "Cargo:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(115, 47);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(311, 24);
            this.txtnombre.TabIndex = 6;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(115, 82);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(311, 24);
            this.txtapellido.TabIndex = 7;
            // 
            // txtespecialidad
            // 
            this.txtespecialidad.Location = new System.Drawing.Point(115, 120);
            this.txtespecialidad.Name = "txtespecialidad";
            this.txtespecialidad.Size = new System.Drawing.Size(311, 24);
            this.txtespecialidad.TabIndex = 8;
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(115, 157);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(311, 24);
            this.txtcargo.TabIndex = 9;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(558, 37);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 36);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(558, 88);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 37);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(558, 143);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 35);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmdoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbDatosDelDoctor);
            this.Controls.Add(this.dgvDatosDoctores);
            this.Name = "frmdoctor";
            this.Text = "frmdoctor";
            this.Load += new System.EventHandler(this.frmdoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDoctores)).EndInit();
            this.gpbDatosDelDoctor.ResumeLayout(false);
            this.gpbDatosDelDoctor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosDoctores;
        private System.Windows.Forms.GroupBox gpbDatosDelDoctor;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblEspexialidad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.TextBox txtespecialidad;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
    }
}