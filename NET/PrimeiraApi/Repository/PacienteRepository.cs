using Microsoft.EntityFrameworkCore;
using PrimeiraApi.Context;
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

        public async Task<IEnumerable<Paciente>> GetPacientesAsync()
        {
            return await _context.Pacientes.Include(x => x.Consultas).ToListAsync();

        }

        public async Task<Paciente> GetPacientesByIdAsync(int id)
        {
            return await _context.Pacientes.Include(x => x.Consultas).Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
