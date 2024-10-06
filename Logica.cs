using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5DS4
{
    internal class Logica
    {

        Logica() { 
        
        }

        public void Calcular() { 
             private const decimal PRECIO_PLATINO = 150m;
             private const decimal PRECIO_VIP = 100m;
             private const decimal PRECIO_EJECUTIVO = 75m;
             private const decimal PRECIO_GENERAL = 50m;
             private const decimal PRECIO_ESTACIONAMIENTO = 25m;
             private const decimal IMPUESTO_SPAC = 0.05m; // 5%
             private const decimal ITBMS = 0.07m; // 7%

             // Método para calcular el total de la compra
             public decimal CalcularTotal(int cantidadEntradas, string tipoEntrada, bool estacionamiento)
             {
               decimal precioEntrada = ObtenerPrecioEntrada(tipoEntrada);
               decimal totalEntradas = cantidadEntradas * precioEntrada;

               // Aplicar el impuesto de la SPAC (5% sobre el total de entradas)
               decimal impuestoSPAC = totalEntradas * IMPUESTO_SPAC;
                
               // Variable para la cantidad de estacionamientos seleccionados (0, 1 o 2)
               int cantidadEstacionamientos = 0;  
              // Calcular el total por estacionamientos (si es que se ha seleccionado al menos 1)
              decimal totalEstacionamiento = cantidadEstacionamientos > 0 ? PRECIO_ESTACIONAMIENTO * cantidadEstacionamientos : 0;

               // Sumar el total de entradas y estacionamiento
               decimal totalConEstacionamiento = totalEntradas + totalEstacionamiento + impuestoSPAC;

               // Aplicar el ITBMS (7% sobre el total final)
               decimal itbmsTotal = totalConEstacionamiento * ITBMS;

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
}
