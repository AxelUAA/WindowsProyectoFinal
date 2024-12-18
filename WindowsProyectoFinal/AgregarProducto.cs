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
using Microsoft.VisualBasic.ApplicationServices;

namespace WindowsProyectoFinal
{
    public partial class AgregarProducto : Form
    {
        private string rutaImagen;
        private string name;
        public AgregarProducto(string name)
        {
            InitializeComponent();
            this.name = name;
            this.textBoxNombre.Text = this.name;
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            SetPlaceholder(txtId, "Ingrese el ID del producto");
            SetPlaceholder(txtNombreProdAgregar, "Nombre del Producto");
            SetPlaceholder(txtDescripcion, "Descripcion del Producto");
            SetPlaceholder(txtExistencias, "Stock (existencias)");
            SetPlaceholder(txtPrecio, "Precio del Producto");

        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(txtId, "Ingrese el ID del producto");
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(txtId, "Ingrese el ID del producto");
        }

        private void txtNombreProdAgregar_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(txtNombreProdAgregar, "Nombre del Producto");
        }

        private void txtNombreProdAgregar_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(txtNombreProdAgregar, "Nombre del Producto");
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(txtDescripcion, "Descripcion del Producto");
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(txtDescripcion, "Descripcion del Producto");
        }

        private void txtExistencias_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(txtExistencias, "Stock (existencias)");
        }

        private void txtExistencias_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(txtExistencias, "Stock (existencias)");
        }

        private void txtPrecio_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(txtPrecio, "Precio del Producto");
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(txtPrecio, "Precio del Producto");
        }

        private void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = Color.Gray; 
            }
        }
        private void RemovePlaceholder(TextBox textBox, string placeholderText)
        {
            if (textBox.Text == placeholderText)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.White; 
            }
        }
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar Imagen";
                openFileDialog.Filter = "Archivos de Imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        rutaImagen = openFileDialog.FileName;

                        string carpetaDestino = @"C:\Users\axeli\source\repos\WindowsProyectoFinal\WindowsProyectoFinal\Resources";

                        if (!Directory.Exists(carpetaDestino))
                        {
                            Directory.CreateDirectory(carpetaDestino);
                        }

                        string nombreArchivo = Path.GetFileName(rutaImagen); 
                        string destino = Path.Combine(carpetaDestino, nombreArchivo); 

                        File.Copy(rutaImagen, destino, true);

                        MessageBox.Show("Imagen guardada correctamente en la carpeta 'Imagenes'.",
                                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        pictureBoxProducto.Image = Image.FromFile(destino);
                        pictureBoxProducto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar la imagen: {ex.Message}",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    string carpetaDestino = @"C:\Users\axeli\source\repos\WindowsProyectoFinal\WindowsProyectoFinal\Resources";

                    if (!Directory.Exists(carpetaDestino))
                    {
                        Directory.CreateDirectory(carpetaDestino);
                    }

                    string nombreImagen = Path.GetFileName(rutaImagen);
                    string rutaDestino = Path.Combine(carpetaDestino, nombreImagen);

                    if (!File.Exists(rutaDestino))
                    {
                        File.Copy(rutaImagen, rutaDestino, true);
                    }

                    using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=proyecto; User=root; Password=; SslMode=none;"))
                    {
                        connection.Open();

                        string countQuery = "SELECT COUNT(*) FROM productos";
                        using (MySqlCommand countCmd = new MySqlCommand(countQuery, connection))
                        {
                            int totalProductos = Convert.ToInt32(countCmd.ExecuteScalar());

                            if (totalProductos >= 10)
                            {
                                MessageBox.Show("No se pueden agregar más de 10 productos.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        string query = "INSERT INTO productos (id, descripcion, precio, stock, nombreimagen) VALUES (@id, @descripcion, @precio, @stock, @nombreimagen)";

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                            cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                            cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
                            cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtExistencias.Text));
                            cmd.Parameters.AddWithValue("@nombreimagen", nombreImagen);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtId.Clear();
                        txtNombreProdAgregar.Clear();
                        txtDescripcion.Clear();
                        txtPrecio.Clear();
                        txtExistencias.Clear();
                        pictureBoxProducto.Image = null;

                        SetPlaceholder(txtId, "Ingrese el ID del producto");
                        SetPlaceholder(txtNombreProdAgregar, "Nombre del Producto");
                        SetPlaceholder(txtDescripcion, "Descripcion del Producto");
                        SetPlaceholder(txtExistencias, "Stock (existencias)");
                        SetPlaceholder(txtPrecio, "Precio del Producto");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


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
             
                txtId.Clear();
                txtNombreProdAgregar.Clear();
                txtDescripcion.Clear();
                txtPrecio.Clear();
                txtExistencias.Clear();
                


                SetPlaceholder(txtId, "Ingrese el ID del producto");
                SetPlaceholder(txtNombreProdAgregar, "Nombre del Producto");
                SetPlaceholder(txtDescripcion, "Descripcion del Producto");
                SetPlaceholder(txtExistencias, "Stock (existencias)");
                SetPlaceholder(txtPrecio, "Precio del Producto");

                pictureBoxProducto.Image = null;
            }
        }

        private void btnSalirDeAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
        }
    }
}
    

