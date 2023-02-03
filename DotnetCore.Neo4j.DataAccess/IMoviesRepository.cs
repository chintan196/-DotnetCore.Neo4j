using DotnetCore.Neo4j.Entities.Common;
using DotnetCore.Neo4j.Entities.ViewModels;
using System.Threading.Tasks;

namespace DotnetCore.Neo4j.DataAccess
{
    public interface IMoviesRepository
    {
        Task<MovieListResult> SearchMoviesByFilter(MoviesFilter filterObject);
    }
}
