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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrito));
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bSalirLogin = new System.Windows.Forms.Button();
            this.bRegreLogin = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(377, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 181);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // bSalirLogin
            // 
            this.bSalirLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalirLogin.Location = new System.Drawing.Point(124, 681);
            this.bSalirLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bSalirLogin.Name = "bSalirLogin";
            this.bSalirLogin.Size = new System.Drawing.Size(171, 55);
            this.bSalirLogin.TabIndex = 4;
            this.bSalirLogin.Text = "REGRESAR";
            this.bSalirLogin.UseVisualStyleBackColor = true;
            // 
            // bRegreLogin
            // 
            this.bRegreLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegreLogin.Location = new System.Drawing.Point(876, 681);
            this.bRegreLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bRegreLogin.Name = "bRegreLogin";
            this.bRegreLogin.Size = new System.Drawing.Size(172, 55);
            this.bRegreLogin.TabIndex = 5;
            this.bRegreLogin.Text = "PAGAR";
            this.bRegreLogin.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox1.Location = new System.Drawing.Point(68, 188);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(788, 286);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsProyectoFinal.Properties.Resources.FONDO;
            this.ClientSize = new System.Drawing.Size(1172, 774);
            this.Controls.Add(this.bRegreLogin);
            this.Controls.Add(this.bSalirLogin);
            this.Controls.Add(this.groupBoxLogin);
            this.Name = "Carrito";
            this.Text = "Carrito";
            this.groupBoxLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bSalirLogin;
        private System.Windows.Forms.Button bRegreLogin;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}