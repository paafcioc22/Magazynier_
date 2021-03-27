using Magazynier.AplicationServices.API.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Domain.Add
{
    public class AddDocRequest : IRequest<AddDocResponse>
    {
		public int Trn_GidNumer { get; set; }
		public int Trn_GidTyp { get; set; }
		public uint Trn_Stan { get; set; }
		public string Trn_NrDokumentu { get; set; }	 
		public DateTime Trn_DataSkan { get; set; }
		public int DclMagKod { get; set; } 	 
		public string Fmm_NrListu { get; set; } 
		public string Fmm_NrlistuPaczka { get; set; }
				 
	}
}
