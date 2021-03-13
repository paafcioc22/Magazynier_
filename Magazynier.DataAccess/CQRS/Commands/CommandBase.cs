using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess.CQRS.Commands
{
    public abstract class CommandBase<TParametr, TResult>
    {
        public TParametr Parametr { get; set; }
        public abstract Task<TResult> Execute(WarehouseProcessesContext context);

    }
}
