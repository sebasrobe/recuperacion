using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ConexionBD
    {
        private string connectionString = "TuConnectionString";

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Clientes";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        // Aquí asigna los valores del cliente según la estructura de tu base de datos
                    };
                    clientes.Add(cliente);
                }

                reader.Close();
            }

            return clientes;
        }

        // Implementa métodos similares para obtener rutas turísticas, ventas de boletos, etc.
    }

    public class Cliente
    {
        // Propiedades del cliente
    }
}
