using eProdaja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class BaseCRUDController<T, TDb, TSearch, TInsert, TUpdate> : BaseReadController<T,TSearch> where T : class where TDb : class where TSearch : class where TInsert : class where TUpdate : class
    {
        protected readonly ICRUDService<T, TSearch, TInsert, TUpdate> _crudService;
        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _crudService = service;
        }

        [HttpPost]
        public T Insert([FromBody]TInsert requst)
        {
            return _crudService.Insert(requst);
        }

        [HttpPut("{id}")]
        public T Update(int id, [FromBody] TUpdate requst)
        {
            return _crudService.Update(id,requst);
        }
    }
}
