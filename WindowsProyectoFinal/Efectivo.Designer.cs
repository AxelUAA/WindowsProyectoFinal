namespace WindowsProyectoFinal
{
    partial class Efectivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelpago = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDinero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCambio = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.buttonPagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelpago
            // 
            this.labelpago.AutoSize = true;
            this.labelpago.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelpago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpago.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelpago.Location = new System.Drawing.Point(101, 79);
            this.labelpago.Name = "labelpago";
            this.labelpago.Size = new System.Drawing.Size(142, 25);
            this.labelpago.TabIndex = 1;
            this.labelpago.Text = "Total a Pagar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(80, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresa el monto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDinero
            // 
            this.textBoxDinero.Location = new System.Drawing.Point(95, 212);
            this.textBoxDinero.Name = "textBoxDinero";
            this.textBoxDinero.Size = new System.Drawing.Size(148, 22);
            this.textBoxDinero.TabIndex = 3;
            this.textBoxDinero.TextChanged += new System.EventHandler(this.textBoxDinero_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(644, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tu cambio";
            // 
            // textBoxCambio
            // 
            this.textBoxCambio.Location = new System.Drawing.Point(630, 79);
            this.textBoxCambio.Name = "textBoxCambio";
            this.textBoxCambio.Size = new System.Drawing.Size(148, 22);
            this.textBoxCambio.TabIndex = 5;
            this.textBoxCambio.TextChanged += new System.EventHandler(this.textBoxCambio_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(613, 358);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(182, 54);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // buttonPagar
            // 
            this.buttonPagar.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonPagar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPagar.Location = new System.Drawing.Point(61, 319);
            this.buttonPagar.Name = "buttonPagar";
            this.buttonPagar.Size = new System.Drawing.Size(182, 54);
            this.buttonPagar.TabIndex = 7;
            this.buttonPagar.Text = "Pagar";
            this.buttonPagar.UseVisualStyleBackColor = false;
            this.buttonPagar.Click += new System.EventHandler(this.buttonPagar_Click);
            // 
            // Efectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsProyectoFinal.Properties.Resources.Fondo5;
            this.ClientSize = new System.Drawing.Size(869, 474);
            this.Controls.Add(this.buttonPagar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.textBoxCambio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDinero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelpago);
            this.Controls.Add(this.textBox1);
            this.Name = "Efectivo";
            this.Text = "Efectivo";
            this.Load += new System.EventHandler(this.Efectivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelpago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDinero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCambio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button buttonPagar;
    }
}