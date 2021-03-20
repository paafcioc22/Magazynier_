using Magazynier.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess.CQRS.Queries
{
    public class GetPlacesQuery : QueryBase<List<Place>>
    {
        public string PlaceName { get; set; }
        public override Task<List<Place>> Execute(WarehouseProcessesContext context)
        {
            if (string.IsNullOrEmpty(PlaceName))
                return context.Places.ToListAsync();
            else
                return context.Places.Where(s => s.PlaceName.Contains(this.PlaceName)).ToListAsync();

        }
    }
}
