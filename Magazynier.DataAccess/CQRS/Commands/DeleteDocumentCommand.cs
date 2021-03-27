using Magazynier.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess.CQRS.Commands
{
    public class DeleteDocumentCommand : CommandBase<Document, Document>
    {
        public int Id { get; set; }
        public async override Task<Document> Execute(WarehouseProcessesContext context)
        {
            var delete = await context.Documents
                .Include(s=>s.Items)
                .SingleOrDefaultAsync(x => x.Id == Id);

            context.Documents.Remove(delete);
            await context.SaveChangesAsync();
            return delete;
        }
    }
}
