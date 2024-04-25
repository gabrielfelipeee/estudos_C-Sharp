using PrimeiraApi.Interfaces;
using PrimeiraApi.Models.Entities;

namespace PrimeiraApi.Repository.Interfaces
{
    public interface IPacienteRepository : IBaseRepository
    {
        Task<IEnumerable<Paciente>> GetPacientesAsync(); // Método para buscar todos os pacientes
       Task<Paciente> GetPacientesByIdAsync(int id); // método para buscar um paciente pelo id
    }
}
