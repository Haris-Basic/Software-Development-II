using eProdaja.Models;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : Controller
    {
        private IKorisniciService _service { get; set; }
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Korisnici> Get()
        {
            return _service.Get();
        }

        //[HttpGet("{id}")]
        //public Korisnici GetById(int id)
        //{
        //    return _service.GetById(id);
        //}
    }
}
