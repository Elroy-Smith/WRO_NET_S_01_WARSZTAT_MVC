using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoneBook.Controllers
{
    public class PersonController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(SourceManager.Get(0, 10));
        }
		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
	    public IActionResult Add(PersonModel personModel)
	    {
			if(ModelState.IsValid)
			{
				
				var id = SourceManager.Add(personModel);
				return Content("Dodano " + id);
			}
				return View(personModel);
	    }
	}
}
