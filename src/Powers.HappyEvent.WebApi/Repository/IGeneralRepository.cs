using Powers.HappyEvent.Abstracts;

namespace Powers.HappyEvent.WebApi.Repository
{
    public interface IGeneralRepository<T> where T : EntityBase
    {
        IQueryable<T> GetQueryable();

        Task<IEnumerable<T>> FindAll();

        Task<T> FirstOrDefault(Guid id);

        Task<bool> Insert(T entity);

        Task<bool> Update(T entity);

        Task<bool> Delete(T entity);
    }
}
