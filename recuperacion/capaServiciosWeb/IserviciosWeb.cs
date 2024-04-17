using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CapaServiciosWeb
{
    [ServiceContract]
    public interface IServiciosWeb
    {
        [OperationContract]
        List<Cliente> ObtenerClientes();

        // Otros contratos de servicios web
    }

    public class ServiciosWeb : IServiciosWeb
    {
        public List<Cliente> ObtenerClientes()
        {
            // Llama a los métodos de la capa de datos para obtener los clientes
            ConexionBD conexionBD = new ConexionBD();
            return conexionBD.ObtenerClientes();
        }

        // Implementa otros métodos del contrato de servicios web
    }
}
