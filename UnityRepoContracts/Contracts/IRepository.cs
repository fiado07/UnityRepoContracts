using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityRepoContracts.Contracts
{


    /// <summary>
    /// Structure Repository
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface IRepository<T> where T : class
    {


        #region any

        bool Any();
        bool Any(System.Linq.Expressions.Expression<Func<T, Boolean>> predicate);

        #endregion


        #region count

        int Count();
        int Count(System.Linq.Expressions.Expression<Func<T, Boolean>> predicate);

        #endregion

        #region find

        IEnumerable<T> FindAll();
        IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, Boolean>> predicate);

        #endregion

        IEnumerable<T> Pagination(int pageIndex, int pageSize = 10);

        T GetEntity(object id);

        #region add

        void AddEntity(T entity);
        void AddEntityRange(List<T> entityList);

        #endregion

        #region remove

        void RemoveEntity(T entity);

        void RemoveEntity(System.Linq.Expressions.Expression<Func<T, Boolean>> predicate);

        void RemoveEntityRange(List<T> entityList);

        #endregion



    }

}
