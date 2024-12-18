namespace WindowsProyectoFinal
{
    partial class ListadoProductosAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.btnRegOAdmin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnRegOAdmin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 719);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::WindowsProyectoFinal.Properties.Resources._77_shop;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(533, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Productos";
            // 
            // panelProductos
            // 
            this.panelProductos.AutoScroll = true;
            this.panelProductos.BackColor = System.Drawing.SystemColors.Info;
            this.panelProductos.Location = new System.Drawing.Point(425, 136);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(730, 537);
            this.panelProductos.TabIndex = 2;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.Black;
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.White;
            this.textBoxNombre.Location = new System.Drawing.Point(229, 92);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(391, 38);
            this.textBoxNombre.TabIndex = 14;
            // 
            // btnRegOAdmin
            // 
            this.btnRegOAdmin.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRegOAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegOAdmin.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegOAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegOAdmin.Location = new System.Drawing.Point(0, 648);
            this.btnRegOAdmin.Name = "btnRegOAdmin";
            this.btnRegOAdmin.Size = new System.Drawing.Size(223, 71);
            this.btnRegOAdmin.TabIndex = 3;
            this.btnRegOAdmin.Text = "LOGOUT";
            this.btnRegOAdmin.UseVisualStyleBackColor = false;
            this.btnRegOAdmin.Click += new System.EventHandler(this.btnRegOAdmin_Click);
            // 
            // ListadoProductosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1276, 719);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.panelProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ListadoProductosAdmin";
            this.Text = "ListadoProductosAdmin";
            this.Load += new System.EventHandler(this.ListadoProductosAdmin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button btnRegOAdmin;
    }
}