using eProdaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IKorisniciService
    {
        public IEnumerable<Models.Korisnici> Get();

        //public Models.Korisnici GetById(int id);
    }
}
