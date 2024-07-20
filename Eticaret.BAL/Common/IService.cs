using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.BAL.Common
{
    public interface IService<TEntity>
    {
        IQueryable<TEntity>? GetAll();
        Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null,
  params Expression<Func<TEntity, object>>[] includeProperties);
        TEntity? GetById(int Id);
        Task<int>? Create(TEntity entity);
        Task? Update(TEntity entity);
        Task? Delete(int Id);
    }
}
