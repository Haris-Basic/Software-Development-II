using eProdaja.Models;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class KorisniciController : BaseReadController<Models.Korisnici,Models.KorisniciSearchObject>
    {
        
        public KorisniciController(IKorisniciService service) : base (service)
        {

        }
    }
}
