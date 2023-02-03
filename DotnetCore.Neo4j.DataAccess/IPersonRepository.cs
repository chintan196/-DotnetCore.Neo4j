using DotnetCore.Neo4j.Entities.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotnetCore.Neo4j.DataAccess
{
    public interface IPersonRepository
    {
        /// <summary>
        /// Searches the name of the persons.
        /// </summary>
        /// <param name="searchString">The search string.</param>
        /// <returns>System.Threading.Tasks.Task&lt;System.Collections.Generic.List&lt;System.Collections.Generic.Dictionary&lt;string, object&gt;&gt;&gt;.</returns>
        Task<List<Dictionary<string, object>>> SearchPersonsByName(string searchString);

        /// <summary>
        /// Adds a new person
        /// </summary>
        /// <param name="person">Person object</param>
        /// <returns>Boolean to indicate of person save was successful or not.</returns>
        Task<bool> AddPerson(Person person);

        /// <summary>
        /// Get count of persons
        /// </summary>
        /// <returns>Count of persons</returns>
        Task<long> GetPersonCount();
    }
}
