using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            // var selam = saat > 21 ? "İyi Günler" : " Günaydın";
            // return View(model: selam);
            /*  
            ViewBag.selam = saat > 21 ? "İyi Günler" : " Günaydın";
            ViewBag.username = "Hakan";
            */
            /* ViewData["selam"] = saat > 21 ? "İyi Günler" : " Günaydın";
            ViewData["username"] = "Seda"; */
            // return View(ViewBag);
            // return View(ViewData);
            int UserCount = ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo()
            {
                id = 1,
                Location = "İstanbul, Kadıköy",
                Date = new DateTime(2025, 10, 10),
                NumberOfPeople = UserCount 
            };
            return View(meetingInfo);
            
        }
    }
}