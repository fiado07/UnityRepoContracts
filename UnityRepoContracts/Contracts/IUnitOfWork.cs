using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityRepoContracts.Contracts
{

    /// <summary>
    /// Structure Unity Of Work
    /// </summary>
    /// <remarks>Fiado Baloi</remarks> 
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> Repository<T>() where T : class;

        T CustomRepository<T>() where T : class;

        T CustomRepository<T, K>() where T : class where K : class;

        IExecuteCommands ExecuteCommands();

        void Commit();

    }

}
