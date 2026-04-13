using AppExplore_Prototype_Front.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace AppExplore_Prototype_Front.Pages.Home
{
    public class IndexModel : PageModel
    {
        //----------------------------------------//
        //DEFINE LISTS FOR THE MODEL
        //----------------------------------------//
        public string[] SupportedCategories =
        {
            "Music",
            "Social Networking",
            "Navigation",
            "Entertainment",
            "Health and Fitness",
            "Communication",
            "Productivity",
            "Games",
            "Business",
            "Travel",
            "Food and Drink",
            "Finance",
            "Education"
        };

        public string[] SupportedTypes =
        {
            "Apple",
            "Android",
            "Web",
            "Free",
            "Paid",
            "Paid-Premium",
            "Paid-InApp",
            "Membership",
            "Ads",
            "No Paid-Premium"
        };

        [BindProperty(SupportsGet = true)]
        public string SelectedCategory { get; set; } = "";

        [BindProperty]
        public List<string> SelectedTypes { get; set; } = new List<string>();

        [BindProperty]
        public List<string> SelectedTags { get; set; } = new();

        public List<string> AvailableTags { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public string SearchQuery { get; set; }


        public void OnGet()
        {
            //Check the selected category & adjust visible tags based on category
            if (!string.IsNullOrWhiteSpace(SelectedCategory) &&
            AppTagDictionary.CategoryTags.ContainsKey(SelectedCategory))
            {
                AvailableTags = AppTagDictionary.CategoryTags[SelectedCategory];
            }
        }

        public IActionResult OnGetTags(string category)
        {
            if (string.IsNullOrWhiteSpace(category))
                return new JsonResult(new List<string>());

            if (AppTagDictionary.CategoryTags.TryGetValue(category, out var tags))
            {
                return new JsonResult(tags);
            }

            return new JsonResult(new List<string>());
        }
    }
}
