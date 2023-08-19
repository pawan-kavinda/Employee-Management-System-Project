using System.ComponentModel.DataAnnotations;

namespace WebApplication8.Models
{
    public class User
    {
       
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Branch { get; set; }
        public string Gender { get; set; }

    }
}
