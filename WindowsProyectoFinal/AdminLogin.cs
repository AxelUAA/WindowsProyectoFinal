using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProyectoFinal
{
    public class AdminLogin
    {
        private MySqlConnection connection;
        public string name { get; set; }

        public AdminLogin()
        {
            this.Connect();
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool ValidarCampos(string usuario, string contrasena)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingrese todos los campos.");
                return false;
            }
            return true;
        }

        public bool ValidarTipoUsuario(RadioButton radioAdmin, RadioButton radioUsuario, RadioButton radioInvitado, out string tipoUsuario)
        {
            tipoUsuario = "";

            if (radioAdmin.Checked)
                tipoUsuario = "Administrador";
            else if (radioUsuario.Checked)
                tipoUsuario = "Usuario";
            else if (radioInvitado.Checked)
                tipoUsuario = "Invitado";
            else
            {
                MessageBox.Show("Por favor, seleccione un tipo de usuario.");
                return false;
            }

            return true;
        }

        public bool ValidarUsuario(string cuenta, string password)
        {
            try
            {
                //var que se va a pasar al form 
                string name = string.Empty;

                string query = "SELECT * FROM usuarios WHERE cuenta = @cuenta AND contra = @contra";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                command.Parameters.AddWithValue("@cuenta", cuenta);
                command.Parameters.AddWithValue("@contra", password);
                


                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    this.name = reader["nombre"].ToString(); //leer el nombre 
                    reader.Close();
                    return true; //validamos si la lectura fue correcta
                }

                reader.Close();
                MessageBox.Show("Usuario o contraseña incorrectos.");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar usuario: {ex.Message}");
                return false;
            }
        }


        public void Connect()
        {
            string cadena = "Server=localhost; Database=proyecto; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
                //MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
