using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer21__LiCirc_AtenProcesos
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Procesador procesador = new Procesador();

            for (int i = 0; i < 200; i++)
            {
                procesador.generarCiclo();
                if (procesador.primerProceso == false)
                    procesador.atenderProceso();
            }
            txtCiclosColaVacía.Text = Convert.ToString(procesador.colaVacía);
            txtProcesosPendientes.Text = Convert.ToString(procesador.procesosPendientes);
            txtSumaCiclos.Text = Convert.ToString(procesador.obtenerSumaDeCiclosPendientes());
            txtMaxProcesosFormados.Text = Convert.ToString(procesador.máximoProcesosFormados);
            txtProcesosAtendidos.Text = Convert.ToString(procesador.procesosAtendidos);
        }
    }
}
