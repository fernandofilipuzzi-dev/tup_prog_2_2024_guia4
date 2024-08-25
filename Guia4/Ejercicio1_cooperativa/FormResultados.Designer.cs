namespace Ejercicio1
{
    partial class FormResultados
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
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResultados
            // 
            this.lbResultados.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.ItemHeight = 18;
            this.lbResultados.Location = new System.Drawing.Point(18, 18);
            this.lbResultados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(596, 238);
            this.lbResultados.TabIndex = 2;
            // 
            // btnPrueba
            // 
            this.btnPrueba.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPrueba.Location = new System.Drawing.Point(243, 272);
            this.btnPrueba.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(112, 35);
            this.btnPrueba.TabIndex = 3;
            this.btnPrueba.Text = "Cerrar";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // FormResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 322);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.lbResultados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
        public System.Windows.Forms.ListBox lbResultados;
    }
}