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
            //inicializar controles
            InitializeComponent();
            cbTipoEntrada.SelectedIndex = 0;
            cbEstacionamientos.SelectedIndex = 0;
            lblEstacionamiento.Text = string.Empty;

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
           

                if (cbTipoEntrada.SelectedIndex != 0)
                {
                    // Obtener datos del formulario
                string tipoEntrada = cbTipoEntrada.SelectedItem.ToString();
                int cantidadEntradas = (int)numEntrada.Value;
                string conEstacionamiento = cbEstacionamientos.SelectedItem.ToString();

                if (Convert.ToInt16(conEstacionamiento) > cantidadEntradas)
                {
                    MessageBox.Show("El numero de estacionamientos es mayor al de entradas. Se ha cambiado el numero de estacionamientos a 1.");
                    conEstacionamiento = "1";
                    cbEstacionamientos.SelectedIndex = 1;

                }


                // Crear una instancia de la clase lógica y calcular
                Logica calculador = new Logica();
                    decimal precioTotal = calculador.CalcularTotal(cantidadEntradas, tipoEntrada, conEstacionamiento);
                    decimal itbms = calculador.CalcularITBMS;
                    decimal spac = calculador.CalcularSPAC;

                    // Mostrar resultados en los labels
                    lblPrecioTotal.Text = $"Precio Total: {precioTotal:C}";
                    lblITBMS.Text = $"ITBMS (7%): {itbms:C}";
                    lblSPAC.Text = $"Impuesto SPAC (5%): {spac:C}";

                    if (conEstacionamiento != "0")
                    {
                        lblEstacionamiento.Text = "Estacionamientos: " + conEstacionamiento;
                    }
                    else
                    {
                        lblEstacionamiento.Text = string.Empty;
                    }
                }
                else {
                    MessageBox.Show("No se ha seleccionado el tipo de entrada. Por favor, haga click al lado de donde dice tipo de entrada y elija una de " +
                        "las opciones.");

                }

            }

        }


    }

