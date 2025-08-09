using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_agregacion_composicion.Clases
{
    public class Factura
    {
        private int id;
        private DateTime fecha;
        private Cliente cliente;
        private decimal total;
        private List<Articulo> articulos;

        public Factura(DateTime fecha, Cliente cliente)
        {
            this.id = Database.BaseDatos.Facturas.Count + 1;
            this.fecha = fecha;
            this.cliente = cliente;
            this.total = 0;
            Database.BaseDatos.Facturas.Add(this);
        }

        public void addArticulo(Articulo articulo)
        {
           if this.articulos == null)
            {
                this.articulos = new List<Articulo>();
            }
            this.articulos.Add(articulo);
            this.total=this.total + articulo.Precio;
        }
        public Cliente Cliente { get => cliente; }
        public decimal Total { get => total; }


        public void ImprimirFactura()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Fecha: {fecha.ToShortDateString()}");
            Console.WriteLine($"Total: {total:C}");
            Console.WriteLine($"Información Cliente:");
            this.cliente.ImprimirCliente();
        }
    }
}
