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
        public decimal CalcularTotal(int cantidadEntradas, string tipoEntrada, bool estacionamiento)
        {
            decimal precioEntrada = ObtenerPrecioEntrada(tipoEntrada);
            decimal totalEntradas = cantidadEntradas * precioEntrada;

            // Aplicar el impuesto de la SPAC (5% sobre el total de entradas)
            decimal impuestoSPACCalcular = totalEntradas * impuestoSPAC;
            impuestoSPACResultado = impuestoSPACCalcular;

        // Calcular el total por estacionamientos (si es que se ha seleccionado)
        decimal totalEstacionamiento = estacionamiento ? precioEstacionamiento * 2 : 0;

            // Sumar el total de entradas y estacionamiento
            decimal totalConEstacionamiento = totalEntradas + totalEstacionamiento + impuestoSPAC;

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
                    return PRECIO_PLATINO;
                case "vip":
                    return PRECIO_VIP;
                case "ejecutivo":
                    return PRECIO_EJECUTIVO;
                case "general":
                    return PRECIO_GENERAL;
                default:
                    throw new ArgumentException("Tipo de entrada inválido");
            }
        } 
    }
    
}

