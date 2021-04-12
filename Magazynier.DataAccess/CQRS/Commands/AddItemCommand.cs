using Magazynier.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess.CQRS.Commands
{
    public class AddItemCommand : CommandBase<Item, Item>
    {
        public async override Task<Item> Execute(WarehouseProcessesContext context)
        {
            await context.Items.AddAsync(this.Parametr);
            await context.SaveChangesAsync();
            return Parametr;
        }
    }
}
