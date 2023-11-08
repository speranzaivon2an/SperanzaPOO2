using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Context: DbContext

    {
        public DbSet<Entidad.AsientosContables> AsientosContable { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(Localdb)\ProjectModels;Initial Catalog=Seguridad;Integrated Security=true");
        }

    }
}