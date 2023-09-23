using Microsoft.AspNetCore.Mvc;

namespace MVCApp2.Controllers
{
	public class MovieController : Controller
	{
		public ActionResult Start()
		{
			return View();
		}
	}
}
