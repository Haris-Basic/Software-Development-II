using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class BaseReadService<T, TDb, TSearch> : IReadService<T, TSearch> where T : class where TDb : class where TSearch : class
    {
        protected  eProdajaContext _db;
        protected readonly IMapper _mapper;
        public BaseReadService(eProdajaContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public virtual IEnumerable<T> Get(TSearch search = null)
        {
            var set = _db.Set<TDb>();

            var list = set.ToList();

            return _mapper.Map<List<T>>(list);
        }

        public virtual T GetById(int id)
        {
            var set = _db.Set<TDb>();

            var entity = set.Find(id);

            return _mapper.Map<T>(entity);
        }
    }
}
