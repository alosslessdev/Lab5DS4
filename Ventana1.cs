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
    public partial class Ventana1 : Form
    {
        public Ventana1()
        {
            InitializeComponent();

        }

        private void Ventana1_Load(object sender, EventArgs e)
        {
            Logica logica = new Logica();
            logica.Calcular(precioPorBoleto, numeroEntradas, estacionamientos);
            //sdfghkjk aaaaaaaaa

        }
    }
}
