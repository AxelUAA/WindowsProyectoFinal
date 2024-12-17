using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsProyectoFinal
{
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarParaEliminar_Click(object sender, EventArgs e)
        {
            string idProducto = txtBoxIdEliminar.Text;
            

            if (string.IsNullOrEmpty(idProducto))
            {
                MessageBox.Show("Por favor, ingrese un código de producto.");
                return;
            }

            try
            {
                string connectionString = "Server=localhost;Database=proyecto;Uid=root;Pwd=;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT nombreimagen, precio, stock FROM productos WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idProducto);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblNombreProducto.Text = "Nombre: " + reader.GetString("nombreimagen");
                                lblPrecioProducto.Text = "Precio: " + reader.GetInt32("precio").ToString();
                                lblStockProducto.Text = "Stock: " + reader.GetInt32("stock").ToString();
                                btnEliminar.Enabled = true; 
                            }
                            else
                            {
                                MessageBox.Show("Producto no encontrado.");
                                lblNombreProducto.Text = "Nombre: (no encontrado)";
                                lblPrecioProducto.Text = "Precio: (no encontrado)";
                                lblStockProducto.Text = "Stock: (no encontrado)";
                                btnEliminar.Enabled = false;  
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string IdProducto = txtBoxIdEliminar.Text;

            if (string.IsNullOrEmpty(IdProducto))
            {
                MessageBox.Show("Por favor, ingrese un código de producto.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Seguro que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=proyecto;Uid=root;Pwd=;"))
                    {
                        conn.Open();
                        string countQuery = "SELECT COUNT(*) FROM productos";
                        using (MySqlCommand countCmd = new MySqlCommand(countQuery, conn))
                        {
                            int totalProductos = Convert.ToInt32(countCmd.ExecuteScalar());

                            if (totalProductos <= 6)
                            {
                                MessageBox.Show("No puedes eliminar este producto. Deben permanecer al menos 6 productos .");
                                return;
                            }
                        }

                        string query = "DELETE FROM productos WHERE id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", IdProducto);

                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Producto eliminado correctamente.");
                                lblNombreProducto.Text = "Nombre: (eliminado)";
                                lblPrecioProducto.Text = "Precio: (eliminado)";
                                lblStockProducto.Text = "Stock: (eliminado)";
                                btnEliminar.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el producto para eliminar.");
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
                }
            }
        }

    }
}
