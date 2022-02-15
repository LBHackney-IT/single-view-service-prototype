using Service.Boundary.HackneyApi.HousingSearh;

namespace Service.Resolvers
{
    public interface ISearch
    {
        public Task<AssetResult> Assets(string searchText, int? pageSize, int? page, AssetTypes? assetTypes, string propertyReference, string x_correlation_id, System.Threading.CancellationToken cancellationToken);
        public Task<PersonResult> Persons(string searchText, int? pageSize, int? page, string sortBy, bool? isDesc, string x_correlation_id, System.Threading.CancellationToken cancellationToken);
        public Task<TenureResult> Tenures(string searchText, int? pageSize, int? page, string x_correlation_id, System.Threading.CancellationToken cancellationToken);
        public Task<TransactionsResponse> Transactions(string searchText, string targetId, int? pageSize, int? page, System.DateTimeOffset? startDate, System.DateTimeOffset? endDate, bool? isSuspense, string x_correlation_id, System.Threading.CancellationToken cancellationToken);
    }
}
