using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5DS4
{


    public partial class wdReservasEntrada : Form
    {
        public wdReservasEntrada()
        {
            InitializeComponent();

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener datos del formulario
                string tipoEntrada = cbTipoEntrada.SelectedItem.ToString();
                int cantidadEntradas = (int)numEntrada.Value;
                bool conEstacionamiento = ckbEntradas.Checked;

                // Crear una instancia de la clase lógica y calcular
                Logica calculador = new Logica();
                decimal precioTotal = calculador.CalcularTotal(cantidadEntradas, tipoEntrada, conEstacionamiento);
                double itbms = calculador.CalcularITBMS();
                double spac = calculador.CalcularSPAC();

                // Mostrar resultados en los labels
                lblPrecioTotal.Text = $"Precio Total: {precioTotal:C}";
                lblITBMS.Text = $"ITBMS (7%): {itbms:C}";
                lblSPAC.Text = $"Impuesto SPAC (5%): {spac:C}";

                if (conEstacionamiento)
                {
                    lblEstacionamiento.Text = "Incluye estacionamiento.";
                }
                else
                {
                    lblEstacionamiento.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
