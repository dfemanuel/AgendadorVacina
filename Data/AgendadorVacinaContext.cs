using Microsoft.EntityFrameworkCore;
using AgendadorVacina.Models;

namespace AgendadorVacina.Data
{
    public class AgendadorVacinaContext : DbContext
    {
        public AgendadorVacinaContext (DbContextOptions<AgendadorVacinaContext> options)
            : base(options)
        {
        }

        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Local> Local { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}