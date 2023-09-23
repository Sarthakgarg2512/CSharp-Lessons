using Microsoft.AspNetCore.Mvc;

namespace MVCApp2.Controllers
{
    public class PartialViewController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tabs()
        {
            ViewData["data1"] = "Tom and Jerry are Good Friends";
            return View();
        }
    }
}
