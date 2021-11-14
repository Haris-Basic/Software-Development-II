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
       
    }
}
