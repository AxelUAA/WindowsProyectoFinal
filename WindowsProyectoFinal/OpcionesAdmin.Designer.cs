namespace WindowsProyectoFinal
{
    partial class OpcionesAdmin
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.btnRegOAdmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bopcadmin = new System.Windows.Forms.Label();
            this.btnDarAlta = new System.Windows.Forms.Button();
            this.btnEliminarPro = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnGraficos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.btnRegOAdmin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 626);
            this.panel1.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.Black;
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.White;
            this.textBoxNombre.Location = new System.Drawing.Point(-2, 207);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(244, 27);
            this.textBoxNombre.TabIndex = 4;
            // 
            // btnRegOAdmin
            // 
            this.btnRegOAdmin.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRegOAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegOAdmin.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegOAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegOAdmin.Location = new System.Drawing.Point(0, 555);
            this.btnRegOAdmin.Name = "btnRegOAdmin";
            this.btnRegOAdmin.Size = new System.Drawing.Size(242, 71);
            this.btnRegOAdmin.TabIndex = 2;
            this.btnRegOAdmin.Text = "LOGOUT";
            this.btnRegOAdmin.UseVisualStyleBackColor = false;
            this.btnRegOAdmin.Click += new System.EventHandler(this.btnRegOAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::WindowsProyectoFinal.Properties.Resources._77_shop;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bopcadmin
            // 
            this.bopcadmin.AutoSize = true;
            this.bopcadmin.Font = new System.Drawing.Font("Segoe UI", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bopcadmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bopcadmin.Location = new System.Drawing.Point(480, 36);
            this.bopcadmin.Name = "bopcadmin";
            this.bopcadmin.Size = new System.Drawing.Size(572, 59);
            this.bopcadmin.TabIndex = 1;
            this.bopcadmin.Text = "Opciones de Administrador";
            this.bopcadmin.Click += new System.EventHandler(this.bopcadmin_Click);
            // 
            // btnDarAlta
            // 
            this.btnDarAlta.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDarAlta.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarAlta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDarAlta.Location = new System.Drawing.Point(617, 152);
            this.btnDarAlta.Name = "btnDarAlta";
            this.btnDarAlta.Size = new System.Drawing.Size(293, 73);
            this.btnDarAlta.TabIndex = 2;
            this.btnDarAlta.Text = "Dar de Alta Producto";
            this.btnDarAlta.UseVisualStyleBackColor = false;
            this.btnDarAlta.Click += new System.EventHandler(this.btnDarAlta_Click);
            // 
            // btnEliminarPro
            // 
            this.btnEliminarPro.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarPro.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarPro.Location = new System.Drawing.Point(617, 261);
            this.btnEliminarPro.Name = "btnEliminarPro";
            this.btnEliminarPro.Size = new System.Drawing.Size(293, 73);
            this.btnEliminarPro.TabIndex = 3;
            this.btnEliminarPro.Text = "Eliminar Producto";
            this.btnEliminarPro.UseVisualStyleBackColor = false;
            this.btnEliminarPro.Click += new System.EventHandler(this.btnEliminarPro_Click);
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnListado.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListado.Location = new System.Drawing.Point(617, 375);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(293, 73);
            this.btnListado.TabIndex = 4;
            this.btnListado.Text = "Listado de Productos";
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // btnGraficos
            // 
            this.btnGraficos.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGraficos.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGraficos.Location = new System.Drawing.Point(617, 491);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(293, 73);
            this.btnGraficos.TabIndex = 5;
            this.btnGraficos.Text = "Graficos de Ventas";
            this.btnGraficos.UseVisualStyleBackColor = false;
            this.btnGraficos.Click += new System.EventHandler(this.btnGraficos_Click);
            // 
            // OpcionesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1293, 626);
            this.Controls.Add(this.btnGraficos);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.btnEliminarPro);
            this.Controls.Add(this.btnDarAlta);
            this.Controls.Add(this.bopcadmin);
            this.Controls.Add(this.panel1);
            this.Name = "OpcionesAdmin";
            this.Text = "OpcionesAdmin";
            this.Load += new System.EventHandler(this.OpcionesAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label bopcadmin;
        private System.Windows.Forms.Button btnRegOAdmin;
        private System.Windows.Forms.Button btnDarAlta;
        private System.Windows.Forms.Button btnEliminarPro;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnGraficos;
        private System.Windows.Forms.TextBox textBoxNombre;
    }
}