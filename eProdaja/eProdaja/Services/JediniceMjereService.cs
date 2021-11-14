﻿using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class JediniceMjereService : BaseReadService<Models.JediniceMjere,JediniceMjere,Models.JediniceMjereSearchObject>, IJediniceMjereService
    {
        public JediniceMjereService(eProdajaContext db, IMapper mapper) : base (db,mapper)
        {

        }
    }
}
