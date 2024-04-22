using PrimeiraApi.Interfaces;
using PrimeiraApi.Models.Entities;

namespace PrimeiraApi.Repository.Interfaces
{
    public interface IPacienteRepository : IBaseRepository
    {
        IEnumerable<Paciente> GetPacientes(); // Método para buscar todos os pacientes
        Paciente GetPacientesById(int id); // método para buscar um paciente pelo id
    }
}
