using Microsoft.AspNetCore.Mvc;

namespace EmployeeManager.Controllers
{
    public class WorkLoadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
