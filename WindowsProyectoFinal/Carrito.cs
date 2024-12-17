using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
            panelOpcPago.Visible = true;
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
            { "navaja.jpg", 500 },
            { "Maquina1.jpg", 2000 },
            { "maquina2.jpg", 3000 },
            { "tijeras.jpg", 400 },
            { "capa.jpg", 200 },
            { "after.jpg", 300 },
            { "kit.jpg", 600 }
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

                // 2. Fecha y hora
                string fechaHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                Paragraph fecha = new Paragraph($"Fecha: {fechaHora}", FontFactory.GetFont(FontFactory.HELVETICA, 12));
                fecha.Alignment = Element.ALIGN_CENTER;
                document.Add(fecha);
                document.Add(new Paragraph("\n"));

                // 3. Lista de productos
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

                // 4. Subtotal, impuestos y total
                impuestos = subtotal * 0.06m;
                totalFinal = subtotal + impuestos;

                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph($"Subtotal: ${subtotal:0.00}", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                document.Add(new Paragraph($"Impuestos (6%): ${impuestos:0.00}", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                Paragraph total = new Paragraph($"Total: ${totalFinal:0.00}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12));
                total.Alignment = Element.ALIGN_RIGHT;
                document.Add(total);

                // 5. Mensaje final
                Paragraph leyenda = new Paragraph("Escanear en OXXO", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14));
                leyenda.Alignment = Element.ALIGN_CENTER;
                document.Add(leyenda);
                document.Add(new Paragraph("\n"));

                // 6. Código de barras
                Barcode128 barcode = new Barcode128
                {
                    Code = "123456789012" // Ejemplo de código
                };

                PdfContentByte cb = writer.DirectContent; // Obtener DirectContent desde el PdfWriter
                iTextSharp.text.Image barcodeImage = barcode.CreateImageWithBarcode(cb, BaseColor.BLACK, BaseColor.BLACK);
                barcodeImage.Alignment = Element.ALIGN_CENTER;
                document.Add(barcodeImage);
               
                // 7. Agregar imagen desde los recursos
                string imageName = "77-shop"; // Cambia esto por el nombre real
                object resourceImage = Properties.Resources.ResourceManager.GetObject(imageName);

                if (resourceImage is System.Drawing.Bitmap bitmap)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ms.ToArray());
                        img.ScaleToFit(200f, 100f);  // Ajusta el tamaño según sea necesario
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
        }



    }
}