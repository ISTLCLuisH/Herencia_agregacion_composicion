using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_agregacion_composicion.Clases
{
    public class Persona
    {
        private int id;
        private string cedula;
        private string nombres;
        private string apellidos;
        private string email;
        private string telefono;

        public Persona(string cedula, string nombres, string apellidos, string email, string telefono)
        {
            this.id=Database.BaseDatos.Personas.Count + 1;   
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.email = email;
            this.telefono = telefono;
        }

        public int Id { get => id; }
        public string Cedula { get => cedula; }
        public string Nombres { get => nombres; }
        public string Apellidos { get => apellidos; }
        public string Email { get => email; }
        public string Telefono { get => telefono; }


        public void ImprimirPersona()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Cédula: {cedula}");
            Console.WriteLine($"Nombres: {nombres}");
            Console.WriteLine($"Apellidos: {apellidos}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Teléfono: {telefono}");
        }
    }
}
