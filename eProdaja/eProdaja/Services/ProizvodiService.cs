using AutoMapper;
using eProdaja.Database;
using eProdaja.Models;
using eProdaja.Models.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiService : BaseCRUDService<Models.Proizvodi,Database.Proizvodi,Models.ProizvodiSearchObject,ProizvodiInsertRequest, ProizvodiUpdateRequest>, IProizvodiService
    {
        private eProdajaContext _db;
        protected readonly IMapper _mapper;
        public ProizvodiService(eProdajaContext db, IMapper mapper) : base (db,mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public override IEnumerable<Models.Proizvodi> Get(Models.ProizvodiSearchObject search = null)
        {
            var entity = _db.Set<Database.Proizvodi>().AsQueryable(); // da bi mogli unutar if izraza pisati query

            if (!string.IsNullOrEmpty(search.Naziv))
            {
                entity = entity.Where(w => w.Naziv.Contains(search.Naziv));
            }
            if (search.VrstaId.HasValue)
            {
                entity = entity.Where(w => w.VrstaId == search.VrstaId);
            }
            if(search.JedinicaMjereId.HasValue)
            {
                entity = entity.Where(w => w.JedinicaMjereId == search.JedinicaMjereId);
            }

            var list = entity.ToList();

            return _mapper.Map<IEnumerable<Models.Proizvodi>>(list);
        }
    }
}
