using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsProyectoFinal
{
    public partial class GraficosVentas : Form
    {
        private string connectionServer = "Server=localhost;Database=proyecto;Uid=root;Pwd=;";

        public GraficosVentas()
        {
            InitializeComponent();
        }

        private void GraficosVentas_Load(object sender, EventArgs e)
        {
            CargarDatosYGenerarGraficas();
        }

        private void CargarDatosYGenerarGraficas()
        {
            try
            {
                List<string> nombres = new List<string>();
                List<int> stock = new List<int>();
                List<decimal> precio = new List<decimal>();

                // Conexión y consulta a la base de datos
                using (MySqlConnection conn = new MySqlConnection(connectionServer))
                {
                    conn.Open();
                    string query = "SELECT nombreimagen, stock, precio FROM productos;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        nombres.Add(reader["nombreimagen"].ToString());
                        stock.Add(Convert.ToInt32(reader["stock"]));
                        precio.Add(Convert.ToDecimal(reader["precio"]));
                    }
                    conn.Close();
                }

                // Generar los gráficos
                GenerarGraficaStock(nombres, stock);
                GenerarGraficaPrecio(nombres, precio);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
            }
        }

        private void GenerarGraficaStock(List<string> nombres, List<int> stocks)
        {
            // Limpiar gráfico anterior
            chartStock.Series.Clear();
            chartStock.Titles.Clear();

            // Configurar título con estilo
            var titulo = chartStock.Titles.Add("Stock de Productos");
            titulo.Font = new Font("Arial", 16, FontStyle.Bold);
            titulo.ForeColor = Color.DarkBlue;

            // Crear la serie de Stock
            var serieStock = new System.Windows.Forms.DataVisualization.Charting.Series("Stock");
            serieStock.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            serieStock.Color = Color.CornflowerBlue;
            serieStock.IsValueShownAsLabel = true;
            serieStock.Font = new Font("Arial", 10, FontStyle.Bold);

            // Añadir datos a la serie
            for (int i = 0; i < nombres.Count; i++)
            {
                var pointIndex = serieStock.Points.AddXY(nombres[i], stocks[i]);
                serieStock.Points[pointIndex].Color = Color.FromArgb(100 + i * 10, 120, 200); // Colores dinámicos
            }

            // Agregar serie al gráfico
            chartStock.Series.Add(serieStock);

            // Configurar ejes con estilo
            chartStock.ChartAreas[0].AxisX.Title = "Productos";
            chartStock.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartStock.ChartAreas[0].AxisY.Title = "Cantidad en Stock";
            chartStock.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartStock.ChartAreas[0].RecalculateAxesScale();
        }

        private void GenerarGraficaPrecio(List<string> nombres, List<decimal> precios)
        {
            // Limpiar gráfico anterior
            chartPrecio.Series.Clear();
            chartPrecio.Titles.Clear();

            // Configurar título con estilo
            var titulo = chartPrecio.Titles.Add("Precios de Productos");
            titulo.Font = new Font("Arial", 16, FontStyle.Bold);
            titulo.ForeColor = Color.DarkRed;

            // Crear la serie de Precio
            var seriePrecio = new System.Windows.Forms.DataVisualization.Charting.Series("Precio");
            seriePrecio.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            seriePrecio.Color = Color.OrangeRed;
            seriePrecio.IsValueShownAsLabel = true;
            seriePrecio.Font = new Font("Arial", 10, FontStyle.Bold);

            // Añadir datos a la serie
            for (int i = 0; i < nombres.Count; i++)
            {
                var pointIndex = seriePrecio.Points.AddXY(nombres[i], precios[i]);
                seriePrecio.Points[pointIndex].Color = Color.FromArgb(200, 100 + i * 10, 100); // Colores dinámicos
            }

            // Agregar serie al gráfico
            chartPrecio.Series.Add(seriePrecio);

            // Configurar ejes con estilo
            chartPrecio.ChartAreas[0].AxisX.Title = "Productos";
            chartPrecio.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartPrecio.ChartAreas[0].AxisY.Title = "Precio";
            chartPrecio.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartPrecio.ChartAreas[0].RecalculateAxesScale();
        }

        private void buttonActualizarVentas_Click(object sender, EventArgs e)
        {
            
        }
    }
}

