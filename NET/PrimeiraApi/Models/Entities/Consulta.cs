namespace PrimeiraApi.Models.Entities
{
    public class Consulta : BaseEntity
    {
        public int PacienteId { get; set; }
        public DateTime DataHorario { get; set; }
        public int Status { get; set; }
        public decimal Preco { get; set; }
        public Paciente Paciente { get; set; }
        public int EspecialidadeId { get; set; }
        public Especialidade Especialidade { get; set; }
        public int ProfissionalId { get; set; }
        public Profissional Profissional { get; set; }
    }
}
