using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            //int saat=2;
           // var selamlama= saat >12 ? "İyi Günler" : "Günaydın";
            ViewBag.selamlama = saat >12 ? "İyi Günler" : "Günaydın";
            int UserCount = Repository.Users.Where(info => info.WillAttend ==true).Count();
            // return View(model: selamlama);

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul, Abc Kongre Merkezi",
                Date = new DateTime(2025, 05, 05,20,0,0),
                NumberOfPeople = UserCount,
            };

           return View(model:meetingInfo);
        }
    }
}
