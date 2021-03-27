using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.SzachoAPI
{
    public interface IWebSzacho
    {
        Task<IList<T>> GetList<T>(string query);
        Task<T> GetObject<T>(string query);
    }
}
