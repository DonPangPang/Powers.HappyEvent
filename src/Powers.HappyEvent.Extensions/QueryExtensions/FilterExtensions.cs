using Powers.HappyEvent.Abstracts;
using Powers.HappyEvent.Abstracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Powers.HappyEvent.Extensions.QueryExtensions
{
    public static class FilterExtensions
    {
        public static IQueryable<T> FilterEnable<T>(this IQueryable<T> query, bool enable)
            where T: EntityBase, IEnableMark
        {
            return query.Where(x => x.EnableMark == enable);
        }

        public static IQueryable<T> FilterDelete<T>(this IQueryable<T> query, bool delete)
            where T : EntityBase, IDeleteMark
        {
            return query.Where(x => x.DeleteMark == delete);
        }
    }
}
