using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParteB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formatoDeNumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnFormatoDeNumeros_Click(object sender, EventArgs e)
        {
            FormatoDeNumeros form = new FormatoDeNumeros();
            form.ShowDialog();
        }

        private void btnFormatoDeFechas_Click(object sender, EventArgs e)
        {
            // Entrada Ejemplo: 6/04/2025T18:07:2025
            FormatoDeFechas form = new FormatoDeFechas();
            form.ShowDialog();
        }

        private void btnFormatoDeStrings_Click(object sender, EventArgs e)
        {
            ManejoDeStrings form = new ManejoDeStrings();
            form.ShowDialog();
        }
    }
}
