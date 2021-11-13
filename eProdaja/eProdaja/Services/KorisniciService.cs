using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class KorisniciService : IKorisniciService
    {
        private eProdajaContext _db;
        protected readonly IMapper _mapper;
        public KorisniciService(eProdajaContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public IEnumerable<Models.Korisnici> Get()
        {
            return _db.Korisnicis.ToList().Select(s => _mapper.Map<Models.Korisnici>(s)).ToList();
        }

        //public Models.Korisnici GetById(int id)
        //{
        //    return _db.Korisnicis.FirstOrDefault(x => x.KorisnikId == id);
        //}
    }
}
