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
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(494, 207);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dUILabel
            // 
            dUILabel.AutoSize = true;
            dUILabel.Location = new System.Drawing.Point(451, 169);
            dUILabel.Name = "dUILabel";
            dUILabel.Size = new System.Drawing.Size(26, 13);
            dUILabel.TabIndex = 30;
            dUILabel.Text = "DUI";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(483, 166);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 31;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(95, 109);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 32;
            nombreLabel.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 33;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(95, 146);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 34;
            apellidoLabel.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(151, 143);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 35;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(90, 182);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 36;
            telefonoLabel.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(151, 179);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 37;
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(99, 217);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(41, 13);
            correoLabel.TabIndex = 38;
            correoLabel.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(151, 214);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 39;
            // 
            // direcciónLabel
            // 
            direcciónLabel.AutoSize = true;
            direcciónLabel.Location = new System.Drawing.Point(85, 253);
            direcciónLabel.Name = "direcciónLabel";
            direcciónLabel.Size = new System.Drawing.Size(55, 13);
            direcciónLabel.TabIndex = 40;
            direcciónLabel.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(151, 250);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 41;
            // 
            // géneroLabel
            // 
            géneroLabel.AutoSize = true;
            géneroLabel.Location = new System.Drawing.Point(95, 290);
            géneroLabel.Name = "géneroLabel";
            géneroLabel.Size = new System.Drawing.Size(45, 13);
            géneroLabel.TabIndex = 42;
            géneroLabel.Text = "Género:";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(151, 287);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 43;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(210, 364);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 45;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(98, 414);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(187, 24);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(98, 364);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(151, 68);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(100, 20);
            this.txtDUI.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(111, 71);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 13);
            label1.TabIndex = 30;
            label1.Text = "DUI:";
            // 
            // RegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}