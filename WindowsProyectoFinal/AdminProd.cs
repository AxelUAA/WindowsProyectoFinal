using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProyectoFinal
{
    public class AdminProd
    {
        private MySqlConnection connection;

        public AdminProd()
        {
            this.Connect();
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        public List<string> ConsultaNombresImagen()
        {
            List<string> nombresImagen = new List<string>();

            try
            {
                // Consulta para obtener todos los valores de la columna nombreimagen
                string query = "SELECT `nombreimagen` FROM `productos`;";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Obtener el valor de la columna nombreimagen
                    string nombreimagen = Convert.ToString(reader["nombreimagen"]) ?? "";

                    // Agregar a la lista
                    nombresImagen.Add(nombreimagen);
                }

                // Cerrar el lector
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }

            return nombresImagen;
        }

        public void Connect()
        {
            string cadena = "Server=localhost; Database=proyecto; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
                MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Productos ConsultaProducto(string nombreProducto)
        {
            Productos producto = null;

            try
            {
                // Consulta SQL para obtener la información del producto
                string query = "SELECT `descripcion`, `precio`, `stock` FROM `productos` WHERE `nombreimagen` = @NombreImagen;";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                command.Parameters.AddWithValue("@NombreImagen", nombreProducto);

                // Ejecutar la consulta y leer los datos
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    producto = new Productos(
                        0,                                      // ID (puedes ajustarlo si es necesario)
                        nombreProducto,                         // NombreImagen
                        reader["descripcion"].ToString(),       // Descripción
                        Convert.ToInt32(reader["precio"]),    // Precio
                        Convert.ToInt32(reader["stock"])        // Stock
                    );
                }

                reader.Close(); // Cerrar el lector
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return producto;
        }

        public bool ActualizarStock(string nombreImagen, int nuevoStock)
        {
            try
            {
                // Consulta SQL para actualizar el stock
                string query = "UPDATE productos SET stock = @nuevoStock WHERE nombreimagen = @nombreImagen;";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Asignar parámetros
                command.Parameters.AddWithValue("@nuevoStock", nuevoStock);
                command.Parameters.AddWithValue("@nombreImagen", nombreImagen);

                // Ejecutar la consulta
                int filasAfectadas = command.ExecuteNonQuery();

                // Si al menos una fila fue afectada, la actualización fue exitosa
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}
