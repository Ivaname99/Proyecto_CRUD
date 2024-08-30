namespace CapaVista
{
    partial class RegistroCliente
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
            System.Windows.Forms.Label dUILabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label direcciónLabel;
            System.Windows.Forms.Label géneroLabel;
            System.Windows.Forms.Label label1;
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            dUILabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            direcciónLabel = new System.Windows.Forms.Label();
            géneroLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dUILabel
            // 
            dUILabel.AutoSize = true;
            dUILabel.Location = new System.Drawing.Point(452, 146);
            dUILabel.Name = "dUILabel";
            dUILabel.Size = new System.Drawing.Size(26, 13);
            dUILabel.TabIndex = 30;
            dUILabel.Text = "DUI";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(103, 78);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 32;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(103, 115);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 34;
            apellidoLabel.Text = "Apellido:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(98, 151);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 36;
            telefonoLabel.Text = "Telefono:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(107, 186);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(41, 13);
            correoLabel.TabIndex = 38;
            correoLabel.Text = "Correo:";
            // 
            // direcciónLabel
            // 
            direcciónLabel.AutoSize = true;
            direcciónLabel.Location = new System.Drawing.Point(93, 222);
            direcciónLabel.Name = "direcciónLabel";
            direcciónLabel.Size = new System.Drawing.Size(55, 13);
            direcciónLabel.TabIndex = 40;
            direcciónLabel.Text = "Dirección:";
            // 
            // géneroLabel
            // 
            géneroLabel.AutoSize = true;
            géneroLabel.Location = new System.Drawing.Point(103, 259);
            géneroLabel.Name = "géneroLabel";
            géneroLabel.Size = new System.Drawing.Size(45, 13);
            géneroLabel.TabIndex = 42;
            géneroLabel.Text = "Género:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(119, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 13);
            label1.TabIndex = 30;
            label1.Text = "DUI:";
            label1.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(495, 184);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(484, 143);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 31;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(159, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 33;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(159, 112);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 35;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(159, 148);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 37;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(159, 183);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 39;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(159, 219);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 41;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(159, 256);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 43;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(218, 333);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 45;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(106, 383);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(187, 24);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(106, 333);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDUI
            // 
            this.txtDUI.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDUI.Location = new System.Drawing.Point(159, 37);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.ReadOnly = true;
            this.txtDUI.Size = new System.Drawing.Size(100, 20);
            this.txtDUI.TabIndex = 48;
            this.txtDUI.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(692, 405);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(96, 33);
            this.btnCerrar.TabIndex = 49;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // RegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(label1);
            this.Controls.Add(dUILabel);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(direcciónLabel);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(géneroLabel);
            this.Controls.Add(this.txtGenero);
            this.Name = "RegistroCliente";
            this.Text = "FormRegistro";
            this.Load += new System.EventHandler(this.RegistroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Button btnCerrar;
    }
}