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
    public partial class InfoCompra : Form
    {
        private Dictionary<string, int> precios = new Dictionary<string, int>
        {
            { "Navaja", 500 },
            { "Maquina1", 2000 },
            { "Maquina2", 3000 },
            { "Tijeras", 400 },
            { "Capa", 200 },
            { "After", 300 },
            { "Kit", 600 }
        };

        public InfoCompra()
        {
            InitializeComponent();
            CargarListaCompra();
        }

        private void CargarListaCompra()
        {
            // Mostrar hora de generación al inicio
            DateTime horaGeneracion = DateTime.Now;
            richTextBox1.AppendText($"Hora: {horaGeneracion.ToString("hh:mm tt")}\n\n");

            int total = 0;
            foreach (var producto in CarritoGlobal.carrito)
            {
                // Usar Nombreimagen como nombre del producto
                string nombreProducto = producto.Nombreimagen;

                if (precios.ContainsKey(nombreProducto))
                {
                    int precio = precios[nombreProducto];
                    richTextBox1.AppendText($"{nombreProducto} - ${precio}\n");
                    total += precio;
                }
                else
                {
                    richTextBox1.AppendText($"{nombreProducto} - Precio no disponible\n");
                }
            }

            // Calcular impuestos (6%)
            double impuestos = total * 0.06;
            double totalConImpuestos = total + impuestos;

            // Mostrar subtotal, impuestos y total con impuestos
            richTextBox1.AppendText($"\nSubtotal: ${total}");
            richTextBox1.AppendText($"\nImpuestos (6%): ${impuestos:F2}");
            richTextBox1.AppendText($"\nTotal con impuestos: ${totalConImpuestos:F2}");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Evento no necesario, puedes eliminarlo si no se usa
        }
    }
}
