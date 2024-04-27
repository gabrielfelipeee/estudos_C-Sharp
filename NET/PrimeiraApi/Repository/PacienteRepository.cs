using Microsoft.EntityFrameworkCore;
using PrimeiraApi.Context;
using PrimeiraApi.Models.DTOs;
using PrimeiraApi.Models.Entities;
using PrimeiraApi.Repository.Interfaces;

namespace PrimeiraApi.Repository
{
    public class PacienteRepository : BaseRepository, IPacienteRepository
    {
        private readonly ConsultorioContext _context;
        public PacienteRepository(ConsultorioContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PacienteDTO>> GetPacientesAsync()
        {
            return await _context.Pacientes
                .Select(x => new PacienteDTO { Id = x.Id, Nome = x.Nome })
                .ToListAsync();

        }

        public async Task<Paciente> GetPacientesByIdAsync(int id)
        {
            return await _context.Pacientes.Include(x => x.Consultas)
                .ThenInclude(x => x.Especialidade)
                .ThenInclude(p => p.Profissionais)
                .Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
