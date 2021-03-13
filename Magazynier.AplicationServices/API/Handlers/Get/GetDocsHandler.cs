using AutoMapper;
using Magazynier.AplicationServices.API.Domain;
using Magazynier.DataAccess;
using Magazynier.DataAccess.CQRS.Queries;
using Magazynier.DataAccess.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Handlers
{
    public class GetDocsHandler : IRequestHandler<GetDocsRequest, GetDocsResponse>
    {
       
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetDocsHandler(  IMapper mapper, IQueryExecutor queryExecutor )
        {
         
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetDocsResponse> Handle(GetDocsRequest request, CancellationToken cancellationToken)
        {
            //var docs =  await this.docsRepository.GetAll(); 

            var query = new GetDocumentsQuery()
            {
                NrDokumentu= request.NrDokumentu
            };
            
            var docs = await this.queryExecutor.Execute(query);

            var mappedDocs = this.mapper.Map<List<Domain.Models.Document>>(docs);

            var response = new GetDocsResponse()
            {
                Data = mappedDocs
            };

            return  response ;
        }
    }
}
