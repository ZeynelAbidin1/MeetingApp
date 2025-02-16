using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            Console.WriteLine("APPYLE - GET ÇALIŞTI");
            return View(); 
        }
        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            //database
            //list
            if(ModelState.IsValid){
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(info=> info.WillAttend==true).Count();
                return View("Thanks",model); 
            }else{
                return View(model);
            }
            
        }
        [HttpGet]
        public IActionResult List()
        {
            var users=Repository.Users;
            return View(users);
        }

        //meeting/details/1
        [HttpGet]
        public IActionResult Details(int id){
            return View(Repository.GetById(id));
        }
    }
}
