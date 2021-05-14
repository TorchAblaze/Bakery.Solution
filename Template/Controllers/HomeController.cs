using Microsoft.AspNetCore.Mvc;

namespace TemplateNameSpace.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    // for photos:
    // [Route("/favorite_photos")]
    // public ActionResult FavoritePhotos()
    // {
    //   return View();
    // }

  }
}