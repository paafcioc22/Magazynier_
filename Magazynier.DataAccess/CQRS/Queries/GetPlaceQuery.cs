using Magazynier.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess.CQRS.Queries
{
    public class GetPlaceQuery : QueryBase<Place>
    {
        public int Id { get; set; }
        public async override Task<Place> Execute(WarehouseProcessesContext context)
        {
            var doc = await context.Places
                .Include(s=>s.Items)
                .FirstOrDefaultAsync(x => x.Id== this.Id);
            return doc;
        }
    }
}
