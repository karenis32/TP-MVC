using Microsoft.EntityFrameworkCore;
using SLNClinica.Models;

namespace SLNClinica.Data
{
    public class DBSLNClinicaContext: DbContext
    {
        public DBSLNClinicaContext(DbContextOptions<DBSLNClinicaContext> options) : base(options) { }

        public DbSet<Medico> Medicos { get; set; }
    }
}
