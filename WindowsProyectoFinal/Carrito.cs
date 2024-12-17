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
            DisenoBoton();
            ActualizarCarrito();
        }
        void DisenoBoton()
        {
            panelOpcPago.Visible = false;
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
            panelOpcPago.Visible=true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPagoTarjeta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compra compra = new Compra();
            compra.ShowDialog();
        }

        private void ActualizarCarrito()
        {
            richTextBox1.Clear();

            foreach (Productos producto in CarritoGlobal.carrito)
            {
                richTextBox1.AppendText($"Nombre: {producto.Nombreimagen}\n");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Ejemplo: listaProductos contiene todos los productos disponibles.
                // El usuario seleccionará un producto por índice (ajusta según tu lógica).
                int indiceSeleccionado = 0; // Cambia este índice por el correcto

                if (indiceSeleccionado >= 0 && indiceSeleccionado < CarritoGlobal.carrito.Count)
                {
                    // Actualizar el RichTextBox
                    ActualizarCarrito();
                }
                else
                {
                    MessageBox.Show("No hay un producto seleccionado válido.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar al carrito: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Buscar y eliminar el producto del carrito
                Productos productoAEliminar = CarritoGlobal.carrito.FirstOrDefault(p => p.Nombreimagen == nombreAEliminar);

                if (productoAEliminar != null)
                {
                    CarritoGlobal.carrito.Remove(productoAEliminar);

                    // Actualizar el RichTextBox
                    ActualizarCarrito();

                    MessageBox.Show($"Producto '{nombreAEliminar}' eliminado del carrito.", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado en el carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
