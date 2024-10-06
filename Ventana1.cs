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

        private void Ventana1_Load(object sender, EventArgs e)
        {
            Logica logica = new Logica();
            logica.Calcular(precioPorBoleto, numeroEntradas, estacionamientos);


        }

        private void Ventana1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numEntrada_ValueChanged(object sender, EventArgs e)
        {

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
                CalculadorEntradas calculador = new CalculadorEntradas(tipoEntrada, cantidadEntradas, conEstacionamiento);
                double precioTotal = calculador.CalcularTotal();
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

        private void lblPrecioTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblITBMS_Click(object sender, EventArgs e)
        {

        }

        private void lblSPAC_Click(object sender, EventArgs e)
        {

        }

        private void lblEstacionamiento_Click(object sender, EventArgs e)
        {

        }
    }
}
