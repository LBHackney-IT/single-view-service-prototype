using Data;
using Models;
using System.Security.Claims;
using static System.Runtime.InteropServices.RuntimeInformation;

namespace Resolvers
{
    public class Query
    {
        public List<Movie> GetMovies()
        {
            return Seed.SeedData();
        }

        public Movie? GetMovieById(int id) =>
            Seed.SeedData().FirstOrDefault(x => x.Id == id);

        public string SysInfo =>
            $"{FrameworkDescription} running on {RuntimeIdentifier}";
    }
}
