using Microsoft.AspNetCore.Mvc;

namespace TreversalCoreProje.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
