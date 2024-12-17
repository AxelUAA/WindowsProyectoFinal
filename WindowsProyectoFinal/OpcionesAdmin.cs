using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProyectoFinal
{
    public partial class OpcionesAdmin : Form
    {
        public OpcionesAdmin()
        {
            InitializeComponent();
        }

        private void bopcadmin_Click(object sender, EventArgs e)
        {

        }

        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.ShowDialog(this);
        }

        private void btnEliminarPro_Click(object sender, EventArgs e)
        {

        }

        private void btnListado_Click(object sender, EventArgs e)
        {

        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            GraficosVentas graficosVentas = new GraficosVentas();
            graficosVentas.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
