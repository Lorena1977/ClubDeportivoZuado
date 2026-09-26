using Microsoft.EntityFrameworkCore;
using ClubDeportivoZuado.Shared.Entities;

namespace ClubDeportivoZuazo.Backend.Data
{
    public class DataContext : DbContext   //DataContext hereda de la clase DbContext. 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) //Esto hace que nos conectemos a la base de datos
        {
        }

        //Creamos una propiedad DbSet (que es un genérico) e indico la entidad que quiero mapear.
        public DbSet<Jugador> Jugadores { get; set; }

        //Queremos que la tabla Jugador tenga un índice (en el campo DNI) y que sea único para que no se dupliquen los paises. Para ello, creamos el método siguiente
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //EntityFramework aplica configuraciones internas y automáticas
            modelBuilder.Entity<Jugador>().HasIndex(c => c.DNI).IsUnique();//Indicamos que la tabla Country tiene un índice único.
        }

    }
}
