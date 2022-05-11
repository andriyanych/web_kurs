using Microsoft.AspNetCore.Mvc;
using web_app.Domain;

namespace web_app.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }

        public IActionResult Targets()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageTargets"));
        }
        public IActionResult Sources()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageSources"));
        }
        public IActionResult Theory()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageTheory"));
        }
        public IActionResult Plan()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PagePlan"));
        }
        public IActionResult Tests()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageTests"));
        }        

    }
}