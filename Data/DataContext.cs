using Microsoft.EntityFrameworkCore;
using Pierwszy_projekt_na_serio.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pierwszy_projekt_na_serio.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Client> Clients { get; set; }
    }
}
