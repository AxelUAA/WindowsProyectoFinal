namespace WindowsProyectoFinal
{
    partial class GraficosVentas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonActualizarVentas = new System.Windows.Forms.Button();
            this.chartPrecio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStock
            // 
            this.chartStock.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.chartStock.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartStock.Legends.Add(legend3);
            this.chartStock.Location = new System.Drawing.Point(114, 106);
            this.chartStock.Name = "chartStock";
            this.chartStock.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartStock.Series.Add(series3);
            this.chartStock.Size = new System.Drawing.Size(530, 435);
            this.chartStock.TabIndex = 0;
            this.chartStock.Text = "chart1";
            // 
            // buttonActualizarVentas
            // 
            this.buttonActualizarVentas.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonActualizarVentas.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizarVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonActualizarVentas.Location = new System.Drawing.Point(77, 648);
            this.buttonActualizarVentas.Name = "buttonActualizarVentas";
            this.buttonActualizarVentas.Size = new System.Drawing.Size(189, 76);
            this.buttonActualizarVentas.TabIndex = 1;
            this.buttonActualizarVentas.Text = "ACTUALIZAR DATOS";
            this.buttonActualizarVentas.UseVisualStyleBackColor = false;
            this.buttonActualizarVentas.Click += new System.EventHandler(this.buttonActualizarVentas_Click);
            // 
            // chartPrecio
            // 
            this.chartPrecio.BorderlineColor = System.Drawing.Color.Black;
            chartArea4.Name = "ChartArea1";
            this.chartPrecio.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartPrecio.Legends.Add(legend4);
            this.chartPrecio.Location = new System.Drawing.Point(693, 106);
            this.chartPrecio.Name = "chartPrecio";
            this.chartPrecio.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartPrecio.Series.Add(series4);
            this.chartPrecio.Size = new System.Drawing.Size(530, 435);
            this.chartPrecio.TabIndex = 2;
            this.chartPrecio.Text = "chart1";
            // 
            // GraficosVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1295, 761);
            this.Controls.Add(this.chartPrecio);
            this.Controls.Add(this.buttonActualizarVentas);
            this.Controls.Add(this.chartStock);
            this.Name = "GraficosVentas";
            this.Text = "GraficosVentas";
            this.Load += new System.EventHandler(this.GraficosVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStock;
        private System.Windows.Forms.Button buttonActualizarVentas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrecio;
    }
}