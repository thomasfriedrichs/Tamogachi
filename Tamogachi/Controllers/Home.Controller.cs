using Microsoft.AspNetCore.Mvc;

namespace Tamogachi.Controllers
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
