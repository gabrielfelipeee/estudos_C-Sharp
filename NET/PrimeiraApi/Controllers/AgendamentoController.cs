using Microsoft.AspNetCore.Mvc;
using PrimeiraApi.Models.Entities;
using System.Collections.Generic;
namespace PrimeiraApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendamentoController : ControllerBase
    {
        List<Agendamento> agendamentos = new List<Agendamento>();
        public AgendamentoController()
        {
            agendamentos.Add(new Agendamento
            {
                Id = 1,
                Nome = "Gabriel",
                Horario = new DateTime(2024, 04, 16)
            });
            agendamentos.Add(new Agendamento
            {
                Id = 2,
                Nome = "Felipe",
                Horario = new DateTime(2024, 04, 17)
            });
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(agendamentos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var agendamentoSelecionado = agendamentos.FirstOrDefault(x => x.Id == id);
            return agendamentoSelecionado != null
            ? Ok(agendamentoSelecionado)
            : BadRequest("Erro ao buscar um agendamento");
        }
    }
}
