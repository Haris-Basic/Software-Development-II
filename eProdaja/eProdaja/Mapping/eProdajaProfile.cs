using AutoMapper;
using eProdaja.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Mapping
{
    public class eProdajaProfile : Profile
    {
        public eProdajaProfile()
        {
            CreateMap<Database.Korisnici, Models.Korisnici>();
            CreateMap<Database.JediniceMjere, Models.JediniceMjere>();
            CreateMap<Database.VrsteProizvodum, Models.VrsteProizvodum>();

            CreateMap<Database.Proizvodi, Models.Proizvodi>();

            CreateMap<ProizvodiInsertRequest,Database.Proizvodi>();
            CreateMap<ProizvodiUpdateRequest,Database.Proizvodi>();
        }
    }
}
