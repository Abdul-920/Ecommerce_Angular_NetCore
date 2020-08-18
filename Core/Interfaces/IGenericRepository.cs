using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Specifications;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T: BaseEntity
    {
        #region Methods Used With Only GenericRepository
         Task<T> GetByIdAsync(int id);
         Task<IReadOnlyList<T>> ListAllAsync();
        #endregion

        #region Methods Used With GenericRepository and SpecificationPattern
         Task<T> GetEntityWithSpec(ISpecification<T> spec);
         Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        
        #endregion
    }
}