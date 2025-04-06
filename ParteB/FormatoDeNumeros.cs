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
    public partial class FormatoDeNumeros : Form
    {
        public FormatoDeNumeros()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            double auxiliar;
            double auxiliar1;
            double auxiliar2;
            // Convierte el texto ingresado a número (double)
            auxiliar = double.Parse(txtIngreso.Text);

            // Formato moneda local (ej: $1.234,56 o USD depending on locale)
            textBox1.Text = string.Format("{0:c}", auxiliar);
            // auxiliar1 se calcula como el 1% del número (aunque no se usa más adelante)
            auxiliar1 = (auxiliar / 100);

            // Formato numérico con separadores (miles, decimales)
            textBox2.Text = string.Format("{0:N}", auxiliar); // Ej: 1,234.56

            // Número con 4 decimales
            textBox3.Text = string.Format("{0:N4}", auxiliar); // Ej: 1,234.5600

            // Número entero con ceros a la izquierda (8 dígitos)
            textBox4.Text = string.Format("{0:D8}", Convert.ToInt32(auxiliar)); // Ej: 00001234

            // Número fijo con 3 decimales
            textBox5.Text = string.Format("{0:f3}", auxiliar); // Ej: 1234.560

            // Notación científica con 3 decimales
            textBox6.Text = string.Format("{0:E3}", auxiliar); // Ej: 1.235E+003

            // Porcentaje (100 = 10,000%)
            textBox7.Text = string.Format("{0:p}", auxiliar); // Ej: 1.234.567,89% si auxiliar = 12.3456789

            // Texto personalizado con formato moneda
            textBox8.Text = string.Format("el valor es {0:c}", auxiliar);

            // Suma 10 al valor original
            auxiliar2 = (auxiliar + 10);

            // Muestra ambos valores en formato moneda
            textBox9.Text = string.Format("{0:c} {1:c}", auxiliar, auxiliar2); // Ej: $1,234.56 $1,244.56

        }
    }
}
