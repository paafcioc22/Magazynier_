using Magazynier.DataAccess.CQRS;
using Magazynier.DataAccess.CQRS.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess
{
    public class QueryExecutor : IQueryExecutor
    {
        private readonly WarehouseProcessesContext context;

        public QueryExecutor(WarehouseProcessesContext context)
        {
            this.context = context;
        }
        public Task<TResult> Execute<TResult>(QueryBase<TResult> query)
        {
            return query.Execute(this.context);
        }
    }
}
