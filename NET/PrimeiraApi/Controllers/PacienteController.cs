using Microsoft.AspNetCore.Mvc;
using PrimeiraApi.Repository;
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
        public IActionResult Get()
        {
            var pacientes = _repository.GetPacientes();
            return pacientes.Any() ? Ok(pacientes) : BadRequest("Pacientes não encontrado");
        }

        [HttpGet("{id}")]
        
        public IActionResult GetById(int id)
        {
            var paciente = _repository.GetPacientesById(id);
            return paciente != null ? Ok(paciente) : BadRequest("Paciente não encontrado");
        }
    }
}
