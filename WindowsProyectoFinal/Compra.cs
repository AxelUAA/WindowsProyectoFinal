using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsProyectoFinal
{
    public partial class Compra : Form
    {
        public string tipo;
        public string nombre;
        public string numero;

        public Compra()
        {
            InitializeComponent();
        }

        private void Compra_Load(object sender, EventArgs e)
        {

        }

     

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            // Validar si el TextBox está vacío o tiene solo espacios en blanco
            if (string.IsNullOrWhiteSpace(textBoxCVV.Text)|| string.IsNullOrWhiteSpace(textBoxFecha.Text)|| string.IsNullOrWhiteSpace(textBoxNombre.Text)||string.IsNullOrWhiteSpace(textBoxTarjeta.Text))
            {
                MessageBox.Show("Algun campo esta vacío.");
            }

            numero= textBoxTarjeta.Text;
            nombre= textBoxNombre.Text;

            if (radioButtonAmerican.Checked)
            {
                tipo = "American Express";
            }
            else if (radioButtonMaster.Checked)
            {
                tipo = "MasterCard";
            }
            else if (radioButtonVisa.Checked)
            {
                tipo = "Visa";
            }
            else 
            {
                MessageBox.Show("Seleciona el tipo de tarjeta");
                return;
            }


        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Carrito carrito = new Carrito();
            carrito.ShowDialog();
        }
    }
}
