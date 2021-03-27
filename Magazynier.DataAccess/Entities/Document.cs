using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess.Entities
{
    public class Document :EntityBase
    {
	 
		public int Trn_GidNumer { get; set; }
		 
		public int Trn_GidTyp { get; set; }
		public uint Trn_Stan { get; set; }
		[MaxLength(30)]
		public string Trn_NrDokumentu { get; set; }
		[MaxLength(30)]
		[Column(TypeName = "datetime")]
		public DateTime Trn_DataSkan { get; set; }
		public int DclMagKod { get; set; }

		[MaxLength(30)]
		public string Fmm_NrListu { get; set; }

		[MaxLength(30)]
		public string Fmm_NrlistuPaczka { get; set; }

		public List<Item> Items { get; set; }
	}
}
