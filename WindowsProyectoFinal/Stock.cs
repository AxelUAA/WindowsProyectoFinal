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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear instancia de la clase que realiza la consulta
                AdminProd obj = new AdminProd();

                // Obtener todos los nombres de imagen
                List<string> nombresImagen = obj.ConsultaNombresImagen();

                // Array o lista de TextBoxes donde se mostrarán los datos
                TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10 }; // Asegúrate de agregar tus TextBoxes aquí.

                // Iterar sobre los resultados y los TextBoxes
                for (int i = 0; i < textBoxes.Length; i++)
                {
                    if (i < nombresImagen.Count) // Asegurarse de que hay datos para llenar
                    {
                        textBoxes[i].Text = nombresImagen[i];
                    }
                    else
                    {
                        textBoxes[i].Text = ""; // Vaciar los TextBoxes que no se usen
                    }
                }

                // Carga imágenes en los botones
                CargarImagenesEnBotones();

                // Mostrar mensaje de confirmación
                MessageBox.Show("Datos cargados correctamente.");
                obj.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void AsignarImagenABoton(Button boton, Image imagen)
        {
            boton.Image = imagen; // Asigna la imagen al botón
            boton.ImageAlign = ContentAlignment.MiddleCenter; // Centra la imagen en el botón
            boton.BackgroundImageLayout = ImageLayout.Zoom; // Ajusta automáticamente
            boton.Text = ""; // Opcional: quita el texto del botón
        }

        private void CargarImagenesEnBotones()
        {
            // Asocia botones con imágenes de Resources
            Dictionary<Button, Image> mapeoBotones = new Dictionary<Button, Image>{
                { button1, Properties.Resources.navaja1_jpg }
                ,{ button2, Properties.Resources.maquina1 }
                ,{ button3, Properties.Resources.maquina2 }
                ,{ button4, Properties.Resources.tijeras }
                ,{ button5, Properties.Resources.capa }
                ,{ button6, Properties.Resources.after}
                ,{ button7, Properties.Resources.kit }
            };
            // Asigna las imágenes a los botones
            foreach (var par in mapeoBotones)
            {
                AsignarImagenABoton(par.Key, par.Value);
            }
        }


    }
}
