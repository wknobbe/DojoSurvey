using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.DojoSurveyController
{
    public class DojoSurveyController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost("result")]
        public IActionResult Result(string Name, string Location, string Language, string Comments)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comments = Comments;
            return View();
        }

    }
}