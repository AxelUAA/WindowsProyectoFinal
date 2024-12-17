namespace WindowsProyectoFinal
{
    partial class Carrito
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
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelOpcPago = new System.Windows.Forms.Panel();
            this.btnPagoOxxo = new System.Windows.Forms.Button();
            this.btnPagoTarjeta = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelOpcPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxLogin.Controls.Add(this.button3);
            this.groupBoxLogin.Controls.Add(this.richTextBox1);
            this.groupBoxLogin.Controls.Add(this.pictureBox2);
            this.groupBoxLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxLogin.Location = new System.Drawing.Point(124, 131);
            this.groupBoxLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxLogin.Size = new System.Drawing.Size(924, 512);
            this.groupBoxLogin.TabIndex = 3;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Carrito de compras";
            this.groupBoxLogin.Enter += new System.EventHandler(this.groupBoxLogin_Enter);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox1.Location = new System.Drawing.Point(68, 188);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(788, 286);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::WindowsProyectoFinal.Properties.Resources.Logo2;
            this.pictureBox2.Location = new System.Drawing.Point(377, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(124, 649);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 87);
            this.button2.TabIndex = 22;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(895, 663);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 87);
            this.button1.TabIndex = 23;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelOpcPago
            // 
            this.panelOpcPago.Controls.Add(this.btnPagoOxxo);
            this.panelOpcPago.Controls.Add(this.btnPagoTarjeta);
            this.panelOpcPago.Location = new System.Drawing.Point(895, 745);
            this.panelOpcPago.Name = "panelOpcPago";
            this.panelOpcPago.Size = new System.Drawing.Size(175, 100);
            this.panelOpcPago.TabIndex = 24;
            // 
            // btnPagoOxxo
            // 
            this.btnPagoOxxo.BackColor = System.Drawing.Color.Black;
            this.btnPagoOxxo.FlatAppearance.BorderSize = 0;
            this.btnPagoOxxo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagoOxxo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoOxxo.ForeColor = System.Drawing.Color.White;
            this.btnPagoOxxo.Location = new System.Drawing.Point(0, 52);
            this.btnPagoOxxo.Name = "btnPagoOxxo";
            this.btnPagoOxxo.Size = new System.Drawing.Size(175, 48);
            this.btnPagoOxxo.TabIndex = 26;
            this.btnPagoOxxo.Text = "Pagar en OXXO";
            this.btnPagoOxxo.UseVisualStyleBackColor = false;
            // 
            // btnPagoTarjeta
            // 
            this.btnPagoTarjeta.BackColor = System.Drawing.Color.Black;
            this.btnPagoTarjeta.FlatAppearance.BorderSize = 0;
            this.btnPagoTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagoTarjeta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnPagoTarjeta.Location = new System.Drawing.Point(0, 3);
            this.btnPagoTarjeta.Name = "btnPagoTarjeta";
            this.btnPagoTarjeta.Size = new System.Drawing.Size(175, 50);
            this.btnPagoTarjeta.TabIndex = 25;
            this.btnPagoTarjeta.Text = "Pago con tarjeta";
            this.btnPagoTarjeta.UseVisualStyleBackColor = false;
            this.btnPagoTarjeta.Click += new System.EventHandler(this.btnPagoTarjeta_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlText;
            this.button3.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(355, 127);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 56);
            this.button3.TabIndex = 25;
            this.button3.Text = "Actualizar Carro";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsProyectoFinal.Properties.Resources.FONDO;
            this.ClientSize = new System.Drawing.Size(1172, 925);
            this.Controls.Add(this.panelOpcPago);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBoxLogin);
            this.Name = "Carrito";
            this.Text = "Carrito";
            this.groupBoxLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelOpcPago.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelOpcPago;
        private System.Windows.Forms.Button btnPagoTarjeta;
        private System.Windows.Forms.Button btnPagoOxxo;
        private System.Windows.Forms.Button button3;
    }
}