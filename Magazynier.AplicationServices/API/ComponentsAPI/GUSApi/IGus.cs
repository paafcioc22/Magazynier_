using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.GUSApi
{
    public interface IGus
    {
        Task<T> szukajPodmioty<T>(string nip);
    }
}
