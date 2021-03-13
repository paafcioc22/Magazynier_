using Magazynier.DataAccess.CQRS.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess.CQRS
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly WarehouseProcessesContext context;

        public CommandExecutor(WarehouseProcessesContext context)
        {
            this.context = context;
        }
        public Task<TResult> Execute<TParameters, TResult>(CommandBase<TParameters, TResult> command)
        {
            return command.Execute(this.context);
        }
    }
}
