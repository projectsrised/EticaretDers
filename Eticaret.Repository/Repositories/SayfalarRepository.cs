using Eticaret.DAL.Data;
using Eticaret.DAL.Models;
using Eticaret.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Repository.Repositories
{
    public class SayfalarRepository:ISayfalarRepository
    {
        private readonly AppDbContext appDbContext;
        public SayfalarRepository(AppDbContext dbContext)
        {
            appDbContext = dbContext;
        }
        public async Task<int> Create(Sayfalar entity)
        {
            var obj = appDbContext.Add<Sayfalar>(entity);
            await appDbContext.SaveChangesAsync();
            return obj.Entity.Id;
        }

        public async Task Remove(int Id)
        {
            var obj = appDbContext.Sayfalars.Find(Id);
            appDbContext.Remove(obj);
            appDbContext.SaveChangesAsync().Wait();

        }

        public IQueryable<Sayfalar> GetAll()
        {
            var obj = appDbContext.Sayfalars.ToList();
            return obj.AsQueryable();
        }

        public async Task<IList<Sayfalar>> GetAllAsync(Expression<Func<Sayfalar, bool>> predicate = null, params Expression<Func<Sayfalar, object>>[] includeProperties)
        {
            IQueryable<Sayfalar> query = appDbContext.Set<Sayfalar>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }
            return await query.AsNoTracking().ToListAsync();
        }

        public Sayfalar? GetById(int? Id)
        {
            var obj = appDbContext.Sayfalars.Where(a => a.Id == Id).FirstOrDefault();
            return obj;
        }

        public async Task Update(Sayfalar entity)
        {
            var obj = appDbContext.Update(entity);
            await appDbContext.SaveChangesAsync();
        }
    }
}
