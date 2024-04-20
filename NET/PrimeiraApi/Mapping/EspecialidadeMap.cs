using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimeiraApi.Models.Entities;

namespace PrimeiraApi.Mapping
{
    public class EspecialidadeMap : BaseMap<Especialidade>
    {
        public EspecialidadeMap() : base("tb_especialidade")
        { }
        public override void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Nome).HasColumnName("nome").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Ativa).HasColumnName("ativa").IsRequired();
        }
    }
}
