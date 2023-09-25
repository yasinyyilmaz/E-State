using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Estate.UI.ViewCompenents
{
    public class AdvertAll : ViewComponent
    {
        ImageService im;
        AdvertService advert;

        public AdvertAll(ImageService im, AdvertService advert)
        {
            this.im = im;
            this.advert = advert;
        }

        public IViewComponentResult Invoke()
        {

            var list = advert.List(x => x.Status == true);
            var images = im.List(x => x.Status == true);
            ViewBag.imgs = images;

            return View(list);

        }
    }
}
