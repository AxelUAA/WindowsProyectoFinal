using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsProyectoFinal
{
    public partial class Carrito : Form
    {
        private int userId;
        private string nombre;

       

        public Carrito()
        {
            InitializeComponent();
            
            ActualizarCarrito();
        }
      
        private void groupBoxLogin_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock Stock = new Stock(userId, nombre);
            Stock.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoCompra info = new InfoCompra();
            info.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void ActualizarCarrito()
        {
            richTextBox1.Clear();

            foreach (Productos producto in CarritoGlobal.carrito)
            {
                richTextBox1.AppendText($"{producto.Nombreimagen}\n");
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén el nombre del producto a eliminar
                string nombreAEliminar = textBoxEliminar.Text; // TextBox donde el usuario escribe el nombre del producto

                // Buscar el producto en el carrito
                Productos productoAEliminar = CarritoGlobal.carrito.FirstOrDefault(p => p.Nombreimagen == nombreAEliminar);

                if (productoAEliminar != null)
                {
                    // 1. Conectar con la base de datos
                    AdminProd adminProd = new AdminProd();

                    // 2. Recuperar el stock actual del producto en la base de datos
                    Productos productoDB = adminProd.ConsultaProducto(nombreAEliminar);

                    if (productoDB != null)
                    {
                        int nuevoStock = productoDB.Stock + 1; // Incrementar el stock en 1

                        // 3. Actualizar el stock en la base de datos
                        bool stockActualizado = adminProd.ActualizarStock(nombreAEliminar, nuevoStock);

                        if (stockActualizado)
                        {
                            // 4. Eliminar el producto del carrito
                            CarritoGlobal.carrito.Remove(productoAEliminar);

                            // Actualizar el RichTextBox o interfaz
                            ActualizarCarrito();

                            MessageBox.Show($"Producto '{nombreAEliminar}' eliminado del carrito y stock actualizado.",
                                "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el stock en la base de datos.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El producto no existe en la base de datos.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    adminProd.Disconnect(); // Cerrar conexión
                }
                else
                {
                    MessageBox.Show("Producto no encontrado en el carrito.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
