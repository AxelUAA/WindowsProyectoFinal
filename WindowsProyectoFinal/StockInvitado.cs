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
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace WindowsProyectoFinal
{

    public partial class StockInvitado : Form
    {
        //vars
        private string name;


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
        public StockInvitado(int userId, string nombre)
        {
            InitializeComponent();
            this.name = nombre;
            this.textBoxNombre.Text = this.name;
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
                List<string> nombresImagen = obj.ConsultaNombresImagen(); // Nombres o rutas de las imágenes

                // Array o lista de TextBoxes donde se mostrarán los datos
                TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10 }; // Ajustar según corresponda

                // Array o lista de PictureBox para las imágenes
                PictureBox[] pictureBoxes = { pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12 }; // Ajustar según corresponda

                // Iterar sobre los resultados y los TextBoxes
                for (int i = 0; i < textBoxes.Length; i++)
                {
                    if (i < nombresImagen.Count) // Asegurarse de que hay datos para llenar
                    {
                        textBoxes[i].Text = nombresImagen[i];
                        textBoxes[i].ReadOnly = true; // Hacer los TextBox de solo lectura

                        // Cargar imagen en el PictureBox correspondiente
                        string rutaImagen = Path.Combine(Application.StartupPath, "Recursos", nombresImagen[i] + ".png"); // Cambia la extensión según corresponda

                        if (File.Exists(rutaImagen))
                        {
                            pictureBoxes[i].Image = Image.FromFile(rutaImagen);
                        }
                        else
                        {
                            pictureBoxes[i].Image = Properties.Resources.soldout; // Imagen predeterminada
                        }

                        pictureBoxes[i].SizeMode = PictureBoxSizeMode.Zoom; // Ajuste proporcional
                    }
                    else
                    {
                        textBoxes[i].Text = ""; // Vaciar los TextBoxes que no se usen
                        pictureBoxes[i].Image = null; // Limpiar el PictureBox
                    }
                }

                // Mostrar mensaje de confirmación
                MessageBox.Show("Datos e imágenes cargados correctamente.");
                obj.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos o imágenes: " + ex.Message);
            }
        }

        private void OpcAdmin_Click(object sender, EventArgs e)
        {
    
                // If the user is an admin, open the Opciones Admin form
                OpcionesAdmin opcionesAdmin = new OpcionesAdmin(name);
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

        private void Stock_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCarro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Carrito carrito = new Carrito();
            carrito.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén el nombre de la imagen del TextBox correspondiente
                string nombreImagen = textBox1.Text; // TextBox1 corresponde al primer botón

                if (!string.IsNullOrEmpty(nombreImagen))
                {
                    // Crea un producto con solo el nombre de la imagen (otros valores pueden ir como predeterminados)
                    Productos producto = new Productos(0, nombreImagen, "", 0, 0); // id=0, descripción="", precio=0, stock=0

                    // Agregar el producto a la lista del carrito
                    CarritoGlobal.carrito.Add(producto);


                    // Mensaje de confirmación
                    MessageBox.Show($"Producto '{nombreImagen}' agregado al carrito.", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El TextBox está vacío. No se puede agregar al carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar al carrito: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
