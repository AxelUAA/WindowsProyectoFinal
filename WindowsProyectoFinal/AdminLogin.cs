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

        public bool ValidarCredenciales(string usuario, string contrasena, string tipoUsuario)
        {
            // Aquí puedes conectar tu base de datos para validar las credenciales
            // Simulando validación simple:
            switch (tipoUsuario)
            {
                case "Administrador":
                    return usuario == "admin" && contrasena == "admin123";
                case "Usuario":
                    return usuario == "usuario" && contrasena == "user123";
                case "Invitado":
                    return usuario == "invitado" && contrasena == "inv123";
                default:
                    return false;
            }
        }


    }
}
