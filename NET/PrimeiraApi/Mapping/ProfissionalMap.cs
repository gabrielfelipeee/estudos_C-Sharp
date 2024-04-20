using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimeiraApi.Models.Entities;

namespace PrimeiraApi.Mapping
{
    public class ProfissionalMap : BaseMap<Profissional>
    {
        public ProfissionalMap() : base("tb_profissional") { }

        public override void Configure(EntityTypeBuilder<Profissional> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo");

            // muitos-para-muitos (NN)
            builder.HasMany(x => x.Especialidades) // especialidades pode ter muitos profissionais 
                .WithMany(x => x.Profissionais) // profissionais pode ter muitas especialidades
                .UsingEntity<ProfissionalEspecialidade>( // tipo da tabela, que irá fazer a intermediação de NN
                    x => x.HasOne(p => p.Especialidade).WithMany().HasForeignKey(x => x.EspecialidadeId), 
                    x => x.HasOne(p => p.Profissionais).WithMany().HasForeignKey(x => x.ProfissionalId),

                    // Configurações adicionais da tabela intermediária
                    x =>
                    {
                        // Define o nome da tabela intermediária como "tb_profissional_especialidade"
                        x.ToTable("tb_profissional_especialidade");

                        // Define a chave primária composta da tabela intermediária
                        x.HasKey(p => new { p.EspecialidadeId, p.ProfissionalId }); // chave composta

                        // Mapeia a coluna EspecialidadeId para "id_especialidade" e define como obrigatória
                        x.Property(p => p.EspecialidadeId).HasColumnName("id_especialidade").IsRequired();

                        // Mapeia a coluna ProfissionalId para "id_profissional" e define como obrigatória
                        x.Property(p => p.ProfissionalId).HasColumnName("id_profissional").IsRequired();
                    }
                );
        }
    }
}
