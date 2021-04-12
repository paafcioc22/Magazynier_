using Magazynier.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess.CQRS.Queries
{
    public class GetUserQuery : QueryBase<User>
    {
        public string Username { get; set; }
        public override Task<User> Execute(WarehouseProcessesContext context)
        {
            return context.User.FirstOrDefaultAsync(x => x.UserName == this.Username);
        }
    }
}
