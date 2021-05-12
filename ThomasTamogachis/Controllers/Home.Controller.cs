using Microsoft.AspNetCore.Mvc;

namespace ThomasTamogachis.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
