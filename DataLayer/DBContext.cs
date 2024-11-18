using Domain;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Database
{
    public class DBContext : DbContext
    {
        public DbSet<Depo> depos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
            ("Server=DESKTOP-S5AKNFC;Database=depos;User Id=sa;Password=2626;TrustServerCertificate=true");
        }

    }
}
