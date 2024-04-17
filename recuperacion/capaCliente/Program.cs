using System;
using CapaServiciosWeb;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            // Código de interfaz de usuario para interactuar con los servicios web y mostrar resultados
            ServiciosWebClient serviciosWebClient = new ServiciosWebClient();
            var clientes = serviciosWebClient.ObtenerClientes();

            // Mostrar los clientes obtenidos
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"Nombre: {cliente.Nombre}, Edad: {cliente.Edad}, Tipo: {cliente.Tipo}");
            }
        }
    }
}
