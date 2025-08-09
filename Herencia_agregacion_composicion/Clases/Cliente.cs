using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_agregacion_composicion.Clases
{
    public class Cliente : Persona
    {
        private string direccion;
        private string ciudad;
        public Cliente(string cedula, string nombres, string apellidos, string email, string telefono, string direccion, string ciudad)
            : base(cedula, nombres, apellidos, email, telefono)
        {
            this.direccion = direccion;
            this.ciudad = ciudad;
            Database.BaseDatos.Clientes.Add(this);
        }
        public string Direccion { get => direccion; }
        public string Ciudad { get => ciudad; }
        public void ImprimirCliente()
        {
            ImprimirPersona();
            Console.WriteLine($"Dirección: {direccion}");
            Console.WriteLine($"Ciudad: {ciudad}");
        }
    }
}
