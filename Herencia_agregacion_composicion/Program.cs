using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_agregacion_composicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cargarMenu();
        }

        private static void cargarMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menú de Opciones:");
                Console.WriteLine("1. Registrar Cliente");
                Console.WriteLine("2. Listar Clientes");
                Console.WriteLine("3. Registrar Factura");
                Console.WriteLine("4. Listar Factura");
                Console.WriteLine("5. Registrar Articulo");
                Console.WriteLine("6. Listar Articulo");
                Console.WriteLine("4. Listar Factura");

                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        registrarCliente();
                        break;
                    case "2":
                        listarClientes();
                        break;
                    case "3":
                        registrarFactura();
                        break;
                    case "4":
                        listarFactura();
                        break;
                    case "5":
                        registarArticulo();
                        break;
                    case "6":
                        listarArticulo();
                        break;
                    case "0":
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }



            }
        }

        private static void listarArticulo()
        {
            throw new NotImplementedException();
        }

        private static void registarArticulo()
        {
            throw new NotImplementedException();
        }

        private static void listarFactura()
        {
            Console.Clear();
            Console.WriteLine("--- Lista de Facturas ---");
            foreach (var factura in Database.BaseDatos.Facturas)
            {
                factura.ImprimirFactura();
                Console.WriteLine("------------------------");
            }
            Console.ReadLine();
        }

        private static void registrarFactura()
        {
            Console.Clear();

            Console.WriteLine("--- Registro de Factura ---");
            Console.Write("Fecha (dd/mm/yyyy): ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());
            Console.Write("Cédula Cliente: ");
            string cedula = Console.ReadLine();
            Clases.Cliente cliente = Database.BaseDatos.GetClienteByCedula(cedula);
            if (cliente == null)
            {
                Console.WriteLine("Cliente no encontrado.");
                Console.ReadLine();
                return;
            }

            Clases.Factura nuevaFactura = new Clases.Factura(fecha, cliente, total);
            Console.WriteLine("Factura registrada exitosamente.");
            Console.ReadLine();
        }

        private static void listarClientes()
        {
            Console.Clear();
            Console.WriteLine("--- Lista de Clientes ---");
            foreach (var cliente in Database.BaseDatos.Clientes)
            {
                cliente.ImprimirCliente();
                Console.WriteLine("------------------------");
            }
            Console.ReadLine();
        }
        private static void listarArticulo()
        {
            Console.Clear();
            Console.WriteLine("--- Lista de Articulos ---");
            foreach (var factura in Database.BaseDatos.Facturas)
            {
                factura.ImprimirFactura();
                Console.WriteLine("------------------------");
            }
            Console.ReadLine();
        }




        private static void registrarCliente()
        {
            Console.Clear();
            Console.WriteLine("--- Registro de Cliente ---");
            Console.Write("Cédula: ");
            string cedula = Console.ReadLine();
            Console.Write("Nombres: ");
            string nombres = Console.ReadLine();
            Console.Write("Apellidos: ");
            string apellidos = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine();
            Console.Write("Dirección: ");
            string direccion = Console.ReadLine();
            Console.Write("Ciudad: ");
            string ciudad = Console.ReadLine();
            Clases.Cliente nuevoCliente = new Clases.Cliente(cedula, nombres, apellidos, email, telefono, direccion, ciudad);
            Console.WriteLine("Cliente registrado exitosamente.");
            Console.ReadLine();
        }
    }
}