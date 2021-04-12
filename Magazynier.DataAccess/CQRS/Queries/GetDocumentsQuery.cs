using Magazynier.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess.CQRS.Queries
{
    public class GetDocumentsQuery : QueryBase<List<Document>>
    {
        public string NrDokumentu { get; set; }
        public async override Task<List<Document>> Execute(WarehouseProcessesContext context)
        {
            if (string.IsNullOrEmpty(NrDokumentu))
                return await context.Documents
                    .Include(s => s.Items)
                   
                    .ToListAsync();
            else
                return await context.Documents
                    .Where(s => s.Trn_NrDokumentu.Contains(this.NrDokumentu))
                    .Include(s => s.Items)
                    .ToListAsync();

        }
    }
}
