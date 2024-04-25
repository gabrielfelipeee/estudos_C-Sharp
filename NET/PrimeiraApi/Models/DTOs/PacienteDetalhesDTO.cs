using PrimeiraApi.Models.Entities;

namespace PrimeiraApi.Models.DTOs
{
    public class PacienteDetalhesDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public List<Consulta> Consultas { get; set; }
    }
}
