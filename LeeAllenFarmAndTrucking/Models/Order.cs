namespace LeeAllenFarmAndTrucking.Models
{
    public class Order
    {
        public int orderId { get; set; }
        public bool paid { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string typeService { get; set; }
        public string cost { get; set; }
        public Client client { get; set; }
       
    }
}
