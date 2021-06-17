using AutoMapper;
using Magazynier.AplicationServices.API.Domain;
using Magazynier.AplicationServices.API.GUSApi;
using Magazynier.AplicationServices.API.SzachoAPI;
using Magazynier.AplicationServices.ErrorHandling;
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
using WebAPISzacho;
using WebService.Model;

namespace Magazynier.AplicationServices.API.Handlers
{
    public class GetDocsHandler : IRequestHandler<GetDocsRequest, GetDocsResponse>
    {
       
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;
        readonly IWebSzacho webSzacho;
      


        public GetDocsHandler(  IMapper mapper, 
            IQueryExecutor queryExecutor, 
            IWebSzacho webSzacho
            )
        {
           
            this.webSzacho = webSzacho;
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetDocsResponse> Handle(GetDocsRequest request, CancellationToken cancellationToken)
        {
       
            var sqlPobierzMMki = $@"cdn.PC_WykonajSelect N'	select twr_kod PlaceOpis , PlaceName, sum(cast(placequantity as int)) PlaceQuantity, PlaceTwrNumer
                            from cdn.pc_mspolozenie a
                            join cdn.TwrKarty on Twr_GIDNumer= placetwrnumer                         
                            group by twr_kod , placeName,PlaceTwrNumer
                            order by 2'";

            //   var daneZgus = await gus.szukajPodmioty<RootDaneSzukajPodmioty>("6121762083");

            // var dsa= await webSzacho.GetList<Place>(sqlPobierzMMki);

            //var respone = await lineSrvSoap.ExecuteSQLCommandAsync(req);



            if (!request.AuthenticationRole.Contains("Pawel"))
            {
                return new GetDocsResponse()
                {
                    Error = new Domain.ErrorModel(ErrorType.Unauthorize)
                };
            }

            var query = new GetDocumentsQuery()
            {
                NrDokumentu= request.NrDokumentu
            };
            
            var docs = await this.queryExecutor.Execute(query);


            if (docs == null)
            {
                return new GetDocsResponse()
                {
                    Error = new Domain.ErrorModel(ErrorType.NotFound)
                };
            }

            var mappedDocs = this.mapper.Map<List<Domain.Models.Document>>(docs);

            var response = new GetDocsResponse()
            {
                Data = mappedDocs
            };

            return  response ;
        }
    }
}
