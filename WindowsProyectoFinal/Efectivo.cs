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

namespace WindowsProyectoFinal
{
    public partial class Efectivo : Form
    {
        private double pagar;
        private double pago;

        private int userId;
        private string nombre;
        public Efectivo(double total)
        {
            InitializeComponent();
            this.pagar = total;
            this.textBox1.Text=total.ToString();
        }

        private void Efectivo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCambio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDinero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si el contenido del TextBox es un número
                if (double.TryParse(textBoxDinero.Text, out double pago))
                {
                    // Si el monto ingresado es mayor o igual al total, calcula el cambio
                    if (pago >= pagar)
                    {
                        double cambio = pago - pagar;
                        textBoxCambio.Text = cambio.ToString("0.00");

                        // Eliminar productos con stock = 0 de la base de datos
                        AdminProd adminProd = new AdminProd();
                        int productosEliminados = adminProd.EliminarProductosSinStock();

                        // Mensaje informativo
                        MessageBox.Show($"Pago realizado exitosamente.\nProductos eliminados con 0 existencias: {productosEliminados}.",
                            "Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        adminProd.Disconnect();
                    }
                    else
                    {
                        MessageBox.Show("DINERO INSUFICIENTE!!!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Si no es un número válido, borra el contenido del TextBox de cambio
                    textBoxCambio.Clear();
                    MessageBox.Show("Por favor, ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Manejamos cualquier excepción de forma genérica
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Limpia el carrito después de pagar
            CarritoGlobal.carrito.Clear();

            // Cierra la ventana actual y abre la de stock
            this.Close();
            Stock stock = new Stock(userId, nombre);
            stock.ShowDialog();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.ShowDialog();
        }
    }
}
