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
        
        private string name;
        public OpcionesAdmin(string name)
        {
            InitializeComponent();
            this.name = name;
            this.textBoxNombre.Text = this.name;
        }

        private void bopcadmin_Click(object sender, EventArgs e)
        {

        }

        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarProducto agregarProducto = new AgregarProducto(name);
            agregarProducto.ShowDialog(this);
        }

        private void btnEliminarPro_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarProducto eliminar = new EliminarProducto(name);
            eliminar.ShowDialog(this);
            
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListadoProductosAdmin listado = new ListadoProductosAdmin(name);
            listado.ShowDialog(this); 
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            this.Hide();
            GraficosVentas graficosVentas = new GraficosVentas(name);
            graficosVentas.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegOAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
        }

        private void OpcionesAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
