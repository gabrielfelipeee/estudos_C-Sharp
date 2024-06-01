using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimeiraApi.Interfaces;
using PrimeiraApi.Models.DTOs;

namespace PrimeiraApi.Repository.Interfaces
{
    public interface IProfissionalRepository : IBaseRepository
    {
        Task<IEnumerable<ProfissionalDTO>> GetProfissionais();
    }
}