using PrimeiraApi.Models.Entities;
using Microsoft.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PrimeiraApi.Mapping
{
    // Define uma classe genérica para mapeamento de entidades no Entity Framework Core.
    public class BaseMap<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        private readonly string _tableName; // Declara um campo privado para armazenar o nome da tabela no banco de dados associada à entidade.

        // Define um construtor que aceita o nome da tabela como parâmetro e o armazena no campo _tableName.
        public BaseMap(string tableName)
        {
            _tableName = tableName;
        }

        // Implementa o método de configuração da entidade da interface IEntityTypeConfiguration<T>.
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            // Verifica se o nome da tabela foi fornecido e, se não for nulo ou vazio, define o nome da tabela no banco de dados.
            if (!string.IsNullOrEmpty(_tableName))
            {
                builder.ToTable(_tableName);
            }

            // Define a chave primária da entidade como a propriedade Id.
            builder.HasKey(x => x.Id);

            // Define a propriedade Id como uma coluna no banco de dados chamada "id" e configura-a para ser gerada automaticamente.
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
        }
    }
}
