namespace PrimeiraApi.Models.Entities
{
    public class Especialidade : BaseEntity
    {
        public string Nome { get; set; }
        public bool Ativa { get; set; }
        public List<Profissional> Profissionais { get; set; }
        public List<Consulta> Consultas { get; set; }
    }
}
