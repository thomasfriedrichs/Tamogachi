using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ThomasTamogachis.Models;

namespace ThomasTamogachis.Controllers
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
      Tamogachi newTamogachi = new Tamogachi(name);
      return RedirectToAction("Index");
    }

    // Show

    [HttpPost("/tamogachis/{id}")]
    public ActionResult Show(int searchId)
    {
      Tamogachi currentTamogachi = Tamogachi.Find(searchId);
      return View(currentTamogachi);
    }

    // Edit name

    // [HttpGet("/tamogachis/{id}/edit")]
    // public ActionResult Edit(int searchId)
    // {
    //   return View();
    // }

    // [HttpPatch("/tamogachis/{id}/edit")]
    // public ActionResult Edit(name)
    // {
    //   Tam
    // }

    // Update

    

    // Destroy

  }
}