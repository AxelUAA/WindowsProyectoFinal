using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;

namespace WindowsProyectoFinal
{
    public partial class Compra : Form
    {
        public string tipo;
        public string nombre;
        public string numero;
        private int userId;
        

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

            try
            {
                // Ruta del archivo PDF
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "TicketPagoTarjeta.pdf");

                // Eliminar el archivo si ya existe
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                // Precios fijos de productos
                Dictionary<string, decimal> precios = new Dictionary<string, decimal>()
        {
            { "Navaja", 500 },
            { "Maquina1", 2000 },
            { "Maquina2", 3000 },
            { "Tijeras", 400 },
            { "Capa", 200 },
            { "After", 300 },
            { "Kit", 600 },
             {"Rastrillo", 200 }
        };

                // Subtotal, impuestos y total
                decimal subtotal = 0, impuestos = 0, totalFinal = 0;

                // Crear el documento PDF
                Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // 1. Agregar el nombre de la tienda
                Paragraph tienda = new Paragraph("77 Shop", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                tienda.Alignment = Element.ALIGN_CENTER;
                document.Add(tienda);

                // 2. Agregar el lema debajo del nombre de la tienda
                Paragraph lema = new Paragraph("CALIDAD QUE DEFINE TU ESTILO", FontFactory.GetFont(FontFactory.HELVETICA, 14));
                lema.Alignment = Element.ALIGN_CENTER;
                document.Add(lema);
                document.Add(new Paragraph("\n"));

                // 3. Fecha y hora (alineada a la izquierda)
                string fechaHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                Paragraph fecha = new Paragraph($"Fecha: {fechaHora}", FontFactory.GetFont(FontFactory.HELVETICA, 12));
                fecha.Alignment = Element.ALIGN_LEFT;
                document.Add(fecha);
                document.Add(new Paragraph("\n"));

                // 4. Lista de productos
                Paragraph listaTitulo = new Paragraph("Lista de Productos", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12));
                document.Add(listaTitulo);
                document.Add(new Paragraph("\n"));

                foreach (var producto in CarritoGlobal.carrito)
                {
                    decimal precio = precios.ContainsKey(producto.Nombreimagen) ? precios[producto.Nombreimagen] : 0;
                    Paragraph productoInfo = new Paragraph($"{producto.Nombreimagen} - ${precio:0.00}", FontFactory.GetFont(FontFactory.HELVETICA, 11));
                    document.Add(productoInfo);

                    subtotal += precio;
                }

                // 5. Subtotal, impuestos y total
                impuestos = subtotal * 0.06m;
                totalFinal = subtotal + impuestos;

                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph($"Subtotal: ${subtotal:0.00}", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                document.Add(new Paragraph($"Impuestos (6%): ${impuestos:0.00}", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                Paragraph total = new Paragraph($"Total: ${totalFinal:0.00}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12));
                total.Alignment = Element.ALIGN_RIGHT;
                document.Add(total);

                // 6. Mensaje "Pago generado con tarjeta"
                Paragraph leyenda = new Paragraph("Pago generado con tarjeta", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14));
                leyenda.Alignment = Element.ALIGN_CENTER;
                document.Add(leyenda);
                document.Add(new Paragraph("\n"));

                // 7. Datos de la tarjeta
                // Asegúrate de que las variables 'numero', 'nombre' y 'tipo' estén correctamente obtenidas desde los campos
                string tarjetaInfo = $"Nombre asociado: {nombre}\nTipo de tarjeta: {tipo}\nNúmero de tarjeta: {numero}";
                Paragraph tarjetaDatos = new Paragraph(tarjetaInfo, FontFactory.GetFont(FontFactory.HELVETICA, 12));
                tarjetaDatos.Alignment = Element.ALIGN_CENTER;
                document.Add(tarjetaDatos);

                // 8. Agregar imagen desde los recursos
                string imageName = "77-shop"; // Cambia esto por el nombre real
                object resourceImage = Properties.Resources.ResourceManager.GetObject(imageName);

                if (resourceImage is System.Drawing.Bitmap bitmap)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ms.ToArray());
                        img.ScaleToFit(400f, 200f);  // Aumenta el tamaño de la imagen
                        img.Alignment = Element.ALIGN_CENTER;
                        document.Add(img);
                    }
                }
                else
                {
                    MessageBox.Show($"No se encontró la imagen: {imageName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Cerrar el documento
                document.Close();

                MessageBox.Show("El ticket se generó correctamente en el escritorio.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(filePath); // Abrir el archivo PDF
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //limpiar variable antes de usarse otra vez
            CarritoGlobal.carrito.Clear();

            this.Close();
            Stock stock = new Stock(userId, nombre);
            stock.ShowDialog();

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoCompra info=new InfoCompra();
            info.ShowDialog();
        }
    }
}
