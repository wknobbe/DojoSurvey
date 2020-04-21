using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;


namespace DojoSurvey.DojoSurveyController
{
    public class DojoSurveyController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost("survey")]
        public IActionResult Submission(string name, string location, string language, string comments)
        {
            Survey yourSurvey = new Survey()
            {
                Name = name,
                Location = location,
                Language = language,
                Comments = comments,
            };
            return View();
        }
    }
}