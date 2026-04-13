using AppExplore_Prototype_Front.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppExplore_Prototype_Front.Pages.Home
{
    public class ResultsModel : PageModel
    {
        //THE IMPORTANT PART

        private readonly AppApiService _apiService;

        public ResultsModel(AppApiService apiService)
        {
            _apiService = apiService;
        }

        public string ImageConnectionString = "https://localhost:7157";

        [BindProperty(SupportsGet = true)]
        public string SearchQuery { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SelectedCategory { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedTypes { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedTags { get; set; }

        public List<AppModel> Results { get; set; }

        public async Task OnGetAsync()
        {
            if (string.IsNullOrWhiteSpace(SearchQuery) &&
                string.IsNullOrWhiteSpace(SelectedCategory) &&
                (SelectedTags == null || SelectedTags.Count == 0) &&
                (SelectedTypes == null || SelectedTypes.Count == 0))
            {
                Results = new List<AppModel>();
                return;
            }

            var filters = new FilterDto
            {
                SearchCategory = SelectedCategory,
                SearchType = SelectedTypes ?? new List<string>(),
                SearchTags = SelectedTags ?? new List<string>()
            };

            Results = await _apiService.FilterAppsAsync(filters);
        }
    }
}


/*
 public IActionResult Create()
        {
            //Validate Admin authority
            var redirect = CheckAdminStatus();
            if (redirect != null)
                return redirect;

            //Define clients and tokens
            var client = _httpClientFactory.CreateClient();
            var token = HttpContext.Session.GetString("JWToken");

            if (token != null)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            //Retrieve list of user IDs
            var response = client.GetAsync($"https://localhost:5001/api/users/ids");

            if (response.Result.IsSuccessStatusCode)
            {
                var users = response.Result.Content.ReadFromJsonAsync<List<int>>().Result;

                var appTaskViewModel = new CreateAppTaskViewModel
                {
                    UserOptions = users.Select(id => new SelectListItem
                    {
                        Value = id.ToString(),
                        Text = $"User #{id}"
                    }).ToList()
                };

                return View(appTaskViewModel);
            }

            return RedirectToAction("Dashboard", "Admin");
        }
 */