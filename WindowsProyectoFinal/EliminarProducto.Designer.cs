namespace WindowsProyectoFinal
{
    partial class EliminarProducto
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
            this.panel1Eliminar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2Eliminar = new System.Windows.Forms.FlowLayoutPanel();
            this.pBoxLogoEliminar = new System.Windows.Forms.PictureBox();
            this.labeltitulo = new System.Windows.Forms.Label();
            this.labelEminarAviso = new System.Windows.Forms.Label();
            this.txtBoxIdEliminar = new System.Windows.Forms.TextBox();
            this.btnBuscarParaEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblStockProducto = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelarEliminacion = new System.Windows.Forms.Button();
            this.panel1Eliminar.SuspendLayout();
            this.flowLayoutPanel2Eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogoEliminar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1Eliminar
            // 
            this.panel1Eliminar.Controls.Add(this.pBoxLogoEliminar);
            this.panel1Eliminar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1Eliminar.Location = new System.Drawing.Point(0, 0);
            this.panel1Eliminar.Name = "panel1Eliminar";
            this.panel1Eliminar.Size = new System.Drawing.Size(216, 969);
            this.panel1Eliminar.TabIndex = 0;
            // 
            // flowLayoutPanel2Eliminar
            // 
            this.flowLayoutPanel2Eliminar.Controls.Add(this.labeltitulo);
            this.flowLayoutPanel2Eliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2Eliminar.Location = new System.Drawing.Point(216, 0);
            this.flowLayoutPanel2Eliminar.Name = "flowLayoutPanel2Eliminar";
            this.flowLayoutPanel2Eliminar.Size = new System.Drawing.Size(1231, 132);
            this.flowLayoutPanel2Eliminar.TabIndex = 1;
            // 
            // pBoxLogoEliminar
            // 
            this.pBoxLogoEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBoxLogoEliminar.Image = global::WindowsProyectoFinal.Properties.Resources._77_shop;
            this.pBoxLogoEliminar.Location = new System.Drawing.Point(0, 0);
            this.pBoxLogoEliminar.Name = "pBoxLogoEliminar";
            this.pBoxLogoEliminar.Size = new System.Drawing.Size(216, 207);
            this.pBoxLogoEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLogoEliminar.TabIndex = 0;
            this.pBoxLogoEliminar.TabStop = false;
            // 
            // labeltitulo
            // 
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labeltitulo.Location = new System.Drawing.Point(3, 0);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Padding = new System.Windows.Forms.Padding(100, 20, 0, 0);
            this.labeltitulo.Size = new System.Drawing.Size(1062, 101);
            this.labeltitulo.TabIndex = 0;
            this.labeltitulo.Text = "CALIDAD QUE DEFINE TU ESTILO";
            // 
            // labelEminarAviso
            // 
            this.labelEminarAviso.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEminarAviso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEminarAviso.Location = new System.Drawing.Point(619, 156);
            this.labelEminarAviso.Name = "labelEminarAviso";
            this.labelEminarAviso.Size = new System.Drawing.Size(442, 51);
            this.labelEminarAviso.TabIndex = 2;
            this.labelEminarAviso.Text = "ELIMINAR PRODUCTO";
            // 
            // txtBoxIdEliminar
            // 
            this.txtBoxIdEliminar.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIdEliminar.Location = new System.Drawing.Point(323, 277);
            this.txtBoxIdEliminar.Name = "txtBoxIdEliminar";
            this.txtBoxIdEliminar.Size = new System.Drawing.Size(279, 51);
            this.txtBoxIdEliminar.TabIndex = 3;
            // 
            // btnBuscarParaEliminar
            // 
            this.btnBuscarParaEliminar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBuscarParaEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarParaEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarParaEliminar.Location = new System.Drawing.Point(323, 372);
            this.btnBuscarParaEliminar.Name = "btnBuscarParaEliminar";
            this.btnBuscarParaEliminar.Size = new System.Drawing.Size(279, 43);
            this.btnBuscarParaEliminar.TabIndex = 4;
            this.btnBuscarParaEliminar.Text = "BUSCAR PRODUCTO";
            this.btnBuscarParaEliminar.UseVisualStyleBackColor = false;
            this.btnBuscarParaEliminar.Click += new System.EventHandler(this.btnBuscarParaEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lblStockProducto);
            this.panel1.Controls.Add(this.lblPrecioProducto);
            this.panel1.Controls.Add(this.lblNombreProducto);
            this.panel1.Location = new System.Drawing.Point(909, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 555);
            this.panel1.TabIndex = 5;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(67, 24);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(141, 38);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre: ";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProducto.Location = new System.Drawing.Point(71, 102);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(106, 38);
            this.lblPrecioProducto.TabIndex = 1;
            this.lblPrecioProducto.Text = "Precio:";
            this.lblPrecioProducto.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStockProducto
            // 
            this.lblStockProducto.AutoSize = true;
            this.lblStockProducto.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockProducto.Location = new System.Drawing.Point(71, 182);
            this.lblStockProducto.Name = "lblStockProducto";
            this.lblStockProducto.Size = new System.Drawing.Size(98, 38);
            this.lblStockProducto.TabIndex = 2;
            this.lblStockProducto.Text = "Stock:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1242, 858);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 56);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelarEliminacion
            // 
            this.btnCancelarEliminacion.BackColor = System.Drawing.Color.Snow;
            this.btnCancelarEliminacion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEliminacion.Location = new System.Drawing.Point(909, 858);
            this.btnCancelarEliminacion.Name = "btnCancelarEliminacion";
            this.btnCancelarEliminacion.Size = new System.Drawing.Size(133, 56);
            this.btnCancelarEliminacion.TabIndex = 7;
            this.btnCancelarEliminacion.Text = "Cancelar";
            this.btnCancelarEliminacion.UseVisualStyleBackColor = false;
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1447, 969);
            this.Controls.Add(this.btnCancelarEliminacion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscarParaEliminar);
            this.Controls.Add(this.txtBoxIdEliminar);
            this.Controls.Add(this.labelEminarAviso);
            this.Controls.Add(this.flowLayoutPanel2Eliminar);
            this.Controls.Add(this.panel1Eliminar);
            this.Name = "EliminarProducto";
            this.Text = "EliminarProducto";
            this.Load += new System.EventHandler(this.EliminarProducto_Load);
            this.panel1Eliminar.ResumeLayout(false);
            this.flowLayoutPanel2Eliminar.ResumeLayout(false);
            this.flowLayoutPanel2Eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogoEliminar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1Eliminar;
        private System.Windows.Forms.PictureBox pBoxLogoEliminar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2Eliminar;
        private System.Windows.Forms.Label labeltitulo;
        private System.Windows.Forms.Label labelEminarAviso;
        private System.Windows.Forms.TextBox txtBoxIdEliminar;
        private System.Windows.Forms.Button btnBuscarParaEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblStockProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelarEliminacion;
    }
}