using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Estate.UI.Controllers
{
    public class AdvertController : Controller
    {
        ImageService im;
        AdvertService advert;

        public AdvertController(ImageService im, AdvertService advert)
        {
            this.im = im;
            this.advert = advert;
        }

        public IActionResult Details(int id)
        {
            var detail = advert.GetById(id);
            var image = im.List(x => x.AdvertId == id);

            ViewBag.imgs = image;
            return View(detail);

        }
    }
}
