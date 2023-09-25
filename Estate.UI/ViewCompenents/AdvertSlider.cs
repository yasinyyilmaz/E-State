using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Estate.UI.ViewCompenents
{
    public class AdvertSlider : ViewComponent
    {
        ImageService im;
        public AdvertSlider(ImageService im)
        {
            this.im = im;
        }

        public IViewComponentResult Invoke()
        {

            var list = im.List(x => x.Status == true);
            return View(list);
        }
    }
}
