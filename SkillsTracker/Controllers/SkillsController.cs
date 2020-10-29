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

        public IActionResult Form()
        {
            string html = "<form method = 'post' action = '/skills/form/'>" +
                "<input type='date' label='Date: ' name='date'/>" +
                "<br>" +
                "<label for='csharp'>" + "C#:" + "</label>" +
                "<select name='csharp'>" +
                "<option value='Learning Basics'>" + "Learning Basics" + "</option>" +
                "<option value='Making Apps'>" + "Making Apps" + "</option>" +
                "<option value='Master Coder'>" + "Master Coder" + "</option>" +
                "</select>" +
                "<br>" +
                "<label for='javaScript'>" + "JavaScript:" + "</label>" +
                "<select name='javaScript'>" +
                "<option value='Learning Basics'>" + "Learning Basics" + "</option>" +
                "<option value='Making Apps'>" + "Making Apps" + "</option>" +
                "<option value='Master Coder'>" + "Master Coder" + "</option>" +
                "</select>" +
                "<br>" +
                "<label for='python'>" + "Python:" + "</label>" +
                "<select name='python'>" +
                "<option value='Learning Basics'>" + "Learning Basics" + "</option>" +
                "<option value='Making Apps'>" + "Making Apps" + "</option>" +
                "<option value='Master Coder'>" + "Master Coder" + "</option>" +
                "</select>" +
                "<br>" +
                "<input type='submit' value='Submit'/>" +
                "</form>";
            return Content(html, "text/html");
        }

        [HttpPost]
        public IActionResult Form(string date, string csharp, string javaScript, string python)
        {
            string html ="<h1>" + date + "</h1>" +
                "<ol>" +
                "<li>" + "C#: " + csharp + "</li>" +
                "<li>" + "JavaScript: " + javaScript + "</li>" +
                "<li>" + "Python: " + python + "</li>" +
                "</ol>";
            return Content(html, "text/html");
        }
    }
}
