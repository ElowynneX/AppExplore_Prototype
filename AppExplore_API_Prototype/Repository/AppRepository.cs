using AppExplore_API_Prototype.Data;
using AppExplore_API_Prototype.Model;
using Microsoft.EntityFrameworkCore;

namespace AppExplore_API_Prototype.Repository
{
    public class AppRepository : IAppRepository
    {
        private readonly AppDbContext _appDbContext;

        public AppRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<AppModel>> GetAllApps()
        {
            return await _appDbContext.Apps.ToListAsync();
        }

        public async Task<AppModel> GetAppById(int id)
        {
            return await _appDbContext.Apps.FindAsync(id);
        }

        public async Task<List<AppModel>> GetFilteredApps(FilterDto filters)
        {
            var apps = await _appDbContext.Apps.ToListAsync();

            // Category
            if (!string.IsNullOrWhiteSpace(filters.SearchCategory))
            {
                apps = apps
                    .Where(a => a.Category == filters.SearchCategory)
                    .ToList();
            }

            // Type
            if (filters.SearchType?.Any() == true)
            {
                apps = apps
                    .Where(a => a.Type.Any(t => filters.SearchType.Contains(t)))
                    .ToList();
            }

            // Tags
            if (filters.SearchTags?.Any() == true)
            {
                apps = apps
                    .Where(a => a.Tags.Any(tag => filters.SearchTags.Contains(tag)))
                    .ToList();
            }

            return apps;
        }

        public async Task<List<AppModel>> GetKeywordApps(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return await _appDbContext.Apps.ToListAsync();

            keyword = keyword.ToLower();

            var apps = await _appDbContext.Apps.ToListAsync(); // pull all apps into memory

            return apps.Where(app =>
                (app.Title != null && app.Title.ToLower().Contains(keyword)) ||
                (app.Description != null && app.Description.ToLower().Contains(keyword)) //||
                //(app.Developer != null && app.Developer.ToLower().Contains(keyword)) ||
                //(app.Category != null && app.Category.ToLower().Contains(keyword)) ||
                //(app.Tags != null && app.Tags.Any(tag => tag.ToLower().Contains(keyword))) ||
                //(app.Type != null && app.Type.Any(t => t.ToLower().Contains(keyword)))
            ).ToList();
        }
    }
}
