
using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message = $"asdfad->{DateTime.Now.ToString()}";
            return View("Index1",message);
        }

        public ViewResult Index2()
        {
            var names = new String[]
            {
                "Güney",
                "Kuzey",
                "Doğu",
                "Batı"
            };

            return View(names);
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>
            { 
                new Employee(){Id=1,FirstName="Ekin",LastName="Cömer",Age=26},
                new Employee(){Id=2,FirstName="Mert",LastName="Semin",Age=26},
                new Employee(){Id=3,FirstName="İpek",LastName="Demir",Age=26}
            };
            return View("Index3",list);
        }
       
    }

}