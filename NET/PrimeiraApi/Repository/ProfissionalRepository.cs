using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimeiraApi.Context;
using PrimeiraApi.Repository.Interfaces;

namespace PrimeiraApi.Repository
{
    public class ProfissionalRepository: BaseRepository, IProfissionalRepository
    {
        
        public ProfissionalRepository(ConsultorioContext context) : base(context)
        {
            
        }
    }
}