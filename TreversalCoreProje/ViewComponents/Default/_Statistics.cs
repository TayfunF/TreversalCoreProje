using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TreversalCoreProje.ViewComponents.Default
{
    public class _Statistics : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var _context = new AppDbContext();
            ViewBag.Destinations = _context.Destinations.Count();
            ViewBag.Guides = _context.Guides.Count();
            ViewBag.Customers = "285";
            return View();
        }
    }
}
