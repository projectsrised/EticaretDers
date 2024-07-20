using Eticaret.BAL.Common;
using Eticaret.BAL.Interfaces;
using Eticaret.DAL.Models;
using Eticaret.Repository.Interfaces;
using Eticaret.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.BAL.Services
{
    public class KategoriService:IKategoriService
    {
        private readonly IKategoriRespository KategoriRepository;
        public KategoriService(IKategoriRespository _KategoriRepository)
        {
            KategoriRepository = _KategoriRepository;
        }
        public Task<IList<Kategori>> GetAllAsync(Expression<Func<Kategori, bool>> predicate = null, params Expression<Func<Kategori, object>>[] includeProperties)
        {
            return KategoriRepository.GetAllAsync(predicate, includeProperties);
        }

        async Task<int> IService<Kategori>.Create(Kategori entity)
        {
            var obj = await KategoriRepository.Create(entity);
            return obj;
        }

        async Task IService<Kategori>.Delete(int Id)
        {
            await KategoriRepository.Remove(Id);
        }

        IQueryable<Kategori> IService<Kategori>.GetAll()
        {
            return KategoriRepository.GetAll();
        }

        Kategori? IService<Kategori>.GetById(int Id)
        {
            return KategoriRepository.GetById(Id);
        }

        async Task IService<Kategori>.Update(Kategori entity)
        {
            await KategoriRepository.Update(entity);
        }
    }
}
