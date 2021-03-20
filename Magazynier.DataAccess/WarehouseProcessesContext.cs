using Magazynier.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess
{
    public class WarehouseProcessesContext : DbContext
    {
        public WarehouseProcessesContext(DbContextOptions<WarehouseProcessesContext> opt) :base (opt)
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Raport> Raport { get; set; }
    }
}
