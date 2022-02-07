using Data;
using Models;
using System.Security.Claims;
using Hackney.Shared.HousingSearch.Domain.Asset;
using Hackney.Shared.HousingSearch.Domain.Person;
using static System.Runtime.InteropServices.RuntimeInformation;
using Tenure = Hackney.Shared.HousingSearch.Domain.Tenure.Tenure;

namespace Service.Resolvers
{
    public class Query
    {
        public List<Person> SearchPerson()
        {
            return new List<Person>();
        }

        public List<Tenure> SearchTenure()
        {
            return new List<Tenure>();
        }
        public List<Asset> SearchAsset()
        {
            return new List<Asset>();
        }

        public string SysInfo =>
            $"{FrameworkDescription} running on {RuntimeIdentifier}";
    }
}
