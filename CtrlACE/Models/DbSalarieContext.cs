using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CtrlACE.Models
{
    public class DbSalarieContext : DbContext
    {
        public DbSalarieContext(DbContextOptions<DbSalarieContext> options)
            : base(options) { }

        public DbSet<Salarie> Salaries { get; set; }
        public DbSet<Departement> Departement { get; set; }
    }
}
