using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_agregacion_composicion.Clases
{
    public class Articulo
    {
        private int id;
        private string codigo;
        private string descripcion;
        private decimal precio;

        public Articulo(string codigo, string descripcion, decimal precio)
        {
            this.id = Database.BaseDatos.Articulos.Count + 1;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
            Database.BaseDatos.Articulos.Add(this);
        }

        public int Id { get => id;  }
        public string Codigo { get => codigo; }
        public string Descripcion { get => descripcion; }
        public decimal Precio { get => precio; }

        public void ImprimirArticulo()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Descripción: {descripcion}");
            Console.WriteLine($"Precio: {precio:C}");
        }
    }
}
