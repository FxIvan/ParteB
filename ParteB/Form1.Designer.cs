namespace ParteB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnFormatoDeFechas = new System.Windows.Forms.Button();
            this.btnFormatoDeStrings = new System.Windows.Forms.Button();
            this.btnFormatoDeNumeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormatoDeFechas
            // 
            this.btnFormatoDeFechas.Location = new System.Drawing.Point(24, 78);
            this.btnFormatoDeFechas.Name = "btnFormatoDeFechas";
            this.btnFormatoDeFechas.Size = new System.Drawing.Size(173, 31);
            this.btnFormatoDeFechas.TabIndex = 0;
            this.btnFormatoDeFechas.Text = "Formato de fechas";
            this.btnFormatoDeFechas.UseVisualStyleBackColor = true;
            this.btnFormatoDeFechas.Click += new System.EventHandler(this.btnFormatoDeFechas_Click);
            // 
            // btnFormatoDeStrings
            // 
            this.btnFormatoDeStrings.Location = new System.Drawing.Point(24, 137);
            this.btnFormatoDeStrings.Name = "btnFormatoDeStrings";
            this.btnFormatoDeStrings.Size = new System.Drawing.Size(173, 31);
            this.btnFormatoDeStrings.TabIndex = 1;
            this.btnFormatoDeStrings.Text = "Formato De String";
            this.btnFormatoDeStrings.UseVisualStyleBackColor = true;
            this.btnFormatoDeStrings.Click += new System.EventHandler(this.btnFormatoDeStrings_Click);
            // 
            // btnFormatoDeNumeros
            // 
            this.btnFormatoDeNumeros.Location = new System.Drawing.Point(24, 12);
            this.btnFormatoDeNumeros.Name = "btnFormatoDeNumeros";
            this.btnFormatoDeNumeros.Size = new System.Drawing.Size(173, 31);
            this.btnFormatoDeNumeros.TabIndex = 2;
            this.btnFormatoDeNumeros.Text = "Formato de Numeros";
            this.btnFormatoDeNumeros.UseVisualStyleBackColor = true;
            this.btnFormatoDeNumeros.Click += new System.EventHandler(this.btnFormatoDeNumeros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 194);
            this.Controls.Add(this.btnFormatoDeNumeros);
            this.Controls.Add(this.btnFormatoDeStrings);
            this.Controls.Add(this.btnFormatoDeFechas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnFormatoDeFechas;
        private System.Windows.Forms.Button btnFormatoDeStrings;
        private System.Windows.Forms.Button btnFormatoDeNumeros;
    }
}

