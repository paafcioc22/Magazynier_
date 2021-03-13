using Magazynier.DataAccess;
using Magazynier.DataAccess.CQRS.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess
{
    public interface IQueryExecutor
    {
        Task<TResult> Execute<TResult>(QueryBase<TResult> query);
    }
}
