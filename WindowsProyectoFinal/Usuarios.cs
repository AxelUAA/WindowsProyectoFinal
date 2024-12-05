using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsProyectoFinal
{
    public class Usuarios
    {
        private int id;
        private string name;
        private string cuenta;
        private string password;
        private int monto;

        public Usuarios(int id, string name, string cuenta, string password, int monto)
        {
            this.Id = id;
            this.Name = name;
            this.Cuenta = cuenta;
            this.Password = password;
            this.Monto = monto;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public string Password { get => password; set => password = value; }
        public int Monto { get => monto; set => monto = value; }
    }
}
