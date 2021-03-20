using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess.Entities
{
    public class Raport: EntityBase
	{

		//public List<Item> Items { get; set; }

		public int MsR_MagNumer { get; set; }
		public int MsR_TrnNumer { get; set; }
		public int MsR_TwrNumer { get; set; }
		public int MsR_Ilosc { get; set; }
		public int MsR_TypDok { get; set; }
		public byte MsR_StanDok { get; set; }
		public DateTime MsR_Data { get; set; }
		public int MsR_NewGidNumer { get; set; }
	}
}
