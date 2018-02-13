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
            Phrase newPhrase = new Phrase();
            newPhrase.SetPhrase(Request.Form["phrase"]);
            newPhrase.ToArray();
            char[] newArray = newPhrase.ToArray();
            string finalString = string.Join("", newArray);
            newPhrase.SetPhrase(finalString);


            return View(newPhrase);
        }
    }
}
