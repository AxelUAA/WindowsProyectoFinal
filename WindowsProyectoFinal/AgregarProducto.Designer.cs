namespace WindowsProyectoFinal
{
    partial class AgregarProducto
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
            this.panel1AggPro = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.pictureBoxProducto = new System.Windows.Forms.PictureBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.btnCanAgregar = new System.Windows.Forms.Button();
            this.btnSalirDeAgregar = new System.Windows.Forms.Button();
            this.panel1AggPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1AggPro
            // 
            this.panel1AggPro.Controls.Add(this.pictureBox1);
            this.panel1AggPro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1AggPro.Location = new System.Drawing.Point(0, 0);
            this.panel1AggPro.Name = "panel1AggPro";
            this.panel1AggPro.Size = new System.Drawing.Size(176, 860);
            this.panel1AggPro.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::WindowsProyectoFinal.Properties.Resources.Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(176, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 132);
            this.panel1.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtId.Location = new System.Drawing.Point(425, 214);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(304, 30);
            this.txtId.TabIndex = 2;
            this.txtId.Text = "ID";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDescripcion.Location = new System.Drawing.Point(425, 276);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(304, 30);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Text = "Descripcion";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPrecio.Location = new System.Drawing.Point(425, 345);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(304, 30);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.Text = "Precio";
            // 
            // pictureBoxProducto
            // 
            this.pictureBoxProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBoxProducto.Location = new System.Drawing.Point(425, 536);
            this.pictureBoxProducto.Name = "pictureBoxProducto";
            this.pictureBoxProducto.Size = new System.Drawing.Size(304, 176);
            this.pictureBoxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProducto.TabIndex = 5;
            this.pictureBoxProducto.TabStop = false;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargarImagen.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargarImagen.Location = new System.Drawing.Point(501, 736);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(170, 38);
            this.btnCargarImagen.TabIndex = 6;
            this.btnCargarImagen.Text = "Seleccionar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // txtExistencias
            // 
            this.txtExistencias.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtExistencias.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistencias.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtExistencias.Location = new System.Drawing.Point(425, 421);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(304, 30);
            this.txtExistencias.TabIndex = 7;
            this.txtExistencias.Text = "Existencias";
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardarProducto.Location = new System.Drawing.Point(965, 228);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(228, 97);
            this.btnGuardarProducto.TabIndex = 8;
            this.btnGuardarProducto.Text = "AGREGAR";
            this.btnGuardarProducto.UseVisualStyleBackColor = false;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // btnCanAgregar
            // 
            this.btnCanAgregar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCanAgregar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCanAgregar.Location = new System.Drawing.Point(965, 354);
            this.btnCanAgregar.Name = "btnCanAgregar";
            this.btnCanAgregar.Size = new System.Drawing.Size(228, 97);
            this.btnCanAgregar.TabIndex = 9;
            this.btnCanAgregar.Text = "CANCELAR";
            this.btnCanAgregar.UseVisualStyleBackColor = false;
            this.btnCanAgregar.Click += new System.EventHandler(this.btnCanAgregar_Click);
            // 
            // btnSalirDeAgregar
            // 
            this.btnSalirDeAgregar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSalirDeAgregar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirDeAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalirDeAgregar.Location = new System.Drawing.Point(953, 677);
            this.btnSalirDeAgregar.Name = "btnSalirDeAgregar";
            this.btnSalirDeAgregar.Size = new System.Drawing.Size(228, 97);
            this.btnSalirDeAgregar.TabIndex = 10;
            this.btnSalirDeAgregar.Text = "SALIR";
            this.btnSalirDeAgregar.UseVisualStyleBackColor = false;
            this.btnSalirDeAgregar.Click += new System.EventHandler(this.btnSalirDeAgregar_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::WindowsProyectoFinal.Properties.Resources.Fondo5;
            this.ClientSize = new System.Drawing.Size(1385, 860);
            this.Controls.Add(this.btnSalirDeAgregar);
            this.Controls.Add(this.btnCanAgregar);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.pictureBoxProducto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel1AggPro);
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            this.panel1AggPro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1AggPro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.PictureBox pictureBoxProducto;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.Button btnCanAgregar;
        private System.Windows.Forms.Button btnSalirDeAgregar;
    }
}