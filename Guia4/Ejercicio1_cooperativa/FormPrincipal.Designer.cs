namespace Ejercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciarCooperativa = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnRegistrarConsumo = new System.Windows.Forms.Button();
            this.tbNroServicio = new System.Windows.Forms.TextBox();
            this.tbCoperativa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerConsumo = new System.Windows.Forms.Button();
            this.tbLecturaMedidor = new System.Windows.Forms.TextBox();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.gbConsumos = new System.Windows.Forms.GroupBox();
            this.gbCargaConsumos = new System.Windows.Forms.GroupBox();
            this.lbDescripcionPeriodo = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.gbAltaCliente = new System.Windows.Forms.GroupBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.gbClientes.SuspendLayout();
            this.gbConsumos.SuspendLayout();
            this.gbCargaConsumos.SuspendLayout();
            this.gbAltaCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarCooperativa
            // 
            this.btnIniciarCooperativa.Location = new System.Drawing.Point(480, 39);
            this.btnIniciarCooperativa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIniciarCooperativa.Name = "btnIniciarCooperativa";
            this.btnIniciarCooperativa.Size = new System.Drawing.Size(323, 35);
            this.btnIniciarCooperativa.TabIndex = 0;
            this.btnIniciarCooperativa.Text = "Iniciar Cooperativa";
            this.btnIniciarCooperativa.UseVisualStyleBackColor = true;
            this.btnIniciarCooperativa.Click += new System.EventHandler(this.btnIniciarCooperativa_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(259, 506);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(323, 35);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(459, 29);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(325, 35);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // btnRegistrarConsumo
            // 
            this.btnRegistrarConsumo.Location = new System.Drawing.Point(397, 26);
            this.btnRegistrarConsumo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrarConsumo.Name = "btnRegistrarConsumo";
            this.btnRegistrarConsumo.Size = new System.Drawing.Size(320, 35);
            this.btnRegistrarConsumo.TabIndex = 5;
            this.btnRegistrarConsumo.Text = "Cargar Consumo";
            this.btnRegistrarConsumo.UseVisualStyleBackColor = true;
            this.btnRegistrarConsumo.Click += new System.EventHandler(this.btnRegistrarConsumo_Click);
            // 
            // tbNroServicio
            // 
            this.tbNroServicio.Location = new System.Drawing.Point(179, 29);
            this.tbNroServicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNroServicio.Name = "tbNroServicio";
            this.tbNroServicio.Size = new System.Drawing.Size(265, 26);
            this.tbNroServicio.TabIndex = 6;
            // 
            // tbCoperativa
            // 
            this.tbCoperativa.Location = new System.Drawing.Point(204, 41);
            this.tbCoperativa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCoperativa.Name = "tbCoperativa";
            this.tbCoperativa.Size = new System.Drawing.Size(265, 26);
            this.tbCoperativa.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Coperativa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Número de Servicio";
            // 
            // btnVerConsumo
            // 
            this.btnVerConsumo.Location = new System.Drawing.Point(402, 29);
            this.btnVerConsumo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerConsumo.Name = "btnVerConsumo";
            this.btnVerConsumo.Size = new System.Drawing.Size(320, 41);
            this.btnVerConsumo.TabIndex = 10;
            this.btnVerConsumo.Text = "Ver Consumo";
            this.btnVerConsumo.UseVisualStyleBackColor = true;
            this.btnVerConsumo.Click += new System.EventHandler(this.btnVerConsumo_Click);
            // 
            // tbLecturaMedidor
            // 
            this.tbLecturaMedidor.Location = new System.Drawing.Point(98, 29);
            this.tbLecturaMedidor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLecturaMedidor.Name = "tbLecturaMedidor";
            this.tbLecturaMedidor.Size = new System.Drawing.Size(284, 26);
            this.tbLecturaMedidor.TabIndex = 11;
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.tbNroServicio);
            this.gbClientes.Controls.Add(this.gbConsumos);
            this.gbClientes.Controls.Add(this.gbCargaConsumos);
            this.gbClientes.Controls.Add(this.lbDescripcion);
            this.gbClientes.Controls.Add(this.label2);
            this.gbClientes.Controls.Add(this.btnSeleccionar);
            this.gbClientes.Enabled = false;
            this.gbClientes.Location = new System.Drawing.Point(18, 168);
            this.gbClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbClientes.Size = new System.Drawing.Size(800, 328);
            this.gbClientes.TabIndex = 12;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Consultas de clientes";
            // 
            // gbConsumos
            // 
            this.gbConsumos.Controls.Add(this.btnVerConsumo);
            this.gbConsumos.Enabled = false;
            this.gbConsumos.Location = new System.Drawing.Point(62, 221);
            this.gbConsumos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConsumos.Name = "gbConsumos";
            this.gbConsumos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConsumos.Size = new System.Drawing.Size(728, 86);
            this.gbConsumos.TabIndex = 12;
            this.gbConsumos.TabStop = false;
            this.gbConsumos.Text = "Consumos";
            // 
            // gbCargaConsumos
            // 
            this.gbCargaConsumos.Controls.Add(this.lbDescripcionPeriodo);
            this.gbCargaConsumos.Controls.Add(this.tbLecturaMedidor);
            this.gbCargaConsumos.Controls.Add(this.btnRegistrarConsumo);
            this.gbCargaConsumos.Enabled = false;
            this.gbCargaConsumos.Location = new System.Drawing.Point(62, 100);
            this.gbCargaConsumos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCargaConsumos.Name = "gbCargaConsumos";
            this.gbCargaConsumos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCargaConsumos.Size = new System.Drawing.Size(729, 112);
            this.gbCargaConsumos.TabIndex = 11;
            this.gbCargaConsumos.TabStop = false;
            this.gbCargaConsumos.Text = "Carga de consumos";
            // 
            // lbDescripcionPeriodo
            // 
            this.lbDescripcionPeriodo.AutoSize = true;
            this.lbDescripcionPeriodo.Location = new System.Drawing.Point(93, 65);
            this.lbDescripcionPeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescripcionPeriodo.Name = "lbDescripcionPeriodo";
            this.lbDescripcionPeriodo.Size = new System.Drawing.Size(29, 20);
            this.lbDescripcionPeriodo.TabIndex = 12;
            this.lbDescripcionPeriodo.Text = "----";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(213, 75);
            this.lbDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(24, 20);
            this.lbDescripcion.TabIndex = 10;
            this.lbDescripcion.Text = "---";
            // 
            // gbAltaCliente
            // 
            this.gbAltaCliente.Controls.Add(this.btnAgregarCliente);
            this.gbAltaCliente.Enabled = false;
            this.gbAltaCliente.Location = new System.Drawing.Point(18, 84);
            this.gbAltaCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAltaCliente.Name = "gbAltaCliente";
            this.gbAltaCliente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAltaCliente.Size = new System.Drawing.Size(800, 74);
            this.gbAltaCliente.TabIndex = 13;
            this.gbAltaCliente.TabStop = false;
            this.gbAltaCliente.Text = "Alta de clientes";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(459, 29);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(320, 35);
            this.btnAgregarCliente.TabIndex = 5;
            this.btnAgregarCliente.Text = "Carga de clientes";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 546);
            this.Controls.Add(this.gbAltaCliente);
            this.Controls.Add(this.gbClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCoperativa);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIniciarCooperativa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Ejercicio 1";
            this.gbClientes.ResumeLayout(false);
            this.gbClientes.PerformLayout();
            this.gbConsumos.ResumeLayout(false);
            this.gbCargaConsumos.ResumeLayout(false);
            this.gbCargaConsumos.PerformLayout();
            this.gbAltaCliente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarCooperativa;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnRegistrarConsumo;
        private System.Windows.Forms.TextBox tbNroServicio;
        private System.Windows.Forms.TextBox tbCoperativa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerConsumo;
        private System.Windows.Forms.TextBox tbLecturaMedidor;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.GroupBox gbCargaConsumos;
        private System.Windows.Forms.GroupBox gbConsumos;
        private System.Windows.Forms.GroupBox gbAltaCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Label lbDescripcionPeriodo;
    }
}

