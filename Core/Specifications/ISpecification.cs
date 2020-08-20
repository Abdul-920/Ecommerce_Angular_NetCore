using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specifications
{
    // Expression will be stored as objects
    public interface ISpecification<T>
    {
         // Find By Id, Find By Name Etc
         Expression<Func<T,bool>> Criteria {get;}
         // addreferential properties
         List<Expression<Func<T,object>>> Includes {get;}
         Expression<Func<T, object>> OrderBy {get;}
         Expression<Func<T, object>> OrderByDescending {get;}

         int Take {get;}
         int Skip {get;}
         bool IsPagingEnabled {get;}
    }
}