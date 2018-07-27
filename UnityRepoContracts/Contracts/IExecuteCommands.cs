using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityRepoContracts.Common;

namespace UnityRepoContracts.Contracts
{

    public interface IExecuteCommands
    {

        #region storedProcedure
        void ExecuteStoredProcedure(string StoredProcedureName, List<Parameters> ParameterList = null);

        T ExecuteStoredProcedure<T>(string StoredProcedureName, List<Parameters> ParameterList = null);

        IEnumerable<T> ExecuteStoredProcedureGetList<T>(string StoredProcedureName, List<Parameters> ParameterList = null);

        #endregion

    }

}
