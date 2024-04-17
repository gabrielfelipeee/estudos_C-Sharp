using Microsoft.EntityFrameworkCore;
using PrimeiraApi.Models.Entities;

namespace PrimeiraApi.Context
{
    public class ConsultorioContext : DbContext
    {
        // base(options) é o método cpntrutor  da Classe DbContext
        public ConsultorioContext(DbContextOptions<ConsultorioContext> options) : base(options)
        {

        }

        public DbSet<Agendamento> Agendamentos { get; set; }


        // Esse método permite que configurar o modelo de dados, especificando detalhes como mapeamento de propriedades para colunas de banco de dados, configuração de chaves primárias e estrangeiras, entre outras coisas.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Agendamento>().ToTable("tb_agendamento");
        }
    }
}
