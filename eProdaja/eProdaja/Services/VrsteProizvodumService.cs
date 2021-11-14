using AutoMapper;
using eProdaja.Database;
using eProdaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class VrsteProizvodumService : BaseReadService<Models.VrsteProizvodum,Database.VrsteProizvodum,Models.VrsteProizvodumSearchObject>, IVrsteProizvodumService
    {
        public VrsteProizvodumService(eProdajaContext db, IMapper mapper) : base(db,mapper)
        {
        }
    }
}
