using Powers.HappyEvent.Abstracts;

namespace Powers.HappyEvent.WebApi.Repository
{
    public interface IGeneralRepository<T> where T : EntityBase
    {
        IQueryable<T> GetQueryable();

        Task<IEnumerable<T>> FindAll();

        Task<T> FirstOrDefault(Guid id);

        Task Insert(T entity);

        Task Update(T entity);

        Task Delete(T entity);
    }
}
