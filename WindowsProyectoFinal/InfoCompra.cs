using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace WindowsProyectoFinal
{
    public partial class InfoCompra : Form
    {
        private int userId;
        private string nombre;



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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Carrito carrito = new Carrito();
            carrito.ShowDialog();
        }

        private void btnPagoTarjeta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compra compra = new Compra();
            compra.ShowDialog();
        }

        private void btnPagoOxxo_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta del archivo PDF
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "TicketOXXO.pdf");

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
            { "Kit", 600 }
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

                // 6. Mensaje final
                Paragraph leyenda = new Paragraph("Escanear en OXXO", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14));
                leyenda.Alignment = Element.ALIGN_CENTER;
                document.Add(leyenda);
                document.Add(new Paragraph("\n"));

                // 7. Código de barras
                Barcode128 barcode = new Barcode128
                {
                    Code = "123456789012" 
                };

                PdfContentByte cb = writer.DirectContent; // Obtener DirectContent desde el PdfWriter
                iTextSharp.text.Image barcodeImage = barcode.CreateImageWithBarcode(cb, BaseColor.BLACK, BaseColor.BLACK);
                barcodeImage.Alignment = Element.ALIGN_CENTER;
                document.Add(barcodeImage);

                // 8. Agregar imagen desde los recursos
                string imageName = "77-shop"; 
                object resourceImage = Properties.Resources.ResourceManager.GetObject(imageName);

                if (resourceImage is System.Drawing.Bitmap bitmap)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ms.ToArray());
                        img.ScaleToFit(400f, 200f);  // Aumentar el tamaño de la imagen
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

            this.Close();
            Stock stock = new Stock(userId, nombre);
            stock.ShowDialog();

        }

    }
}
