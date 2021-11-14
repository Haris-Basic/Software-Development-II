﻿using eProdaja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseReadController<T,TSearch> : ControllerBase where T : class where TSearch:class
    {
        protected IReadService<T, TSearch> _service { get; set; }
        public BaseReadController(IReadService<T, TSearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual IEnumerable<T> Get([FromQuery]TSearch search = null)
        {
            return _service.Get(search);
        }

        [HttpPost("{id}")]
        public virtual T GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}