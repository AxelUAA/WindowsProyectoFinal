namespace WindowsProyectoFinal
{
    partial class Login
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
            this.panLogin1 = new System.Windows.Forms.Panel();
            this.panLogin2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSlogan = new System.Windows.Forms.Label();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.panLogin1.SuspendLayout();
            this.panLogin2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panLogin1
            // 
            this.panLogin1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panLogin1.Controls.Add(this.pictureBox1);
            this.panLogin1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLogin1.Location = new System.Drawing.Point(0, 0);
            this.panLogin1.Name = "panLogin1";
            this.panLogin1.Size = new System.Drawing.Size(170, 767);
            this.panLogin1.TabIndex = 0;
            // 
            // panLogin2
            // 
            this.panLogin2.Controls.Add(this.labelSlogan);
            this.panLogin2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLogin2.Location = new System.Drawing.Point(170, 0);
            this.panLogin2.Name = "panLogin2";
            this.panLogin2.Size = new System.Drawing.Size(1004, 104);
            this.panLogin2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::WindowsProyectoFinal.Properties.Resources._77_shop;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelSlogan
            // 
            this.labelSlogan.AutoSize = true;
            this.labelSlogan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSlogan.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlogan.Location = new System.Drawing.Point(3, 0);
            this.labelSlogan.Name = "labelSlogan";
            this.labelSlogan.Size = new System.Drawing.Size(639, 54);
            this.labelSlogan.TabIndex = 0;
            this.labelSlogan.Text = "CALIDAD QUE DEFINE TU ESTILO";
            this.labelSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.Location = new System.Drawing.Point(247, 121);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(821, 439);
            this.groupBoxLogin.TabIndex = 2;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "BIENVENIDO";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 767);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.panLogin2);
            this.Controls.Add(this.panLogin1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panLogin1.ResumeLayout(false);
            this.panLogin2.ResumeLayout(false);
            this.panLogin2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panLogin1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel panLogin2;
        private System.Windows.Forms.Label labelSlogan;
        private System.Windows.Forms.GroupBox groupBoxLogin;
    }
}