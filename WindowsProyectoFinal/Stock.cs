﻿using System;
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

    public partial class Stock : Form
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
        public Stock(int userId, string nombre)
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
                AdminProd obj = new AdminProd();

                // Obtener los nombres de las imágenes
                List<string> nombresImagen = obj.ConsultaNombresImagen();

                // Arreglos de TextBox y PictureBox
                TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10 };
                PictureBox[] pictureBoxes = { pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12 };

                for (int i = 0; i < textBoxes.Length; i++)
                {
                    if (i < nombresImagen.Count)
                    {
                        textBoxes[i].Text = nombresImagen[i];
                        textBoxes[i].ReadOnly = true;

                        // Crear ruta relativa a "Resources"
                        string rutaImagen = Path.Combine(Application.StartupPath, "Resources", nombresImagen[i] + ".png");

                        if (File.Exists(rutaImagen))
                        {
                            pictureBoxes[i].Image = Image.FromFile(rutaImagen);
                        }
                        else
                        {
                            pictureBoxes[i].Image = Properties.Resources.soldout; // Imagen predeterminada
                        }

                        pictureBoxes[i].SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        textBoxes[i].Text = "";
                        pictureBoxes[i].Image = null;
                    }
                }

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
                string nombreImagen = textBox1.Text; 
                if (!string.IsNullOrEmpty(nombreImagen))
                {
                    Productos producto = new Productos(0, nombreImagen, "", 0, 0); // id=0, descripción="", precio=0, stock=0
                    CarritoGlobal.carrito.Add(producto);

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreImagen = textBox2.Text;

                if (!string.IsNullOrEmpty(nombreImagen))
                {
                    Productos producto = new Productos(0, nombreImagen, "", 0, 0);
                    CarritoGlobal.carrito.Add(producto);

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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreImagen = textBox3.Text; 

                if (!string.IsNullOrEmpty(nombreImagen))
                {
                    Productos producto = new Productos(0, nombreImagen, "", 0, 0);
                    CarritoGlobal.carrito.Add(producto);

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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreImagen = textBox4.Text; 

                if (!string.IsNullOrEmpty(nombreImagen))
                {
                    Productos producto = new Productos(0, nombreImagen, "", 0, 0);
                    CarritoGlobal.carrito.Add(producto);

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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreImagen = textBox5.Text;

                if (!string.IsNullOrEmpty(nombreImagen))
                {
                    Productos producto = new Productos(0, nombreImagen, "", 0, 0);
                    CarritoGlobal.carrito.Add(producto);

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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreImagen = textBox6.Text;

                if (!string.IsNullOrEmpty(nombreImagen))
                {
                    Productos producto = new Productos(0, nombreImagen, "", 0, 0);
                    CarritoGlobal.carrito.Add(producto);

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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreImagen = textBox7.Text;

                if (!string.IsNullOrEmpty(nombreImagen))
                {
                    Productos producto = new Productos(0, nombreImagen, "", 0, 0);
                    CarritoGlobal.carrito.Add(producto);

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

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreImagen = textBox8.Text;

                if (!string.IsNullOrEmpty(nombreImagen))
                {
                    Productos producto = new Productos(0, nombreImagen, "", 0, 0);
                    CarritoGlobal.carrito.Add(producto);

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

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreImagen = textBox9.Text;

                if (!string.IsNullOrEmpty(nombreImagen))
                {
                    Productos producto = new Productos(0, nombreImagen, "", 0, 0);
                    CarritoGlobal.carrito.Add(producto);

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

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreImagen = textBox10.Text;

                if (!string.IsNullOrEmpty(nombreImagen))
                {
                    Productos producto = new Productos(0, nombreImagen, "", 0, 0);
                    CarritoGlobal.carrito.Add(producto);

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
