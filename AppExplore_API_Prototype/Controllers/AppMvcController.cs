using AppExplore_API_Prototype.Model;
using AppExplore_API_Prototype.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AppExplore_API_Prototype.Controllers
{
    public class AppMvcController : Controller
    {
        private readonly IAppRepository _appRepository;

        public AppMvcController(IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }

        public async Task<IActionResult> Index(string searchKeyword = "")
        {
            List<AppModel> apps;

            if (string.IsNullOrWhiteSpace(searchKeyword))
            {
                apps = await _appRepository.GetAllApps();
            }
            else
            {
                apps = await _appRepository.GetKeywordApps(searchKeyword);
            }

            // Pass the current search keyword to the view
            ViewBag.SearchKeyword = searchKeyword;

            return View(apps);
        }
        public async Task<IActionResult> Details(int id)
        {
            var app = await _appRepository.GetAppById(id);
            if (app == null)
                return NotFound();

            return View(app);
        }
    }
}
