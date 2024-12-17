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
    public partial class Carrito : Form
    {
        private int userId;
        private string nombre;
        public Carrito()
        {
            InitializeComponent();
            DisenoBoton();
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
    }
}
