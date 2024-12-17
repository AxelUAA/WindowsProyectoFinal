using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsProyectoFinal
{
    public partial class ListadoProductosAdmin : Form
    {
        string cadenaConexion = "Server=localhost;Database=proyecto;Uid=root;Pwd=;";

        public ListadoProductosAdmin()
        {
            InitializeComponent();
        }

        private void ListadoProductosAdmin_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            panelProductos.Controls.Clear();
            panelProductos.AutoScroll = true;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string query = "SELECT nombreimagen, precio, stock FROM productos ORDER BY stock ASC";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            int y = 10;
                            while (reader.Read())
                            {
                                Panel productoPanel = new Panel
                                {
                                    Size = new Size(500, 90),
                                    Location = new Point(10, y),
                                    BackColor = Color.Black,
                                    BorderStyle = BorderStyle.None
                                };

                                Label lblNombre = new Label
                                {
                                    Text = $"Nombre: {reader["nombreimagen"]}",
                                    Location = new Point(20, 20),
                                    AutoSize = true,
                                    ForeColor = Color.White,
                                    Font = new Font("Arial", 10, FontStyle.Bold)
                                };

                                Label lblPrecio = new Label
                                {
                                    Text = $"Precio: ${reader["precio"]}",
                                    Location = new Point(350, 20),
                                    AutoSize = true,
                                    ForeColor = Color.White,
                                    Font = new Font("Arial", 10, FontStyle.Bold)
                                };

                                Label lblStock = new Label
                                {
                                    Text = $"Stock: {reader["stock"]}",
                                    Location = new Point(20, 50),
                                    AutoSize = true,
                                    ForeColor = Color.White,
                                    Font = new Font("Arial", 10, FontStyle.Bold)
                                };

                                Panel separator = new Panel
                                {
                                    Size = new Size(480, 1),
                                    Location = new Point(10, 88),
                                    BackColor = Color.White
                                };

                                productoPanel.Controls.Add(lblNombre);
                                productoPanel.Controls.Add(lblPrecio);
                                productoPanel.Controls.Add(lblStock);
                                productoPanel.Controls.Add(separator);

                                panelProductos.Controls.Add(productoPanel);

                                y += 100;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }
    }
}

