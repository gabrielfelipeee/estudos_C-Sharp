using PrimeiraApi.Interfaces;
using PrimeiraApi.Models.DTOs;
using PrimeiraApi.Models.Entities;

namespace PrimeiraApi.Repository.Interfaces
{
    public interface IPacienteRepository : IBaseRepository
    {
        Task<IEnumerable<PacienteDTO>> GetPacientesAsync(); // Método para buscar todos os pacientes
       Task<Paciente> GetPacientesByIdAsync(int id); // método para buscar um paciente pelo id
    }
}
