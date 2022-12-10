using Microsoft.AspNetCore.Mvc;
using BakeryOrder.Models;

namespace BakeryOrder.Controllers
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