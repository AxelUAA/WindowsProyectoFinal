using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsProyectoFinal
{
    public partial class AgregarProducto : Form
    {
        private string rutaImagen = "";
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar Imagen";
                openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Mostrar la imagen en el PictureBox
                        pictureBoxProducto.Image = new Bitmap(openFileDialog.FileName);

                        // Guardar la ruta de la imagen
                        rutaImagen = openFileDialog.FileName;

                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Evento del botón para guardar el producto en la base de datos
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    // Convertir la imagen a un arreglo de bytes (BLOB)
                    byte[] imagenBytes = File.ReadAllBytes(rutaImagen);

                    using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=proyecto; User=root; Password=; SslMode=none;"))
                    {
                        connection.Open();
                        string query = "INSERT INTO proyecto (nombre, descripcion, precio, existencias, imagen) VALUES (@nombre, @descripcion, @precio, @existencias, @imagen)";

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            // Parámetros del producto
                            cmd.Parameters.AddWithValue("@nombre", txtId.Text);
                            cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                            cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
                            cmd.Parameters.AddWithValue("@existencias", Convert.ToInt32(txtExistencias.Text));
                            cmd.Parameters.AddWithValue("@imagen", imagenBytes); // Insertar imagen como BLOB

                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Validar que todos los campos estén llenos
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtId.Text) ||
                string.IsNullOrEmpty(txtDescripcion.Text) ||
                string.IsNullOrEmpty(txtPrecio.Text) ||
                string.IsNullOrEmpty(txtExistencias.Text) ||
                string.IsNullOrEmpty(rutaImagen))
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione una imagen.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCanAgregar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea cancelar y cerrar el formulario? Todos los datos se perderán.",
                                "Cancelar",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Limpiar TextBox
                txtId.Clear();
                txtDescripcion.Clear();
                txtPrecio.Clear();
                txtExistencias.Clear();


                // Limpiar PictureBox
                pictureBoxProducto.Image = null;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
    

