using eProdaja.Database;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    
    public class JediniceMjereController : BaseReadController<Models.JediniceMjere,Models.JediniceMjereSearchObject>
    {
        public JediniceMjereController(IJediniceMjereService service) : base (service)
        {

        }
    }
}
