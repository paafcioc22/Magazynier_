using Magazynier.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess.CQRS.Commands
{
    public class AddPlaceCommand : CommandBase<Place, Place>
    {
        public async override Task<Place> Execute(WarehouseProcessesContext context)
        {
            await context.Places.AddAsync(this.Parametr);
            await context.SaveChangesAsync();
            return Parametr;
        }
    }
}
