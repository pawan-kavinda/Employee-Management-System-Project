using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication8.Models
{
    
    public class Student
	{
        [Key]
        public int Idn { get; set; }
        public int RegNo { get; set; }
        public int Age { get; set; }
        [Required (ErrorMessage ="Name can not be empty" )]
        public string Name { get; set; }
        
        public string PhoneNmb { get; set; }
    }
}
 