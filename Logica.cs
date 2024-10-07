using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5DS4
{
    internal class Logica
    {

        public Logica() {

        }

        private const decimal precioPlatino = 150m;
        private const decimal precioVip = 100m;
        private const decimal precioEjecutivo = 75m;
        private const decimal precioGeneral = 50m;
        private const decimal precioEstacionamiento = 25m;
        private const decimal impuestoSPAC = 0.05m; // 5%
        private const decimal ITBMS = 0.07m; // 7%
        private decimal impuestoSPACResultado, ITBMSResultado;

        //getter en c#
        public decimal CalcularSPAC
        { 
            get => impuestoSPACResultado;
        }

        public decimal CalcularITBMS
        {
            get => ITBMSResultado;
        }

        // Método para calcular el total de la compra
        internal decimal CalcularTotal(int cantidadEntradas, string tipoEntrada, string estacionamiento)
        {
            decimal precioEntrada = ObtenerPrecioEntrada(tipoEntrada);
            decimal totalEntradas = cantidadEntradas * precioEntrada;

            // Aplicar el impuesto de la SPAC (5% sobre el total de entradas)
            if (totalEntradas != 0)
            {
                decimal impuestoSPACCalcular = totalEntradas * impuestoSPAC;
                impuestoSPACResultado = impuestoSPACCalcular;
            }
            else {
                impuestoSPACResultado = 0;

            }

            // Calcular el total por estacionamientos (si es que se ha seleccionado)
            decimal totalEstacionamiento = Convert.ToInt16(estacionamiento) * precioEstacionamiento;

            // Sumar el total de entradas y estacionamiento
            decimal totalConEstacionamiento = totalEntradas + totalEstacionamiento + impuestoSPACResultado;

            // Aplicar el ITBMS (7% sobre el total final)
            decimal itbmsTotal = totalConEstacionamiento * ITBMS;
            ITBMSResultado = itbmsTotal;

            // Retornar el total final con impuestos incluidos
            return totalConEstacionamiento + itbmsTotal;
        }

        private decimal ObtenerPrecioEntrada(string tipoEntrada)
        {
            switch (tipoEntrada.ToLower())
            {
                case "platino":
                    return precioPlatino;
                case "vip":
                    return precioVip;
                case "ejecutivo":
                    return precioEjecutivo;
                case "general":
                    return precioGeneral;
                default:
                    return 0;
            }
        } 
    }
    
}

