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
    public class MakaleRepository : IMakaleRepository
    {
        private readonly AppDbContext appDbContext;
        public MakaleRepository(AppDbContext dbContext)
        {
            appDbContext = dbContext;
        }
        public async Task<int> Create(Makale entity)
        {
            var obj = appDbContext.Add<Makale>(entity);
            await appDbContext.SaveChangesAsync();
            return obj.Entity.Id;
        }

        public async Task Remove(int Id)
        {
            var obj = appDbContext.Makales.Find(Id);
            appDbContext.Remove(obj);
            appDbContext.SaveChangesAsync().Wait();
            
        }

        public IQueryable<Makale> GetAll()
        {
            var obj = appDbContext.Makales.ToList();
            return obj.AsQueryable();
        }

        public async Task<IList<Makale>> GetAllAsync(Expression<Func<Makale, bool>> predicate = null, params Expression<Func<Makale, object>>[] includeProperties)
        {
            IQueryable<Makale> query = appDbContext.Set<Makale>();
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

        public Makale? GetById(int? Id)
        {
            var obj = appDbContext.Makales.Where(a => a.Id == Id).FirstOrDefault();
            return obj;
        }

        public async Task Update(Makale entity)
        {
            var obj = appDbContext.Update(entity);
            await appDbContext.SaveChangesAsync();
        }
    }
}
