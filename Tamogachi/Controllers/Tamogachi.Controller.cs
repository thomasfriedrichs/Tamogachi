using Microsoft.AspNetCore.Mvc;
using Tamogachi.Models;
using System.Collections.Generic;

namespace Tamogachi.Controllers
{
  public class TamogachiController : Controller
  {

    [HttpGet("/tamogachis")]
    public ActionResult Index()
    {
      List<Tamogachi> tamogachis = Tamogachi.GetAll();
      return View(tamogachis);
    }

    [HttpGet("/tamogachis/new")]
    public ActionResult New()
    {
      return View();
    }

    // Create
    [HttpPost("/tamogachis")]
    public ActionResult Create(string name)
    {
      Tamogachi name = new Tamogachi(name);
      return RedirectToAction("Index");
    }

    // Show

    [HttpPost("/tamogachis/{id}")]
    public ActionResult Show(int searchId)
    {
      Tamogachi currentTamogachi = Tamogachi.Find(searchId);
      return currentTamogachi;
    }

    // Edit name

    [HttpGet("/tamogachis/{id}/edit")]
    public ActionResult Edit(int searchId)
    {
      return View();
    }

    // Update

    // Destroy

  }
}