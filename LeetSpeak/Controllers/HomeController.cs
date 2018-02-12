using Microsoft.AspNetCore.Mvc;
using LeetSpeak.Models;
using System.Collections.Generic;

namespace LeetSpeak.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost("/leet-phrase")]
        public ActionResult Converted()
        {
            Phrase newPhrase = new Phrase(Request.Form["phrase"]);
            return View(newPhrase);
        }
    }
}
