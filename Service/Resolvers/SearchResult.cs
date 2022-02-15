using Service.Boundary.HackneyApi.HousingSearh;
using Service.Resolvers.Models;

namespace Service.Resolvers
{
    public class SearchResult
    {
        ISearch housingSearch;
        public SearchResult(ISearch search)
        {
            housingSearch = search;
        }

        public async Task<SearchResult<Assets>> Assets(string searchText, int? pageSize, int? page, AssetTypes? assetTypes, string? propertyReference, string? x_correlation_id, System.Threading.CancellationToken cancellationToken)
        {
            var r = await housingSearch.Assets(searchText, pageSize, page, assetTypes, propertyReference, x_correlation_id, cancellationToken);
            return new Models.SearchResult<Assets>()
            {
                Total = r.Total ?? 0,
                Page = r.Results.Assets
            };
        }

        public async Task<Models.SearchResult<Persons>> Persons(string searchText, int? pageSize, int? page, string? sortBy, bool? isDesc, string? x_correlation_id, System.Threading.CancellationToken cancellationToken) {
            var r = await housingSearch.Persons(searchText, pageSize, page, sortBy, isDesc, x_correlation_id, cancellationToken);
            return new Models.SearchResult<Persons>()
            {
                Total = r.Total ?? 0,
                Page = r.Results.Persons
            };
        }

        public async Task<Models.SearchResult<Tenures>> Tenures(string searchText, int? pageSize, int? page, string? x_correlation_id, System.Threading.CancellationToken cancellationToken)  {
            var r = await housingSearch.Tenures(searchText, pageSize, page, x_correlation_id, cancellationToken);
            return new Models.SearchResult<Tenures>()
            {
                Total = r.Total ?? 0,
                Page = r.Results.Tenures
            };
        }
            

        public async Task<Models.SearchResult<ICollection<Transaction>>> Transactions(string? searchText, string? targetId, int? pageSize, int? page, System.DateTimeOffset? startDate, System.DateTimeOffset? endDate, bool? isSuspense, string? x_correlation_id, System.Threading.CancellationToken cancellationToken)
        {
            var r = await housingSearch.Transactions(searchText, targetId, pageSize, page, startDate, endDate, isSuspense, x_correlation_id, cancellationToken);
            return new Models.SearchResult<ICollection<Transaction>>()
            {
                Total = (int)(r.Total ?? 0),
                Page = r.Results
            };
        }
        
    }
}