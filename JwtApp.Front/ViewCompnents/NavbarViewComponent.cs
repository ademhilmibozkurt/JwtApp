using Microsoft.AspNetCore.Mvc;

namespace JwtApp.Front.ViewCompnents
{
    public class NavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
