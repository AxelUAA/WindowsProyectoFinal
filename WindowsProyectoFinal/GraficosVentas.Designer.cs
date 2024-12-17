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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonRegresarVentas = new System.Windows.Forms.Button();
            this.chartPrecio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStock
            // 
            this.chartStock.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chartStock.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStock.Legends.Add(legend1);
            this.chartStock.Location = new System.Drawing.Point(114, 106);
            this.chartStock.Name = "chartStock";
            this.chartStock.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStock.Series.Add(series1);
            this.chartStock.Size = new System.Drawing.Size(530, 435);
            this.chartStock.TabIndex = 0;
            this.chartStock.Text = "chart1";
            // 
            // buttonRegresarVentas
            // 
            this.buttonRegresarVentas.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonRegresarVentas.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresarVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegresarVentas.Location = new System.Drawing.Point(77, 648);
            this.buttonRegresarVentas.Name = "buttonRegresarVentas";
            this.buttonRegresarVentas.Size = new System.Drawing.Size(189, 76);
            this.buttonRegresarVentas.TabIndex = 1;
            this.buttonRegresarVentas.Text = "Regresar";
            this.buttonRegresarVentas.UseVisualStyleBackColor = false;
            this.buttonRegresarVentas.Click += new System.EventHandler(this.buttonRegresarVentas_Click);
            // 
            // chartPrecio
            // 
            this.chartPrecio.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.chartPrecio.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPrecio.Legends.Add(legend2);
            this.chartPrecio.Location = new System.Drawing.Point(693, 106);
            this.chartPrecio.Name = "chartPrecio";
            this.chartPrecio.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartPrecio.Series.Add(series2);
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
            this.Controls.Add(this.buttonRegresarVentas);
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
        private System.Windows.Forms.Button buttonRegresarVentas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrecio;
    }
}