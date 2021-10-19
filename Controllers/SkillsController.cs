using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillTracker.Controllers
{
    [Route("/skills")]
    public class SkillsController : Controller
    {
        //GET: /skills/
        public IActionResult Index()
        {
            string html =
                @"<h1>Skills Tracker</h1>
                <h2> Coding Skills to learn:</h2>
                <ol>
                    <li>C#</li>
                    <li>Javscript</li>
                    <li>Python</li>
                </ol>";

            return Content(html, "text/html");
        }

        
        [HttpGet("select")] //GET: /skills/select
        [HttpPost("select")]//POST: /skills/select

        public IActionResult Form(string testDate = "")
        {
            string html =
                @$"<form method='post' action='/skills/select'>
                    <input type='date' name='testDate'/>
                  <input type='submit' value='Submit'/>
                  </form>";
            if (testDate != "")
            {
                html += $"<p> The date you entered is { testDate } </p>";
            }

            return Content(html, "text/html");
        }
    }
}
