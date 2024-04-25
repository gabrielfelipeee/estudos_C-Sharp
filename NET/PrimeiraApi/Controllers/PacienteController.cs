using Microsoft.AspNetCore.Mvc;
using PrimeiraApi.Repository.Interfaces;


namespace PrimeiraApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteRepository _repository;
        public PacienteController(IPacienteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pacientes = await _repository.GetPacientesAsync();
            return pacientes.Any() ? Ok(pacientes) : BadRequest("Pacientes não encontrado");
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id)
        {
            var paciente = await _repository.GetPacientesByIdAsync(id);
            return paciente != null ? Ok(paciente) : BadRequest("Paciente não encontrado");
        }
    }
}
