using System.Collections.Generic;
namespace LeeAllenFarmAndTrucking.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhone { get; set; }
        public string ClientEmail { get; set; }
        public ICollection<Order> orders { get; set; }
    }

}
