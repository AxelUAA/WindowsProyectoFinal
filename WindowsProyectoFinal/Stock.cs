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
    public partial class Stock : Form
    {
        private Dictionary<int, string> userRoles = new Dictionary<int, string>
        {
            { 1, "Admin" },
            { 2, "Invitado " },
            { 286973, "User " },
            { 334582, "User " },
            { 442536, "User " },
            { 511513, "User " }

        };

        private int currentUserId;
        public Stock(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
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

        private void OpcAdmin_Click(object sender, EventArgs e)
        {
    
                // If the user is an admin, open the Opciones Admin form
                OpcionesAdmin opcionesAdmin = new OpcionesAdmin();
                opcionesAdmin.ShowDialog();
            
            /*else
            {
                // If the user is not an admin, show a message
                MessageBox.Show("No tienes permisos para acceder a esta opción.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        // Método para verificar si el usuario es administrador
        private bool EsUsuarioAdministrador()
        {
            // Aquí deberías implementar la lógica para verificar si el usuario es administrador
            // Por ejemplo, podrías tener una variable booleana que se establezca al iniciar sesión
            return true; // Cambia esto según tu lógica de autenticación
        }
    }
    
}
