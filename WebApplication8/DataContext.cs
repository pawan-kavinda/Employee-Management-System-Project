using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.IO;
using WebApplication8.Models;

namespace WebApplication2.Data
{
	public class DataContext : DbContext
	{
        
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
           
        }

        public DbSet<Student> customers { get; set; }
		public DbSet<Student> StudentData { get; set; }

		public DbSet<User> Users { get; set; }
        public DbSet<EmployeeData> EmployeeData { get; set; }
        public DbSet<Admin> Admins { get; set; }
	}

    

}
