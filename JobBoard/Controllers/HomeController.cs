using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;
using System;
namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index(){
            return View();
        }
    }
}