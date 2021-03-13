using Magazynier.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess.CQRS.Queries
{
    public class GetDocumentQuery : QueryBase<Document>
    {
        public int Id { get; set; }
        public override async Task<Document> Execute(WarehouseProcessesContext context)
        {
            var doc = await context.Documents.FirstOrDefaultAsync(x=> x.Id==this.Id);
            return doc;
        }
    }
}
