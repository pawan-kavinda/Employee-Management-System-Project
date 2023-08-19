using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Options;
using WebApplication2.Data;
using WebApplication8.Models;
namespace WebApplication8.Controllers
{
	public class ListController : Controller
	{

		private readonly DataContext _db;
		
		
        public ListController(DataContext db )
        {
			_db = db;
			
        }

        public IActionResult Index()
		{
			List<EmployeeData> Employee_list = _db.EmployeeData.ToList();
			return View(Employee_list);
		}

		public IActionResult Create()
		{
			ViewBag.Departmentlst = new List<string>() { "Financial", "Sales", "Accounting", "Marketing", "Management" };
			return View();
		}
		[HttpPost]
		public IActionResult Create(EmployeeData Currentemp)
		{
			var newemployee = new EmployeeData();
			{
				newemployee.ID = Currentemp.ID;
				newemployee.LastName = Currentemp.LastName;
				newemployee.FirstName = Currentemp.FirstName;
				newemployee.Address = Currentemp.Address;
				newemployee.Department = Currentemp.Department;
				newemployee.Branch = Currentemp.Branch;
				newemployee.ContactNo = Currentemp.ContactNo;
				newemployee.EmployeeID = Currentemp.EmployeeID;
				

			}

			if (ModelState.IsValid)
			{
				_db.EmployeeData.Add(newemployee);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}


			ViewBag.Departmentlst = new List<string>() {"Financial","Sales","Accounting","Marketing","Management"};
			return View();
		}

		public IActionResult Edit( int id)
		{	
			EmployeeData editemployee = _db.EmployeeData.Find(id);
			ViewBag.Departmentlst = new List<string>() { "Financial", "Sales", "Accounting", "Marketing", "Management" };
			return View(editemployee);
			
		}

		[HttpPost]
		public IActionResult Edit(EmployeeData editemployee)
		{
			ViewBag.Departmentlst = new List<string>() { "Financial", "Sales", "Accounting", "Marketing", "Management" };
			_db.EmployeeData.Update(editemployee);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}

		public IActionResult Delete(int id)
		{

			EmployeeData deleteemp = _db.EmployeeData.Find(id);
			ViewBag.Departmentlst = new List<string>() { "Financial", "Sales", "Accounting", "Marketing", "Management" };
			return View(deleteemp);
		}

		[HttpPost, ActionName("Delete")]
		public IActionResult Deleteemp(int id)
		{
			ViewBag.Departmentlst = new List<string>() { "Financial", "Sales", "Accounting", "Marketing", "Management" };
			EmployeeData deleteemp = _db.EmployeeData.Find(id);
			_db.EmployeeData.Remove(deleteemp);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}

		private static Admin loggedinadmin;//for store the information of the logged in user


        public IActionResult LoginWindow()
		{
			return View();
		}
		
		
		[HttpPost]
		public IActionResult LoginWindow(Admin usr)
		{

			var user = _db.Admins.FirstOrDefault(u => u.UserName == usr.UserName && u.Password == usr.Password);
			

			if (user != null)
			{
				loggedinadmin = user;
				return RedirectToAction("Index");
			}
			else
			{
				return View("LoginFailed");
			}
		
		}

		public IActionResult info()//view the infomation of logged admin
		{
			return View(loggedinadmin);
		}
		public IActionResult Logout()
		{
			loggedinadmin = null;
			return RedirectToAction("LoginWindow");
		}

		

	}
}
