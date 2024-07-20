using Eticaret.BAL.Common;
using Eticaret.BAL.Interfaces;
using Eticaret.DAL.Models;
using Eticaret.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.BAL.Services
{
    public class MakaleService:IMakaleService
    {
        private readonly IMakaleRepository makaleRepository;
        public MakaleService(IMakaleRepository _makaleRepository)
        {
            makaleRepository = _makaleRepository; 
        }
        public Task<IList<Makale>> GetAllAsync(Expression<Func<Makale, bool>> predicate = null, params Expression<Func<Makale, object>>[] includeProperties)
        {
            return makaleRepository.GetAllAsync(predicate, includeProperties);
        }

        async Task<int> IService<Makale>.Create(Makale entity)
        {
            var obj = await makaleRepository.Create(entity);
            return obj;
        }

        async Task IService<Makale>.Delete(int Id)
        {
            await makaleRepository.Remove(Id);
        }

        IQueryable<Makale> IService<Makale>.GetAll()
        {
            return makaleRepository.GetAll();
        }

        Makale? IService<Makale>.GetById(int Id)
        {
            return makaleRepository.GetById(Id);
        }

        async Task IService<Makale>.Update(Makale entity)
        {
            await makaleRepository.Update(entity);
        }
    }
}
