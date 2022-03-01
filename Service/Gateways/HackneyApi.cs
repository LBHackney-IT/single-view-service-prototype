using System.ComponentModel.DataAnnotations;

namespace Service.Gateways
{
    public class HackneyApi
    {
        [Required]
        public Uri HousingSearchAPI { get; set; }
        [Required]
        public Uri PersonAPI { get; set; }
        [Required]
        public Uri PropertiesAPI { get; set; }
        [Required]
        public Uri AssetAPI { get; set; }
        [Required]
        public Uri TenureInformationApi { get; set; }
        [Required]
        public Uri ContactDetailsApi { get; set; }
    }
}
