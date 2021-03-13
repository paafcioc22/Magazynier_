using Magazynier.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess.CQRS.Commands
{
    public class AddDocumentCommand : CommandBase<Document, Document>
    {
        public override async Task<Document> Execute(WarehouseProcessesContext context)
        {
            await context.Documents.AddAsync(this.Parametr);
            await context.SaveChangesAsync();
            return Parametr;
        }
    }
}
