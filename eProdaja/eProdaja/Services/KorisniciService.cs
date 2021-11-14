using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class KorisniciService : BaseReadService<Models.Korisnici,Database.Korisnici,Models.KorisniciSearchObject>, IKorisniciService
    {
        
        public KorisniciService(eProdajaContext db, IMapper mapper) : base(db,mapper)
        {
        }

        public override IEnumerable<Models.Korisnici> Get(Models.KorisniciSearchObject request = null)
        {
            var entity = _db.Set<Database.Korisnici>().AsQueryable(); // da bi mogli unutar if izraza pisati query

            if (!string.IsNullOrEmpty(request.Ime))
            {
                entity = entity.Where(w => w.Ime.Contains(request.Ime));
            }

            var list = entity.ToList();

            return _mapper.Map<IEnumerable<Models.Korisnici>>(list);
        }

    }
}
