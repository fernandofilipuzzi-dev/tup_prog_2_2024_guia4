using System;
using System.Windows.Forms;
using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        Cooperativa cooperativa;
        Cliente clienteSeleccion;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciarCooperativa_Click(object sender, EventArgs e)
        {
            string nombre = tbCoperativa.Text;
            cooperativa = new Cooperativa(nombre);

            #region limpiando controles
            btnIniciarCooperativa.Enabled = false;
            tbCoperativa.Enabled = false;
            gbAltaCliente.Enabled = true;
            #endregion
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            #region limpiando controles
            lbDescripcion.Text = "";
            gbConsumos.Enabled = false;
            gbCargaConsumos.Enabled = false;
            #endregion

            if (string.IsNullOrEmpty(tbNroServicio.Text.Trim())==false)
            {
                int nroServicio = Convert.ToInt32(tbNroServicio.Text.Trim());
                clienteSeleccion = cooperativa.BuscarCliente(nroServicio);
                if (clienteSeleccion != null)
                {
                    lbDescripcion.Text = clienteSeleccion.ToString();

                    gbConsumos.Enabled = true;
                    gbCargaConsumos.Enabled = true;
                }
                else 
                {
                    MessageBox.Show("Cliente no encontrado!");
                }
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FormDatosCliente fCliente = new FormDatosCliente();

            if (fCliente.ShowDialog() == DialogResult.OK)
            {
                int servicio = Convert.ToInt32(fCliente.tbNumeroServicio.Text);

                string nombre = fCliente.tbNombre.Text;
                int dni = Convert.ToInt32(fCliente.tbDNI.Text);
                string direccion = fCliente.tbDireccion.Text;

                Medidor medidor = new Medidor(servicio);
                Cliente nuevo = cooperativa.AgregarCliente(dni, nombre, direccion, medidor);

                MessageBox.Show($"Servicio nro: {nuevo.Medidor.NumeroServicio}. Cliente nuevo!");

                gbClientes.Enabled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrarConsumo_Click(object sender, EventArgs e)
        {
            double medicionActual = Convert.ToDouble(tbLecturaMedidor.Text);


            clienteSeleccion.Medidor.RegistrarConsumo(medicionActual);

            lbDescripcionPeriodo.Text = $"Último periodo: {clienteSeleccion.Medidor.PeriodoActual}";

            tbLecturaMedidor.Clear();
        }

        private void btnVerConsumo_Click(object sender, EventArgs e)
        {
            FormVer fResultado = new FormVer();
            fResultado.lbResultados.Items.Clear();
            
            fResultado.lbResultados.Items.Add(  $"Número de Servicio {clienteSeleccion.Medidor.NumeroServicio,-10}");

            for (int n = 0; n < clienteSeleccion.Medidor.CantidadConsumos; n++)
            {
                //imprimo el historico de este cliente
                string consumo = clienteSeleccion.Medidor.LeerConsumo(n).ToString("0.00");
                int periodo=(n + clienteSeleccion.Medidor.PeriodoActual) % 6;

                fResultado.lbResultados.Items.Add( $"{periodo,-10} {consumo,10}");
            }

            fResultado.ShowDialog();

            fResultado.Dispose();
        }
    }
}
