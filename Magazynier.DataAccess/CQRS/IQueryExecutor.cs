using Magazynier.DataAccess.CQRS.Queries;
using System.Threading.Tasks;

namespace Magazynier.DataAccess
{
    public interface IQueryExecutor
    {
        Task<TResult> Execute<TResult>(QueryBase<TResult> query);
    }
}
