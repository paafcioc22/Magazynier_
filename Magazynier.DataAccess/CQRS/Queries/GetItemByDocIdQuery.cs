using Magazynier.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess.CQRS.Queries
{

    public class GetItemByDocIdQuery : QueryBase<List<Item>>
    {
        public int Id { get; set; }

        public override Task<List<Item>> Execute(WarehouseProcessesContext context)
        {
            return context.Items
                .Where(x => x.DocumentId == this.Id)
                .ToListAsync();
        }
    }
}
