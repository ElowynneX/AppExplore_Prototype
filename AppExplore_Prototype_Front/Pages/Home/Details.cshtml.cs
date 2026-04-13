using AppExplore_Prototype_Front.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppExplore_Prototype_Front.Pages.Home
{
    public class DetailsModel : PageModel
    {
        private readonly AppApiService _apiService;

        public DetailsModel(AppApiService apiService)
        {
            _apiService = apiService;
        }

        public string ImageConnectionString = "https://localhost:7157";

        public AppModel App { get; set; }

        public async Task OnGetAsync(int id)
        {
            App = await _apiService.GetAppByIdAsync(id);
        }
    }
}
