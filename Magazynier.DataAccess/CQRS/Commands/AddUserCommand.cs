using Magazynier.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess.CQRS.Commands
{
    public class AddUserCommand : CommandBase<User, User>
    {
        public async override Task<User> Execute(WarehouseProcessesContext context)
        {
            await context.User.AddAsync(this.Parametr);
            await context.SaveChangesAsync();
            return Parametr;
        }
    }
}
