namespace PRACTICA_4._8_REPASO___PALINDROMOS
{
    partial class btnVerificar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnVerificar_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "TEXT";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(469, 92);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(97, 20);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "lblResultado";
            // 
            // btnVerificar_Click
            // 
            this.btnVerificar_Click.Location = new System.Drawing.Point(324, 224);
            this.btnVerificar_Click.Name = "btnVerificar_Click";
            this.btnVerificar_Click.Size = new System.Drawing.Size(133, 73);
            this.btnVerificar_Click.TabIndex = 2;
            this.btnVerificar_Click.Text = "btnVerificar";
            this.btnVerificar_Click.UseVisualStyleBackColor = true;
            this.btnVerificar_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerificar_Click);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.textBox1);
            this.Name = "btnVerificar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnVerificar_Click;
    }
}

