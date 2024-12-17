namespace WindowsProyectoFinal
{
    partial class Compra
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
            this.BtnPagar = new System.Windows.Forms.Button();
            this.pictureBoxLogoTarjeta = new System.Windows.Forms.PictureBox();
            this.labelNombreTarjeta = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelTargeta = new System.Windows.Forms.Label();
            this.textBoxTarjeta = new System.Windows.Forms.TextBox();
            this.radioButtonAmerican = new System.Windows.Forms.RadioButton();
            this.radioButtonMaster = new System.Windows.Forms.RadioButton();
            this.radioButtonVisa = new System.Windows.Forms.RadioButton();
            this.labelElige = new System.Windows.Forms.Label();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.labelCVV = new System.Windows.Forms.Label();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPagar
            // 
            this.BtnPagar.BackColor = System.Drawing.Color.Black;
            this.BtnPagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPagar.ForeColor = System.Drawing.Color.White;
            this.BtnPagar.Location = new System.Drawing.Point(903, 512);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(127, 59);
            this.BtnPagar.TabIndex = 0;
            this.BtnPagar.Text = "Pagar";
            this.BtnPagar.UseVisualStyleBackColor = false;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // pictureBoxLogoTarjeta
            // 
            this.pictureBoxLogoTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogoTarjeta.Image = global::WindowsProyectoFinal.Properties.Resources.logostarjetas;
            this.pictureBoxLogoTarjeta.Location = new System.Drawing.Point(508, 156);
            this.pictureBoxLogoTarjeta.Name = "pictureBoxLogoTarjeta";
            this.pictureBoxLogoTarjeta.Size = new System.Drawing.Size(274, 63);
            this.pictureBoxLogoTarjeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoTarjeta.TabIndex = 1;
            this.pictureBoxLogoTarjeta.TabStop = false;
            // 
            // labelNombreTarjeta
            // 
            this.labelNombreTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreTarjeta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreTarjeta.ForeColor = System.Drawing.Color.White;
            this.labelNombreTarjeta.Location = new System.Drawing.Point(20, 134);
            this.labelNombreTarjeta.Name = "labelNombreTarjeta";
            this.labelNombreTarjeta.Size = new System.Drawing.Size(280, 41);
            this.labelNombreTarjeta.TabIndex = 2;
            this.labelNombreTarjeta.Text = "Nombre asociado a  la tarjeta";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.DimGray;
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.ForeColor = System.Drawing.Color.White;
            this.textBoxNombre.Location = new System.Drawing.Point(25, 173);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(275, 19);
            this.textBoxNombre.TabIndex = 3;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.White;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(448, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(193, 32);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Pago con tarjeta";
            // 
            // labelTargeta
            // 
            this.labelTargeta.AutoSize = true;
            this.labelTargeta.BackColor = System.Drawing.Color.Transparent;
            this.labelTargeta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTargeta.ForeColor = System.Drawing.Color.White;
            this.labelTargeta.Location = new System.Drawing.Point(20, 248);
            this.labelTargeta.Name = "labelTargeta";
            this.labelTargeta.Size = new System.Drawing.Size(256, 28);
            this.labelTargeta.TabIndex = 5;
            this.labelTargeta.Text = "Ingresa el numero de tarjeta";
            // 
            // textBoxTarjeta
            // 
            this.textBoxTarjeta.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBoxTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTarjeta.ForeColor = System.Drawing.Color.White;
            this.textBoxTarjeta.Location = new System.Drawing.Point(25, 288);
            this.textBoxTarjeta.Name = "textBoxTarjeta";
            this.textBoxTarjeta.Size = new System.Drawing.Size(255, 19);
            this.textBoxTarjeta.TabIndex = 6;
            // 
            // radioButtonAmerican
            // 
            this.radioButtonAmerican.AutoSize = true;
            this.radioButtonAmerican.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAmerican.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAmerican.ForeColor = System.Drawing.Color.White;
            this.radioButtonAmerican.Location = new System.Drawing.Point(392, 278);
            this.radioButtonAmerican.Name = "radioButtonAmerican";
            this.radioButtonAmerican.Size = new System.Drawing.Size(175, 29);
            this.radioButtonAmerican.TabIndex = 7;
            this.radioButtonAmerican.TabStop = true;
            this.radioButtonAmerican.Text = "American Express";
            this.radioButtonAmerican.UseVisualStyleBackColor = false;
            // 
            // radioButtonMaster
            // 
            this.radioButtonMaster.AutoSize = true;
            this.radioButtonMaster.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMaster.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMaster.ForeColor = System.Drawing.Color.White;
            this.radioButtonMaster.Location = new System.Drawing.Point(614, 282);
            this.radioButtonMaster.Name = "radioButtonMaster";
            this.radioButtonMaster.Size = new System.Drawing.Size(128, 29);
            this.radioButtonMaster.TabIndex = 8;
            this.radioButtonMaster.TabStop = true;
            this.radioButtonMaster.Text = "MasterCard";
            this.radioButtonMaster.UseVisualStyleBackColor = false;
            // 
            // radioButtonVisa
            // 
            this.radioButtonVisa.AutoSize = true;
            this.radioButtonVisa.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonVisa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonVisa.ForeColor = System.Drawing.Color.White;
            this.radioButtonVisa.Location = new System.Drawing.Point(822, 278);
            this.radioButtonVisa.Name = "radioButtonVisa";
            this.radioButtonVisa.Size = new System.Drawing.Size(69, 29);
            this.radioButtonVisa.TabIndex = 9;
            this.radioButtonVisa.TabStop = true;
            this.radioButtonVisa.Text = "Visa";
            this.radioButtonVisa.UseVisualStyleBackColor = false;
            // 
            // labelElige
            // 
            this.labelElige.AutoSize = true;
            this.labelElige.BackColor = System.Drawing.Color.Transparent;
            this.labelElige.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElige.ForeColor = System.Drawing.Color.White;
            this.labelElige.Location = new System.Drawing.Point(532, 232);
            this.labelElige.Name = "labelElige";
            this.labelElige.Size = new System.Drawing.Size(183, 25);
            this.labelElige.TabIndex = 10;
            this.labelElige.Text = "Elige el tipo de tarjeta";
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.BackColor = System.Drawing.Color.White;
            this.buttonRegresar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresar.ForeColor = System.Drawing.Color.Black;
            this.buttonRegresar.Location = new System.Drawing.Point(25, 533);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(107, 38);
            this.buttonRegresar.TabIndex = 11;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = false;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.Color.Transparent;
            this.labelFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(20, 361);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(271, 28);
            this.labelFecha.TabIndex = 12;
            this.labelFecha.Text = "Fecha de expiracion (MM/AA)";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBoxFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFecha.ForeColor = System.Drawing.Color.White;
            this.textBoxFecha.Location = new System.Drawing.Point(25, 421);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(100, 19);
            this.textBoxFecha.TabIndex = 13;
            // 
            // labelCVV
            // 
            this.labelCVV.AutoSize = true;
            this.labelCVV.BackColor = System.Drawing.Color.Transparent;
            this.labelCVV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCVV.ForeColor = System.Drawing.Color.White;
            this.labelCVV.Location = new System.Drawing.Point(420, 361);
            this.labelCVV.Name = "labelCVV";
            this.labelCVV.Size = new System.Drawing.Size(249, 28);
            this.labelCVV.TabIndex = 14;
            this.labelCVV.Text = "Codigo de seguridad (CVV)";
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBoxCVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCVV.ForeColor = System.Drawing.Color.White;
            this.textBoxCVV.Location = new System.Drawing.Point(425, 421);
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(100, 19);
            this.textBoxCVV.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsProyectoFinal.Properties.Resources.Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(903, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::WindowsProyectoFinal.Properties.Resources.FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxCVV);
            this.Controls.Add(this.labelCVV);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.labelElige);
            this.Controls.Add(this.radioButtonVisa);
            this.Controls.Add(this.radioButtonMaster);
            this.Controls.Add(this.radioButtonAmerican);
            this.Controls.Add(this.textBoxTarjeta);
            this.Controls.Add(this.labelTargeta);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombreTarjeta);
            this.Controls.Add(this.pictureBoxLogoTarjeta);
            this.Controls.Add(this.BtnPagar);
            this.Name = "Compra";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.PictureBox pictureBoxLogoTarjeta;
        private System.Windows.Forms.Label labelNombreTarjeta;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelTargeta;
        private System.Windows.Forms.TextBox textBoxTarjeta;
        private System.Windows.Forms.RadioButton radioButtonAmerican;
        private System.Windows.Forms.RadioButton radioButtonMaster;
        private System.Windows.Forms.RadioButton radioButtonVisa;
        private System.Windows.Forms.Label labelElige;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label labelCVV;
        private System.Windows.Forms.TextBox textBoxCVV;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}