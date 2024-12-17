using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsProyectoFinal
{
    public class Productos
    {
        private int id;
        private string nombreimagen;
        private string descripcion;
        private int precio;
        private int stock;

        public Productos(int id, string nombreimagen, string descripcion, int precio, int stock)
        {
            this.Id = id;
            this.Nombreimagen = nombreimagen;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Stock = stock;
        }

        public int Id { get => id; set => id = value; }
        public string Nombreimagen { get => nombreimagen; set => nombreimagen = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
