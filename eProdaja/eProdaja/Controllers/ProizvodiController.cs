using eProdaja.Models;
using eProdaja.Models.Requests;
using eProdaja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class ProizvodiController : BaseCRUDController<Models.Proizvodi,Database.Proizvodi,ProizvodiSearchObject,ProizvodiInsertRequest,ProizvodiUpdateRequest>
    {
        public ProizvodiController(IProizvodiService service) : base (service)
        {
        }

    }
}
