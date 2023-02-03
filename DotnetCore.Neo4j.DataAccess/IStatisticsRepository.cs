using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotnetCore.Neo4j.DataAccess
{
    /// <summary>
    ///   Statistics Repository
    /// </summary>
    public interface IStatisticsRepository
    {
        Task<Dictionary<string, object>> GetEntityWiseCount();
    }
}