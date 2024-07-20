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
    public class KategoriRepository:IKategoriRespository
    {
        private readonly AppDbContext appDbContext;
        public KategoriRepository(AppDbContext dbContext)
        {
            appDbContext = dbContext;
        }
        public async Task<int> Create(Kategori entity)
        {
            var obj = appDbContext.Add<Kategori>(entity);
       
            await appDbContext.SaveChangesAsync();
            return obj.Entity.Id;
        }

        public async Task Remove(int Id)
        {
            var obj = appDbContext.Kategoris.Find(Id);
            appDbContext.Remove(obj);
            appDbContext.SaveChangesAsync().Wait();

        }

        public IQueryable<Kategori> GetAll()
        {
            var obj = appDbContext.Kategoris.ToList();
            return obj.AsQueryable();
        }

        public async Task<IList<Kategori>> GetAllAsync(Expression<Func<Kategori, bool>> predicate = null, params Expression<Func<Kategori, object>>[] includeProperties)
        {
            IQueryable<Kategori> query = appDbContext.Set<Kategori>();
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

        public Kategori? GetById(int? Id)
        {
            var obj = appDbContext.Kategoris.Where(a => a.Id == Id).FirstOrDefault();
            return obj;
        }

        public async Task Update(Kategori entity)
        {
            var obj = appDbContext.Update(entity);
            await appDbContext.SaveChangesAsync();
        }
    }
}
