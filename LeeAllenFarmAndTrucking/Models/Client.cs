using System.Collections.Generic;
namespace LeeAllenFarmAndTrucking.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set; }
        public ICollection<Order> orders { get; set; }
    }
}
