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
            cbTipoEntrada.SelectedIndex = 0;

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbTipoEntrada.SelectedItem.ToString() != null)
                {
                    // Obtener datos del formulario
                string tipoEntrada = cbTipoEntrada.SelectedItem.ToString();
                int cantidadEntradas = (int)numEntrada.Value;
                bool conEstacionamiento = ckbEntradas.Checked;




                    // Crear una instancia de la clase lógica y calcular
                    Logica calculador = new Logica();
                    decimal precioTotal = calculador.CalcularTotal(cantidadEntradas, tipoEntrada, conEstacionamiento);
                    decimal itbms = calculador.CalcularITBMS;
                    decimal spac = calculador.CalcularSPAC;

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
                else {
                    MessageBox.Show("No se ha seleccionado el tipo de entrada. Por favor, haga click abajo de donde dice tipo de entrada y elija una de " +
                        "las opciones.");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha seleccionado el tipo de entrada. Por favor, haga click abajo de donde dice tipo de entrada y elija una de " +
                                       "las opciones.");
            }
        }

        private void numEntrada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ckbEntradas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbTipoEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelEstaticoEntrada_Click(object sender, EventArgs e)
        {

        }
    }
}
