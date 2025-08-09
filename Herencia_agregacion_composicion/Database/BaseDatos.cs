using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_agregacion_composicion.Database
{
    public class BaseDatos
    {
        public static List<Clases.Persona> Personas = new List<Clases.Persona>();
        public static List<Clases.Cliente> Clientes = new List<Clases.Cliente>();
        public static List<Clases.Factura> Facturas = new List<Clases.Factura>();
        public static List<Clases.Articulo> Articulos = new List<Clases.Articulo>();
        public static Clases.Cliente GetClienteByCedula(string cedula)
        {
            return Clientes.FirstOrDefault(c => c.Cedula == cedula);
        }

        public static Clases.Articulo GetArticuloByCedula(string codigo)
        {
            return Articulos.FirstOrDefault(c => c.codigo == codigo);
        }
    }
}
