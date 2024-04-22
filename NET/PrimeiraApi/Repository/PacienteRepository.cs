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

        public IEnumerable<Paciente> GetPacientes()
        {
            return _context.Pacientes.Include(x => x.Consultas).ToList();

        }

        public Paciente GetPacientesById(int id)
        {
            return _context.Pacientes.Include(x => x.Consultas).Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
