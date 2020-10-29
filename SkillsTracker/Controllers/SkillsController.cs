using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            string html = "<h1>" + "Skills Tracker" + "</h1>" +
                "<h2>" + "Skills to learn:" + "</h2>" +
                "<ol>" +
                "<li>" + "C#" + "</li>" +
                "<li>" + "JavaScript" + "</li>" +
                "<li>" + "Python" + "</li>" +
                "</ol>";
            return Content(html, "text/html");
        }
    }
}
