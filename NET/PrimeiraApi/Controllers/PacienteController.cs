using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PrimeiraApi.Models.DTOs;
using PrimeiraApi.Repository.Interfaces;


namespace PrimeiraApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteRepository _repository;
        private readonly IMapper _mapper;
        public PacienteController(IPacienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
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

            var pacienteRetorno = _mapper.Map<PacienteDetalhesDTO>(paciente);

            /*
            // A biblioteca mapper faz isso abaixo:
                        var pacienteRetorno = new PacienteDetalhesDTO
                        {
                            Id = paciente.Id,
                            Nome = paciente.Nome,
                            Celular = paciente.Celular,
                            Email = paciente.Email,
                            Consultas = new List<Consulta>()
                        };
            */
            return pacienteRetorno != null ? Ok(pacienteRetorno) : BadRequest("Paciente não encontrado");
        }
    }
}
