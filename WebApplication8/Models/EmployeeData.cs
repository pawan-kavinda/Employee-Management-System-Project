using System.ComponentModel.DataAnnotations;

namespace WebApplication8.Models
{
    public class EmployeeData
    {
        [Key]
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Branch { get; set; }
        public string Department{ get; set; }
        public string ContactNo { get; set; }
        public int Salary { get; set; }
    }
}
