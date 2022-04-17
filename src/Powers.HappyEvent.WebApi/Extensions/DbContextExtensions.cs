using Microsoft.EntityFrameworkCore;
using Powers.HappyEvent.Abstracts;

namespace Powers.HappyEvent.WebApi.Extensions
{
    public static class DbContextExtensions
    {
        /// <summary>
        /// 添加实体到数据库上下文中
        /// </summary>
        /// <param name="modelBuilder"> </param>
        /// <param name="entityType">   </param>
        /// <returns> </returns>
        public static ModelBuilder AddEntityTypes(this ModelBuilder modelBuilder, Type entityType)
        {
            var types = entityType.Assembly.GetTypes().AsEnumerable();
            var entityTypes = types.Where(t => !t.IsAbstract && t.IsSubclassOf(entityType));

            foreach (var type in entityTypes)
            {
                if (modelBuilder.Model.FindEntityType(type) is null)
                {
                    modelBuilder.Model.AddEntityType(type);
                }
            }

            return modelBuilder;
        }
    }
}
