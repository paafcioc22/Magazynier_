using AutoMapper;
using Magazynier.AplicationServices.API.Domain;
using Magazynier.DataAccess;
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
        private readonly IRepository<Document> docsRepository;
        private readonly IMapper mapper;

        public GetDocsHandler(IRepository<DataAccess.Entities.Document> docsRepository, IMapper mapper )
        {
            this.docsRepository = docsRepository;
            this.mapper = mapper;
        }

        public async Task<GetDocsResponse> Handle(GetDocsRequest request, CancellationToken cancellationToken)
        {
            var docs =  await this.docsRepository.GetAll(); 

            var mappedDocs = this.mapper.Map<List<Domain.Models.Document>>(docs);

            var response = new GetDocsResponse()
            {
                Data = mappedDocs
            };

            return  response ;
        }
    }
}
