using AppExplore_API_Prototype.Model;
using AppExplore_API_Prototype.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppExplore_API_Prototype.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        private readonly IAppRepository _appRepository;

        public AppController(IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }

        //HTTP Functions
        [HttpGet]
        public async Task<IActionResult> GetAllApps()
        {
            List<AppModel> apps = await _appRepository.GetAllApps();
            return Ok(apps);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppById(int id)
        {
            var app = await _appRepository.GetAppById(id);

            if (app == null)
            {
                return NotFound();
            }

            return Ok(app);
        }

        [HttpPost("filter")]
        public async Task<IActionResult> FilterApps([FromBody] FilterDto filter)
        {
            if (filter == null)
                return BadRequest("Filter criteria is required.");

            var apps = await _appRepository.GetFilteredApps(filter);

            return Ok(apps);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchApps([FromQuery] string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return BadRequest("Search keyword is required.");

            var results = await _appRepository.GetKeywordApps(keyword);

            return Ok(results);
        }
    }
}
