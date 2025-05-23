﻿using System;
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
    public partial class FormatoDeFechas : Form
    {
        public FormatoDeFechas()
        {
            InitializeComponent();
        }

        private void FormatoDeFechas_Load(object sender, EventArgs e)
        {

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            DateTime Fecha = DateTime.Now;
            textBox1.Text = Convert.ToString(Fecha);
            //Fecha Corta
            textBox2.Text = string.Format("{0:d}", Fecha);
            //Fecha Larga + tiempo
            textBox3.Text = string.Format("{0:D}", Fecha);
            //Fecha larga + tiempocorto
            textBox4.Text = string.Format("{0:f}", Fecha);
            //Fecha corta + tiempo corto
            textBox5.Text = string.Format("{0:g}", Fecha);
            //Fecha corta + tiempo largo
            textBox6.Text = string.Format("{0:G}", Fecha);
        }
    }
}
