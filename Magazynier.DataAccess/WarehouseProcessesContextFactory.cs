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
            //optionsBuilder.UseSqlServer(@"Data Source=WIN-M4TFKCSRRDC\OPTIMA;Initial Catalog=WarehouseProcesses;User ID=szachownica;Password=M@nieczki22");
            optionsBuilder.UseSqlServer(@"Server=tcp:magazynier-srv.database.windows.net,1433;Initial Catalog=WarehouseProcesses;Persist Security Info=False;User ID=pawel;Password=HXUexuP42n8Hhd9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            return new WarehouseProcessesContext(optionsBuilder.Options);
        }
    }
}
