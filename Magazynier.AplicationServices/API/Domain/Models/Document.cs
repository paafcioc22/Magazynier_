using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Domain.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Trn_NrDokumentu { get; set; }
        public string Fmm_NrListu { get; set; }
        public int Trn_GidNumer { get; set; }
        
        public List<Item> Items { get; set; }
    }
}
