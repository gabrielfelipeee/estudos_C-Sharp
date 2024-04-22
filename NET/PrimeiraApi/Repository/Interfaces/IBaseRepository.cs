
/*
// Essa interface define o CRUD
Os métodos recebem um parâmetro do tipo genérico T, que representa a entidade a ser adicionada. O tipo T deve ser uma classe (referência) devido à restrição where T : class.
*/
namespace PrimeiraApi.Interfaces
{
    public interface IBaseRepository
    {
        public void Add<T>(T entity) where T : class;
        public void Update<T>(T entity) where T : class;
        public void Delete<T>(T entity) where T : class;
        bool SaveChanges(); //usado para salvar todas as alterações pendentes feitas no repositório.
    }
}
