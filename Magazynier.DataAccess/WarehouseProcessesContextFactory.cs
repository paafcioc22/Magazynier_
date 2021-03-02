using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace Magazynier.DataAccess
{
    public class WarehouseProcessesContextFactory : IDesignTimeDbContextFactory<WarehouseProcessesContext>
    {
        public WarehouseProcessesContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WarehouseProcessesContext>();
            optionsBuilder.UseSqlServer(@"Data Source=WIN-M4TFKCSRRDC\OPTIMA;Initial Catalog=WarehouseProcesses;User ID=szachownica;Password=M@nieczki22");
            return new WarehouseProcessesContext(optionsBuilder.Options);
        }
    }
}
