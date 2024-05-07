using PrimeiraApi.Context;
using PrimeiraApi.Interfaces;

namespace PrimeiraApi.Repository
{
    public class BaseRepository : IBaseRepository
    {
        private readonly ConsultorioContext _context;
        public BaseRepository(ConsultorioContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
    }
}
