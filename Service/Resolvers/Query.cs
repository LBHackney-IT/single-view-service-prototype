using static System.Runtime.InteropServices.RuntimeInformation;

namespace Service.Resolvers
{
    public class Query
    {
        public Query()
        {
        }

        public SearchResult Search([Service]ISearch search) => new SearchResult(search);

        public string SysInfo =>
            $"{FrameworkDescription} running on {RuntimeIdentifier}";
    }
}
