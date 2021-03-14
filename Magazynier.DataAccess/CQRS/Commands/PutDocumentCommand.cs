using Magazynier.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Magazynier.DataAccess.CQRS.Commands
{
    public class PutDocumentCommand : CommandBase<Document, Document>
    {
       
        public async override Task<Document> Execute(WarehouseProcessesContext context)
        {

            context.Documents.Update(Parametr);
            await context.SaveChangesAsync();
            return Parametr;
        }
    }
}
