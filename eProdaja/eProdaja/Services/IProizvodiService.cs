using eProdaja.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IProizvodiService : ICRUDService<Models.Proizvodi,Models.ProizvodiSearchObject,ProizvodiInsertRequest,ProizvodiUpdateRequest>
    {
       
    }
}
