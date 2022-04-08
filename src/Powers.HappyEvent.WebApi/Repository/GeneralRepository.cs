using Microsoft.EntityFrameworkCore;
using Powers.HappyEvent.Abstracts;
using Powers.HappyEvent.WebApi.Data;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace Powers.HappyEvent.WebApi.Repository
{
    public class GeneralRepository<T> : IGeneralRepository<T>
        where T : EntityBase
    {
        private readonly HappyEventDbContext _context;

        private readonly DbSet<T> Scheel;

        public GeneralRepository(HappyEventDbContext context)
        {
            _context = context;
            Scheel = context.Set<T>();
        }

        public async Task Delete(T entity)
        {
            if(entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            Scheel.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindAll()
        {
            return await Scheel.ToListAsync();
        }

        public async Task<T> FirstOrDefault(Guid id)
        {
            if(id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id));
            }

#pragma warning disable CS8603 // 可能返回 null 引用。
            return await Scheel.FirstOrDefaultAsync(x => x.Id == id);
#pragma warning restore CS8603 // 可能返回 null 引用。
        }

        public IQueryable<T> GetQueryable()
        {
            return Scheel;
        }

        public async Task Insert(T entity)
        {
            await Scheel.AddAsync(entity);

            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            Scheel.Update(entity);

            await _context.SaveChangesAsync();
        }
    }
}
