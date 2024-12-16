using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsProyectoFinal
{
    public partial class Login : Form
    {
        private int userId;
        private string nombre;
        public Login()
        {
            InitializeComponent();
           // MessageBox.Show("Bienvenido!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonalizarMenu();
        }


        private void PersonalizarMenu()
        {
            panelUsuarios.Visible = false;
        }

        private void OcultarMenu()
        {
            if (panelUsuarios.Visible)
            {
                panelUsuarios.Visible = false;
            }
        }

        private void MostrarMenu(Panel Menu)
        {
            if (Menu.Visible==false)
            {
                OcultarMenu();
                Menu.Visible = true;
            }
            else
            {
                Menu.Visible = false;
            }
        }

        private void labelSlogan_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxUsuario_TextChanged(object sender, EventArgs e)
        {
           
        }
          


        private void txtBoxContra_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtBoxUsuario_Enter(object sender, EventArgs e)
        {
            if (txtBoxUsuario.Text == "USUARIO")
            {
                txtBoxUsuario.Text = "";
                txtBoxUsuario.ForeColor = Color.White;
            }
        }

        private void txtBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUsuario.Text))
            {
                txtBoxUsuario.Text = "USUARIO";
                txtBoxUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtBoxContra_Enter(object sender, EventArgs e)
        {
            if (txtBoxContra.Text == "CONTRASEÑA")
            {
                txtBoxContra.Text = "";
                txtBoxContra.ForeColor = Color.White;
                txtBoxContra.UseSystemPasswordChar = true; // Para ocultar la contraseña
            }
        }

        private void txtBoxContra_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtBoxContra.Text))
            {
                txtBoxContra.Text = "CONTRASEÑA";
                txtBoxContra.ForeColor = Color.Gray;
                txtBoxContra.UseSystemPasswordChar = false; // Para mostrar el texto de forma legible
            }
        }

        private void bRegreLogin_Click(object sender, EventArgs e)
        {
            bRegreLogin.BackColor = Color.Black; 
            bRegreLogin.ForeColor = Color.White;

            this.Close();

            // Crear una nueva instancia de Form1
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void bRegreLogin_Enter(object sender, EventArgs e)
        {
            bRegreLogin.BackColor = Color.Black;
            bRegreLogin.ForeColor = Color.White;
        }

        private void bRegreLogin_Leave(object sender, EventArgs e)
        {
            bRegreLogin.BackColor = Color.White;
            bRegreLogin.ForeColor = Color.Black;
        }

        private void bSalirLogin_Click(object sender, EventArgs e)
        {
            bSalirLogin.BackColor = Color.Black;
            bSalirLogin.ForeColor = Color.White;
            Application.Exit();
        }

        private void bSalirLogin_Enter(object sender, EventArgs e)
        {
            bSalirLogin.BackColor = Color.Black;
            bSalirLogin.ForeColor = Color.White;
        }

        private void bSalirLogin_Leave(object sender, EventArgs e)
        {
            bSalirLogin.BackColor = Color.White;
            bSalirLogin.ForeColor = Color.Black;
        }

        private void groupBoxLogin_Enter(object sender, EventArgs e)
        {
            label1.SendToBack();
            labeluser.SendToBack();
            label1.TabStop = false;
            labeluser.TabStop = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.White;
            btnIngresar.ForeColor = Color.Black;

            string cuenta = txtBoxUsuario.Text;
            string password = txtBoxContra.Text;

            AdminLogin adminLogin = new AdminLogin();

            if (adminLogin.ValidarCampos(cuenta, password))
            {
                if (adminLogin.ValidarUsuario(cuenta, password))
                {
                    // Obtenemos el nombre del usuario desde la propiedad
                    nombre = adminLogin.name;
                    MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Stock Stock = new Stock(userId, nombre);
                    Stock.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.White;
            btnIngresar.ForeColor = Color.Black;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.Black;
            btnIngresar.ForeColor = Color.White;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelUsuarios);
        }
    }
}
