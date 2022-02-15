using Service.Boundary.HackneyApi.HousingSearh;
using Service.Gateways;
using System.Net.Http.Headers;

namespace Service.Resolvers.Implementation
{
    public class Search: ISearch
    {
        private Client housingSearch;

        public Search(IHttpClientFactory cf, IHttpContextAccessor ctx, HackneyApi cfg)
        {
            var client = cf.CreateClient();
            var contextAccessor = ctx;
            client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(
                contextAccessor.HttpContext?.Request.Headers.Authorization.FirstOrDefault());
            
            this.housingSearch = new Client(client)
            {
                BaseUrl = cfg.HousingSearchAPI.ToString()
            };
        }

        public Task<AssetResult> Assets(string searchText, int? pageSize, int? page, AssetTypes? assetTypes, string propertyReference, string x_correlation_id, System.Threading.CancellationToken cancellationToken) =>
         housingSearch.AssetsAsync(searchText, pageSize, page, assetTypes, propertyReference, null, cancellationToken);
        
        public Task<PersonResult> Persons(string searchText, int? pageSize, int? page, string sortBy, bool? isDesc, string x_correlation_id, System.Threading.CancellationToken cancellationToken) => 
         housingSearch.PersonsAsync(searchText, pageSize, page, sortBy, isDesc, string.Empty, cancellationToken);

        public Task<TenureResult> Tenures(string searchText, int? pageSize, int? page, string x_correlation_id, System.Threading.CancellationToken cancellationToken) =>
            housingSearch.TenuresAsync(searchText, pageSize, page, string.Empty, cancellationToken);

        public Task<TransactionsResponse> Transactions(string searchText, string targetId, int? pageSize, int? page, System.DateTimeOffset? startDate, System.DateTimeOffset? endDate, bool? isSuspense, string x_correlation_id, System.Threading.CancellationToken cancellationToken) =>
            housingSearch.TransactionsAsync(searchText, targetId, pageSize, page, startDate, endDate, isSuspense, string.Empty, cancellationToken);
    }
}
