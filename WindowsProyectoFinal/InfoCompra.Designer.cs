namespace WindowsProyectoFinal
{
    partial class InfoCompra
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPagoTarjeta = new System.Windows.Forms.Button();
            this.btnPagoOxxo = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnPagoEfectivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(166, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información de compra";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(31, 189);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(540, 392);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::WindowsProyectoFinal.Properties.Resources._77_shop;
            this.pictureBox1.Location = new System.Drawing.Point(604, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnPagoTarjeta
            // 
            this.btnPagoTarjeta.BackColor = System.Drawing.Color.Black;
            this.btnPagoTarjeta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnPagoTarjeta.Location = new System.Drawing.Point(676, 230);
            this.btnPagoTarjeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPagoTarjeta.Name = "btnPagoTarjeta";
            this.btnPagoTarjeta.Size = new System.Drawing.Size(165, 56);
            this.btnPagoTarjeta.TabIndex = 3;
            this.btnPagoTarjeta.Text = "Pago con tarjeta";
            this.btnPagoTarjeta.UseVisualStyleBackColor = false;
            this.btnPagoTarjeta.Click += new System.EventHandler(this.btnPagoTarjeta_Click);
            // 
            // btnPagoOxxo
            // 
            this.btnPagoOxxo.BackColor = System.Drawing.Color.Black;
            this.btnPagoOxxo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoOxxo.ForeColor = System.Drawing.Color.White;
            this.btnPagoOxxo.Location = new System.Drawing.Point(676, 328);
            this.btnPagoOxxo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPagoOxxo.Name = "btnPagoOxxo";
            this.btnPagoOxxo.Size = new System.Drawing.Size(165, 56);
            this.btnPagoOxxo.TabIndex = 4;
            this.btnPagoOxxo.Text = "Pagar en OXXO";
            this.btnPagoOxxo.UseVisualStyleBackColor = false;
            this.btnPagoOxxo.Click += new System.EventHandler(this.btnPagoOxxo_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.DimGray;
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(28, 621);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(104, 29);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnPagoEfectivo
            // 
            this.btnPagoEfectivo.BackColor = System.Drawing.Color.Black;
            this.btnPagoEfectivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoEfectivo.ForeColor = System.Drawing.Color.White;
            this.btnPagoEfectivo.Location = new System.Drawing.Point(676, 434);
            this.btnPagoEfectivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPagoEfectivo.Name = "btnPagoEfectivo";
            this.btnPagoEfectivo.Size = new System.Drawing.Size(165, 56);
            this.btnPagoEfectivo.TabIndex = 6;
            this.btnPagoEfectivo.Text = "Pago en Efectivo";
            this.btnPagoEfectivo.UseVisualStyleBackColor = false;
            this.btnPagoEfectivo.Click += new System.EventHandler(this.btnPagoEfectivo_Click_1);
            // 
            // InfoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsProyectoFinal.Properties.Resources.Fondo5;
            this.ClientSize = new System.Drawing.Size(964, 794);
            this.Controls.Add(this.btnPagoEfectivo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnPagoOxxo);
            this.Controls.Add(this.btnPagoTarjeta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InfoCompra";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.InfoCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPagoTarjeta;
        private System.Windows.Forms.Button btnPagoOxxo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnPagoEfectivo;
    }
}