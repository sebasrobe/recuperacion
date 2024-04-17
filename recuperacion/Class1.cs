using System.Data.Entity;

public class VentasBoletosContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<RutaTuristica> RutasTuristicas { get; set; }

    public VentasBoletosContext() : base("name=VentasBoletosConnectionString")
    {
    }
}
