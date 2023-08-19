using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using WebApplication2.Data;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
	public class RegistrationController : Controller
	{

		private readonly DataContext ndb;

        public RegistrationController(DataContext db)
        {
			ndb = db;
        }

        public IActionResult AdminRegistration()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AdminRegistration(Admin user)
		{
			var newusr = new Admin();
			newusr.UserName = user.UserName;
			newusr.Password = user.Password;
			newusr.Email = user.Email;
			newusr.Address = user.Address;
			newusr.Gender = user.Gender;
			newusr.Branch = user.Branch;
			newusr.Name = user.Name;
			
			ndb.Admins.Add(newusr);
			ndb.SaveChanges();
			return RedirectToAction("Index", "Home");
			
		}



	}
}
