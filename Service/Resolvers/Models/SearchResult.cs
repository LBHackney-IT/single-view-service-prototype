namespace Service.Resolvers.Models
{
    public class SearchResult<TPage>
    {
        public int Total { get; set; }
        public TPage Page { get; set; }
    }
}
